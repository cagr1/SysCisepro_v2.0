Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

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
        End Sub

        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            dgvMayores.DataSource = Nothing

            Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59"

            dgvMayores.DataSource = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinalMensual2(_tipoCon, dtpInicio.Value.Year)

            dgvMayores.Columns(0).Width = 25
            dgvMayores.Columns("CODIGO").Width = 80
            dgvMayores.Columns("CUENTA").Width = 510
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

            Dim auxData As DataTable = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinal2(_tipoCon, fechaDesde, fechaHasta)

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

            ' PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER 
            Dim activo As Decimal = 0.0
            Dim pasivo As Decimal = 0.0
            Dim capital As Decimal = 0.0
            If dgvMayores.Rows.Count > 0 Then
                For index = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(index).Cells("CUENTA").Value = "ACTIVO" Then
                        activo = activo + dgvMayores.Rows(index).Cells("SALDO").Value
                    ElseIf dgvMayores.Rows(index).Cells("CUENTA").Value = "PASIVO" Then
                        pasivo = pasivo + dgvMayores.Rows(index).Cells("SALDO").Value
                    ElseIf dgvMayores.Rows(index).Cells("CUENTA").Value = "PATRIMONIO NETO" Then
                        capital = capital + dgvMayores.Rows(index).Cells("SALDO").Value
                    End If
                Next
                txtDeudor.Text = activo
                txtAcreedor.Text = pasivo
                txtCapital.Text = capital
                txtUtilidad.Text = Math.Abs(activo + pasivo + capital)
            End If
            dgvMayores.AutoResizeRows()

            'Asignar el valor de la utilidad a la cuenta contable
            Dim utilidad = activo + pasivo + capital

            Dim utilidadAux As Double = Convert.ToDouble(txtUtilidad.Text.Trim)

            If (utilidad > 0) Then
                lblUtilidadPerdida.Text = "UTILIDAD"
                lblUtilidadPerdida.ForeColor = Color.Navy

                For index = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(index).Cells("CODIGO").Value = "3" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "307" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "30701" Then
                        dgvMayores.Rows(index).Cells("HABER").Value = Math.Round(dgvMayores.Rows(index).Cells("HABER").Value + utilidadAux, 2)
                        dgvMayores.Rows(index).Cells("SALDO").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value - dgvMayores.Rows(index).Cells("HABER").Value, 2)
                    End If
                Next

            ElseIf (utilidad + capital < 0) Then
                lblUtilidadPerdida.Text = "PERDIDA"
                lblUtilidadPerdida.ForeColor = Color.Red

                For index = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(index).Cells("CODIGO").Value = "3" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "307" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "30702" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "3070201" Then
                        dgvMayores.Rows(index).Cells("DEBE").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value + utilidadAux, 2)
                        dgvMayores.Rows(index).Cells("SALDO").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value - dgvMayores.Rows(index).Cells("HABER").Value, 2)
                    End If
                Next

            Else
                lblUtilidadPerdida.Text = "UTILIDAD"
                lblUtilidadPerdida.ForeColor = Color.Navy
            End If

            'dgvMayores.AutoResizeRows()
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
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "BALANCE"

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


                ' TOTALES, ETC
                Dim footin = headin + dgvAsientosDiario.RowCount + 3
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Merge()
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Value = "TOTAL BALANCE FINAL"
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Font.Bold = True

                worksheet.Cells(footin + 2, 2).Value = "ACTIVO:"
                worksheet.Cells(footin + 2, 2).Font.Bold = True
                worksheet.Cells(footin + 2, 6).Value = txtDeudor.Text

                worksheet.Cells(footin + 3, 2).Value = "PASIVO:"
                worksheet.Cells(footin + 3, 2).Font.Bold = True
                worksheet.Cells(footin + 3, 6).Value = txtAcreedor.Text

                worksheet.Cells(footin + 4, 2).Value = "PATRIMONIO:"
                worksheet.Cells(footin + 4, 2).Font.Bold = True
                worksheet.Cells(footin + 4, 6).Value = txtCapital.Text

                worksheet.Cells(footin + 5, 2).Value = lblUtilidadPerdida.Text.Trim
                worksheet.Cells(footin + 5, 2).Font.Bold = True
                worksheet.Cells(footin + 5, 6).Value = txtUtilidad.Text

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    MsgBox("PRIMERO DEBE CARGAR EL BALANCE", MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACION")
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
                MsgBox("ÁRBOL GENERADO CON EÉXTIO", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            Catch esxception As Exception
                MsgBox("ERROR AL GENERAR ÁRBOL: " & esxception.Message, MsgBoxStyle.Critical, "MENSAJE DE INFORMACION")
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
                MsgBox(ex.Message.ToString)
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
    End Class
End Namespace