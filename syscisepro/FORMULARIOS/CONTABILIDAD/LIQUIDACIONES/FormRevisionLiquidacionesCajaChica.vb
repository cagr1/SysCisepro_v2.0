Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.CONTABILIDAD.RETENCIONES_EMITIDAS

Namespace FORMULARIOS.CONTABILIDAD.LIQUIDACIONES

    Public Class FormRevisionLiquidacionesCajaChica
        ''' <summary>
        '''  CISEPRO - SEPORTPAC - ASENAVA 2019
        ''' </summary>
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

        ReadOnly _objLiquidacionCajaChica As New ClassLiquidacionCajaChica
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objSolicitudesCajaChica As New ClassSolicitudCajaChica
        ReadOnly _objCajaChica As New ClassCajaChica
        ReadOnly _objPer As New ClassPersonal
        ReadOnly _objProvincia As New ClassProvincias
        ReadOnly _objCanton As New ClassCiudades
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _objCentroCosto As New ClassCentroCosto
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objAuxiliarCajasChicas As New ClassAuxiliarCajaChica
        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoComprobanteRetencionCompra As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobanteRetencionCompra As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoPorcentajes As New ClassPorcentajes

        Dim _valDebe = 0
        Dim _valHaber = 0
        Dim _idald = 0

        Dim _esContribuyenteEspecial = False

        Dim _sqlCommands As List(Of SqlCommand)

        Private Sub FormRevisionLiquidacionesCajaChica_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvLiquidacionesCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSolicitudes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava

                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionesCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSolicitudes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionesCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSolicitudes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvSolicitudes.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvLiquidacionesCajaChica.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)

        End Sub
        Private Sub btnRecargar_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRecargar.Click
            CargarLiquidacionesCajaChica()
        End Sub

        Private Sub CargarLiquidacionesCajaChica()
            Try
                dgvLiquidacionesCajaChica.DataSource = _objLiquidacionCajaChica.SeleccionarLiquidacionesCajaChica(_tipoCon)

                dgvLiquidacionesCajaChica.Columns(0).HeaderText = "N"
                dgvLiquidacionesCajaChica.Columns(0).Width = 60
                dgvLiquidacionesCajaChica.Columns(1).Width = 90
                dgvLiquidacionesCajaChica.Columns(1).HeaderText = "FECHA"
                dgvLiquidacionesCajaChica.Columns(2).Width = 60
                dgvLiquidacionesCajaChica.Columns(2).HeaderText = "TOTAL"
                dgvLiquidacionesCajaChica.Columns(3).Width = 60
                dgvLiquidacionesCajaChica.Columns(3).HeaderText = "FONDO"
                dgvLiquidacionesCajaChica.Columns(4).Width = 60
                dgvLiquidacionesCajaChica.Columns(4).HeaderText = "GASTOS"
                dgvLiquidacionesCajaChica.Columns(5).Width = 60
                dgvLiquidacionesCajaChica.Columns(5).HeaderText = "SALDO"
                dgvLiquidacionesCajaChica.Columns(6).Width = 80
                dgvLiquidacionesCajaChica.Columns(6).HeaderText = "REPOSICIÓN"
                dgvLiquidacionesCajaChica.Columns(13).Width = 80
                dgvLiquidacionesCajaChica.Columns(13).HeaderText = "N° ASIENTO"

                dgvLiquidacionesCajaChica.AutoResizeRows()

                For indice = 0 To dgvLiquidacionesCajaChica.Columns.Count - 1
                    dgvLiquidacionesCajaChica.Columns(indice).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    If indice > 6 And indice < 13 Then dgvLiquidacionesCajaChica.Columns(indice).Visible = False
                Next
            Catch ex As Exception
                dgvLiquidacionesCajaChica.DataSource = Nothing
                MsgBox("METODO CARGAR SOLICITUD LIQUIDACIÓN DEDUCIBLE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub LimpiarParametros()
            dgvLiquidacionesCajaChica.DataSource = Nothing
            dgvSolicitudes.DataSource = Nothing
            dgvComprobanteCompra.DataSource = Nothing
            dgvComprobanteRetencionCompra.DataSource = Nothing
            dgvDetalleComprobanteRetencionCompra.DataSource = Nothing
            chkSeleccionarTodo.Checked = False

            txtProvincia.Tag = Nothing
            txtCiudad.Tag = Nothing
            txtParroquia.Tag = Nothing
            txtCentroCosto.Tag = Nothing
            txtProvincia.Text = ""
            txtCiudad.Text = ""
            txtParroquia.Text = ""
            txtCentroCosto.Text = ""

            txtIdLiquidacion.Text = "..."
            txtFechaLiquidacion.Text = ""
            txtTotalLiquidacion.Text = "0.00"
            txtFondoLiquidacion.Text = "0.00"
            txtGastosLiquidacion.Text = "0.00"
            txtSaldoLiquidacion.Text = "0.00"
            txtReposicionLiquidacion.Text = "0.00"
            txtCuentaCaja.Text = ""
            txtCaja.Tag = Nothing
            txtCaja.Text = ""
            txtCustodio.Text = ""
        End Sub
        Private Sub dgvLiquidacionesCajaChica_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvLiquidacionesCajaChica.SelectionChanged
            If dgvLiquidacionesCajaChica.Rows.Count = 0 Or dgvLiquidacionesCajaChica.CurrentRow Is Nothing Then Return
            CargarDatos()
        End Sub
        Private Sub LimpiarParametrosLiq()
            txtProvincia.Tag = Nothing
            txtCiudad.Tag = Nothing
            txtParroquia.Tag = Nothing
            txtCentroCosto.Tag = Nothing
            txtProvincia.Text = ""
            txtCiudad.Text = ""
            txtParroquia.Text = ""
            txtCentroCosto.Text = ""

            txtIdLiquidacion.Text = "..."
            txtFechaLiquidacion.Text = ""
            txtTotalLiquidacion.Text = "0.00"
            txtFondoLiquidacion.Text = "0.00"
            txtGastosLiquidacion.Text = "0.00"
            txtSaldoLiquidacion.Text = "0.00"
            txtReposicionLiquidacion.Text = "0.00"
            txtCuentaCaja.Text = ""
            txtCaja.Tag = Nothing
            txtCaja.Text = ""
            txtCustodio.Text = ""

            dgvSolicitudes.DataSource = Nothing
            chkSeleccionarTodo.Checked = False
        End Sub
        Private Sub CargarDatos()
            If dgvLiquidacionesCajaChica.CurrentRow Is Nothing Then
                LimpiarParametrosLiq()
                Return
            End If

            txtIdLiquidacion.Text = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("ID_LIQUIDACION_CCH").Value.ToString()
            txtFechaLiquidacion.Text = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("FECHA_LIQUIDACION_CCH").Value.ToString()
            txtTotalLiquidacion.Text = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("TOTAL_LIQUIDACION_CCH").Value.ToString()
            txtFondoLiquidacion.Text = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("FONDO_LIQUIDACION_CCH").Value.ToString()
            txtGastosLiquidacion.Text = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("GASTOS_LIQUIDACION_CCH").Value.ToString()
            txtSaldoLiquidacion.Text = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("SALDO_LIQUIDACION_CCH").Value.ToString()
            txtReposicionLiquidacion.Text = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("REPOSICION_LIQUIDACION_CCH").Value.ToString()

            txtProvincia.Tag = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("ID_PROVINCIAS").Value.ToString()
            txtProvincia.Text = _objProvincia.BuscarNombreProvinciaXIdProvincia(_tipoCon, txtProvincia.Tag)

            txtCiudad.Tag = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("ID_CIUDAD").Value.ToString()
            txtCiudad.Text = _objCanton.BuscarNombreCiudadXIdCiudad(_tipoCon, txtCiudad.Tag)

            txtParroquia.Tag = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("ID_PARROQUIAS").Value.ToString()
            txtParroquia.Text = _objParroquias.BuscarNombreParroquiaXIdParroquia(_tipoCon, txtParroquia.Tag)

            txtCentroCosto.Tag = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("ID_CENTRO_COSTO_CCH").Value.ToString()
            txtCentroCosto.Text = _objCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, txtCentroCosto.Tag)

            txtCaja.Tag = dgvLiquidacionesCajaChica.CurrentRow.Cells.Item("ID_CAJA_CCH").Value.ToString()
            txtCaja.Text = _objLiquidacionCajaChica.BuscarDetalleCajaChicaXIdCajaChica(_tipoCon, txtCaja.Tag)
            txtCuentaCaja.Text = _objCajaChica.BuscarCuentaContableXIdCajaChica(_tipoCon, txtCaja.Tag)
            txtCustodio.Text = _objPer.BuscarApellidosPersonalXIdPersonal(_tipoCon, _objCajaChica.BuscarIdCustodioCajaChicaXDetalleCajaChica(_tipoCon, txtCaja.Text)) + " " + _objPer.BuscarNombresPersonalXIdPersonal(_tipoCon, _objCajaChica.BuscarIdCustodioCajaChicaXDetalleCajaChica(_tipoCon, txtCaja.Text))

            CargarSolicitudFondoRotativo()
        End Sub
        Private Sub CargarSolicitudFondoRotativo()
            Try
                ' CAMBIAR CONSULTA Y REVISAR DETALLES SOLICITUDES CAJA CHICA
                dgvSolicitudes.DataSource = _objSolicitudesCajaChica.SeleccionarSolicitudesCajaChicaXIdLiquidacion(_tipoCon, txtIdLiquidacion.Text)

                dgvSolicitudes.Columns(0).ReadOnly = False
                dgvSolicitudes.Columns(1).Width = 50
                dgvSolicitudes.Columns(2).Visible = False
                dgvSolicitudes.Columns(3).Width = 80
                dgvSolicitudes.Columns(4).Width = 60
                dgvSolicitudes.Columns(5).Width = 100
                dgvSolicitudes.Columns(6).Width = 100
                dgvSolicitudes.Columns(7).Visible = False
                dgvSolicitudes.Columns(8).Visible = False
                dgvSolicitudes.Columns(9).Visible = False
                dgvSolicitudes.Columns(10).Width = 545

                dgvSolicitudes.AutoResizeRows()

                For indice = 1 To dgvSolicitudes.Columns.Count - 1
                    dgvSolicitudes.Columns(indice).ReadOnly = True
                    If indice < 10 Then dgvSolicitudes.Columns(indice).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    If indice >= 11 Then dgvSolicitudes.Columns(indice).Visible = False
                Next
            Catch ex As Exception
                dgvSolicitudes.DataSource = Nothing
                MsgBox("METODO CARGAR SOLICITUDES CAJA CHICA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Function ValidarSeleccion() As Boolean
            Return dgvSolicitudes.Rows.Cast(Of DataGridViewRow)().Any(Function(o) o.Cells(0).Value = True)
        End Function

        Private Sub btnFinRevision_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAprobarLiquidación.Click
            If dgvSolicitudes.RowCount = 0 And dgvSolicitudes.RowCount = 0 Then
                MsgBox("NO SE CARGARON LAS SOLICITUDES DE CAJA POR FAVOR REVISE LA LIQUIDACIÓN", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            Else
                If Not ValidarSeleccion() Then
                    MsgBox("DEBE SELECCIONAR AL MENOS UNA SOLICITUD PARA REALIZAR LA LIQUIDACIÓN", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                    Return
                End If

                If MsgBox("ESTÁ SEGURO QUE DESEA PROCESAR LA LIQUIDACIÓN ACTUAL?", MsgBoxStyle.YesNo, "MENSAJE DE INFORMACIÓN") <> DialogResult.Yes Then Return
                dgvSolicitudes_CellEndEdit(Nothing, Nothing)

                _valDebe = 0
                _valHaber = 0

                _sqlCommands.Clear()

                _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                ' NUM REGISTRO
                With _objetoNumeroRegistro
                    .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                    .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon) + 1
                End With
                _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                _idald = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1

                For indiceComprobantes = 0 To dgvSolicitudes.Rows.Count - 1
                    If dgvSolicitudes.Rows(indiceComprobantes).Cells(0).Value = False Then Continue For
                    If dgvSolicitudes.Rows(indiceComprobantes).Cells("TIPO").Value = "DEDUCIBLE" Then

                        CargarComprobantesCompra(dgvSolicitudes.Rows(indiceComprobantes).Cells("ID_COMP").Value)
                        CargarComprobanteRetencionCompra(dgvSolicitudes.Rows(indiceComprobantes).Cells("ID_COMP").Value)
                        CargarDetalleComprobanteRetencionCompras(dgvSolicitudes.Rows(indiceComprobantes).Cells("ID_COMP").Value)

                        _esContribuyenteEspecial = dgvComprobanteCompra.Rows(0).Cells("CONTRIBUYENTE_ESPECIAL_PROVEEDOR_GENERAL").Value.ToString.Trim.Equals("SI")

                        With _objetoAsientoLibroDiario 'gasto
                            .IdAsiento = _idald
                            .FechaAsiento = txtFechaLiquidacion.Text
                            .CodigoCuentaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("DEBE").Value
                            .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                            .ConceptoAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CONCEPTO").Value
                            .DetalleTransaccionAsiento = "ID CCH : " + txtIdLiquidacion.Text.ToString + " CAJA: " + txtCaja.Text.ToString + " DETALLE: " + dgvSolicitudes.Rows(indiceComprobantes).Cells("DETALLE").Value
                            .ProvinciaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("PROVINCIA").Value
                            .CiudadAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CIUDAD").Value
                            .ParroquiaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("PARROQUIA").Value
                            .CentroCostoAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CENTRO").Value
                            .ValorDebeAsiento = dgvComprobanteCompra.Rows(0).Cells("SUBTOTAL_COMPROBANTE_COMPRA").Value
                            .ValorHaberAsiento = 0
                            .DebeHaberAsiento = 1 ' DEBE=1 / HABER=2 
                            .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                            .ConciliarAsiento = 1
                            .EstadoAsiento = 1
                            .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                            .EstadoMayorAsiento = 0
                        End With
                        _valDebe += _objetoAsientoLibroDiario.ValorDebeAsiento
                        _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                        _idald += 1

                        If dgvComprobanteCompra.Rows.Count > 0 Then
                            If dgvComprobanteCompra.Rows(0).Cells(16).Value > 0 Then ' si la compra tiene iva
                                With _objetoAsientoLibroDiario 'iva 
                                    .IdAsiento = _idald
                                    .FechaAsiento = txtFechaLiquidacion.Text
                                    .CodigoCuentaAsiento = "1010512"
                                    .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                                    .ConceptoAsiento = "IVA PAGADO POR COMPRA"
                                    .DetalleTransaccionAsiento = "ID CCH : " + txtIdLiquidacion.Text.ToString + " CAJA: " + txtCaja.Text.ToString + " DETALLE: " + dgvSolicitudes.Rows(indiceComprobantes).Cells("DETALLE").Value
                                    .ProvinciaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("PROVINCIA").Value
                                    .CiudadAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CIUDAD").Value
                                    .ParroquiaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("PARROQUIA").Value
                                    .CentroCostoAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CENTRO").Value
                                    .ValorDebeAsiento = dgvComprobanteCompra.Rows(0).Cells("IVA_COMPROBANTE_COMPRA").Value
                                    .ValorHaberAsiento = 0
                                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                                    .DebeHaberAsiento = 1 ' DEBE=1 / HABER=2 
                                    .ConciliarAsiento = 1
                                    .EstadoAsiento = 1
                                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                                    .EstadoMayorAsiento = 0
                                End With
                                _valDebe += _objetoAsientoLibroDiario.ValorDebeAsiento
                                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                                _idald += 1
                            End If

                            If dgvComprobanteRetencionCompra.Rows.Count > 0 Then
                                If dgvComprobanteRetencionCompra.Rows(0).Cells(8).Value > 0 Then       'SI EL VALOR DE LA RETENCIÓN ES MAYOR A 0 / (SI NO ES CODIGO 332)
                                    'Dim codigoCuenta = "0"
                                    For indiceRetencion = 0 To dgvDetalleComprobanteRetencionCompra.RowCount - 1
                                        'If dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(4).Value = "RENTA" Then 
                                        '    codigoCuenta = _objetoPorcentajes.CuentaRetencionRentaCodPorcTipo(TipoCox, dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(2).Value.ToString().Trim(), dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(5).Value.ToString().Trim(), 0)
                                        '    If codigoCuenta.Trim().Length = 0 Then
                                        '        MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO EN LA FAC. ID: " & dgvComprobanteCompra.Rows(0).Cells(0).Value & " NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALICACIÓN")
                                        '        Exit Sub
                                        '    End If
                                        'End If
                                        'If dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(4).Value = "IVA" Then
                                        '    codigoCuenta = _objetoPorcentajes.CuentaRetencionIvaPorc(TipoCox, dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(5).Value.ToString().Trim())
                                        '    If codigoCuenta.Trim().Length = 0 Then
                                        '        MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO EN LA FAC. ID: " & dgvComprobanteCompra.Rows(0).Cells(0).Value & " NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALICACIÓN")
                                        '        Exit Sub
                                        '    End If
                                        'End If

                                        If dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(10).Value.ToString().Trim().Length = 0 Or dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(11).Value.ToString().Trim().Length = 0 Then
                                            MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO EN LA FAC. ID: " & dgvComprobanteCompra.Rows(0).Cells(0).Value & " NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALICACIÓN")
                                            Exit Sub
                                        End If

                                        With _objetoAsientoLibroDiario ' retencion
                                            .IdAsiento = _idald
                                            .FechaAsiento = txtFechaLiquidacion.Text
                                            .CodigoCuentaAsiento = dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(10).Value.ToString().Trim()
                                            .NombreCuentaAsiento = dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(11).Value.ToString().Trim()
                                            .ConceptoAsiento = "OBLIGACIONES CON LA ADMINISTRACIÓN TRIBUTARIA"
                                            .DetalleTransaccionAsiento = "ID CCH : " + txtIdLiquidacion.Text.ToString + " CAJA: " + txtCaja.Text.ToString + " DETALLE: " + dgvSolicitudes.Rows(indiceComprobantes).Cells("DETALLE").Value
                                            .ProvinciaAsiento = txtProvincia.Text.ToUpper.Trim
                                            .CiudadAsiento = txtCiudad.Text.ToUpper.Trim
                                            .ParroquiaAsiento = txtParroquia.Text.ToUpper.Trim
                                            .CentroCostoAsiento = txtCentroCosto.Text.ToUpper.Trim
                                            .ValorDebeAsiento = 0
                                            .ValorHaberAsiento = CDec(dgvDetalleComprobanteRetencionCompra.Rows(indiceRetencion).Cells.Item(6).Value)
                                            .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                                            .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                                            .ConciliarAsiento = 1
                                            .EstadoAsiento = 1
                                            .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                                            .EstadoMayorAsiento = 0
                                        End With
                                        _valHaber += _objetoAsientoLibroDiario.ValorHaberAsiento
                                        _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                                        _idald += 1
                                    Next
                                End If
                            End If

                        End If
                    Else
                        With _objetoAsientoLibroDiario 'NO DEDUCIBLE
                            .IdAsiento = _idald
                            .FechaAsiento = txtFechaLiquidacion.Text
                            .CodigoCuentaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("DEBE").Value
                            .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                            .ConceptoAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CONCEPTO").Value
                            .DetalleTransaccionAsiento = "ID CCH : " + txtIdLiquidacion.Text.ToString + " CAJA: " + txtCaja.Text.ToString + " DETALLE: " + dgvSolicitudes.Rows(indiceComprobantes).Cells("DETALLE").Value
                            .ProvinciaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("PROVINCIA").Value
                            .CiudadAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CIUDAD").Value
                            .ParroquiaAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("PARROQUIA").Value
                            .CentroCostoAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("CENTRO").Value
                            .ValorDebeAsiento = dgvSolicitudes.Rows(indiceComprobantes).Cells("VALOR").Value
                            .ValorHaberAsiento = 0
                            .DebeHaberAsiento = 1 ' DEBE=1 / HABER=2 
                            .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                            .ConciliarAsiento = 1
                            .EstadoAsiento = 1
                            .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                            .EstadoMayorAsiento = 0
                        End With
                        _valDebe += _objetoAsientoLibroDiario.ValorDebeAsiento
                        _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                        _idald += 1
                    End If

                    With _objSolicitudesCajaChica
                        .IdSolitud = dgvSolicitudes.Rows(indiceComprobantes).Cells("ID").Value
                        .Estado = 3
                    End With
                    _sqlCommands.Add(_objSolicitudesCajaChica.AprobarSolicitudesCajaChicaCommand())
                Next

                With _objetoAsientoLibroDiario
                    .IdAsiento = _idald
                    .FechaAsiento = txtFechaLiquidacion.Text
                    .CodigoCuentaAsiento = txtCuentaCaja.Text
                    .NombreCuentaAsiento = txtCaja.Text
                    .ConceptoAsiento = "LIQUIDACIÓN " + txtCaja.Text
                    .DetalleTransaccionAsiento = "ID CCH : " + txtIdLiquidacion.Text.ToString + " CAJA: " + txtCaja.Text.ToString + " SE LIQUIDO PARA REALIZAR REPOSICIÓN"
                    .ProvinciaAsiento = txtProvincia.Text
                    .CiudadAsiento = txtCiudad.Text
                    .ParroquiaAsiento = txtParroquia.Text
                    .CentroCostoAsiento = txtCentroCosto.Text
                    .ValorDebeAsiento = 0
                    .ValorHaberAsiento = CDec(txtTotalRegistros.Text)
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    .DebeHaberAsiento = 2
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                    .EstadoMayorAsiento = 0
                End With
                _valHaber += _objetoAsientoLibroDiario.ValorHaberAsiento
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                _idald += 1

                With _objLiquidacionCajaChica
                    .Id = CInt(txtIdLiquidacion.Text)
                    .Estado = 2
                    .NroAsiento = _objetoNumeroRegistro.NumeroRegistro
                End With
                _sqlCommands.Add(_objLiquidacionCajaChica.AprobarLiquidacionCommand())

                With _objAuxiliarCajasChicas
                    .IdCajaChica = CInt(txtCaja.Tag)
                    .MontoCajaChica = CDec(txtFondoLiquidacion.Text)
                    .MontoAnterior = CDec(txtFondoLiquidacion.Text)
                End With
                _sqlCommands.Add(_objAuxiliarCajasChicas.ActualizarMontosCajaChicaCommand())

                Dim texto = "DEBE: " & _valDebe & "        -        HABER: " & _valHaber
                If Math.Abs(_valDebe - _valHaber) > 0.01 Then
                    MsgBox("NO ES POSBLE PROCESAR LA LIQUIDACIÓN PORQUE LA TRANSACCIÓN GENERADA NO CUADRA!!!" & vbNewLine & texto)
                    Return
                End If

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    LimpiarParametros()
                    CargarLiquidacionesCajaChica()
                End If
                MsgBox(res(1) & vbNewLine & texto, If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            End If
        End Sub
        Private Sub chkSeleccionarTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkSeleccionarTodo.CheckedChanged
            txtTotalRegistros.Text = "0.00"
            Dim n = 0.0
            For indice = 0 To dgvSolicitudes.RowCount - 1
                n += If(chkSeleccionarTodo.Checked, CDec(dgvSolicitudes.Rows(indice).Cells(4).Value), 0)
                dgvSolicitudes.Rows(indice).Cells(0).Value = chkSeleccionarTodo.Checked
            Next
            txtTotalRegistros.Text = Math.Round(n, 2)
        End Sub
        Private Sub CargarComprobantesCompra(ByVal idc As Integer)
            dgvComprobanteCompra.DataSource = _objetoComprobantesCompra.SeleccionarComprobanteCompraXIdComprobante(_tipoCon, idc)
            dgvComprobanteCompra.AutoResizeColumns()
            dgvComprobanteCompra.AutoResizeRows()
        End Sub
        Private Sub CargarComprobanteRetencionCompra(ByVal idc As Integer)
            dgvComprobanteRetencionCompra.DataSource = _objetoComprobanteRetencionCompra.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, idc)
            dgvComprobanteRetencionCompra.AutoResizeColumns()
            dgvComprobanteRetencionCompra.AutoResizeRows()
        End Sub
        Private Sub CargarDetalleComprobanteRetencionCompras(ByVal idc As Integer)
            dgvDetalleComprobanteRetencionCompra.DataSource = _objetoDetalleComprobanteRetencionCompra.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteCompra(_tipoCon, idc)
            dgvDetalleComprobanteRetencionCompra.AutoResizeColumns()
            dgvDetalleComprobanteRetencionCompra.AutoResizeRows()
        End Sub
        Private Sub dgvSolicitudes_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudes.CellEndEdit
            Dim n = 0.0
            For indice = 0 To dgvSolicitudes.RowCount - 1
                If dgvSolicitudes.Rows(indice).Cells(0).Value = False Then Continue For
                n += CDec(dgvSolicitudes.Rows(indice).Cells(4).Value)
            Next
            txtTotalRegistros.Text = Math.Round(n, 2)
        End Sub

    End Class
End Namespace