Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAnularComprobanteEgresoBancos
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
        Dim _sqlCommands As List(Of SqlCommand)

        ReadOnly _objetoComprobanteEgreso As New ClassComprobanteEgresoBanco
        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos


        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario

        'ReadOnly _objetoNumeroRegistroAsientoComprobanteEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso

        ReadOnly _objetoChequeEmitido As New ClassChequesEmitidosCxp

        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra

        Dim _estadoBuscarComprobanteEgresos = 1
        Dim _fechaDesde = ""
        Dim _fechaHasta = ""

        Private Sub LlenarComboCuentasBancos()
            'Dim data = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, lblIdBanco.Text)
            'cmbCuentaBancos.DataSource = data
            'If cmbCuentaBancos.Items.Count = 0 Then
            '    cmbCuentaBancos.Text = "NINGUNA CUENTA"
            'Else
            '    cmbCuentaBancos.DisplayMember = data.Columns(0).ToString
            '    cmbCuentaBancos.ValueMember = data.Columns(0).ToString
            'End If

            cmbCuentaBancos.DataSource = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, cmbBancos.SelectedValue)
            If cmbCuentaBancos.Items.Count = 0 Then
                cmbCuentaBancos.Text = "NINGUNA CUENTA" 
            Else
                cmbCuentaBancos.DisplayMember = "NUMERO_CUENTA_BANCOS"
                cmbCuentaBancos.ValueMember = "ID_CUENTA_BANCOS" 
            End If
        End Sub

        Private Sub CargarComprobanteEgresoBancos()
            Try 
                If _estadoBuscarComprobanteEgresos = 1 Then ' Emitidos
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoEmitidosXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, String.Empty)
                ElseIf _estadoBuscarComprobanteEgresos = 2 Then ' Aprobados
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoAprobadosXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, String.Empty)
                ElseIf _estadoBuscarComprobanteEgresos = 3 Then ' Cheque
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.SeleccionarComprobanteEgresoBancosXNumeroCheque(_tipoCon, txtNumeroCheque.Text)
                ElseIf _estadoBuscarComprobanteEgresos = 4 Then ' Todos
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.SeleccionarOrdenadosComprobanteEgresoBancos(_tipoCon, String.Empty)
                ElseIf _estadoBuscarComprobanteEgresos = 5 Then ' Fecha
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, String.Empty)
                ElseIf _estadoBuscarComprobanteEgresos = 6 Then ' Banco
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoXIdBancoIdCuentaRangoFecha(_tipoCon, cmbBancos.SelectedValue, cmbCuentaBancos.SelectedValue, _fechaDesde, _fechaHasta, String.Empty)
                End If

                dgvComprobanteEgresoBancos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(1).HeaderText = "ID"
                dgvComprobanteEgresoBancos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(2).HeaderText = "NRO CE"
                dgvComprobanteEgresoBancos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(3).HeaderText = "FECHA"
                dgvComprobanteEgresoBancos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(4).HeaderText = "FACTURA"
                dgvComprobanteEgresoBancos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(5).HeaderText = "RUC / CI"
                dgvComprobanteEgresoBancos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(6).HeaderText = "PAGADO A"
                dgvComprobanteEgresoBancos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(7).HeaderText = "ACTIVIDAD"
                dgvComprobanteEgresoBancos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(8).HeaderText = "CONCEPTO"
                dgvComprobanteEgresoBancos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteEgresoBancos.Columns(9).HeaderText = "TIPO"
                dgvComprobanteEgresoBancos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobanteEgresoBancos.Columns(10).HeaderText = "VALOR"
                dgvComprobanteEgresoBancos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobanteEgresoBancos.Columns(11).HeaderText = "Nº CHEQUE"
                dgvComprobanteEgresoBancos.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobanteEgresoBancos.Columns(12).HeaderText = "BANCO"
                dgvComprobanteEgresoBancos.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobanteEgresoBancos.Columns(13).HeaderText = "CUENTA"
                dgvComprobanteEgresoBancos.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobanteEgresoBancos.Columns(14).HeaderText = "EST"
                dgvComprobanteEgresoBancos.AutoResizeColumns()
                dgvComprobanteEgresoBancos.AutoResizeRows()
                dgvComprobanteEgresoBancos.Columns(3).Width = 100
                dgvComprobanteEgresoBancos.Columns(4).Width = 150
                dgvComprobanteEgresoBancos.Columns(8).Width = 150

            Catch
                dgvComprobanteEgresoBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub AnularComprobanteEgresoBancos()
            'Dim numeroAnulados = 0
            For indiceAnular = 0 To dgvComprobanteEgresoBancos.Rows.Count - 1
                If CBool(dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(0).Value) Then ' Si la fila de la grilla esta checkeada 
                    With _objetoComprobanteEgreso ' anula el comprobante de egreso
                        .Id = dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(1).Value
                        .Estado = 0
                        '.ActualizarEstadoComprobanteEgresoBancos(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoComprobanteEgreso.ActualizarEstadoComprobanteEgresoBancos)

                    With _objetoChequeEmitido ' anula el cheque
                        .IdComprobante = dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(1).Value
                        .EstadoCheque = 0
                        '.ActualizarEstadoChequesEmitidosXIdComprobanteEgreso(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoChequeEmitido.ActualizarEstadoChequesEmitidosXIdComprobanteEgreso)

                    Dim numeroRegistro = dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(15).Value
                    With _objetoAsientoLibroDiario ' anula el asiento de diario
                        .NumeroRegistroAsiento = numeroRegistro
                        '.AnularAsientoLibroDiarioXNumeroRegistro(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXNumeroRegistro)

                    With _objetoPagosComprobantesCompra ' anula los pagos hechos con el comprobante
                        .IdComprobanteEgreso = dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(1).Value

                        '_idComprobanteEgresoB = dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(1).Value

                        'CargarPagosComprobantesCompra() ' carga los pagos
                        'ActualizarValoresPagos() ' calcula los nuevos valores y saldos

                        'For indicePago = 0 To _dgvPagosComprobantesCompras.Rows.Count - 1 ' recorre los pagos para actualizarlos
                        '    '.IdPagosComprobantes = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("ID_PAGO").Value
                        '    '.FechaPagosComprobantes = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("FECHA").Value
                        '    '.NumeroPagosComprobantes = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("NUMERO_PAGO").Value
                        '    '.MontoPagosComprobantes = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("MONTO").Value
                        '    '.SaldoPagosComprobantes = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("SALDO").Value
                        '    '.EstadoPagosComprobantes = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("ESTADO").Value
                        '    '.IdComprobante = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("ID_COMPRA").Value
                        '    '.IdComprobanteEgreso = _dgvPagosComprobantesCompras.Rows(indicePago).Cells("ID_EGRESO").Value
                        '    ''.ActualizarRegistroPagosComprobantesCompra(_tipoCon)
                        'Next
                        _sqlCommands.Add(_objetoPagosComprobantesCompra.AnularPagosComprobantesCompraByIdComprobanteEgreso())

                    End With
                    'numeroAnulados += 1
                End If

            Next
        End Sub

        Private Sub FormAnularComprobanteEgresoBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)


            LlenarComboBancos()
            CargarComprobanteEgresoBancos()
        End Sub

        Private Sub LlenarComboBancos()
            Try
                Dim data = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"

            CargarComprobanteEgresoBancos()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            dgvComprobanteEgresoBancos.EndEdit()
            If dgvComprobanteEgresoBancos.Rows.Count > 0 Then
                Dim respuestaMsgBox = MessageBox.Show("¿CONFIRMA QUE DESEA ANULAR LOS COMPROBANTES SELECCIONADOS?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If respuestaMsgBox <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                AnularComprobanteEgresoBancos()

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    LlenarComboCuentasBancos()
                    CargarComprobanteEgresoBancos()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("NO HAY COMPROBANTES CARGADOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub rbEmitidos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbEmitidos.CheckedChanged
            If rbEmitidos.Checked Then
                _estadoBuscarComprobanteEgresos = 1
                gbNumeroCheque.Enabled = False
                gbRangoFechas.Enabled = True
                gbBanco.Enabled = False
            Else
                _estadoBuscarComprobanteEgresos = 2
            End If
        End Sub

        Private Sub rbAprobados_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbAprobados.CheckedChanged
            If rbAprobados.Checked Then
                _estadoBuscarComprobanteEgresos = 2
                gbNumeroCheque.Enabled = False
                gbRangoFechas.Enabled = True
                gbBanco.Enabled = False
            Else
                _estadoBuscarComprobanteEgresos = 1
            End If
        End Sub

        Private Sub rbNumeroCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNumeroCheque.CheckedChanged
            If rbNumeroCheque.Checked Then
                _estadoBuscarComprobanteEgresos = 3
                txtNumeroCheque.Enabled = True
                txtNumeroCheque.Focus()
                gbNumeroCheque.Enabled = True
                gbRangoFechas.Enabled = False
                gbBanco.Enabled = False
            Else
                _estadoBuscarComprobanteEgresos = 1
            End If
        End Sub

        Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFecha.CheckedChanged
            If rbFecha.Checked Then
                _estadoBuscarComprobanteEgresos = 5
                gbNumeroCheque.Enabled = False
                gbRangoFechas.Enabled = True
                gbBanco.Enabled = False
            Else
                _estadoBuscarComprobanteEgresos = 1
            End If
        End Sub
        Private Sub rbBanco_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbBanco.CheckedChanged
            If rbBanco.Checked = True Then
                _estadoBuscarComprobanteEgresos = 6
                gbNumeroCheque.Enabled = False
                gbRangoFechas.Enabled = True
                gbBanco.Enabled = True
            Else
                _estadoBuscarComprobanteEgresos = 1
            End If
        End Sub

        Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodos.CheckedChanged
            If rbTodos.Checked Then
                _estadoBuscarComprobanteEgresos = 4
            Else
                _estadoBuscarComprobanteEgresos = 1
            End If
        End Sub

        Private Sub txtNumeroCheque_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroCheque.KeyDown
            If e.KeyCode <> Keys.Enter Then Return
            If txtNumeroCheque.Text <> "" Then CargarComprobanteEgresoBancos()
        End Sub

        Private Sub cmbCuentaBancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbCuentaBancos.SelectedIndexChanged
            lblIdCuentaBancos.Text = _objetoCuentaBancos.BuscarIdCuentaXNumeroCuenta(_tipoCon, cmbCuentaBancos.SelectedValue.ToString)
        End Sub

        Private Sub cmbBancos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedValueChanged
            Try
                lblIdBanco.Text = cmbBancos.SelectedValue
                LlenarComboCuentasBancos()
            Catch
                lblIdBanco.Text = String.Empty
            End Try
            'cmbCuentaBancos.DataSource = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, cmbBancos.SelectedValue)
            'If cmbCuentaBancos.Items.Count = 0 Then
            '    cmbCuentaBancos.Text = "NINGUNA CUENTA"
            '    lblIdBanco.Text = String.Empty
            'Else
            '    cmbCuentaBancos.DisplayMember = "NUMERO_CUENTA_BANCOS"
            '    cmbCuentaBancos.ValueMember = "ID_CUENTA_BANCOS"

            '    lblIdBanco.Text = cmbCuentaBancos.SelectedValue
            'End If
        End Sub
    End Class
End Namespace