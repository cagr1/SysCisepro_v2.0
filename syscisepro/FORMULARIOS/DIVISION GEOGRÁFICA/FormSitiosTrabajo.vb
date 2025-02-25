Imports System.Data.SqlClient
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports Krypton.Toolkit
Imports ClosedXML.Excel
Imports System.IO

Namespace FORMULARIOS.DIVISION_GEOGRÁFICA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormSitiosTrabajo
        Private _tipoCon As TipoConexion
        Public UserName As String
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
        Dim _sqlCommands As List(Of SqlCommand)

        ReadOnly _validacionesDecimales As New ClassDecimal

        ReadOnly _objetoSitio As New ClassSitiosTrabajo
        ReadOnly _objProvincias As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _objPer As New ClassPersonal
        ReadOnly _crSitiosCisepro As New crSitiosTrabajo

        Dim _botonSeleccionadoSitio As Integer = 0

        Private Sub ConectarReporte()
            Try
                _crSitiosCisepro.SetDataSource(_objetoSitio.SeleccionarSitiosTrabajo(_tipoCon))
                _crSitiosCisepro.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvSitios.ReportSource = _crSitiosCisepro
                crvSitios.Zoom(75)
                crvSitios.Refresh()
            Catch ex As Exception
            End Try
        End Sub

        Private Sub LlenarComboGrupos()
            Dim data = _objetoSitio.SeleccionarGruposSitioTrabajo(_tipoCon)
            cbmGrupo.DataSource = data
            cbmGrupo.DisplayMember = "grupo"
            cbmGrupo.ValueMember = "grupo"
            cbmGrupo.DropDownWidth = 450
        End Sub

        Private Sub CargarSitiosClienteGeneral(ByVal filtro As String, ByVal selId As Int32)
            Try
                LlenarSupervisores()
                LlenarProvincia()

                Dim grupos = _objetoSitio.SeleccionarSitiosTrabajo2Grupos(_tipoCon, filtro, cbxFiltro.SelectedIndex)
                Dim datos = _objetoSitio.SeleccionarSitiosTrabajo2(_tipoCon, filtro, cbxFiltro.SelectedIndex)

                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                ' grupos
                For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                    ListView1.Groups.Add(group)
                Next

                ' detalles
                For Each row As DataRow In datos.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(18).ToString.Trim, ListView1))
                    lst.UseItemStyleForSubItems = False

                    For i = 1 To datos.Columns.Count - 1
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next

                    If row.Item(14).ToString.Equals("0") Then
                        lst.SubItems(1).BackColor = Color.FromArgb(255, 240, 128, 128)
                        lst.SubItems(14).BackColor = Color.FromArgb(255, 240, 128, 128)
                    End If

                    ListView1.Items.Add(lst)
                Next

                ' AutoSize columns
                For Each column As ColumnHeader In From column1 As ColumnHeader In ListView1.Columns Where column1.Width > 5
                    column.Width = -2
                Next

                ' seleccionar el ultimo que ingreso
                If ListView1.Items.Count = 0 Then Return

                If selId = 0 Then
                    ListView1.Items(0).EnsureVisible()
                    ListView1.Items(0).Selected = True
                    ListView1.Select()
                Else
                    For Each row As ListViewItem In From row1 As ListViewItem In ListView1.Items Where row1.SubItems(0).Text.Trim.Equals(selId.ToString.Trim)
                        row.EnsureVisible()
                        ListView1.Items(row.Index).Selected = True
                        ListView1.Select()
                        Exit For
                    Next
                End If

            Catch ex As Exception
                ListView1.Items.Clear()
            End Try
        End Sub

        Private Function GetListViewGroup(ByVal namer As String, ByVal list As ListView) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In list.Groups Where grupo1.ToString.Trim.Equals(namer.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoSitio.Click
            LlenarComboGrupos()
            LlenarProvincia()
            LlenarSupervisores()

            btnBuscarPersonal.Enabled = True

            cbmGrupo.SelectedValue = "GENERAL"

            cbmProvincia.SelectedValue = 7

            txtNombreSitio.Clear()

            txtDireccion.Clear()
            txtReferencia.Clear()

            txtLatitud.Clear()
            txtLongitud.Clear()
            txtRiver.Clear()

            cbmProvincia.Enabled = True
            cbmCanton.Enabled = True
            cbmParroquia.Enabled = True
            txtNombreSitio.Enabled = True

            txtDireccion.Enabled = True
            txtReferencia.Enabled = True
            txtLatitud.Enabled = True
            txtLongitud.Enabled = True
            txtRiver.Enabled = True

            cbmGrupo.Enabled = True
            cbxSupervisor.Enabled = False
            cbxSupervisor.SelectedValue = 468 ' economista

            cbxHorasPuesto.Enabled = True

            txtHorasNormal.Enabled = True
            txtHoras50.Enabled = True
            txtHoras100.Enabled = True
            txtHorasFeria.Enabled = True
            txtHorasNoct.Enabled = True
            txtAdicional.Enabled = True
            chkExtra.Enabled = True

            Label23.Text = "..."
            cbxTipoIdentificacion.Text = ""
            txtCiRuc.Clear()
            txtClienteComercial.Clear()
            txtCliente.Clear()

            txtHorasNormal.Text = 0
            txtHoras50.Text = 0
            txtHoras100.Text = 0
            txtHorasFeria.Text = 0
            txtHorasNoct.Text = 0
            txtAdicional.Text = 0
            chkExtra.Checked = False

            btnCargarSitios.Enabled = True ' cargar
            btnNuevoSitio.Enabled = False ' nuevo
            btnGuardarSitio.Enabled = True ' guardar
            btnActualizarSitio.Enabled = False ' actualizar
            btnAnularSitio.Enabled = False ' anular
            btnCancelarSitio.Enabled = True ' cancelar
            btnExportarSitio.Enabled = ListView1.Items.Count > 0 ' exportar

            _botonSeleccionadoSitio = 1
            txtNombreSitio.Focus()
        End Sub

        Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSitio.Click
            Try
                If Label23.Text = "..." Or txtCiRuc.Text.Trim.Length = 0 Then
                    'MessageBox.Show("Por favor, seleccione un cliente para este sitio / punto!", "VALIDACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    KryptonMessageBox.Show("Por favor, seleccione un cliente para este sitio / punto!", "VALIDACION DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If txtRiver.Text.Trim.Length = 0 Then
                    'MessageBox.Show("Por favor, asigne el número de river para este sitio / punto!", "VALIDACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    KryptonMessageBox.Show("Por favor, asigne el número de river para este sitio / punto!", "VALIDACION DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                Dim s = _objetoSitio.ExisteNumeroRiverActivo(_tipoCon, Label28.Text.Trim, txtRiver.Text.Trim)
                If s.Trim.Length > 0 Then
                    'MessageBox.Show("El N° de river que intenta regisrar ya está asignado al sitio: " & s, "VALIDACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    KryptonMessageBox.Show("El N° de river que intenta regisrar ya está asignado al sitio: " & s, "VALIDACION DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If
                _sqlCommands.Clear()

                'If MessageBox.Show("Desea guardar los cambios realizados?", "VALIDACION DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then Return
                If KryptonMessageBox.Show("Desea guardar los cambios realizados?", "VALIDACION DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Exclamation) <> DialogResult.Yes Then Return

                If cbmGrupo.SelectedValue Is Nothing Then
                    Dim g = _objetoSitio.SeleccionarGruposSitioTrabajo(_tipoCon, cbmGrupo.Text)
                    If g.Rows.Count = 0 Then _sqlCommands.Add(_objetoSitio.GuardarGruposSitioTrabajoCommand(cbmGrupo.Text))
                End If

                If _botonSeleccionadoSitio = 1 Then ' nuevo
                    With _objetoSitio
                        .Id = .BuscarMayorIdSitio(_tipoCon) + 1
                        .IdProvincia = cbmProvincia.SelectedValue
                        .IdCiudad = cbmCanton.SelectedValue
                        .IdParroquia = cbmParroquia.SelectedValue
                        .Direccion = txtDireccion.Text.ToUpper
                        .Referencia = txtReferencia.Text.ToUpper
                        .Nombre = txtNombreSitio.Text.ToUpper
                        .Tipo = "FIJO"
                        .Cliente = Label23.Text.Trim
                        .Supervisor = cbxSupervisor.SelectedValue
                        .Latitud = txtLatitud.Text.Trim
                        .Longitud = txtLongitud.Text.Trim
                        .Estado = 1
                        .River = txtRiver.Text.Trim
                        .Grupo = cbmGrupo.Text
                        .Riv = NumeroRiver(txtRiver.Text.Trim)
                        .HorasPuesto = CInt(cbxHorasPuesto.SelectedValue)
                        .CantHorasNor = If(txtHorasNormal.Text.Trim().Length = 0, 0, CDec(txtHorasNormal.Text.Trim))
                        .CantHoras50 = If(txtHoras50.Text.Trim().Length = 0, 0, CDec(txtHoras50.Text.Trim))
                        .CantHoras100 = If(txtHoras100.Text.Trim().Length = 0, 0, CDec(txtHoras100.Text.Trim))
                        .CantHorasExt = If(txtHorasFeria.Text.Trim().Length = 0, 0, CDec(txtHorasFeria.Text.Trim))
                        .CantRecNoct = If(txtHorasNoct.Text.Trim().Length = 0, 0, CDec(txtHorasNoct.Text.Trim))
                        .CantAdicional = If(txtAdicional.Text.Trim().Length = 0, 0, CDec(txtAdicional.Text.Trim))
                        .DecimosConExtra = chkExtra.Checked

                    End With
                    _sqlCommands.Add(_objetoSitio.RegistrarNuevoSitioTrabajoCommand())
                End If

                If _botonSeleccionadoSitio = 2 Then ' actualizar
                    With _objetoSitio
                        .Id = Label28.Text.Trim
                        .IdProvincia = cbmProvincia.SelectedValue
                        .IdCiudad = cbmCanton.SelectedValue
                        .IdParroquia = cbmParroquia.SelectedValue
                        .Direccion = txtDireccion.Text.ToUpper
                        .Referencia = txtReferencia.Text.ToUpper
                        .Nombre = txtNombreSitio.Text.ToUpper
                        .Tipo = "FIJO"
                        .Cliente = Label23.Text.Trim
                        .Supervisor = cbxSupervisor.SelectedValue
                        .Estado = 1
                        .Latitud = txtLatitud.Text.Trim
                        .Longitud = txtLongitud.Text.Trim
                        .River = txtRiver.Text.Trim
                        .Grupo = cbmGrupo.Text
                        .Riv = NumeroRiver(txtRiver.Text.Trim)
                        .HorasPuesto = CInt(cbxHorasPuesto.SelectedValue)
                        .CantHorasNor = If(txtHorasNormal.Text.Trim().Length = 0, 0, CDec(txtHorasNormal.Text.Trim))
                        .CantHoras50 = If(txtHoras50.Text.Trim().Length = 0, 0, CDec(txtHoras50.Text.Trim))
                        .CantHoras100 = If(txtHoras100.Text.Trim().Length = 0, 0, CDec(txtHoras100.Text.Trim))
                        .CantHorasExt = If(txtHorasFeria.Text.Trim().Length = 0, 0, CDec(txtHorasFeria.Text.Trim))
                        .CantRecNoct = If(txtHorasNoct.Text.Trim().Length = 0, 0, CDec(txtHorasNoct.Text.Trim))
                        .CantAdicional = If(txtAdicional.Text.Trim().Length = 0, 0, CDec(txtAdicional.Text.Trim))
                        .DecimosConExtra = chkExtra.Checked
                    End With
                    _sqlCommands.Add(_objetoSitio.ModificarSitioTrabajoCommand())
                End If

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then

                    btnBuscarPersonal.Enabled = False
                    cbmProvincia.Enabled = False
                    cbmCanton.Enabled = False
                    cbmParroquia.Enabled = False
                    txtNombreSitio.Enabled = False
                    cbmGrupo.Enabled = False

                    txtDireccion.Enabled = False
                    txtReferencia.Enabled = False
                    cbxSupervisor.Enabled = False
                    txtLatitud.Enabled = False
                    txtLongitud.Enabled = False
                    txtRiver.Enabled = False

                    cbxHorasPuesto.Enabled = False
                    txtHorasNormal.Enabled = False
                    txtHoras50.Enabled = False
                    txtHoras100.Enabled = False
                    txtHorasFeria.Enabled = False
                    txtHorasNoct.Enabled = False
                    txtAdicional.Enabled = False
                    chkExtra.Enabled = False

                    btnCargarSitios.Enabled = True ' cargar
                    btnNuevoSitio.Enabled = True ' nuevo
                    btnGuardarSitio.Enabled = False ' guardar
                    btnActualizarSitio.Enabled = ListView1.SelectedItems.Count > 0 ' catualizar
                    btnAnularSitio.Enabled = ListView1.SelectedItems.Count > 0 ' anular
                    btnCancelarSitio.Enabled = False ' cancelar
                    btnExportarSitio.Enabled = ListView1.Items.Count > 0 ' exportar

                    LlenarComboGrupos()

                    _botonSeleccionadoSitio = 0
                    CargarSitiosClienteGeneral(txtFiltro.Text.Trim, _objetoSitio.Id)
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If
                'End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                'MsgBox("ERROR AL GUARDAR SITIO DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Error al guardar sitio de trabajo: " & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Function NumeroRiver(ByVal river As String) As Integer
            Dim nriver = (From c In river Where Char.IsDigit(c)).Aggregate(String.Empty, Function(current, c) current + c)
            Try
                Return Convert.ToInt32(nriver.Trim)
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnActualizarSitio.Click
            If ListView1.Items.Count = 0 Or ListView1.SelectedItems.Count = 0 Then
                Return
            End If

            LlenarComboGrupos()
            cbmGrupo.SelectedValue = ListView1.SelectedItems(0).SubItems(22).Text

            cbmProvincia.Enabled = True
            cbmCanton.Enabled = True
            cbmParroquia.Enabled = True
            txtNombreSitio.Enabled = True

            txtDireccion.Enabled = True
            txtReferencia.Enabled = True
            cbmGrupo.Enabled = True
            btnBuscarPersonal.Enabled = True
            cbxSupervisor.Enabled = False
            txtLatitud.Enabled = True
            txtLongitud.Enabled = True
            txtRiver.Enabled = True

            cbxHorasPuesto.Enabled = True
            txtHorasNormal.Enabled = True
            txtHoras50.Enabled = True
            txtHoras100.Enabled = True
            txtHorasFeria.Enabled = True
            txtHorasNoct.Enabled = True
            txtAdicional.Enabled = True
            chkExtra.Enabled = True

            _botonSeleccionadoSitio = 2

            btnCargarSitios.Enabled = True ' cargar
            btnNuevoSitio.Enabled = False ' nuevo
            btnGuardarSitio.Enabled = True ' guardar
            btnActualizarSitio.Enabled = False ' catualizar
            btnAnularSitio.Enabled = False ' anular
            btnCancelarSitio.Enabled = True ' cancelar
            btnExportarSitio.Enabled = ListView1.Items.Count > 0 ' exportar

            txtNombreSitio.Focus()
        End Sub

        Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnularSitio.Click

            'If MessageBox.Show("Seguro que desea anular este Sitio de Trabajo?", "ANULAR SITIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If KryptonMessageBox.Show("Seguro que desea anular este Sitio de Trabajo?", "ANULAR SITIO", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.Yes Then
                _sqlCommands.Clear()
                With _objetoSitio
                    .Id = Label28.Text
                    .Estado = 0
                End With
                _sqlCommands.Add(_objetoSitio.ModificarEstadoSitioTrabajoCommand())

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    _botonSeleccionadoSitio = 0
                    btnCargarSitios.Enabled = True ' cargar
                    btnNuevoSitio.Enabled = True ' nuevo
                    btnGuardarSitio.Enabled = False ' guardar
                    btnActualizarSitio.Enabled = ListView1.SelectedItems.Count > 0 ' catualizar
                    btnAnularSitio.Enabled = ListView1.SelectedItems.Count > 0 ' anular
                    btnCancelarSitio.Enabled = False ' cancelar
                    btnExportarSitio.Enabled = ListView1.Items.Count > 0 ' exportar

                    CargarSitiosClienteGeneral("", 0)
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If
                'End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            End If
            'End If
            'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

        End Sub

        Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarSitio.Click
            cbmProvincia.SelectedIndex = 1
            cbmGrupo.SelectedValue = "GENERAL"
            txtNombreSitio.Clear()
            txtDireccion.Clear()
            txtReferencia.Clear()
            txtLatitud.Clear()
            txtLongitud.Clear()

            btnBuscarPersonal.Enabled = False
            cbmProvincia.Enabled = False
            cbmCanton.Enabled = False
            cbmParroquia.Enabled = False
            txtNombreSitio.Enabled = False
            txtDireccion.Enabled = False
            txtReferencia.Enabled = False
            txtLatitud.Enabled = False
            txtLongitud.Enabled = False
            txtRiver.Enabled = False
            cbxSupervisor.Enabled = False
            cbxSupervisor.SelectedValue = 468 ' economista
            cbmGrupo.Enabled = False

            cbxHorasPuesto.Enabled = False
            txtHorasNormal.Enabled = False
            txtHoras50.Enabled = False
            txtHoras100.Enabled = False
            txtHorasFeria.Enabled = False
            txtHorasNoct.Enabled = False
            txtAdicional.Enabled = False
            chkExtra.Enabled = False

            Label23.Text = "..."
            cbxTipoIdentificacion.Text = ""

            txtHorasNormal.Clear()
            txtHoras50.Clear()
            txtHoras100.Clear()
            txtHorasFeria.Clear()
            txtHorasNoct.Clear()
            txtAdicional.Clear()
            chkExtra.Checked = False

            txtCiRuc.Clear()
            txtClienteComercial.Clear()
            txtCliente.Clear()

            _botonSeleccionadoSitio = 0

            btnCargarSitios.Enabled = True ' cargar
            btnNuevoSitio.Enabled = True ' nuevo
            btnGuardarSitio.Enabled = False ' guardar
            btnActualizarSitio.Enabled = ListView1.SelectedItems.Count > 0 ' catualizar
            btnAnularSitio.Enabled = ListView1.SelectedItems.Count > 0 ' anular
            btnCancelarSitio.Enabled = False ' cancelar
            btnExportarSitio.Enabled = ListView1.Items.Count > 0

            CargarSitiosClienteGeneral("", 0)
        End Sub

        Private Sub cbmProvincia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmProvincia.SelectedValueChanged
            If cbmProvincia.SelectedValue Is Nothing Or TypeOf cbmProvincia.SelectedValue Is DataRowView Then Return
            LlenarCiudad()
        End Sub

        Private Sub LlenarCiudad()
            Try
                Dim cius = _objCiudad.BuscarNombreCiudadXIdProvincia(_tipoCon, cbmProvincia.SelectedValue.ToString)
                cbmCanton.DataSource = cius
                cbmCanton.DisplayMember = "NOMBRE_CIUDADES"
                cbmCanton.ValueMember = "ID_CIUDAD"
                cbmCanton.DropDownWidth = cbmCanton.DropDownWidth + 50
                cbmCanton.SelectedIndex = 0
            Catch ex As Exception
                cbmCanton.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmCanton_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCanton.SelectedValueChanged
            If cbmCanton.SelectedValue Is Nothing Or TypeOf cbmCanton.SelectedValue Is DataRowView Then Return
            LlenarParroquia()
        End Sub

        Private Sub LlenarParroquia()
            Try
                Dim pars As DataTable = _objParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, cbmCanton.SelectedValue.ToString)
                cbmParroquia.DataSource = pars
                cbmParroquia.DisplayMember = "NOMBRE_PARROQUIAS"
                cbmParroquia.ValueMember = "ID_PARROQUIAS"
                cbmParroquia.DropDownWidth = cbmParroquia.DropDownWidth + 50
                cbmParroquia.SelectedIndex = 0
            Catch ex As Exception
                cbmParroquia.DataSource = Nothing
            End Try
        End Sub

        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Dim formBuscar As New FrmBuscarProveedorCliente
            formBuscar.TipoCox = TipoCox
            formBuscar.rbtProveedor.Visible = False
            formBuscar.rbtPersonal.Visible = False
            formBuscar.rbtCliente.Checked = True
            formBuscar.rbtCliente.Enabled = False
            formBuscar.txtParametrobusqueda.Width = formBuscar.txtParametrobusqueda.Width + formBuscar.rbtProveedor.Width + formBuscar.rbtPersonal.Width
            formBuscar.Todos = True

            DialogResult = formBuscar.ShowDialog

            Try
                If DialogResult = vbOK Then
                    Label23.Text = formBuscar.dgvCustodios.CurrentRow.Cells(0).Value
                    cbxTipoIdentificacion.Text = formBuscar.dgvCustodios.CurrentRow.Cells(2).Value
                    txtCiRuc.Text = formBuscar.dgvCustodios.CurrentRow.Cells(3).Value
                    txtClienteComercial.Text = formBuscar.dgvCustodios.CurrentRow.Cells(4).Value
                    txtCliente.Text = formBuscar.dgvCustodios.CurrentRow.Cells(5).Value
                End If
            Catch ex As Exception
                Label23.Text = "..."
                cbxTipoIdentificacion.Text = ""
                txtCiRuc.Clear()
                txtClienteComercial.Clear()
                txtCliente.Clear()
            End Try
        End Sub

        Private Sub LlenarSupervisores()
            Try
                Dim pars As DataTable = _objPer.BuscarPersonal(_tipoCon)
                cbxSupervisor.DataSource = pars
                cbxSupervisor.DisplayMember = "DATOS"
                cbxSupervisor.ValueMember = "ID"
                cbxSupervisor.DropDownWidth = cbxSupervisor.DropDownWidth + 50
                cbxSupervisor.SelectedValue = 468
            Catch ex As Exception
                cbxSupervisor.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarProvincia()
            Try
                Dim provs = _objProvincias.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cbmProvincia.DataSource = provs
                cbmProvincia.DisplayMember = "NOMBRE_PROVINCIAS"
                cbmProvincia.ValueMember = "ID_PROVINCIAS"
                cbmProvincia.DropDownWidth = cbmProvincia.DropDownWidth + 50
                cbmProvincia.SelectedIndex = 0
            Catch ex As Exception
                cbmProvincia.DataSource = Nothing
            End Try
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
            ConectarReporte()
        End Sub

        Private Sub TextBox7_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyUp
            CargarSitiosClienteGeneral(txtFiltro.Text.Trim, 0)
            txtFiltro.Focus()
        End Sub

        Private Sub ExportarDatosExcel(ByVal listViewExp As ListView, ByVal titulo As String)
            Try

                If listViewExp.Columns.Count = 0 Then
                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                'Dim app As Excel._Application = New Excel.Application()
                'Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
                'Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

                'worksheet.Name = "SITIOS TRABAJO"

                Dim ic = "Z"

                'worksheet.Range("A1:" & ic & listViewExp.Items.Count + listViewExp.Items.Count + 25).Font.Size = 10

                'worksheet.Range("A1:" & ic & "1").Merge()
                'worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
                'worksheet.Range("A1:" & ic & "1").Font.Bold = True
                'worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                'worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                'worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                'worksheet.Range("A1:" & ic & "1").Font.Size = 12
                ''Copete  
                'worksheet.Range("A2:" & ic & "2").Merge()
                'worksheet.Range("A2:" & ic & "2").Value = titulo
                'worksheet.Range("A2:" & ic & "2").Font.Size = 12
                ''Fecha  
                'worksheet.Range("A3:" & ic & "3").Merge()
                'worksheet.Range("A3:" & ic & "3").Value = "Fecha de Impresión: " + Date.Now
                'worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Dim head = 4

                'For i = 1 To listViewExp.Columns.Count
                '    worksheet.Cells(1 + head, i) = listViewExp.Columns(i - 1).Text
                '    worksheet.Cells(1 + head, i).Font.Bold = True
                '    worksheet.Cells(1 + head, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                '    worksheet.Cells(1 + head, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                '    worksheet.Cells(1 + head, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                '    worksheet.Cells(1 + head, i).Font.Color = Color.White
                'Next

                'Dim dataGridViewExpRowCount = 0
                'For Each row As ListViewItem In listViewExp.Items
                '    For j = 0 To listViewExp.Columns.Count - 1
                '        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1) = row.SubItems(j).Text

                '        ' definir bordes
                '        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                '        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                '        If dataGridViewExpRowCount = listViewExp.Items.Count - 1 Then
                '            worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                '        End If
                '    Next
                '    dataGridViewExpRowCount += 1
                'Next

                'worksheet.Range("A1:" & ic & listViewExp.Items.Count + listViewExp.Items.Count + 25).Columns.AutoFit()

                'app.DisplayAlerts = False
                'app.Visible = True
                'app.DisplayAlerts = True

                Dim fec As DateTime = DateTime.Now
                Dim sfd As New SaveFileDialog With {
                .Filter = "Excel Files(.xlsx)|*.xlsx",
                .Title = "EXPORTAR A EXCEL",
                .FileName = "SITIOS_TRABAJO_" & fec.ToString("yyyyMMdd_HHmm") & ".xlsx"
                    }

                If sfd.ShowDialog() <> DialogResult.OK Then Return

                Dim wb As New XLWorkbook()
                Dim ws As IXLWorksheet = wb.Worksheets.Add("SITIOS TRABAJO")

                ' Rango de ajuste
                'Dim ic As String = ValidationForms.NumToCharExcel(listViewExp.Columns.Count - 1)
                Dim totalFilas As Integer = listViewExp.Items.Count + 25

                ' Formato general
                ws.Range("A1:" & ic & totalFilas).Style.Font.SetFontSize(10)

                ' Encabezado con nombre de la empresa
                ws.Range("A1:" & ic & "1").Merge().Value = ValidationForms.NombreCompany(_tipoCon).ToString()
                ws.Range("A1:" & ic & "1").Style.Font.SetBold().Font.SetFontSize(12).Font.SetFontColor(XLColor.White)
                ws.Range("A1:" & ic & "1").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                ws.Range("A1:" & ic & "1").Style.Fill.SetBackgroundColor(XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon)))

                ' Título del reporte
                ws.Range("A2:" & ic & "2").Merge().Value = titulo
                ws.Range("A2:" & ic & "2").Style.Font.SetFontSize(12)

                ' Fecha de impresión
                ws.Range("A3:" & ic & "3").Merge().Value = "Fecha de Impresión: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                ws.Range("A3:" & ic & "3").Style.Font.SetFontSize(12)

                ' Encabezados de columnas
                Dim filaActual As Integer = 4
                Dim colIndex As Integer = 1
                For Each col As ColumnHeader In listViewExp.Columns
                    Dim headerCell As IXLCell = ws.Cell(filaActual + 1, colIndex)
                    headerCell.Value = col.Text
                    headerCell.Style.Font.SetBold()
                    headerCell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    headerCell.Style.Fill.SetBackgroundColor(XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon)))
                    headerCell.Style.Font.SetFontColor(XLColor.White)
                    headerCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                    colIndex += 1
                Next

                ' Datos de las filas
                Dim dataGridViewExpRowCount As Integer = 0

                For Each row As ListViewItem In listViewExp.Items

                    For j = 0 To listViewExp.Columns.Count - 1
                        Dim dataCell As IXLCell = ws.Cell(dataGridViewExpRowCount + 2 + filaActual, j + 1)
                        dataCell.Value = row.SubItems(j).Text
                        dataCell.Style.Border.LeftBorder = XLBorderStyleValues.Thin
                        dataCell.Style.Border.RightBorder = XLBorderStyleValues.Thin

                        If dataGridViewExpRowCount = listViewExp.Items.Count - 1 Then
                            dataCell.Style.Border.BottomBorder = XLBorderStyleValues.Thin
                        End If
                    Next

                    dataGridViewExpRowCount += 1
                Next

                ' Ajustar automáticamente las columnas
                ws.Columns().AdjustToContents()

                ' Guardar el archivo
                wb.SaveAs(sfd.FileName)

                KryptonMessageBox.Show("Datos exportados correctamente!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Catch ex As Exception

                KryptonMessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR!: " & vbNewLine & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargarSitios.Click
            txtFiltro.Clear()
            CargarSitiosClienteGeneral("", 0)
        End Sub

        Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
            If _botonSeleccionadoSitio <> 0 Or ListView1.Items.Count = 0 Or ListView1.SelectedItems.Count = 0 Then Return

            Label28.Text = ListView1.SelectedItems(0).SubItems(0).Text
            Label12.Text = ListView1.SelectedItems(0).SubItems(0).Text

            txtNombreSitio.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtNombreSitio2.Text = ListView1.SelectedItems(0).SubItems(1).Text

            txtRiver.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtRiver2.Text = ListView1.SelectedItems(0).SubItems(2).Text

            cbmProvincia.SelectedValue = ListView1.SelectedItems(0).SubItems(3).Text
            cbmProvincia2.Text = cbmProvincia.Text & " / " & cbmCanton.Text & " / " & cbmParroquia.Text

            cbmCanton.SelectedValue = ListView1.SelectedItems(0).SubItems(5).Text

            cbmParroquia.SelectedValue = ListView1.SelectedItems(0).SubItems(7).Text

            txtDireccion.Text = ListView1.SelectedItems(0).SubItems(9).Text
            txtDireccion2.Text = ListView1.SelectedItems(0).SubItems(9).Text

            txtReferencia.Text = ListView1.SelectedItems(0).SubItems(10).Text
            txtReferencia2.Text = ListView1.SelectedItems(0).SubItems(10).Text

            cbxSupervisor.SelectedValue = ListView1.SelectedItems(0).SubItems(12).Text

            Label23.Text = ListView1.SelectedItems(0).SubItems(15).Text

            cbxTipoIdentificacion.Text = ListView1.SelectedItems(0).SubItems(16).Text
            txtCiRuc.Text = ListView1.SelectedItems(0).SubItems(17).Text
            txtCliente.Text = ListView1.SelectedItems(0).SubItems(18).Text
            txtClienteComercial.Text = ListView1.SelectedItems(0).SubItems(19).Text

            txtLatitud.Text = ListView1.SelectedItems(0).SubItems(20).Text
            txtLatitud2.Text = ListView1.SelectedItems(0).SubItems(20).Text

            txtLongitud.Text = ListView1.SelectedItems(0).SubItems(21).Text
            txtLongitud2.Text = ListView1.SelectedItems(0).SubItems(21).Text

            cbmGrupo.SelectedValue = ListView1.SelectedItems(0).SubItems(22).Text
            cbmGrupo2.Text = ListView1.SelectedItems(0).SubItems(22).Text

            cbxHorasPuesto.SelectedValue = If(ListView1.SelectedItems(0).SubItems(24).Text.Trim().Equals("0"), 8, ListView1.SelectedItems(0).SubItems(24).Text)

            txtHorasNormal.Text = ListView1.SelectedItems(0).SubItems(25).Text
            txtHoras50.Text = ListView1.SelectedItems(0).SubItems(26).Text
            txtHoras100.Text = ListView1.SelectedItems(0).SubItems(27).Text
            txtHorasFeria.Text = ListView1.SelectedItems(0).SubItems(28).Text
            txtHorasNoct.Text = ListView1.SelectedItems(0).SubItems(29).Text
            txtAdicional.Text = ListView1.SelectedItems(0).SubItems(30).Text
            chkExtra.Checked = CInt(ListView1.SelectedItems(0).SubItems(31).Text) = 1

            btnCargarSitios.Enabled = True ' cargar
            btnNuevoSitio.Enabled = True ' nuevo
            btnGuardarSitio.Enabled = False ' guardar

            btnActualizarSitio.Enabled = ListView1.SelectedItems.Count > 0 ' catualizar
            btnAnularSitio.Enabled = ListView1.SelectedItems.Count > 0 ' anular
            btnCancelarSitio.Enabled = False ' cancelar
            btnExportarSitio.Enabled = ListView1.Items.Count > 0 ' exportar

            CargarArmasSitio(Label28.Text)

            ToolStripMenuItem1.PerformClick()
        End Sub

        Private Sub CargarArmasSitio(ByVal idSitio As Integer)
            Dim fechaDesde = DateTimePicker7.Value.Year.ToString & "-" & DateTimePicker7.Value.Month.ToString & "-" & DateTimePicker7.Value.Day.ToString & " 00:00:00"
            Dim fechaHasta = DateTimePicker6.Value.Year.ToString & "-" & DateTimePicker6.Value.Month.ToString & "-" & DateTimePicker6.Value.Day.ToString & " 23:59:59"

            Try
                'dgvCategoriaItem.DataSource = _objetoSitio.SeleccionarArmasByIdSitio(_tipoCon, idSitio, String.Empty, fechaDesde, fechaHasta)
                'dgvCategoriaItem.DataSource = _objetoSitio.SeleccionarArmasByIdSitio(_tipoCon, idSitio, fechaDesde, fechaHasta)
                dgvCategoriaItem.DataSource = _objetoSitio.SeleccionarArmasByIdSitio(_tipoCon, idSitio, String.Empty)
                dgvCategoriaItem.AutoResizeColumns()
                dgvCategoriaItem.AutoResizeRows()
                dgvCategoriaItem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells



                dgvCategoriaItem.Columns(0).HeaderText = "ID"
                dgvCategoriaItem.Columns(0).Width = 50
                dgvCategoriaItem.Columns(1).HeaderText = "FECHA"
                dgvCategoriaItem.Columns(1).Width = 90
                dgvCategoriaItem.Columns(1).DefaultCellStyle.Format = "d"
                dgvCategoriaItem.Columns(2).HeaderText = "TIPO"
                dgvCategoriaItem.Columns(2).Width = 40
                dgvCategoriaItem.Columns(3).HeaderText = "DESCRIPCIÓN"
                dgvCategoriaItem.Columns(3).Width = 250
                dgvCategoriaItem.Columns(4).HeaderText = "SERIE"
                dgvCategoriaItem.Columns(4).Width = 100
                dgvCategoriaItem.Columns(5).HeaderText = "MOTIVO"
                dgvCategoriaItem.Columns(5).Width = 400






                'dgvCategoriaItem.Columns(0).HeaderText = "ID COMPROBANTE"
                'dgvCategoriaItem.Columns(0).Width = 50
                'dgvCategoriaItem.Columns(1).HeaderText = "FECHA"
                'dgvCategoriaItem.Columns(1).Width = 90
                'dgvCategoriaItem.Columns(1).DefaultCellStyle.Format = "d"
                'dgvCategoriaItem.Columns(2).HeaderText = "CANTIDAD"
                'dgvCategoriaItem.Columns(2).Width = 50
                'dgvCategoriaItem.Columns(3).HeaderText = "TIPO"
                'dgvCategoriaItem.Columns(3).Width = 40
                'dgvCategoriaItem.Columns(4).HeaderText = "DESCRIPCIÓN"
                'dgvCategoriaItem.Columns(4).Width = 250
                'dgvCategoriaItem.Columns(5).HeaderText = "ID KARDEX"
                'dgvCategoriaItem.Columns(5).Width = 50
                'dgvCategoriaItem.Columns(6).HeaderText = "SERIE"
                'dgvCategoriaItem.Columns(6).Width = 100
                'dgvCategoriaItem.Columns(7).HeaderText = "RAZON"
                'dgvCategoriaItem.Columns(7).Width = 400
            Catch
                dgvCategoriaItem.DataSource = Nothing
            End Try
        End Sub

        Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarSitio.Click
            ExportarDatosExcel(ListView1, "SITIOS DE TRABAJO (SITIOS)")
        End Sub

        Private Sub FormSitiosTrabajo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            MenuStrip2.ForeColor = Color.White
            'MenuStrip2.BackColor = ValidationForms.GetColorSistema(_tipoCon)
            MenuStrip1.ForeColor = Color.White
            'MenuStrip1.BackColor = ValidationForms.GetColorSistema(_tipoCon)



            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCategoriaItem.Font = New Font("Roboto", 8, FontStyle.Regular)
            Dim horas = New DataTable()
            horas.Columns.Add("ID")
            horas.Columns.Add("HORA")
            horas.Rows.Add(New String() {8, "8 - HORAS"})
            horas.Rows.Add(New String() {12, "12 - HORAS"})
            horas.Rows.Add(New String() {24, "24 - HORAS"})
            cbxHorasPuesto.DataSource = horas
            cbxHorasPuesto.DisplayMember = "HORA"
            cbxHorasPuesto.ValueMember = "ID"

            LlenarComboGrupos()
            cbxFiltro.SelectedIndex = 0
            _sqlCommands = New List(Of SqlCommand)
        End Sub

        Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If Label12.Text = "..." Then Return
            If ListView1.Items.Count = 0 Then Return

            Dim fechaDesde = DateTimePicker7.Value.Day.ToString & "-" & DateTimePicker7.Value.Month.ToString & "-" & DateTimePicker7.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = DateTimePicker6.Value.Day.ToString & "-" & DateTimePicker6.Value.Month.ToString & "-" & DateTimePicker6.Value.Year.ToString & " 23:59:59"

            Dim grupos = _objetoSitio.SeleccionarRegistroGrupoAsistenciaDetallesByPuestoDias(_tipoCon, CInt(Label12.Text), fechaDesde, fechaHasta)
            Dim datos = _objetoSitio.SeleccionarRegistroDetalleAsistenciaDetallesByPuestoDias(_tipoCon, CInt(Label12.Text), fechaDesde, fechaHasta)

            ListView3.Items.Clear()
            ListView3.Groups.Clear()

            ' grupos
            For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(1).ToString.Trim)
                ListView3.Groups.Add(group)
            Next

            ' detalles
            For Each row As DataRow In datos.Rows
                Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(0).ToString.Trim, ListView3))
                lst.UseItemStyleForSubItems = False

                For i = 1 To datos.Columns.Count - 1
                    If i = 1 Then
                        lst.SubItems.Add(row.Item(i).ToString.Split(" ")(0).Trim)
                    Else
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    End If
                Next

                If row.Item(5).ToString.Equals("ASISTENCIA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 34, 139, 34)
                If row.Item(5).ToString.Equals("LIBRE") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 135, 206, 250)
                If row.Item(5).ToString.Equals("INASISTENCIA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 240, 128, 128)
                If row.Item(5).ToString.Equals("DOBLADA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 240, 128, 128)
                If row.Item(5).ToString.Equals("VACACIONES") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 135, 206, 235)
                If row.Item(5).ToString.Equals("PERMISO MÉDICO") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 255, 218, 155)
                If row.Item(5).ToString.Equals("CALAMIDAD DOMÉSTICA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 255, 218, 155)
                lst.SubItems(5).ForeColor = Color.White

                ListView3.Items.Add(lst)
            Next

            CargarArmasSitio(Label12.Text)

        End Sub

        Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbxFiltro.SelectedIndexChanged
            CargarSitiosClienteGeneral(txtFiltro.Text.Trim, 0)
        End Sub

        Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtHorasNoct.KeyPress, txtAdicional.KeyPress, txtHoras100.KeyPress, txtHorasFeria.KeyPress, txtHoras50.KeyPress, txtHorasNormal.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
        End Sub

        Private Sub cbmGrupo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbmGrupo.KeyPress
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End Sub

        Private Sub ToolStripMenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
            ExportarDatosExcel(ListView3, "REPORTE DE PUESTO")
        End Sub

        Private Sub cbxHorasPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxHorasPuesto.SelectedIndexChanged

        End Sub

        Private Sub btnSitios_Click(sender As Object, e As EventArgs) Handles btnSitios.Click
            Dim frm As New FormGrupo
            frm.Usuario = UserName
            frm.ShowDialog()

        End Sub
    End Class
End Namespace