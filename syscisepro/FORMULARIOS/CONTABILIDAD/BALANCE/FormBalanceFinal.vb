Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit
Imports ClosedXML.Excel
Imports System.IO

Namespace FORMULARIOS.CONTABILIDAD.BALANCE
 ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBalanceFinal
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

        Dim objPlanCuentas As New ClassPlanDeCuentas

        Private SelectedRangeT As Integer
        Private Rango As String
        Private FechaDesdeT As DateTime
        Private FechaHastaT As DateTime
        Private ShowColumnsT As Integer
        Private Columnas As String
        Private Anterior As Boolean
        Private CambioAnterior As Boolean
        Private PorcentajeAnterior As Boolean
        Private Previo As Boolean
        Private CambioPrevio As Boolean
        Private PorcentajePrevio As Boolean

        Private Sub FormBalanceFinal_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava 
                    dgvMayores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac 
                    dgvMayores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro 
                    dgvMayores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvMayores.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvMayores.ContextMenuStrip = Me.ContextMenuStripClicDerecho
            cbNivel.SelectedIndex = 0
            cbxDates.SelectedIndex = 3
        End Sub

        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            'dgvMayores.DataSource = Nothing

            'Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00"
            'Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59"

            'dgvMayores.DataSource = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinalMensual2(_tipoCon, dtpInicio.Value.Year)

            'dgvMayores.Columns(0).Width = 25
            'dgvMayores.Columns("CODIGO").Width = 80
            'dgvMayores.Columns("CUENTA").Width = 510
            'dgvMayores.Columns("INICIAL").Width = 75
            'dgvMayores.Columns("INICIAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'dgvMayores.Columns("DEBE").Width = 75
            'dgvMayores.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'dgvMayores.Columns("HABER").Width = 75
            'dgvMayores.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'dgvMayores.Columns("SALDO").Width = 75
            'dgvMayores.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            'dgvMayores.Columns("NIVEL").Width = 40
            'dgvMayores.Columns("PADRE").Width = 80

            'Dim auxData As DataTable = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinal2(_tipoCon, fechaDesde, fechaHasta)

            ''SE COPIA LA DATA, SE PINTA Y CALCULA SALDO (CUENTA POR CUENTA)
            'For Each row As DataGridViewRow In dgvMayores.Rows

            '    If (row.Cells("INICIAL").Value & "").ToString().Length = 0 Then row.Cells("INICIAL").Value = "0.00"

            '    Select Case row.Cells.Item("NIVEL").Value.ToString
            '        Case "7" : row.DefaultCellStyle.BackColor = Color.AliceBlue
            '        Case "6" : row.DefaultCellStyle.BackColor = Color.GhostWhite
            '        Case "5" : row.DefaultCellStyle.BackColor = Color.White
            '        Case "4" : row.DefaultCellStyle.BackColor = Color.SkyBlue
            '        Case "3" : row.DefaultCellStyle.BackColor = Color.LightBlue
            '        Case "2" : row.DefaultCellStyle.BackColor = Color.PowderBlue
            '        Case "1" : row.DefaultCellStyle.BackColor = Color.LightCyan
            '    End Select

            '    For Each drow As DataRow In auxData.Rows
            '        If row.Cells("CODIGO").Value = drow("CODIGO") Then
            '            row.Cells("DEBE").Value = drow("DEBE")
            '            row.Cells("HABER").Value = drow("HABER")
            '            row.Cells("SALDO").Value = drow("SALDO")
            '        End If
            '    Next

            'Next



            '' SE COPIA LA DATA ambas estructuras tiene debe, haber y saldo por nivel (auxiliar)
            'auxData = CType(dgvMayores.DataSource, DataTable)

            '' SE CALCULA LOS SALDOS TODOS LOS NIVELES (ACUMULADO NIVELES)
            'For i = 7 To 1 Step -1
            '    For Each row As DataGridViewRow In dgvMayores.Rows
            '        For Each drow As DataRow In auxData.Rows
            '            If row.Cells("CODIGO").Value = drow("PADRE") And drow("NIVEL") = i Then
            '                row.Cells("INICIAL").Value = Math.Round((CType(row.Cells("INICIAL").Value, Double) + CType(drow("INICIAL"), Double)), 2)

            '                row.Cells("DEBE").Value = Math.Round((CType(row.Cells("DEBE").Value, Double) + CType(drow("DEBE"), Double)), 2)
            '                row.Cells("HABER").Value = Math.Round((CType(row.Cells("HABER").Value, Double) + CType(drow("HABER"), Double)), 2)
            '                row.Cells("SALDO").Value = Math.Round((CType(row.Cells("SALDO").Value, Double) + CType(drow("SALDO"), Double)), 2)
            '            End If

            '            'verificar nodos
            '            If row.Cells("CODIGO").Value = drow("PADRE") Then
            '                row.Cells("nodo").Value = "-"
            '            End If
            '        Next
            '    Next
            '    auxData = CType(dgvMayores.DataSource, DataTable)
            'Next




            '' PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER 
            'Dim activo As Decimal = 0.0
            'Dim pasivo As Decimal = 0.0
            'Dim capital As Decimal = 0.0
            'If dgvMayores.Rows.Count > 0 Then
            '    For index = 0 To dgvMayores.Rows.Count - 1 Step 1
            '        If dgvMayores.Rows(index).Cells("CUENTA").Value = "ACTIVO" Then
            '            activo = activo + dgvMayores.Rows(index).Cells("SALDO").Value
            '        ElseIf dgvMayores.Rows(index).Cells("CUENTA").Value = "PASIVO" Then
            '            pasivo = pasivo + dgvMayores.Rows(index).Cells("SALDO").Value
            '        ElseIf dgvMayores.Rows(index).Cells("CUENTA").Value = "PATRIMONIO NETO" Then
            '            capital = capital + dgvMayores.Rows(index).Cells("SALDO").Value
            '        End If
            '    Next
            '    txtDeudor.Text = activo
            '    txtAcreedor.Text = pasivo
            '    txtCapital.Text = capital
            '    txtUtilidad.Text = Math.Abs(activo + pasivo + capital)
            'End If


            'txtDeudor.Text = activo.ToString()
            'txtAcreedor.Text = pasivo.ToString()
            'txtCapital.Text = capital.ToString()


            'dgvMayores.AutoResizeRows()

            ''Asignar el valor de la utilidad a la cuenta contable
            'Dim utilidad = activo + pasivo + capital

            'Dim utilidadAux As Double = Convert.ToDouble(txtUtilidad.Text.Trim)

            'If (utilidad > 0) Then
            '    lblUtilidadPerdida.Text = "UTILIDAD"
            '    lblUtilidadPerdida.ForeColor = Color.Navy

            '    For index = 0 To dgvMayores.Rows.Count - 1 Step 1
            '        If dgvMayores.Rows(index).Cells("CODIGO").Value = "3" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "307" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "30701" Then
            '            dgvMayores.Rows(index).Cells("HABER").Value = Math.Round(dgvMayores.Rows(index).Cells("HABER").Value + utilidadAux, 2)
            '            dgvMayores.Rows(index).Cells("SALDO").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value - dgvMayores.Rows(index).Cells("HABER").Value, 2)
            '        End If
            '    Next

            'ElseIf (utilidad + capital < 0) Then
            '    lblUtilidadPerdida.Text = "PERDIDA"
            '    lblUtilidadPerdida.ForeColor = Color.Red

            '    For index = 0 To dgvMayores.Rows.Count - 1 Step 1
            '        If dgvMayores.Rows(index).Cells("CODIGO").Value = "3" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "307" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "30702" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "3070201" Then
            '            dgvMayores.Rows(index).Cells("DEBE").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value + utilidadAux, 2)
            '            dgvMayores.Rows(index).Cells("SALDO").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value - dgvMayores.Rows(index).Cells("HABER").Value, 2)
            '        End If
            '    Next

            'Else
            '    lblUtilidadPerdida.Text = "UTILIDAD"
            '    lblUtilidadPerdida.ForeColor = Color.Navy
            'End If



            ''dgvMayores.AutoResizeRows()
            'CantidadReistros()
            'chkTodos.Checked = False


            'Limpiar DataSource
            dgvMayores.DataSource = Nothing

            'Formateo de fechas optimizado
            'Dim fechaDesde As String = $"{dtpInicio.Value.Day}-{dtpInicio.Value.Month}-{dtpInicio.Value.Year} 00:00:00"
            'Dim fechaHasta As String = $"{dtpFinal.Value.Day}-{dtpFinal.Value.Month}-{dtpFinal.Value.Year} 23:59:59"

            Dim fechaDesde = New Date(dtpInicio.Value.Year, dtpInicio.Value.Month, dtpInicio.Value.Day, 0, 0, 0)
            Dim fechaHasta = New Date(dtpFinal.Value.Year, dtpFinal.Value.Month, dtpFinal.Value.Day, 23, 59, 59)

            'Cargar DATOS principales
            dgvMayores.DataSource = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinalMensual2(_tipoCon, dtpInicio.Value.Year)

            'Configuración de columnas (igual al original)
            With dgvMayores
                .Columns(0).Width = 25
                .Columns("CODIGO").Width = 80
                .Columns("CUENTA").Width = 510
                .Columns("INICIAL").Width = 75
                .Columns("INICIAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns("DEBE").Width = 75
                .Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns("HABER").Width = 75
                .Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns("SALDO").Width = 75
                .Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns("NIVEL").Width = 40
                .Columns("PADRE").Width = 80
            End With

            'Obtener DATOS auxiliares
            Dim auxData As DataTable = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinal2(_tipoCon, fechaDesde, fechaHasta)

            'Paso 1: Pintar filas y actualizar valores desde auxData (optimizado con diccionario)
            Dim lookupAuxData As New Dictionary(Of String, DataRow)
            For Each dr As DataRow In auxData.Rows
                lookupAuxData(dr("CODIGO").ToString()) = dr
            Next

            For Each row As DataGridViewRow In dgvMayores.Rows
                'Inicializar valor inicial
                If String.IsNullOrEmpty(row.Cells("INICIAL").Value?.ToString()) Then
                    row.Cells("INICIAL").Value = "0.00"
                End If

                'Colorear filas(misma lógica)
                Select Case row.Cells("NIVEL").Value.ToString()
                    Case "7" : row.DefaultCellStyle.BackColor = Color.AliceBlue
                    Case "6" : row.DefaultCellStyle.BackColor = Color.GhostWhite
                    Case "5" : row.DefaultCellStyle.BackColor = Color.White
                    Case "4" : row.DefaultCellStyle.BackColor = Color.SkyBlue
                    Case "3" : row.DefaultCellStyle.BackColor = Color.LightBlue
                    Case "2" : row.DefaultCellStyle.BackColor = Color.PowderBlue
                    Case "1" : row.DefaultCellStyle.BackColor = Color.LightCyan
                End Select

                'Actualizar desde auxData (optimizado)
                Dim codigo As String = row.Cells("CODIGO").Value.ToString()
                If lookupAuxData.ContainsKey(codigo) Then
                    Dim dr As DataRow = lookupAuxData(codigo)
                    row.Cells("DEBE").Value = dr("DEBE")
                    row.Cells("HABER").Value = dr("HABER")
                    row.Cells("SALDO").Value = dr("SALDO")
                End If
            Next

            'Paso 2: Cálculo de saldos acumulados (misma lógica pero optimizado)
            Dim currentData As DataTable = CType(dgvMayores.DataSource, DataTable)

            For i As Integer = 7 To 1 Step -1
                Dim view As New DataView(currentData, $"NIVEL = {i}", "", DataViewRowState.CurrentRows)

                For Each rowView As DataRowView In view
                    Dim padre As String = rowView("PADRE").ToString()
                    Dim rowsPadre As DataRow() = currentData.Select($"CODIGO = '{padre}'")

                    If rowsPadre.Length > 0 Then
                        Dim rowPadre As DataRow = rowsPadre(0)
                        rowPadre("INICIAL") = Math.Round(CDbl(rowPadre("INICIAL")) + CDbl(rowView("INICIAL")), 2)
                        rowPadre("DEBE") = Math.Round(CDbl(rowPadre("DEBE")) + CDbl(rowView("DEBE")), 2)
                        rowPadre("HABER") = Math.Round(CDbl(rowPadre("HABER")) + CDbl(rowView("HABER")), 2)
                        rowPadre("SALDO") = Math.Round(CDbl(rowPadre("SALDO")) + CDbl(rowView("SALDO")), 2)


                    End If
                Next
                currentData.AcceptChanges()
            Next

            'Ahora actualizamos 'nodo' solo en el DataGridView (si existe como columna visual)
            For Each row As DataGridViewRow In dgvMayores.Rows
                Dim codigoActual As String = row.Cells("CODIGO").Value.ToString()

                'Verificar si es padre de algún registro
                If currentData.Select($"PADRE = '{codigoActual}'").Length > 0 Then
                    row.Cells("nodo").Value = "-" ' Solo si 'nodo' existe en el DataGridView
                End If
            Next

            'Paso 3: Cálculo de totales (misma lógica)
            Dim activo As Decimal = 0D
            Dim pasivo As Decimal = 0D
            Dim capital As Decimal = 0D

            For Each row As DataGridViewRow In dgvMayores.Rows
                Select Case row.Cells("CUENTA").Value.ToString()
                    Case "ACTIVO" : activo += CDec(row.Cells("SALDO").Value)
                    Case "PASIVO" : pasivo += CDec(row.Cells("SALDO").Value)
                    Case "PATRIMONIO NETO" : capital += CDec(row.Cells("SALDO").Value)
                End Select
            Next

            'Asignación de totales (igual al original)
            txtDeudor.Text = activo.ToString()
            txtAcreedor.Text = pasivo.ToString()
            txtCapital.Text = capital.ToString()
            txtUtilidad.Text = Math.Abs(activo + pasivo + capital).ToString()

            'Paso 4: Ajuste de utilidad (misma lógica exacta)
            Dim utilidad As Double = CDbl(txtUtilidad.Text.Trim)
            Dim targetCodes As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            If utilidad > 0 Then
                lblUtilidadPerdida.Text = "UTILIDAD"
                lblUtilidadPerdida.ForeColor = Color.Navy
                targetCodes.UnionWith({"3", "307", "30701"})
            ElseIf (utilidad + capital) < 0 Then
                lblUtilidadPerdida.Text = "PERDIDA"
                lblUtilidadPerdida.ForeColor = Color.Red
                targetCodes.UnionWith({"3", "307", "30702", "3070201"})
            Else
                lblUtilidadPerdida.Text = "UTILIDAD"
                lblUtilidadPerdida.ForeColor = Color.Navy
            End If

            For Each row As DataGridViewRow In dgvMayores.Rows
                Dim codigo As String = row.Cells("CODIGO").Value.ToString()
                If targetCodes.Contains(codigo) Then
                    If utilidad > 0 Then
                        row.Cells("HABER").Value = Math.Round(CDbl(row.Cells("HABER").Value) + utilidad, 2)
                    Else
                        row.Cells("DEBE").Value = Math.Round(CDbl(row.Cells("DEBE").Value) + Math.Abs(utilidad), 2)
                    End If
                    row.Cells("SALDO").Value = Math.Round(CDbl(row.Cells("DEBE").Value) - CDbl(row.Cells("HABER").Value), 2)
                End If
            Next

            'Finalizar
            dgvMayores.AutoResizeRows()
            CantidadReistros()
            chkTodos.Checked = False


        End Sub

        Private Sub CantidadReistros()
            Dim v1 As Integer = 0
            Dim o1 As Integer = 0
            For Each row As DataGridViewRow In dgvMayores.Rows
                If row.Visible Then
                    v1 += 1
                Else
                    o1 += 1
                End If
            Next
            LbCount1.Text = v1 & " REGISTRO(S)"
        End Sub

        '=== PARA EXPORTAR EN EXCEL ===================================================================================================================================================
        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    'MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If



                '' TOTALES, ETC
                'Dim footin = headin + dgvAsientosDiario.RowCount + 3
                'worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Merge()
                'worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Value = "TOTAL BALANCE FINAL"
                'worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Font.Bold = True

                'worksheet.Cells(footin + 2, 2).Value = "ACTIVO:"
                'worksheet.Cells(footin + 2, 2).Font.Bold = True
                'worksheet.Cells(footin + 2, 6).Value = txtDeudor.Text

                'worksheet.Cells(footin + 3, 2).Value = "PASIVO:"
                'worksheet.Cells(footin + 3, 2).Font.Bold = True
                'worksheet.Cells(footin + 3, 6).Value = txtAcreedor.Text

                'worksheet.Cells(footin + 4, 2).Value = "PATRIMONIO:"
                'worksheet.Cells(footin + 4, 2).Font.Bold = True
                'worksheet.Cells(footin + 4, 6).Value = txtCapital.Text

                'worksheet.Cells(footin + 5, 2).Value = lblUtilidadPerdida.Text.Trim
                'worksheet.Cells(footin + 5, 2).Font.Bold = True
                'worksheet.Cells(footin + 5, 6).Value = txtUtilidad.Text

                'worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                'app.DisplayAlerts = False
                'app.Visible = True
                'app.DisplayAlerts = True


                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
                saveFileDialog.Title = "Guardar archivo Excel"
                saveFileDialog.FileName = $"{titulo}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"


                If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                    Exit Sub
                End If



                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim tituloReporte = ValidationForms.NombreCompany(_tipoCon) & " - " & titulo

                ' Crear workbook y worksheet
                Dim workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("Balance_Final")
                Dim colorSistema As System.Drawing.Color = ValidationForms.GetColorSistema(_tipoCon)
                Dim xlColor As XLColor = xlColor.FromColor(colorSistema)

                ' Definir rango para el título
                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Cell(1, 1).Value = tituloReporte.ToString()
                worksheet.Cell(1, 1).Style.Font.SetBold(True)
                worksheet.Cell(1, 1).Style.Font.SetFontSize(12)
                worksheet.Cell(1, 1).Style.Font.SetFontColor(xlColor.White)
                worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(xlColor)
                worksheet.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)

                ' Copete
                worksheet.Range("A2:" & ic & "2").Merge()
                'worksheet.Cell(2, 1).Value = $"{cmbBancos.Text} CTA: {cmbCuentaBancos.Text}, PERÍODO: {dtpDesde.Value.ToLongDateString()} AL {dtpHasta.Value.ToLongDateString()}"
                worksheet.Cell(2, 1).Value = "PERÍODO: " & dtpInicio.Value.ToLongDateString() & "  AL " & dtpFinal.Value.ToLongDateString()
                worksheet.Cell(2, 1).Style.Font.SetFontSize(12)

                ' Fecha
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Cell(3, 1).Value = $"Fecha de Reporte: {fec.ToLongDateString()} {fec.ToLongTimeString()}"
                worksheet.Cell(3, 1).Style.Font.SetFontSize(12)

                ' Encabezados de columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cell(headin, indc).Value = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cell(headin, indc).Style.Font.SetBold(True)
                    worksheet.Cell(headin, indc).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    worksheet.Cell(headin, indc).Style.Fill.SetBackgroundColor(xlColor)
                    worksheet.Cell(headin, indc).Style.Font.SetFontColor(xlColor.White)
                    worksheet.Cell(headin, indc).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    indc += 1
                Next

                Dim quitarCeros As Boolean = chkTodos.Checked
                Dim columnasContable As String() = {"DEBE", "HABER", "SALDO"}
                Dim filaExcel As Integer = 1 + headin
                ' Detalle de datos
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    'Verificar si las columansContables esan en cero
                    Dim omitirFila As Boolean = True

                    For Each colName In columnasContable
                        Dim colIndex As Integer = dgvAsientosDiario.Columns(colName).Index
                        Dim cellValue = dgvAsientosDiario.Rows(i).Cells(colIndex).Value
                        If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) AndAlso CDbl(cellValue) <> 0 Then
                            omitirFila = False
                            Exit For
                        End If
                    Next

                    ' Si la fila debe omitirse, saltar a la siguiente iteración
                    If quitarCeros AndAlso omitirFila Then Continue For



                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1
                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        ' Obtener el valor de la celda
                        Dim cellValue = dgvAsientosDiario.Rows(i).Cells(j).Value
                        Dim cell = worksheet.Cell(filaExcel, indc)
                        Dim columnName As String = dgvAsientosDiario.Columns(j).HeaderText
                        ' Validar si el valor de la celda no es Nothing
                        If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                            If columnasContable.Contains(columnName) Then
                                cell.Value = CDbl(cellValue)
                                cell.Style.NumberFormat.Format = "#,##0.00"

                            Else

                                cell.Value = CDbl(cellValue)
                            End If

                        Else

                            cell.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)

                        End If

                        ' Establecer bordes
                        'Dim cell = worksheet.Cell(i + 1 + headin, indc)
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        If i = dgvAsientosDiario.RowCount - 1 Then
                            cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                        End If

                        indc += 1
                    Next
                    filaExcel += 1
                Next

                ' TOTALES
                Dim footin = headin + dgvAsientosDiario.RowCount + 3
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Merge()
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Value = "TOTAL BALANCE FINAL"
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Style.Font.SetBold(True)

                worksheet.Cell(footin + 2, 2).Value = "ACTIVO:"
                worksheet.Cell(footin + 2, 2).Style.Font.SetBold(True)
                worksheet.Cell(footin + 2, 6).Value = txtDeudor.Text

                worksheet.Cell(footin + 3, 2).Value = "PASIVO:"
                worksheet.Cell(footin + 3, 2).Style.Font.SetBold(True)
                worksheet.Cell(footin + 3, 6).Value = txtAcreedor.Text

                worksheet.Cell(footin + 4, 2).Value = "PATRIMONIO:"
                worksheet.Cell(footin + 4, 2).Style.Font.SetBold(True)
                worksheet.Cell(footin + 4, 6).Value = txtCapital.Text

                worksheet.Cell(footin + 5, 2).Value = lblUtilidadPerdida.Text.Trim()
                worksheet.Cell(footin + 5, 2).Style.Font.SetBold(True)
                worksheet.Cell(footin + 5, 6).Value = txtUtilidad.Text


                ' Ajustar columnas automáticamente
                worksheet.Columns("A:" & ic).AdjustToContents()

                ' Guardar el archivo en una ubicación temporal y abrirlo
                Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), saveFileDialog.FileName)
                ' Guardar el archivo en una ubicación temporal
                workbook.SaveAs(saveFileDialog.FileName)

                ' Abrir el archivo Excel automáticamente
                Process.Start(tempFilePath)

                KryptonMessageBox.Show("Datos exportados correctamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)




            Catch ex As Exception

                KryptonMessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try

        End Sub

        '=== PARA EXPORTAR DATOS A EXCEL =============================================================================================================================================
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvMayores, "BALANCE FINAL")
        End Sub

        '=============================================================================================================================================================================
        Private Sub tsmOcultar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmOcultar.Click
            Dim indice As Integer = 0
            If dgvMayores.Rows.Count > 0 Then
                For indice = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value > dgvMayores.CurrentRow.Cells.Item(5).Value Then
                        dgvMayores.Rows(indice).Visible = False
                    End If
                Next
            Else
            End If
        End Sub

        Private Sub tsmMostrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmMostrar.Click
            Dim indice = 0
            If dgvMayores.Rows.Count > 0 Then
                For indice = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value <> dgvMayores.CurrentRow.Cells.Item(5).Value Then
                        dgvMayores.Rows(indice).Visible = True
                    End If
                Next
            Else
            End If
        End Sub
         
        Private Sub btnArbol_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnArbol.Click
            Try
                If dgvMayores.RowCount = 0 Then

                    KryptonMessageBox.Show("Primero debe cargar el balance", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                tvBalanceComprobacion.BeginUpdate()

                Dim nivel1 As TreeNode = tvBalanceComprobacion.Nodes.Add("CUENTAS", "BALANCE FINAL")
                Dim nivel2 As TreeNode = Nothing
                Dim nivel3 As TreeNode = Nothing
                Dim nivel4 As TreeNode = Nothing
                Dim nivel5 As TreeNode = Nothing
                Dim nivel6 As TreeNode = Nothing
                Dim nivel7 As TreeNode = Nothing
                Dim nivel8 As TreeNode = Nothing

                Dim indice As Integer = 0
                For indice = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value = "1" Then
                        nivel2 = añadirNodo(nivel1, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                    End If
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value = "2" Then
                        nivel3 = añadirNodo(nivel2, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                    End If
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value = "3" Then
                        nivel4 = añadirNodo(nivel3, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                    End If
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value = "4" Then
                        nivel5 = añadirNodo(nivel4, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                    End If
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value = "5" Then
                        nivel6 = añadirNodo(nivel5, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                    End If
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value = "6" Then
                        nivel7 = añadirNodo(nivel6, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                    End If
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value = "7" Then
                        nivel8 = añadirNodo(nivel7, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                    End If
                Next

                tvBalanceComprobacion.EndUpdate()
                tcAuxiliares.SelectedIndex = 1

                KryptonMessageBox.Show("Árbol generado con éxtio", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Catch esxception As Exception

                KryptonMessageBox.Show("Error al generar árbol: " & esxception.Message, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Function añadirNodo(ByVal node As TreeNode, ByVal padre As String, ByVal cuenta As String) As TreeNode
            Return node.Nodes.Add(padre, cuenta)
        End Function

        '===================================================================================================================================================================================================================
        Private Sub cbNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbNivel.SelectedIndexChanged
            FiltrarNiveles(cbNivel.SelectedIndex)
        End Sub

        Private Sub FiltrarNiveles(ByVal nivel As Integer)
            cbNivel.SelectedIndex = nivel
            dgvMayores.CurrentCell = Nothing
            ' balance
            For indiceBalance = 0 To dgvMayores.Rows.Count - 1
                If nivel <> 0 And dgvMayores.Rows(indiceBalance).Cells("NIVEL").Value > nivel Then
                    dgvMayores.Rows(indiceBalance).Visible = False
                Else
                    dgvMayores.Rows(indiceBalance).Visible = True
                End If
            Next

            chkTodos.Checked = False

            CantidadReistros()
        End Sub

        Private Sub dgvMayoresHijos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMayores.CellClick
            Try
                If dgvMayores.Columns(e.ColumnIndex).Name = "nodo" AndAlso Me.dgvMayores.Rows(e.RowIndex).IsNewRow = False Then
                    ' si el nodo esta desplegado
                    If dgvMayores.CurrentRow.Cells("nodo").Value = "-" Then
                        For indiceNodo = 0 To dgvMayores.Rows.Count - 1
                            ' si el valor del nodo cliqueado forma parte de la cadena de las demas celdas (hijos, nietos, visnietos, etc.)
                            If Mid(dgvMayores.Rows(indiceNodo).Cells("PADRE").Value, 1, dgvMayores.CurrentRow.Cells("CODIGO").Value.ToString.Length) = dgvMayores.CurrentRow.Cells("CODIGO").Value Then
                                ' ocultamos la fila
                                dgvMayores.Rows(indiceNodo).Visible = False
                                ' si la fila es sub nodo 
                                If dgvMayores.Rows(indiceNodo).Cells("nodo").Value = "-" Then
                                    ' cambia el estado del nodo a contraido
                                    dgvMayores.Rows(indiceNodo).Cells("nodo").Value = "+"
                                End If
                            End If
                        Next
                        ' cambia el estado del nodo a contraido
                        dgvMayores.CurrentRow.Cells("nodo").Value = "+"

                    ElseIf dgvMayores.CurrentRow.Cells("nodo").Value = "+" Then ' si el nodo esta contraido
                        For indiceNodo = 0 To dgvMayores.Rows.Count - 1
                            ' si la fila es parte del nodo liqueado
                            If dgvMayores.Rows(indiceNodo).Cells("PADRE").Value = dgvMayores.CurrentRow.Cells("CODIGO").Value Then
                                ' mostramos la fila
                                dgvMayores.Rows(indiceNodo).Visible = True
                            End If
                        Next
                        ' cambia el estado del nodo a desplegado
                        dgvMayores.CurrentRow.Cells("nodo").Value = "-"
                    Else ' no es nodo
                        dgvMayores.CurrentRow.Cells("nodo").Value = ""
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.Message.ToString)
                KryptonMessageBox.Show(ex.Message.ToString, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
         
        Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTodos.CheckedChanged
            dgvMayores.CurrentCell = Nothing

            If chkTodos.Checked Then
                For Each row As DataGridViewRow In dgvMayores.Rows
                    If row.Cells("DEBE").Value < 0.01 And row.Cells("HABER").Value <= 0.01 And row.Cells("SALDO").Value <= 0.01 And row.Visible Then
                        row.Visible = False
                    End If
                Next
            Else
                For Each row As DataGridViewRow In dgvMayores.Rows
                    If cbNivel.SelectedIndex = 0 Then
                        row.Visible = True
                    Else
                        If Not row.Visible And row.Cells("NIVEL").Value <= cbNivel.SelectedIndex Then
                            row.Visible = True
                        End If
                    End If
                Next

            End If

            CantidadReistros()
        End Sub

        Private Sub txtCapital_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCapital.TextChanged

        End Sub

        Private Sub cbxDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDates.SelectedIndexChanged
            Dim selectedRange As String = cbxDates.SelectedItem.ToString()

            Select Case selectedRange.Trim()
                Case "Mensual"
                    ' Desde el primer día del mes actual
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1)
                    dtpFechaHastaMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, Date.DaysInMonth(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month))
                    Rango = "Mensual"
                    FechaDesdeT = dtpFechaDesdeMes.Value
                    FechaHastaT = dtpFechaHastaMes.Value
                Case "Trimestral"
                    ' Desde el primer día del mes, restando 2 meses (para cubrir 3 meses en total)
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1).AddMonths(-2)
                    Rango = "Trimestral"
                    FechaDesdeT = dtpFechaDesdeMes.Value
                    FechaHastaT = dtpFechaHastaMes.Value

                Case "Semestral"
                    ' Desde el primer día del mes, restando 5 meses (para cubrir 6 meses en total)
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1).AddMonths(-5)
                    Rango = "Semestral"
                    FechaDesdeT = dtpFechaDesdeMes.Value
                    FechaHastaT = dtpFechaHastaMes.Value

                Case "Anual"
                    ' Desde el primer día del mes, restando 1 año
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year - 1, dtpFechaHastaMes.Value.Month, dtpFechaHastaMes.Value.Day)
                    Rango = "Anual"
                    FechaDesdeT = dtpFechaDesdeMes.Value
                    FechaHastaT = dtpFechaHastaMes.Value


                Case "Custom"
                    ' No hacer cambios en las fechas, el usuario las define manualmente
            End Select

            ' Actualizar cbxShowColumns
            'UpdateCbxShowColumns()

            callReport()

        End Sub

        Private Sub callReport()

            Try

                Dim Balance As DataTable

                dgvComparacion.DataSource = Nothing

                FechaDesdeT = New Date(FechaDesdeT.Year, FechaDesdeT.Month, FechaDesdeT.Day, 0, 0, 0)
                FechaHastaT = New Date(FechaHastaT.Year, FechaHastaT.Month, FechaHastaT.Day, 23, 59, 59)

                If cbxShowColumns.SelectedIndex = 0 Then
                    Columnas = "Mensual"
                ElseIf cbxShowColumns.SelectedIndex = 1 Then
                    Columnas = "Trimestral"
                ElseIf cbxShowColumns.SelectedIndex = 2 Then
                    Columnas = "Semestral"
                ElseIf cbxShowColumns.SelectedIndex = 3 Then
                    Columnas = "Anual"
                End If


                If Anterior Then
                    Previo = False
                    Balance = objPlanCuentas.SeleccionarBalnceFinalComparativoDinamico(_tipoCon, FechaDesdeT, FechaHastaT, Rango, Columnas, Anterior, Previo, CambioAnterior, PorcentajeAnterior)
                ElseIf Previo Then
                    Anterior = False
                    Balance = objPlanCuentas.SeleccionarBalnceFinalComparativoDinamico(_tipoCon, FechaDesdeT, FechaHastaT, Rango, Columnas, Anterior, Previo, CambioPrevio, PorcentajePrevio)
                Else

                    Balance = objPlanCuentas.SeleccionarBalnceFinalComparativoDinamico(_tipoCon, FechaDesdeT, FechaHastaT, Rango, Columnas, Anterior, Previo, CambioAnterior, PorcentajeAnterior)

                End If
                If Balance IsNot Nothing AndAlso Balance.Rows.Count > 0 Then

                    dgvComparacion.DataSource = Balance
                    dgvComparacion.Columns(0).Width = 25
                    dgvComparacion.Columns("Codigo").Width = 80
                    dgvComparacion.Columns("Cuenta").Width = 180

                    Dim AnchoFijo As Integer = TextRenderer.MeasureText("-10000000.00", dgvComparacion.Font).Width + 5

                    For Each col As DataGridViewColumn In dgvComparacion.Columns

                        ' Si la columna no es Codigo, Cuenta, Nivel o Padre, alinearla a la derecha
                        If col.Name <> "Codigo" AndAlso col.Name <> "Cuenta" AndAlso col.Name <> "Nivel" AndAlso col.Name <> "Padre" Then
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        End If


                        If col.Name.StartsWith("Cambio") Or col.Name.StartsWith("Variacion") Then
                            col.DefaultCellStyle.Format = "N2"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            col.Width = AnchoFijo
                        End If
                    Next

                    AddHandler dgvComparacion.CellFormatting,
                          Sub(sender As Object, e As DataGridViewCellFormattingEventArgs)
                              'Dim dgv As DataGridView = DirectCast(sender, DataGridView)
                              Dim columnName As String = dgvComparacion.Columns(e.ColumnIndex).Name

                              If columnName.StartsWith("Cambio") OrElse columnName.StartsWith("Variacion") Then
                                  If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) Then
                                      ' Dim valorStr As String = e.Value.ToString()
                                      Dim valor As Decimal = 0
                                      ' Intentar convertir el valor a número
                                      If Decimal.TryParse(e.Value.ToString(), valor) Then
                                          If valor > 0 Then
                                              e.CellStyle.ForeColor = Color.Green
                                          ElseIf valor < 0 Then
                                              e.CellStyle.ForeColor = Color.Red
                                          End If
                                      End If
                                  End If
                              End If
                          End Sub

                    For Each row As DataGridViewRow In dgvComparacion.Rows
                        Select Case row.Cells("NIVEL").Value.ToString()
                            Case "7"
                                row.DefaultCellStyle.BackColor = Color.Lavender ' Suave lila
                            Case "6"
                                row.DefaultCellStyle.BackColor = Color.Thistle ' Lila claro
                            Case "5"
                                row.DefaultCellStyle.BackColor = Color.MistyRose ' Rosa pálido
                            Case "4"
                                row.DefaultCellStyle.BackColor = Color.LightSalmon ' Naranja suave
                            Case "3"
                                row.DefaultCellStyle.BackColor = Color.PeachPuff ' Durazno claro
                            Case "2"
                                row.DefaultCellStyle.BackColor = Color.Moccasin ' Amarillo crema
                            Case "1"
                                row.DefaultCellStyle.BackColor = Color.LemonChiffon ' Amarillo pastel
                        End Select
                    Next


                    ' Volver a obtener la data actual de dgvComparacion
                    Dim auxData = CType(dgvComparacion.DataSource, DataTable)



                    'Acumular saldos(sumar nodos) desde el nivel inferior hacia el superior
                    For level As Integer = 7 To 1 Step -1
                        For Each parentRow As DataGridViewRow In dgvComparacion.Rows
                            Dim parentCodigo As String = parentRow.Cells("Codigo").Value.ToString()
                            Dim parentNivel As Integer = Integer.Parse(parentRow.Cells("Nivel").Value.ToString())

                            If parentNivel < level Then
                                For Each childRow As DataRow In auxData.Select("Padre = '" & parentCodigo & "' AND Nivel = '" & level & "'")
                                    For Each col As DataGridViewColumn In dgvComparacion.Columns
                                        If Not (col.Name = "Codigo" OrElse col.Name = "Cuenta" OrElse col.Name = "Nivel" OrElse col.Name = "Padre" OrElse col.Name = "nodoCom" OrElse col.Name.Contains("Variacion")) Then
                                            Dim parentVal As Double = 0, childVal As Double = 0

                                            If parentRow.Cells(col.Name).Value IsNot Nothing AndAlso Not IsDBNull(parentRow.Cells(col.Name).Value) Then
                                                Double.TryParse(parentRow.Cells(col.Name).Value.ToString(), parentVal)
                                            End If

                                            Dim childObj = childRow(col.Name)
                                            If childObj IsNot Nothing AndAlso Not IsDBNull(childObj) Then
                                                Double.TryParse(childObj.ToString(), childVal)
                                            End If

                                            parentRow.Cells(col.Name).Value = Math.Round(parentVal + childVal, 2)
                                        End If
                                    Next

                                    If dgvComparacion.Columns.Contains("nodoCom") Then
                                        parentRow.Cells("nodoCom").Value = "-"
                                    End If
                                Next
                            End If
                        Next

                        auxData = CType(dgvComparacion.DataSource, DataTable)
                    Next

                    ' --- Paso 1: Calcular Cambio y Variacion para cuentas padres ---
                    For Each row As DataGridViewRow In dgvComparacion.Rows
                        If Integer.Parse(row.Cells("Nivel").Value.ToString()) < 5 Then
                            ' Recorrer todas las columnas "CambioX"
                            For Each col As DataGridViewColumn In dgvComparacion.Columns
                                If col.Name.StartsWith("Cambio") Then
                                    Dim cambioNumber As String = col.Name.Replace("Cambio", "").Trim()
                                    Dim indexCambio As Integer = col.Index

                                    ' Las dos columnas anteriores son los periodos a comparar
                                    Dim periodoActualCol As DataGridViewColumn = dgvComparacion.Columns(indexCambio - 2)
                                    Dim periodoAnteriorCol As DataGridViewColumn = dgvComparacion.Columns(indexCambio - 1)

                                    ' Obtener valores
                                    Dim valorActual As Double = 0
                                    If row.Cells(periodoActualCol.Name).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(periodoActualCol.Name).Value) Then
                                        Double.TryParse(row.Cells(periodoActualCol.Name).Value.ToString(), valorActual)
                                    End If

                                    Dim valorAnterior As Double = 0
                                    If row.Cells(periodoAnteriorCol.Name).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(periodoAnteriorCol.Name).Value) Then
                                        Double.TryParse(row.Cells(periodoAnteriorCol.Name).Value.ToString(), valorAnterior)
                                    End If

                                    ' Calcular diferencia
                                    Dim cambio As Double = Math.Abs(valorActual) - Math.Abs(valorAnterior)
                                    row.Cells(col.Name).Value = Math.Round(cambio, 2)

                                    ' Calcular variación si existe la columna
                                    Dim variacionColName As String = "Variacion" & cambioNumber
                                    If dgvComparacion.Columns.Contains(variacionColName) Then
                                        Dim variacion As Double = If(valorAnterior <> 0, ((cambio * 100) / Math.Abs(valorAnterior)), 0)
                                        row.Cells(variacionColName).Value = Math.Round(variacion, 2)
                                    End If
                                End If
                            Next
                        End If
                    Next

                End If

            Catch Ex As Exception
                Krypton.Toolkit.KryptonMessageBox.Show("ERROR: " & Ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try


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
                cbxDates.SelectedIndex = 2
            ElseIf IsAnnualRange(fechaDesde, fechaHasta) Then
                cbxDates.SelectedIndex = 3
            Else
                cbxDates.SelectedIndex = 4
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
                SelectedRangeT = frm.SelectedRange
                FechaDesdeT = frm.FechaDesde
                FechaHastaT = frm.FechaHasta
                ShowColumnsT = frm.ShowColumns
                Anterior = frm.Anterior
                CambioAnterior = frm.CambioAnterior
                PorcentajeAnterior = frm.PorcentajeAnterior
                Previo = frm.Previo
                CambioPrevio = frm.CambioPrevio
                PorcentajePrevio = frm.PorcentajePrevio

                cbxDates.SelectedIndex = SelectedRangeT
                dtpFechaDesdeMes.Value = FechaDesdeT
                dtpFechaHastaMes.Value = FechaHastaT
                cbxShowColumns.SelectedIndex = ShowColumnsT

            End If


        End Sub

        Private Sub dtpFechaDesdeMes_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesdeMes.ValueChanged

            UpdateCbxDates()
            callReport()


        End Sub

        Private Sub cbxShowColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxShowColumns.SelectedIndexChanged
            callReport()
        End Sub

        Private Sub chkOcultar_CheckedChanged(sender As Object, e As EventArgs) Handles chkOcultar.CheckedChanged
            If dgvComparacion.Rows.Count = 0 Then
                Krypton.Toolkit.KryptonMessageBox.Show("Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            ' 1. Definir columnas fijas y excluir Cambio/Variacion
            Dim columnasFijas As New List(Of String) From {"Codigo", "Cuenta", "Nivel", "Padre", "nodoCom"}
            Dim columnasPeriodos As New List(Of String)

            ' 2. Filtrar columnas: solo las de períodos (ej: "ENE 2024", "JUL - DIC 2023")
            For Each col As DataGridViewColumn In dgvComparacion.Columns
                If Not columnasFijas.Contains(col.Name) AndAlso
           Not col.Name.StartsWith("Cambio") AndAlso
           Not col.Name.StartsWith("Variacion") Then
                    columnasPeriodos.Add(col.Name)
                End If
            Next

            ' 3. Evaluar filas
            For Each row As DataGridViewRow In dgvComparacion.Rows
                Dim todasCero As Boolean = True

                For Each colName As String In columnasPeriodos
                    If row.Cells(colName).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(colName).Value) Then
                        Dim valor As Double = 0
                        Dim valorStr As String = row.Cells(colName).Value.ToString()

                        ' 4. Convertir con formato invariante para evitar errores culturales
                        If Double.TryParse(valorStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, valor) Then
                            If Math.Abs(valor) > 0.0001 Then ' Tolerancia para redondeos
                                todasCero = False
                                Exit For
                            End If
                        Else
                            ' 5. Si no es numérico, no se oculta (ej: texto o formato incorrecto)
                            todasCero = False
                            Exit For
                        End If
                    End If
                Next

                ' 6. Ocultar/mostrar según el CheckBox
                row.Visible = If(chkOcultar.Checked, Not todasCero, True)
            Next
        End Sub

        Private Sub btnExportarComparacion_Click(sender As Object, e As EventArgs) Handles btnExportarComparacion.Click
            ExportarDatosCompracion(dgvComparacion, "BalanceFinal_Comparativo")
        End Sub


        Private Sub ExportarDatosCompracion(ByVal dgvComparacion As DataGridView, ByVal titulo As String)
            Try
                If dgvComparacion.Rows.Count = 0 Then
                    Krypton.Toolkit.KryptonMessageBox.Show("Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If



                Dim fec = ValidationForms.FechaActual(_tipoCon)



                'Crear un nuevo libro y hoja
                Dim workbook = New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("Comparación")

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvComparacion)
                worksheet.Range("A1:" & ic & (dgvComparacion.RowCount + 50)).Style.Font.FontSize = 10


                'Encabezado

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon).ToString() & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Style.Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                worksheet.Range("A1:" & ic & "1").Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))
                worksheet.Range("A1:" & ic & "1").Style.Font.FontColor = XLColor.White
                worksheet.Range("A1:" & ic & "1").Style.Font.FontSize = 12

                ' Copete
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaDesdeMes.Value.ToLongDateString() & "  AL " & dtpFechaHastaMes.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Style.Font.FontSize = 12

                ' Fecha
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Style.Font.FontSize = 12

                'Encabezados de Columnas 
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvComparacion.Columns.Count - 1
                    If Not dgvComparacion.Columns(i).Visible Then Continue For
                    worksheet.Cell(headin, indc).Value = dgvComparacion.Columns(i).HeaderText
                    worksheet.Cell(headin, indc).Style.Font.Bold = True
                    worksheet.Cell(headin, indc).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                    worksheet.Cell(headin, indc).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    worksheet.Cell(headin, indc).Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))
                    worksheet.Cell(headin, indc).Style.Font.FontColor = XLColor.White
                    indc += 1
                Next


                ' Detalle de la tabla
                Dim columnasTexto As String() = {"Cuenta"} ' Solo "Cuenta" es texto
                Dim columnasNumericas As String() = {"Codigo", "Nivel", "Padre"} ' Estas son numéricas
                Dim c = 0
                For o = 0 To dgvComparacion.Rows.Count - 1
                    ' Omitir filas ocultas si el CheckBox está marcado
                    If chkOcultar.Checked AndAlso Not dgvComparacion.Rows(o).Visible Then Continue For

                    indc = 1
                    For j = 0 To dgvComparacion.Columns.Count - 1
                        If Not dgvComparacion.Columns(j).Visible Then Continue For

                        Dim cellValue = dgvComparacion.Rows(o).Cells(j).Value
                        Dim cell = worksheet.Cell(c + 1 + headin, indc)
                        Dim columnName As String = dgvComparacion.Columns(j).HeaderText

                        ' Aplicar formato según el tipo de columna
                        If columnasNumericas.Contains(columnName) Then
                            ' Columnas numéricas específicas ("Codigo", "Nivel", "Padre")
                            If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                                cell.Value = CDbl(cellValue) ' Asegurar que el valor sea numérico
                            Else
                                cell.Value = 0 ' Valor por defecto si no es numérico
                            End If
                        ElseIf columnasTexto.Contains(columnName) Then
                            ' Columna de texto ("Cuenta")
                            cell.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                        Else
                            ' Formato contable para el resto de columnas
                            If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                                cell.Value = CDbl(cellValue)
                                cell.Style.NumberFormat.Format = "#,##0.00" ' Formato contable
                            Else
                                cell.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                            End If
                        End If

                        ' Aplicar bordes a la celda
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        ' Aplicar borde inferior solo en la última fila
                        If o = dgvComparacion.Rows.Count - 1 Then
                            cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                        End If

                        indc += 1
                    Next
                    c += 1
                Next


                ' Bordes inferiores
                worksheet.Range("A" & (c + headin) & ":" & ic & indc).Style.Border.BottomBorder = XLBorderStyleValues.Thin

                ' Ajustar columnas
                Dim range As IXLRange = worksheet.Range("A1:" & ic & (dgvComparacion.RowCount + 50))
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
                Krypton.Toolkit.KryptonMessageBox.Show("ERROR: " & ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace