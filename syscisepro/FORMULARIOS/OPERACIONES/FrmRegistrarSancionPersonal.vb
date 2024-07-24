Imports System.Data.SqlClient
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmRegistrarSancionPersonal

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
        Public IdUsuario As Integer
        Public UserName As String
        ReadOnly _objRegistroSancion As New ClassRegistroSancionPersonal
        ReadOnly _objPersonal As New ClassPersonal
        ReadOnly _objSitioTrabajo As New ClassSitiosTrabajo
        ReadOnly _objetoHistorial As New ClassHistorialLaboral
        ReadOnly _objvalid As New ClassDecimal
        Private _hoy As DateTime

        ReadOnly _objProgramacionOps As New ClassProgramacionOperaciones
        ReadOnly _objRegistroDescuento As New ClassDescuentosPersonal
        ReadOnly _objUser As New ClassUsuarioGeneral

        Dim _sqlCommands As List(Of SqlCommand)

        Private Sub FrmAsignarPuestoTrabajoOperaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label24.ForeColor = Color.White
                    Label24.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSanciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava

                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    Label24.ForeColor = Color.White
                    Label24.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSanciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    Label24.ForeColor = Color.White
                    Label24.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSanciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvSanciones.Font = New Font("Roboto", 8, FontStyle.Regular)
            _hoy = DateTime.Now
            dtpFecha.Value = _hoy
            dtpFechaDesde.Value = New DateTime(_hoy.Year, _hoy.Month, 1, 0, 0, 0)

            _sqlCommands = New List(Of SqlCommand)
            Label1.Text = "O REGISTRO(S) - TOTAL EN MULTAS: "
            Label2.Text = "$ 0.00"
            'txtMultador.Text = UserName
        End Sub

        Private Sub ExportarDatosExcel(ByVal listViewExp As ListView, ByVal titulo As String)
            Try
                Dim app As Excel._Application = New Excel.Application()
                Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

                worksheet.Name = "SANCIONES"

                Dim l = -1
                For i = 0 To listViewExp.Columns.Count - 1
                    If listViewExp.Columns(i).Width <> 0 Then l += 1
                Next

                Dim ic = NumToCharExcel(l)
                worksheet.Range("A1:" & ic & l).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = titulo
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Impresión: " + Date.Now
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se agregan las cabeceras de nuestro datagrid.
                Dim head = 6
                'Dim foot = head + listViewExp.Items.Count + 2

                Dim x = 1
                For i = 0 To listViewExp.Columns.Count - 1
                    If listViewExp.Columns(i).Width = 0 Then Continue For
                    worksheet.Cells(head, x) = listViewExp.Columns(i).Text
                    worksheet.Cells(head, x).Font.Bold = True
                    worksheet.Cells(head, x).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(head, x).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(head, x).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(head, x).Font.Color = Color.White
                    x += 1
                Next

                Dim t = 0.0
                head = 7
                For Each row As ListViewItem In listViewExp.Items
                    Dim y = 1
                    t += CDbl(row.SubItems(10).Text)
                    For j = 0 To listViewExp.Columns.Count - 1
                        If listViewExp.Columns(j).Width = 0 Then Continue For
                        worksheet.Cells(head, y) = row.SubItems(j).Text

                        ' definir bordes
                        worksheet.Cells(head, y).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(head, y).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If head = listViewExp.Items.Count + 6 Then worksheet.Cells(head, y).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        y += 1
                    Next
                    head += 1
                Next

                worksheet.Cells(head + 1, 2) = "TOTAL SANCIONES"
                worksheet.Cells(head + 1, 2).Font.Bold = True

                worksheet.Cells(head + 1, 6) = t.ToString("N")
                worksheet.Cells(head + 1, 6).Font.Bold = True

                worksheet.Range("A1:" & ic & (head * 2)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Function NumToCharExcel(ByVal i As Integer) As String
            Dim data() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", _
                          "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", _
                          "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ"}
            Return data(i)
        End Function

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            btnPersonalEntra.Enabled = True

            txtIdPersonal.Clear()
            txtPersonal.Clear()
            txtCargo.Clear()
            txtArea.Clear()

            txtIdPuesto.Clear()
            txtUbicacionPuesto.Clear()
            txtCliente.Clear()

            txtSancion.Enabled = False
            txtObservacion.Enabled = True
            dtpFecha.Enabled = True
            txtValor.Enabled = True
            dtpFecha.Value = _hoy
            txtSancion.Tag = Nothing
            txtSancion.Clear()
            txtValor.Clear()
            txtObservacion.Clear()
            txtCant.Value = 1
            txtTotal.Text = TotalMultas()
            txtIdSancion.Clear()
            txtMultador.Text = UserName
            dtpFecha.Tag = Nothing

            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnAnular.Enabled = False
            btnCancelar.Enabled = True
            bntSanciones.Enabled = True
        End Sub

        Private Function TotalMultas() As Decimal
            Dim c As Int32
            Dim v As Decimal
            Try
                c = If(txtCant.Text.Trim().Length = 0, 0, CInt(txtCant.Value))
                v = If(txtValor.Text.Trim().Length = 0, 0, CDec(txtValor.Text))
            Catch ex As Exception
                c = 0
                v = 0
            End Try
            Return c * v
        End Function

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Try
                txtTotal.Text = TotalMultas()
                If MessageBox.Show("Está seguro que desea guardar los cambios realizados", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If

                If txtIdPersonal.Text.Trim.Length = 0 Or txtValor.Text.Trim.Length = 0 Then
                    MessageBox.Show("Debe definir los datos de la sanción para guardar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                _sqlCommands.Clear()

                Dim fechaDesde = dtpFecha.Value.Year.ToString & "-" & dtpFecha.Value.Month.ToString & "-" & dtpFecha.Value.Day.ToString & " 00:00:00"
                Dim prog = _objProgramacionOps.SeleccionarProgramacionByFecha(_tipoCon, fechaDesde)

                _objRegistroSancion.IdSancion = _objRegistroSancion.BuscarMayorIdRegistroSancion(_tipoCon) + 1
                txtIdSancion.Text = _objRegistroSancion.IdSancion

                dtpFecha.Tag = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + 1

                ' REGISTRAR SANCION
                With _objRegistroSancion
                    .IdRegistro = txtIdSancion.Text.Trim
                    .IdPersonal = txtIdPersonal.Text.Trim
                    .IdSancion = CInt(txtSancion.Tag)
                    .Fecha = dtpFecha.Value
                    .Valor = txtTotal.Value
                    .Estado = 1
                    .Observacion = txtObservacion.Text.Trim
                    .Idsitio = If(txtIdPuesto.Text.Trim.Length = 0, 0, txtIdPuesto.Text.Trim)
                    .IdProg = If(prog.Rows.Count = 0, 0, CInt(prog.Rows(0).Item(0)))
                    .IdDescuento = dtpFecha.Tag.ToString
                    .Multador = txtMultador.Text
                End With
                _sqlCommands.Add(_objRegistroSancion.NuevoRegistroSancionDescuentoCommands())

                ' REGISTRAR HISTORIAL
                With _objetoHistorial
                    .IdHistorias = .BuscarMayorIdHistoriaLaboral(_tipoCon) + 1
                    .FechaHistoria = dtpFecha.Value
                    .DetalleHistoria = "REGISTRA SANCIÓN EN EL SITIO: " & txtUbicacionPuesto.Text & ", POR CONCEPTO DE: " & txtSancion.Text.Trim & " - " & txtObservacion.Text
                    .EstadoHistoria = 1
                    .IdPersonalHistoria = txtIdPersonal.Text.Trim
                    .IdSitioPuestoHistoria = If(txtIdPuesto.Text.Trim.Length = 0, 0, txtIdPuesto.Text.Trim)
                    .IdAuxiliares = txtIdSancion.Text.Trim
                End With
                _sqlCommands.Add(_objetoHistorial.RegistrarNuevoHistorialLaboralCommand())

                ' REGISTRAR DESCUENTO
                Dim fecha = dtpFecha.Value.Year.ToString & "-" & dtpFecha.Value.Month.ToString & "-" & dtpFecha.Value.Day.ToString & " 00:00:00"
                With _objRegistroDescuento
                    .IdRegistro = dtpFecha.Tag.ToString
                    .IdPersonal = txtIdPersonal.Text.Trim
                    .Fecha = fecha
                    .Procesado = 0
                    .Mes = dtpFecha.Value.Month
                    .Anio = dtpFecha.Value.Year
                    .IdRol = 0
                    .Tipo = 10
                    .Observacion = txtCant.Value & " - " & txtSancion.Text.Trim & " " & txtObservacion.Text.Trim
                    .Valor = txtTotal.Value
                    .Tipot = "DESCUENTO MULTAS / ATRASOS"
                End With
                _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())


                Dim user As String = _objUser.DatosUsuario.ToString()
                Dim nombreU As String = "REGISTRO SANCION " & user
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    btnPersonalEntra.Enabled = False
                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnAnular.Enabled = True
                    btnCancelar.Enabled = False
                    dtpFecha.Enabled = False
                    txtSancion.Enabled = False
                    txtValor.Enabled = False
                    txtObservacion.Enabled = False
                    bntSanciones.Enabled = False
                    txtFiltro.Clear()

                    CargarAsignaciones(String.Empty, _objRegistroSancion.IdSancion)
                End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                Dim messageIcon As KryptonMessageBoxIcon
                If res(0) Then
                    messageIcon = KryptonMessageBoxIcon.Information
                Else
                    messageIcon = KryptonMessageBoxIcon.Exclamation
                End If

                KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
            Catch ex As Exception
                MsgBox("ERROR AL GUARDAR HORARIO DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End Try
        End Sub

        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnular.Click
            Try
                If MessageBox.Show("Está seguro que desea anular el registro seleccionado?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If

                _sqlCommands.Clear()
                With _objRegistroSancion
                    .IdRegistro = txtIdSancion.Text.Trim
                    .Estado = 0
                End With
                _sqlCommands.Add(_objRegistroSancion.AnularRegistroSancionCommand())

                ' ANULAR DESCUENTO
                _objRegistroDescuento.IdRegistro = dtpFecha.Tag.ToString
                _sqlCommands.Add(_objRegistroDescuento.AnularRegistroDescuentoCommand())

                Dim user As String = _objUser.DatosUsuario.ToString()
                Dim nombreU As String = "SANCION ANULADA " & user
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    btnPersonalEntra.Enabled = False
                    txtSancion.Enabled = False
                    txtValor.Enabled = False
                    txtObservacion.Enabled = False
                    bntSanciones.Enabled = False
                    dtpFecha.Enabled = False
                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnAnular.Enabled = False
                    btnCancelar.Enabled = False

                    txtFiltro.Clear()
                    CargarAsignaciones(String.Empty, 0)
                End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                Dim messageIcon As KryptonMessageBoxIcon
                If res(0) Then
                    messageIcon = KryptonMessageBoxIcon.Information
                Else
                    messageIcon = KryptonMessageBoxIcon.Exclamation
                End If

                KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
            Catch ex As Exception
                MsgBox("ERROR AL GUARDAR HORARIO DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End Try
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            btnPersonalEntra.Enabled = False
            txtIdPersonal.Clear()
            txtPersonal.Clear()
            txtCargo.Clear()
            txtArea.Clear()

            txtIdPuesto.Clear()
            txtUbicacionPuesto.Clear()
            txtCliente.Clear()

            dtpFecha.Enabled = False
            txtSancion.Tag = Nothing
            txtSancion.Enabled = False
            txtValor.Enabled = False
            txtObservacion.Enabled = False
            bntSanciones.Enabled = False
            txtIdSancion.Text = String.Empty
            txtIdSancion.Clear()
            txtSancion.Clear()
            txtValor.Clear()
            txtObservacion.Clear()
            txtMultador.Clear()

            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnAnular.Enabled = False
            btnCancelar.Enabled = False

            Label1.Text = "O REGISTRO(S) - TOTAL EN MULTAS: "
            Label2.Text = "$ 0.00"


        End Sub

        Private Sub txtFiltro_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyUp
            CargarAsignaciones(txtFiltro.Text.Trim, 0)
        End Sub

        Private Sub CargarAsignaciones(ByVal filtro As String, ByVal selId As Int32)
            Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"

            Dim grupos = _objRegistroSancion.SeleccionarRegistroSancionesGrupos(_tipoCon, filtro, fechaDesde, fechaHasta)
            Dim datos = _objRegistroSancion.SeleccionarRegistroSancionesDatos2(_tipoCon, filtro, fechaDesde, fechaHasta)


            ListView1.Items.Clear()
            ListView1.Groups.Clear()


            ' grupos
            For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                ListView1.Groups.Add(group)
            Next


            dgvSanciones.DataSource = Nothing
            dgvSanciones.DataSource = _objRegistroSancion.SeleccionarRegistroSancionesDatos2(_tipoCon, filtro, fechaDesde, fechaHasta)
            'dgvSanciones.Columns.Add("GroupName", "Group")


            dgvSanciones.Columns("ID_REGISTRO").Width = 80
            dgvSanciones.Columns("SANCION").Width = 180
            dgvSanciones.Columns("ID_SANCION").Visible = False
            dgvSanciones.Columns("FECHA").Width = 80
            dgvSanciones.Columns("ID_PERSONAL").Visible = False
            dgvSanciones.Columns("NOMINA").Width = 250
            dgvSanciones.Columns("DESCRIPCION").HeaderText = "CARGO"
            dgvSanciones.Columns("DESCRIPCION").Width = 150
            dgvSanciones.Columns("AREA").Visible = False
            dgvSanciones.Columns("ID_SITIO").Visible = False
            dgvSanciones.Columns("SITIO_TRABAJO").HeaderText = "SITIO"
            dgvSanciones.Columns("SITIO_TRABAJO").Width = 150
            dgvSanciones.Columns("VALOR").Width = 60
            dgvSanciones.Columns("OBSERVACION").Width = 180
            dgvSanciones.Columns("ID_DESCUENTO").Width = 60
            dgvSanciones.Columns("MULTADOR").Width = 150



            dgvSanciones.AutoResizeRows()
            'For Each group As DataRow In grupos.Rows
            '    Dim groupName As String = group.Item(0).ToString.Trim
            '    dgvSanciones.Rows.Add(groupName)
            '    dgvSanciones.DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(_tipoCon)
            '    dgvSanciones.DefaultCellStyle.ForeColor = Color.White
            '    dgvSanciones.DefaultCellStyle.Font = New Font(dgvSanciones.Font, FontStyle.Bold)
            'Next


            ' detalles
            Dim t = 0.0
            Dim head As Integer = 0
            For Each row As DataRow In datos.Rows
                Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(1).ToString.Trim))
                t += Convert.ToDouble(row.Item(10))
                For i = 1 To datos.Columns.Count - 1
                    lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                Next
                ListView1.Items.Add(lst)
            Next

            ' lleno dgvSanciones 1

            

            'For Each row As DataRow In datos.Rows

            '    Dim groupName As String = row.Item(0).ToString.Trim
            '    Dim groupIndex As Integer = GetDataGridViewGroup(dgvSanciones, groupName)
            '    If groupIndex = -1 Then
            '        dgvSanciones.Rows.Add(groupName)
            '        groupIndex = dgvSanciones.Rows.Count - 1
            '    End If

            '    ' Set the values for each cell in the details row
            '    'Dim rowIndex As Integer = dgvSanciones.Rows.Count - 1 ' Index of the newly added row
            '    For i As Integer = 0 To datos.Columns.Count - 1
            '        ' Make sure the row index is valid
            '        If i < dgvSanciones.Columns.Count Then
            '            dgvSanciones.Rows(groupIndex).Cells(i).Value = If(row.Item(i) IsNot Nothing, row.Item(i).ToString(), String.Empty)
            '        End If
            '    Next


            'Next

            'lleno dgvSanciones 2

            'For Each row As DataRow In datos.Rows
            '    ' Add a row for each group in dgvSanciones
            '    Dim groupName As String = row.Item(0).ToString.Trim
            '    'dgvSanciones.Rows.Add(groupName)
            '    Dim groupIndex As Integer = GetDataGridViewGroup(dgvSanciones, groupName)



            '    If groupIndex = -1 Then
            '        dgvSanciones.Rows.Add(groupName)
            '        groupIndex = dgvSanciones.Rows.Count - 1


            '        dgvSanciones.Rows(groupIndex).DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(_tipoCon)
            '        dgvSanciones.Rows(groupIndex).DefaultCellStyle.ForeColor = Color.White
            '        dgvSanciones.Rows(groupIndex).DefaultCellStyle.Font = New Font(dgvSanciones.Font, FontStyle.Bold)
            '    End If



            '    'For i As Integer = 1 To datos.Columns.Count - 1
            '    '    ' Make sure the column index is valid
            '    '    If i < dgvSanciones.Columns.Count Then
            '    '        dgvSanciones.Rows(groupIndex).Cells(i).Value = If(row.Item(i) IsNot Nothing, row.Item(i).ToString(), String.Empty)
            '    '    End If
            '    'Next

            '    'For i As Integer = 0 To datos.Columns.Count - 1
            '    '    Dim columnName As String = datos.Columns(i).ColumnName
            '    '    If dgvSanciones.Columns.Cast(Of DataGridViewColumn)().Any(Function(col) col.Name = columnName) Then
            '    '        ' Column with this name already exists, skip
            '    '        Continue For
            '    '    End If
            '    '    dgvSanciones.Columns.Add(columnName, columnName)
            '    '    dgvSanciones.Columns(i + 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            '    'Next


            '    t += Convert.ToDouble(row.Item(10))
            'Next

            'esto vale
            'For i As Integer = 0 To datos.Columns.Count - 1
            '    dgvSanciones.Columns.Add(datos.Columns(i).ColumnName, datos.Columns(i).ColumnName)
            '    dgvSanciones.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'Next

            'Dim columnNames As String() = {"ID", "FECHA", "PERSONAL", "CARGO", "SITIO", "VALOR", "OBSERVACION"}
            'For Each columnName As String In columnNames
            '    dgvSanciones.Columns.Add(columnName, columnName)
            '    dgvSanciones.Columns(columnName).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'Next

            'For Each row As DataRow In datos.Rows
            '    ' Find the index of the group corresponding to the row's group name
            '    Dim groupName As String = row.Item(0).ToString.Trim
            '    Dim groupIndex As Integer = GetDataGridViewGroup(dgvSanciones, groupName)

            '    If groupIndex = -1 Then
            '        ' Add a new group if it doesn't exist
            '        dgvSanciones.Rows.Add(groupName)
            '        groupIndex = dgvSanciones.Rows.Count - 1
            '        dgvSanciones.Rows(groupIndex).DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(_tipoCon)
            '        dgvSanciones.Rows(groupIndex).DefaultCellStyle.ForeColor = Color.White
            '        dgvSanciones.Rows(groupIndex).DefaultCellStyle.Font = New Font(dgvSanciones.Font, FontStyle.Bold)
            '    End If


            '    While dgvSanciones.Rows(groupIndex).Cells.Count < datos.Columns.Count
            '        dgvSanciones.Rows(groupIndex).Cells.Add(New DataGridViewTextBoxCell())
            '    End While
            '    ' Add a new row and set its cell values
            '    'Dim rowIndex As Integer = dgvSanciones.Rows.Add()
            '    'For i As Integer = 0 To datos.Columns.Count - 1
            '    '    dgvSanciones.Rows(rowIndex).Cells(i).Value = If(row.Item(i) IsNot Nothing, row.Item(i).ToString(), String.Empty)
            '    'Next

            '    For i As Integer = 1 To datos.Columns.Count - 1 ' Start from 1 to skip the group name
            '        If i < dgvSanciones.Rows(groupIndex).Cells.Count Then ' Check if the cell index is valid
            '            dgvSanciones.Rows(groupIndex).Cells(i).Value = If(row.Item(i) IsNot Nothing, row.Item(i).ToString(), String.Empty)
            '        End If
            '    Next
            'Next

            '' autosize columns for dgvSanciones
            'For Each column As DataGridViewColumn In dgvSanciones.Columns
            '    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'Next



            ' autosize columns
            For Each column As ColumnHeader In ListView1.Columns
                If column.Width > 5 Then
                    column.Width = -2
                End If
            Next

            Label1.Text = datos.Rows.Count & " REGISTRO(S) - TOTAL EN MULTAS: "
            Label2.Text = "$ " & t.ToString("N")

            ' seleccionar el ultimo que ingreso
            If selId = 0 Then Return

            For Each row As ListViewItem In From row1 As ListViewItem In ListView1.Items Where row1.SubItems(0).Text.Trim.Equals(selId.ToString.Trim)
                row.EnsureVisible()
                ListView1.Items(row.Index).Selected = True
                ListView1.Select()
                Exit For
            Next
        End Sub

        
        Private Function GetDataGridViewGroup(ByVal dgv As DataGridView, ByVal nm As String) As Integer
            Dim groupIndex As Integer = -1

            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(i).Cells(0) IsNot Nothing AndAlso dgv.Rows(i).Cells(0).Value IsNot Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString().Trim = nm.Trim Then
                    groupIndex = i
                    Exit For
                End If
            Next

            Return groupIndex
        End Function

        Private Function GetListViewGroup(ByVal nm As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView1.Groups Where grupo1.ToString.Trim.Equals(nm.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub btnPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPersonalEntra.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        txtIdPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                        Try
                            Dim cr = _objPersonal.BuscarPersonalXIdPersonal(_tipoCon, frm.dgvCustodios.CurrentRow.Cells.Item(0).Value)
                            txtCargo.Text = cr.Rows(0)(60)
                            txtArea.Text = cr.Rows(0)(66)
                        Catch
                            txtCargo.Clear()
                            txtArea.Clear()
                        End Try

                        Dim data As DataTable
                        data = _objSitioTrabajo.SeleccionarSitiosFullClientexIdPersonal(_tipoCon, txtIdPersonal.Text)
                        If data Is Nothing Then Return
                        If data.Rows.Count = 0 Then
                            data = _objSitioTrabajo.SeleccionarSitiosFullClientexIdPersonal2(_tipoCon, txtIdPersonal.Text)
                        End If
                        If data Is Nothing Then Return

                        If data.Columns.Count = 1 Then
                            Dim p = data.Rows(0).Item(0).ToString.Trim().Split("|")
                            txtIdPuesto.Text = p(0).ToString
                            txtUbicacionPuesto.Text = p(1).ToString()
                            txtCliente.Text = p(2).ToString
                        Else
                            If data.Rows(0).Item(44).ToString.Trim().Length > 0 Then
                                Dim p = data.Rows(0).Item(44).ToString.Trim().Split("|")
                                txtIdPuesto.Text = p(0).ToString
                                txtUbicacionPuesto.Text = p(1).ToString()
                                txtCliente.Text = p(2).ToString
                            Else
                                txtIdPuesto.Text = data.Rows(0).Item(0).ToString
                                txtUbicacionPuesto.Text = data.Rows(0).Item(6).ToString
                                txtCliente.Text = data.Rows(0).Item(27).ToString
                            End If
                        End If

                    End If
                End If
            Catch ex As Exception
                txtPersonal.Text = "NO DEFINIDO"
                txtIdPersonal.Clear()
                txtCargo.Clear()
                txtArea.Clear()
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            txtFiltro.Clear()
            CargarAsignaciones(txtFiltro.Text.Trim, 0)
        End Sub

        Private Sub bntSanciones_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntSanciones.Click
            Dim frm As New FrmSeleccionarSancion
            frm.TipoCox = TipoCox
            Try
                If frm.ShowDialog = vbOK Then
                    txtSancion.Tag = frm.ListView1.SelectedItems(0).SubItems(0).Text
                    txtValor.Text = frm.ListView1.SelectedItems(0).SubItems(2).Text
                    txtSancion.Text = frm.ListView1.SelectedItems(0).Group.Header & " - " & frm.ListView1.SelectedItems(0).SubItems(1).Text
                End If
            Catch ex As Exception
                txtSancion.Text = "NO DEFINIDO"
                txtValor.Clear()
                txtSancion.Tag = Nothing
            End Try
        End Sub

        Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
            If ListView1.Items.Count > 0 Then
                Try
                    txtIdSancion.Text = ListView1.SelectedItems(0).SubItems(0).Text

                    txtIdPersonal.Text = ListView1.SelectedItems(0).SubItems(4).Text
                    txtPersonal.Text = ListView1.SelectedItems(0).SubItems(5).Text
                    txtCargo.Text = ListView1.SelectedItems(0).SubItems(6).Text
                    txtArea.Text = ListView1.SelectedItems(0).SubItems(7).Text

                    txtSancion.Tag = ListView1.SelectedItems(0).SubItems(2).Text
                    txtSancion.Text = ListView1.SelectedItems(0).SubItems(1).Text
                    txtValor.Text = ListView1.SelectedItems(0).SubItems(10).Text
                    txtObservacion.Text = ListView1.SelectedItems(0).SubItems(11).Text
                    txtMultador.Text = ListView1.SelectedItems(0).SubItems(13).Text

                    dtpFecha.Tag = ListView1.SelectedItems(0).SubItems(12).Text

                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnAnular.Enabled = True
                    btnCancelar.Enabled = False

                    Dim data = _objSitioTrabajo.SeleccionarSitiosFullClientexIdPersonal(_tipoCon, txtIdPersonal.Text)
                    If data Is Nothing Then Return
                    If data.Rows.Count = 0 Then Return
                    If data.Rows(0).Item(36).ToString.Trim().Length = 0 Then
                        Dim p = data.Rows(0).Item(36).ToString.Trim().Split("|")
                        txtIdPuesto.Text = p(0).ToString
                        txtUbicacionPuesto.Text = p(1).ToString()
                        txtCliente.Text = p(2).ToString
                    Else
                        txtIdPuesto.Text = data.Rows(0).Item(0).ToString
                        txtUbicacionPuesto.Text = data.Rows(0).Item(6).ToString
                        txtCliente.Text = data.Rows(0).Item(20).ToString
                    End If

                Catch
                    Exit Try
                End Try
            End If
        End Sub

        Private Sub txtValor_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
            e.Handled = Not _objvalid.EsDecimal(e.KeyChar)
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            ExportarDatosExcel(ListView1, "ASIGNACION DE PUESTOS DE TRABAJO")
        End Sub

        Private Sub txtCant_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCant.ValueChanged
            txtTotal.Text = TotalMultas()
        End Sub

        Private Sub txtValor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.TextChanged
            txtTotal.Text = TotalMultas()
        End Sub

        Private Sub AGRUPADOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGRUPADOSToolStripMenuItem.Click
            ExportarDatosExcel2(dgvSanciones, "ASIGNACION DE PUESTOS DE TRABAJO")
        End Sub

        Private Sub ExportarDatosExcel2(ByVal dgv As DataGridView, ByVal titulo As String)
            Try
                Dim app As Excel._Application = New Excel.Application()
                Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

                worksheet.Name = "SANCIONES"

                Dim l = -1
                For Each column As DataGridViewColumn In dgvSanciones.Columns
                    If column.Visible Then
                        l += 1
                    End If
                Next

                Dim ic = NumToCharExcel(l)
                worksheet.Range("A1:" & ic & l).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = titulo
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Impresión: " + Date.Now
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se agregan las cabeceras de nuestro datagrid.
                Dim head = 6
                'Dim foot = head + listViewExp.Items.Count + 2

                Dim x = 1
                For Each column As DataGridViewColumn In dgvSanciones.Columns
                    If column.Visible Then
                        worksheet.Cells(head, x) = column.HeaderText
                        worksheet.Cells(head, x).Font.Bold = True
                        worksheet.Cells(head, x).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(head, x).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        worksheet.Cells(head, x).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                        worksheet.Cells(head, x).Font.Color = Color.White
                        x += 1
                    End If
                Next

                Dim t = 0.0
                head = 7
                For Each row As DataGridViewRow In dgvSanciones.Rows
                    Dim y = 1
                    t += CDbl(row.Cells("VALOR").Value) ' Adjust the column name accordingly
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.OwningColumn.Visible Then
                            worksheet.Cells(head, y) = cell.Value.ToString()

                            ' Define borders
                            worksheet.Cells(head, y).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                            worksheet.Cells(head, y).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                            If head = dgvSanciones.Rows.Count + 6 Then
                                worksheet.Cells(head, y).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            End If
                            y += 1
                        End If
                    Next
                    head += 1
                Next

                worksheet.Cells(head + 1, 2) = "TOTAL SANCIONES"
                worksheet.Cells(head + 1, 2).Font.Bold = True

                worksheet.Cells(head + 1, 6) = t.ToString("N")
                worksheet.Cells(head + 1, 6).Font.Bold = True

                worksheet.Range("A1:" & ic & (head * 2)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
    End Class
End Namespace