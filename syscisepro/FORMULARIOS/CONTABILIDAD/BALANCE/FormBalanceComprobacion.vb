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
    Public Class FormBalanceComprobacion
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
         
        '=============================================================================================================================================================================
        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            dgvMayores.DataSource = Nothing

            Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59"

            Dim objPlanCuentas As New ClassPlanDeCuentas
            dgvMayores.DataSource = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioMensual2(_tipoCon, dtpInicio.Value.Year)

            dgvMayores.Columns(0).Width = 25
            dgvMayores.Columns("CODIGO").Width = 80
            dgvMayores.Columns("CUENTA").Width = 500
            dgvMayores.Columns("INICIAL").Width = 75
            dgvMayores.Columns("INICIAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMayores.Columns("DEBE").Width = 75
            dgvMayores.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMayores.Columns("HABER").Width = 75
            dgvMayores.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMayores.Columns("SALDO").Width = 75
            dgvMayores.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMayores.Columns("NIVEL").Width = 40
            dgvMayores.Columns("PADRE").Width = 80

            Dim auxData As DataTable = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiario2(_tipoCon, fechaDesde, fechaHasta)

            ' SE COPIA LA DATA, SE PINTA Y CALCULA SALDO (CUENTA POR CUENTA)
            For Each row As DataGridViewRow In dgvMayores.Rows

                If (row.Cells("INICIAL").Value & "").ToString().Length = 0 Then row.Cells("INICIAL").Value = "0.00"

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
            auxData = CType(dgvMayores.DataSource, DataTable)

            ' SE CALCULA LOS SALDOS TODOS LOS NIVELES (ACUMULADO NIVELES)
            For i = 7 To 1 Step -1
                For Each row As DataGridViewRow In dgvMayores.Rows
                    For Each drow As DataRow In auxData.Rows
                        If row.Cells("CODIGO").Value = drow("PADRE") And drow("NIVEL") = i Then
                            row.Cells("INICIAL").Value = Math.Round((CType(row.Cells("INICIAL").Value, Double) + CType(drow("INICIAL"), Double)), 2)

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
                auxData = CType(dgvMayores.DataSource, DataTable)
            Next

            '=== PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER =====================================================================================================================================
            Dim deudor As Decimal = 0.0
            Dim acreedor As Decimal = 0.0
            If dgvMayores.Rows.Count > 0 Then
                For index = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(index).Cells("NIVEL").Value = 1 Then
                        deudor = deudor + dgvMayores.Rows(index).Cells("DEBE").Value
                        acreedor = acreedor + dgvMayores.Rows(index).Cells("HABER").Value
                    End If
                Next
                txtDeudor.Text = deudor
                txtAcreedor.Text = acreedor
            End If

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
        Public Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then

                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If



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
                Dim worksheet = workbook.Worksheets.Add("Balance_Comprobacion")
                Dim colorSistema As System.Drawing.Color = ValidationForms.GetColorSistema(_tipoCon)
                Dim xlColor As XLColor = XLColor.FromColor(colorSistema)

                ' Definir rango para el título
                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Cell(1, 1).Value = tituloReporte.ToString()
                worksheet.Cell(1, 1).Style.Font.SetBold(True)
                worksheet.Cell(1, 1).Style.Font.SetFontSize(12)
                worksheet.Cell(1, 1).Style.Font.SetFontColor(XLColor.White)
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
                    worksheet.Cell(headin, indc).Style.Font.SetFontColor(XLColor.White)
                    worksheet.Cell(headin, indc).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    indc += 1
                Next

                ' Detalle de datos
                Dim c = 0
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    If dgvAsientosDiario.Rows(i).IsNewRow Then Continue For ' Evita la fila vacía
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1
                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For


                        ' Verificar si el valor de la celda no es null antes de asignarlo
                        Dim cellValue = dgvAsientosDiario.Rows(i).Cells(j).Value
                        If cellValue IsNot Nothing Then
                            worksheet.Cell(c + headin + 1, indc).Value = cellValue.ToString()
                        Else
                            worksheet.Cell(c + headin + 1, indc).Value = ""
                        End If

                        ' Establecer bordes
                        Dim cell = worksheet.Cell(c + headin + 1, indc)
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        If i = dgvAsientosDiario.Rows.Count - 1 Then
                            cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                        End If

                        indc += 1
                    Next
                    c += 1
                Next

                worksheet.Range("A" & (c + headin) & ":" & ic & indc).Style.Border.BottomBorder = XLBorderStyleValues.Thin


                '' TOTALES, ETC
                'Dim foot = headin + dgvAsientosDiario.RowCount + 3
                'worksheet.Cells(foot, 7).Value = "TOTAL DEBE"
                'worksheet.Cells(foot, 7).Style.Font.SetBold(True)
                'worksheet.Cells(foot, 8).Value = txtDeudor.Text

                'worksheet.Cells(foot + 1, 7).Value = "TOTAL HABER"
                'worksheet.Cells(foot + 1, 7).Style.Font.SetBold(True)
                'worksheet.Cells(foot + 1, 8).Value = txtAcreedor.Text


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
                'MessageBox.Show("Hubo un problema al exportar datos! " & ex.Message.ToString(), "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show(ex.Message.ToString, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try 
        End Sub

        '=== PARA EXPORTAR DATOS A EXCEL =============================================================================================================================================
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvMayores, "BALANCE DE COMPROBACIÓN")
        End Sub
        '=============================================================================================================================================================================
        Private Sub FormBalanceComprobacion_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvMayores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvMayores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvMayores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvMayores.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvMayores.ContextMenuStrip = ContextMenuStripClicDerecho
            cbNivel.SelectedIndex = 0
        End Sub

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
            Dim indice As Integer = 0
            If dgvMayores.Rows.Count > 0 Then
                For indice = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(indice).Cells("NIVEL").Value <> dgvMayores.CurrentRow.Cells.Item(5).Value Then
                        dgvMayores.Rows(indice).Visible = True
                    End If
                Next
            Else
            End If
        End Sub

        '==== PARA MOSTRAR EL BALANCE DE COMPROBACIÓN EN FORMA DE ÁRBOL ================================================================================================================================================
        Private Sub btnArbol_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnArbol.Click
            tvBalanceComprobacion.BeginUpdate()
            Dim nivel1 As TreeNode = tvBalanceComprobacion.Nodes.Add("CUENTAS", "BALANCE DE COMPROBACIÓN")
            Dim nivel2 As TreeNode = Nothing
            Dim nivel3 As TreeNode = Nothing
            Dim nivel4 As TreeNode = Nothing
            Dim nivel5 As TreeNode = Nothing
            Dim nivel6 As TreeNode = Nothing
            Dim nivel7 As TreeNode = Nothing
            Dim nivel8 As TreeNode = Nothing

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
                If dgvMayores.Rows(indice).Cells("NIVEL").Value = "5" Then
                    nivel7 = añadirNodo(nivel6, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                End If
                If dgvMayores.Rows(indice).Cells("NIVEL").Value = "5" Then
                    nivel8 = añadirNodo(nivel7, dgvMayores.Rows(indice).Cells("PADRE").Value, dgvMayores.Rows(indice).Cells("CODIGO").Value + " " + dgvMayores.Rows(indice).Cells("CUENTA").Value & " DEBE: " & dgvMayores.Rows(indice).Cells("DEBE").Value & " HABER: " & dgvMayores.Rows(indice).Cells("HABER").Value)
                End If
            Next
            tvBalanceComprobacion.EndUpdate()
        End Sub

        Private Function añadirNodo(ByVal node As TreeNode, ByVal padre As String, ByVal cuenta As String) As TreeNode
            Return node.Nodes.Add(padre, cuenta)
        End Function
        
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

                KryptonMessageBox.Show(ex.Message.ToString, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

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
        End Sub

        Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTodos.CheckedChanged
            dgvMayores.CurrentCell = Nothing

            If chkTodos.Checked Then
                For Each row As DataGridViewRow In dgvMayores.Rows
                    If row.Cells("SALDO").Value = 0 And row.Cells("NIVEL").Value > 4 And row.Visible Then
                        row.Visible = False
                    End If
                Next
            Else
                For Each row As DataGridViewRow In dgvMayores.Rows
                    row.Visible = True
                Next
            End If

            CantidadReistros()
        End Sub

        Private Sub tpActualizar_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace