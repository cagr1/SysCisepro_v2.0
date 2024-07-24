Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.BODEGA
Imports ClassLibraryCisepro.INVENTARIOS.COMPROBANTES
Imports ClassLibraryCisepro.INVENTARIOS.CONCEPTOS
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.INVENTARIOS.KARDEX
Imports ClassLibraryCisepro.INVENTARIOS.UNIFORMES
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormComprobanteEgresoBodega
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
        Public IdUsuario As Integer
        Public UserName As String

        ReadOnly _objControl As New ClassControlUniformes
        ReadOnly _objSerie As New ClassGenerarSerie
        ReadOnly _objBodega As New ClassBodega
        ReadOnly _objDoc As New ClassParametroDocumentos
        ReadOnly _objCon As New ClassConceptosInventarios
        ReadOnly _objPer As New ClassPersonal
        ReadOnly _objUser As New ClassUsuarioGeneral
        ReadOnly _objProv As New ClassProveedores
        ReadOnly _objCli As New ClassClienteGeneral
        ReadOnly _objProvincia As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _objCentroCostos As New ClassCentroCosto
        ReadOnly _objCompEgr As New ClassComprobanteEgresoBodega
        ReadOnly _objDetCompEgr As New ClassDetalleComprobanteEgreso
        ReadOnly _crComprobanteEgreso As New crComprobanteEgreso
        ReadOnly _objSecuencialItem As New ClassSecuencialItem
        ReadOnly _objKardex As New ClassKardex
        ReadOnly _objDetalleKardex As New ClassDetalleKardex
        ReadOnly _objActivoFIjo As New ClassActivoFijo
        ReadOnly _objSitioTrabajo As New ClassSitiosTrabajo
        ReadOnly _objEntrega As New ClassEntregaUniformes
        ReadOnly _objRegistroDescuento As New ClassDescuentosPersonal
        ReadOnly _crComprobanteUniforme As New crComprobanteEgresoUniformes

        ReadOnly _objFoto As New ClassFoto

        ReadOnly _objDetalleEgresoPuesto As New ClassDetalleBodegaSitio

        ReadOnly _objCompIng As New ClassComprobanteIngresoBodego

        Dim _detalleKardex As New DataTable
        Dim _detalleKardexIngreso As New DataTable
        Dim _botonSeleccionadoSitio As Integer = 0

        Private Sub AutocompletarRecibe()
            txtRecibe.AutoCompleteCustomSource = _objPer.AutocompletarApellidos(_tipoCon, True)
            txtRecibe.AutoCompleteMode = AutoCompleteMode.Suggest
            txtRecibe.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub

        Private Sub AutocompletarProveedores()
            txtProveedores.AutoCompleteCustomSource = _objProv.Autocompletar(_tipoCon)
            txtProveedores.AutoCompleteMode = AutoCompleteMode.Suggest
            txtProveedores.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub

        Private Sub AutocompletarArticulo()
            txtArticulo.AutoCompleteCustomSource = _objSecuencialItem.Autocompletar(_tipoCon)
            txtArticulo.AutoCompleteMode = AutoCompleteMode.Suggest
            txtArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub

        Private Sub AutoCompletarArticuloIngreso()
            txtArticuloIngreso.AutoCompleteCustomSource = _objSecuencialItem.Autocompletar(_tipoCon)
            txtArticuloIngreso.AutoCompleteMode = AutoCompleteMode.Suggest
            txtArticuloIngreso.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub


        Private Sub FormComprobanteEgresoBodega_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label11.ForeColor = Color.White
                    'Label11.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesEgreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    'Label11.ForeColor = Color.White
                    'Label11.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesEgreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    'Label11.ForeColor = Color.White
                    'Label11.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesEgreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dgvSecuencial.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobantesEgreso.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobate.Font = New Font("Roboto", 8, FontStyle.Regular)

            txtFiltro.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            txtFiltro.Font = New Font("Roboto", 9, FontStyle.Regular)
            Dim validation As New ValidationForms()
            validation.SetPlaceholder(txtFiltro, "Buscar por Sitio o Nombre")


            _sqlCommands = New List(Of SqlCommand)
        End Sub

        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmNuevo.Click
            AutocompletarRecibe()
            AutocompletarProveedores()

            AutocompletarArticulo()

            CargarBodegas()

            LlenarConceptos(2) ' EGRESO

            LlenarComboProvincias()
            cbmCanton.SelectedValue = 58 ' MACHALA

            LlenarCentroCosto()
            cbmEgreso.SelectedIndex = 0

            CargarDocumentos()

            HabilitarIngresos(True)

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmCancelar.Enabled = True
            tsmActualizar.Enabled = False
            tmsEliminar.Enabled = False
            tsmReingreso.Enabled = False

            Limpiar()
            _botonSeleccionadoSitio = 1 ' CONTROL INGRESO

            cmbBodega.SelectedValue = 1 ' UNFORMES
            cmbBodega_SelectedValueChanged(Nothing, Nothing)

            txtProveedores.Text = _objPer.BuscarApellidosNombresPersonalXIdPersonal(_tipoCon, _objPer.BuscarIdPersonalXIdUsuario(_tipoCon, IdUsuario))

            txtRecibe.Focus()
        End Sub

        Private Sub Limpiar()
            txtNumero.Clear()
            txtNombre.Tag = Nothing
            txtNombre.Clear()
            txtCedula.Clear()
            txtNumero.Text = "S/N"

            txtRecibe.Tag = Nothing
            txtRecibe.Clear()
            txtUbicacion.Clear()
            txtRazon.Clear()


            txtArticulo.Clear()
            txtCodigoArticulo.Clear()
            cmbObservacionCalidad.SelectedIndex = 0
            nudCantidad.Value = 0
            nudValor.Value = 0
            txtObservacion.Clear()
            lblIdArticulo.Text = 0
            lblIdDetalleKardex.Text = 0
            lblIdKardex.Text = 0
            lbldetalle.Text = 0
            Label11.Text = "0 REGISTRO(S) - TOTAL"
            txtCedulaRecibe.Clear()

            txtArticuloIngreso.Clear()
            txtSerieIngreso.Clear()
            lblIdArticuloIngreso.Text = 0
            lblIdDetalleKardexIngreso.Text = 0
            lblIdKardexIngreso.Text = 0
            nudCantidadIngreso.Value = 0
            nudValorIngreso.Value = 0
            nudTotalIngreso.Value = 0
            cbxCalidadIngreso.SelectedIndex = 0
            txtObservacionesIngreso.Clear()

            _detalleKardex = Nothing
            _detalleKardexIngreso = Nothing
            dgvSecuencial.Rows.Clear()
            dgvDetalleComprobanteIngreso.Rows.Clear()
            dgvComprobantesEgreso.DataSource = Nothing
            dgvDetalleComprobate.DataSource = Nothing
        End Sub

        Private Sub HabilitarIngresos(ByVal cmbBodegaV As Boolean)
            cmbBodega.Enabled = cmbBodegaV
            cbmProvincia.Enabled = cmbBodegaV
            cbmCanton.Enabled = cmbBodegaV
            cbmParroquia.Enabled = cmbBodegaV
            cbmCentroCosto.Enabled = cmbBodegaV
            cmbDocumento.Enabled = cmbBodegaV
            txtNroDocumento.Enabled = cmbBodegaV
            dtpFecha.Enabled = cmbBodegaV
            cmbConceptos.Enabled = cmbBodegaV
            txtProveedores.Enabled = cmbBodegaV
            txtRecibe.Enabled = cmbBodegaV
            txtRazon.Enabled = cmbBodegaV
            gbBusquedaArticulo.Enabled = cmbBodegaV
            bntPuesto.Enabled = cmbBodegaV
            btnSerie.Enabled = cmbBodegaV
            pbFoto.Enabled = cmbBodegaV

        End Sub

        Private Sub CargarBodegas()
            Try
                cmbBodega.DataSource = _objBodega.SeleccionarBodegasActivas(_tipoCon)
                cmbBodega.ValueMember = "CÓDIGO"
                cmbBodega.DisplayMember = "BODEGA"
                cmbBodega.DropDownWidth = 400
                If (CType(cmbBodega.DataSource, DataTable).Rows.Count > 0) Then cmbBodega.SelectedIndex = 0
            Catch
                cmbBodega.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbBodega_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBodega.SelectedValueChanged
            If cmbBodega.SelectedValue Is Nothing Or TypeOf cmbBodega.SelectedValue Is DataRowView Then Return
            Dim cu = _objPer.BuscarPersonalCustodioBodegaPorIdBodega(_tipoCon, cmbBodega.SelectedValue)
            If cu.Rows.Count = 0 Then
                txtNombre.Tag = Nothing
                txtCedula.Clear()
                txtNombre.Clear()
                Return
            End If
            txtNombre.Tag = cu.Rows(0)(0).ToString
            txtCedula.Text = cu.Rows(0)(1).ToString
            txtNombre.Text = cu.Rows(0)(2).ToString

        End Sub

        Private Sub LlenarConceptos(ByVal idActividad As Integer)
            Try
                cmbConceptos.DataSource = _objCon.SeleccionarConceptosxIdActividad(_tipoCon, idActividad)
                cmbConceptos.DisplayMember = "DETALLE"
                cmbConceptos.ValueMember = "ID"
                If (CType(cmbConceptos.DataSource, DataTable).Rows.Count > 0) Then cmbConceptos.SelectedIndex = 0
            Catch
                cmbConceptos.DataSource = Nothing
            End Try
        End Sub

        Private Sub cmbConceptos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbConceptos.SelectedValueChanged
            If cmbConceptos.SelectedValue Is Nothing Or TypeOf cmbConceptos.SelectedValue Is DataRowView Then Return
            txtCódigo.Text = _objCon.BuscarCodigoxIdConcepto(_tipoCon, cmbConceptos.SelectedValue)
        End Sub

        Private Sub LlenarComboProvincias()
            Try
                cbmProvincia.DataSource = _objProvincia.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cbmProvincia.DisplayMember = "NOMBRE_PROVINCIAS"
                cbmProvincia.ValueMember = "ID_PROVINCIAS"
                cbmProvincia.DropDownWidth = 300
                If (CType(cbmProvincia.DataSource, DataTable).Rows.Count > 0) Then cbmProvincia.SelectedValue = 7
            Catch
                cbmProvincia.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmProvincia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmProvincia.SelectedValueChanged
            If cbmProvincia.SelectedValue Is Nothing Or TypeOf cbmProvincia.SelectedValue Is DataRowView Then Return
            LlenarComboCiudad()
        End Sub

        Private Sub LlenarComboCiudad()
            Try
                cbmCanton.DataSource = _objCiudad.BuscarNombreCiudadXIdProvincia(_tipoCon, CInt(cbmProvincia.SelectedValue))
                cbmCanton.DisplayMember = "NOMBRE_CIUDADES"
                cbmCanton.ValueMember = "ID_CIUDAD"
                cbmCanton.DropDownWidth = 300
                If (CType(cbmCanton.DataSource, DataTable).Rows.Count > 0) Then cbmCanton.SelectedIndex = 0
            Catch
                cbmCanton.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmCanton_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCanton.SelectedValueChanged
            If cbmCanton.SelectedValue Is Nothing Or TypeOf cbmCanton.SelectedValue Is DataRowView Then Return
            LlenarComboParroquias()
        End Sub

        Private Sub LlenarComboParroquias()
            Try
                cbmParroquia.DataSource = _objParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, CInt(cbmCanton.SelectedValue))
                cbmParroquia.DisplayMember = "NOMBRE_PARROQUIAS"
                cbmParroquia.ValueMember = "ID_PARROQUIAS"
                cbmParroquia.DropDownWidth = 300
                If (CType(cbmParroquia.DataSource, DataTable).Rows.Count > 0) Then cbmParroquia.SelectedIndex = 0
            Catch
                cbmParroquia.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarDocumentos()
            Try
                cmbDocumento.DataSource = _objDoc.SeleccionarParametrosDocumentos(_tipoCon)
                cmbDocumento.ValueMember = "ID_PARAMETRO_DOCUMENTOS"
                cmbDocumento.DisplayMember = "NOMBRE_PARAMETRO_DOCUMENTOS"
                cmbDocumento.DropDownWidth = 400
                If (CType(cmbDocumento.DataSource, DataTable).Rows.Count > 0) Then cmbDocumento.SelectedIndex = 0
            Catch
                cmbDocumento.DataSource = Nothing
            End Try
        End Sub

        Private Sub cmbDocumento_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbDocumento.SelectedValueChanged
            If cmbDocumento.SelectedValue Is Nothing Or TypeOf cmbDocumento.SelectedValue Is DataRowView Then Return
            txtNroDocumento.Text = "S/N"
            txtNroDocumento.Enabled = cmbDocumento.SelectedValue <> 8
        End Sub

        Private Sub LlenarCentroCosto()
            Try
                Dim data = _objCentroCostos.SeleccionarCentroCosto(_tipoCon)
                cbmCentroCosto.DataSource = data
                cbmCentroCosto.DisplayMember = "DETALLE_CENTRO_COSTO"
                cbmCentroCosto.ValueMember = "ID_CENTRO_COSTO"
                cbmCentroCosto.DropDownWidth = 300
                If (CType(cbmCentroCosto.DataSource, DataTable).Rows.Count > 0) Then cbmCentroCosto.SelectedIndex = 0
            Catch
                cbmCentroCosto.DataSource = Nothing
            End Try
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
                    ' nudCantidad.Value = 1
                    nudValor.Value = _objSecuencialItem.BuscarPvpSecuencialItemXIdSecuencialItem(_tipoCon, lblIdArticulo.Text)
                    cmbObservacionCalidad.SelectedIndex = 0
                    tsmAgregar.Enabled = True
                Else
                    _detalleKardex = Nothing
                    nudValor.Value = 0
                    txtCodigoArticulo.Clear()
                    cmbObservacionCalidad.SelectedIndex = 0
                    nudCantidad.Value = 0
                    txtObservacion.Clear()
                    lblIdArticulo.Text = 0
                    lblIdDetalleKardex.Text = 0
                    lblIdKardex.Text = 0
                    tsmAgregar.Enabled = False
                    tsmEliminar.Enabled = dgvSecuencial.RowCount > 0
                    MsgBox("EL ITEM SELECCIONADO NO EXISTE EN EL SISTEMA. DEBE CREAR EL ITEM EN LA OPCIÓN 'BODEGA / ARTÍCULOS Y PRODUCTOS' Y LUEGO REGISTAR EL 'COMPROBANTE DE INGRESO' CORRESPONDIENTE!!!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
                CalcuarTotal()
            Catch
                nudValor.Value = 0
                lblIdArticulo.Text = 0
                lblIdKardex.Text = 0
                lblIdDetalleKardex.Text = 0
                _detalleKardex = Nothing
                txtArticulo.Clear()
                txtCodigoArticulo.Clear()
                cmbObservacionCalidad.SelectedIndex = 0
                nudCantidad.Value = 0
                CalcuarTotal()
                txtObservacion.Clear()
                MsgBox("OCURRIÓ UN PROBLEMA AL SELECCIONAR ARTÍCULOS. POR FAVOR, CONTÁCTE AL ADMINISTRADOR!!!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End Try
        End Sub
        Private Sub tsmAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmAgregar.Click
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
            lbldetalle.Text = txtSerie.Text
            If Not ValidarKardexRepetidos(CLng(lblIdKardex.Text), lbldetalle.Text) Then

                Dim fila As String() =
                    {
                        txtCodigoArticulo.Text,
                        txtArticulo.Text,
                        cant,
                        val,
                        cant * val,
                        cmbObservacionCalidad.Text,
                        txtObservacion.Text & " - SERIE: " & If(txtSerie.Text.Trim().Length = 0, "-", txtSerie.Text.Trim()),
                        _detalleKardex.Rows(0)(0).ToString(),
                        _detalleKardex.Rows(0)(9).ToString(),
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(14).ToString()), CDbl(_detalleKardex.Rows(0)(17).ToString())),
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(15).ToString()), CDbl(_detalleKardex.Rows(0)(18).ToString())),
                        CDbl(_detalleKardex.Rows(0)(19).ToString()) - cant,
                        val,
                        (CDbl(_detalleKardex.Rows(0)(19).ToString()) - cant) * val,
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
                _detalleKardex = Nothing
                nudCantidad.Enabled = True
                txtSerie.Clear()
                tsmAgregar.Enabled = False
                tsmEliminar.Enabled = True
                Label11.Text = dgvSecuencial.Rows.Count & " REGISTRO(S) - TOTAL"
            Else
                MsgBox("NO SE PUEDE AGREGAR UN ITEM REPETIDO", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÒN")
            End If
        End Sub

        Private Function ValidarKardexRepetidos(ByVal idKardex As Int64, ByVal detalle As String) As Boolean
            Dim contarRepetidos = 0
            'Try
            '    For indice = 0 To dgvSecuencial.RowCount - 1 Step 1
            '        If dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value = idKardex Then
            '            contarRepetidos += 1
            '        End If
            '    Next
            '    Return contarRepetidos > 0
            'Catch
            '    Return False
            'End Try
            'Return False

            Try
                For indice = 0 To dgvSecuencial.RowCount - 1


                    Dim compareDetalle As String = dgvSecuencial.Rows.Item(indice).Cells("DETALLES").Value.ToString()
                    Dim compareSerie As String = ""


                    If compareDetalle.Contains("SERIE:") Then
                        compareSerie = compareDetalle.Substring(compareDetalle.IndexOf("SERIE:") + 6).Trim()
                    End If

                    If dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value = idKardex And detalle = compareSerie Then
                        contarRepetidos += 1
                    End If


                    'If dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value = idKardex AndAlso serie = detalle Then
                    '    contarRepetidos += 1
                    'End If

                Next

                For indice = 0 To dgvDetalleComprobanteIngreso.RowCount - 1
                    Dim compareDetalle As String = dgvDetalleComprobanteIngreso.Rows.Item(indice).Cells("DETALLES").Value.ToString()
                    Dim compareSerie As String = ""

                    If compareDetalle.Contains("SERIE:") Then
                        compareSerie = compareDetalle.Substring(compareDetalle.IndexOf("SERIE:") + 6).Trim()
                    End If

                    If dgvDetalleComprobanteIngreso.Rows.Item(indice).Cells("NUMERO_KARDEX").Value = idKardex And detalle = compareSerie Then
                        contarRepetidos += 1
                    End If
                Next


                Return contarRepetidos > 0
            Catch
                Return False
            End Try
        End Function

        Private Sub tsmEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmEliminar.Click
            If dgvSecuencial.Rows.Count = 0 Then Return
            dgvSecuencial.Rows.RemoveAt(dgvSecuencial.CurrentCell.RowIndex())
            tsmEliminar.Enabled = dgvSecuencial.RowCount > 0
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            'CargarComprobantesEgreso()
            tsmActualizar.Enabled = True
            tmsEliminar.Enabled = True
            tsmCancelar.Enabled = True
        End Sub



        Private Sub CargarComprobantesEgreso(ByVal Filtro As String)
            Try
                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"

                dgvComprobantesEgreso.DataSource = _objCompEgr.SeleccionarComprobanteEgresoBodegaxRengoFechas(_tipoCon, fechaDesde, fechaHasta, Filtro)
                'If chkTodos.Checked Then
                '    dgvComprobantesEgreso.DataSource = _objCompEgr.SeleccionarComprobanteEgresoBodegaxRengoFechas(_tipoCon, fechaDesde, fechaHasta)
                'Else
                '    If rbtNum.Checked Then
                '        dgvComprobantesEgreso.DataSource = _objCompEgr.SeleccionarComprobanteEgresoBodegaxNroComprobante(_tipoCon, txtNroComprobante.Text.Trim)
                '    Else
                '        dgvComprobantesEgreso.DataSource = _objCompEgr.SeleccionarComprobanteEgresoBodegaxDetalle(_tipoCon, txtDetail.Text.Trim)
                '    End If
                'End If

                For Each row In dgvComprobantesEgreso.Rows
                    If row.Cells("SITIO DE TRABAJO").Value.ToString() = "SIN SITIO" Then
                        row.DefaultCellStyle.BackColor = Color.LightCoral
                        row.DefaultCellStyle.ForeColor = Color.DarkRed
                    End If
                Next

                dgvComprobantesEgreso.AutoResizeColumns()
                dgvComprobantesEgreso.AutoResizeRows()
                dgvComprobantesEgreso.ReadOnly = True
                dgvComprobantesEgreso.Columns(17).Visible = False
            Catch
                dgvComprobantesEgreso.DataSource = Nothing
                dgvDetalleComprobate.DataSource = Nothing
            End Try
        End Sub
        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmCancelar.Click
            HabilitarIngresos(False)

            Limpiar()

            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            tsmCancelar.Enabled = False
            tsmActualizar.Enabled = False
            tsmEliminar.Enabled = False
            tsmReingreso.Enabled = False

            lblArticuloTitulo.Visible = False
            lblArticuloTitulo.SendToBack()
            txtArticuloIngreso.Visible = False
            txtArticuloIngreso.SendToBack()
            lblSerieTitulo.Visible = False
            lblSerieTitulo.SendToBack()
            txtSerieIngreso.Visible = False
            txtSerieIngreso.SendToBack()
            btnBuscarReingreso.Visible = False
            btnBuscarReingreso.SendToBack()
            lblCantidadTitulo.Visible = False
            lblCantidadTitulo.SendToBack()
            nudCantidadIngreso.Visible = False
            nudCantidadIngreso.SendToBack()
            lblValorTitulo.Visible = False
            lblValorTitulo.SendToBack()
            nudValorIngreso.Visible = False
            nudValorIngreso.SendToBack()
            lblTotalTitulo.Visible = False
            lblTotalTitulo.SendToBack()
            nudTotalIngreso.Visible = False
            nudTotalIngreso.SendToBack()
            cbxCalidadIngreso.Visible = False
            cbxCalidadIngreso.SendToBack()
            lblObservacionesTitulo.Visible = False
            lblObservacionesTitulo.SendToBack()
            txtObservacionesIngreso.Visible = False
            txtObservacionesIngreso.SendToBack()
            btnAgregarIngreso.Visible = False
            btnAgregarIngreso.SendToBack()
            btnEliminaringreso.Visible = False
            btnEliminaringreso.SendToBack()
            dgvDetalleComprobanteIngreso.Visible = False
            dgvDetalleComprobanteIngreso.SendToBack()




        End Sub
        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmGuardar.Click



            'If MessageBox.Show("DESEA GUARDAR LOS CAMBIOS?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            If KryptonMessageBox.Show("DESEA GUARDAR LOS CAMBIOS?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

            _sqlCommands.Clear()
            If _botonSeleccionadoSitio = 1 Then

                If dgvSecuencial.RowCount = 0 Then
                    KryptonMessageBox.Show("POR FAVOR, INGRESE LOS ITEMS DEL COMPROBANTES PARA GUARDAR", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If CInt(txtUbicacion.Tag) = 0 Then
                    KryptonMessageBox.Show("POR FAVOR, SELECCIONE UN SITIO DE TRABAJO", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                Dim cantidadPrendasLleva = 0

                If cmbBodega.SelectedValue = 1 Then
                    With _objEntrega
                        .Id = .BuscarMayorIdEntregaUniforme(_tipoCon) + 1
                        .Codigo = "RE-3.8.1-2"
                        .Version = "003"
                        .Fecha = dtpFecha.Value
                        .Nombre = txtRecibe.Text.ToUpper.Trim
                        .Cedula = txtCedulaRecibe.Text.Trim
                        .Cliente = txtUbicacion.Text.ToUpper.Trim
                        .FechaIngreso = dtpFecha.Value
                        .Realizado = "ING. JOSÉ NAVARRETE M."
                        .Revisado = "ING. KAREN NAVARRETE M"
                        .Aprobado = "MYR(R) IGNACIO NAVARRETE L"
                        .Registrado = txtNombre.Text.ToUpper.Trim
                        .Estado = 1
                        .Observacion = txtRazon.Text.ToUpper.Trim
                    End With
                    _sqlCommands.Add(_objEntrega.NuevoRegistroEntregaUniformesCommand())

                End If

                With _objCompEgr

                    .Id = (_objSerie.Serie(_objCompEgr.BuscarMayorIdComprobanteEgresoBodega(_tipoCon) + 1))
                    .Fecha = dtpFecha.Value
                    .Nro = txtNroDocumento.Text
                    .IdBodega = cmbBodega.SelectedValue
                    .IdActividad = 2
                    .IdConcepto = cmbConceptos.SelectedValue
                    .IdProvincias = cbmProvincia.SelectedValue
                    .IdCiudad = cbmCanton.SelectedValue
                    .IdParroquias = cbmParroquia.SelectedValue
                    .IdCentroCosto = cbmCentroCosto.SelectedValue
                    .IdParametroDocumento = cmbDocumento.SelectedValue
                    .Estado = 1
                    .Razon = txtRazon.Text.ToUpper
                    .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                    .Cliente = txtUbicacion.Text.Trim
                    .IdEmpresa = 1
                    .SitioTrabajo = CInt(txtUbicacion.Tag)
                End With
                _sqlCommands.Add(_objCompEgr.NuevoRegistroComprobanteEgresoBodegaCommand())

                If Not pbFoto.Image Is Nothing Then
                    With _objFoto
                        .IdFoto = .BuscarMayorIdFoto(_tipoCon) + 1
                        .Aux = "EGRESO BODEGA"
                        .Imagen = ValidationForms.ImageToBytes(pbFoto.Image)
                        .IdAux = _objCompEgr.Id
                    End With
                    _sqlCommands.Add(_objFoto.NuevoRegistroFotoCommands())
                End If


                Dim iddk = _objDetalleKardex.BuscarMayorIdDetalleKardex(_tipoCon) + 1
                Dim idce = _objDetCompEgr.BuscarMayorIdDetalleComprobanteEgresoBodega(_tipoCon) + 1
                Dim idu = _objControl.BuscarMayorIdControlUniformes(_tipoCon) + 1
                Dim idd = _objDetalleEgresoPuesto.BuscarMayorIdRegistroDetalleComprobante(_tipoCon) + 1

                Try




                    For indice = 0 To dgvSecuencial.RowCount - 1

                        'Control por cada celda 
                        'Dim idKdex = Row.Cells("NUMERO_KARDEX").Value
                        Dim row As DataGridViewRow = dgvSecuencial.Rows(indice)
                        Dim idKdex = row.Cells("NUMERO_KARDEX").Value
                        If idKdex > 0 Then
                            Dim para As String = idKdex.ToString()
                            Dim valor As Int32 = _objSecuencialItem.BuscarDescuentoSecuencialItem(_tipoCon, para)
                            If valor > 0 Then
                                With _objRegistroDescuento
                                    .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + 1
                                    .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                                    .Fecha = _objEntrega.Fecha
                                    .Procesado = 0
                                    .Mes = dtpFecha.Value.Month
                                    .Anio = dtpFecha.Value.Year
                                    .IdRol = 0
                                    .Tipo = 9 ' DESCUENTO EQ. SEG. / BODEGA
                                    .Observacion = "ENTREGA DE UNIFORMES (EQ. SEG. / BODEGA) AL SR(A): " & txtRecibe.Text & ", " & row.Cells("NOMBRE").Value.ToString()
                                    .Valor = CDbl(row.Cells("VALOR").Value)
                                    .Tipot = "DESCUENTO EQ. SEG. / BODEGA"
                                    .Idprog = 0
                                End With
                                _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())
                            End If
                        End If



                        With _objDetalleKardex
                            .Id = iddk
                            .IdActividad = 2
                            .IdConcepto = cmbConceptos.SelectedValue
                            .CantidadIngreso = 0.0
                            .ValorUnitarioIngreso = 0.0
                            .ValorTotalIngreso = 0.0
                            .CantidadEgreso = CInt(dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD").Value.ToString.ToUpper)
                            .ValorUnitarioEgreso = CDec(dgvSecuencial.Rows.Item(indice).Cells("VALOR").Value.ToString.ToUpper)
                            .ValorTotalEgreso = CDec(dgvSecuencial.Rows.Item(indice).Cells("TOTAL").Value.ToString.ToUpper)
                            .CantidadSaldo = dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD_SALDO").Value.ToString.ToUpper
                            .ValorUnitarioSaldo = CDec(dgvSecuencial.Rows.Item(indice).Cells("VALOR_UNITARIO_SALDO").Value.ToString.ToUpper)
                            .ValorTotalSaldo = CDec(dgvSecuencial.Rows.Item(indice).Cells("SALDO").Value.ToString.ToUpper)
                            .Fecha = _objCompEgr.Fecha
                            .IdKardex = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value.ToString.ToUpper)
                            .Estado = 1
                            .NroComprobante = _objCompEgr.Id
                            cantidadPrendasLleva = dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD").Value
                        End With
                        _sqlCommands.Add(_objDetalleKardex.NuevoRegistroDetalleKardexCommand())

                        With _objDetCompEgr
                            .IdDetalle = idce
                            .IdKardex = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value.ToString.ToUpper)
                            .IdDetalleKardex = _objDetalleKardex.Id
                            .ObservacionCalidad = dgvSecuencial.Rows.Item(indice).Cells("OBSERVACION").Value.ToString.ToUpper
                            .ObservacionDetalle = dgvSecuencial.Rows.Item(indice).Cells("DETALLES").Value.ToString.ToUpper
                            .IdComprobante = _objCompEgr.Id
                            .Estado = 1
                        End With
                        _sqlCommands.Add(_objDetCompEgr.NuevoRegistroDetalleComprobanteEgresoBodegaCommand())

                        ' PUESTO   -   DETALLE
                        With _objDetalleEgresoPuesto
                            .Id = idd
                            .IdSitio = CInt(txtUbicacion.Tag)
                            .IdDetalle = idce
                            .Fecha = dtpFecha.Value
                            .Tipo = "EGRESO"
                            .Estado = 1
                            .Serie = dgvSecuencial.Rows.Item(indice).Tag.ToString
                        End With
                        _sqlCommands.Add(_objDetalleEgresoPuesto.NuevoRegistroDetalleComprobanteEgresoSitioCommand())
                        idd += 1

                        With _objKardex
                            .Id = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value)
                            .IdsecuencialItem = CLng(dgvSecuencial.Rows.Item(indice).Cells("ID_SECUENCIAL").Value)
                            .Cantidad = CInt(dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD_SALDO").Value)
                            .Fecha = _objCompEgr.Fecha
                            .Estado = 1
                        End With
                        _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand())

                        With _objControl
                            .IdControl = idu
                            .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                            .IdComprobante = _objCompEgr.Id
                            .Cantidad = cantidadPrendasLleva
                            .Fecha = _objCompEgr.Fecha
                            .IdActividad = 2
                            .Estado = 1
                            .IdDetalleKardex = _objDetalleKardex.Id
                        End With
                        _sqlCommands.Add(_objControl.NuevoRegistroControlUniformesCommand())

                        iddk += 1
                        idce += 1
                        idu += 1
                    Next
                Catch ex As Exception
                    KryptonMessageBox.Show("Error al guardar los datos:" & ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

                    Return
                End Try
            ElseIf _botonSeleccionadoSitio = 2 Then
                ModicificarComprobanteEgreso()
            Else
                ReingresoComprante()
            End If

            Dim nombreU As String = ""

            If _botonSeleccionadoSitio = 1 Then
                nombreU = "COMPROBANTE EGRESO " & UserName
            ElseIf _botonSeleccionadoSitio = 2 Then
                nombreU = "MODIFICACIÓN COMPROBANTE EGRESO " & UserName
            ElseIf _botonSeleccionadoSitio = 3 Then
                nombreU = "REINGRESO COMPROBANTE EGRESO " & UserName
            End If

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then
                txtNumero.Text = _objCompEgr.Id
                txtIdComprobante.Text = txtNumero.Text
                tbComprobanteIngresoBodega.SelectedIndex = 2
            End If

            Dim messageIcon As KryptonMessageBoxIcon
            If res(0) Then
                messageIcon = KryptonMessageBoxIcon.Information
            Else
                messageIcon = KryptonMessageBoxIcon.Exclamation
            End If
            KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
            HabilitarIngresos(False)
            Limpiar()
            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            tsmCancelar.Enabled = False
            tsmActualizar.Enabled = False
            tsmEliminar.Enabled = False
            tsmReingreso.Enabled = False

        End Sub

        'Private Sub chkNumeroComprobante_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        '    If chkTodos.Checked Then
        '        txtNroComprobante.Enabled = False
        '        txtDetail.Enabled = False
        '        rbtNum.Enabled = False
        '        rbtDet.Enabled = False
        '        rbtNum.Checked = False
        '        rbtDet.Checked = False
        '    Else
        '        txtNroComprobante.Enabled = True
        '        txtDetail.Enabled = False
        '        rbtNum.Enabled = True
        '        rbtDet.Enabled = True
        '        rbtNum.Checked = True
        '        rbtDet.Checked = False
        '    End If
        '    txtNroComprobante.Clear()
        '    txtDetail.Clear()
        'End Sub
        Private Sub btnExportarComprobantes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarComprobantes.Click
            ExportarDatosExcel(dgvComprobantesEgreso, "COMPROBANTES DE EGRESO DE BODEGA ")
        End Sub
        Private Sub btnExportarDetalleComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            ExportarDatosExcel(dgvDetalleComprobate, "DETALLE DE COMPROABANTE DE EGRESO N°: " & CType(dgvComprobantesEgreso.CurrentRow.Cells.Item(0).Value, String))
        End Sub

        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)
            Try
                Dim app As Excel._Application = New Excel.Application()
                Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

                worksheet.Name = "EGRESO BODEGA"

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
            Catch ex As Exception
                MsgBox("NO SE PUEDE EXPORTAR, CONTÁCTE AL ADMINISTRADOR", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÒN")
            End Try
        End Sub

        Private Sub dgvComprobantesEgreso_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesEgreso.SelectionChanged
            If dgvComprobantesEgreso.Rows.Count = 0 Or dgvComprobantesEgreso.CurrentRow Is Nothing Then Return
            CargarDetalleComprobante(dgvComprobantesEgreso.CurrentRow.Cells.Item(0).Value)
            CargarDetalleComprobanteIngreso(dgvComprobantesEgreso.CurrentRow.Cells.Item(0).Value)
            CargarBodegas()
            AutocompletarRecibe()
            AutocompletarProveedores()
            AutocompletarArticulo()

            LlenarConceptos(2) ' EGRESO
            LlenarComboProvincias()
            cbmCanton.SelectedValue = 58 ' MACHALA
            LlenarCentroCosto()
            cbmEgreso.SelectedIndex = 0
            CargarDocumentos()

            'cmbConcepto.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(4).Value

            txtNumero.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(0).Value.ToString().Trim() 'Id_comprobante_ingreso  
            cmbBodega.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(3).Value ' Id_bodega
            cbmProvincia.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(7).Value ' Id_provincia
            cbmCanton.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(8).Value ' Id_ciudad
            cbmParroquia.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(9).Value ' Id_parroquia
            cbmCentroCosto.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(10).Value ' Id_centro_costo

            dtpFecha.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(1).Value ' fecha_comprobante_ingreso






            txtCódigo.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(5).Value ' 
            cmbConceptos.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(6).Value
            txtProveedores.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(14).Value.ToString()
            txtUbicacion.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(15).Value
            txtRecibe.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(13).Value + " - " + dgvComprobantesEgreso.CurrentRow.Cells.Item(17).Value.ToString()
            txtRazon.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(12).Value
            cmbDocumento.Text = dgvComprobantesEgreso.CurrentRow.Cells.Item(16).Value ' id_parametro_documento
            UpdateUbicacion(dgvComprobantesEgreso.CurrentRow.Cells.Item(17).Value.ToString())

            'Label28.Text = ListView1.SelectedItems(0).SubItems(0).Text
        End Sub

        Private Sub CargarDetalleComprobante(ByVal idcomprobante As String)
            Try
                dgvDetalleComprobate.DataSource = _objCompEgr.SeleccionarDetallesComprobantesEgreso(_tipoCon, idcomprobante)

                dgvDetalleComprobate.Columns(0).Width = 80
                dgvDetalleComprobate.Columns(1).Width = 60
                dgvDetalleComprobate.Columns(2).Width = 60
                dgvDetalleComprobate.Columns(3).Width = 200
                dgvDetalleComprobate.Columns(4).Width = 60
                dgvDetalleComprobate.Columns(5).Width = 60
                dgvDetalleComprobate.Columns(6).Width = 120
                dgvDetalleComprobate.Columns(7).Width = 250
                dgvDetalleComprobate.Columns(8).Width = 60
                dgvDetalleComprobate.Columns(9).Width = 60
                dgvDetalleComprobate.Columns(10).Width = 60
                dgvDetalleComprobate.Columns(11).Width = 60
                dgvDetalleComprobate.Columns(12).Width = 100
                dgvDetalleComprobate.Columns(13).Width = 80
                dgvDetalleComprobate.Columns(14).Width = 80
                dgvDetalleComprobate.Columns(15).Width = 200
                dgvDetalleComprobate.Columns(16).Visible = False
                dgvDetalleComprobate.Columns(17).Visible = False


                dgvDetalleComprobate.AutoResizeRows()
                dgvDetalleComprobate.AutoResizeColumns()
                dgvDetalleComprobate.ReadOnly = True



            Catch
                dgvDetalleComprobate.DataSource = Nothing
            End Try
        End Sub
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            ConectarReporteComprobanteEgreso(txtIdComprobante.Text.Trim)
            PictureBox1.Image = Nothing
            Try
                Dim r = _objFoto.BuscarRegistroFoto(_tipoCon, "EGRESO BODEGA", CInt(txtIdComprobante.Text.Trim))
                If r.Rows.Count = 0 Then Return
                PictureBox1.Image = ValidationForms.BytesToImage(CType(r.Rows(0)("FOTO"), Byte()))
            Catch
                PictureBox1.Image = Nothing
            End Try
        End Sub

        Private Sub ConectarReporteComprobanteEgreso(ByVal idComprobante As String)
            Try
                _crComprobanteEgreso.SetDataSource(_objCompEgr.SeleccionarComprobanteEgresoxIdComprobanteEgreso(_tipoCon, idComprobante))
                _crComprobanteEgreso.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                _crComprobanteEgreso.SetParameterValue("ubicacion", _objCompEgr.BuscarClienteByIdComprobanteEgresoBodega(_tipoCon, idComprobante))
                crvComprobante.ReportSource = _crComprobanteEgreso
                crvComprobante.Zoom(100)
                crvComprobante.Refresh()
            Catch
                crvComprobante.ReportSource = Nothing
            End Try
        End Sub
        'Private Sub rbtNum_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        '    If rbtNum.Checked Then
        '        txtDetail.Clear()
        '        txtNroComprobante.Clear()
        '        txtNroComprobante.Focus()
        '    End If
        '    txtNroComprobante.Enabled = rbtNum.Checked
        '    txtDetail.Enabled = rbtDet.Checked
        'End Sub
        'Private Sub rbtDet_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        '    If rbtDet.Checked Then
        '        txtDetail.Clear()
        '        txtNroComprobante.Clear()
        '        txtDetail.Focus()
        '    End If
        '    txtNroComprobante.Enabled = rbtNum.Checked
        '    txtDetail.Enabled = rbtDet.Checked
        'End Sub

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
        End Sub

        Private Sub CalcularTotalIngreso()
            If nudCantidadIngreso.Text.Trim().Length = 0 Then nudCantidadIngreso.Value = 0
            If nudValorIngreso.Text.Trim().Length = 0 Then nudValorIngreso.Value = 0
            nudTotalIngreso.Value = CInt(nudCantidadIngreso.Value) * CDec(nudValorIngreso.Value)
        End Sub

        Private Sub bntPuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntPuesto.Click
            Dim frm As New FrmBuscarPuestoTrabajo
            frm.TipoCox = TipoCox
            frm.Label3.Text = "TODOS LOS PUESTOS REGISTRADOS"
            frm.Text = "BUSCAR SITIOS DE TRABAJO"

            Try
                If frm.ShowDialog = vbOK Then
                    txtUbicacion.Tag = frm.ListView1.SelectedItems(0).SubItems(0).Text.Trim ' ids
                    txtUbicacion.Text = "CLIENTE: " & frm.ListView1.SelectedItems(0).Group.Header.Trim & vbNewLine & _
                        "PUESTO: " & frm.ListView1.SelectedItems(0).SubItems(2).Text.Trim
                End If
            Catch
                txtUbicacion.Tag = Nothing
                txtUbicacion.Clear()
            End Try
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSerie.Click
            Dim frm As New FrmBuscarActivoFijo
            frm.TipoCox = TipoCox

            Try
                If frm.ShowDialog = vbOK Then

                    Dim s = frm.dgvActivosFijos.CurrentRow.Cells(6).Value.ToString().Split(".")
                    txtSerie.Text = s(s.Length - 1)

                    'nudCantidad.Value = 1
                    'nudCantidad.Enabled = False

                    cmbObservacionCalidad.SelectedIndex = 2
                    txtObservacion.Text = "OK"
                End If
            Catch
                txtSerie.Text = "S/N"
                'nudCantidad.Value = 1
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

        Private Sub txtIdComprobante_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdComprobante.TextChanged

        End Sub

        Private Sub crvComprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvComprobante.Load

        End Sub

        Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        End Sub

        Private Sub dgvDetalleComprobate_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleComprobate.SelectionChanged
            If dgvDetalleComprobate.Rows.Count = 0 Or dgvDetalleComprobate.CurrentRow Is Nothing Then Return


            Dim serieResult As String = ""
            Dim dataTable = _objCompEgr.SeleccionarSerieByIdDetalleComprobanteEgresoBodega(_tipoCon, CType(dgvDetalleComprobate.CurrentRow.Cells.Item(0).Value.ToString(), String), CType(dgvDetalleComprobate.CurrentRow.Cells.Item(1).Value.ToString(), String), CType(dgvDetalleComprobate.CurrentRow.Cells.Item(2).Value.ToString(), String))

            If dataTable.Rows.Count > 0 AndAlso dataTable.Rows(0)("SERIE") IsNot DBNull.Value Then
                Dim serieInfo As String = dataTable.Rows(0)("SERIE").ToString()
                Dim index As Integer = serieInfo.IndexOf(":")

                If index <> -1 AndAlso index < serieInfo.Length - 1 Then
                    serieResult = serieInfo.Substring(index + 1).Trim()
                End If
            End If

            txtSerie.Text = serieResult
            nudCantidad.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(8).Value ' cantidad egreso
            nudValor.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(9).Value ' valor egreso
            nudTotal.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(10).Value
            lblIdKardex2.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(2).Value ' Id kardex
            lblDetaComp.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(1).Value ' Id Detalle comprobante
            cmbObservacionCalidad.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(6).Value
            txtArticulo.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(3).Value
            txtObservacion.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(7).Value
            lblDetKardex.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(5).Value ' Id detalle kardex
            lblComp.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(0).Value 'ID de comprobante
            lblIdSecuencial.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(16).Value ' Id Secuencial 
            lblCantidadSaldo.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(17).Value ' cantidad_saldo 

           

        End Sub

        Private Sub tsmActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


            
            HabilitarIngresos(True)
            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmCancelar.Enabled = True
            _botonSeleccionadoSitio = 2
            If txtNumero.Text.Trim().Length > 0 Then

            Else

                MsgBox("SELECCIONE UN REGISTRO A MODIFICAR", MsgBoxStyle.Information, "MENSAJE")
            End If


           
        End Sub

        Private Sub ModicificarComprobanteEgreso()



            Dim cant = CInt(nudCantidad.Value)
            Dim val = CDbl(nudValor.Value)
            Dim toEgre = cant * val
            Dim saldoTotal = Convert.ToInt32(lblCantidadSaldo.Text)
            Dim CantidadEgreso = Convert.ToInt32(dgvDetalleComprobate.CurrentRow.Cells.Item(8).Value)


            Dim result As DataTable = _objControl.SeleccionarIdControlUniformes(_tipoCon, lblComp.Text, lblDetKardex.Text)

            'If cmbBodega.SelectedValue = 1 Then
            '    With _objEntrega
            '        .Id = .BuscarMayorIdEntregaUniforme(_tipoCon) + 1
            '        .Codigo = "RE-3.8.1-2"
            '        .Version = "003"
            '        .Fecha = dtpFecha.Value
            '        .Nombre = txtRecibe.Text.ToUpper.Trim
            '        .Cedula = txtCedulaRecibe.Text.Trim
            '        .Cliente = txtUbicacion.Text.ToUpper.Trim
            '        .FechaIngreso = dtpFecha.Value
            '        .Realizado = "ING. JOSÉ NAVARRETE M."
            '        .Revisado = "ING. KAREN NAVARRETE M"
            '        .Aprobado = "MYR(R) IGNACIO NAVARRETE L"
            '        .Registrado = txtNombre.Text.ToUpper.Trim
            '        .Estado = 1
            '        .Observacion = txtRazon.Text.ToUpper.Trim
            '    End With
            '    _sqlCommands.Add(_objEntrega.NuevoRegistroEntregaUniformesCommand())

            'End If


            With _objCompEgr

                .Id = lblComp.Text
                .Fecha = dtpFecha.Value
                .Nro = txtNroDocumento.Text
                .IdBodega = cmbBodega.SelectedValue
                .IdActividad = 2
                .IdConcepto = cmbConceptos.SelectedValue
                .IdProvincias = cbmProvincia.SelectedValue
                .IdCiudad = cbmCanton.SelectedValue
                .IdParroquias = cbmParroquia.SelectedValue
                .IdCentroCosto = cbmCentroCosto.SelectedValue
                .IdParametroDocumento = cmbDocumento.SelectedValue
                .Estado = 1
                .Razon = txtRazon.Text.ToUpper
                .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                .IdEmpresa = 1
                .Cliente = txtUbicacion.Text.Trim
                .SitioTrabajo = CInt(txtUbicacion.Tag)
            End With
            _sqlCommands.Add(_objCompEgr.ModificarComprobanteEgresoBodegaCommand())

            If result.Rows.Count > 0 Then
                Dim idcon As Long = Convert.ToInt64(result.Rows(0)("ID_CONTROL"))

                With _objControl

                    .IdControl = idcon
                    .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                    .IdComprobante = Convert.ToString(lblComp.Text)
                    .Cantidad = cant
                    .Fecha = dtpFecha.Value
                    .IdActividad = 2
                    .Estado = 1
                    .IdDetalleKardex = lblDetKardex.Text
                End With
                _sqlCommands.Add(_objControl.ModificarControlCommand())

            End If

            With _objDetCompEgr
                .IdDetalle = lblDetaComp.Text
                .IdKardex = lblIdKardex2.Text
                .IdDetalleKardex = lblDetKardex.Text
                .ObservacionCalidad = cmbObservacionCalidad.Text.ToUpper
                .ObservacionDetalle = txtObservacion.Text.ToUpper & " - SERIE: " & If(txtSerie.Text.Trim().Length = 0, "-", txtSerie.Text.Trim())
                .IdComprobante = lblComp.Text
                .Estado = 1
            End With
            _sqlCommands.Add(_objDetCompEgr.ModificarDetalleComprobanteEgresoBodegaCommand())


            If CantidadEgreso > cant Then

                With _objDetalleKardex
                    .Id = lblDetKardex.Text
                    .IdActividad = 2
                    .IdConcepto = cmbConceptos.SelectedValue
                    .CantidadIngreso = 0.0
                    .ValorUnitarioIngreso = 0.0
                    .ValorTotalIngreso = 0.0
                    .CantidadEgreso = cant
                    .ValorUnitarioEgreso = val
                    .ValorTotalEgreso = toEgre
                    .CantidadSaldo = saldoTotal + (CantidadEgreso - cant)
                    .ValorUnitarioSaldo = val
                    .ValorTotalSaldo = (saldoTotal + (CantidadEgreso - cant)) * val
                    .Fecha = dtpFecha.Value
                    .IdKardex = Convert.ToInt64(lblIdKardex2.Text)
                    .Estado = 1
                    .NroComprobante = lblComp.Text

                End With
                _sqlCommands.Add(_objDetalleKardex.ModificarDetalleKardexCommand())

                With _objKardex
                    .Id = lblIdKardex2.Text
                    .IdsecuencialItem = lblIdSecuencial.Text
                    .Cantidad = saldoTotal + (CantidadEgreso - cant)
                    .Fecha = dtpFecha.Value
                    .Estado = 1
                End With
                _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand)

            ElseIf CantidadEgreso < cant Then

                With _objDetalleKardex
                    .Id = lblDetKardex.Text
                    .IdActividad = 2
                    .IdConcepto = cmbConceptos.SelectedValue
                    .CantidadIngreso = 0.0
                    .ValorUnitarioIngreso = 0.0
                    .ValorTotalIngreso = 0.0
                    .CantidadEgreso = cant
                    .ValorUnitarioEgreso = val
                    .ValorTotalEgreso = toEgre
                    .CantidadSaldo = saldoTotal - (cant - CantidadEgreso)
                    .ValorUnitarioSaldo = val
                    .ValorTotalSaldo = (saldoTotal - (cant - CantidadEgreso)) * val
                    .Fecha = dtpFecha.Value
                    .IdKardex = Convert.ToInt64(lblIdKardex2.Text)
                    .Estado = 1
                    .NroComprobante = lblComp.Text

                End With
                _sqlCommands.Add(_objDetalleKardex.ModificarDetalleKardexCommand())

                With _objKardex
                    .Id = lblIdKardex2.Text
                    .IdsecuencialItem = lblIdSecuencial.Text
                    .Cantidad = saldoTotal - (cant - CantidadEgreso)
                    .Fecha = dtpFecha.Value
                    .Estado = 1
                End With
                _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand)

            ElseIf CantidadEgreso = cant Then
                With _objDetalleKardex
                    .Id = lblDetKardex.Text
                    .IdActividad = 2
                    .IdConcepto = cmbConceptos.SelectedValue
                    .CantidadIngreso = 0.0
                    .ValorUnitarioIngreso = 0.0
                    .ValorTotalIngreso = 0.0
                    .CantidadEgreso = cant
                    .ValorUnitarioEgreso = val
                    .ValorTotalEgreso = toEgre
                    .CantidadSaldo = saldoTotal
                    .ValorUnitarioSaldo = val
                    .ValorTotalSaldo = saldoTotal * val
                    .Fecha = dtpFecha.Value
                    .IdKardex = Convert.ToInt64(lblIdKardex2.Text)
                    .Estado = 1
                    .NroComprobante = lblComp.Text

                End With
                _sqlCommands.Add(_objDetalleKardex.ModificarDetalleKardexCommand())

                With _objKardex
                    .Id = lblIdKardex2.Text
                    .IdsecuencialItem = lblIdSecuencial.Text
                    .Cantidad = saldoTotal
                    .Fecha = dtpFecha.Value
                    .Estado = 1
                End With
                _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand)
            End If





        End Sub

        Private Sub ModificarComprobanteEgresoAnular()
            If MessageBox.Show("DESEA ANULAR EL REGISTRO?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return


            _sqlCommands.Clear()

            With _objCompEgr
                .Id = lblComp.Text  'Id Comprobante 
            End With
            _sqlCommands.Add(_objCompEgr.AnularRegistroComprobanteEgresoBodegaCommand())

            Dim result As DataTable = _objControl.SeleccionarIdControlUniformes(_tipoCon, lblComp.Text, lblDetKardex.Text)


            If result.Rows.Count > 0 Then
                Dim idcon As Long = Convert.ToInt64(result.Rows(0)("ID_CONTROL"))

                With _objControl
                    .IdControl = idcon
                End With
                _sqlCommands.Add(_objControl.AnularControlCommand())

            End If

            With _objDetCompEgr
                .IdDetalle = lblDetaComp.Text
            End With
            _sqlCommands.Add(_objDetCompEgr.anularDetalleComprobanteEgresoBodegaCommand())

            With _objDetalleKardex
                .Id = lblDetKardex.Text
            End With
            _sqlCommands.Add(_objDetalleKardex.AnularRegistroDetalleKardexCommand())

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then
                tsmNuevo.Enabled = False
                tsmGuardar.Enabled = False
                tsmCancelar.Enabled = False
            End If

            Dim messageIcon As KryptonMessageBoxIcon
            If res(0) Then
                messageIcon = KryptonMessageBoxIcon.Information
            Else
                messageIcon = KryptonMessageBoxIcon.Exclamation
            End If

            KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
        End Sub

        Private Sub tsmActualizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmActualizar.Click


            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmCancelar.Enabled = True
            tsmEliminar.Enabled = False
            tsmReingreso.Enabled = False

            _botonSeleccionadoSitio = 2
            txtProveedores.Text = _objPer.BuscarApellidosNombresPersonalXIdPersonal(_tipoCon, _objPer.BuscarIdPersonalXIdUsuario(_tipoCon, IdUsuario))
            If txtNumero.Text.Trim().Length > 0 Then
                HabilitarIngresos(True)
                tsmAgregar.Enabled = True
            Else
                tsmEliminar.Enabled = False
                MsgBox("SELECCIONE UN REGISTRO A MODIFICAR", MsgBoxStyle.Information, "MENSAJE")
            End If

        End Sub

        Private Sub tmsEliminar_Click(sender As Object, e As EventArgs) Handles tmsEliminar.Click

            If dgvComprobantesEgreso.CurrentRow Is Nothing Then
                KryptonMessageBox.Show("No hay datos para anular!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return
            Else

                ModificarComprobanteEgresoAnular()
                dgvComprobantesEgreso.DataSource = Nothing
                dgvDetalleComprobate.DataSource = Nothing

                Return
            End If
        End Sub

        Private Sub txtRecibe_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRecibe.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                Dim idPer As String = txtRecibe.Text.Split("-")(1).Trim()
                txtCedulaRecibe.Text = _objPer.BuscarCedulaPersonalXIdPersonal(_tipoCon, idPer)
                UpdateUbicacion(idPer)

            Catch

                txtCedulaRecibe.Clear()
                txtUbicacion.Clear()
            End Try
        End Sub

        Private Sub UpdateUbicacion(idPer As String)
            Try
                'Dim idPer As String = ""
                'idPer = txtRecibe.Text.Split("-")(1).Trim()

                Dim sitio = _objSitioTrabajo.SeleccionarSitiosFullClientexIdPersonal2(_tipoCon, idPer)


                If sitio.Rows.Count = 0 Then

                    sitio = _objSitioTrabajo.SeleccionarSitiosClientexIdPersonal3(_tipoCon, idPer)
                    Dim par() As String = sitio.Rows(0).Item(0).ToString().Split("|"c)
                    txtUbicacion.Text = "CLIENTE: " & par(0) & vbCrLf & "PUESTO:" & par(1)
                    txtUbicacion.Tag = 1

                Else
                    Dim parts() As String = sitio.Rows(0).Item(0).ToString().Split("|"c)
                    If parts.Length = 3 Then
                        txtUbicacion.Tag = parts(0)
                        txtUbicacion.Text = "CLIENTE: " & parts(2) & vbCrLf & "PUESTO: " & parts(1)
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error al cargar la ubicación del personal: " & ex.Message, MsgBoxStyle.Information, "MENSAJE DE VALIDACIÒN")
                txtUbicacion.Clear()
            End Try
        End Sub

        Private Sub btnBusqueda_Click(sender As Object, e As EventArgs)
            ' CargarReingreso(txtBusqueda.Text)

        End Sub

        Private Sub CargarReingreso(ByVal filtro As String)
            Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"

            'dgvComprobantesEgreso.DataSource = _objCompEgr.SeleccionarComprobanteEgresoBodegaxRengoFechasReingreso(_tipoCon, fechaDesde, fechaHasta)

        End Sub

        Private Sub btnUniformes_Click(sender As Object, e As EventArgs) Handles btnUniformes.Click
            ConectarReporteComprobanteEgresoUniforme(txtIdComprobante.Text.Trim)
        End Sub

        Private Sub ConectarReporteComprobanteEgresoUniforme(ByVal idComprobante As String)
            Try
                If cmbBodega.SelectedValue = 1 Then
                    _crComprobanteUniforme.SetDataSource(_objCompEgr.SeleccionarComprobanteEgresoxIdComprobanteEgreso(_tipoCon, idComprobante))
                    _crComprobanteUniforme.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crComprobanteUniforme.SetParameterValue("ubicacion", _objCompEgr.BuscarClienteByIdComprobanteEgresoBodega(_tipoCon, idComprobante))
                    _crComprobanteUniforme.SetParameterValue("cisepro", ValidationForms.NombreCompany(_tipoCon))
                    crvComprobante.ReportSource = _crComprobanteUniforme
                    crvComprobante.Zoom(100)
                    crvComprobante.Refresh()
                Else
                    KryptonMessageBox.Show("EL COMPROBANTE NO CORRESPONDE A UNIFORMES", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return
                End If

            Catch
                crvComprobante.ReportSource = Nothing
            End Try
        End Sub

        Private Sub btnBuscarModi_Click(sender As Object, e As EventArgs) Handles btnBuscarModi.Click

            If txtFiltro.Text = "Buscar por Sitio o Nombre" Then
                txtFiltro.Text = ""

            End If
            CargarComprobantesEgreso(txtFiltro.Text)
            tsmNuevo.Enabled = False
            tsmActualizar.Enabled = True
            tmsEliminar.Enabled = True
            tsmCancelar.Enabled = True
            tsmReingreso.Enabled = True
        End Sub

        Private Sub txtFiltro_Enter(sender As Object, e As EventArgs) Handles txtFiltro.Enter

        End Sub

        Private Sub tsmReingreso_Click(sender As Object, e As EventArgs) Handles tsmReingreso.Click
            _botonSeleccionadoSitio = 3
            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmCancelar.Enabled = True
            tsmActualizar.Enabled = False
            tmsEliminar.Enabled = False

            AutoCompletarArticuloIngreso()

            lblArticuloTitulo.Visible = True
            lblArticuloTitulo.BringToFront()
            txtArticuloIngreso.Visible = True
            txtArticuloIngreso.BringToFront()
            lblSerieTitulo.Visible = True
            lblSerieTitulo.BringToFront()
            txtSerieIngreso.Visible = True
            txtSerieIngreso.BringToFront()
            btnBuscarReingreso.Visible = True
            btnBuscarReingreso.BringToFront()
            lblCantidadTitulo.Visible = True
            lblCantidadTitulo.BringToFront()
            nudCantidadIngreso.Visible = True
            nudCantidadIngreso.BringToFront()
            lblValorTitulo.Visible = True
            lblValorTitulo.BringToFront()
            nudValorIngreso.Visible = True
            nudValorIngreso.BringToFront()
            cbxCalidadIngreso.Visible = True
            cbxCalidadIngreso.BringToFront()
            lblTotalTitulo.Visible = True
            lblTotalTitulo.BringToFront()
            nudTotalIngreso.Visible = True
            nudTotalIngreso.BringToFront()
            lblObservacionesTitulo.Visible = True
            lblObservacionesTitulo.BringToFront()
            txtObservacionesIngreso.Visible = True
            txtObservacionesIngreso.BringToFront()
            btnAgregarIngreso.Visible = True
            btnAgregarIngreso.BringToFront()
            btnEliminaringreso.Visible = True
            btnEliminaringreso.BringToFront()
            dgvDetalleComprobanteIngreso.Visible = True
            dgvDetalleComprobanteIngreso.BringToFront()


        End Sub

        Public Sub ReingresoComprante()

        End Sub

        Private Sub btnAgregarIngreso_Click(sender As Object, e As EventArgs) Handles btnAgregarIngreso.Click
            If _detalleKardexIngreso Is Nothing Then
                KryptonMessageBox.Show("POR FAVOR, SELECCIONE UN ITEM PARA AGREGAR A LA LISTA!", "MENSAJE DE VALIDACIÒN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If

            If _detalleKardexIngreso.Rows.Count = 0 Then
                KryptonMessageBox.Show("POR FAVOR, SELECCIONE UN ITEM PARA AGREGAR A LA LISTA!", "MENSAJE DE VALIDACIÒN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If

            If cbxCalidadIngreso.SelectedIndex = 0 Then
                KryptonMessageBox.Show("POR FAVOR, SELECCIONE LA OBSERVACIÓN DE CALIDAD PARA ESTE ITEM", "MENSAJE DE VALIDACIÒN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If

            Dim cant = CInt(nudCantidadIngreso.Value)
            Dim val = CDbl(nudValorIngreso.Value)
            lbldetalleIngreso.Text = txtSerieIngreso.Text
            If Not ValidarKardexRepetidos(CLng(lblIdKardexIngreso.Text), lbldetalleIngreso.Text) Then

                Dim fila As String() =
                    {
                        lblIdKardexIngreso.Text,
                        txtArticuloIngreso.Text,
                        lblIdArticuloIngreso.Text,
                        cant,
                        val,
                        nudTotalIngreso.ToString(),
                        cbxCalidadIngreso.Text,
                        txtObservacionesIngreso.Text & " - SERIE: " & If(txtSerieIngreso.Text.Trim().Length = 0, "-", txtSerieIngreso.Text.Trim()),
                        _detalleKardex.Rows(0)(9).ToString(),'id detalle kardex
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(14).ToString()), CDbl(_detalleKardex.Rows(0)(17).ToString())),
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(15).ToString()), CDbl(_detalleKardex.Rows(0)(18).ToString())),
                        CDbl(_detalleKardex.Rows(0)(19).ToString()) - cant,
                        val,
                        (CDbl(_detalleKardex.Rows(0)(19).ToString()) - cant) * val,
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
                _detalleKardex = Nothing
                nudCantidad.Enabled = True
                txtSerie.Clear()
                tsmAgregar.Enabled = False
                tsmEliminar.Enabled = True
                Label11.Text = dgvSecuencial.Rows.Count & " REGISTRO(S) - TOTAL"
            Else
                MsgBox("NO SE PUEDE AGREGAR UN ITEM REPETIDO", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÒN")
            End If
        End Sub

        Private Sub CargarDetalleComprobanteIngreso(ByVal id As String)

            'Try
            '    dgvDetalleComprobanteIngreso.DataSource = _objCompEgr.SeleccionarDetallesComprobantesReingreso(_tipoCon, id)

            '    dgvDetalleComprobanteIngreso.Columns(0).Name = "ID_KAR"
            '    dgvDetalleComprobanteIngreso.Columns(1).Name = "NOMBRE_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(2).Name = "ID_SECUENCIAL_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(3).Name = "CANTIDAD_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(4).Name = "VALOR_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(5).Name = "TOTAL_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(6).Name = "OBSERVACION_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(7).Name = "DETALLE_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(8).Name = "VALOR_UNITARIO_ANTERIOR_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(9).Name = "VALOR_TOTAL_ANTERIOR_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(10).Name = "SALDO_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(11).Name = "FECHA_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(12).Name = "CODIGO_CONCEPTO_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(13).Name = "CANTIDAD_INICIAL_INGRESO"
            '    dgvDetalleComprobanteIngreso.Columns(14).Name = "CANTIDAD_TOTAL"



            '    dgvDetalleComprobanteIngreso.AutoResizeRows()
            '    dgvDetalleComprobanteIngreso.AutoResizeColumns()
            '    'dgvDetalleComprobate.ReadOnly = True



            'Catch
            '    dgvDetalleComprobanteIngreso.DataSource = Nothing
            'End Try
            Try
                dgvDetalleComprobanteIngreso.Rows.Clear()




                Dim dataTable As DataTable = _objCompEgr.SeleccionarDetallesComprobantesReingreso(_tipoCon, id)


                For Each row As DataRow In dataTable.Rows
                    Dim rowIndex As Integer = dgvDetalleComprobanteIngreso.Rows.Add()
                    Dim dgvRow As DataGridViewRow = dgvDetalleComprobanteIngreso.Rows(rowIndex)

                    dgvRow.Cells("ID_KAR").Value = row("ID_KAR")
                    dgvRow.Cells("NOMBRE_INGRESO").Value = row("NOMBRE_INGRESO")
                    dgvRow.Cells("ID_SECUENCIAL_INGRESO").Value = row("ID_SECUENCIAL_INGRESO")
                    dgvRow.Cells("CANTIDAD_INGRESO").Value = row("CANTIDAD_INGRESO")
                    dgvRow.Cells("VALOR_INGRESO").Value = row("VALOR_INGRESO")
                    dgvRow.Cells("TOTAL_INGRESO").Value = row("TOTAL_INGRESO")
                    dgvRow.Cells("OBSERVACION_INGRESO").Value = row("OBSERVACION_INGRESO")
                    dgvRow.Cells("DETALLES_INGRESO").Value = row("DETALLE_INGRESO")
                    dgvRow.Cells("VALOR_UNITARIO_ANTERIOR_INGRESO").Value = row("VALOR_UNITARIO_ANTERIOR_INGRESO")
                    dgvRow.Cells("VALOR_TOTAL_ANTERIOR_INGRESO").Value = row("VALOR_TOTAL_ANTERIOR_INGRESO")
                    dgvRow.Cells("SALDO_INGRESO").Value = row("SALDO_INGRESO")
                    dgvRow.Cells("FECHA_INGRESO").Value = row("FECHA_INGRESO")
                    dgvRow.Cells("CODIGO_CONCEPTO_INGRESO").Value = row("CODIGO_CONCEPTO_INGRESO")
                    dgvRow.Cells("CONCEPTO_INVENTARIO").Value = row("CONCEPTO_INVENTARIO")
                    dgvRow.Cells("CANTIDAD_INICIAL_INGRESO").Value = row("CANTIDAD_INICIAL_INGRESO")
                    dgvRow.Cells("CANTIDAD_TOTAL_INGRESO").Value = row("CANTIDAD_TOTAL")
                Next



                dgvDetalleComprobanteIngreso.AutoResizeColumns()
                dgvDetalleComprobanteIngreso.AutoResizeRows()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            dgvDetalleComprobanteIngreso.DataSource = Nothing
            End Try

        End Sub

        Private Sub dgvDetalleComprobanteIngreso_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleComprobanteIngreso.CellValueChanged
            'If dgvDetalleComprobanteIngreso.RowCount = 0 Or dgvDetalleComprobanteIngreso.CurrentRow Is Nothing Then Return
            'If dgvDetalleComprobanteIngreso.Columns(e.ColumnIndex).Name = "CANTIDAD_INGRESO" Or dgvDetalleComprobanteIngreso.Columns(e.ColumnIndex).Name = "VALOR_INGRESO" Then
            '    Dim cant = CInt(dgvDetalleComprobanteIngreso.CurrentRow.Cells.Item(3).Value)
            '    Dim val = CDbl(dgvDetalleComprobanteIngreso.CurrentRow.Cells.Item(4).Value)
            '    Dim toEgre = cant * val
            '    dgvDetalleComprobanteIngreso.CurrentRow.Cells.Item(5).Value = toEgre
            'End If
        End Sub

        Private Sub dgvDetalleComprobanteIngreso_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDetalleComprobanteIngreso.SelectionChanged
            'If dgvDetalleComprobate.Rows.Count = 0 Or dgvDetalleComprobate.CurrentRow Is Nothing Then Return


            'Dim serieResult As String = ""
            'Dim dataTable = _objCompEgr.SeleccionarSerieByIdDetalleComprobanteEgresoBodega(_tipoCon, CType(dgvDetalleComprobate.CurrentRow.Cells.Item(0).Value.ToString(), String), CType(dgvDetalleComprobate.CurrentRow.Cells.Item(1).Value.ToString(), String), CType(dgvDetalleComprobate.CurrentRow.Cells.Item(2).Value.ToString(), String))

            'If dataTable.Rows.Count > 0 AndAlso dataTable.Rows(0)("SERIE") IsNot DBNull.Value Then
            '    Dim serieInfo As String = dataTable.Rows(0)("SERIE").ToString()
            '    Dim index As Integer = serieInfo.IndexOf(":")

            '    If index <> -1 AndAlso index < serieInfo.Length - 1 Then
            '        serieResult = serieInfo.Substring(index + 1).Trim()
            '    End If
            'End If

            'txtSerieIngreso.Text = serieResult
            'nudCantidadIngreso.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(8).Value ' cantidad egreso
            'nudValorIngreso.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(9).Value ' valor egreso
            'nudTotalIngreso.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(10).Value
            'lblIdKardexIngreso.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(2).Value ' Id kardex
            'lblDetaComp.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(1).Value ' Id Detalle comprobante
            ''cmbObservacionCalidad.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(6).Value
            'txtArticulo.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(3).Value
            'txtObservacion.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(7).Value
            'lblDetKardex.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(5).Value ' Id detalle kardex
            'lblComp.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(0).Value 'ID de comprobante
            'lblIdSecuencial.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(16).Value ' Id Secuencial 
            'lblCantidadSaldo.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(17).Value ' cantidad_saldo 

        End Sub

        Private Sub txtArticuloIngreso_KeyUp(sender As Object, e As KeyEventArgs) Handles txtArticuloIngreso.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                lblIdArticuloIngreso.Text = _objSecuencialItem.BuscarIdSecuencialItemXNombreSecuencialItem(_tipoCon, txtArticuloIngreso.Text.Trim)
                lblIdKardexIngreso.Text = _objKardex.BuscarKardexPorIdSecuencialItem(_tipoCon, lblIdArticuloIngreso.Text.Trim)
                lblIdDetalleKardexIngreso.Text = _objDetalleKardex.BuscarMayorIdDetalleKardexxIdKardex(_tipoCon, lblIdKardexIngreso.Text)

                If CInt(lblIdKardexIngreso.Text) > 0 Then
                    _detalleKardexIngreso = _objKardex.BuscarUltimoMoviminetoKardexXIdKardex(_tipoCon, lblIdKardexIngreso.Text, lblIdDetalleKardexIngreso.Text)


                    ' nudCantidad.Value = 1
                    nudValorIngreso.Value = _objSecuencialItem.BuscarPvpSecuencialItemXIdSecuencialItem(_tipoCon, lblIdArticuloIngreso.Text)
                    cbxCalidadIngreso.SelectedIndex = 0
                    btnAgregarIngreso.Enabled = True
                Else
                    _detalleKardexIngreso = Nothing
                    nudValorIngreso.Value = 0
                    cbxCalidadIngreso.SelectedIndex = 0
                    nudCantidadIngreso.Value = 0
                    nudTotalIngreso.Value = 0
                    txtObservacionesIngreso.Clear()
                    lblIdArticuloIngreso.Text = 0
                    lblIdDetalleKardexIngreso.Text = 0
                    lblIdKardexIngreso.Text = 0
                    btnAgregarIngreso.Enabled = False
                    btnEliminaringreso.Enabled = dgvDetalleComprobanteIngreso.RowCount > 0
                    KryptonMessageBox.Show("EL ITEM SELECCIONADO NO EXISTE EN EL SISTEMA. DEBE CREAR EL ITEM EN LA OPCIÓN 'BODEGA / ARTÍCULOS Y PRODUCTOS' Y LUEGO REGISTAR EL 'COMPROBANTE DE INGRESO' CORRESPONDIENTE!!!", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
                CalcuarTotal()
            Catch
                nudValorIngreso.Value = 0
                lblIdArticuloIngreso.Text = 0
                lblIdKardexIngreso.Text = 0
                lblIdDetalleKardexIngreso.Text = 0
                _detalleKardexIngreso = Nothing
                txtArticuloIngreso.Clear()
                cbxCalidadIngreso.SelectedIndex = 0
                nudCantidadIngreso.Value = 0
                CalcuarTotal()
                txtObservacionesIngreso.Clear()
                KryptonMessageBox.Show("OCURRIÓ UN PROBLEMA AL SELECCIONAR ARTÍCULOS. POR FAVOR, CONTÁCTE AL ADMINISTRADOR!!!", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try

        End Sub

        Private Sub nudCantidadIngreso_ValueChanged(sender As Object, e As EventArgs) Handles nudCantidadIngreso.ValueChanged
            CalcularTotalIngreso()
        End Sub

        Private Sub nudValorIngreso_ValueChanged(sender As Object, e As EventArgs) Handles nudValorIngreso.ValueChanged
            CalcularTotalIngreso()
        End Sub
    End Class
End Namespace