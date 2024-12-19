Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS 
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormLibroBancos
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
        Public IdUsuario As Integer

        Dim objetoBancos As New ClassBancos
        Dim objetoCuentaBancos As New ClassCuentasBancos
        Dim objetoChequesEmitidos As New ClassChequesEmitidosCxp

        Dim tipoBusqueda As Integer = 0
        Dim fechaDesde As String = ""
        Dim fechaHasta As String = ""
        Dim fechaInicialSaldo As String = ""
        Dim fechaFinalSaldo As String = ""

        Dim inicialdeb = 0
        Dim inicialhab = 0
        Dim acumuladorDebe As Decimal = 0
        Dim acumuladorHaber As Decimal = 0

        Dim acuTotalNoCobrados As Decimal = 0
        Dim acuTotalCobradosMesAnterior As Decimal = 0
        Dim acuTotalCobradosMesActual As Decimal = 0
         
        Private Sub LlenarComboBancos()
            Try
                Dim data = objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboCuentasBancos()
            Try
                Dim data = objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, CInt(cmbBancos.SelectedValue))
                cmbCuentaBancos.DataSource = data
                cmbCuentaBancos.DisplayMember = data.Columns(1).ToString
                cmbCuentaBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbCuentaBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarLibroBancos()
            Try
                If tipoBusqueda = 1 Then
                    dgvLibroBancos.DataSource = objetoCuentaBancos.BuscarComprobantesEgresoIngresoBancosXBancoCtaFecha(_tipoCon, CInt(cmbBancos.SelectedValue), CInt(cmbCuentaBancos.SelectedValue), fechaDesde, fechaHasta, fechaInicialSaldo, fechaFinalSaldo)
                Else
                    dgvLibroBancos.DataSource = Nothing
                End If

                dgvLibroBancos.AutoResizeColumns()

                dgvLibroBancos.Columns(0).Width = 40
                dgvLibroBancos.Columns(1).Width = 50
                dgvLibroBancos.Columns(2).Width = 80
                dgvLibroBancos.Columns(3).Width = 60
                dgvLibroBancos.Columns(4).Width = 330
                dgvLibroBancos.Columns(5).Width = 72
                dgvLibroBancos.Columns(6).Width = 72
                dgvLibroBancos.Columns(7).Width = 70

                dgvLibroBancos.Rows(0).Cells(2).Value = ""
                dgvLibroBancos.ReadOnly = False

                dgvLibroBancos.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvLibroBancos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            Catch ex As Exception
                'MsgBox(ex.Message.ToString)
                'show meesage error and the text in ex.Message
                KryptonMessageBox.Show("Error en el metodo CargarLibros" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub CargarChequesEmitidosNoCobrados()
            Try
                dgvChequesEmitidosAprobados.Rows.Clear()
                dgvChequesEmitidosAprobados.Columns.Clear()

                Dim data = objetoChequesEmitidos.BuscarChequesEmitidosNoCobradosXRangoFechaMin(_tipoCon, "01-01-2013 00:00:00", fechaHasta, cmbBancos.Text, cmbCuentaBancos.Text)
                dgvChequesEmitidosAprobados.Columns.Add("ID", "ID")
                dgvChequesEmitidosAprobados.Columns.Add("EMISION", "EMISION")
                dgvChequesEmitidosAprobados.Columns.Add("NUMERO", "NUMERO")
                dgvChequesEmitidosAprobados.Columns.Add("BENEFICIARIO", "BENEFICIARIO")
                dgvChequesEmitidosAprobados.Columns.Add("VALOR", "VALOR")
                dgvChequesEmitidosAprobados.Columns.Add("EST", "EST")
                dgvChequesEmitidosAprobados.Columns.Add("EGRESO", "EGRESO")
                dgvChequesEmitidosAprobados.Columns.Add("COBRO", "COBRO")

                dgvChequesEmitidosAprobados.Columns("ID").Width = 40
                dgvChequesEmitidosAprobados.Columns("EMISION").Width = 80
                dgvChequesEmitidosAprobados.Columns("NUMERO").Width = 50
                dgvChequesEmitidosAprobados.Columns("BENEFICIARIO").Width = 250
                dgvChequesEmitidosAprobados.Columns("VALOR").Width = 60
                dgvChequesEmitidosAprobados.Columns("EST").Width = 40
                dgvChequesEmitidosAprobados.Columns("EGRESO").Width = 50
                dgvChequesEmitidosAprobados.Columns("COBRO").Width = 80

                For Each row As DataRow In data.Rows

                    If row.Item("EST") > 2 Then

                        If Convert.ToDateTime(row.Item("COBRO")) < Convert.ToDateTime(fechaDesde) Or Convert.ToDateTime(row.Item("COBRO")) < Convert.ToDateTime(fechaHasta) Then
                            Continue For
                        Else
                            dgvChequesEmitidosAprobados.Rows.Add(row.Item("ID"), row.Item("EMISION"), row.Item("NUMERO"),
                                                                 row.Item("BENEFICIARIO"), row.Item("VALOR"), row.Item("EST"),
                                                                 row.Item("EGRESO"), row.Item("COBRO"))
                        End If


                    Else
                        dgvChequesEmitidosAprobados.Rows.Add(row.Item("ID"), row.Item("EMISION"), row.Item("NUMERO"),
                                                             row.Item("BENEFICIARIO"), row.Item("VALOR"), row.Item("EST"),
                                                             row.Item("EGRESO"), "-")
                    End If

                Next
                Dim dt As New DataTable()

                ' Crear las columnas basadas en el DataGridView
                For Each column As DataGridViewColumn In dgvChequesEmitidosAprobados.Columns
                    dt.Columns.Add(column.HeaderText, GetType(String)) ' Todas las celdas como texto
                Next

                ' Rellenar el DataTable con las filas del DataGridView
                For Each row As DataGridViewRow In dgvChequesEmitidosAprobados.Rows
                    If Not row.IsNewRow Then ' Ignorar la fila nueva vacía
                        Dim dr As DataRow = dt.NewRow()
                        For Each column As DataGridViewColumn In dgvChequesEmitidosAprobados.Columns
                            dr(column.HeaderText) = row.Cells(column.Index).Value?.ToString() ' Maneja valores nulos
                        Next
                        dt.Rows.Add(dr)
                    End If
                Next


                label12.Text = "Emitidos (no cobrados) -> " & dgvChequesEmitidosAprobados.RowCount & "" '                                             Emitidos (cobrados) -> " & dgvEmitidosCobrados.RowCount & ""
                lblcobrados.Text = "Emitidos (Cobrados) -> " & dgvEmitidosCobrados.RowCount & ""
            Catch ex As Exception
                'MsgBox("Error al cargar cheques no cobrados")
                KryptonMessageBox.Show("Error al cargar cheques no cobrados" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub CargarChequesEmitidosCobradosEnMes()
            Try
                dgvEmitidosCobrados.DataSource = objetoChequesEmitidos.BuscarChequesEmitidosCobradosXRangoFechaCobroMin(_tipoCon, fechaDesde, fechaHasta, cmbBancos.Text, cmbCuentaBancos.Text)

                dgvEmitidosCobrados.Columns(0).Width = 50
                dgvEmitidosCobrados.Columns(1).Width = 85
                dgvEmitidosCobrados.Columns(2).Width = 50
                dgvEmitidosCobrados.Columns(3).Width = 250
                dgvEmitidosCobrados.Columns(4).Width = 65
                dgvEmitidosCobrados.Columns(5).Width = 40
                dgvEmitidosCobrados.Columns(6).Width = 60
                dgvEmitidosCobrados.Columns(7).Width = 70

                label12.Text = "Emitidos (no cobrados) -> " & dgvChequesEmitidosAprobados.RowCount & "" '                                             Emitidos (cobrados) -> " & dgvEmitidosCobrados.RowCount & ""
                lblcobrados.Text = "Emitidos (Cobrados) -> " & dgvEmitidosCobrados.RowCount & ""


            Catch ex As Exception
                'MsgBox("Error al cargar cheques cobrados")
                KryptonMessageBox.Show("Error al cargar cheques cobrados" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub SumarTotal()
            inicialdeb = 0
            inicialhab = 0

            acumuladorDebe = 0
            acumuladorHaber = 0

            Dim ci = 0
            Dim ce = 0
            For indiceSuma = 0 To (dgvLibroBancos.Rows.Count - 1)

                ' captura saldo inicial
                If dgvLibroBancos.Rows(indiceSuma).Cells(4).Value.ToString.Trim.Equals("ANTERIOR") Or dgvLibroBancos.Rows(indiceSuma).Cells(4).Value.ToString.Trim.StartsWith("SALDO INICIAL ") Then
                    If dgvLibroBancos.Rows(indiceSuma).Cells(5).Value.ToString <> "" Then
                        inicialdeb = CDec(dgvLibroBancos.Rows(indiceSuma).Cells(5).Value)
                    End If
                    If dgvLibroBancos.Rows(indiceSuma).Cells(6).Value.ToString <> "" Then
                        inicialhab = CDec(dgvLibroBancos.Rows(indiceSuma).Cells(6).Value)
                    End If
                Else
                    If dgvLibroBancos.Rows(indiceSuma).Cells(5).Value.ToString <> "" Then
                        acumuladorDebe = acumuladorDebe + CDec(dgvLibroBancos.Rows(indiceSuma).Cells(5).Value)
                    End If
                    If dgvLibroBancos.Rows(indiceSuma).Cells(6).Value.ToString <> "" Then
                        acumuladorHaber = acumuladorHaber + CDec(dgvLibroBancos.Rows(indiceSuma).Cells(6).Value)
                    End If
                End If

                ' resaltar color celdas de debe y haber 
                If dgvLibroBancos.Rows(indiceSuma).Cells("COD").Value = "CI" Then
                    dgvLibroBancos.Rows(indiceSuma).Cells("COD").Style.BackColor = Color.LightGoldenrodYellow
                    ci = ci + 1
                ElseIf dgvLibroBancos.Rows(indiceSuma).Cells("COD").Value = "CE" Then
                    dgvLibroBancos.Rows(indiceSuma).Cells("COD").Style.BackColor = Color.Cyan
                    ce = ce + 1
                Else
                    dgvLibroBancos.Rows(indiceSuma).DefaultCellStyle.BackColor = Color.Yellow
                End If
            Next

            txtSaldoInicial.Text = inicialdeb - inicialhab

            txtTotalDebe.Text = acumuladorDebe
            txtTotalHaber.Text = acumuladorHaber

            txtSaldoLibroBancos.Text = (inicialdeb - inicialhab) + acumuladorDebe - acumuladorHaber
            lblci.Text = "C.I: " & ci
            lblce.Text = "C.E: " & ce
        End Sub

        Private Sub SumarTotalEmitidosNoCobrados()
            acuTotalNoCobrados = 0
            For indice = 0 To dgvChequesEmitidosAprobados.RowCount - 1
                acuTotalNoCobrados = acuTotalNoCobrados + CDec(dgvChequesEmitidosAprobados.Rows(indice).Cells("VALOR").Value)
            Next
            txtTotalEmitidosNoCobrados.Text = acuTotalNoCobrados
        End Sub

        Private Sub SumarTotalEmitidosCobradosMesAnterior()
            acuTotalCobradosMesAnterior = 0
            acuTotalCobradosMesActual = 0
            For indice = 0 To dgvEmitidosCobrados.RowCount - 1
                If dgvEmitidosCobrados.Rows(indice).Cells(1).Value < fechaDesde Then ' si la fecha de cobro es anterior al rango de consulta
                    acuTotalCobradosMesAnterior = acuTotalCobradosMesAnterior + CDec(dgvEmitidosCobrados.Rows(indice).Cells("VALOR").Value)
                Else ' caso contrario la fecha de cobro esta en el rango de consulta
                    acuTotalCobradosMesActual = acuTotalCobradosMesActual + CDec(dgvEmitidosCobrados.Rows(indice).Cells("VALOR").Value)
                End If
            Next
            txtTotalEmitidosCobrados.Text = acuTotalCobradosMesActual ' Emitidos cobrados
            txtTotalEmitidosCobradosMesAnterior.Text = acuTotalCobradosMesAnterior ' Cobrados del mes anterior
        End Sub

        Private Sub FormLibroBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    'gbBanco.ForeColor = Color.White
                    'gbBanco.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'gbComandos.ForeColor = Color.White
                    'gbComandos.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'gbRangoFechas.ForeColor = Color.White
                    'gbRangoFechas.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvChequesEmitidosAprobados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvLibroBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEmitidosCobrados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvChequesEmitidosAprobados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvLibroBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvEmitidosCobrados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvChequesEmitidosAprobados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvLibroBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvEmitidosCobrados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvChequesEmitidosAprobados.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvLibroBancos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEmitidosCobrados.Font = New Font("Roboto", 8, FontStyle.Regular)

            tipoBusqueda = 1
            dtpDesde.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            LlenarComboBancos()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            Dim primero = Convert.ToDateTime(dtpDesde.Value.Year & "/" & dtpDesde.Value.Month & "/1")

            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            fechaDesde = primero.ToShortDateString & " 00:00:00"

            fechaHasta = primero.AddMonths(1).AddDays(-1).ToShortDateString & " 23:59:59"
            'fechaHasta = "2019-12-02 23:59:59"

            fechaInicialSaldo = "01-01-" & dtpDesde.Value.Year.ToString & " 00:00:00"
            fechaFinalSaldo = primero.AddDays(-1).ToShortDateString & " 23:59:59"

            CargarLibroBancos()

            SumarTotal()

            CargarChequesEmitidosNoCobrados()

            CargarChequesEmitidosCobradosEnMes()

            SumarTotalEmitidosNoCobrados()

            SumarTotalEmitidosCobradosMesAnterior()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvLibroBancos.Rows.Count = 0 Then Return
            Try
                Dim estCuenta = InputBox("Ingrese el valor del estado de cuenta", "ESTADO CUENTA", "0.00")

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "LIBRO_BANCO"
                 
                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvLibroBancos)
                worksheet.Range("A1:" & ic & (dgvLibroBancos.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = color.White
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Font.Size = 12

                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "LIBRO BANCO: " + cmbBancos.Text + "     CTA: " + cmbCuentaBancos.Text
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Período: " & ValidationForms.Mes(dtpDesde.Value.Month) & " - " & dtpDesde.Value.Year & "      Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12
                 

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                Dim footin = headin + dgvLibroBancos.RowCount + 3
                For i = 0 To dgvLibroBancos.Columns.Count - 1
                    If Not dgvLibroBancos.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvLibroBancos.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvLibroBancos.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvLibroBancos.Columns.Count - 1

                        If Not dgvLibroBancos.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvLibroBancos.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvLibroBancos.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next
                 

                worksheet.Range("A" + (footin + 2).ToString, "C" + (footin + 2).ToString).Merge()
                worksheet.Range("A" + (footin + 2).ToString, "C" + (footin + 2).ToString).Value = "COBRADOS DEL MES:"
                worksheet.Range("A" + (footin + 2).ToString, "C" + (footin + 2).ToString).Font.Bold = True
                worksheet.Range("D" + (footin + 2).ToString, "D" + (footin + 2).ToString).Value = acuTotalCobradosMesActual

                worksheet.Range("A" + (footin + 3).ToString, "C" + (footin + 3).ToString).Merge()
                worksheet.Range("A" + (footin + 3).ToString, "C" + (footin + 3).ToString).Value = "GIRADOS NO COBRADOS:"
                worksheet.Range("A" + (footin + 3).ToString, "C" + (footin + 3).ToString).Font.Bold = True
                worksheet.Range("D" + (footin + 3).ToString, "D" + (footin + 3).ToString).Value = acuTotalNoCobrados

                worksheet.Range("A" + (footin + 4).ToString, "C" + (footin + 4).ToString).Merge()
                worksheet.Range("A" + (footin + 4).ToString, "C" + (footin + 4).ToString).Value = "COBRADOS DEL MES ANTERIOR:"
                worksheet.Range("A" + (footin + 4).ToString, "C" + (footin + 4).ToString).Font.Bold = True
                worksheet.Range("D" + (footin + 4).ToString, "D" + (footin + 4).ToString).Value = acuTotalCobradosMesAnterior

                worksheet.Range("G" + (footin + 1).ToString, "G" + (footin + 1).ToString).Value = "SALDO ANTERIOR:"
                worksheet.Range("G" + (footin + 1).ToString, "G" + (footin + 1).ToString).Font.Bold = True
                worksheet.Range("H" + (footin + 1).ToString, "H" + (footin + 1).ToString).Value = inicialdeb - inicialhab
                worksheet.Range("G" + (footin + 2).ToString, "G" + (footin + 2).ToString).Value = "DEBE:"
                worksheet.Range("G" + (footin + 2).ToString, "G" + (footin + 2).ToString).Font.Bold = True
                worksheet.Range("H" + (footin + 2).ToString, "H" + (footin + 2).ToString).Value = acumuladorDebe
                worksheet.Range("G" + (footin + 3).ToString, "G" + (footin + 3).ToString).Value = "HABER:"
                worksheet.Range("G" + (footin + 3).ToString, "G" + (footin + 3).ToString).Font.Bold = True
                worksheet.Range("H" + (footin + 3).ToString, "H" + (footin + 3).ToString).Value = acumuladorHaber
                worksheet.Range("G" + (footin + 4).ToString, "G" + (footin + 4).ToString).Value = "SALDO:"
                worksheet.Range("G" + (footin + 4).ToString, "G" + (footin + 4).ToString).Font.Bold = True
                worksheet.Range("H" + (footin + 4).ToString, "H" + (footin + 4).ToString).Value = (inicialdeb - inicialhab) + acumuladorDebe - acumuladorHaber


                worksheet.Range("A" + (footin + 6).ToString, "H" + (footin + 6).ToString).Merge()
                worksheet.Range("A" + (footin + 6).ToString, "H" + (footin + 6).ToString).Value = ValidationForms.NombreCompany(_tipoCon)
                worksheet.Range("A" + (footin + 6).ToString, "H" + (footin + 6).ToString).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A" + (footin + 6).ToString, "H" + (footin + 6).ToString).Font.Bold = True
                worksheet.Range("A" + (footin + 6).ToString, "H" + (footin + 6).ToString).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A" + (footin + 6).ToString, "H" + (footin + 6).ToString).Font.Color = color.White

                worksheet.Range("A" + (footin + 7).ToString, "F" + (footin + 7).ToString).Merge()
                worksheet.Range("A" + (footin + 7).ToString, "F" + (footin + 7).ToString).Value = "LIBRO BANCO: " + cmbBancos.Text + "     CTA: " + cmbCuentaBancos.Text

                worksheet.Range("A" + (footin + 8).ToString, "F" + (footin + 8).ToString).Merge()
                worksheet.Range("A" + (footin + 8).ToString, "F" + (footin + 8).ToString).Value = ("Período: " & ValidationForms.Mes(dtpDesde.Value.Month) & " - " & dtpDesde.Value.Year)


                worksheet.Range("A" + (footin + 10).ToString, "D" + (footin + 10).ToString).Merge()
                worksheet.Range("A" + (footin + 10).ToString, "D" + (footin + 10).ToString).Value = "SALDO ANTERIOR"
                worksheet.Range("A" + (footin + 10).ToString, "D" + (footin + 10).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 10).ToString, "H" + (footin + 10).ToString).Merge()
                worksheet.Range("E" + (footin + 10).ToString, "H" + (footin + 10).ToString).Value = inicialdeb - inicialhab

                worksheet.Range("A" + (footin + 11).ToString, "D" + (footin + 11).ToString).Merge()
                worksheet.Range("A" + (footin + 11).ToString, "D" + (footin + 11).ToString).Value = "+ INGRESO MES ACTUAL"
                worksheet.Range("A" + (footin + 11).ToString, "D" + (footin + 11).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 11).ToString, "H" + (footin + 11).ToString).Merge()
                worksheet.Range("E" + (footin + 11).ToString, "H" + (footin + 11).ToString).Value = acumuladorDebe

                worksheet.Range("A" + (footin + 12).ToString, "D" + (footin + 12).ToString).Merge()
                worksheet.Range("A" + (footin + 12).ToString, "D" + (footin + 12).ToString).Value = " CHEQUE DEVUELTO"
                worksheet.Range("A" + (footin + 12).ToString, "D" + (footin + 12).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 12).ToString, "H" + (footin + 12).ToString).Merge()
                worksheet.Range("E" + (footin + 12).ToString, "H" + (footin + 12).ToString).Value = 0

                worksheet.Range("A" + (footin + 13).ToString, "D" + (footin + 13).ToString).Merge()
                worksheet.Range("A" + (footin + 13).ToString, "D" + (footin + 13).ToString).Value = "- EGRESO DEL MES"
                worksheet.Range("A" + (footin + 13).ToString, "D" + (footin + 13).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 13).ToString, "H" + (footin + 13).ToString).Merge()
                worksheet.Range("E" + (footin + 13).ToString, "H" + (footin + 13).ToString).Value = acumuladorHaber

                worksheet.Range("A" + (footin + 14).ToString, "D" + (footin + 14).ToString).Merge()
                worksheet.Range("A" + (footin + 14).ToString, "D" + (footin + 14).ToString).Value = " SALDO LIBROS"
                worksheet.Range("A" + (footin + 14).ToString, "D" + (footin + 14).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 14).ToString, "H" + (footin + 14).ToString).Merge()
                worksheet.Range("E" + (footin + 14).ToString, "H" + (footin + 14).ToString).Value = (inicialdeb - inicialhab) + acumuladorDebe - acumuladorHaber


                worksheet.Range("A" + (footin + 16).ToString, "D" + (footin + 16).ToString).Merge()
                worksheet.Range("A" + (footin + 16).ToString, "D" + (footin + 16).ToString).Value = " SALDO ESTADO DE CUENTA"
                worksheet.Range("A" + (footin + 16).ToString, "D" + (footin + 16).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 16).ToString, "H" + (footin + 16).ToString).Merge()
                worksheet.Range("E" + (footin + 16).ToString, "H" + (footin + 16).ToString).Value = estCuenta

                worksheet.Range("A" + (footin + 17).ToString, "D" + (footin + 17).ToString).Merge()
                worksheet.Range("A" + (footin + 17).ToString, "D" + (footin + 17).ToString).Value = "- CHEQUES GIRADOS Y NO COBRADOS"
                worksheet.Range("A" + (footin + 17).ToString, "D" + (footin + 17).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 17).ToString, "H" + (footin + 17).ToString).Merge()
                worksheet.Range("E" + (footin + 17).ToString, "H" + (footin + 17).ToString).Value = acuTotalNoCobrados

                worksheet.Range("A" + (footin + 18).ToString, "D" + (footin + 18).ToString).Merge()
                worksheet.Range("A" + (footin + 18).ToString, "D" + (footin + 18).ToString).Value = "- CHEQUES DEVUELTO"
                worksheet.Range("A" + (footin + 18).ToString, "D" + (footin + 18).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 18).ToString, "H" + (footin + 18).ToString).Merge()
                worksheet.Range("E" + (footin + 18).ToString, "H" + (footin + 18).ToString).Value = 0

                worksheet.Range("A" + (footin + 19).ToString, "D" + (footin + 19).ToString).Merge()
                worksheet.Range("A" + (footin + 19).ToString, "D" + (footin + 19).ToString).Value = "- CHEQUES BLOQUEADO"
                worksheet.Range("A" + (footin + 19).ToString, "D" + (footin + 19).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 19).ToString, "H" + (footin + 19).ToString).Merge()
                worksheet.Range("E" + (footin + 19).ToString, "H" + (footin + 19).ToString).Value = 0

                worksheet.Range("A" + (footin + 20).ToString, "D" + (footin + 20).ToString).Merge()
                worksheet.Range("A" + (footin + 20).ToString, "D" + (footin + 20).ToString).Value = "SALDO CONCILIADO"
                worksheet.Range("A" + (footin + 20).ToString, "D" + (footin + 20).ToString).Font.Bold = True
                worksheet.Range("E" + (footin + 20).ToString, "H" + (footin + 20).ToString).Merge()
                worksheet.Range("E" + (footin + 20).ToString, "H" + (footin + 20).ToString).Value = estCuenta - acuTotalNoCobrados

                worksheet.Range("A1:" & ic & (dgvLibroBancos.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub txtSaldoLibroBancos_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtSaldoLibroBancos.TextChanged

            If CType(txtSaldoLibroBancos.Text, Decimal) < 0 Then
                txtSaldoLibroBancos.ForeColor = Color.Red
            Else
                txtSaldoLibroBancos.ForeColor = Color.Green
            End If
            txtSaldoLibroBancos.ReadOnly = True
        End Sub

        Private Sub cmbBancos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBancos.SelectedValueChanged
            LlenarComboCuentasBancos()
        End Sub

    End Class
End Namespace