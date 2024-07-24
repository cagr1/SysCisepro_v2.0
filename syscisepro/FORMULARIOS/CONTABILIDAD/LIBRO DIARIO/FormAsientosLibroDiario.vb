Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.REPORTES
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA

Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAsientosLibroDiario
        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Private Get
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


        Private admin As Boolean
        Public Property IsAdmin() As Boolean
            Get
                Return admin
            End Get
            Set(ByVal value As Boolean)
                admin = value
            End Set
        End Property

        Dim _sqlCommands As List(Of SqlCommand)

        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""

        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _validacionesTexto As New ClassAlfanumerico

        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objUser As New ClassUsuarioGeneral

        Private Sub AutocompletarPlanCuentas()
            Try
                txtCuentaNueva.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtCuentaNueva.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txtCuentaNueva.AutoCompleteCustomSource = _objetoPlanCuentas.Autocompletar(_tipoCon)
            Catch
                txtCuentaNueva.AutoCompleteSource = Nothing
            End Try
        End Sub

        Private Sub FormAsientosLibroDiario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'CheckBox1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    CheckBox1.ForeColor = Color.White
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'CheckBox1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    CheckBox1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'CheckBox1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    CheckBox1.ForeColor = Color.White
            End Select
            CheckBox1.Visible = IsAdmin
            dgvAsientosDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            AutocompletarPlanCuentas()
        End Sub

        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            CargarAsientoLibroDiario()
        End Sub

        Private Sub CargarAsientoLibroDiario()
            Try
                _fechaDesde = dtpAsientoDesde.Value.Day.ToString & "-" & dtpAsientoDesde.Value.Month.ToString & "-" & dtpAsientoDesde.Value.Year.ToString & " 00:00:00"
                _fechaHasta = dtpAsientoHasta.Value.Day.ToString & "-" & dtpAsientoHasta.Value.Month.ToString & "-" & dtpAsientoHasta.Value.Year.ToString & " 23:59:59"

                Dim parametroBusqueda = If(rbNumero.Checked, 1, If(rbFecha.Checked, 2, If(rbCuenta.Checked, 3, 0)))
                Select Case parametroBusqueda
                    Case 0
                        dgvAsientosDiario.DataSource = _objetoAjustarAsientos.SeleccionarAsientosLibroDiario(_tipoCon)
                    Case 1
                        If (txtNumeroAsientoBuscar.Text.Trim.Length = 0) Then txtNumeroAsientoBuscar.Text = 0
                        dgvAsientosDiario.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, txtNumeroAsientoBuscar.Text)
                    Case 2
                        dgvAsientosDiario.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta)
                    Case 3
                        If txtCuentaNueva.Text.Trim.Length > 0 Then
                            dgvAsientosDiario.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXCodigoCuenta(_tipoCon, txtCuentaNueva.Text.Trim.Split(" ")(0), _fechaDesde, _fechaHasta)
                        End If
                    Case Else
                        MsgBox("NO HA SELECCIONADO UN PARAMETRO DE BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End Select

                If dgvAsientosDiario.RowCount = 0 Then Return

                dgvAsientosDiario.Columns(0).Width = 50
                dgvAsientosDiario.Columns(0).ReadOnly = True
                dgvAsientosDiario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvAsientosDiario.Columns(1).Width = 90
                dgvAsientosDiario.Columns(1).ReadOnly = True
                dgvAsientosDiario.Columns(1).DefaultCellStyle.Format = "g"
                dgvAsientosDiario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvAsientosDiario.Columns(2).Width = 100
                dgvAsientosDiario.Columns(2).ReadOnly = True
                dgvAsientosDiario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgvAsientosDiario.Columns(3).Width = 230

                dgvAsientosDiario.Columns(4).Width = 120
                dgvAsientosDiario.Columns(4).ReadOnly = True

                dgvAsientosDiario.Columns(5).Width = 400
                dgvAsientosDiario.Columns(5).ReadOnly = True

                dgvAsientosDiario.Columns(6).Width = 75
                dgvAsientosDiario.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(7).Width = 75
                dgvAsientosDiario.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(8).Width = 60
                dgvAsientosDiario.Columns(8).ReadOnly = True
                dgvAsientosDiario.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvAsientosDiario.Columns(9).Visible = False
                dgvAsientosDiario.Columns(10).Visible = False
                dgvAsientosDiario.Columns(11).Visible = False
                dgvAsientosDiario.Columns(12).Visible = False
                dgvAsientosDiario.AutoResizeRows()

            Catch ex As Exception
                dgvAsientosDiario.DataSource = Nothing
                MsgBox("CARGAR ASIENTOS DIARIO BUSQUEDA" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
            SumarTotalAsientoDiario()
        End Sub

        Private Sub SumarTotalAsientoDiario()
            Dim totalDebe = 0.0
            Dim totalHaber = 0.0
            Try
                For indice = 0 To dgvAsientosDiario.RowCount - 1
                    If dgvAsientosDiario.Rows(indice).Cells("EST").Value = 0 Then Continue For

                    totalDebe += CDec(dgvAsientosDiario.Rows(indice).Cells("DEBE").Value)
                    totalHaber += CDec(dgvAsientosDiario.Rows(indice).Cells("HABER").Value)

                    If CDec(dgvAsientosDiario.Rows(indice).Cells("DEBE").Value) > 0 Then
                        dgvAsientosDiario.Rows(indice).Cells("DEBE").Style.BackColor = Color.Cyan
                    ElseIf CDec(dgvAsientosDiario.Rows(indice).Cells("DEBE").Value) < 0 Then
                        dgvAsientosDiario.Rows(indice).Cells("DEBE").Style.BackColor = Color.IndianRed
                    End If

                    If CDec(dgvAsientosDiario.Rows(indice).Cells("HABER").Value) > 0 Then
                        dgvAsientosDiario.Rows(indice).Cells("HABER").Style.BackColor = Color.Cyan
                    ElseIf CDec(dgvAsientosDiario.Rows(indice).Cells("HABER").Value) < 0 Then
                        dgvAsientosDiario.Rows(indice).Cells("HABER").Style.BackColor = Color.IndianRed
                    End If
                Next
            Catch ex As Exception
                totalDebe = 0.0
                totalHaber = 0.0
                MsgBox("SUMAR ASIENTOS DIARIO" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try

            txtTotalDebe.Text = "$ " & totalDebe.ToString("N")
            txtTotalHaber.Text = "$ " & totalHaber.ToString("N")

            If txtTotalDebe.Text.Trim().Equals(txtTotalHaber.Text.Trim()) Then
                PictureBoxErrorSumaAsiento.Visible = False
                txtTotalDebe.ForeColor = Color.Black
                txtTotalHaber.ForeColor = Color.Black
            Else
                PictureBoxErrorSumaAsiento.Visible = True
                txtTotalDebe.ForeColor = Color.Red
                txtTotalHaber.ForeColor = Color.Red
            End If
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvAsientosDiario.Rows.Count = 0 Then
                MsgBox("NO HAY ASINETOS QUE CARGAR. PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel("ASIENTOS DE DIARIO", "LIBRO_DARIO", dtpAsientoDesde.Value, dtpAsientoHasta.Value)
        End Sub

        Private Sub rbNumero_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNumero.CheckedChanged
            If rbNumero.Checked = True Then
                txtCuentaNueva.Clear()
                txtNumeroAsientoBuscar.Clear()
                txtNumeroAsientoBuscar.Enabled = True
                dtpAsientoDesde.Enabled = True
                dtpAsientoHasta.Enabled = True
                txtCuentaNueva.Enabled = False
                txtNumeroAsientoBuscar.Focus()
            End If
        End Sub

        Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFecha.CheckedChanged
            If rbFecha.Checked = True Then
                txtCuentaNueva.Clear()
                txtNumeroAsientoBuscar.Clear()
                txtNumeroAsientoBuscar.Enabled = False
                dtpAsientoDesde.Enabled = True
                dtpAsientoHasta.Enabled = True
                txtCuentaNueva.Enabled = False
            End If
        End Sub

        Private Sub rbCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCuenta.CheckedChanged
            If rbCuenta.Checked = True Then
                txtCuentaNueva.Clear()
                txtNumeroAsientoBuscar.Clear()
                txtNumeroAsientoBuscar.Enabled = False
                dtpAsientoDesde.Enabled = True
                dtpAsientoHasta.Enabled = True
                txtCuentaNueva.Enabled = True
                txtCuentaNueva.Focus()
            End If
        End Sub

        Private Sub txtNumeroAsientoBuscar_KeyUp(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtNumeroAsientoBuscar.KeyUp
            If e.KeyCode <> 13 Then Return
            CargarAsientoLibroDiario()
        End Sub

        Private Sub txtNumeroAsientoBuscar_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtNumeroAsientoBuscar.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
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

                ''Aca se ingresa el detalle recorrera la tabla celda por celda                
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
                Dim foot = headin + dgvAsientosDiario.RowCount + 3
                worksheet.Cells(foot, 7).Value = "TOTAL DEBE"
                worksheet.Cells(foot, 7).Font.Bold = True
                worksheet.Cells(foot, 8).Value = txtTotalDebe.Text

                worksheet.Cells(foot + 1, 7).Value = "TOTAL HABER"
                worksheet.Cells(foot + 1, 7).Font.Bold = True
                worksheet.Cells(foot + 1, 8).Value = txtTotalHaber.Text

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
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtNumeroAsientoBuscar.Text.Trim.Length = 0 Or dgvAsientosDiario.RowCount = 0 Then
                MsgBox("POR FAVOR REVISE LAS TRANSACCIONES, DEBE SELECCIONAR UNA TRANSACCIÓN PARA ANULAR", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                Return
            End If

            If CType(txtNumeroAsientoBuscar.Text, Int32) < 10 Then
                MsgBox("POR FAVOR REVISE LAS TRANSACCIONES, DEBE SELECCIONAR UNA TRANSACCIÓN PARA ANULAR", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                Return
            End If

            If MessageBox.Show("DESEA GUARDAR LOS CAMBIOS REALIZADOS?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            Try
                SumarTotalAsientoDiario()

                If txtTotalDebe.Text.Trim().Equals(txtTotalHaber.Text.Trim()) Then

                    _sqlCommands.Clear()
                    Dim er = False

                    For indice = 0 To dgvAsientosDiario.RowCount - 1
                        If dgvAsientosDiario.Rows(indice).Cells(2).Value.ToString().Trim().Contains("NO EXISTE") Then
                            er = True
                            Exit For
                        End If

                        With _objetoAsientoLibroDiario
                            .IdAsiento = dgvAsientosDiario.Rows(indice).Cells(0).Value
                            .FechaAsiento = dgvAsientosDiario.Rows(indice).Cells(1).Value
                            .CodigoCuentaAsiento = dgvAsientosDiario.Rows(indice).Cells(2).Value
                            .NombreCuentaAsiento = dgvAsientosDiario.Rows(indice).Cells(3).Value
                            .ConceptoAsiento = dgvAsientosDiario.Rows(indice).Cells(4).Value.ToString.ToUpper
                            .DetalleTransaccionAsiento = dgvAsientosDiario.Rows(indice).Cells(5).Value.ToString.ToUpper
                            .ValorDebeAsiento = dgvAsientosDiario.Rows(indice).Cells(6).Value
                            .ValorHaberAsiento = dgvAsientosDiario.Rows(indice).Cells(7).Value
                            .NumeroRegistroAsiento = dgvAsientosDiario.Rows(indice).Cells(8).Value
                            .DebeHaberAsiento = dgvAsientosDiario.Rows(indice).Cells(9).Value
                            .ConciliarAsiento = 1
                            .EstadoAsiento = dgvAsientosDiario.Rows(indice).Cells(11).Value
                            .IdLibroDiario = dgvAsientosDiario.Rows(indice).Cells(12).Value
                            '.ModificarRegistroAsientoLibroDiario()
                        End With
                        _sqlCommands.Add(_objetoAsientoLibroDiario.ModificarRegistroAsientoLibroDiarioCommand())
                    Next

                    If er Then
                        MsgBox("NO SE PUEDE GUARDAR. LA CUENTA NO EXISTE EN SU PLAN DE CUENTAS, POR FAVOR REVISE LAS TRANSACCIONES.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                        Return
                    End If

                    Dim user As String = _objUser.DatosUsuario.ToString()
                    Dim nombreU As String = "AJUSTE EN BUSQUEDA LIBRO DIARIO " & user
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                    If res(0) Then btnBuscarAsiento.PerformClick()
                    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

                Else
                    MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LOS VALORES DE EL DEBE Y EL HABER NO COINCIDEN POR FAVOR REVISE LAS TRANSACCIONES.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dgvAsientosDiario_EditingControlShowing(ByVal sender As System.Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvAsientosDiario.EditingControlShowing
            Dim tBox = CType(e.Control, Windows.Forms.TextBox)
            tBox.CharacterCasing = CharacterCasing.Upper
            AddHandler tBox.KeyPress, AddressOf ItemType_KeyPress
            If dgvAsientosDiario.CurrentCell.ColumnIndex = 3 Then
                tBox.Multiline = False
                tBox.AutoCompleteSource = AutoCompleteSource.CustomSource
                tBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                tBox.AutoCompleteCustomSource = _objetoPlanCuentas.Autocompletar(_tipoCon)
            Else
                tBox.AutoCompleteMode = AutoCompleteMode.None
            End If
        End Sub

        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
            Select Case dgvAsientosDiario.CurrentCell.ColumnIndex
                Case 3
                    e.Handled = Not _validacionesTexto.EsAlfanumerico(e.KeyChar)
                Case 6, 7
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
                Case Else
                    e.Handled = True
            End Select
        End Sub

        Private Sub dgvAsientosDiario_CellEndEdit(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvAsientosDiario.CellEndEdit
            dgvAsientosDiario.Rows(e.RowIndex).ErrorText = [String].Empty
            If e.ColumnIndex = 3 Then
                Try
                    Dim codicuenta = dgvAsientosDiario.CurrentRow.Cells(3).Value.ToString.Trim()
                    Dim codigo = codicuenta.Split("-")(0).Trim
                    Dim cuenta = codicuenta.Replace((codigo.Trim & " - "), String.Empty).Trim

                    ' codigo
                    dgvAsientosDiario.CurrentRow.Cells(2).Value = codigo

                    ' cuenta
                    dgvAsientosDiario.CurrentRow.Cells(3).Value = cuenta
                Catch ex As Exception
                    dgvAsientosDiario.CurrentRow.Cells(2).Value = "CUENTA NO EXISTE!"
                End Try
            End If
            SumarTotalAsientoDiario()
        End Sub

        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnular.Click
            If txtNumeroAsientoBuscar.Text.Trim.Length = 0 Or dgvAsientosDiario.RowCount = 0 Or Not rbNumero.Checked Then
                MsgBox("POR FAVOR REVISE LAS TRANSACCIONES, DEBE SELECCIONAR UNA TRANSACCIÓN PARA ANULAR", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                Return
            End If

            If CType(txtNumeroAsientoBuscar.Text, Int32) < 10 Then
                MsgBox("POR FAVOR REVISE LAS TRANSACCIONES, DEBE SELECCIONAR UNA TRANSACCIÓN PARA ANULAR", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                Return
            End If

            If MessageBox.Show("DESEA ANULAR EL ASIENTO SELECCIONADO?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            Try
                _sqlCommands.Clear()

                For indice = 0 To dgvAsientosDiario.RowCount - 1
                    dgvAsientosDiario.Rows(indice).Cells("EST").Value = 0
                    With _objetoAsientoLibroDiario
                        .IdAsiento = dgvAsientosDiario.Rows(indice).Cells(0).Value
                        .FechaAsiento = dgvAsientosDiario.Rows(indice).Cells(1).Value
                        .CodigoCuentaAsiento = dgvAsientosDiario.Rows(indice).Cells(2).Value
                        .NombreCuentaAsiento = dgvAsientosDiario.Rows(indice).Cells(3).Value
                        .ConceptoAsiento = dgvAsientosDiario.Rows(indice).Cells(4).Value.ToString.ToUpper
                        .DetalleTransaccionAsiento = dgvAsientosDiario.Rows(indice).Cells(5).Value.ToString.ToUpper
                        .ValorDebeAsiento = dgvAsientosDiario.Rows(indice).Cells(6).Value
                        .ValorHaberAsiento = dgvAsientosDiario.Rows(indice).Cells(7).Value
                        .NumeroRegistroAsiento = dgvAsientosDiario.Rows(indice).Cells(8).Value
                        .DebeHaberAsiento = dgvAsientosDiario.Rows(indice).Cells(9).Value
                        .ConciliarAsiento = 1
                        .EstadoAsiento = dgvAsientosDiario.Rows(indice).Cells(11).Value
                        .IdLibroDiario = dgvAsientosDiario.Rows(indice).Cells(12).Value
                        '.ModificarRegistroAsientoLibroDiario()
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.ModificarRegistroAsientoLibroDiarioCommand())
                Next

                Dim user As String = _objUser.DatosUsuario.ToString()
                Dim nombreU As String = "ANULACION EN BSUQUEDA LIBRO DIARIO " & user
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then btnBuscarAsiento.PerformClick()
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                MsgBox("NO SE PUEDE GUARDAR." & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
            End Try

        End Sub

        Private Sub dgvAsientosDiario_CellBeginEdit(ByVal sender As System.Object, ByVal e As DataGridViewCellCancelEventArgs) Handles dgvAsientosDiario.CellBeginEdit
            If dgvAsientosDiario.RowCount = 0 Then Return
            If Not (e.ColumnIndex = 3 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7) Then Return
        End Sub

        Private Sub dgvAsientosDiario_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvAsientosDiario.SelectionChanged
            If dgvAsientosDiario.Rows.Count = 0 Or dgvAsientosDiario.CurrentRow Is Nothing Then Return
            If dgvAsientosDiario.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then Return
            txtNumeroAsientoBuscar.Text = dgvAsientosDiario.CurrentRow.Cells("ASIENTO").Value 
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            btnBuscarAsiento.PerformClick()
        End Sub

        Private Sub REPORTEASIENTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTEASIENTOToolStripMenuItem.Click
            If dgvAsientosDiario.Rows.Count = 0 Then
                MsgBox("NO HAY ASIENTOS QUE CARGAR. PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            Dim f = New FormReporteAsiento
            f.EsAsiento = True
            f.TipoCox = TipoCox
            f.NumeroRegistro = txtNumeroAsientoBuscar.Text
            f.Show()
        End Sub

        Private Sub TODOSLOSASIENTOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODOSLOSASIENTOSToolStripMenuItem.Click
            If dgvAsientosDiario.Rows.Count = 0 Then
                MsgBox("NO HAY ASIENTOS QUE CARGAR. PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            Dim f = New FormReporteAsiento
            f.EsAsiento = False
            f.debe = txtTotalDebe.Text
            f.haber = txtTotalHaber.Text
            f.DataGrid = dgvAsientosDiario
            f.desde = dtpAsientoDesde.Value.ToString("dd/MM/yyyy")
            f.hasta = dtpAsientoHasta.Value.ToString("dd/MM/yyyy")
            f.TipoCox = TipoCox
            f.NumeroRegistro = txtNumeroAsientoBuscar.Text
            f.Show()
        End Sub

        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            dgvAsientosDiario.CurrentCell = Nothing

            If CheckBox1.Checked Then
                For Each row As DataGridViewRow In dgvAsientosDiario.Rows 
                    If row.Cells("DEBE").Value = 0 And row.Cells("HABER").Value = 0 Then
                        row.Visible = False
                    End If
                Next
            Else
                For Each row As DataGridViewRow In dgvAsientosDiario.Rows
                    row.Visible = True
                Next
            End If

            SumarTotalAsientoDiario()
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

        End Sub
    End Class
End Namespace
