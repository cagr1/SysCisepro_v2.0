Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.COMPROBANTES
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.INVENTARIOS.KARDEX
Imports ClassLibraryCisepro.INVENTARIOS.UNIFORMES
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormEntregaUniformes
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

        ReadOnly _crEntrega As New crEntregaUNIFORMES

        ReadOnly _objControl As New ClassControlUniformes
        ReadOnly _objSecuencialItem As New ClassSecuencialItem
        ReadOnly _objKardex As New ClassKardex
        ReadOnly _objDetalleKardex As New ClassDetalleKardex
        ReadOnly _objPer As New ClassPersonal
        ReadOnly _objEntrega As New ClassEntregaUniformes
        ReadOnly _objDetalle As New ClassDetalleUniforme
        ReadOnly _objFoto As New ClassFoto

        'ReadOnly _objCompEgr As New ClassComprobanteEgresoBodega
        'ReadOnly _objDetCompEgr As New ClassDetalleComprobanteEgreso
        'ReadOnly _objSerie As New ClassGenerarSerie
        ReadOnly _objCli As New ClassClienteGeneral
        ReadOnly _objSitioTrabajo As New ClassSitiosTrabajo
        ReadOnly _objRegistroDescuento As New ClassDescuentosPersonal

        'ReadOnly _objDetalleEgresoPuesto As New ClassDetalleBodegaSitio

        Dim _detalleKardex As New DataTable

        Private Sub AutocompletarArticulo()
            txtArticulo.AutoCompleteCustomSource = _objSecuencialItem.Autocompletar(_tipoCon)
            txtArticulo.AutoCompleteMode = AutoCompleteMode.Suggest
            txtArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub

        Private Sub AutocompletarRecibe()
            txtRecibe.AutoCompleteCustomSource = _objPer.AutocompletarApellidos(_tipoCon, True)
            txtRecibe.AutoCompleteMode = AutoCompleteMode.Suggest
            txtRecibe.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub

        Private Sub AutocompletarClientes()
            txtCliente.AutoCompleteCustomSource = _objCli.Autocompletar(_tipoCon)
            txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest
            txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub
        Private Sub FormEntregaUniformes_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    Label1.ForeColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label10.ForeColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label10.Text = Label10.Text.Replace("CISEPRO", "ASENAVA")
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label25.ForeColor = Color.White
                    Label25.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    lblTotalUniformes.ForeColor = Color.White
                    lblTotalUniformes.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    pbImagen.Image = Nothing
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    Label10.Text = Label10.Text.Replace("CISEPRO", "SEPORTPAC")
                    Label1.ForeColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label10.ForeColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    Label25.ForeColor = Color.White
                    Label25.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    lblTotalUniformes.ForeColor = Color.White
                    lblTotalUniformes.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    pbImagen.Image = My.Resources.SeportPac_wall_min
                Case Else
                    Icon = My.Resources.logo_c
                    Label1.ForeColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label10.ForeColor = My.MySettingsProperty.Settings.ColorCisepro
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    Label25.ForeColor = Color.White
                    Label25.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    lblTotalUniformes.ForeColor = Color.White
                    lblTotalUniformes.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    pbImagen.Image = My.Resources.Cisepro_wall_min
            End Select
            dgvSecuencial.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobantesIngreso.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobate.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
        End Sub
        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmNuevo.Click
            AutocompletarRecibe()
            AutocompletarClientes()
            AutocompletarArticulo()

            HabilitarIngresos(True)

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmCancelar.Enabled = True

            Limpiar()

            txtRecibe.Focus()
        End Sub

        Private Sub HabilitarIngresos(ByVal cmbBodegaV As Boolean)
            txtRecibe.Enabled = cmbBodegaV
            txtObservacion.Enabled = cmbBodegaV
            txtObservacionEntrega.Enabled = cmbBodegaV
            dtpIngreso.Enabled = cmbBodegaV
            dtpRolPago.Enabled = cmbBodegaV
            txtCliente.Enabled = cmbBodegaV
            gbBusquedaArticulo.Enabled = cmbBodegaV
            chkEditar.Enabled = cmbBodegaV
            dtpFechaEmision.Enabled = cmbBodegaV
            btnSerie.Enabled = cmbBodegaV
            pbFoto.Enabled = cmbBodegaV
        End Sub
        Private Sub Limpiar()
            txtCedula.Tag = Nothing
            txtRecibe.Clear()
            txtCedula.Clear()
            txtCliente.Clear()
            dtpIngreso.Value = DateTime.Now
            dtpRolPago.Value = DateTime.Now

            pbFoto.Image = Nothing

            txtObservacionEntrega.Clear()

            txtArticulo.Clear()
            txtCodigoArticulo.Clear()
            cmbObservacionCalidad.SelectedIndex = 0
            nudCantidad.Value = 0
            nudValor.Value = 0
            txtObservacion.Clear()
            lblIdArticulo.Text = 0
            lblIdDetalleKardex.Text = 0
            lblIdKardex.Text = 0
            _detalleKardex = Nothing
            dgvSecuencial.Rows.Clear()
        End Sub
        Private Sub txtArticulo_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtArticulo.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                lblIdArticulo.Text = _objSecuencialItem.BuscarIdSecuencialItemXNombreSecuencialItem(_tipoCon, txtArticulo.Text.Trim)
                lblIdKardex.Text = _objKardex.BuscarKardexPorIdSecuencialItem(_tipoCon, lblIdArticulo.Text.Trim)
                lblIdDetalleKardex.Text = _objDetalleKardex.BuscarMayorIdDetalleKardexxIdKardex(_tipoCon, lblIdKardex.Text)

                If CInt(lblIdKardex.Text) > 0 Then
                    _detalleKardex = _objKardex.BuscarUltimoMoviminetoKardexXIdKardex(_tipoCon, lblIdKardex.Text, lblIdDetalleKardex.Text)
                    txtCodigoArticulo.Text = _objSecuencialItem.BuscarCodigoSecuencialItemxNombreSecuencial(_tipoCon, txtArticulo.Text.Trim.ToUpper)

                    nudCantidad.Value = 1
                    nudValor.Value = _objSecuencialItem.BuscarPvpSecuencialItemXIdSecuencialItem(_tipoCon, lblIdArticulo.Text)

                    cmbObservacionCalidad.SelectedIndex = 0
                    tsmAgregar.Enabled = True
                Else
                    _detalleKardex = Nothing
                    txtArticulo.Clear()
                    txtCodigoArticulo.Clear()
                    cmbObservacionCalidad.SelectedIndex = 0
                    nudCantidad.Value = 0
                    nudValor.Value = 0
                    txtObservacion.Clear()
                    lblIdArticulo.Text = 0
                    lblIdDetalleKardex.Text = 0
                    lblIdKardex.Text = 0
                    _detalleKardex = Nothing
                    tsmAgregar.Enabled = False
                    tsmEliminar.Enabled = dgvSecuencial.RowCount > 0
                    MsgBox("EL ITEM SELECCIONADO NO EXISTE EN EL SISTEMA. DEBE CREAR EL ITEM EN LA OPCIÓN 'BODEGA / ARTÍCULOS Y PRODUCTOS' Y LUEGO REGISTAR EL 'COMPROBANTE DE INGRESO' CORRESPONDIENTE!!!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
            Catch
                txtArticulo.Clear()
                txtCodigoArticulo.Clear()
                cmbObservacionCalidad.SelectedIndex = 0
                nudCantidad.Value = 0
                nudValor.Value = 0
                txtObservacion.Clear()
                lblIdArticulo.Text = 0
                lblIdDetalleKardex.Text = 0
                lblIdKardex.Text = 0
                _detalleKardex = Nothing
            End Try
        End Sub

        Private Sub tsmAgregarArticulos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmAgregar.Click
            If _detalleKardex Is Nothing Then
                MsgBox("POR FAVOR, SELECCIONE UN ITEM PARA AGREGAR A LA LISTA!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÒN")
                Return
            End If

            If _detalleKardex.Rows.Count = 0 Then
                MsgBox("POR FAVOR, SELECCIONE UN ITEM PARA AGREGAR A LA LISTA!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÒN")
                Return
            End If

            If cmbObservacionCalidad.SelectedIndex = 0 Then
                MsgBox("POR FAVOR, SELECCIONE LA OBSERVACIÓN DE CALIDAD PARA ESTE ITEM", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÒN")
                Return
            End If

            Dim cant = CInt(nudCantidad.Value)
            Dim val = CDbl(nudValor.Value)
            If Not ValidarKardexRepetidos(CLng(lblIdKardex.Text)) Then

                Dim fila As String() = _
                    {
                        txtCodigoArticulo.Text, _
                        txtArticulo.Text, _
                        cant, _
                        val, _
                        cant * val, _
                        cmbObservacionCalidad.Text, _
                         txtObservacion.Text & " - SERIE: " & If(txtSerie.Text.Trim().Length = 0, "-", txtSerie.Text.Trim()), _
                        _detalleKardex.Rows(0)(0).ToString(), _
                        _detalleKardex.Rows(0)(9).ToString(), _
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(14).ToString()), CDbl(_detalleKardex.Rows(0)(17).ToString())), _
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(15).ToString()), CDbl(_detalleKardex.Rows(0)(18).ToString())), _
                        CDbl(_detalleKardex.Rows(0)(19).ToString()) - cant, _
                        val, _
                        (CDbl(_detalleKardex.Rows(0)(19).ToString()) - cant) * val, _
                        _detalleKardex.Rows(0)(1).ToString()
                    }
                dgvSecuencial.Rows.Add(fila)
                dgvSecuencial.Rows(dgvSecuencial.RowCount - 1).Tag = If(txtSerie.Text.Trim().Length = 0, "-", txtSerie.Text.Trim())

                txtArticulo.Clear()
                txtCodigoArticulo.Clear()
                cmbObservacionCalidad.SelectedIndex = 0
                nudCantidad.Value = 0
                nudValor.Value = 0
                txtObservacion.Clear()
                lblIdArticulo.Text = 0
                lblIdDetalleKardex.Text = 0
                lblIdKardex.Text = 0
                nudCantidad.Enabled = True
                txtSerie.Clear()
                _detalleKardex = Nothing
                tsmAgregar.Enabled = False
                tsmEliminar.Enabled = True

                CalcuarTotal()
            Else
                MsgBox("NO SE PUEDE AGREGAR UN ITEM REPETIDO", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÒN")
            End If
        End Sub

        Private Function ValidarKardexRepetidos(ByVal idKardex As Int64) As Boolean
            Dim contarRepetidos = 0
            Try
                For indice = 0 To dgvSecuencial.RowCount - 1 Step 1
                    If dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value = idKardex Then
                        contarRepetidos += 1
                    End If
                Next
                Return contarRepetidos > 0
            Catch
                Return False
            End Try
        End Function
        Private Sub tsmEliminarArticulo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmEliminar.Click
            If dgvSecuencial.Rows.Count = 0 Then Return
            dgvSecuencial.Rows.RemoveAt(dgvSecuencial.CurrentCell.RowIndex())
            tsmEliminar.Enabled = dgvSecuencial.RowCount > 0
            CalcuarTotal()
        End Sub
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            CargarComprobantesUniformes()
        End Sub

        Private Sub CargarComprobantesUniformes()
            Try
                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"

                If chkTodos.Checked Then
                    dgvComprobantesIngreso.DataSource = _objControl.SeleccionarComprobanteUniformesxRengoFechas(_tipoCon, fechaDesde, fechaHasta)
                Else
                    If rbtNum.Checked Then
                        dgvComprobantesIngreso.DataSource = _objControl.SeleccionarComprobanteUniformesxNroComprobante(_tipoCon, txtNroComprobante.Text.Trim)
                    Else
                        dgvComprobantesIngreso.DataSource = _objControl.SeleccionarComprobanteUniformesxDealle(_tipoCon, txtDetail.Text.Trim)
                    End If
                End If

                dgvComprobantesIngreso.AutoResizeColumns()
                dgvComprobantesIngreso.AutoResizeRows()
                dgvComprobantesIngreso.ReadOnly = True
            Catch
                dgvComprobantesIngreso.DataSource = Nothing
                dgvDetalleComprobate.DataSource = Nothing
            End Try
        End Sub
        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCancelar.Click
            HabilitarIngresos(False)

            Limpiar()

            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            tsmCancelar.Enabled = False
        End Sub
        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmGuardar.Click
            CalcuarTotal()
            If dgvSecuencial.RowCount = 0 Then
                MsgBox("POR FAVOR, INGRESE LOS ITEMS DEL COMPROBANTES PARA GUARDAR", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            If MessageBox.Show("DESEA GUARDAR LOS CAMBIOS?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            _sqlCommands.Clear()

            Dim cantidadPrendasLleva = 0
            With _objEntrega
                .Id = .BuscarMayorIdEntregaUniforme(_tipoCon) + 1
                .Codigo = txtCodigo.Text.Trim
                .Version = txtVersion.Text.Trim
                .Fecha = dtpFechaEmision.Value
                .Nombre = txtRecibe.Text.ToUpper.Trim
                .Cedula = txtCedula.Text.Trim
                .Cliente = txtCliente.Text.ToUpper.Trim
                .FechaIngreso = dtpIngreso.Value
                .Realizado = txtRealizado.Text.ToUpper.Trim
                .Revisado = txtRevisado.Text.ToUpper.Trim
                .Aprobado = txtAprobado.Text.ToUpper.Trim
                .Registrado = txtRegistrado.Text.ToUpper.Trim
                .Estado = 1
                .Observacion = txtObservacionEntrega.Text.ToUpper.Trim
            End With
            _sqlCommands.Add(_objEntrega.NuevoRegistroEntregaUniformesCommand())

            If Not pbFoto.Image Is Nothing Then
                With _objFoto
                    .IdFoto = .BuscarMayorIdFoto(_tipoCon) + 1
                    .Aux = "ENTREGA UNIFORMES"
                    .Imagen = ValidationForms.ImageToBytes(pbFoto.Image)
                    .IdAux = _objEntrega.Id
                End With
                _sqlCommands.Add(_objFoto.NuevoRegistroFotoCommands())
            End If

            ' descontar total uniformes rol
            With _objRegistroDescuento
                .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + 1
                .IdPersonal = If(txtCedula.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CInt(txtCedula.Tag))
                .Fecha = _objEntrega.Fecha
                .Procesado = 0
                .Mes = dtpRolPago.Value.Month
                .Anio = dtpRolPago.Value.Year
                .IdRol = 0
                .Tipo = 9 ' DESCUENTO EQ. SEG. / BODEGA
                .Observacion = "ENTREGA DE UNFIROMES (EQ. SEG. / BODEGA) AL SR(A): " & txtRecibe.Text & ", " & txtObservacionEntrega.Text.Trim
                .Valor = CDbl(lblTotalUniformes.Text.Trim.Split("$")(1).Trim())
                .Tipot = "DESCUENTO EQ. SEG. / BODEGA"
                .Idprog = 0
            End With
            _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())

            Dim iddk = _objDetalleKardex.BuscarMayorIdDetalleKardex(_tipoCon) + 1

            Dim iddu = _objDetalle.BuscarMayorIdDetalleUniformes(_tipoCon) + 1

            Dim idcu = _objControl.BuscarMayorIdControlUniformes(_tipoCon) + 1

            For indice = 0 To dgvSecuencial.RowCount - 1
                With _objDetalleKardex
                    .Id = iddk
                    .IdActividad = 2
                    .IdConcepto = 3
                    .CantidadIngreso = 0.0
                    .ValorUnitarioIngreso = 0.0
                    .ValorTotalIngreso = 0.0
                    .CantidadEgreso = CInt(dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD").Value.ToString.ToUpper)
                    .ValorUnitarioEgreso = CDec(dgvSecuencial.Rows.Item(indice).Cells("VALOR").Value.ToString.ToUpper)
                    .ValorTotalEgreso = CDec(dgvSecuencial.Rows.Item(indice).Cells("TOTAL").Value.ToString.ToUpper)
                    .CantidadSaldo = dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD_SALDO").Value.ToString.ToUpper
                    .ValorUnitarioSaldo = CDec(dgvSecuencial.Rows.Item(indice).Cells("VALOR_UNITARIO_SALDO").Value.ToString.ToUpper)
                    .ValorTotalSaldo = CDec(dgvSecuencial.Rows.Item(indice).Cells("SALDO").Value.ToString.ToUpper)
                    .Fecha = _objEntrega.Fecha
                    .IdKardex = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value.ToString.ToUpper)
                    .Estado = 10
                    .NroComprobante = _objEntrega.Id
                    cantidadPrendasLleva = dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD").Value
                End With
                _sqlCommands.Add(_objDetalleKardex.NuevoRegistroDetalleKardexCommand())


                With _objDetalle
                    .IdDetalle = iddu
                    .IdKardex = CType(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value.ToString.ToUpper, Int64)
                    .IdDetalleKardex = _objDetalleKardex.Id
                    .ObservacionEstado = dgvSecuencial.Rows.Item(indice).Cells("OBSERVACION").Value.ToString.ToUpper
                    .Cantidad = CType(dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD").Value.ToString.ToUpper, Integer)
                    .Estado = 1
                    .FechaRenovacion = _objEntrega.Fecha
                    .IdUniformes = _objEntrega.Id
                    .ObservacionDetalle = dgvSecuencial.Rows.Item(indice).Cells("DETALLES").Value.ToString.ToUpper
                End With
                _sqlCommands.Add(_objDetalle.NuevoRegistroDetalleUniformesCommand())

                With _objKardex
                    .Id = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value)
                    .IdsecuencialItem = CLng(dgvSecuencial.Rows.Item(indice).Cells("ID_SECUENCIAL").Value)
                    .Cantidad = CInt(dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD_SALDO").Value)
                    .Fecha = _objEntrega.Fecha
                    .Estado = 1
                End With
                _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand())


                With _objControl
                    .IdControl = idcu
                    .IdPersonal = If(txtCedula.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CInt(txtCedula.Tag))
                    .IdComprobante = _objEntrega.Id
                    .Cantidad = cantidadPrendasLleva
                    .Fecha = _objEntrega.Fecha
                    .IdActividad = 2
                    .Estado = 1
                    .IdDetalleKardex = _objDetalleKardex.Id
                End With
                _sqlCommands.Add(_objControl.NuevoRegistroControlUniformesCommand())

                iddk += 1
                iddu += 1
                idcu += 1
            Next

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then
                txtIdEntrega.Text = _objEntrega.Id

                HabilitarIngresos(False)

                tsmNuevo.Enabled = True
                tsmGuardar.Enabled = False
                tsmCancelar.Enabled = False

                tbComprobanteIngresoBodega.SelectedIndex = 2
            End If
            MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
        End Sub

        Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTodos.CheckedChanged
            If chkTodos.Checked Then
                txtNroComprobante.Enabled = False
                txtDetail.Enabled = False
                rbtNum.Enabled = False
                rbtDet.Enabled = False
                rbtNum.Checked = False
                rbtDet.Checked = False
            Else
                txtNroComprobante.Enabled = True
                txtDetail.Enabled = False
                rbtNum.Enabled = True
                rbtDet.Enabled = True
                rbtNum.Checked = True
                rbtDet.Checked = False
            End If
            txtNroComprobante.Clear()
            txtDetail.Clear()
        End Sub
        Private Sub btnExportarComprobantes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarComprobantes.Click
            ExportarDatosExcel(Me.dgvComprobantesIngreso, "COMPROBANTES DE UNIFORMES")
        End Sub
        Private Sub btnExportarDetalleComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarDetalleComprobante.Click
            ExportarDatosExcel(Me.dgvDetalleComprobate, "DETALLE DE COMPROABANTE DE UNIFORMES N°: " & CType(dgvComprobantesIngreso.CurrentRow.Cells.Item(0).Value, String))
        End Sub

        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)

            Dim app As Excel._Application = New Excel.Application()
            Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

            worksheet.Name = "INGRESO BODEGA"

            worksheet.Range("A1:Z" & dataGridViewExp.RowCount + dataGridViewExp.RowCount + 25).Font.Size = 10

            Dim ic As String = If(titulo.Contains("DETALLE"), "P", "O")

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
            worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " + Date.Now
            worksheet.Range("A3:" & ic & "3").Font.Size = 12

            'Aca se agregan las cabeceras de nuestro datagrid.
            Dim head = 4

            For i = 1 To dataGridViewExp.Columns.Count
                worksheet.Cells(1 + head, i) = dataGridViewExp.Columns(i - 1).HeaderText
                worksheet.Cells(1 + head, i).Font.Bold = True
                worksheet.Cells(1 + head, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(1 + head, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Cells(1 + head, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Cells(1 + head, i).Font.Color = Color.White
            Next

            Dim dataGridViewExpRowCount = 0
            For Each row As DataGridViewRow In dataGridViewExp.Rows
                If row.Visible Then
                    For j = 0 To dataGridViewExp.Columns.Count - 1
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1) = row.Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If dataGridViewExpRowCount = dataGridViewExp.RowCount - 1 Then
                            worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                    Next
                    dataGridViewExpRowCount += 1
                End If
            Next

            worksheet.Range("A1:Z" & dataGridViewExp.RowCount + dataGridViewExp.RowCount + 25).Columns.AutoFit()

            app.DisplayAlerts = False
            app.Visible = True
            app.DisplayAlerts = True
        End Sub
        Private Sub dgvComprobantesIngreso_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesIngreso.SelectionChanged
            If dgvComprobantesIngreso.Rows.Count = 0 Or dgvComprobantesIngreso.CurrentRow Is Nothing Then Return
            CargarDetalleComprobante(dgvComprobantesIngreso.CurrentRow.Cells.Item(0).Value)
        End Sub

        Private Sub CargarDetalleComprobante(ByVal idcomprobante As String)
            Try
                dgvDetalleComprobate.DataSource = _objControl.SeleccionarDetallesComprobanteuNniformesXId(_tipoCon, idcomprobante)

                dgvDetalleComprobate.Columns(0).Width = 80
                dgvDetalleComprobate.Columns(1).Width = 60
                dgvDetalleComprobate.Columns(2).Width = 60
                dgvDetalleComprobate.Columns(3).Width = 200
                dgvDetalleComprobate.Columns(4).Visible = False
                dgvDetalleComprobate.Columns(5).Width = 150
                dgvDetalleComprobate.Columns(5).HeaderText = "OBSERVACION"
                dgvDetalleComprobate.Columns(6).Width = 230
                dgvDetalleComprobate.Columns(6).HeaderText = "DETALLES"
                dgvDetalleComprobate.Columns(7).Width = 60
                dgvDetalleComprobate.Columns(8).Width = 60
                dgvDetalleComprobate.Columns(9).Width = 60
                dgvDetalleComprobate.Columns(10).Visible = False
                dgvDetalleComprobate.Columns(11).Width = 70

                dgvDetalleComprobate.AutoResizeRows()
                dgvDetalleComprobate.AutoResizeColumns()
            Catch
                dgvDetalleComprobate.DataSource = Nothing
            End Try
        End Sub
        Private Sub bntCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntCargar.Click
            ConectarReporteEntregaUniformes(CInt(txtIdEntrega.Text.Trim))
            PictureBox1.Image = Nothing
            Try
                Dim r = _objFoto.BuscarRegistroFoto(_tipoCon, "ENTREGA UNIFORMES", CInt(txtIdEntrega.Text.Trim))
                If r.Rows.Count = 0 Then Return
                PictureBox1.Image = ValidationForms.BytesToImage(CType(r.Rows(0)("FOTO"), Byte()))
            Catch
                PictureBox1.Image = Nothing
            End Try
        End Sub

        Private Sub ConectarReporteEntregaUniformes(ByVal idUniformes As Int64)
            _crEntrega.SetDataSource(_objEntrega.BuscarRegistroEntregaUniformesXid(_tipoCon, idUniformes))
            _crEntrega.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            _crEntrega.SetParameterValue("cisepro", ValidationForms.NombreCompany(_tipoCon))
            crvComprobante.ReportSource = Me._crEntrega
            crvComprobante.Zoom(100)
            crvComprobante.Refresh()
        End Sub
        Private Sub rbtNum_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbtNum.CheckedChanged
            If rbtNum.Checked Then
                txtDetail.Clear()
                txtNroComprobante.Clear()
                txtNroComprobante.Focus()
            End If
            txtNroComprobante.Enabled = rbtNum.Checked
            txtDetail.Enabled = rbtDet.Checked
        End Sub
        Private Sub rbtDet_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbtDet.CheckedChanged
            If rbtDet.Checked Then
                txtDetail.Clear()
                txtNroComprobante.Clear()
                txtDetail.Focus()
            End If
            txtNroComprobante.Enabled = rbtNum.Checked
            txtDetail.Enabled = rbtDet.Checked
        End Sub
        Private Sub txtNombre_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtRecibe.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                txtCedula.Tag = txtRecibe.Text.Split("-")(1).Trim()
                txtCedula.Text = _objPer.BuscarCedulaPersonalXIdPersonal(_tipoCon, txtCedula.Tag)

                Dim sitio = _objSitioTrabajo.SeleccionarSitiosClientexIdPersonal2(_tipoCon, txtCedula.Tag)
                If sitio.Rows.Count = 0 Then
                    sitio = _objSitioTrabajo.SeleccionarSitiosClientexIdPersonal1(_tipoCon, txtCedula.Tag)
                    If sitio.Rows.Count = 0 Then
                        txtCliente.Clear()
                    Else
                        txtCliente.Text = sitio.Rows(0).Item(0)
                    End If
                Else
                    txtCliente.Text = sitio.Rows(0).Item(0)
                End If
            Catch
                txtCedula.Tag = Nothing
                txtCedula.Clear()
                txtCliente.Clear()
            End Try
        End Sub

        Private Sub nudCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles nudCantidad.ValueChanged
            CalcuarTotal()
        End Sub

        Private Sub nudValor_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles nudValor.ValueChanged
            CalcuarTotal()
        End Sub

        Private Sub CalcuarTotal()
            If nudCantidad.Text.Trim().Length = 0 Then nudCantidad.Value = 0
            If nudValor.Text.Trim().Length = 0 Then nudValor.Value = 0
            nudTotal.Value = CInt(nudCantidad.Value) * CDec(nudValor.Value)

            Dim t = 0.0
            Dim p = 0
            For Each r As DataGridViewRow In dgvSecuencial.Rows
                t += CDec(r.Cells(4).Value)
                p += CDec(r.Cells(2).Value)
            Next
            Label25.Text = p & " PRENDA(S) - TOTAL UNIFORMES: "
            lblTotalUniformes.Text = "$ " & t
        End Sub

        Private Sub btnSerie_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSerie.Click
            Dim frm As New FrmBuscarActivoFijo
            frm.TipoCox = TipoCox

            Try
                If frm.ShowDialog = vbOK Then

                    Dim s = frm.dgvActivosFijos.CurrentRow.Cells(6).Value.ToString().Split(".")
                    txtSerie.Text = s(s.Length - 1)

                    nudCantidad.Value = 1
                    nudCantidad.Enabled = False

                    cmbObservacionCalidad.SelectedIndex = 2
                    txtObservacion.Text = "OK"
                End If
            Catch
                txtSerie.Text = "S/N"
                nudCantidad.Value = 1
                cmbObservacionCalidad.SelectedIndex = 2
            End Try
        End Sub

        Private Sub pbFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbFoto.Click
            Dim OpenFileDialog1 = New OpenFileDialog
            With OpenFileDialog1
                .InitialDirectory = "C:\"
                .Filter = "Image Files (*.png *.jpg *.jpeg *.bmp) |*.png; *.jpg; *.jpeg; *.bmp|All Files(*.*) |*.*"
                .FilterIndex = 1
            End With
            If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return
            With pbFoto
                .Image = Image.FromFile(OpenFileDialog1.FileName)
            End With
        End Sub

        Private Sub dgvSecuencial_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSecuencial.CellContentClick

        End Sub
    End Class
End Namespace