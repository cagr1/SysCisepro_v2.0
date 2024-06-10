Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAnularComprobanteIngresoBancos
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

        ReadOnly _objetoComprobanteIngreso As New ClassComprobanteIngresoBanco


        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario

        ReadOnly _objetoNumeroRegistroAsientoCompIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso

        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos

        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta

        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""

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

        Private Sub LlenarComboCuentasBancos()
            cmbCuentaBancos.DataSource = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, cmbBancos.SelectedValue)
            If cmbCuentaBancos.Items.Count = 0 Then
                cmbCuentaBancos.Text = "NINGUNA CUENTA"
            Else
                cmbCuentaBancos.DisplayMember = "NUMERO_CUENTA_BANCOS"
                cmbCuentaBancos.ValueMember = "ID_CUENTA_BANCOS"
            End If
        End Sub

        Private Sub CargarComprobanteIngresoBancos()
            Try
                dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteIngreso.BuscarComprobantesIngresoXIdBancoIdCuentaRangoFecha(_tipoCon, cmbBancos.SelectedValue, cmbCuentaBancos.SelectedValue, _fechaDesde, _fechaHasta)
                dgvComprobanteEgresoBancos.AutoResizeColumns()
                dgvComprobanteEgresoBancos.AutoResizeRows()

                dgvComprobanteEgresoBancos.Columns("FACTURAS").Width = 100
                dgvComprobanteEgresoBancos.Columns("CLIENTE").Width = 250
                dgvComprobanteEgresoBancos.Columns("ACTIVIDAD").Width = 250
                dgvComprobanteEgresoBancos.Columns("OBSERVACION").Width = 250
                dgvComprobanteEgresoBancos.Columns(0).ReadOnly = False
            Catch ex As Exception
                MsgBox("METODO CARGAR COMPROBANTES DE INGRESO." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub ActualizarValoresPagos()
            Try

                'For indicePagos = 0 To dgvPagosFacturaVentaPorIngreso.Rows.Count - 1
                'Dim saldo As Decimal = 0

                'lblIdFacturaVenta.Text = dgvPagosFacturaVentaPorIngreso.Rows(indicePagos).Cells("ID FACTURA").Value
                'CargarPagosFacturaVentaPorFactura(lblIdFacturaVenta.Text)

                'For indiceFacturaAnular = 0 To dgvPagosFacturaVentaPorFactura.Rows.Count - 1
                '    If lblIdComprobanteIngresoBanco.Text = CType(dgvPagosFacturaVentaPorFactura.Rows(indiceFacturaAnular).Cells("ID INGRESO").Value, Decimal) Then
                '        dgvPagosFacturaVentaPorFactura.Rows(indiceFacturaAnular).Cells("ESTADO").Value = 0 ' anula el pago correspondiente al COMPROBANTE DE INGRESO
                '    End If
                'Next

                'For indiceFactura = 0 To dgvPagosFacturaVentaPorFactura.Rows.Count - 1
                '    If dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("NUMERO").Value = 1 Then ' en caso de pagar varias compras con un cheque se resetea el saldo para hacer el calculo de la siguiente compra
                '        saldo = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("SALDO").Value ' saldo inicial para empezar a restar
                '    End If
                '    If CType(dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("ESTADO").Value, Decimal) <> 0 And CType(dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("MONTO").Value, Decimal) > 0 Then
                '        saldo = saldo - dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("MONTO").Value ' calcula el nuevo saldo
                '        dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("SALDO").Value = saldo ' asigna el nuevo saldo
                '    End If

                If lblIdComprobanteIngresoBanco.Text <> "..." And lblIdComprobanteIngresoBanco.Text <> "0" Then
                    With _objetoPagosFacturaVenta  ' anula los pagos hechos con el comprobante
                        '.IdPagoFactura = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("ID").Value
                        '.FechaPagoFactura = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("FECHA").Value
                        '.NumeroPagoFactura = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("NUMERO").Value
                        '.FormaPagoFactura = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("FORMA PAGO").Value
                        '.MontoPagoFactura = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("MONTO").Value
                        '.SaldoPagoFactura = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("SALDO").Value
                        '.EstadoPagoFactura = 0
                        '.IdFactura = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("ID FACTURA").Value
                        '.IdCliente = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("ID CLIENTE").Value
                        '.IdComprobanteIngreso = dgvPagosFacturaVentaPorFactura.Rows(indiceFactura).Cells("ID INGRESO").Value
                        .IdComprobanteIngreso = lblIdComprobanteIngresoBanco.Text
                        '.ActualizarRegistroPagosFacturaVenta(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoPagosFacturaVenta.AnularPagosFacturaVentaByIdComprobanteIngresos)
                End If

                'Next
                'Next
            Catch ex As Exception
                MsgBox("Error calcular pagos" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
            End Try
        End Sub

        Private Sub AnularComprobanteIngresoBancos()
            dgvComprobanteEgresoBancos.EndEdit()

            'Dim numeroAnulados = 0
            For indiceAnular = 0 To dgvComprobanteEgresoBancos.Rows.Count - 1

                If CBool(dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(0).Value) Then ' Si la fila de la grilla esta checkeada 
                    With _objetoComprobanteIngreso  ' anula el comprobante de egreso
                        .Id = dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(1).Value
                        .EstadoComprobanteIngreso = 0
                        '.ActualizarEstadoComprobanteIngresoBancos(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoComprobanteIngreso.ActualizarEstadoComprobanteIngresoBancos)


                    With _objetoAsientoLibroDiario ' anula el asiento de diario
                        .NumeroRegistroAsiento = _objetoNumeroRegistroAsientoCompIngreso.BuscarNumeroRegistroAsientoPorIdComprobanteIngreso(_tipoCon, dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(1).Value) ' busca el asiento del egreso
                        '.AnularAsientoLibroDiarioXNumeroRegistro(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXNumeroRegistro)

                    lblIdComprobanteIngresoBanco.Text = dgvComprobanteEgresoBancos.Rows(indiceAnular).Cells(1).Value

                    'CargarPagosFacturaVentaPorIngreso(lblIdComprobanteIngresoBanco.Text) ' carga los pagos
                    ActualizarValoresPagos() ' calcula los nuevos valores, saldos y anula

                    'numeroAnulados += 1
                End If

            Next
            'MsgBox("Se anularon " + numeroAnulados.ToString + " registros.")

        End Sub

        Private Sub FormAnularComprobanteIngresoBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA 
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            dgvComprobanteEgresoBancos.Font = New Font("Roboto", 8, FontStyle.Regular)
            LlenarComboBancos()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"
            cargarComprobanteIngresoBancos()
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            dgvComprobanteEgresoBancos.EndEdit()
            If dgvComprobanteEgresoBancos.Rows.Count > 0 Then
                Dim respuestaMsgBox = MessageBox.Show("¿CONFIRMA QUE DESEA ANULAR LOS COMPROBANTES SELECCIONADOS?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If respuestaMsgBox <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                AnularComprobanteIngresoBancos()

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    LlenarComboCuentasBancos()
                    CargarComprobanteIngresoBancos()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("NO HAY COMPROBANTES CARGADOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub cmbBancos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedValueChanged
            If cmbBancos.SelectedValue Is Nothing Or TypeOf cmbBancos.SelectedValue Is DataRowView Then Return
            LlenarComboCuentasBancos()
        End Sub
    End Class
End Namespace