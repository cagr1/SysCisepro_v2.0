Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.TALENTO_HUMANO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmSancionesPersonal

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
        Public UserName As String

        Dim _estadoAccion As Integer = 0
        ReadOnly _objSancionesPersonal As New ClassSanciones
         
        Private Sub CargarTiposSanciones()
            cbxTipo.Items.Clear()
            Dim tipos = _objSancionesPersonal.SeleccionarTiposSanciones(_tipoCon)

            For Each row As DataRow In tipos.Rows
                cbxTipo.Items.Add(row.Item(0))
            Next
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            cbxTipo.Enabled = True
            txtDefinicion.Enabled = True
            txtValor.Enabled = True

            cbxTipo.Text = String.Empty
            txtValor.Clear()
            txtDefinicion.Clear()

            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnAnular.Enabled = False
            btnCancelar.Enabled = True

            CargarTiposSanciones()


            txtIdSancion.Text = _objSancionesPersonal.BuscarMayorIdSancion(_tipoCon) + 1
            _estadoAccion = 1
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Try
                If MessageBox.Show("Está seguro que desea guardar los cambios realizados", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If

                If cbxTipo.Text.Trim.Length = 0 Or txtDefinicion.Text.Trim.Length = 0 Or txtValor.Text.Trim.Length = 0 Then
                    MessageBox.Show("Debe definir los datos de la sanción para guardar!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                _sqlCommands.Clear()
                If _estadoAccion = 1 Then ' nuevo
                    With _objSancionesPersonal

                        .IdSancion = .BuscarMayorIdSancion(_tipoCon) + 1
                        .Tipo = cbxTipo.Text.ToUpper.Trim
                        .Detalle = txtDefinicion.Text
                        .Valor = If(txtValor.Text.Trim.Length = 0, 0, Convert.ToDouble(txtValor.Text))
                        .Estado = 1
                        .Sancionpermiso = 0
                    End With
                    _sqlCommands.Add(_objSancionesPersonal.RegistrarNuevoSancionPersonalCommand())
                End If

                If _estadoAccion = 2 Then ' actualizar
                    With _objSancionesPersonal
                        .IdSancion = txtIdSancion.Text.Trim
                        .Tipo = cbxTipo.Text.ToUpper.Trim
                        .Detalle = txtDefinicion.Text
                        .Valor = If(txtValor.Text.Trim.Length = 0, 0, Convert.ToDouble(txtValor.Text))
                    End With
                    _sqlCommands.Add(_objSancionesPersonal.ModificarSancionPersonalCommand())
                End If
                Dim nombreU As String = String.Empty
                If _estadoAccion = 1 Then
                    nombreU = "INGRESO SANCION " & UserName
                ElseIf _estadoAccion = 2 Then
                    nombreU = "MODIFICACIÓN SANCION " & UserName
                End If
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    cbxTipo.Enabled = False
                    txtDefinicion.Enabled = False
                    txtValor.Enabled = False

                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnModificar.Enabled = True
                    btnAnular.Enabled = True
                    btnCancelar.Enabled = False
                    _estadoAccion = 0

                    txtFiltro.Clear()
                    CargarSanciones(String.Empty, _objSancionesPersonal.IdSancion)
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Catch ex As Exception
                MsgBox("ERROR AL GUARDAR HORARIO DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
            End Try
        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            cbxTipo.Enabled = True
            txtDefinicion.Enabled = True
            txtValor.Enabled = True

            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnAnular.Enabled = False
            btnCancelar.Enabled = True

            _objSancionesPersonal.Tipo = cbxTipo.SelectedItem.ToString
            CargarTiposSanciones()
            cbxTipo.SelectedItem = _objSancionesPersonal.Tipo

            _estadoAccion = 2
        End Sub

        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnular.Click
            Try
                If MessageBox.Show("Seguro que desea anular la sanción seleccionada?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If

                _sqlCommands.Clear()
                With _objSancionesPersonal
                    .IdSancion = txtIdSancion.Text
                    .Estado = 0
                End With
                _sqlCommands.Add(_objSancionesPersonal.AnularSancionPersonalCommand())


                Dim NombreU As String = "ANULACIÓN SANCION " & UserName

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, NombreU)
                If res(0) Then
                    txtIdSancion.Clear()
                    cbxTipo.Text = String.Empty
                    txtValor.Clear()
                    txtDefinicion.Clear()

                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnModificar.Enabled = False
                    btnAnular.Enabled = False
                    btnCancelar.Enabled = False
                    _estadoAccion = 0
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Catch ex As Exception
                MsgBox("ERROR AL GUARDAR HORARIO DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
            End Try
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            txtIdSancion.Clear()
            cbxTipo.Text = String.Empty
            txtValor.Clear()
            txtDefinicion.Clear()

            cbxTipo.Enabled = False
            txtDefinicion.Enabled = False
            txtValor.Enabled = False

            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnAnular.Enabled = True
            btnCancelar.Enabled = False
            _estadoAccion = 0
        End Sub

        Private Sub CargarSanciones(ByVal filtro As String, ByVal selId As Int32)
            Try
                Dim grupos = _objSancionesPersonal.SeleccionarTiposSanciones(_tipoCon)
                Dim datos = _objSancionesPersonal.SeleccionarSancionesFiltro(_tipoCon, filtro)

                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                ' grupos
                For Each row As DataRow In grupos.Rows
                    Dim group = New ListViewGroup(row.Item(0).ToString.Trim)
                    ListView1.Groups.Add(group)
                Next

                ' detalles
                For Each row As DataRow In datos.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(1).ToString.Trim))
                    For i = 1 To datos.Columns.Count - 1
                        If i = 1 Then ' excepto el titulode grupo (porque ya esta especificado en el grupo)
                            Continue For
                        End If
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next
                    ListView1.Items.Add(lst)
                Next

                ' seleccionar el ultimo que ingreso
                If selId = 0 Then Return

                For Each row As ListViewItem In ListView1.Items
                    If row.SubItems(0).Text.Trim.Equals(selId.ToString.Trim) Then
                        row.EnsureVisible()
                        ListView1.Items(row.Index).Selected = True
                        ListView1.Select()
                        Exit For
                    End If
                Next

            Catch ex As Exception
                ListView1.Items.Clear()
            End Try
        End Sub

        Private Function GetListViewGroup(ByVal name As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView1.Groups Where grupo1.ToString.Trim.Equals(name.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub FrmSancionesPersonal_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label21.ForeColor = Color.White
                    Label21.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    Label21.ForeColor = Color.White
                    Label21.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    Label21.ForeColor = Color.White
                    Label21.BackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            CargarTiposSanciones()

            _sqlCommands = New List(Of SqlCommand)
        End Sub

        Private Sub txtFiltro_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyUp
            If e.KeyCode = Keys.Enter Then
                CargarSanciones(txtFiltro.Text.Trim, 0)
            End If
        End Sub

        Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
            If ListView1.Items.Count > 0 Then
                Try
                    txtIdSancion.Text = ListView1.SelectedItems(0).SubItems(0).Text
                    cbxTipo.Text = ListView1.SelectedItems(0).Group.Header
                    txtValor.Text = ListView1.SelectedItems(0).SubItems(2).Text
                    txtDefinicion.Text = ListView1.SelectedItems(0).SubItems(1).Text

                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnModificar.Enabled = True
                    btnAnular.Enabled = True
                    btnCancelar.Enabled = False
                    _estadoAccion = 2
                Catch
                End Try
            End If
        End Sub
         
        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As ListView, ByVal titulo As String)

            Dim app As Excel._Application = New Excel.Application()
            Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

            worksheet.Name = titulo

            worksheet.Range("A1:Z" & dataGridViewExp.Items.Count + dataGridViewExp.Items.Count + 25).Font.Size = 10

            Dim ic = "E"

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
            Dim head = 4


            worksheet.Cells(1 + head, 1) = "ID"
            worksheet.Cells(1 + head, 2) = "TIPO DE SANCIÓN"
            worksheet.Cells(1 + head, 3) = "DETALLE"
            worksheet.Cells(1 + head, 4) = "VALOR"
            worksheet.Cells(1 + head, 5) = "ESTADO"
            For i As Integer = 1 To 5
                worksheet.Cells(1 + head, i).Font.Bold = True
                worksheet.Cells(1 + head, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(1 + head, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Cells(1 + head, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Cells(1 + head, i).Font.Color = Color.White
            Next

            Dim dataGridViewExpRowCount = 0
            For Each row As ListViewItem In dataGridViewExp.Items
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 0 + 1) = row.SubItems(0).Text
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 0 + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 0 + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 1 + 1) = row.Group.Header
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 1 + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 1 + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 2 + 1) = row.SubItems(1).Text
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 2 + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 2 + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 3 + 1) = row.SubItems(2).Text
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 3 + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 3 + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 4 + 1) = row.SubItems(3).Text
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 4 + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExpRowCount + 2 + head, 4 + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                worksheet.Cells(dataGridViewExp.Items.Count + 2 + head, 0 + 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExp.Items.Count + 2 + head, 1 + 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExp.Items.Count + 2 + head, 2 + 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExp.Items.Count + 2 + head, 3 + 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(dataGridViewExp.Items.Count + 2 + head, 4 + 1).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
                dataGridViewExpRowCount = dataGridViewExpRowCount + 1
            Next

            worksheet.Range("A1:Z" & dataGridViewExp.Items.Count + dataGridViewExp.Items.Count + 25).Columns.AutoFit()

            app.DisplayAlerts = False
            app.Visible = True
            app.DisplayAlerts = True
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            CargarSanciones(String.Empty, 0)
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
            CargarSanciones(String.Empty, 0)
            ConectarReporte()
        End Sub

        ReadOnly _crSancionesPersonal As New rptSancionesPersonal 

        Private Sub ConectarReporte()
            Try
                If ListView1.Items.Count = 0 Then
                    MessageBox.Show("NO SE HA SELECCIONADO DATOS PARA EXPORTAR!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                Dim ds As New dsOperaciones
                For Each item As ListViewItem In ListView1.Items
                    ds.Tables("SANCIONES_PERSONAL").Rows.Add(item.SubItems(0).Text, item.Group.Header, item.SubItems(1).Text, item.SubItems(2).Text, item.SubItems(3).Text)
                Next

                _crSancionesPersonal.SetDataSource(ds.Tables("SANCIONES_PERSONAL"))
                _crSancionesPersonal.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvSitios.ReportSource = _crSancionesPersonal
                crvSitios.Zoom(75)
                crvSitios.Refresh()
            Catch ex As Exception
            End Try
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            ExportarDatosExcel(ListView1, "TIPOS DE SANCIONES Y MULTAS")
        End Sub
    End Class
End Namespace