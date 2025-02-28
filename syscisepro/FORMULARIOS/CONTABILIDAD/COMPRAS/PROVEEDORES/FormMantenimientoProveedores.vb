Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports Microsoft.Office.Interop
Imports Krypton.Toolkit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormMantenimientoProveedores
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
        Public UserName As String

        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoCiudad As New ClassCiudades
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesText As New ClassAlfanumerico

        Dim _sqlCommands As List(Of SqlCommand)

        Dim _botonSeleccionado As New Integer

        Private Sub FormMantenimientoProveedores_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvProveedoresGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvProveedoresGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvProveedoresGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvProveedoresGeneral.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            cbxCiruc.SelectedIndex = 0
            DeshabilitadoInicio()
            txtBuscarProveedor.Focus()
        End Sub
        Private Sub DeshabilitadoInicio()
            txtIdProveedorGeneral.Enabled = False
            txtFechaProveedorGeneral.Enabled = False
            txtRucCiProveedorGeneral.Enabled = False
            txtRazonSocial.Enabled = False
            txtNombreComercialProveedorGeneral.Enabled = False
            cmbTipoProveedorGeneral.Enabled = False
            cmbContabilidadProveedorGeneral.Enabled = False
            cmbContribuyenteEspecial.Enabled = False
            txtDocContriEspProveedor.Enabled = False
            txtDireccionProveedorGeneral.Enabled = False
            txtNombreCiudad.Enabled = False
            txtTelefono1ProveedorGeneral.Enabled = False
            txtTelefono2ProveedorGeneral.Enabled = False
            txtEmailProveedorGeneral.Enabled = False
            cbxCiruc.Enabled = False
            cbxTipo.Enabled = False

            btnNuevoProveedorGeneral.Enabled = True
            btnModificarProveedorGeneral.Enabled = True
            btnCancelarProveedorGeneral.Enabled = False
            btnGuardarProveedorGeneral.Enabled = False
            btnExportar.Enabled = True
        End Sub
        Private Sub btnNuevoProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoProveedorGeneral.Click
            LimpiarParametros()
            HabilitadoNuevo()

            AutocompletarNombreCiudades()

            txtFechaProveedorGeneral.Text = ValidationForms.FechaActual(_tipoCon)
            _botonSeleccionado = 1
        End Sub
        Private Sub LimpiarParametros()
            txtIdProveedorGeneral.Text = ""
            txtFechaProveedorGeneral.Text = ""
            txtRucCiProveedorGeneral.Text = ""
            txtRazonSocial.Text = ""
            txtNombreComercialProveedorGeneral.Text = ""
            cmbTipoProveedorGeneral.Text = ""
            cbxTipo.SelectedIndex = 0
            cbxCiruc.SelectedIndex = 0
            cmbContabilidadProveedorGeneral.Text = ""
            txtDocContriEspProveedor.Text = ""
            cmbContribuyenteEspecial.Text = ""
            txtDireccionProveedorGeneral.Text = ""
            txtTelefono1ProveedorGeneral.Text = ""
            txtTelefono2ProveedorGeneral.Text = ""
            txtEmailProveedorGeneral.Text = ""
        End Sub
        Private Sub HabilitadoNuevo()
            cbxCiruc.SelectedIndex = 0
            txtIdProveedorGeneral.Enabled = False
            txtFechaProveedorGeneral.Enabled = True
            txtRucCiProveedorGeneral.Enabled = True
            txtRazonSocial.Enabled = True
            txtNombreComercialProveedorGeneral.Enabled = True
            cmbTipoProveedorGeneral.Enabled = True
            cbxTipo.Enabled = True
            cmbContabilidadProveedorGeneral.Enabled = True
            cmbContribuyenteEspecial.Enabled = True
            txtDocContriEspProveedor.Enabled = True
            txtDireccionProveedorGeneral.Enabled = True
            txtNombreCiudad.Enabled = True
            txtTelefono1ProveedorGeneral.Enabled = True
            txtTelefono2ProveedorGeneral.Enabled = True
            txtEmailProveedorGeneral.Enabled = True
            cbxCiruc.Enabled = True

            btnNuevoProveedorGeneral.Enabled = False
            btnModificarProveedorGeneral.Enabled = False
            btnCancelarProveedorGeneral.Enabled = True
            btnGuardarProveedorGeneral.Enabled = True
            btnExportar.Enabled = False
        End Sub
        Private Sub AutocompletarNombreCiudades()
            Try
                txtNombreCiudad.AutoCompleteCustomSource = _objetoCiudad.Autocompletar(_tipoCon)
                txtNombreCiudad.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreCiudad.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreCiudad.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub btnModificarProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarProveedorGeneral.Click
            If txtIdProveedorGeneral.Text = "" Then
                'MsgBox("NO HA SELECCIONA NINGÚN REGISTRO.", MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("No ha selecciona ningún registro.", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                HabilitadoModificar()
                _botonSeleccionado = 2
            End If
        End Sub
        Private Sub HabilitadoModificar()
            txtIdProveedorGeneral.Enabled = False
            txtFechaProveedorGeneral.Enabled = False
            txtRucCiProveedorGeneral.Enabled = True
            txtRazonSocial.Enabled = True
            txtNombreComercialProveedorGeneral.Enabled = True
            cmbTipoProveedorGeneral.Enabled = True
            cmbContabilidadProveedorGeneral.Enabled = True
            cmbContribuyenteEspecial.Enabled = True
            txtDocContriEspProveedor.Enabled = True
            txtDireccionProveedorGeneral.Enabled = True
            txtTelefono1ProveedorGeneral.Enabled = True
            txtTelefono2ProveedorGeneral.Enabled = True
            txtEmailProveedorGeneral.Enabled = True
            cbxCiruc.Enabled = True
            cbxTipo.Enabled = True

            btnNuevoProveedorGeneral.Enabled = False
            btnModificarProveedorGeneral.Enabled = False
            btnCancelarProveedorGeneral.Enabled = True
            btnGuardarProveedorGeneral.Enabled = True
        End Sub
        Private Sub btnCancelarProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarProveedorGeneral.Click
            LimpiarParametros()
            DeshabilitadoInicio()
        End Sub
        Private Sub txtBuscarProveedor_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBuscarProveedor.KeyUp
            If e.KeyValue <> 13 Then Return
            CargarProveedores()
        End Sub
        Private Sub CargarProveedores()
            Try
                dgvProveedoresGeneral.DataSource = _objetoProveedorGeneral.BuscarFiltradoPorRazonSocialProveedorGeneral(_tipoCon, txtBuscarProveedor.Text)
                dgvProveedoresGeneral.AutoResizeColumns()
                dgvProveedoresGeneral.Columns(0).HeaderText = "ID"
                dgvProveedoresGeneral.Columns(0).Width = 50
                dgvProveedoresGeneral.Columns(1).HeaderText = "FECHA"
                dgvProveedoresGeneral.Columns(1).Width = 90
                dgvProveedoresGeneral.Columns(1).DefaultCellStyle.Format = "g"
                dgvProveedoresGeneral.Columns(2).HeaderText = "RUC"
                dgvProveedoresGeneral.Columns(2).Width = 90
                dgvProveedoresGeneral.Columns(3).HeaderText = "RAZÓN SOCIAL"
                dgvProveedoresGeneral.Columns(3).Width = 300
                dgvProveedoresGeneral.Columns(4).HeaderText = "NOMBRE COMERCIAL"
                dgvProveedoresGeneral.Columns(4).Width = 300
                dgvProveedoresGeneral.Columns(5).HeaderText = "TIPO"
                dgvProveedoresGeneral.Columns(5).Width = 90
                dgvProveedoresGeneral.Columns(6).Visible = False
                dgvProveedoresGeneral.Columns(7).Visible = False
                dgvProveedoresGeneral.Columns(8).HeaderText = "DIRECCIÓN"
                dgvProveedoresGeneral.Columns(8).Width = 300
                dgvProveedoresGeneral.Columns(9).Visible = False
                dgvProveedoresGeneral.Columns(10).Visible = False
                dgvProveedoresGeneral.Columns(11).Visible = False
                dgvProveedoresGeneral.Columns(11).Visible = False
                dgvProveedoresGeneral.Columns(13).Visible = False

                dgvProveedoresGeneral.Columns(14).HeaderText = "IDENT."
                dgvProveedoresGeneral.Columns(15).HeaderText = "TIPO PRO."

                dgvProveedoresGeneral.ReadOnly = True
            Catch ex As Exception
                dgvProveedoresGeneral.DataSource = Nothing
            End Try
        End Sub

        Private Sub txtNombreCiudad_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreCiudad.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            lblIdCiudad.Text = _objetoCiudad.BuscarIdCiudadPorNombreCiudad(_tipoCon, txtNombreCiudad.Text)
        End Sub
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "PROVEEDORES"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvProveedoresGeneral)
                worksheet.Range("A1:" & ic & (dgvProveedoresGeneral.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  PROVEEDORES"
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: TODOS LOS PROVEEDORES REGISTRADOS"
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvProveedoresGeneral.Columns.Count - 1
                    If Not dgvProveedoresGeneral.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvProveedoresGeneral.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvProveedoresGeneral.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvProveedoresGeneral.Columns.Count - 1

                        If Not dgvProveedoresGeneral.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvProveedoresGeneral.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvProveedoresGeneral.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvProveedoresGeneral.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub txtRucCiProveedorGeneral_Validated(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtRucCiProveedorGeneral.Validated
            Dim r = _objetoProveedorGeneral.BuscarProveedorGeneralXRuc(_tipoCon, txtRucCiProveedorGeneral.Text.Trim)
            If r.Rows.Count > 0 Then
                If Not txtIdProveedorGeneral.Text.Trim.Equals(r(0)(0).ToString.Trim) Then
                    If txtRucCiProveedorGeneral.Text.Trim.Equals(r(0)(2)) Then
                        'MsgBox("ESTE C.I./R.U.C. YA SE ENCUANTRA REGISTRADO CON EL PROVEEDOR:" & vbNewLine & r(0)(3), MsgBoxStyle.Exclamation, "Mensaje de validación")
                        KryptonMessageBox.Show("Este C.I./R.U.C. ya se encuentra registrado con el proveedor:" & vbNewLine & r(0)(3), "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        txtRucCiProveedorGeneral.Focus()
                    End If
                End If
            End If
        End Sub

        Private Sub txtRucCiProveedorGeneral_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRucCiProveedorGeneral.KeyPress
            If (cbxCiruc.SelectedIndex = 0) Then
                e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
            Else
                e.Handled = Not _validacionesText.EsAlfanumerico(e.KeyChar)
            End If
        End Sub
        Private Sub txtTelefono1ProveedorGeneral_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono1ProveedorGeneral.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtTelefono2ProveedorGeneral_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtTelefono2ProveedorGeneral.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Function ValidacionParametros() As Boolean
            Return txtFechaProveedorGeneral.Text <> "" And txtRucCiProveedorGeneral.Text <> "" And txtRazonSocial.Text <> "" And txtNombreComercialProveedorGeneral.Text <> "" And cmbTipoProveedorGeneral.Text <> "" And cmbContabilidadProveedorGeneral.Text <> "" And cmbContribuyenteEspecial.Text <> "" And txtDireccionProveedorGeneral.Text <> "" And txtTelefono1ProveedorGeneral.Text <> "" And txtDocContriEspProveedor.Text <> ""
        End Function
        Private Sub btnGuardarProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarProveedorGeneral.Click
            If cbxCiruc.SelectedIndex = 0 And txtRucCiProveedorGeneral.Text.Trim.Length <> 10 Then
                'MessageBox.Show("La C.I. ingresada no es válida!", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KryptonMessageBox.Show("La C.I. ingresada no es válida!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            If cbxCiruc.SelectedIndex = 1 And txtRucCiProveedorGeneral.Text.Trim.Length <> 13 Then
                'MessageBox.Show("El R.U.C. ingresado no es válido!", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KryptonMessageBox.Show("El R.U.C. ingresado no es válido!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            Dim r = _objetoProveedorGeneral.BuscarProveedorGeneralXRuc(_tipoCon, txtRucCiProveedorGeneral.Text.Trim)
            If r.Rows.Count > 0 Then
                If Not txtIdProveedorGeneral.Text.Trim().Equals(r(0)(0).ToString().Trim()) Then
                    If txtRucCiProveedorGeneral.Text.Trim.Equals(r(0)(2)) Then
                        'MsgBox("ESTE C.I./R.U.C. YA SE ENCUANTRA REGISTRADO CON EL PROVEEDOR:" & vbNewLine & r(0)(3), MsgBoxStyle.Exclamation, "Mensaje de validación")
                        KryptonMessageBox.Show("Este C.I./R.U.C. ya se encuentra registrado con el proveedor:" & vbNewLine & r(0)(3), "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        txtRucCiProveedorGeneral.Focus()
                        Return
                    End If
                End If
            End If

            If ValidacionParametros() Then
                If KryptonMessageBox.Show("¿Esta segura que desea guardar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                'If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                _sqlCommands.Clear()


                Select Case (_botonSeleccionado)
                    Case 1
                        GuargarRegistroProveedorGeneralNuevo()

                    Case 2
                        GuargarRegistroProveedorGeneralModificar()

                End Select

                Dim nombreU As String = ""

                If _botonSeleccionado = 1 Then
                    nombreU = nombreU = "Creó un nuevo proveedor general. RUC: " + txtRucCiProveedorGeneral.Text & " por " & UserName
                ElseIf _botonSeleccionado = 2 Then
                    nombreU = "Modificó un proveedor general. RUC: " + txtRucCiProveedorGeneral.Text & " por " & UserName

                End If


                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    DeshabilitadoInicio()
                    LimpiarParametros()
                    txtBuscarProveedor.Focus()
                    _botonSeleccionado = 0

                    CargarProveedores()
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

                    Return
                End If

                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                'MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub Auditoria()
            With _objAuditoria
                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                '.NuevaAuditoria(_tipoCon)
            End With
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub
        Private Sub GuargarRegistroProveedorGeneralNuevo()
            With _objetoProveedorGeneral
                .IdProveedorGeneral = .BuscarMayorIdProveedorGeneral(_tipoCon) + 1
                .FechaProveedorGeneral = txtFechaProveedorGeneral.Text
                .RucProveedorGeneral = txtRucCiProveedorGeneral.Text.Trim
                .RazonSocialProveedorGeneral = txtRazonSocial.Text.ToUpper
                .NombreComercialProveedorGeneral = txtNombreComercialProveedorGeneral.Text.ToUpper
                .TipoProveedorGeneral = cmbTipoProveedorGeneral.Text.ToUpper
                .ContabilidadProveedorGeneral = cmbContabilidadProveedorGeneral.Text.ToUpper
                .ContribuyenteEspecialProveedorGeneral = cmbContribuyenteEspecial.Text.ToUpper
                .DireccionProveedorGeneral = txtDireccionProveedorGeneral.Text.ToUpper
                .IdCiudadProveedorGeneral = lblIdCiudad.Text
                .Telefono1ProveedorGeneral = txtTelefono1ProveedorGeneral.Text
                If txtTelefono2ProveedorGeneral.Text <> "" Then
                    .Telefono2ProveedorGeneral = txtTelefono2ProveedorGeneral.Text
                Else
                    .Telefono2ProveedorGeneral = "NO POSEE"
                End If
                If txtEmailProveedorGeneral.Text <> "" Then
                    .EmailProveedorGeneral = txtEmailProveedorGeneral.Text
                Else
                    .EmailProveedorGeneral = "NO POSEE"
                End If
                .EstadoProveedorGeneral = 1
                .TipoIdeProveedorGeneral = If(cbxCiruc.SelectedIndex = 1, "RUC", If(cbxCiruc.SelectedIndex = 2, "PAS", "CED"))
                .TipoPersonaProveedorGeneral = If(cbxTipo.SelectedIndex = 0, "PN", "SA")
                .DocumentoContriEspeProveedorGeneral = txtDocContriEspProveedor.Text
                '.NuevoRegistroProveedorGeneral(_tipoCon)
            End With
            _sqlCommands.Add(_objetoProveedorGeneral.NuevoRegistroProveedorGeneral)

            _sqlCommands.Add(_objetoProveedorGeneral.BorrarRegistroDetalleProveedorGeneral)

            _sqlCommands.Add(_objetoProveedorGeneral.NuevoRegistroDetalleProveedorGeneral)

            _objAuditoria.AccionAuditoria = "CREO UN NUEVO PROVEEDOR GENERAL. ID: " & _objetoProveedorGeneral.IdProveedorGeneral & " RUC: " + txtRucCiProveedorGeneral.Text + " RAZÓN SOCIAL: " + txtRazonSocial.Text + " TIPO: " + cmbTipoProveedorGeneral.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            Auditoria()
        End Sub
        Private Sub GuargarRegistroProveedorGeneralModificar()
            With _objetoProveedorGeneral
                .IdProveedorGeneral = txtIdProveedorGeneral.Text
                .FechaProveedorGeneral = txtFechaProveedorGeneral.Text
                .RucProveedorGeneral = txtRucCiProveedorGeneral.Text
                .RazonSocialProveedorGeneral = txtRazonSocial.Text.ToUpper
                .NombreComercialProveedorGeneral = txtNombreComercialProveedorGeneral.Text.ToUpper
                .TipoProveedorGeneral = cmbTipoProveedorGeneral.Text.ToUpper
                .ContabilidadProveedorGeneral = cmbContabilidadProveedorGeneral.Text.ToUpper
                .ContribuyenteEspecialProveedorGeneral = cmbContribuyenteEspecial.Text.ToUpper
                .DireccionProveedorGeneral = txtDireccionProveedorGeneral.Text.ToUpper
                .IdCiudadProveedorGeneral = lblIdCiudad.Text
                .Telefono1ProveedorGeneral = txtTelefono1ProveedorGeneral.Text
                If txtTelefono2ProveedorGeneral.Text <> "" Then
                    .Telefono2ProveedorGeneral = txtTelefono2ProveedorGeneral.Text
                Else
                    .Telefono2ProveedorGeneral = "NO POSEE"
                End If
                If txtEmailProveedorGeneral.Text <> "" Then
                    .EmailProveedorGeneral = txtEmailProveedorGeneral.Text
                Else
                    .EmailProveedorGeneral = "NO POSEE"
                End If
                .EstadoProveedorGeneral = 1
                .TipoIdeProveedorGeneral = If(cbxCiruc.SelectedIndex = 1, "RUC", If(cbxCiruc.SelectedIndex = 2, "PAS", "CED"))
                .TipoPersonaProveedorGeneral = If(cbxTipo.SelectedIndex = 0, "PN", "SA")
                .DocumentoContriEspeProveedorGeneral = txtDocContriEspProveedor.Text
                '.ModificarRegistroProveedorGeneral(_tipoCon)
            End With
            _sqlCommands.Add(_objetoProveedorGeneral.ModificarRegistroProveedorGeneral)

            _sqlCommands.Add(_objetoProveedorGeneral.BorrarRegistroDetalleProveedorGeneral)

            _sqlCommands.Add(_objetoProveedorGeneral.NuevoRegistroDetalleProveedorGeneral)

            _objAuditoria.AccionAuditoria = "MODIFICO UN PROVEEDOR GENERAL. ID: " + txtIdProveedorGeneral.Text + " RUC: " + txtRucCiProveedorGeneral.Text + " RAZÓN SOCIAL: " + txtRazonSocial.Text + " TIPO: " + cmbTipoProveedorGeneral.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            Auditoria()
        End Sub

        Private Sub cbxCiruc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCiruc.SelectedIndexChanged
            txtRucCiProveedorGeneral.Clear()
        End Sub

        Private Sub dgvProveedoresGeneral_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProveedoresGeneral.SelectionChanged
            If dgvProveedoresGeneral.RowCount = 0 Then
                LimpiarParametros()
                Return
            End If
            If dgvProveedoresGeneral.CurrentRow Is Nothing Then
                LimpiarParametros()
                Return
            End If
            If dgvProveedoresGeneral.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdProveedorGeneral.Text = ""
            Else
                txtIdProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(0).Value
                txtFechaProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(1).Value

                txtRazonSocial.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(3).Value
                txtNombreComercialProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(4).Value
                cmbTipoProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(5).Value
                cmbContabilidadProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(6).Value
                cmbContribuyenteEspecial.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(7).Value
                txtDireccionProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(8).Value
                lblIdCiudad.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(9).Value

                If (dgvProveedoresGeneral.CurrentRow.Cells.Item(14).Value.Equals("CED")) Then
                    cbxCiruc.SelectedIndex = 0
                ElseIf (dgvProveedoresGeneral.CurrentRow.Cells.Item(14).Value.Equals("RUC")) Then
                    cbxCiruc.SelectedIndex = 1
                Else
                    cbxCiruc.SelectedIndex = 2
                End If

                If (dgvProveedoresGeneral.CurrentRow.Cells.Item(15).Value.Equals("PN")) Then
                    cbxTipo.SelectedIndex = 0
                Else
                    cbxTipo.SelectedIndex = 1
                End If

                txtRucCiProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(2).Value
                txtNombreCiudad.Text = _objetoCiudad.BuscarNombreCiudadXIdCiudad(_tipoCon, lblIdCiudad.Text.Trim)
                txtTelefono1ProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(10).Value
                txtTelefono2ProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(11).Value
                txtEmailProveedorGeneral.Text = dgvProveedoresGeneral.CurrentRow.Cells.Item(12).Value
            End If
        End Sub
    End Class
End Namespace