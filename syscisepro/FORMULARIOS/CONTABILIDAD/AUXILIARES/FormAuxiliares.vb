Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.AUXILIARES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAuxiliares

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
        
        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            '=========================================================================================================================================================================
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.001"
            Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"
            Dim objPlanCuentas As New ClassPlanDeCuentas
            'Dim siete As Integer = 0
            'Dim seis As Integer = 0
            'Dim cinco As Integer = 0
            'Dim cuatro As Integer = 0
            'Dim tres As Integer = 0
            'Dim dos As Integer = 0
            'Dim uno As Integer = 0
            dgvMayoresPadres.DataSource = objPlanCuentas.SeleccionarSaldosMayoresXFechaDiario(_tipoCon, fechaDesde, fechaHasta)
            dgvMayoresPadres.AutoResizeColumns()
            dgvMayoresPadres.AutoResizeRows()
            '=== PINTO LAS CUENTAS CONTABLES =========================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                Select Case dgvMayoresPadres.Rows(indice).Cells.Item(5).Value.ToString
                    Case "7" : dgvMayoresPadres.Rows(indice).DefaultCellStyle.BackColor = Color.AliceBlue
                        'siete += 1
                    Case "6" : dgvMayoresPadres.Rows(indice).DefaultCellStyle.BackColor = Color.GhostWhite
                        'seis += 1
                    Case "5" : dgvMayoresPadres.Rows(indice).DefaultCellStyle.BackColor = Color.White
                        'cinco += 1
                    Case "4" : dgvMayoresPadres.Rows(indice).DefaultCellStyle.BackColor = Color.SkyBlue
                        'cuatro += 1
                    Case "3" : dgvMayoresPadres.Rows(indice).DefaultCellStyle.BackColor = Color.LightBlue
                        'tres += 1
                    Case "2" : dgvMayoresPadres.Rows(indice).DefaultCellStyle.BackColor = Color.PowderBlue
                        'dos += 1
                    Case "1" : dgvMayoresPadres.Rows(indice).DefaultCellStyle.BackColor = Color.LightCyan
                        'uno += 1
                End Select
            Next

            'MsgBox("MENSAJE DE INFORMACION", MsgBoxStyle.Information, "MAYORES CARGADOS")
            Dim objPlanCuentas2 As New ClassPlanDeCuentas
            dgvAsientosDiario.DataSource = objPlanCuentas2.SeleccionarSaldosMayoresXFechaDiario(_tipoCon, fechaDesde, fechaHasta)
            dgvAsientosDiario.AutoResizeColumns()
            dgvAsientosDiario.AutoResizeRows()
            For indice = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                Select Case dgvAsientosDiario.Rows(indice).Cells.Item(5).Value.ToString
                    Case "7" : dgvAsientosDiario.Rows(indice).DefaultCellStyle.BackColor = Color.AliceBlue
                    Case "6" : dgvAsientosDiario.Rows(indice).DefaultCellStyle.BackColor = Color.GhostWhite
                    Case "5" : dgvAsientosDiario.Rows(indice).DefaultCellStyle.BackColor = Color.White
                    Case "4" : dgvAsientosDiario.Rows(indice).DefaultCellStyle.BackColor = Color.SkyBlue
                    Case "3" : dgvAsientosDiario.Rows(indice).DefaultCellStyle.BackColor = Color.LightBlue
                    Case "2" : dgvAsientosDiario.Rows(indice).DefaultCellStyle.BackColor = Color.PowderBlue
                    Case "1" : dgvAsientosDiario.Rows(indice).DefaultCellStyle.BackColor = Color.LightCyan
                End Select
            Next

            '=== PROCESAR LOS DE NIVEL 7 ==============================================================================================================================================
            ' MsgBox("NIVEL 7 PROCESADOS", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(posicion).Cells(6).Value And dgvAsientosDiario.Rows(posicion).Cells(5).Value = "7" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvAsientosDiario.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvAsientosDiario.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvAsientosDiario.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvAsientosDiario.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvAsientosDiario.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvAsientosDiario.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value - dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
                dgvAsientosDiario.Rows(indice).Cells(6).Value = dgvMayoresPadres.Rows(indice).Cells(6).Value
            Next
            '=== PROCESAR LOS DE NIVEL 6 ==============================================================================================================================================
            ' MsgBox("NIVEL 6 PROCESADOS", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(posicion).Cells(6).Value And dgvAsientosDiario.Rows(posicion).Cells(5).Value = "6" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvAsientosDiario.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvAsientosDiario.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvAsientosDiario.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvAsientosDiario.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvAsientosDiario.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvAsientosDiario.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value - dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
                dgvAsientosDiario.Rows(indice).Cells(6).Value = dgvMayoresPadres.Rows(indice).Cells(6).Value
            Next
            '=== PROCESAR LOS DE NIVEL 5 ==============================================================================================================================================
            ' MsgBox("NIVEL 5 PROCESADOS", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(posicion).Cells(6).Value And dgvAsientosDiario.Rows(posicion).Cells(5).Value = "5" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvAsientosDiario.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvAsientosDiario.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvAsientosDiario.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvAsientosDiario.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvAsientosDiario.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvAsientosDiario.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value - dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
                dgvAsientosDiario.Rows(indice).Cells(6).Value = dgvMayoresPadres.Rows(indice).Cells(6).Value
            Next
            '=== PROCESAR LOS DE NIVEL 4 ==============================================================================================================================================
            'MsgBox("NIVEL 4 PROCESADOS", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(posicion).Cells(6).Value And dgvAsientosDiario.Rows(posicion).Cells(5).Value = "4" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvAsientosDiario.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvAsientosDiario.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvAsientosDiario.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvAsientosDiario.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvAsientosDiario.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvAsientosDiario.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value - dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
                dgvAsientosDiario.Rows(indice).Cells(6).Value = dgvMayoresPadres.Rows(indice).Cells(6).Value
            Next
            '=== PROCESAR LOS DE NIVEL 3 ==============================================================================================================================================
            'MsgBox("NIVEL 3 PROCESADOS", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(posicion).Cells(6).Value And dgvAsientosDiario.Rows(posicion).Cells(5).Value = "3" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvAsientosDiario.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvAsientosDiario.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvAsientosDiario.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvAsientosDiario.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvAsientosDiario.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvAsientosDiario.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value - dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
                dgvAsientosDiario.Rows(indice).Cells(6).Value = dgvMayoresPadres.Rows(indice).Cells(6).Value
            Next
            '=== PROCESAR LOS DE NIVEL 2 ==============================================================================================================================================
            'MsgBox("NIVEL 2 PROCESADOS", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(posicion).Cells(6).Value And dgvAsientosDiario.Rows(posicion).Cells(5).Value = "2" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvAsientosDiario.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvAsientosDiario.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvAsientosDiario.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvAsientosDiario.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvAsientosDiario.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvAsientosDiario.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value - dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
                dgvAsientosDiario.Rows(indice).Cells(6).Value = dgvMayoresPadres.Rows(indice).Cells(6).Value
            Next
            '=== PROCESAR LOS DE NIVEL 1 ==============================================================================================================================================
            'MsgBox("NIVEL 1 PROCESADOS", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(posicion).Cells(6).Value And dgvAsientosDiario.Rows(posicion).Cells(5).Value = "1" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvAsientosDiario.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvAsientosDiario.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvAsientosDiario.Rows.Count - 1 Step 1
                dgvAsientosDiario.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvAsientosDiario.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvAsientosDiario.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvAsientosDiario.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value - dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvAsientosDiario.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
                dgvAsientosDiario.Rows(indice).Cells(6).Value = dgvMayoresPadres.Rows(indice).Cells(6).Value
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvAsientosDiario.Rows(indice).Cells(0).Value
                dgvMayoresPadres.Rows(indice).Cells(1).Value = dgvAsientosDiario.Rows(indice).Cells(1).Value
                dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvAsientosDiario.Rows(indice).Cells(2).Value
                dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvAsientosDiario.Rows(indice).Cells(3).Value
                dgvMayoresPadres.Rows(indice).Cells(4).Value = dgvAsientosDiario.Rows(indice).Cells(4).Value
                dgvMayoresPadres.Rows(indice).Cells(5).Value = dgvAsientosDiario.Rows(indice).Cells(5).Value
                dgvMayoresPadres.Rows(indice).Cells(6).Value = dgvAsientosDiario.Rows(indice).Cells(6).Value
            Next
        End Sub

        Private Sub FormAuxiliares_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvAsientosDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
            dtpInicio.Value = New DateTime(Date.Now.Year, Date.Now.Month, 1, 0, 0, 0)
            dtpFinal.Value = dtpInicio.Value.AddMonths(1).AddDays(-1)
        End Sub

        Private Sub ExportarDatosExcel(ByVal titulo As String, ByVal sname As String, ByVal desde As DateTime, ByVal hasta As DateTime)
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim app = New Microsoft.Office.Interop.Excel.Application()

                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = sname

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
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & desde.ToLongDateString().ToUpper() & "  AL " & hasta.ToLongDateString().ToUpper()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString().ToUpper() & " " & fec.ToLongTimeString()
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
                        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosDiario.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvAsientosDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                Dim position = CType(worksheet.Cells(2, 7), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.paste(position)

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvAsientosDiario.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel("AUXILIARES", "AUXILIARES", dtpInicio.Value, dtpFinal.Value)
        End Sub
    End Class
End Namespace