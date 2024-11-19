Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.MAYORIZACION
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormMayorizacion
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

        ReadOnly _objPlan As New ClassPlanDeCuentas
        ReadOnly _objAsiento As New ClassAsientosLibroDiario

        Private Sub FormMayorizacion_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvMayoresHijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvRegistros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvMayoresHijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvRegistros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvMayoresHijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvRegistros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvAsiento.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvMayoresHijos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvRegistros.Font = New Font("Roboto", 8, FontStyle.Regular)

            AutocompletarPlanCuentas()
            txtCuentaPadre.Focus()
        End Sub
        Private Sub AutocompletarPlanCuentas()
            Try
                txtCuentaPadre.AutoCompleteCustomSource = _objPlan.Autocompletar(_tipoCon)
                txtCuentaPadre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txtCuentaPadre.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtCuentaPadre.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            If txtCuentaPadre.Text.Trim().Length = 0 Then Return
            dgvAsiento.DataSource = Nothing

            CargaMayores()
            CargarRegistrosMayores()
        End Sub
        Private Sub CargaMayores()
            Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.001"
            Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"
            Dim codicuenta = txtCuentaPadre.Text.Trim().Split("-")(0).Trim

            dgvMayoresPadres.DataSource = _objPlan.SeleccionarCuentasXRangoFechasXRangoCuentas(_tipoCon, fechaDesde, fechaHasta, codicuenta, CheckBox1.Checked)
            dgvMayoresHijos.DataSource = _objPlan.SeleccionarCuentasXRangoFechasXRangoCuentas(_tipoCon, fechaDesde, fechaHasta, codicuenta, CheckBox1.Checked)
            dgvMayoresHijos.AutoResizeRows()
            dgvMayoresHijos.AutoResizeColumns()

            '=== PROCESAR LOS DE NIVEL 7 ==============================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(posicion).Cells(5).Value And dgvMayoresHijos.Rows(posicion).Cells(4).Value = "7" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvMayoresHijos.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvMayoresHijos.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            '=== PROCESAR LOS DE NIVEL 6 ==============================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(posicion).Cells(5).Value And dgvMayoresHijos.Rows(posicion).Cells(4).Value = "6" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvMayoresHijos.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvMayoresHijos.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            '=== PROCESAR LOS DE NIVEL 5 ==============================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(posicion).Cells(5).Value And dgvMayoresHijos.Rows(posicion).Cells(4).Value = "5" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvMayoresHijos.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvMayoresHijos.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            '=== PROCESAR LOS DE NIVEL 4 ==============================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(posicion).Cells(5).Value And dgvMayoresHijos.Rows(posicion).Cells(4).Value = "4" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvMayoresHijos.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvMayoresHijos.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            '=== PROCESAR LOS DE NIVEL 3 ==============================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(posicion).Cells(5).Value And dgvMayoresHijos.Rows(posicion).Cells(4).Value = "3" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvMayoresHijos.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvMayoresHijos.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            '=== PROCESAR LOS DE NIVEL 2 ==============================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(posicion).Cells(5).Value And dgvMayoresHijos.Rows(posicion).Cells(4).Value = "2" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvMayoresHijos.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvMayoresHijos.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            '=== PROCESAR LOS DE NIVEL 1 ==============================================================================================================================================
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                For posicion = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                    If dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(posicion).Cells(5).Value And dgvMayoresHijos.Rows(posicion).Cells(4).Value = "1" Then
                        dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value + dgvMayoresHijos.Rows(posicion).Cells(2).Value
                        dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value + dgvMayoresHijos.Rows(posicion).Cells(3).Value
                    End If
                Next
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            For indice = 0 To dgvMayoresHijos.Rows.Count - 1 Step 1
                dgvMayoresHijos.Rows(indice).Cells(0).Value = dgvMayoresPadres.Rows(indice).Cells(0).Value
                dgvMayoresHijos.Rows(indice).Cells(1).Value = dgvMayoresPadres.Rows(indice).Cells(1).Value
                dgvMayoresHijos.Rows(indice).Cells(2).Value = dgvMayoresPadres.Rows(indice).Cells(2).Value
                dgvMayoresHijos.Rows(indice).Cells(3).Value = dgvMayoresPadres.Rows(indice).Cells(3).Value
                dgvMayoresHijos.Rows(indice).Cells(4).Value = dgvMayoresPadres.Rows(indice).Cells(4).Value
                dgvMayoresHijos.Rows(indice).Cells(5).Value = dgvMayoresPadres.Rows(indice).Cells(5).Value
            Next
            For indice = 0 To dgvMayoresPadres.Rows.Count - 1 Step 1
                dgvMayoresPadres.Rows(indice).Cells(0).Value = dgvMayoresHijos.Rows(indice).Cells(0).Value
                dgvMayoresPadres.Rows(indice).Cells(1).Value = dgvMayoresHijos.Rows(indice).Cells(1).Value
                dgvMayoresPadres.Rows(indice).Cells(2).Value = dgvMayoresHijos.Rows(indice).Cells(2).Value
                dgvMayoresPadres.Rows(indice).Cells(3).Value = dgvMayoresHijos.Rows(indice).Cells(3).Value
                dgvMayoresPadres.Rows(indice).Cells(4).Value = dgvMayoresHijos.Rows(indice).Cells(4).Value
                dgvMayoresPadres.Rows(indice).Cells(5).Value = dgvMayoresHijos.Rows(indice).Cells(5).Value
            Next
        End Sub

        Private Sub CargarRegistrosMayores()
            Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.001"
            Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"
            Dim codCuenta = txtCuentaPadre.Text.Split("-")(0).Trim()

            dgvRegistros.DataSource = _objPlan.SeleccionarCuentasXRangoFechasXRangoCuentasAsientos(_tipoCon, fechaDesde, fechaHasta, codCuenta, CheckBox1.Checked)
            dgvRegistros.AutoResizeRows()
            dgvRegistros.AutoResizeColumns()

            Dim deudor As Decimal = 0.0
            Dim acreedor As Decimal = 0.0
            If dgvRegistros.Rows.Count > 0 Then
                For index = 0 To dgvRegistros.Rows.Count - 1 Step 1
                    deudor += CDec(dgvRegistros.Rows(index).Cells(3).Value)
                    acreedor += CDec(dgvRegistros.Rows(index).Cells(4).Value)
                Next
                txtDeudorRegistros.Text = deudor
                txtAcreedorRegistros.Text = acreedor
                txtSaldo.Text = Math.Round(Math.Abs(deudor - acreedor), 2)
            End If
        End Sub
        Private Sub dgvRegistros_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvRegistros.SelectionChanged
            If dgvRegistros.RowCount = 0 Or dgvRegistros.CurrentRow Is Nothing Then Return
            CargarAsiento()
        End Sub
        Private Sub CargarAsiento()
            dgvAsiento.DataSource = _objAsiento.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, dgvRegistros.CurrentRow.Cells(6).Value)
            Dim deudor As Decimal = 0.0
            Dim acreedor As Decimal = 0.0
            If dgvAsiento.Rows.Count > 0 Then
                For index = 0 To dgvAsiento.Rows.Count - 1 Step 1
                    deudor = deudor + dgvAsiento.Rows(index).Cells(6).Value
                    acreedor = acreedor + dgvAsiento.Rows(index).Cells(7).Value
                Next
                txtDeudorAsiento.Text = deudor
                txtAcreedorAsiento.Text = acreedor
                txtSaldoAsiento.Text = Math.Round(Math.Abs(deudor - acreedor), 2)
            End If
        End Sub
        Private Sub btnMayores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMayores.Click
            ExportarDatosExcel(dgvRegistros, "MAYORES", "MAYORES")
        End Sub
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvAsiento, "ASIENTO DE DIARIO", "ASIENTO_DIARIO")
        End Sub
        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String, ByVal sname As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    Return
                End If

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
                Dim foot = headin + dgvAsientosDiario.RowCount + 3
                worksheet.Cells(foot, 7).Value = "TOTAL DEBE"
                worksheet.Cells(foot, 7).Font.Bold = True
                worksheet.Cells(foot + 1, 7).Value = "TOTAL HABER"
                worksheet.Cells(foot + 1, 7).Font.Bold = True
                worksheet.Cells(foot + 2, 7).Value = "TOTAL SALDO"
                worksheet.Cells(foot + 2, 7).Font.Bold = True

                If sname.Equals("MAYORES") Then
                    worksheet.Cells(foot, 8).Value = txtDeudorRegistros.Text
                    worksheet.Cells(foot + 1, 8).Value = txtAcreedorRegistros.Text
                    worksheet.Cells(foot + 2, 8).Value = txtSaldo.Text
                Else
                    worksheet.Cells(foot, 8).Value = txtDeudorAsiento.Text
                    worksheet.Cells(foot + 1, 8).Value = txtAcreedorAsiento.Text
                    worksheet.Cells(foot + 2, 8).Value = txtSaldoAsiento.Text
                End If

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub REPORTEASIENTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTEASIENTOToolStripMenuItem.Click
            If dgvRegistros.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS QUE CARGAR. Primero realice una busqueda", MsgBoxStyle.Exclamation, "Mensaje de validación")
                Return
            End If

            Dim f = New FormReportMayorizacion
            f.cuenta = txtCuentaPadre.Text
            f.deudor = txtDeudorRegistros.Text
            f.acreedor = txtAcreedorRegistros.Text
            f.saldo = txtSaldo.Text
            f.DataGrid = dgvRegistros
            f.desde = dtpInicio.Value.ToString("dd/MM/yyyy")
            f.hasta = dtpFinal.Value.ToString("dd/MM/yyyy")
            f.TipoCox = TipoCox
            f.Show()
        End Sub

    End Class
End Namespace