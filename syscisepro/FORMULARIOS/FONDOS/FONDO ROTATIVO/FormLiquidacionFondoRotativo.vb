Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.DATOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
Imports ClassLibraryCisepro.TALENTO_HUMANO

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormLiquidacionFondoRotativo

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

        ReadOnly _crLiquidacionFondoRotativo As New crLiquidacionFondoRotativo

        ReadOnly _objetoProvincias As New ClassProvincias
        ReadOnly _objetoCiudades As New ClassCiudades
        ReadOnly _objetoParroquias As New ClassParroquias
        ReadOnly _objetoCentroCosto As New ClassCentroCosto


        Dim _objAuditoria As ClassAuditoriaGeneral
        Dim _objetoLiquidacionFondoRotativo As ClassLiquidacionFondoRotativo
        Dim _objetoSolicitudFondoRotativo As ClassSolicitudFondoRotativo
        Dim _objetoFondoRotativo As ClassFondoRotativo
        Dim _objetoAuxiliarFondoRotativo As ClassAuxiliarFondoRotativo

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoComprobantesRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        Dim _objetoDocumentoNoDeducible As New ClassDocumentoNoDeducible

        Private Sub FormLiquidacionFondoRotativo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvLiquidacionFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvLiquidacionFondoRotativo.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            _objAuditoria = New ClassAuditoriaGeneral
            _objetoLiquidacionFondoRotativo = New ClassLiquidacionFondoRotativo
            _objetoSolicitudFondoRotativo = New ClassSolicitudFondoRotativo
            _objetoFondoRotativo = New ClassFondoRotativo
            _objetoAuxiliarFondoRotativo = New ClassAuxiliarFondoRotativo

            _objetoAnticipoPrestamo = New ClassAnticiposPrestamos 
            _objRegistroDescuento = New ClassDescuentosPersonal 
            _objetoHistorial = New ClassHistorialLaboral

            LlenarComboCentroCosto()
            LlenarComboProvincias()
            cmbCanton.SelectedValue = 58 ' MACHALA

            btnCargar.Enabled = True
            btnLiquidacionFondoRotativo.Enabled = False
            btnGuardarSolicitudFR.Enabled = False
            btnCancelarSolicitudFR.Enabled = False

        End Sub

        Private Sub LlenarComboCentroCosto()
            Try
                cmbCentroCosto.DataSource = _objetoCentroCosto.SeleccionarCentroCosto(_tipoCon)
                cmbCentroCosto.DisplayMember = "DETALLE_CENTRO_COSTO"
                cmbCentroCosto.ValueMember = "ID_CENTRO_COSTO"
                cmbCentroCosto.DropDownWidth = 300
                If (CType(cmbCentroCosto.DataSource, DataTable).Rows.Count > 0) Then cmbCentroCosto.SelectedIndex = 0
            Catch
                cmbCentroCosto.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboProvincias()
            Try
                cmbProvincia.DataSource = _objetoProvincias.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cmbProvincia.DisplayMember = "NOMBRE_PROVINCIAS"
                cmbProvincia.ValueMember = "ID_PROVINCIAS"
                If (CType(cmbProvincia.DataSource, DataTable).Rows.Count > 0) Then cmbProvincia.SelectedValue = 7
            Catch
                cmbProvincia.DataSource = Nothing
            End Try
        End Sub

        Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbProvincia.SelectedIndexChanged
            If cmbProvincia.SelectedValue Is Nothing Or TypeOf cmbProvincia.SelectedValue Is DataRowView Then Return
            LlenarComboCiudad()
        End Sub

        Private Sub LlenarComboCiudad()
            Try
                cmbCanton.DataSource = _objetoCiudades.BuscarNombreCiudadXIdProvincia(_tipoCon, CInt(cmbProvincia.SelectedValue))
                cmbCanton.DisplayMember = "NOMBRE_CIUDADES"
                cmbCanton.ValueMember = "ID_CIUDAD"
                cmbCanton.DropDownWidth = 300
                If (CType(cmbCanton.DataSource, DataTable).Rows.Count > 0) Then cmbCanton.SelectedIndex = 0
            Catch
                cmbCanton.DataSource = Nothing
            End Try
        End Sub

        Private Sub cmbCanton_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbCanton.SelectedIndexChanged
            If cmbCanton.SelectedValue Is Nothing Or TypeOf cmbCanton.SelectedValue Is DataRowView Then Return
            LlenarComboParroquias()
        End Sub

        Private Sub LlenarComboParroquias()
            Try
                cmbParroquia.DataSource = _objetoParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, CInt(cmbCanton.SelectedValue))
                cmbParroquia.DisplayMember = "NOMBRE_PARROQUIAS"
                cmbParroquia.ValueMember = "ID_PARROQUIAS"
                cmbParroquia.DropDownWidth = 300
                If (CType(cmbParroquia.DataSource, DataTable).Rows.Count > 0) Then cmbParroquia.SelectedIndex = 0
            Catch
                cmbParroquia.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarSolicitudFondoRotativo()
            Try
                Dim data = _objetoSolicitudFondoRotativo.SeleccionarRegistrosLiquidacionSolicitudfondoRotativo(_tipoCon)
                dgvLiquidacionFondoRotativo.DataSource = data
                dgvLiquidacionFondoRotativo.AutoResizeRows()
                dgvLiquidacionFondoRotativo.Columns(0).HeaderText = "ID"
                dgvLiquidacionFondoRotativo.Columns(0).Width = 40
                dgvLiquidacionFondoRotativo.Columns(1).HeaderText = "CONCEPTO"
                dgvLiquidacionFondoRotativo.Columns(1).Width = 225
                dgvLiquidacionFondoRotativo.Columns(2).HeaderText = "DETALLE"
                dgvLiquidacionFondoRotativo.Columns(2).Width = 320
                dgvLiquidacionFondoRotativo.Columns(3).HeaderText = "FECHA"
                dgvLiquidacionFondoRotativo.Columns(3).Width = 120
                dgvLiquidacionFondoRotativo.Columns(4).HeaderText = "TIPO DOC"
                dgvLiquidacionFondoRotativo.Columns(4).Width = 90
                dgvLiquidacionFondoRotativo.Columns(5).HeaderText = "APELLIDO AUTORIZADOR"
                dgvLiquidacionFondoRotativo.Columns(5).Width = 160
                dgvLiquidacionFondoRotativo.Columns(6).HeaderText = "NOMBRE AUTORIZADOR"
                dgvLiquidacionFondoRotativo.Columns(6).Width = 160
                dgvLiquidacionFondoRotativo.Columns(7).Visible = False
                dgvLiquidacionFondoRotativo.Columns(8).HeaderText = "VALOR"
                dgvLiquidacionFondoRotativo.Columns(8).Width = 70
                dgvLiquidacionFondoRotativo.Columns(9).HeaderText = "N° DOC."
                dgvLiquidacionFondoRotativo.Columns(10).Visible = False ' ID DOC
                dgvLiquidacionFondoRotativo.Columns(11).Visible = False ' TIPO DOC
                dgvLiquidacionFondoRotativo.ReadOnly = True


                btnCargar.Enabled = True
                btnLiquidacionFondoRotativo.Enabled = True
                btnGuardarSolicitudFR.Enabled = False
                btnCancelarSolicitudFR.Enabled = False
            Catch ex As Exception
                dgvLiquidacionFondoRotativo.DataSource = Nothing
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "MENSAJE")
            End Try
        End Sub

        Private Sub SumaTotalLiquidacion()
            Dim indice As Decimal
            Dim acumulador = 0.0
            Try
                For indice = 0 To dgvLiquidacionFondoRotativo.RowCount - 1
                    acumulador += CType(dgvLiquidacionFondoRotativo.Rows(+indice).Cells(8).Value, Decimal)
                Next
            Catch ex As Exception
                acumulador = 0.0
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "MENSAJE")
            End Try
            txtTotalLiquidacion.Text = Math.Round(acumulador, 2, MidpointRounding.ToEven)
            CalculoReposicion()
        End Sub

        Private Sub CalculoReposicion()
            Dim fondo = 700
            Dim gastos As Decimal
            Dim saldo As Decimal
            Dim reposicion As Decimal
            Try
                gastos = CType(txtTotalLiquidacion.Text, Decimal)
                saldo = fondo - gastos
                reposicion = fondo - saldo
            Catch ex As Exception
                gastos = 0
                saldo = 0
                reposicion = 0
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "MENSAJE")
            End Try
            txtCantidadFondoRotativo.Text = Math.Round(fondo, 2, MidpointRounding.ToEven)
            txtCantidadGastosFondoRotativo.Text = Math.Round(gastos, 2, MidpointRounding.ToEven)
            txtCantidadSaldoFondoRotativo.Text = Math.Round(saldo, 2, MidpointRounding.ToEven)
            txtCantidadReposicionFondoRotativo.Text = Math.Round(reposicion, 2, MidpointRounding.ToEven)
        End Sub

        Private Function ValidacionParametros() As Boolean
            If txtTotalLiquidacion.Text <> "" And txtCantidadFondoRotativo.Text <> "0.00" _
               And txtCantidadGastosFondoRotativo.Text <> "0.00" And txtCantidadSaldoFondoRotativo.Text <> "0.00" And txtCantidadReposicionFondoRotativo.Text <> "0.00" _
               And cmbProvincia.SelectedValue <> 0 And dgvLiquidacionFondoRotativo.RowCount > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub Auditoria(ByVal accion As String)
            _objAuditoria.IdAuditoria += 1
            _objAuditoria.AccionAuditoria = accion
            _sqlCommands.Add(_objAuditoria.RegistrarNuevoAuditoriaCommand())
        End Sub

        Private Sub ActualizarMontoFondo()
            With _objetoAuxiliarFondoRotativo
                .IdFondo = _objetoFondoRotativo.BuscarIdFondoRotativo(_tipoCon)
                .MontoFondo = 0
                .MontoAnteriorFondo = 0
            End With
            _sqlCommands.Add(_objetoAuxiliarFondoRotativo.ActualizarMontoAuxiliarFondoRotativoCommand())
            Auditoria("LIQUIDACIÓN DE FONDO ROTATIVO ID: " & _objetoLiquidacionFondoRotativo.IdLiquidacion & ", ACTUALIZAR MONTO  ANT: 0, ACT: 0" & _
                     _objetoLiquidacionFondoRotativo.FechaLiquidacion & ", VALOR: " & _objetoLiquidacionFondoRotativo.TotalLiquidacion)
        End Sub

        Private Sub GuardarRegistroLiquidacionFondoRotativo()
            With _objetoLiquidacionFondoRotativo
                .IdLiquidacion = _objetoLiquidacionFondoRotativo.BuscarMayorIdLiquidacionFondoRotativo(_tipoCon) + 1
                .FechaLiquidacion = dtpFechaLiquidacion.Value
                .TotalLiquidacion = txtTotalLiquidacion.Text
                .FondoLiquidacion = txtCantidadFondoRotativo.Text
                .GastosLiquidacion = txtCantidadGastosFondoRotativo.Text
                .SaldoLiquidacion = txtCantidadSaldoFondoRotativo.Text
                .ReposicionLiquidacion = txtCantidadReposicionFondoRotativo.Text
                .EstadoLiquidacion = 1
                .IdProvincias = 7
                .IdCiudad = 58
                .IdParroquias = 287
                .IdCentroCosto = cmbCentroCosto.SelectedValue
                .NroAsiento = 0
                '.NuevoRegistroLiquidacionForndoRotativo()
            End With
            _sqlCommands.Add(_objetoLiquidacionFondoRotativo.NuevoRegistroLiquidacionForndoRotativoCommand(_tipoCon))
            Auditoria("LIQUIDACIÓN DE FONDO ROTATIVO ID: " & _objetoLiquidacionFondoRotativo.IdLiquidacion & ", FECHA: " & _
                      _objetoLiquidacionFondoRotativo.FechaLiquidacion & ", VALOR: " & _objetoLiquidacionFondoRotativo.TotalLiquidacion)
        End Sub

        Private Sub ActualizarRegistroSolicitudFondoRotativo()
            For indice = 0 To dgvLiquidacionFondoRotativo.RowCount - 1
                With _objetoSolicitudFondoRotativo
                    .IdSolicitud = dgvLiquidacionFondoRotativo.Rows(indice).Cells(0).Value
                    .EstadoSolicitud = 2
                    .IdLiquidacion = _objetoLiquidacionFondoRotativo.IdLiquidacion
                    '.ModificarLiquidacionSolicitudFondoRotativo()
                End With
                _sqlCommands.Add(_objetoSolicitudFondoRotativo.ModificarLiquidacionSolicitudFondoRotativoCommand())

                Auditoria("LIQUIDACIÓN DE FONDO ROTATIVO ID: " & _objetoLiquidacionFondoRotativo.IdLiquidacion & ", DETALLE DE LIQUIDACIÓN  " & _
                        "ID SOL: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", FECHA: " & dgvLiquidacionFondoRotativo.Rows(+indice).Cells(3).Value & _
                        "VALOR: " & dgvLiquidacionFondoRotativo.Rows(+indice).Cells(8).Value)
            Next
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            CargarSolicitudFondoRotativo()
            SumaTotalLiquidacion()
        End Sub

        Private Sub btnLiquidacionFondoCCH_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLiquidacionFondoRotativo.Click
            If dgvLiquidacionFondoRotativo.Rows.Count < 1 Then
                MsgBox("NO HAY SOLICITUDES QUE LIQUIDAR", MsgBoxStyle.Information, "MENSAJE DE INFORMACION")
            Else
                SumaTotalLiquidacion()

                btnCargar.Enabled = False
                btnLiquidacionFondoRotativo.Enabled = False
                btnGuardarSolicitudFR.Enabled = True
                btnCancelarSolicitudFR.Enabled = True
            End If
        End Sub

        Private Sub btnGuardarSolicitudCCH_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSolicitudFR.Click
            Try
                If CDbl(txtTotalLiquidacion.Text) > CDbl(txtCantidadFondoRotativo.Text) Then
                    MessageBox.Show("NO SE PUEDE LIQUIDAR debido a que el total de los gastos supera al valor definido para FONDO DE CAJA CHICA!!!", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LA LIQUIDACIÓN?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                If ValidacionParametros() Then

                    _sqlCommands.Clear()

                    _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                    _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                    _objAuditoria.FormularioAuditoria = Text.Trim
                    _objAuditoria.EstadoAuditoria = 1
                    _objAuditoria.IdUsuarioAuditoria = IdUsuario

                    GuardarRegistroLiquidacionFondoRotativo()
                    ActualizarMontoFondo()
                    ActualizarRegistroSolicitudFondoRotativo()

                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                    If res(0) Then
                        txtIdLiquidacion.Text = _objetoLiquidacionFondoRotativo.IdLiquidacion
                        txtIdLiquidacionBusqueda.Text = txtIdLiquidacion.Text

                        btnCargar.Enabled = True
                        btnLiquidacionFondoRotativo.Enabled = False
                        btnGuardarSolicitudFR.Enabled = False
                        btnCancelarSolicitudFR.Enabled = False

                        TabControl1.SelectedIndex = 1
                    End If
                    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

                Else
                    MsgBox("No se pudo GUARDAR debido a que no ha llenado los parámetros necesarios o no hay registros que liquidar!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarSolicitudFR.Click
            dgvLiquidacionFondoRotativo.DataSource = Nothing
            SumaTotalLiquidacion()

            txtCantidadFondoRotativo.Text = "0.00"
            txtCantidadGastosFondoRotativo.Text = "0.00"
            txtCantidadSaldoFondoRotativo.Text = "0.00"
            txtCantidadReposicionFondoRotativo.Text = "0.00"
            txtTotalLiquidacion.Text = "0.00"

            btnCargar.Enabled = True
            btnLiquidacionFondoRotativo.Enabled = False
            btnGuardarSolicitudFR.Enabled = False
            btnCancelarSolicitudFR.Enabled = False
        End Sub

        Private Sub bntCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            Try
                Dim liq = _objetoLiquidacionFondoRotativo.SeleccionarLiquidacionFondoRotativoXid(_tipoCon, CInt(txtIdLiquidacionBusqueda.Text))
                _crLiquidacionFondoRotativo.SetDataSource(_objetoLiquidacionFondoRotativo.ReporteFondoRotativoPorIdLiquidacion(_tipoCon, CInt(txtIdLiquidacionBusqueda.Text)))
                _crLiquidacionFondoRotativo.SetParameterValue("idliquidacion", liq.Rows(0)(0))
                _crLiquidacionFondoRotativo.SetParameterValue("fecha", CDate(liq.Rows(0)(1)).ToLongDateString())
                _crLiquidacionFondoRotativo.SetParameterValue("fondo", CDec(liq.Rows(0)(3)).ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("saldo", CDec(liq.Rows(0)(5)).ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("reposicion", CDec(liq.Rows(0)(6)).ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("total", CDec(liq.Rows(0)(2)).ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvLiquidacion.ReportSource = _crLiquidacionFondoRotativo
                crvLiquidacion.Zoom(2)
            Catch ex As Exception
                crvLiquidacion.ReportSource = Nothing
            End Try
        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles TabControl1.SelectedIndexChanged
            If TabControl1.SelectedIndex = 1 Then txtIdLiquidacionBusqueda.Focus()
        End Sub

        Private Sub dgvLiquidacionFondoRotativo_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLiquidacionFondoRotativo.SelectionChanged
            btnAnularSolicitud.Enabled = dgvLiquidacionFondoRotativo.RowCount > 0 And Not dgvLiquidacionFondoRotativo.CurrentRow Is Nothing
        End Sub

        Dim _objetoAnticipoPrestamo As ClassAnticiposPrestamos
        Dim _objRegistroDescuento As ClassDescuentosPersonal
        Dim _objetoHistorial As ClassHistorialLaboral
        Private Sub btnAnularSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularSolicitud.Click
            If MessageBox.Show("¿ESTA SEGURA QUE DESEA ANULAR EL DOCUMENTO: '" & dgvLiquidacionFondoRotativo.CurrentRow.Cells(4).Value & "' N° " & dgvLiquidacionFondoRotativo.CurrentRow.Cells(9).Value & "?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                _sqlCommands.Clear()

                ' anular solicitud
                With _objetoSolicitudFondoRotativo
                    .IdSolicitud = dgvLiquidacionFondoRotativo.CurrentRow.Cells(0).Value
                    .DetalleSolicitud = dgvLiquidacionFondoRotativo.CurrentRow.Cells(2).Value
                End With
                _sqlCommands.Add(_objetoSolicitudFondoRotativo.EliminarUnaSolicitudesFondoRotativoCommand)

                ' anular comprobante
                If dgvLiquidacionFondoRotativo.CurrentRow.Cells(11).Value.ToString.Equals("DEDUCIBLE") Then
                    _objetoComprobantesCompra.IdComprobante = CInt(dgvLiquidacionFondoRotativo.CurrentRow.Cells(10).Value)
                    _objetoComprobantesCompra.EstadoComprobante = 0
                    _sqlCommands.Add(_objetoComprobantesCompra.ActualizarEstadoComprobanteCompras)

                    _objetoComprobantesRetencion.IdComprobanteCompra = CInt(dgvLiquidacionFondoRotativo.CurrentRow.Cells(10).Value)
                    _objetoComprobantesRetencion.EstadoComprobanteRetencion = 0
                    _sqlCommands.Add(_objetoComprobantesRetencion.ActualizarEstadoComprobanteRetencionCompraByIdComprobanteCompra)

                    _objetoDetalleComprobantesRetencion.IdComprobanteCompra = CInt(dgvLiquidacionFondoRotativo.CurrentRow.Cells(10).Value)
                    _objetoDetalleComprobantesRetencion.EstadoDetalleComprobanteRetencion = 0
                    _sqlCommands.Add((_objetoDetalleComprobantesRetencion.ActualizarEstadoDetalleComprobanteRetencionCompraByIdComprobanteCompra))
                Else
                    _objetoDocumentoNoDeducible.IdDocumentoNo = CInt(dgvLiquidacionFondoRotativo.CurrentRow.Cells(10).Value)
                    _objetoDocumentoNoDeducible.EstadoDocumentoNo = 0
                    _sqlCommands.Add(_objetoDocumentoNoDeducible.ActualizarEstadoDetalleDocumentoByIdDocumento)

                    ' anular DESCUENTO anticipo emergente                    
                    If dgvLiquidacionFondoRotativo.CurrentRow.Cells(1).Value.ToString.Trim.Equals("PRESTAMOS Y ANTICIPOS") Then
                        With _objetoAnticipoPrestamo
                            .IdAuxFondoCheque = _objetoSolicitudFondoRotativo.IdSolicitud
                        End With
                        _sqlCommands.Add(_objetoAnticipoPrestamo.AnularAnticiposPrestamoCommand())

                        ' descuento rol
                        _sqlCommands.Add(_objRegistroDescuento.AnularRegistroDescuentoFrCommand(_objetoSolicitudFondoRotativo.IdSolicitud))

                        ' historia lab                       
                        _sqlCommands.Add(_objetoHistorial.AnularHistorialLaboralFrCommand(_objetoSolicitudFondoRotativo.IdSolicitud))
                    End If

                End If

                ' AJUSTAR CAJA
                _objetoAuxiliarFondoRotativo.IdFondo = 1 ' FONDO ROTATIVO
                _objetoAuxiliarFondoRotativo.MontoFondo = CDec(dgvLiquidacionFondoRotativo.CurrentRow.Cells(8).Value)
                _sqlCommands.Add(_objetoAuxiliarFondoRotativo.ActualizarMontoAuxiliarFondoRotativoCommand2)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then ToolStripMenuItem1_Click(Nothing, Nothing)
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                MsgBox("ERROR AL ANULAR DOCUMENTO: " & ex.ToString, MsgBoxStyle.Critical)
            End Try
        End Sub
    End Class
End Namespace