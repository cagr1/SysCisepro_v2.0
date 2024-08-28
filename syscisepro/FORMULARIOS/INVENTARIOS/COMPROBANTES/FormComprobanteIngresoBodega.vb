Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
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
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports Krypton.Toolkit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormComprobanteIngresoBodega

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
        ReadOnly _objControl As New ClassControlUniformes
        ReadOnly _objSerie As New ClassGenerarSerie
        ReadOnly _objBodega As New ClassBodega
        ReadOnly _objDoc As New ClassParametroDocumentos
        ReadOnly _objCon As New ClassConceptosInventarios
        ReadOnly _objPer As New ClassPersonal
        ReadOnly _objProv As New ClassProveedores
        ReadOnly _objCli As New ClassClienteGeneral
        ReadOnly _objProvincia As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _objCentroCostos As New ClassCentroCosto
        ReadOnly _objCompIng As New ClassComprobanteIngresoBodego
        ReadOnly _objDetCompIng As New ClassDetalleComprobanteIngreso
        'ReadOnly _crComprobanteIngreso As New crComprobanteIngreso
        ReadOnly _crComprobanteIngreso As New crComprobanteIngresoMin
        ReadOnly _objSecuencialItem As New ClassSecuencialItem
        ReadOnly _objKardex As New ClassKardex
        ReadOnly _objDetalleKardex As New ClassDetalleKardex
        ReadOnly _objSitioTrabajo As New ClassSitiosTrabajo
        Dim _detalleKardex As New System.Data.DataTable
        ReadOnly _objFoto As New ClassFoto

        ReadOnly _objDetalleEgresoPuesto As New ClassDetalleBodegaSitio

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

        Private Sub AutocompletarClientes()
            txtUbicacion.AutoCompleteCustomSource = _objCli.Autocompletar(_tipoCon)
            txtUbicacion.AutoCompleteMode = AutoCompleteMode.Suggest
            txtUbicacion.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub
        Private Sub FormComprobanteIngresoBodega_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label14.ForeColor = Color.White
                    'Label14.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    'Label14.ForeColor = Color.White
                    'Label14.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    'Label14.ForeColor = Color.White
                    'Label14.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvSecuencial.Font = New System.Drawing.Font("Roboto", 8, FontStyle.Regular)
            dgvComprobantesIngreso.Font = New System.Drawing.Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobate.Font = New System.Drawing.Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            Dim validation As New ValidationForms()
            validation.SetPlaceholder(txtFiltro, "Buscar por Sitio o Nombre")
            Label14.Text = "0  REGISTRO(S) - TOTAL"
            'pbFoto.TabStop = False
        End Sub
        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmNuevo.Click
            Limpiar()
            AutocompletarRecibe()
            AutocompletarProveedores()
            AutocompletarClientes()
            AutocompletarArticulo()

            CargarBodegas()
            LlenarConceptos(1) ' INGRESO

            LlenarComboProvincias()
            cbmCanton.SelectedValue = 58 ' MACHALA

            LlenarCentroCosto()
            cbmIngreso.SelectedIndex = 0

            HabilitarIngresos(True)

            _botonSeleccionadoSitio = 1
            CargarDocumentos()
            cmbDocumento.SelectedValue = 8 ' SIN DOCUMENTO

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmCancelar.Enabled = True
            TmsActualizar.Enabled = False
            TmsEliminar.Enabled = False
            Limpiar()

            txtRecibe.Focus()
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
            chkReq.Enabled = cmbBodegaV
            pbFoto.Enabled = cmbBodegaV
        End Sub
        Private Sub Limpiar()
            lblOrdenCompra.Text = "###"
            chkReq.Checked = False

            txtNroComprobante.Clear()
            txtNombre.Tag = Nothing
            txtNombre.Clear()
            txtCedula.Clear()
            txtNroComprobante.Text = "S/N"

            txtNroDocumento.Tag = Nothing
            txtNroDocumento.Text = "S/N"

            txtRecibe.Tag = Nothing
            txtRecibe.Clear()
            txtUbicacion.Clear()
            txtRazon.Clear()
            txtSerie.Clear()

            pbFoto.Image = Nothing

            txtArticulo.Clear()
            txtCodigoArticulo.Clear()
            cmbObservacionCalidad.SelectedIndex = 0
            nudCantidad.Value = 0
            nudValor.Value = 0
            txtObservacion.Clear()
            lblIdArticulo.Text = 0
            lblIdDetalleKardex.Text = 0
            lblIdKardex.Text = 0
            lblDetalle.Text = 0
            _detalleKardex = Nothing
            dgvSecuencial.Rows.Clear()
            dgvComprobantesIngreso.DataSource = Nothing
            dgvComprobantesIngreso.Rows.Clear()
            dgvDetalleComprobate.DataSource = Nothing
            dgvDetalleComprobate.Rows.Clear()
            Label14.Text = "0  REGISTRO(S) - TOTAL"
        End Sub

        Private Sub CargarBodegas()
            Try
                cmbBodega.DataSource = _objBodega.SeleccionarBodegasActivas(_tipoCon)
                cmbBodega.ValueMember = "CÓDIGO"
                cmbBodega.DisplayMember = "BODEGA"
                cmbBodega.DropDownWidth = 400
                If (CType(cmbBodega.DataSource, System.Data.DataTable).Rows.Count > 0) Then cmbBodega.SelectedIndex = 0
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
                cmbConceptos.ValueMember = "ID"
                cmbConceptos.DisplayMember = "DETALLE"
                If (CType(cmbConceptos.DataSource, System.Data.DataTable).Rows.Count > 0) Then cmbConceptos.SelectedIndex = 0
            Catch
                cmbConceptos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbConceptos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbConceptos.SelectedValueChanged
            If cmbConceptos.SelectedValue Is Nothing Or TypeOf cmbConceptos.SelectedValue Is DataRowView Then Return
            txtCodigo.Text = _objCon.BuscarCodigoxIdConcepto(_tipoCon, cmbConceptos.SelectedValue)
        End Sub

        Private Sub LlenarComboProvincias()
            Try
                cbmProvincia.DataSource = _objProvincia.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cbmProvincia.DisplayMember = "NOMBRE_PROVINCIAS"
                cbmProvincia.ValueMember = "ID_PROVINCIAS"
                cbmProvincia.DropDownWidth = 300
                If (CType(cbmProvincia.DataSource, System.Data.DataTable).Rows.Count > 0) Then cbmProvincia.SelectedValue = 7
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
                If (CType(cbmCanton.DataSource, System.Data.DataTable).Rows.Count > 0) Then cbmCanton.SelectedIndex = 0
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
                If (CType(cbmParroquia.DataSource, System.Data.DataTable).Rows.Count > 0) Then cbmParroquia.SelectedIndex = 0
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
                If (CType(cmbDocumento.DataSource, System.Data.DataTable).Rows.Count > 0) Then cmbDocumento.SelectedIndex = 0
            Catch
                cmbDocumento.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbDocumento_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbDocumento.SelectedValueChanged
            If cmbDocumento.SelectedValue Is Nothing Or TypeOf cmbDocumento.SelectedValue Is DataRowView Then Return
            txtNroDocumento.Text = "S/N"
            txtNroDocumento.Enabled = cmbDocumento.Text.Equals("FACTURA")
        End Sub

        Private Sub LlenarCentroCosto()
            Try
                Dim data = _objCentroCostos.SeleccionarCentroCosto(_tipoCon)
                cbmCentroCosto.DataSource = data
                cbmCentroCosto.DisplayMember = "DETALLE_CENTRO_COSTO"
                cbmCentroCosto.ValueMember = "ID_CENTRO_COSTO"
                cbmCentroCosto.DropDownWidth = 300
                If (CType(cbmCentroCosto.DataSource, System.Data.DataTable).Rows.Count > 0) Then cbmCentroCosto.SelectedIndex = 0
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
                    'nudCantidad.Value = 1
                    nudValor.Value = _objSecuencialItem.BuscarPvpSecuencialItemXIdSecuencialItem(_tipoCon, lblIdArticulo.Text)
                    cmbObservacionCalidad.SelectedIndex = 0
                    tsmAgregar.Enabled = True

                    ' verificar activo fijo

                Else
                    _detalleKardex = Nothing
                    txtCodigoArticulo.Clear()
                    cmbObservacionCalidad.SelectedIndex = 0
                    nudCantidad.Value = 0
                    nudValor.Value = 0
                    txtObservacion.Clear()
                    lblIdArticulo.Text = 0
                    lblIdDetalleKardex.Text = 0
                    lblIdKardex.Text = 0
                    tsmAgregar.Enabled = False
                    tsmEliminar.Enabled = dgvSecuencial.RowCount > 0
                    MsgBox("EL ITEM SELECCIONADO NO EXISTE EN EL SISTEMA. DEBE CREAR EL ITEM EN LA OPCIÓN 'BODEGA / ARTÍCULOS Y PRODUCTOS' Y LUEGO REGISTAR EL 'COMPROBANTE DE INGRESO' CORRESPONDIENTE!!!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
            Catch
                lblIdArticulo.Text = 0
                lblIdKardex.Text = 0
                lblIdDetalleKardex.Text = 0
                _detalleKardex = Nothing
                txtArticulo.Clear()
                txtCodigoArticulo.Clear()
                cmbObservacionCalidad.SelectedIndex = 0
                nudCantidad.Value = 0
                nudValor.Value = 0
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
            lblDetalle.Text = txtSerie.Text
            Dim cant = CInt(nudCantidad.Value)
            Dim val = CDbl(nudValor.Value)
            If Not ValidarKardexRepetidos(CLng(lblIdKardex.Text), lblDetalle.Text) Then

                Dim fila As String() =
                    {
                        txtCodigoArticulo.Text, 'CODIGO / 0
                        txtArticulo.Text, 'NOMBRE / 1
                        cant,' CANTIDAD / 2
                        val,'VALOR / 3
                        cant * val,'TOTAL / 4
                        cmbObservacionCalidad.Text,'OBSERVACION / 5
                        txtObservacion.Text & " - SERIE: " & If(txtSerie.Text.Trim().Length = 0, "-", txtSerie.Text.Trim()),'DETALLES / 6
                        _detalleKardex.Rows(0)(0).ToString(),'ID_KARDEX / NUMERO_KARDEX / 7
                        _detalleKardex.Rows(0)(9).ToString(),'ID_DETALLE_KARDEX / DETALLE_KARDEX / 8
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(14).ToString()), CDbl(_detalleKardex.Rows(0)(17).ToString())), 'VALOR_UNITARIO_ANTERIOR / 9
                        If(_detalleKardex.Rows(0)(12).ToString().Equals("INGRESO"), CDbl(_detalleKardex.Rows(0)(15).ToString()), CDbl(_detalleKardex.Rows(0)(18).ToString())), 'VALOR_TOTAL_ANTERIOR / 10
                        CDbl(_detalleKardex.Rows(0)(19).ToString()) + cant, 'SALDO / 11
                        val, 'CANTIDAD_SALDO / 12
                        (CDbl(_detalleKardex.Rows(0)(19).ToString()) + cant) * val,'VALOR_UNITARIO_SALDO / 13
                        _detalleKardex.Rows(0)(1).ToString()'ID_SECUENCIAL / 14
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

                Label14.Text = dgvSecuencial.Rows.Count & " REGISTRO(S) - TOTAL"
            Else
                MsgBox("NO SE PUEDE AGREGAR UN ITEM REPETIDO", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÒN")
            End If
        End Sub

        'Private Function ValidarKardexRepetidos(ByVal idKardex As Int64, ByVal idDetalle As String) As Boolean
        Private Function ValidarKardexRepetidosCompra(ByVal idKardex As Int64) As Boolean
            Dim contarRepetidos = 0
            'AndAlso dgvSecuencial.Rows.Item(indice).Cells("DETALLE_KARDEX").Value
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

        Private Function ValidarKardexRepetidos(ByVal idKardex As Int64, ByVal detalle As String) As Boolean
            Dim contarRepetidos = 0
            'AndAlso dgvSecuencial.Rows.Item(indice).Cells("DETALLE_KARDEX").Value


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
            CargarComprobantesEgreso(txtFiltro.Text)
            TmsActualizar.Enabled = True
            TmsEliminar.Enabled = True
            tsmCancelar.Enabled = True
        End Sub

        Private Sub CargarComprobantesEgreso(ByVal filtro As String)
            Try



                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"
                dgvComprobantesIngreso.DataSource = _objCompIng.SeleccionarComprobanteIngresoBodegaxRengoFechas(_tipoCon, fechaDesde, fechaHasta, filtro)

                'If chkTodos.Checked Then

                'Else
                '    If rbtNum.Checked Then
                '        dgvComprobantesIngreso.DataSource = _objCompIng.SeleccionarComprobanteIngresoBodegaxNroComprobante(_tipoCon, txtNroComprobanteBusqueda.Text.Trim)
                '    Else
                '        dgvComprobantesIngreso.DataSource = _objCompIng.SeleccionarComprobanteIngresoBodegaxDealle(_tipoCon, txtDetail.Text.Trim)
                '    End If
                'End If


                For Each row In dgvComprobantesIngreso.Rows
                    If row.Cells("SITIO DE TRABAJO").Value.ToString() = "SIN SITIO" Then
                        row.DefaultCellStyle.BackColor = Color.LightCoral
                        row.DefaultCellStyle.ForeColor = Color.DarkRed
                    End If
                Next

                dgvComprobantesIngreso.Columns(17).Visible = False
                dgvComprobantesIngreso.Columns(2).Visible = False
                dgvComprobantesIngreso.Columns(2).Visible = False
                dgvComprobantesIngreso.Columns(4).Visible = False
                dgvComprobantesIngreso.Columns(5).Visible = False
                dgvComprobantesIngreso.Columns(7).Visible = False
                dgvComprobantesIngreso.Columns(8).Visible = False
                dgvComprobantesIngreso.Columns(9).Visible = False
                dgvComprobantesIngreso.Columns(10).Visible = False
                dgvComprobantesIngreso.Columns(11).Visible = False

                dgvComprobantesIngreso.AutoResizeColumns()
                dgvComprobantesIngreso.AutoResizeRows()

                dgvComprobantesIngreso.ReadOnly = True

            Catch ex As Exception
                KryptonMessageBox.Show("OCURRIÓ UN PROBLEMA AL CARGAR LOS COMPROBANTES DE INGRESO. POR FAVOR, CONTÁCTE AL ADMINISTRADOR!!!", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                dgvComprobantesIngreso.DataSource = Nothing
                dgvDetalleComprobate.DataSource = Nothing
            End Try
        End Sub
        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmCancelar.Click
            HabilitarIngresos(False)

            Limpiar()

            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            tsmCancelar.Enabled = False
            TmsActualizar.Enabled = False
            TmsEliminar.Enabled = False
        End Sub
        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmGuardar.Click
            If chkReq.Checked And lblOrdenCompra.Text.Equals("###") Then
                MsgBox("DEBE ESPECIFICAR LA ORDEN DE COMPRA!")
                Return
            End If



            If KryptonMessageBox.Show("DESEA GUARDAR LOS CAMBIOS?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

            _sqlCommands.Clear()
            If _botonSeleccionadoSitio = 1 Then

                If dgvSecuencial.RowCount = 0 Then

                    KryptonMessageBox.Show("POR FAVOR, INGRESE LOS ITEMS DEL COMPROBANTES PARA GUARDAR", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If
                If cmbDocumento.SelectedValue <> 8 And txtNroDocumento.Text.Trim().Equals("S/N") Then

                    KryptonMessageBox.Show("POR FAVOR, INGRESE EL NUMERO DE FACTURA/DOCUMENTO PARA GUARDAR", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If CInt(txtUbicacion.Tag) = 0 Then

                    KryptonMessageBox.Show("POR FAVOR, SELECCIONE UN SITIO DE TRABAJO", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)

                    Return
                End If

                Dim msj = If(lblOrdenCompra.Text.Equals("###"), "", " CON ÓRDEN N° " & lblOrdenCompra.Text)

                If KryptonMessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR EL COMPROBANTE" & msj & "?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

                Dim cantidadPrendasLleva = 0
                Dim dt As DataTable = ConvertDataTable(dgvSecuencial)

                With _objCompIng
                    .Id = _objSerie.Serie(_objCompIng.BuscarMayorIdComprobanteIngresoBodega(_tipoCon) + 1)
                    .Fecha = dtpFecha.Value
                    .NroParametroDocumento = txtNroDocumento.Tag & " ~ " & txtNroDocumento.Text.Trim
                    .IdBodega = cmbBodega.SelectedValue.ToString
                    .IdActividad = 1
                    .IdConcepto = cmbConceptos.SelectedValue.ToString
                    .IdProvincias = cbmProvincia.SelectedValue.ToString
                    .IdCiudad = cbmCanton.SelectedValue.ToString
                    .IdParroquias = cbmParroquia.SelectedValue.ToString
                    .IdCentroCosto = cbmCentroCosto.SelectedValue.ToString
                    .IdParametroDocumento = cmbDocumento.SelectedValue.ToString
                    .Estado = 1
                    .Razon = txtRazon.Text.ToUpper
                    .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                    .IdEmpresa = 1
                    .Cliente = txtUbicacion.Text.ToUpper.Trim
                    .SitioTrabajo = CInt(txtUbicacion.Tag)
                    '.IdOrdenCompra = If(lblOrdenCompra.Text.Trim.Equals("###"), 0, CInt(lblOrdenCompra.Text))
                End With
                _sqlCommands.Add(_objCompIng.NuevoRegistroComprobanteIngresoBodegaCommand())


                If Not pbFoto.Image Is Nothing Then
                    With _objFoto
                        .IdFoto = .BuscarMayorIdFoto(_tipoCon) + 1
                        .Aux = "INGRESO BODEGA"
                        .Imagen = ValidationForms.ImageToBytes(pbFoto.Image)
                        .IdAux = _objCompIng.Id
                    End With
                    _sqlCommands.Add(_objFoto.NuevoRegistroFotoCommands())
                End If
                If _objCompIng.IdOrdenCompra <> 0 Then _sqlCommands.Add(_objCompIng.NuevoDetalleOrdenComprobanteIngresoCommand())
                Dim iddk = _objDetalleKardex.BuscarMayorIdDetalleKardex(_tipoCon) + 1
                Dim idce = _objDetCompIng.BuscarMayorIdDetalleComprobanteIngresoBodega(_tipoCon) + 1

                Dim idu = _objControl.BuscarMayorIdControlUniformes(_tipoCon) + 1

                Dim idd = _objDetalleEgresoPuesto.BuscarMayorIdRegistroDetalleComprobante(_tipoCon) + 1
                Dim dat As DataTable = ConvertDataTable(dgvSecuencial)
                For indice = 0 To dgvSecuencial.RowCount - 1
                    With _objDetalleKardex
                        .Id = iddk
                        .IdActividad = 1
                        .IdConcepto = cmbConceptos.SelectedValue
                        .CantidadEgreso = 0.0
                        .ValorUnitarioEgreso = 0.0
                        .ValorTotalEgreso = 0.0
                        .CantidadIngreso = CInt(dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD").Value.ToString.ToUpper)
                        .ValorUnitarioIngreso = CDec(dgvSecuencial.Rows.Item(indice).Cells("VALOR").Value.ToString.ToUpper)
                        .ValorTotalIngreso = CDec(dgvSecuencial.Rows.Item(indice).Cells("TOTAL").Value.ToString.ToUpper)
                        .CantidadSaldo = dgvSecuencial.Rows.Item(indice).Cells("SALDO").Value.ToString.ToUpper 'de CANTIDAD_SALDO a SALDO
                        .ValorUnitarioSaldo = CDec(dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD_SALDO").Value.ToString.ToUpper) 'de CANTIDAD_SALDO a  
                        .ValorTotalSaldo = CDec(dgvSecuencial.Rows.Item(indice).Cells("VALOR_UNITARIO_SALDO").Value.ToString.ToUpper) 'VALOR_UNITARIO_SALDO
                        .Fecha = _objCompIng.Fecha
                        .IdKardex = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value.ToString.ToUpper)
                        .Estado = 1
                        .NroComprobante = _objCompIng.Id
                        cantidadPrendasLleva = dgvSecuencial.Rows.Item(indice).Cells("CANTIDAD").Value
                    End With
                    _sqlCommands.Add(_objDetalleKardex.NuevoRegistroDetalleKardexCommand())
                    With _objDetCompIng
                        .IdDetalle = idce
                        .IdKardex = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value.ToString.ToUpper)
                        .IdDetalleKardex = _objDetalleKardex.Id
                        .ObservacionCalidadDetalle = dgvSecuencial.Rows.Item(indice).Cells("OBSERVACION").Value.ToString.ToUpper
                        .IdComprobante = _objCompIng.Id
                        .ObservacionDetalleSerial = dgvSecuencial.Rows.Item(indice).Cells("DETALLES").Value.ToString.ToUpper
                        .Estado = 1
                    End With
                    _sqlCommands.Add(_objDetCompIng.NuevoRegistroDetalleComprobanteIngresoBodegaCommand())

                    ' PUESTO   -   DETALLE
                    With _objDetalleEgresoPuesto
                        .Id = idd
                        .IdSitio = CInt(txtUbicacion.Tag)
                        .IdDetalle = idce
                        .Fecha = dtpFecha.Value
                        .Tipo = "INGRESO"
                        .Estado = 1
                        .Serie = dgvSecuencial.Rows.Item(indice).Tag.ToString
                    End With
                    _sqlCommands.Add(_objDetalleEgresoPuesto.NuevoRegistroDetalleComprobanteEgresoSitioCommand())
                    idd += 1
                    With _objKardex
                        .Id = CLng(dgvSecuencial.Rows.Item(indice).Cells("NUMERO_KARDEX").Value)
                        .IdsecuencialItem = CLng(dgvSecuencial.Rows.Item(indice).Cells("ID_SECUENCIAL").Value)
                        .Cantidad = CInt(dgvSecuencial.Rows.Item(indice).Cells("SALDO").Value) 'de CANTIDAD_SALDO a SALDO
                        .Fecha = _objCompIng.Fecha
                    End With
                    _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand())

                    With _objControl
                        .IdControl = idu
                        .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                        .IdComprobante = _objCompIng.Id
                        .Cantidad = cantidadPrendasLleva
                        .Fecha = _objCompIng.Fecha
                        .IdActividad = 1
                        .Estado = 1
                        .IdDetalleKardex = _objDetalleKardex.Id
                    End With
                    _sqlCommands.Add(_objControl.NuevoRegistroControlUniformesCommand())
                    iddk += 1
                    idce += 1
                    idu += 1
                Next
            ElseIf _botonSeleccionadoSitio = 2 Then
                ModicificarComprobanteIngreso()
            End If

            Dim nombreU As String = ""

            If _botonSeleccionadoSitio = 1 Then
                nombreU = "COMPROBANTE INGRESO " & UserName
            ElseIf _botonSeleccionadoSitio = 2 Then
                nombreU = "MODIFICACIÓN COMPROBANTE INGRESO " & UserName
            End If
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then
                    txtNroComprobante.Text = _objCompIng.Id
                    txtIdComprobante.Text = txtNroComprobante.Text
                    tbComprobanteIngresoBodega.SelectedIndex = 2
                    tsmNuevo.Enabled = True
                    tsmGuardar.Enabled = False
                    tsmCancelar.Enabled = False
                    TmsActualizar.Enabled = True
                End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                Dim messageIcon As KryptonMessageBoxIcon
                If res(0) Then
                    messageIcon = KryptonMessageBoxIcon.Information
                Else
                    messageIcon = KryptonMessageBoxIcon.Exclamation
                End If
                KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
        End Sub
        'Private Sub chkNumeroComprobante_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTodos.CheckedChanged
        '    If chkTodos.Checked Then
        '        txtNroComprobanteBusqueda.Enabled = False
        '        txtFiltro.Enabled = False
        '        rbtNum.Enabled = False
        '        rbtDet.Enabled = False
        '        rbtNum.Checked = False
        '        rbtDet.Checked = False
        '    Else
        '        txtNroComprobanteBusqueda.Enabled = True
        '        txtFiltro.Enabled = False
        '        rbtNum.Enabled = True
        '        rbtDet.Enabled = True
        '        rbtNum.Checked = True
        '        rbtDet.Checked = False
        '    End If
        '    txtNroComprobanteBusqueda.Clear()
        '    txtFiltro.Clear()
        'End Sub
        Private Sub btnExportarComprobantes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarComprobantes.Click
            ExportarDatosExcel(dgvComprobantesIngreso, "COMPROBANTES DE EGRESO DE BODEGA ")
        End Sub
        Private Sub btnExportarDetalleComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarDetalleComprobante.Click
            ExportarDatosExcel(dgvDetalleComprobate, "DETALLE DE COMPROABANTE DE EGRESO N°: " & CType(dgvComprobantesIngreso.CurrentRow.Cells.Item(0).Value, String))
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

            For i As Integer = 1 To dataGridViewExp.Columns.Count
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


            CargarBodegas()
            AutocompletarRecibe()
            AutocompletarProveedores()
            AutocompletarArticulo()

            LlenarConceptos(1) ' INGRESO
            LlenarComboProvincias()
            cbmCanton.SelectedValue = 58 ' MACHALA
            LlenarCentroCosto()
            cbmIngreso.SelectedIndex = 0
            CargarDocumentos()

            'cmbConcepto.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(4).Value

            txtNroComprobante.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(0).Value.ToString().Trim() 'Id_comprobante_ingreso
            txtIdComprobante.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(0).Value.ToString().Trim() 'Id_comprobante_ingreso
            cmbBodega.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(3).Value ' Id_bodega
            cbmProvincia.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(7).Value ' Id_provincia
            cbmCanton.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(8).Value ' Id_ciudad
            cbmParroquia.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(9).Value ' Id_parroquia
            cbmCentroCosto.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(10).Value ' Id_centro_costo

            dtpFecha.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(1).Value ' fecha_comprobante_ingreso



            txtRecibe.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(13).Value + " - " + dgvComprobantesIngreso.CurrentRow.Cells.Item(17).Value.ToString()
            txtCodigo.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(5).Value ' 
            cmbConceptos.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(6).Value
            txtProveedores.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(14).Value.ToString()
            UpdateUbicacion(dgvComprobantesIngreso.CurrentRow.Cells.Item(17).Value.ToString())


            txtRazon.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(12).Value
            cmbDocumento.Text = dgvComprobantesIngreso.CurrentRow.Cells.Item(16).Value ' id_parametro_documento


        End Sub

        Private Sub CargarDetalleComprobante(ByVal idcomprobante As String)
            Try
                dgvDetalleComprobate.DataSource = _objCompIng.SeleccionarDetallesComprobantesIngreso(_tipoCon, idcomprobante)

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
        Private Sub bntCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntCargar.Click
            ConectarReporteComprobanteIngreso(txtIdComprobante.Text.Trim)
            PictureBox1.Image = Nothing
            Try
                Dim r = _objFoto.BuscarRegistroFoto(_tipoCon, "INGRESO BODEGA", CInt(txtIdComprobante.Text.Trim))
                If r.Rows.Count = 0 Then Return
                PictureBox1.Image = ValidationForms.BytesToImage(CType(r.Rows(0)("FOTO"), Byte()))
            Catch
                PictureBox1.Image = Nothing
            End Try
        End Sub

        Private Sub ConectarReporteComprobanteIngreso(ByVal idComprobante As String)
            Try
                Dim ds = _objCompIng.SeleccionarComprobanteIngresoxIdComprobanteIngresoMin(_tipoCon, idComprobante)
                _crComprobanteIngreso.SetDataSource(ds)
                For Each table As DataTable In ds.Tables
                    For Each column As DataColumn In table.Columns
                        Debug.WriteLine("Table: " & table.TableName & " Column: " & column.ColumnName & " DataType: " & column.DataType.ToString())
                    Next
                Next
                '_crComprobanteIngreso.SetDataSource(ds.Tables("ComprobanteIngreso"))
                _crComprobanteIngreso.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                _crComprobanteIngreso.SetParameterValue("ubicacion", _objCompIng.BuscarClienteByIdComprobanteEgresoBodega(_tipoCon, idComprobante))
                crvComprobante.ReportSource = _crComprobanteIngreso
                crvComprobante.Zoom(100)
                crvComprobante.Refresh()
            Catch ex As Exception

                MsgBox("ERROR AL CARGAR EL REPORTE DE COMPROBANTE DE INGRESO " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACIÓN.")
                crvComprobante.ReportSource = Nothing
            End Try
        End Sub
        'Private Sub rbtNum_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbtNum.CheckedChanged
        '    If rbtNum.Checked Then
        '        txtDetail.Clear()
        '        txtNroComprobanteBusqueda.Clear()
        '        txtNroComprobanteBusqueda.Focus()
        '    End If
        '    txtNroComprobanteBusqueda.Enabled = rbtNum.Checked
        '    txtDetail.Enabled = rbtDet.Checked
        'End Sub
        'Private Sub rbtDet_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbtDet.CheckedChanged
        '    If rbtDet.Checked Then
        '        txtDetail.Clear()
        '        txtNroComprobanteBusqueda.Clear()
        '        txtDetail.Focus()
        '    End If
        '    txtNroComprobanteBusqueda.Enabled = rbtNum.Checked
        '    txtDetail.Enabled = rbtDet.Checked
        'End Sub

        Private Sub bntPuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntPuesto.Click
            Dim frm As New FrmBuscarPuestoTrabajo
            frm.TipoCox = TipoCox
            frm.Label3.Text = "TODOS LOS PUESTOS REGISTRADOS"
            frm.Text = "BUSCAR SITIOS DE TRABAJO"

            Try
                If frm.ShowDialog = vbOK Then
                    txtUbicacion.Tag = frm.ListView1.SelectedItems(0).SubItems(0).Text.Trim ' ids
                    txtUbicacion.Text = "CLIENTE: " & frm.ListView1.SelectedItems(0).Group.Header.Trim & vbNewLine &
                        "PUESTO: " & frm.ListView1.SelectedItems(0).SubItems(2).Text.Trim
                End If
            Catch
                txtUbicacion.Tag = Nothing
                txtUbicacion.Clear()
            End Try
        End Sub

        Private Sub btnSerie_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSerie.Click
            Dim frm As New FrmBuscarActivoFijo
            frm.TipoCox = TipoCox

            Try
                If frm.ShowDialog = vbOK Then

                    Dim s = frm.dgvActivosFijos.CurrentRow.Cells(6).Value.ToString().Split(".")
                    txtSerie.Text = s(s.Length - 1)

                    'nudCantidad.Value = 1
                    'nudCantidad.Enabled = False

                    'cmbObservacionCalidad.SelectedIndex = 2
                    txtObservacion.Text = "OK"
                End If
            Catch
                txtSerie.Text = "S/N"
                ' nudCantidad.Value = 1
                cmbObservacionCalidad.SelectedIndex = 2
            End Try
        End Sub

        Private Sub txtNroDocumento_DoubleClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNroDocumento.DoubleClick
            Dim frm As New FrmBuscarComprobanteIngresoEgreso
            frm.TipoCox = TipoCox
            frm.EsCompra = True
            frm.rbtIngreso.Visible = False
            frm.rbtEgreso.Visible = False
            frm.Label1.Text = "FILTRO"
            frm.txtParametrobusqueda.Width = 300
            frm.Text = "SELECCIONE FACTURA DE COMPRA CORRESPONDENTE"
            Try
                If frm.ShowDialog = vbOK Then
                    txtNroDocumento.Tag = frm.ListView2.SelectedItems(0).SubItems(0).Text
                    txtNroDocumento.Text = frm.ListView2.SelectedItems(0).SubItems(2).Text
                    txtRazon.Text += frm.ListView2.SelectedItems(0).SubItems(7).Text
                End If
            Catch ex As Exception
                txtNroDocumento.Tag = Nothing
                txtNroDocumento.Text = "S/N"
                txtRazon.Clear()
                MsgBox("ERROR AL CARGAR COMPROBANTE DE EGRESO " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACIÓN.")
            End Try
        End Sub

        Private Sub chkReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReq.CheckedChanged
            lblOrdenCompra.Text = "###"
            btnOrdenCompra.Enabled = chkReq.Checked
        End Sub

        Private Sub btnOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenCompra.Click
            Try
                Dim oc = New FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA.FormBuscarOrdenCompra()
                oc.TipoCox = _tipoCon
                oc.IdUsuario = IdUsuario
                oc.btnReporte.Visible = False
                oc.btnAceptar.Visible = True

                If oc.ShowDialog <> Windows.Forms.DialogResult.OK Then lblOrdenCompra.Text = "###"
                lblOrdenCompra.Text = oc.dgvOrdenCompra.CurrentRow.Cells(0).Value

                ' cargar items
                For Each row As DataGridViewRow In oc.dgvDetalleOrdenCompra.Rows
                    If Not ValidarKardexRepetidosCompra(CLng(row.Cells(9).Value)) Then
                        Dim dk = _objDetalleKardex.BuscarMayorIdDetalleKardexxIdKardex(_tipoCon, CLng(row.Cells(9).Value))
                        _detalleKardex = _objKardex.BuscarUltimoMoviminetoKardexXIdKardex(_tipoCon, CLng(row.Cells(9).Value), dk)

                        Dim cant = CInt(row.Cells(3).Value)
                        Dim val = CDbl(row.Cells(4).Value)

                        Dim fila As String() =
                            {
                            row.Cells(12).Value,
                            row.Cells(1).Value,
                            cant,
                            val,
                            cant * val,
                            "NUEVO",
                            "OK - SERIE: " & If(row.Cells(11).Value.ToString.Trim().Length = 0, "-", row.Cells(11).Value.ToString.Trim()),
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
                        dgvSecuencial.Rows(dgvSecuencial.RowCount - 1).Tag = If(row.Cells(11).Value.ToString.Trim().Length = 0, "-", row.Cells(11).Value.ToString.Trim())
                    End If
                Next

            Catch
                lblOrdenCompra.Text = "###"
                MsgBox("ERROR AL CARGAR ORDEN DE COMPRA!", MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACIÓN.")
            End Try
        End Sub

        Private Sub dgvSecuencial_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSecuencial.CellEndEdit
            If dgvSecuencial.CurrentRow Is Nothing Then Return
            'PVP
            If e.ColumnIndex = 3 Then
                Try
                    dgvSecuencial.CurrentRow.Cells(2).Value = CDec(dgvSecuencial.CurrentRow.Cells(2).Value)
                Catch
                    dgvSecuencial.CurrentRow.Cells(2).Value = "0.00"
                End Try
            End If

            'TOTAL
            Try
                dgvSecuencial.CurrentRow.Cells(4).Value = CInt(dgvSecuencial.CurrentRow.Cells(2).Value) * CDec(dgvSecuencial.CurrentRow.Cells(3).Value)
            Catch
                dgvSecuencial.CurrentRow.Cells(4).Value = "0.00"
                MsgBox("ERROR AL MODIFICAR DETALLES!", MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACIÓN.")
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

        Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        End Sub

        Private Sub ACTUALIZARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmsActualizar.Click

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmCancelar.Enabled = True
            TmsEliminar.Enabled = False
            _botonSeleccionadoSitio = 2
            'txtProveedores.Text = _objPer.BuscarApellidosNombresPersonalXIdPersonal(_tipoCon, _objPer.BuscarIdPersonalXIdUsuario(_tipoCon, IdUsuario))

            If txtNroComprobante.Text.Trim().Length > 0 Then
                HabilitarIngresos(True)
                tsmAgregar.Enabled = False
            Else

                MsgBox("SELECCIONE UN REGISTRO A MODIFICAR", MsgBoxStyle.Information, "MENSAJE")

            End If
        End Sub

        Private Sub dgvDetalleComprobate_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleComprobate.SelectionChanged
            If dgvDetalleComprobate.Rows.Count = 0 Or dgvDetalleComprobate.CurrentRow Is Nothing Then Return


            Dim serieResult As String = ""
            Dim dataTable = _objCompIng.SeleccionarSerieByIdDetalleComprobanteIngresoBodega(_tipoCon, CType(dgvDetalleComprobate.CurrentRow.Cells.Item(0).Value.ToString(), String), CType(dgvDetalleComprobate.CurrentRow.Cells.Item(1).Value.ToString(), String), CType(dgvDetalleComprobate.CurrentRow.Cells.Item(2).Value.ToString(), String))

            If dataTable.Rows.Count > 0 AndAlso dataTable.Rows(0)("SERIE") IsNot DBNull.Value Then
                Dim serieInfo As String = dataTable.Rows(0)("SERIE").ToString()
                Dim index As Integer = serieInfo.IndexOf(":")

                If index <> -1 AndAlso index < serieInfo.Length - 1 Then
                    serieResult = serieInfo.Substring(index + 1).Trim()
                End If
            End If

            txtSerie.Text = serieResult
            nudCantidad.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(8).Value ' cantidad ingreso
            nudValor.Value = dgvDetalleComprobate.CurrentRow.Cells.Item(9).Value ' valor ingreso
            lblIdKardex2.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(2).Value ' Id kardex
            lblDetaComp.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(1).Value ' Id Detalle comprobante
            cmbObservacionCalidad.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(6).Value
            txtArticulo.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(3).Value
            txtObservacion.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(7).Value
            lblDetaKardex.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(5).Value ' Id detalle kardex
            lblComp.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(0).Value 'ID de comprobante
            lblIdSecuencial.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(16).Value ' Id Secuencial 
            lblCantidadSaldo.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(17).Value ' cantidad_saldo 
            lblCantidadInicial.Text = dgvDetalleComprobate.CurrentRow.Cells.Item(4).Value ' cantidad inicial

        End Sub

        Private Sub ModicificarComprobanteIngreso()

            Try

                With _objCompIng
                    .Id = txtNroComprobante.Text  'Id Comprobante 
                    .Fecha = dtpFecha.Value
                    .NroParametroDocumento = txtNroDocumento.Text
                    .IdBodega = Convert.ToInt64(cmbBodega.SelectedValue)
                    .IdConcepto = cmbConceptos.SelectedValue
                    .IdProvincias = cbmProvincia.SelectedValue
                    .IdCiudad = cbmCanton.SelectedValue
                    .IdParroquias = cbmParroquia.SelectedValue
                    .IdCentroCosto = cbmCentroCosto.SelectedValue
                    .IdParametroDocumento = cmbDocumento.SelectedValue
                    .Razon = txtRazon.Text.ToUpper
                    .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                    .IdEmpresa = 1
                    .Cliente = txtUbicacion.Text.Trim
                    .SitioTrabajo = txtUbicacion.Tag.ToString()
                End With
                _sqlCommands.Add(_objCompIng.ModificarRegistroComprobanteIngresoBodegaCommand())
            Catch ex As Exception
                KryptonMessageBox.Show("ERROR AL MODIFICAR COMPROBANTE DE INGRESO DE BODEGA" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try

            Dim cant = CInt(nudCantidad.Value)
            Dim val = CDbl(nudValor.Value)
            Dim toIngre = cant * val
            Dim saldoTotal = Convert.ToInt32(lblCantidadSaldo.Text)
            Dim CantidadIngreso = Convert.ToInt32(dgvDetalleComprobate.CurrentRow.Cells.Item(8).Value)


            Dim result As DataTable = _objControl.SeleccionarIdControlUniformes(_tipoCon, txtNroComprobante.Text, lblDetaKardex.Text)


            If result.Rows.Count > 0 Then
                Try
                    Dim idcon As Long = Convert.ToInt64(result.Rows(0)("ID_CONTROL"))

                    With _objControl
                        .IdControl = idcon
                        .IdPersonal = If(txtRecibe.Tag Is Nothing, txtRecibe.Text.Split("-")(1).Trim(), CType(txtRecibe.Tag, Integer))
                        .IdComprobante = txtNroComprobante.Text
                        .Cantidad = cant
                        .Fecha = dtpFecha.Value
                        .IdActividad = 1
                        .IdDetalleKardex = Convert.ToInt64(lblDetaKardex.Text)
                    End With
                    _sqlCommands.Add(_objControl.ModificarControlCommand())
                Catch ex As Exception
                    KryptonMessageBox.Show("ERROR AL MODIFICAR CONTROL DE UNIFORMES" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try
            End If



            Try
                With _objDetCompIng
                    .IdDetalle = Convert.ToInt64(lblDetaComp.Text)
                    .IdKardex = Convert.ToInt64(lblIdKardex2.Text)
                    .IdDetalleKardex = Convert.ToInt64(lblDetaKardex.Text)
                    .ObservacionCalidadDetalle = cmbObservacionCalidad.Text.ToUpper
                    .ObservacionDetalleSerial = txtObservacion.Text.ToUpper & " - SERIE: " & If(txtSerie.Text.Trim().Length = 0, "-", txtSerie.Text.Trim())
                    .IdComprobante = txtNroComprobante.Text

                End With
                _sqlCommands.Add(_objDetCompIng.ModificarDetalleComprobanteIngresoBodegaCommand())

            Catch ex As Exception
                KryptonMessageBox.Show("ERROR AL MODIFICAR DETALLE DE COMPROBANTE DE INGRESO DE BODEGA" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try

            If CantidadIngreso > cant Then
                Try
                    With _objDetalleKardex
                        .Id = Convert.ToInt64(lblDetaKardex.Text)
                        .IdActividad = 1
                        .IdConcepto = cmbConceptos.SelectedValue
                        .CantidadIngreso = cant
                        .ValorUnitarioIngreso = val
                        .ValorTotalIngreso = toIngre
                        .CantidadEgreso = 0.0
                        .ValorUnitarioEgreso = 0.0
                        .ValorTotalEgreso = 0.0
                        .CantidadSaldo = saldoTotal - (CantidadIngreso - cant)
                        .ValorUnitarioSaldo = val
                        .ValorTotalSaldo = (saldoTotal - (CantidadIngreso - cant)) * val
                        .Fecha = dtpFecha.Value
                        .IdKardex = Convert.ToInt64(lblIdKardex2.Text)
                        .NroComprobante = txtNroComprobante.Text

                    End With
                    _sqlCommands.Add(_objDetalleKardex.ModificarDetalleKardexCommand())

                Catch ex As Exception
                    KryptonMessageBox.Show("ERROR AL MODIFICAR DETALLE DE KARDEX" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try

                Try
                    With _objKardex
                        .Id = Convert.ToInt64(lblIdKardex2.Text)
                        .IdsecuencialItem = Convert.ToInt64(lblIdSecuencial.Text)
                        .Cantidad = saldoTotal - (CantidadIngreso - cant)
                        .Fecha = dtpFecha.Value
                    End With
                    _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand)
                Catch ex As Exception
                    KryptonMessageBox.Show("ERROR AL MODIFICAR KARDEX" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try

            ElseIf CantidadIngreso < cant Then

                Try
                    With _objDetalleKardex
                        .Id = Convert.ToInt64(lblDetaKardex.Text)
                        .IdActividad = 1
                        .IdConcepto = cmbConceptos.SelectedValue
                        .CantidadIngreso = cant
                        .ValorUnitarioIngreso = val
                        .ValorTotalIngreso = toIngre
                        .CantidadEgreso = 0.0
                        .ValorUnitarioEgreso = 0.0
                        .ValorTotalEgreso = 0.0
                        .CantidadSaldo = saldoTotal + (cant - CantidadIngreso)
                        .ValorUnitarioSaldo = val
                        .ValorTotalSaldo = (saldoTotal + (cant - CantidadIngreso)) * cant
                        .Fecha = dtpFecha.Value
                        .IdKardex = Convert.ToInt64(lblIdKardex2.Text)
                        .NroComprobante = txtNroComprobante.Text

                    End With
                    _sqlCommands.Add(_objDetalleKardex.ModificarDetalleKardexCommand())

                Catch ex As Exception
                    KryptonMessageBox.Show("ERROR AL MODIFICAR DETALLE DE KARDEX" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try

                Try
                    With _objKardex
                        .Id = Convert.ToInt64(lblIdKardex2.Text)
                        .IdsecuencialItem = Convert.ToInt64(lblIdSecuencial.Text)
                        .Cantidad = saldoTotal + (cant - CantidadIngreso)
                        .Fecha = dtpFecha.Value
                    End With

                    _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand)
                Catch ex As Exception
                    KryptonMessageBox.Show("ERROR AL MODIFICAR KARDEX" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try

            ElseIf CantidadIngreso = cant Then

                Try
                    With _objDetalleKardex
                        .Id = Convert.ToInt64(lblDetaKardex.Text)
                        .IdActividad = 1
                        .IdConcepto = cmbConceptos.SelectedValue
                        .CantidadIngreso = cant
                        .ValorUnitarioIngreso = val
                        .ValorTotalIngreso = toIngre
                        .CantidadEgreso = 0.0
                        .ValorUnitarioEgreso = 0.0
                        .ValorTotalEgreso = 0.0
                        .CantidadSaldo = saldoTotal
                        .ValorUnitarioSaldo = val
                        .ValorTotalSaldo = saldoTotal * val
                        .Fecha = dtpFecha.Value
                        .IdKardex = Convert.ToInt64(lblIdKardex2.Text)
                        .Estado = 1
                        .NroComprobante = txtNroComprobante.Text

                    End With
                    _sqlCommands.Add(_objDetalleKardex.ModificarDetalleKardexCommand())

                Catch ex As Exception
                    KryptonMessageBox.Show("ERROR AL MODIFICAR DETALLE DE KARDEX" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try

                Try

                    With _objKardex
                        .Id = Convert.ToInt64(lblIdKardex2.Text)
                        .IdsecuencialItem = Convert.ToInt64(lblIdSecuencial.Text)
                        .Cantidad = saldoTotal
                        .Fecha = dtpFecha.Value
                        .Estado = 1
                    End With
                    _sqlCommands.Add(_objKardex.ModificarCantidadKardexCommand)
                Catch ex As Exception
                    KryptonMessageBox.Show("ERROR AL MODIFICAR KARDEX" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try

            End If

        End Sub

        Private Sub ModificarComprobanteIngresoAnular()

            If KryptonMessageBox.Show("DESEA ANULAR EL REGISTRO?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

            'Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
            'Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"
            _sqlCommands.Clear()
            Try
                With _objCompIng
                    .Id = txtNroComprobante.Text  'Id Comprobante 
                End With
                _sqlCommands.Add(_objCompIng.AnularRegistroComprobanteIngresoBodegaCommand())


                For Each row In dgvDetalleComprobate.Rows

                    Dim result As DataTable = _objControl.SeleccionarIdControlUniformes(_tipoCon, txtNroComprobante.Text, row.Cells.Item(1).Value)

                    If result.Rows.Count > 0 Then
                        Dim idcon As Long = Convert.ToInt64(result.Rows(0)("ID_CONTROL"))

                        With _objControl
                            .IdControl = idcon
                        End With
                        _sqlCommands.Add(_objControl.AnularControlCommand())

                    End If



                    With _objDetCompIng
                        .IdDetalle = row.Cells.Item(1).Value
                    End With
                    _sqlCommands.Add(_objDetCompIng.anularDetalleComprobanteIngresoBodegaCommand())


                    With _objDetalleKardex
                        .Id = row.Cells.Item(5).Value
                    End With
                    _sqlCommands.Add(_objDetalleKardex.AnularRegistroDetalleKardexCommand())


                Next
            Catch ex As Exception
                KryptonMessageBox.Show("ERROR AL ANULAR COMPROBANTE DE INGRESO DE BODEGA" & vbNewLine & ex.Message, "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try


            Dim nombreU As String = "ANULACIÓN COMPROBANTE INGRESO " & UserName
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)

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

        Private Sub TmsEliminar_Click(sender As Object, e As EventArgs) Handles TmsEliminar.Click



            If dgvComprobantesIngreso.CurrentRow Is Nothing Then
                KryptonMessageBox.Show("No hay datos para anular!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return
            Else

                ModificarComprobanteIngresoAnular()
                dgvComprobantesIngreso.DataSource = Nothing
                dgvDetalleComprobate.DataSource = Nothing

                Return
            End If
        End Sub

        Private Sub txtRecibe_KeyUp(sender As Object, e As KeyEventArgs)

        End Sub

        Private Sub txtRecibe_KeyUp_1(sender As Object, e As KeyEventArgs) Handles txtRecibe.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                Dim idPer As String = txtRecibe.Text.Split("-")(1).Trim()
                UpdateUbicacion(idPer)
                Dim sitio = _objSitioTrabajo.SeleccionarSitiosFullClientexIdPersonal2(_tipoCon, idPer)
            Catch

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

                    txtUbicacion.Text = "CLIENTE: " & sitio.Rows(0).Item(0).ToString() & vbCrLf & "PUESTO: " & sitio.Rows(0).Item(1).ToString()
                    txtUbicacion.Tag = sitio.Rows(0).Item(2).ToString()

                Else
                    Dim parts() As String = sitio.Rows(0).Item(0).ToString().Split("|"c)
                    If parts.Length = 3 Then
                        txtUbicacion.Tag = parts(0)
                        txtUbicacion.Text = "CLIENTE: " & parts(2) & vbCrLf & "PUESTO: " & parts(1)
                    End If
                End If
            Catch

                txtUbicacion.Clear()
            End Try
        End Sub

        Private Sub txtSerie_TextChanged(sender As Object, e As EventArgs) Handles txtSerie.TextChanged
            Dim idkardex = Convert.ToInt32(lblIdKardex.Text)

            If txtSerie.Text.Trim().Length > 0 Then
                Try
                    Dim data As DataTable = _objDetCompIng.BuscarSerieRepetida(_tipoCon, txtSerie.Text, idkardex)
                    If data IsNot Nothing AndAlso data.Rows.Count > 0 Then
                        Dim last As DataRow = data.Rows(data.Rows.Count - 1)
                        If Convert.ToInt32(last("ID_ACTIVIDAD")) = 1 Then
                            KryptonMessageBox.Show("LA SERIE YA FUE UTILIZADA EN UN INGRESO", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                            txtSerie.Clear()
                            Return
                        End If
                    End If
                Catch ex As Exception
                    KryptonMessageBox.Show("OCURRIÓ UN PROBLEMA AL BUSCAR LA SERIE. POR FAVOR, CONTÁCTE AL ADMINISTRADOR!!!", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)

                End Try
            End If

        End Sub

        Private Function ConvertDataTable(ByVal dgv As DataGridView) As DataTable
            Dim dt As New DataTable()
            For Each column As DataGridViewColumn In dgv.Columns
                dt.Columns.Add(column.Name)
            Next

            For Each row As DataGridViewRow In dgv.Rows
                Dim newRow As DataRow = dt.NewRow()
                For Each col As DataGridViewColumn In dgv.Columns
                    newRow(col.Name) = row.Cells(col.Name).Value
                Next
                dt.Rows.Add(newRow)

            Next
            Return dt
        End Function

        Private Sub btnBuscarModi_Click(sender As Object, e As EventArgs) Handles btnBuscarModi.Click
            If txtFiltro.Text = "Buscar por Sitio o Nombre" Then
                txtFiltro.Text = ""

            End If

            CargarComprobantesEgreso(txtFiltro.Text)
            TmsActualizar.Enabled = True
            TmsEliminar.Enabled = True
            tsmCancelar.Enabled = True
        End Sub

        Private Sub txtDetail_KeyUp(sender As Object, e As KeyEventArgs)
            CargarComprobantesEgreso(txtFiltro.Text)
        End Sub
    End Class
End Namespace