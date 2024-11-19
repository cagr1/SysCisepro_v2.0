Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.INVENTARIOS.KARDEX
Imports ClassLibraryCisepro.INVENTARIOS.PARAMETROS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports Microsoft.Office.Interop
Imports Krypton.Toolkit

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormProductosBodega
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
        Dim _sqlCommands As List(Of SqlCommand)

        ReadOnly _objMarcas As New ClassMarca
        ReadOnly _objModelos As New ClassModelo
        ReadOnly _objMaterial As New ClassMaterial
        ReadOnly _objColor As New ClassColor
        ReadOnly _objUnidad As New ClassUnidadMedida
        ReadOnly _objCategoria As New ClassCategoriaItem
        ReadOnly _objGrupo As New ClassGrupoItem
        ReadOnly _objSubGrupo As New ClassSubGrupoItem
        ReadOnly _objSecuencial As New ClassSecuencialItem
        ReadOnly _objSerie As New ClassGenerarSerie
        ReadOnly _crItems As New crItemsBodega
        ReadOnly _objKardex As New ClassKardex
        ReadOnly _objDetalleKardex As New ClassDetalleKardex
        ReadOnly _validacionesDecimales As New ClassDecimal

        Dim _saveOupdate As Integer
        Public UserName As String

        Private Sub FormProductosBodega_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dgvSecuencial.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)

            CargarMarcas()
            CargarModelos()
            CargarMaterial()
            CargarColor()
            CargarUnidad()
            CargarCategorías()
            TextBox1.Focus()
        End Sub

        Private Sub CargarMarcas()
            Try
                cbmMarca.DataSource = _objMarcas.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarca.DisplayMember = "MARCA"
                cbmMarca.ValueMember = "ID"
                cbmMarca.DropDownWidth = 400
            Catch
                cbmMarca.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarModelos()
            Try
                cbmModelo.DataSource = _objModelos.SeleccionarTodosLosRegistrosModelo(_tipoCon)
                cbmModelo.DisplayMember = "MODELO"
                cbmModelo.ValueMember = "ID"
                cbmModelo.DropDownWidth = 400
            Catch
                cbmModelo.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarMaterial()
            Try
                cbmMaterial.DataSource = _objMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterial.DisplayMember = "MATERIAL"
                cbmMaterial.ValueMember = "ID"
                cbmMaterial.DropDownWidth = 400
            Catch ex As Exception
                cbmMaterial.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarColor()
            Try
                cbmColor.DataSource = _objColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColor.DisplayMember = "COLOR"
                cbmColor.ValueMember = "ID"
            Catch
                cbmColor.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarUnidad()
            Try
                cbmUnidadDeMedida.DataSource = _objUnidad.SeleccionarRegistrosUnidadMedida(_tipoCon)
                cbmUnidadDeMedida.DisplayMember = "UNIDAD MEDIDA"
                cbmUnidadDeMedida.ValueMember = "ID"
            Catch
                cbmUnidadDeMedida.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarCategorías()
            Try
                cbmCategoría.DataSource = _objCategoria.SeleccionarCategoriasItemsActivas(_tipoCon)
                cbmCategoría.DisplayMember = "NOMBRE CATEGORÍA"
                cbmCategoría.ValueMember = "CÓDIGO"

                Try
                    cbmCategoria2.DataSource = _objCategoria.SeleccionarCategoriasItemsActivasTodas(_tipoCon)
                    cbmCategoria2.DisplayMember = "NOMBRE"
                    cbmCategoria2.ValueMember = "ID"

                    cbmCategoria2.SelectedIndex = 0
                Catch
                    cbmCategoria2.DataSource = Nothing
                End Try
            Catch
                cbmCategoría.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmCategoría_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCategoría.SelectedValueChanged
            If cbmCategoría.SelectedValue Is Nothing Or TypeOf cbmCategoría.SelectedValue Is DataRowView Then Return
            CargarGrupos(cbmCategoría.SelectedValue)
        End Sub

        Private Sub CargarGrupos2(ByVal idCategorías As Int64)
            Try
                cbmGrupo2.DataSource = _objGrupo.BuscarGrupoItemXIdCategoriaItemTodas(_tipoCon, idCategorías)
                cbmGrupo2.DisplayMember = "NOMBRE"
                cbmGrupo2.ValueMember = "ID"
                cbmGrupo2.SelectedIndex = 0
            Catch
                cbmGrupo2.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarGrupos(ByVal idCategorías As Int64)
            Try
                cbmGrupo.DataSource = _objGrupo.BuscarGrupoItemXIdCategoriaItem(_tipoCon, idCategorías)
                cbmGrupo.DisplayMember = "NOMBRE_GRUPO_ITEM"
                cbmGrupo.ValueMember = "ID_GRUPO_ITEM"
            Catch
                cbmGrupo.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmGrupo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmGrupo.SelectedValueChanged
            If cbmGrupo.SelectedValue Is Nothing Or TypeOf cbmGrupo.SelectedValue Is DataRowView Then Return
            CargarSubGrupos(cbmGrupo.SelectedValue)
        End Sub

        Private Sub CargarSubGrupos2(ByVal idGrupos As Int64)
            Try
                cbmSubGrupo2.DataSource = _objSubGrupo.BuscarSubGrupoItemXIdGrupoItemTodas(_tipoCon, idGrupos)
                cbmSubGrupo2.DisplayMember = "NOMBRE"
                cbmSubGrupo2.ValueMember = "ID"
                cbmSubGrupo2.SelectedIndex = 0
            Catch
                cbmSubGrupo2.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarSubGrupos(ByVal idGrupos As Int64)
            Try
                cbmSubGrupo.DataSource = _objSubGrupo.BuscarSubGrupoItemXIdGrupoItem(_tipoCon, idGrupos)
                cbmSubGrupo.DisplayMember = "NOMBRE_SUB_GRUPO_ITEM"
                cbmSubGrupo.ValueMember = "ID_SUB_GRUPO_ITEM"
            Catch
                cbmSubGrupo.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmSubGrupo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmSubGrupo.SelectedValueChanged
            If cbmSubGrupo.SelectedValue Is Nothing Or TypeOf cbmSubGrupo.SelectedValue Is DataRowView Then Return
            Try
                txtCódigo.Text = _objSubGrupo.BuscarCodigoSubGrupoItemXidSubGrupoItem(_tipoCon, cbmSubGrupo.SelectedValue) & "." & _objSerie.SerieDeDos(_objSecuencial.ContarMayorIdSubGrupoxIdSubGrupoItem(_tipoCon, cbmSubGrupo.SelectedValue) + 1)
            Catch
                txtCódigo.Text = "0.0.0.0"
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            TextBox1.Clear()
            CargarSecuencial()
        End Sub

        Private Sub CargarSecuencial()
            Try
                dgvSecuencial.DataSource = _objSecuencial.SeleccionarSecuencialItemsActivas(_tipoCon, cbmCategoria2.SelectedValue, cbmGrupo2.SelectedValue, cbmSubGrupo2.SelectedValue, TextBox1.Text.Trim())

                dgvSecuencial.Columns(0).Width = 40
                dgvSecuencial.Columns(1).Width = 60
                dgvSecuencial.Columns(2).Width = 200
                dgvSecuencial.Columns(3).Width = 300
                dgvSecuencial.Columns(4).Width = 80
                dgvSecuencial.Columns(5).Width = 60
                dgvSecuencial.Columns(6).Width = 60
                dgvSecuencial.Columns(7).Width = 60

                dgvSecuencial.Columns(8).Visible = False

                dgvSecuencial.Columns(9).Width = 90
                dgvSecuencial.Columns(10).Width = 90
                dgvSecuencial.Columns(11).Width = 90
                dgvSecuencial.Columns(12).Width = 90

                dgvSecuencial.Columns(13).Width = 50

                dgvSecuencial.Columns(14).Visible = False
                dgvSecuencial.Columns(15).Visible = False
                dgvSecuencial.Columns(16).Visible = False
                dgvSecuencial.Columns(17).Visible = False
                dgvSecuencial.Columns(18).Visible = False
                dgvSecuencial.Columns(19).Visible = False
                dgvSecuencial.Columns(20).Visible = False

                dgvSecuencial.AutoResizeRows()
            Catch
                dgvSecuencial.DataSource = Nothing
            End Try
        End Sub

        Private Sub dgvSecuencial_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvSecuencial.SelectionChanged
            If _saveOupdate <> 0 Then Return
            If dgvSecuencial.RowCount = 0 Or dgvSecuencial.CurrentRow Is Nothing Then Return
            Try
                Dim item As DataTable = _objSecuencial.BuscarSecuencialItemXIdSecuencialItem(_tipoCon, dgvSecuencial.CurrentRow.Cells(0).Value)
                If item Is Nothing Then Return
                If item.Rows.Count = 0 Then Return

                txtCódigo.Text = dgvSecuencial.CurrentRow.Cells(1).Value
                cbmMarca.SelectedValue = item.Rows(0).Item(4)
                cbmModelo.SelectedValue = item.Rows(0).Item(5)
                cbmMaterial.SelectedValue = item.Rows(0).Item(6)
                cbmColor.SelectedValue = item.Rows(0).Item(7)

                cbmUnidadDeMedida.SelectedValue = item.Rows(0).Item(8)
                cbmCategoría.SelectedValue = item.Rows(0).Item(18)
                cbmGrupo.SelectedValue = item.Rows(0).Item(17)
                cbmSubGrupo.SelectedValue = item.Rows(0).Item(12)

                lblIdSecuencial.Text = item.Rows(0).Item(0)
                txtSecuencial.Text = item.Rows(0).Item(2)
                txtDescripción.Text = item.Rows(0).Item(9)
                txtDescripción.BackColor = Color.White

                txtCosto.Text = item.Rows(0).Item(13)
                txtPvp.Text = item.Rows(0).Item(19)
                txtSerie.Text = item.Rows(0).Item(15) & ""
                chbxDescuento.Checked = If(IsDBNull(item.Rows(0).Item(16)), False, Convert.ToBoolean(item.Rows(0).Item(16)))

                tsmModificar.Enabled = dgvSecuencial.RowCount > 0 And Not dgvSecuencial.CurrentRow Is Nothing
                tsmAjustar.Enabled = dgvSecuencial.RowCount > 0 And Not dgvSecuencial.CurrentRow Is Nothing
            Catch ex As Exception
                txtDescripción.Text = "Error al cargar item"
                txtDescripción.BackColor = Color.Salmon
                'show the error message
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                KryptonMessageBox.Show(ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

            End Try
        End Sub

        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmNuevo.Click
            LimpiarParametrosSecuencial()

            CargarMarcas()
            CargarModelos()
            CargarMaterial()
            CargarColor()
            CargarUnidad()
            CargarCategorías()

            HabilitarParametrosSecuencial(True)

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmModificar.Enabled = False
            tsmCancelar.Enabled = True
            tsmAjustar.Enabled = False

            _saveOupdate = 1
        End Sub

        Private Sub LimpiarParametrosSecuencial()
            txtCódigo.Clear()
            txtSecuencial.Clear()
            txtDescripción.Clear()
            txtCosto.Clear()
        End Sub

        Private Sub HabilitarParametrosSecuencial(ByVal cbmMarcaI As Boolean)
            cbmMarca.Enabled = cbmMarcaI
            cbmModelo.Enabled = cbmMarcaI
            cbmMaterial.Enabled = cbmMarcaI
            cbmColor.Enabled = cbmMarcaI
            cbmUnidadDeMedida.Enabled = cbmMarcaI
            cbmCategoría.Enabled = cbmMarcaI
            cbmGrupo.Enabled = cbmMarcaI
            cbmSubGrupo.Enabled = cbmMarcaI

            txtSecuencial.Enabled = cbmMarcaI
            txtDescripción.Enabled = cbmMarcaI
            txtCosto.Enabled = cbmMarcaI
            txtPvp.Enabled = cbmMarcaI
            txtSerie.Enabled = cbmMarcaI
            chbxDescuento.Enabled = cbmMarcaI

            lblCrearMarca.Enabled = cbmMarcaI
            lblCrearModelo.Enabled = cbmMarcaI
            lblCrearMaterial.Enabled = cbmMarcaI
            lblCrearColor.Enabled = cbmMarcaI

            lblCrearUnidadMedida.Enabled = cbmMarcaI
            lblCrearCategoria.Enabled = cbmMarcaI
            lblCrearGrupo.Enabled = cbmMarcaI
            lblCrearSubGrupo.Enabled = cbmMarcaI
        End Sub

        Private Sub tsmModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmModificar.Click
            txtCosto.Enabled = True
            txtPvp.Enabled = True
            chbxDescuento.Enabled = True

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmModificar.Enabled = False
            tsmCancelar.Enabled = True
            tsmAjustar.Enabled = False

            _saveOupdate = 2
        End Sub

        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmCancelar.Click
            LimpiarParametrosSecuencial()
            HabilitarParametrosSecuencial(False)

            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            tsmModificar.Enabled = dgvSecuencial.RowCount > 0 And Not dgvSecuencial.CurrentRow Is Nothing
            tsmCancelar.Enabled = False
            tsmAjustar.Enabled = dgvSecuencial.RowCount > 0 And Not dgvSecuencial.CurrentRow Is Nothing
            _saveOupdate = 0
        End Sub

        Private Sub ToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            ConectarReporte()
            tcProducto.SelectedIndex = 1
        End Sub

        Private Sub ConectarReporte()
            Try
                _crItems.SetDataSource(CType(dgvSecuencial.DataSource, DataTable))
                _crItems.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvInventarios.ReportSource = _crItems
                crvInventarios.Zoom(75)
                crvInventarios.Refresh()
            Catch
                crvInventarios.ReportSource = Nothing
            End Try
        End Sub

        Private Sub lblCrearMarca_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearMarca.Click
            Dim respuesta = InputBox("INGRESE EL NOMBRE DE LA MARCA", "REGISTRO DE NUEVA MARCA", "INGRESE EL NOMBRE")
            If respuesta.Trim().Length = 0 Then Return
            'If MessageBox.Show("Esta seguro que desea guardar LA MARCA '" & respuesta & "'?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            If KryptonMessageBox.Show("Esta seguro que desea guardar LA MARCA '" & respuesta & "'?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            Dim r = _objMarcas.BuscarMarcaRepetida(_tipoCon, respuesta)
            If r Then
                'MsgBox("Marca ya está registrada!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Marca ya está registrada!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            With _objMarcas
                .IdMarca = .BuscarMayorIdMarca(_tipoCon) + 1
                .DetalleMarca = respuesta.ToUpper
                .EstadoMarca = 1
                .NuevaMarca(_tipoCon)
            End With

            CargarMarcas()
            cbmMarca.SelectedValue = _objMarcas.IdMarca
        End Sub

        Private Sub lblCrearModelo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearModelo.Click
            Dim respuesta = InputBox("INGRESE EL NOMBRE DEL MODELO", "REGISTRO DE NUEVO MODELO", "INGRESE EL NOMBRE")
            If respuesta.Trim().Length = 0 Then Return
            If MessageBox.Show("Esta seguro que desea guardar EL MODELO '" & respuesta & "'?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            Dim r = _objModelos.BuscarModeloRepetida(_tipoCon, respuesta)
            If r Then
                'MsgBox("Modelo ya está registrado!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Modelo ya está registrado!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            With _objModelos
                .Id = .BuscarMayorIdModelo(_tipoCon) + 1
                .Detalle = respuesta.ToUpper
                .EstadoMaterial = 1
                .NuevaModelo(_tipoCon)
            End With
            CargarModelos()
            cbmModelo.SelectedValue = _objModelos.Id
        End Sub

        Private Sub lblCrearMaterial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearMaterial.Click
            Dim respuesta = InputBox("INGRESE EL NOMBRE DEL MATERIAL", "REGISTRO DE NUEVO MATERIAL", "INGRESE EL NOMBRE")
            If respuesta.Trim().Length = 0 Then Return
            If MessageBox.Show("Esta seguro que desea guardar EL MATERIAL '" & respuesta & "'?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            Dim r = _objMaterial.BuscarMaterialRepetida(_tipoCon, respuesta)
            If r Then
                'MsgBox("Material ya está registrado!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Material ya está registrado!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            With _objMaterial
                .IdMaterial = .BuscarMayorIdMaterial(_tipoCon) + 1
                .DetalleMaterial = respuesta.ToUpper
                .EstadoMaterial = 1
                .NuevaMaterial(_tipoCon)
            End With
            CargarMaterial()
            cbmMaterial.SelectedValue = _objMaterial.IdMaterial
        End Sub

        Private Sub lblCrearColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearColor.Click
            Dim respuesta = InputBox("INGRESE EL NOMBRE DEL COLOR", "REGISTRO DE NUEVO COLOR", "INGRESE EL NOMBRE")
            If respuesta.Trim().Length = 0 Then Return
            If MessageBox.Show("Esta seguro que desea guardar EL COLOR '" & respuesta & "'?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            Dim r = _objColor.BuscarColorRepetida(_tipoCon, respuesta)
            If r Then
                'MsgBox("Color ya está registrado!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Color ya está registrado!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            With _objColor

                .Id = .BuscarMayorIdColor(_tipoCon) + 1
                .Detalle = respuesta.ToUpper
                .Estado = 1
                .NuevaColor(_tipoCon)
            End With
            CargarColor()
            cbmColor.SelectedValue = _objColor.Id
        End Sub

        Private Sub lblCrearUnidadMedida_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearUnidadMedida.Click
            Dim respuesta = InputBox("INGRESE EL NOMBRE DE LA UNIDAD DE MEDIDA", "REGISTRO DE NUEVA UNIDAD DE MEDIDA", "INGRESE EL NOMBRE")
            If respuesta.Trim().Length = 0 Then Return

            Dim respuesta2 = InputBox("INGRESE ABREVIATURA DE LA UNIDAD DE MEDIDA", "REGISTRO DE NUEVA UNIDAD DE MEDIDA", "INGRESE EL NOMBRE")
            If respuesta2.Trim().Length = 0 Then Return

            If MessageBox.Show("Esta seguro que desea guardar LA UNIDAD DE MEDIDA '" & respuesta & " / " & respuesta2 & "'?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            Dim r = _objUnidad.BuscarUnidadMedidaRepetida(_tipoCon, respuesta)
            If r Then
                'MsgBox("Unidad de medida ya está registrado!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Unidad de medida ya está registrado!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            With _objUnidad
                .IdUnidadMedida = .BuscarMayorIdUnidadMedida(_tipoCon) + 1
                .DetalleUnidadMedida = respuesta.ToUpper
                .EstadoUnidadMedida = 1
                .CodigoUnidadMedida = respuesta2.ToUpper
                .NuevoRegistroUnidadMedida(_tipoCon)
            End With
            CargarUnidad()
            cbmUnidadDeMedida.SelectedValue = _objUnidad.IdUnidadMedida
        End Sub

        Private Sub lblCrearCategoria_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearCategoria.Click
            Dim formCrearItems As New FormCrearCategoriasItem
            formCrearItems.TipoCox = TipoCox
            formCrearItems.tcItems.SelectedIndex = 0
            formCrearItems.ShowDialog()
        End Sub
        Private Sub lblCrearGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearGrupo.Click
            Dim formCrearItems As New FormCrearCategoriasItem
            formCrearItems.TipoCox = TipoCox
            formCrearItems.tcItems.SelectedIndex = 1
            formCrearItems.ShowDialog()
        End Sub
        Private Sub lblCrearSubGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCrearSubGrupo.Click
            Dim formCrearItems As New FormCrearCategoriasItem
            formCrearItems.TipoCox = TipoCox
            formCrearItems.tcItems.SelectedIndex = 2
            formCrearItems.ShowDialog()
        End Sub

        Private Function ValidarParametros() As Boolean
            Return cbmMarca.SelectedValue <> Nothing And
               cbmModelo.SelectedValue <> Nothing And
               cbmMaterial.SelectedValue <> Nothing And
               cbmColor.SelectedValue <> Nothing And
               cbmUnidadDeMedida.SelectedValue <> Nothing And
               cbmSubGrupo.SelectedValue <> Nothing And
               txtSecuencial.Text.Trim.Length > 0 And
               txtDescripción.Text.Trim.Length > 0 And
               txtCódigo.Text.Trim.Length > 0 And
               txtCosto.Text.Trim().Length > 0 And
               txtPvp.Text.Trim().Length > 0
        End Function

        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmGuardar.Click
            If Not ValidarParametros() Then
                'MsgBox("NO HA LLENADO LOS PARÁMETROS NECESARIOS", MsgBoxStyle.Exclamation, "Mensaje de información")
                KryptonMessageBox.Show("NO HA LLENADO LOS PARÁMETROS NECESARIOS", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            Dim valor = 0.0
            If Double.TryParse(txtCosto.Text.Trim, valor) Then
                _sqlCommands.Clear()

                If _saveOupdate = 1 Then

                    lblIdSecuencial.Text = _objSecuencial.BuscarMayorIdSecuencialItem(_tipoCon) + 1

                    With _objSecuencial
                        .Id = CInt(lblIdSecuencial.Text)
                        .Codigo = txtCódigo.Text.Trim
                        .Nombre = txtSecuencial.Text.ToUpper.Trim
                        .Fecha = Date.Now
                        .IdMarca = cbmMarca.SelectedValue
                        .IdModelo = cbmModelo.SelectedValue
                        .IdMaterial = cbmMaterial.SelectedValue
                        .IdColor = cbmColor.SelectedValue
                        .IdUnidadMedida = cbmUnidadDeMedida.SelectedValue
                        .Descripcion = txtDescripción.Text.ToUpper.Trim
                        .Serie = txtSerie.Text.ToUpper.Trim
                        .Estado = 1
                        .IdLote = 0
                        .IdSubGrupo = cbmSubGrupo.SelectedValue
                        .Costo = If(txtCosto.Text.Trim.Length = 0, 0, CDec(txtCosto.Text))
                        .Pvp = If(txtPvp.Text.Trim.Length = 0, 0, CDec(txtPvp.Text))
                        .Descuento = If(chbxDescuento.Checked, 1, 0)
                        '.nuevaSecuencialItem()
                    End With
                    _sqlCommands.Add(_objSecuencial.NuevaSecuencialItemCommand())

                    With _objKardex
                        .Id = .BuscarMayorIdKardex(_tipoCon) + 1
                        .IdsecuencialItem = _objSecuencial.Id
                        .Fecha = _objSecuencial.Fecha
                        .Cantidad = 0
                        .Estado = 1


                        '.NuevoRegistroKardex()
                    End With
                    _sqlCommands.Add(_objKardex.NuevoRegistroKardexCommand())

                    With _objDetalleKardex
                        .Id = .BuscarMayorIdDetalleKardex(_tipoCon) + 1
                        .IdActividad = 1
                        .IdConcepto = 8
                        .CantidadIngreso = 0
                        .ValorUnitarioIngreso = 0
                        .ValorTotalIngreso = 0
                        .CantidadEgreso = 0
                        .ValorUnitarioEgreso = 0
                        .ValorTotalEgreso = 0
                        .CantidadSaldo = 0
                        .ValorUnitarioSaldo = 0
                        .ValorTotalSaldo = 0
                        .Fecha = _objSecuencial.Fecha
                        .IdKardex = _objKardex.Id
                        .Estado = 1
                        .NroComprobante = "0000000"
                        '.NuevoRegistroDetalleKardex()
                    End With
                    _sqlCommands.Add(_objDetalleKardex.NuevoRegistroDetalleKardexCommand())

                Else

                    With _objSecuencial
                        .Id = lblIdSecuencial.Text
                        .Costo = If(txtCosto.Text.Trim.Length = 0, 0, CDec(txtCosto.Text))
                        .Pvp = If(txtPvp.Text.Trim.Length = 0, 0, CDec(txtPvp.Text))
                        .Descuento = If(chbxDescuento.Checked, 1, 0)
                    End With
                    _sqlCommands.Add(_objSecuencial.ModificarPreciosCommand())


                    Dim k = _objKardex.BuscarKardexPorIdSecuencialItem(_tipoCon, lblIdSecuencial.Text)

                    If k = 0 Then

                        With _objKardex
                            .Id = .BuscarMayorIdKardex(_tipoCon) + 1
                            .IdsecuencialItem = lblIdSecuencial.Text
                            .Fecha = Date.Now
                            .Cantidad = 0
                            .Estado = 1

                            '.NuevoRegistroKardex()
                        End With
                        _sqlCommands.Add(_objKardex.NuevoRegistroKardexCommand())

                        With _objDetalleKardex
                            .Id = .BuscarMayorIdDetalleKardex(_tipoCon) + 1
                            .IdActividad = 1
                            .IdConcepto = 8
                            .CantidadIngreso = 0
                            .ValorUnitarioIngreso = 0
                            .ValorTotalIngreso = 0
                            .CantidadEgreso = 0
                            .ValorUnitarioEgreso = 0
                            .ValorTotalEgreso = 0
                            .CantidadSaldo = 0
                            .ValorUnitarioSaldo = 0
                            .ValorTotalSaldo = 0
                            .Fecha = Date.Now
                            .IdKardex = _objKardex.Id
                            .Estado = 1
                            .NroComprobante = "0000000"
                            '.NuevoRegistroDetalleKardex()
                        End With
                        _sqlCommands.Add(_objDetalleKardex.NuevoRegistroDetalleKardexCommand())
                    End If

                End If

                Dim nombreU = "Ingreso de Producto Bodega por: " & UserName
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    _saveOupdate = 0
                    'lblModificar.Visible = False
                    tsmNuevo.Enabled = True
                    tsmGuardar.Enabled = False
                    tsmModificar.Enabled = True
                    tsmCancelar.Enabled = False
                    tsmAjustar.Enabled = True
                    HabilitarParametrosSecuencial(False)
                    CargarSecuencial()
                End If

                Dim messageIcon As KryptonMessageBoxIcon
                If res(0) Then
                    messageIcon = KryptonMessageBoxIcon.Information
                Else
                    messageIcon = KryptonMessageBoxIcon.Exclamation
                End If
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)

                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                'MsgBox("DEBE REGISTRAR EL COSTO PARA GUARDAR", MsgBoxStyle.Exclamation, "Mensaje de información")
                KryptonMessageBox.Show("DEBE REGISTRAR EL COSTO PARA GUARDAR", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub txtCosto_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCosto.KeyPress, txtPvp.KeyPress
            Dim txt = CType(sender, TextBox)
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar, txt.Text)
        End Sub

        Private Sub txtCosto_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCosto.KeyUp
            Try
                txtPvp.Text = Math.Round(CDbl(txtCosto.Text) * 1.3, 3)
            Catch
                txtPvp.Text = "0.00"
            End Try
        End Sub

        Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
            If e.KeyValue <> 13 Then Return
            CargarSecuencial()
        End Sub

        Private Sub cbmCategoria2_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCategoria2.SelectedValueChanged
            If cbmCategoria2.SelectedValue Is Nothing Or TypeOf cbmCategoria2.SelectedValue Is DataRowView Then Return
            CargarGrupos2(cbmCategoria2.SelectedValue)
        End Sub

        Private Sub cbmGrupo2_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmGrupo2.SelectedValueChanged
            If cbmGrupo2.SelectedValue Is Nothing Or TypeOf cbmGrupo2.SelectedValue Is DataRowView Then Return
            CargarSubGrupos2(cbmGrupo2.SelectedValue)
        End Sub

        Private Sub btnExportarGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarGrupos.Click
            If dgvSecuencial.RowCount = 0 Then MessageBox.Show("NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "INVENTARIO"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvSecuencial)
                worksheet.Range("A1:" & ic & (dgvSecuencial.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & "INVENTARIO " & cbmCategoría.Text
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "" 'PERÍODO: " & desde.ToLongDateString().ToUpper() & "  AL " & hasta.ToLongDateString().ToUpper()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString().ToUpper() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvSecuencial.Columns.Count - 1
                    If Not dgvSecuencial.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvSecuencial.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvSecuencial.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvSecuencial.Columns.Count - 1

                        If Not dgvSecuencial.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = dgvSecuencial.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvSecuencial.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next


                worksheet.Range("A1:" & ic & (dgvSecuencial.RowCount + 50)).Columns.AutoFit()

                Dim position = CType(worksheet.Cells(2, 7), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.paste(position)

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub tsmAjustar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAjustar.Click
            Try
                Dim c = InputBox("INGRESE LA CANTIDAD EXACTA EN STOCK PARA: " & txtSecuencial.Text.Trim, "INGRESE CANTIDAD", " ")
                If String.IsNullOrEmpty(c) Then Return

                Dim cant = 0
                If (Integer.TryParse(c, cant)) Then

                    _sqlCommands.Clear()
                    Dim ant = CInt(dgvSecuencial.CurrentRow.Cells(7).Value)


                    With _objDetalleKardex
                        .Id = .BuscarMayorIdDetalleKardex(_tipoCon) + 1
                        .IdActividad = 3
                        .IdConcepto = If(cant > ant, 17, 18) ' faltante / sobrante
                        .CantidadIngreso = If(cant > ant, cant - ant, 0)
                        .ValorUnitarioIngreso = 0
                        .ValorTotalIngreso = 0
                        .CantidadEgreso = If(cant > ant, 0, ant - cant)
                        .ValorUnitarioEgreso = 0
                        .ValorTotalEgreso = 0
                        .CantidadSaldo = cant
                        .ValorUnitarioSaldo = 0
                        .ValorTotalSaldo = 0
                        .Fecha = Date.Now
                        .IdKardex = _objKardex.BuscarKardexPorIdSecuencialItem(_tipoCon, lblIdSecuencial.Text)
                        .Estado = 1
                        .NroComprobante = "0000000"
                    End With
                    _sqlCommands.Add(_objDetalleKardex.NuevoRegistroDetalleKardexCommand())


                    With _objKardex
                        .Id = _objDetalleKardex.IdKardex
                        .Cantidad = cant
                    End With
                    _sqlCommands.Add(_objKardex.ModificarCantidadKardexMinCommand())

                    Dim nombreU = "Ajuste de Producto Bodega por: " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then
                        _saveOupdate = 0
                        tsmNuevo.Enabled = True
                        tsmGuardar.Enabled = False
                        tsmModificar.Enabled = True
                        tsmCancelar.Enabled = False
                        tsmAjustar.Enabled = True

                        HabilitarParametrosSecuencial(False)
                        CargarSecuencial()
                    End If

                    Dim messageIcon As KryptonMessageBoxIcon
                    If res(0) Then
                        messageIcon = KryptonMessageBoxIcon.Information
                    Else
                        messageIcon = KryptonMessageBoxIcon.Exclamation
                    End If
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)

                    'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                Else
                    MessageBox.Show("LA CANTIDAD DEBE SER UN VALOR NUMÉRICO!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                'MessageBox.Show("HUBO UN PROBLEMA AL REALIZAR AJUSTE!" & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("HUBO UN PROBLEMA AL REALIZAR AJUSTE!" & vbNewLine & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace