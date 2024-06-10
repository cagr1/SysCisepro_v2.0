Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.MAYORIZACION
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormEstadoSituacionInicial
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



        '=== INSTANCIAS ==============================================================================================================================================================
        Dim fechaDesde As String = ""
        Dim fechaHasta As String = ""
        '==============================================================================================================================================================================

        Dim objMayor As New ClassMayorGeneral
        Dim objDetalle As New ClassDetalleMayores
        Dim objAsiento As New ClassAsientosLibroDiario
        '==============================================================================================================================================================================
        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click

            dgvMayores.DataSource = Nothing

            fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00"
            fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59"

            Dim objPlanCuentas As New ClassPlanDeCuentas
            dgvMayores.DataSource = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinalMensual(_tipoCon)

            dgvMayores.Columns(0).Width = 25 : dgvMayores.Columns("CODIGO").Width = 80 : dgvMayores.Columns("CUENTA").Width = 510
            dgvMayores.Columns("DEBE").Width = 75 : dgvMayores.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMayores.Columns("HABER").Width = 75 : dgvMayores.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMayores.Columns("SALDO").Width = 75 : dgvMayores.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvMayores.Columns("NIVEL").Width = 40 : dgvMayores.Columns("PADRE").Width = 80

            Dim auxData As DataTable = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiarioBalanceFinal(_tipoCon, fechaDesde, fechaHasta)

            ' SE COPIA LA DATA, SE PINTA Y CALCULA SALDO (CUENTA POR CUENTA)
            For Each row As DataGridViewRow In dgvMayores.Rows

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
                            row.Cells("DEBE").Value = Math.Round((CType(row.Cells("DEBE").Value, Double) + CType(drow("DEBE"), Double)), 2)
                            row.Cells("HABER").Value = Math.Round((CType(row.Cells("HABER").Value, Double) + CType(drow("HABER"), Double)), 2)
                            row.Cells("SALDO").Value = Math.Round((CType(row.Cells("SALDO").Value, Double) + CType(drow("SALDO"), Double)), 2)
                        End If

                        'verificar nodos
                        'If row.Cells("CODIGO").Value = drow("PADRE") Then
                        '    row.Cells("nodo").Value = "-"
                        'End If
                    Next
                Next
                auxData = CType(dgvMayores.DataSource, DataTable)
            Next

            ' PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER 
            Dim index As Integer = 0
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
                For index = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(index).Cells("CODIGO").Value = "3" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "307" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "30701" Then
                        dgvMayores.Rows(index).Cells("HABER").Value = Math.Round(dgvMayores.Rows(index).Cells("HABER").Value + utilidadAux, 2)
                        dgvMayores.Rows(index).Cells("SALDO").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value - dgvMayores.Rows(index).Cells("HABER").Value, 2)
                    End If
                Next
            ElseIf (utilidad + capital < 0) Then
                For index = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(index).Cells("CODIGO").Value = "3" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "307" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "30702" Or dgvMayores.Rows(index).Cells("CODIGO").Value = "3070201" Then
                        dgvMayores.Rows(index).Cells("DEBE").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value + utilidadAux, 2)
                        dgvMayores.Rows(index).Cells("SALDO").Value = Math.Round(dgvMayores.Rows(index).Cells("DEBE").Value - dgvMayores.Rows(index).Cells("HABER").Value, 2)
                    End If
                Next
            End If

        End Sub

        '==== PARA MOSTRAR EL BALANCE DE COMPROBACIÓN EN FORMA DE ÁRBOL ================================================================================================================================================        
        Private Sub FormEstadoSituacionInicial_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
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
            Me.dgvMayores.ContextMenuStrip = Me.ContextMenuStripClicDerecho

            _hoy = ValidationForms.FechaActual(_tipoCon)
        End Sub

        Private Sub btnArbol_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnArbol.Click
            tvBalanceComprobacion.BeginUpdate()
            Dim nivel1 As TreeNode = tvBalanceComprobacion.Nodes.Add("CUENTAS", "BALANCE FINAL")
            Dim nivel2 As TreeNode = Nothing
            Dim nivel3 As TreeNode = Nothing
            Dim nivel4 As TreeNode = Nothing
            Dim nivel5 As TreeNode = Nothing
            Dim nivel6 As TreeNode = Nothing
            Dim nivel7 As TreeNode = Nothing
            Dim nivel8 As TreeNode = Nothing

            For indice = 0 To dgvMayores.Rows.Count - 1 Step 1
                If dgvMayores.Rows(indice).Cells(5).Value = "1" Then
                    nivel2 = añadirNodo(nivel1, dgvMayores.Rows(indice).Cells(6).Value, dgvMayores.Rows(indice).Cells(0).Value + " " + dgvMayores.Rows(indice).Cells(1).Value & " DEBE: " & dgvMayores.Rows(indice).Cells(2).Value & " HABER: " & dgvMayores.Rows(indice).Cells(3).Value)
                End If
                If dgvMayores.Rows(indice).Cells(5).Value = "2" Then
                    nivel3 = añadirNodo(nivel2, dgvMayores.Rows(indice).Cells(6).Value, dgvMayores.Rows(indice).Cells(0).Value + " " + dgvMayores.Rows(indice).Cells(1).Value & " DEBE: " & dgvMayores.Rows(indice).Cells(2).Value & " HABER: " & dgvMayores.Rows(indice).Cells(3).Value)
                End If
                If dgvMayores.Rows(indice).Cells(5).Value = "3" Then
                    nivel4 = añadirNodo(nivel3, dgvMayores.Rows(indice).Cells(6).Value, dgvMayores.Rows(indice).Cells(0).Value + " " + dgvMayores.Rows(indice).Cells(1).Value & " DEBE: " & dgvMayores.Rows(indice).Cells(2).Value & " HABER: " & dgvMayores.Rows(indice).Cells(3).Value)
                End If
                If dgvMayores.Rows(indice).Cells(5).Value = "4" Then
                    nivel5 = añadirNodo(nivel4, dgvMayores.Rows(indice).Cells(6).Value, dgvMayores.Rows(indice).Cells(0).Value + " " + dgvMayores.Rows(indice).Cells(1).Value & " DEBE: " & dgvMayores.Rows(indice).Cells(2).Value & " HABER: " & dgvMayores.Rows(indice).Cells(3).Value)
                End If
                If dgvMayores.Rows(indice).Cells(5).Value = "5" Then
                    nivel6 = añadirNodo(nivel5, dgvMayores.Rows(indice).Cells(6).Value, dgvMayores.Rows(indice).Cells(0).Value + " " + dgvMayores.Rows(indice).Cells(1).Value & " DEBE: " & dgvMayores.Rows(indice).Cells(2).Value & " HABER: " & dgvMayores.Rows(indice).Cells(3).Value)
                End If
                If dgvMayores.Rows(indice).Cells(5).Value = "5" Then
                    nivel7 = añadirNodo(nivel6, dgvMayores.Rows(indice).Cells(6).Value, dgvMayores.Rows(indice).Cells(0).Value + " " + dgvMayores.Rows(indice).Cells(1).Value & " DEBE: " & dgvMayores.Rows(indice).Cells(2).Value & " HABER: " & dgvMayores.Rows(indice).Cells(3).Value)
                End If
                If dgvMayores.Rows(indice).Cells(5).Value = "5" Then
                    nivel8 = añadirNodo(nivel7, dgvMayores.Rows(indice).Cells(6).Value, dgvMayores.Rows(indice).Cells(0).Value + " " + dgvMayores.Rows(indice).Cells(1).Value & " DEBE: " & dgvMayores.Rows(indice).Cells(2).Value & " HABER: " & dgvMayores.Rows(indice).Cells(3).Value)
                End If
            Next
            tvBalanceComprobacion.EndUpdate()
        End Sub

        Private Function añadirNodo(ByVal node As TreeNode, ByVal padre As String, ByVal cuenta As String) As TreeNode
            Return node.Nodes.Add(padre, cuenta)
        End Function

        Private Sub tsmOcultar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmOcultar.Click
            Dim indice As Integer = 0
            If dgvMayores.Rows.Count > 0 Then
                For indice = 0 To dgvMayores.Rows.Count - 1 Step 1
                    If dgvMayores.Rows(indice).Cells(5).Value > dgvMayores.CurrentRow.Cells.Item(5).Value Then
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
                    If dgvMayores.Rows(indice).Cells(5).Value <> dgvMayores.CurrentRow.Cells.Item(5).Value Then
                        dgvMayores.Rows(indice).Visible = True
                    End If
                Next
            Else
            End If
        End Sub
        '=== PARA EXPORTAR EN EXCEL ===================================================================================================================================================
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
                worksheet.Name = "SITUACION_INICIAL"

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

                ' TOTALES, ETC
                Dim footin = headin + dgvAsientosDiario.RowCount + 3
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Merge()
                worksheet.Range("A" & (footin + 1) & ":C" & (footin + 1)).Value = "TOTAL BALANCE"
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

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            'Try
            '    _hoy = ValidationForms.FechaActual(_tipoCon)

            '    If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR EL ESTADO DE SITUACIÓN INICIAL " & _hoy.Year & "?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            '    _sqlCommands.Clear()

            '    Dim idMayor = objMayor.BuscarMayorIdMayorGeneral(_tipoCon) + 1
            '    Dim idDetalleMayor = objDetalle.BuscarMayorIdDetalleMayorGeneral(_tipoCon) + 1
            '    Dim idAsiento = objAsiento.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
            '    Dim numRegistroAsiento = objAsiento.BuscarMayorNuneroRegistroAsientoLibroDiario(_tipoCon)

            '    For indice = 0 To dgvMayores.Rows.Count - 1
            '        With objMayor

            '            .Id = idMayor
            '            .Codigo = dgvMayores.Rows(indice).Cells(1).Value
            '            .Fecha = _hoy
            '            .Observacion = "APERTURA " + CType(_hoy.Year, String)
            '            .TotalDebe = Math.Abs(Math.Round(CType(dgvMayores.Rows(indice).Cells("DEBE").Value, Decimal), 4))
            '            .TotalHaber = Math.Abs(Math.Round(CType(dgvMayores.Rows(indice).Cells("HABER").Value, Decimal), 4))
            '            If .TotalDebe >= .TotalHaber Then
            '                .DeudorAcreedor = 1
            '                .TotalDeudor = Math.Abs(Math.Round(.TotalDebe - .TotalHaber, 4))
            '                .TotalAcreedor = 0.0
            '            Else
            '                .DeudorAcreedor = 2
            '                .TotalDeudor = 0.0
            '                .TotalAcreedor = Math.Abs(Math.Round(.TotalDebe - .TotalHaber, 4))
            '            End If
            '            .Estado = 1
            '            .IdEmpresa = 1
            '            .CodigoPadre = dgvMayores.Rows(indice).Cells(6).Value
            '            '.NuevoRegistroMayor(_tipoCon)
            '        End With
            '        _sqlCommands.Add(objMayor.NuevoRegistroMayorCommand())


            '        With objDetalle
            '            .Id = idDetalleMayor
            '            .Fecha = _hoy
            '            .Descripcion = "ESTADO SITUACIÓN INICIAL " + CType(_hoy.Year, String)
            '            .Referencia = "2"
            '            .Debe = objMayor.TotalDebe
            '            .Haber = objMayor.TotalHaber
            '            .IdMayor = objMayor.Id
            '            .Estado = 1
            '            .IdAsiento = 2
            '            .IdCorte = 2
            '            '.NuevoRegistroDetalleMayor(_tipoCon)
            '        End With
            '        _sqlCommands.Add(objDetalle.NuevoRegistroDetalleMayorCommand())


            '        With objAsiento
            '            .NumeroRegistroAsiento = numRegistroAsiento
            '            .IdAsiento = idAsiento
            '            .FechaAsiento = _hoy
            '            .CodigoCuentaAsiento = dgvMayores.Rows(indice).Cells("CODIGO").Value
            '            .NombreCuentaAsiento = dgvMayores.Rows(indice).Cells("CUENTA").Value
            '            .ConceptoAsiento = "ESTADO SITUACION INICIAL " + CType(_hoy.Year, String)
            '            .DetalleTransaccionAsiento = "INGRESO DE SALDOS"
            '            .ProvinciaAsiento = "EL ORO"
            '            .CiudadAsiento = "MACHALA"
            '            .ParroquiaAsiento = "9 DE MAYO"
            '            .CentroCostoAsiento = "SUPERVISION MACHALA"
            '            .NumeroRegistroAsiento = 2
            '            .ConciliarAsiento = 1
            '            .ValorDebeAsiento = objMayor.TotalDebe
            '            .ValorHaberAsiento = objMayor.TotalHaber
            '            If .ValorDebeAsiento >= .ValorHaberAsiento Then
            '                .DebeHaberAsiento = 1
            '            Else
            '                .DebeHaberAsiento = 2
            '            End If
            '            .EstadoAsiento = 2
            '            .EstadoMayorAsiento = 1
            '            .IdLibroDiario = 1
            '            '.NuevoRegistroAsientoLibroDiario(_tipoCon)
            '        End With
            '        _sqlCommands.Add(objAsiento.NuevoRegistroAsientoLibroDiarioCommand())

            '        idMayor += 1
            '        idDetalleMayor += 1
            '        idAsiento += 1
            '    Next

            '    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)

            '    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            'Catch ex As Exception
            '    MessageBox.Show("HUBO UN PROBLEMA GUARDAR!" & vbNewLine & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
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

            chkTodos.Checked = False

            CantidadReistros()
        End Sub

        Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTodos.CheckedChanged
            dgvMayores.CurrentCell = Nothing

            If chkTodos.Checked Then
                For Each row As DataGridViewRow In dgvMayores.Rows
                    If row.Cells("SALDO").Value = 0 And row.Visible Then
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

    End Class
End Namespace