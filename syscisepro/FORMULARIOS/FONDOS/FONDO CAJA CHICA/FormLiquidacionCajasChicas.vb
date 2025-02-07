Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.DATOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
Imports Krypton.Toolkit


Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormLiquidacionCajasChicas
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

        Dim _gasto As Decimal
        Dim _saldo As Decimal
        Dim _reposicion As Decimal
        Dim _fondo As Decimal

        ReadOnly _objCajasChicas As New ClassCajaChica
        ReadOnly _objProvincia As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objCentroCostos As New ClassCentroCosto
        ReadOnly _objParroquias As New ClassParroquias

        ReadOnly _crLiquidacionCajaChica As New crLiquidacionCajaChica
        ReadOnly _crLiquidacionCajaChicaNew As New crLiquidacionCajaChicaNew

        Dim _objAuditoria As New ClassAuditoriaGeneral
        Dim _objSolicitudCajaChica As New ClassSolicitudCajaChica
        Dim _objLiquidacionCajaChica As New ClassLiquidacionCajaChica
        Dim _objAuxiliarCajaChica As New ClassAuxiliarCajaChica

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoComprobantesRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion

        Dim _objetoDocumentoNoDeducible As New ClassDocumentoNoDeducible


        Private Sub LlenarComboCajasChicas()
            Try
                RemoveHandler cbmCajasChicas.SelectedValueChanged, AddressOf cbmCajasChicas_SelectedValueChanged

                cbmCajasChicas.DataSource = _objCajasChicas.SeleccionarCajasChicas(_tipoCon)
                cbmCajasChicas.DisplayMember = "DETALLE_CAJA_CHICA"
                cbmCajasChicas.ValueMember = "ID_CAJA_CHICA"
                cbmCajasChicas.DropDownWidth = 300
                If (CType(cbmCajasChicas.DataSource, DataTable).Rows.Count > 0) Then cbmCajasChicas.SelectedIndex = 0

                AddHandler cbmCajasChicas.SelectedValueChanged, AddressOf cbmCajasChicas_SelectedValueChanged
            Catch
                cbmCajasChicas.DataSource = Nothing
            End Try
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
        Private Sub LlenarComboCiudad()
            Try
                cbmCanton.DataSource = _objCiudad.BuscarNombreCiudadXIdProvincia(_tipoCon, cbmProvincia.SelectedValue)
                cbmCanton.DisplayMember = "NOMBRE_CIUDADES"
                cbmCanton.ValueMember = "ID_CIUDAD"
                cbmCanton.DropDownWidth = 300
                If (CType(cbmCanton.DataSource, DataTable).Rows.Count > 0) Then cbmCanton.SelectedIndex = 0
            Catch
                cbmCanton.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboParroquias()
            Try
                cbmParroquia.DataSource = _objParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, cbmCanton.SelectedValue)
                cbmParroquia.DisplayMember = "NOMBRE_PARROQUIAS"
                cbmParroquia.ValueMember = "ID_PARROQUIAS"
                cbmParroquia.DropDownWidth = 300
                If (CType(cbmParroquia.DataSource, DataTable).Rows.Count > 0) Then cbmParroquia.SelectedIndex = 0
            Catch
                cbmParroquia.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboCentroCostos()
            Try
                cbmCentroCosto.DataSource = _objCentroCostos.SeleccionarCentroCosto(_tipoCon)
                cbmCentroCosto.DisplayMember = "DETALLE_CENTRO_COSTO"
                cbmCentroCosto.ValueMember = "ID_CENTRO_COSTO"
                cbmCentroCosto.DropDownWidth = 300
                If (CType(cbmCentroCosto.DataSource, DataTable).Rows.Count > 0) Then cbmCentroCosto.SelectedIndex = 0
            Catch
                cbmCentroCosto.DataSource = Nothing
            End Try
        End Sub

        Private Sub FormLiquidacionCajasChicas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvLiquidacionFondoCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac()
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionFondoCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionFondoCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)
            _objAuditoria = New ClassAuditoriaGeneral
            _objSolicitudCajaChica = New ClassSolicitudCajaChica
            _objLiquidacionCajaChica = New ClassLiquidacionCajaChica

            LlenarComboProvincias()
            cbmCanton.SelectedValue = 58 ' MACHALA

            LlenarComboCentroCostos()
            LlenarComboCajasChicas()
            cbmCajasChicas.SelectedValue = 1
            cbmCajasChicas_SelectedIndexChanged(Nothing, Nothing)

        End Sub

        Private Sub cbmProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmProvincia.SelectedIndexChanged
            If cbmProvincia.SelectedValue Is Nothing Or TypeOf cbmProvincia.SelectedValue Is DataRowView Then Return
            LlenarComboCiudad()
        End Sub



        Private Sub cbmCajasChicas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs)
            If cbmCajasChicas.SelectedValue Is Nothing Or TypeOf cbmCajasChicas.SelectedValue Is DataRowView Then Return
            txtFondoCajaChica.Text = _objCajasChicas.BuscarMontoAsignadoCajaChicaXidCajaChica(_tipoCon, cbmCajasChicas.SelectedValue)
        End Sub

        Private Sub CargarSolicitudes()
            dgvLiquidacionFondoCajaChica.DataSource = _objSolicitudCajaChica.SeleccionarSolicitudesCajaChicaXIdCajaChica(_tipoCon, cbmCajasChicas.SelectedValue)
            dgvLiquidacionFondoCajaChica.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvLiquidacionFondoCajaChica.Columns(0).HeaderText = "N°"
            dgvLiquidacionFondoCajaChica.Columns(0).Width = 50
            dgvLiquidacionFondoCajaChica.Columns(1).HeaderText = "CONCEPTO"
            dgvLiquidacionFondoCajaChica.Columns(1).Width = 180
            dgvLiquidacionFondoCajaChica.Columns(2).HeaderText = "DETALLE"
            dgvLiquidacionFondoCajaChica.Columns(2).Width = 250
            dgvLiquidacionFondoCajaChica.Columns(3).HeaderText = "FECHA"
            dgvLiquidacionFondoCajaChica.Columns(3).Width = 120
            dgvLiquidacionFondoCajaChica.Columns(4).HeaderText = "VALOR"
            dgvLiquidacionFondoCajaChica.Columns(4).Width = 70
            dgvLiquidacionFondoCajaChica.Columns(5).HeaderText = "CÓDIGO"
            dgvLiquidacionFondoCajaChica.Columns(5).Width = 90
            dgvLiquidacionFondoCajaChica.Columns(6).HeaderText = "DOCUMENTO"
            dgvLiquidacionFondoCajaChica.Columns(6).Width = 90
            dgvLiquidacionFondoCajaChica.Columns(7).HeaderText = "N°"
            dgvLiquidacionFondoCajaChica.Columns(7).Width = 90
            dgvLiquidacionFondoCajaChica.Columns(8).HeaderText = "TIPO"
            dgvLiquidacionFondoCajaChica.Columns(8).Width = 90
            dgvLiquidacionFondoCajaChica.Columns(9).HeaderText = "AUTORIZA"
            dgvLiquidacionFondoCajaChica.Columns(9).Width = 180
            dgvLiquidacionFondoCajaChica.Columns(10).HeaderText = "PROVINCIA"
            dgvLiquidacionFondoCajaChica.Columns(11).HeaderText = "CANTÓN"
            dgvLiquidacionFondoCajaChica.Columns(12).HeaderText = "PARROQUIA"
            dgvLiquidacionFondoCajaChica.Columns(13).HeaderText = "CENTRO COSTO"
            dgvLiquidacionFondoCajaChica.Columns(13).Width = 180
            dgvLiquidacionFondoCajaChica.Columns(15).HeaderText = "CUENTA"
            dgvLiquidacionFondoCajaChica.Columns(17).HeaderText = "CLIENTE"
            dgvLiquidacionFondoCajaChica.Columns(17).Width = 200

            dgvLiquidacionFondoCajaChica.ReadOnly = True

        End Sub

        Private Sub SumaTotalLiquidacion()
            Dim indice As Decimal
            Dim acumulador As Decimal = 0
            Try
                For indice = 0 To dgvLiquidacionFondoCajaChica.RowCount - 1
                    acumulador += CDec(dgvLiquidacionFondoCajaChica.Rows(indice).Cells(4).Value)
                Next

                _fondo = CType(txtFondoCajaChica.Text, Decimal)
                _gasto = acumulador
                _saldo = _fondo - _gasto
                _reposicion = _gasto

                btnCargar.Enabled = False
                btnLiquidacionFondoCCH.Enabled = False
                btnGuardarSolicitudCCH.Enabled = True
                btnCancelar.Enabled = True
            Catch ex As Exception
                _fondo = 0
                _gasto = 0
                _saldo = 0
                _reposicion = 0
                'MessageBox.Show("Ocurrió un problema al realizar la sumatoria!", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                KryptonMessageBox.Show("Ocurrió un problema al realizar la sumatoria!" & vbNewLine & ex.Message.ToString(), "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
            txtFondoCajaChica.Text = _fondo
            txtGastosFondoCajaChica.Text = _gasto
            txtsaldoFondoCajaChica.Text = _saldo
            txtReposicionFondoCajaChica.Text = _reposicion
            txtTotalLiquidacion.Text = acumulador
        End Sub

        Private Function ValidarParametrosLiquidacion()
            Return (cbmCajasChicas.SelectedValue > 0 And
               cbmProvincia.SelectedValue > 0 And
               cbmCanton.SelectedValue > 0 And
               cbmParroquia.SelectedValue > 0 And
               txtTotalLiquidacion.Text > 0 And
               txtReposicionFondoCajaChica.Text <> 0 And
               txtGastosFondoCajaChica.Text > 0 And dgvLiquidacionFondoCajaChica.RowCount > 0)
        End Function

        Private Sub Auditoria(ByVal accion As String)
            _objAuditoria.IdAuditoria += 1
            _objAuditoria.AccionAuditoria = accion
            _sqlCommands.Add(_objAuditoria.RegistrarNuevoAuditoriaCommand())
        End Sub

        Private Sub EliminarSolicitudesCajaChica()
            For indice = 0 To dgvLiquidacionFondoCajaChica.RowCount - 1
                With _objSolicitudCajaChica
                    .IdSolitud = dgvLiquidacionFondoCajaChica.Rows(+indice).Cells(0).Value
                    .Estado = 2
                    .IdLiquidacion = _objLiquidacionCajaChica.Id
                End With
                _sqlCommands.Add(_objSolicitudCajaChica.EliminarSolicitudesCajaChicaCommand())
                Auditoria("LIQUIDACIÓN DE CAJA CHICA ID: " & _objLiquidacionCajaChica.Id & ", DETALLE DE LIQUIDACIÓN  " &
                        "ID SOL: " & _objSolicitudCajaChica.IdSolitud & ", N°: " & dgvLiquidacionFondoCajaChica.Rows(+indice).Cells(7).Value & ", FECHA: " & dgvLiquidacionFondoCajaChica.Rows(+indice).Cells(3).Value &
                        "VALOR: " & dgvLiquidacionFondoCajaChica.Rows(+indice).Cells(4).Value)
            Next
        End Sub

        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            CargarSolicitudes()
            SumaTotalLiquidacion()

            btnCargar.Enabled = True
            btnAnularSolicitud.Enabled = dgvLiquidacionFondoCajaChica.RowCount > 0 And Not dgvLiquidacionFondoCajaChica.CurrentRow Is Nothing
            btnLiquidacionFondoCCH.Enabled = dgvLiquidacionFondoCajaChica.RowCount > 0
            btnGuardarSolicitudCCH.Enabled = False
            btnCancelar.Enabled = False
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLiquidacionFondoCCH.Click
            SumaTotalLiquidacion()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSolicitudCCH.Click
            Try
                If CDbl(txtTotalLiquidacion.Text) > CDbl(txtFondoCajaChica.Text) Then
                    KryptonMessageBox.Show("NO SE PUEDE LIQUIDAR debido a que el total de los gastos supera al valor definido para FONDO DE CAJA CHICA!!!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                'If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LA LIQUIDACIÓN '" & cbmCajasChicas.Text & "' en la fecha " & dtpFechaLiquidacion.Value.ToLongDateString() & "?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                If KryptonMessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LA LIQUIDACIÓN '" & cbmCajasChicas.Text & "' en la fecha " & dtpFechaLiquidacion.Value.ToLongDateString() & "?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

                If ValidarParametrosLiquidacion() Then

                    _sqlCommands.Clear()

                    _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                    _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                    _objAuditoria.FormularioAuditoria = Text.Trim
                    _objAuditoria.EstadoAuditoria = 1
                    _objAuditoria.IdUsuarioAuditoria = IdUsuario

                    With _objLiquidacionCajaChica
                        .Id = .BuscarMayorIdLiquidacion(_tipoCon) + 1
                        .Fecha = dtpFechaLiquidacion.Value
                        .Total = CDec(txtTotalLiquidacion.Text)
                        .Fondo = CDec(txtFondoCajaChica.Text)
                        .Saldo = CDec(txtsaldoFondoCajaChica.Text)
                        .Gastos = CDec(txtGastosFondoCajaChica.Text)
                        .Reposicion = CDec(txtReposicionFondoCajaChica.Text)
                        .Estado = 1
                        .IdProvincias = cbmProvincia.SelectedValue
                        .IdCiudad = cbmCanton.SelectedValue
                        .IdParroquias = cbmParroquia.SelectedValue
                        .IdCaja = cbmCajasChicas.SelectedValue
                        .IdCentro = cbmCentroCosto.SelectedValue
                        .NroAsiento = 0
                    End With
                    _sqlCommands.Add(_objLiquidacionCajaChica.NuevaLiquidacionCommand())

                    Auditoria("LIQUIDACIÓN DE CAJA CHICA ID: " & _objLiquidacionCajaChica.Id & ", FECHA: " & _objLiquidacionCajaChica.Fecha &
                    "FONDO: " & _objLiquidacionCajaChica.Fondo & ", GASTO: " & _objLiquidacionCajaChica.Gastos & ", REPOSICIÓN: " & _objLiquidacionCajaChica.Reposicion &
                    "ID CAJA: " & _objLiquidacionCajaChica.IdCaja)

                    EliminarSolicitudesCajaChica()


                    Dim nombreU As String = "lIQUIDACION-CAJA-CHICA " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then

                        btnCargar.Enabled = True
                        btnLiquidacionFondoCCH.Enabled = False
                        btnGuardarSolicitudCCH.Enabled = False
                        btnCancelar.Enabled = False

                        txtIdLiquidacion.Text = _objLiquidacionCajaChica.Id
                        txtIdLiquidacionBusqueda.Text = txtIdLiquidacion.Text

                        tcLiquidar.SelectedIndex = 1
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Else
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

                    End If




                Else

                    KryptonMessageBox.Show("No se pudo gaurdar debido a que no ha llenado los parámetros necesarios o no hay registros que liquidar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception

                KryptonMessageBox.Show(ex.ToString, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End Try
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            dgvLiquidacionFondoCajaChica.DataSource = Nothing
            SumaTotalLiquidacion()
            btnCargar.Enabled = True
            btnLiquidacionFondoCCH.Enabled = False
            btnGuardarSolicitudCCH.Enabled = False
            btnCancelar.Enabled = False
        End Sub



        Private Sub tcLiquidar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs)
            If tcLiquidar.SelectedIndex = 1 Then txtIdLiquidacionBusqueda.Focus()
        End Sub

        Private Sub dgvLiquidacionFondoCajaChica_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            btnAnularSolicitud.Enabled = dgvLiquidacionFondoCajaChica.RowCount > 0 And Not dgvLiquidacionFondoCajaChica.CurrentRow Is Nothing
        End Sub

        Private Sub btnAnularSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularSolicitud.Click
            'If MessageBox.Show("¿ESTA SEGURA QUE DESEA ANULAR EL DOCUMENTO: '" & dgvLiquidacionFondoCajaChica.CurrentRow.Cells(6).Value & "' N° " & dgvLiquidacionFondoCajaChica.CurrentRow.Cells(7).Value & "?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            If KryptonMessageBox.Show("¿Esta segura que desea anular el documento: '" & dgvLiquidacionFondoCajaChica.CurrentRow.Cells(6).Value & "' N° " & dgvLiquidacionFondoCajaChica.CurrentRow.Cells(7).Value & "?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                _sqlCommands.Clear()

                ' anular solicitud
                With _objSolicitudCajaChica
                    .IdSolitud = dgvLiquidacionFondoCajaChica.CurrentRow.Cells(0).Value
                End With
                _sqlCommands.Add(_objSolicitudCajaChica.EliminarUnaSolicitudesCajaChicaCommand())

                ' anular comprobante
                If dgvLiquidacionFondoCajaChica.CurrentRow.Cells(8).Value.ToString.Equals("DEDUCIBLE") Then
                    _objetoComprobantesCompra.IdComprobante = CInt(dgvLiquidacionFondoCajaChica.CurrentRow.Cells(15).Value)
                    _objetoComprobantesCompra.EstadoComprobante = 0
                    _sqlCommands.Add(_objetoComprobantesCompra.ActualizarEstadoComprobanteCompras)

                    _objetoComprobantesRetencion.IdComprobanteCompra = CInt(dgvLiquidacionFondoCajaChica.CurrentRow.Cells(15).Value)
                    _objetoComprobantesRetencion.EstadoComprobanteRetencion = 0
                    _sqlCommands.Add(_objetoComprobantesRetencion.ActualizarEstadoComprobanteRetencionCompraByIdComprobanteCompra)

                    _objetoDetalleComprobantesRetencion.IdComprobanteCompra = CInt(dgvLiquidacionFondoCajaChica.CurrentRow.Cells(15).Value)
                    _objetoDetalleComprobantesRetencion.EstadoDetalleComprobanteRetencion = 0
                    _sqlCommands.Add((_objetoDetalleComprobantesRetencion.ActualizarEstadoDetalleComprobanteRetencionCompraByIdComprobanteCompra))
                Else
                    _objetoDocumentoNoDeducible.IdDocumentoNo = CInt(dgvLiquidacionFondoCajaChica.CurrentRow.Cells(15).Value)
                    _objetoDocumentoNoDeducible.EstadoDocumentoNo = 0
                    _sqlCommands.Add(_objetoDocumentoNoDeducible.ActualizarEstadoDetalleDocumentoByIdDocumento)
                End If

                ' AJUSTAR CAJA
                _objAuxiliarCajaChica.IdCajaChica = CInt(dgvLiquidacionFondoCajaChica.CurrentRow.Cells(16).Value)
                _objAuxiliarCajaChica.MontoCajaChica = CDec(dgvLiquidacionFondoCajaChica.CurrentRow.Cells(4).Value)
                _sqlCommands.Add(_objAuxiliarCajaChica.ActualizarMontosCajaChica2Command)

                Dim nombreU As String = "LIQUIDACION-CAJA-CHICA-ANULADA " & UserName
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    btnCargar_Click(Nothing, Nothing)
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

                End If




            Catch ex As Exception

                KryptonMessageBox.Show(ex.ToString, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End Try
        End Sub

        Private Sub crvLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvLiquidacion.Load

        End Sub

        Private Sub cbmCanton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmCanton.SelectedIndexChanged
            If cbmCanton.SelectedValue Is Nothing Or TypeOf cbmCanton.SelectedValue Is DataRowView Then Return
            LlenarComboParroquias()
        End Sub

        Private Sub bntCargar_Click(sender As Object, e As EventArgs) Handles bntCargar.Click
            Try
                '_crLiquidacionCajaChica.SetDataSource(_objLiquidacionCajaChica.BuscarSolicitudesFondoCajaChicaPorIdLiquidacion(_tipoCon, txtIdLiquidacionBusqueda.Text))
                '_crLiquidacionCajaChica.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                _crLiquidacionCajaChicaNew.SetDataSource(_objLiquidacionCajaChica.BuscarSolicitudesFondoCajaChicaPorIdLiquidacion(_tipoCon, txtIdLiquidacionBusqueda.Text))
                _crLiquidacionCajaChicaNew.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvLiquidacion.ReportSource = _crLiquidacionCajaChicaNew
                crvLiquidacion.Zoom(2)
                crvLiquidacion.Refresh()
            Catch ex As Exception
                crvLiquidacion.ReportSource = Nothing
            End Try
        End Sub

        Private Sub cbmCajasChicas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbmCajasChicas.SelectedValueChanged
            Dim selectedValue As Integer = cbmCajasChicas.SelectedValue


            Select Case selectedValue
                Case "1" 'caja chica machala
                    cbmProvincia.SelectedValue = 7
                    cbmCanton.SelectedValue = 58
                    cbmParroquia.SelectedValue = 287

                Case "6" 'caja chica guayaquil
                    cbmProvincia.SelectedValue = 10
                    cbmCanton.SelectedValue = 84
                    cbmParroquia.SelectedValue = 418

                Case "15" 'caja chica lago agrio
                    cbmProvincia.SelectedValue = 22
                    cbmCanton.SelectedValue = 196

                Case "16" 'caja chica lago agrio 2
                    cbmProvincia.SelectedValue = 22
                    cbmCanton.SelectedValue = 196


                Case "11" 'caja chica cuenca
                    cbmProvincia.SelectedValue = 1
                    cbmCanton.SelectedValue = 1
                    cbmParroquia.SelectedValue = 921

                Case "14" ' caja chica quito
                    cbmProvincia.SelectedValue = 19
                    cbmCanton.SelectedValue = 185
                    cbmParroquia.SelectedValue = 736

                Case "10" ' caja chica naranjal
                    cbmProvincia.SelectedValue = 10
                    cbmCanton.SelectedValue = 87


                Case "9" ' caja chica minas
                    cbmProvincia.SelectedValue = 1


                Case "17" ' caja chica loja
                    cbmProvincia.SelectedValue = 12
                    cbmCanton.SelectedValue = 109
                    cbmParroquia.SelectedValue = 490

                Case "8" ' caja chica zamora
                    cbmProvincia.SelectedValue = 24
                    cbmCanton.SelectedValue = 218
                    cbmParroquia.SelectedValue = 917

                Case "2" ' caja chica zaruma
                    cbmProvincia.SelectedValue = 7
                    cbmCanton.SelectedValue = 64
                    cbmParroquia.SelectedValue = 327

            End Select
        End Sub
    End Class
End Namespace