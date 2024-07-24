Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO 
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql


Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAnularNotaCredito
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
        ReadOnly _objetoNotaCredito As New ClassNotaCredito
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoNumeroRegistroAsientoNotaCredito As New ClassNumeroRegistroAsientoNotaCreditoVenta
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario

        Dim _total As Decimal
        Dim _idFacturaVenta As Integer
        Dim _notSelect As List(Of Integer)

        Private Sub FormAnularNotaCredito_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvNotaCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvNotaCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvNotaCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
            End Select
            _sqlCommands = New List(Of SqlCommand)
            _notSelect = New List(Of Integer)

            AutocompletarNombreCliente()
        End Sub
        Private Sub AutocompletarNombreCliente()
            Try
                txtNombreComercialCliente.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialCliente.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialCliente.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub txtNombreComercialCliente_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            txtNumeroFacturaBuscar.Clear()
            CargarDatosCliente()
            CargarNotaCreditoXIdCliente()
        End Sub
        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            txtNombreComercialCliente.Clear()
            lblIdClienteGeneral.Text = "..."
            lblRucClienteGenral.Text = "..."
            lblLlevaContabilidadClienteGeneral.Text = "..."
            CargarNotaCreditoXNroNotaCredito()
        End Sub
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If txtNombreComercialCliente.Text.Trim().Length > 0 Then
                txtNumeroFacturaBuscar.Clear()
                CargarDatosCliente()
                CargarNotaCreditoXIdCliente()
            Else
                txtNombreComercialCliente.Clear()
                lblIdClienteGeneral.Text = "..."
                lblRucClienteGenral.Text = "..."
                lblLlevaContabilidadClienteGeneral.Text = "..."
                CargarNotaCreditoXNroNotaCredito()
            End If
        End Sub
        Private Sub CargarDatosCliente()
            Try
                Dim cli = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, txtNombreComercialCliente.Text)
                If cli.Rows.Count > 0 Then
                    lblIdClienteGeneral.Text = cli.Rows(0)(0)
                    lblRucClienteGenral.Text = cli.Rows(0)(3)
                    lblLlevaContabilidadClienteGeneral.Text = cli.Rows(0)(7)
                End If
            Catch ex As Exception
                MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarNotaCreditoXIdCliente()
            Try
                dgvNotaCredito.DataSource = _objetoNotaCredito.SeleccionarNotaCreditoXIdCliente(_tipoCon, lblIdClienteGeneral.Text)
                dgvNotaCredito.AutoResizeColumns()
                dgvNotaCredito.AutoResizeRows()
            Catch
                dgvNotaCredito.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarNotaCreditoXNroNotaCredito()
            Try
                dgvNotaCredito.DataSource = _objetoNotaCredito.SeleccionarNotaCreditoVentaXNumeroNotaCredito(_tipoCon, txtNumeroFacturaBuscar.Text)
                dgvNotaCredito.AutoResizeColumns()
                dgvNotaCredito.AutoResizeRows()
            Catch
                dgvNotaCredito.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarPagosFacturaVenta()
            Try
                dgvPagosFacturaVenta.DataSource = _objetoPagosFacturaVenta.SeleccionarPagosFacturaVentaXIdFactura(_tipoCon, _idFacturaVenta) 
            Catch
                dgvPagosFacturaVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub ActualizarValoresPagos()
            Try
                Dim saldo As Decimal = dgvPagosFacturaVenta.Rows(0).Cells("SALDO").Value
                For i = 0 To dgvPagosFacturaVenta.Rows.Count - 1
                    If _total = CDec(dgvPagosFacturaVenta.Rows(i).Cells("MONTO").Value) And dgvPagosFacturaVenta.Rows(i).Cells("FORMA PAGO").Value = "NOTA DE CRÉDITO" Then
                        dgvPagosFacturaVenta.Rows(i).Cells("ESTADO").Value = 0 ' anula el pago correspondiente a la nota de crédito
                    End If

                    If CDec(dgvPagosFacturaVenta.Rows(i).Cells("ESTADO").Value) <> 0 And CDec(dgvPagosFacturaVenta.Rows(i).Cells("MONTO").Value) > 0 Then
                        saldo -= CDec(dgvPagosFacturaVenta.Rows(i).Cells("MONTO").Value) ' calcula el nuevo saldo
                        dgvPagosFacturaVenta.Rows(i).Cells("SALDO").Value = saldo ' asigna el nuevo saldo
                    End If
                Next 
            Catch ex As Exception
                MsgBox("Error calcular pagos" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Error")
            End Try
        End Sub
        Private Sub dgvNotaCredito_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotaCredito.CellContentClick
            If e.ColumnIndex = chk.Index Then
                If CBool(dgvNotaCredito.CurrentCell.EditedFormattedValue) Then
                    If _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvNotaCredito.CurrentRow.Cells(16).Value) < 0.01 Then
                        If Not _notSelect.Contains(dgvNotaCredito.CurrentCell.RowIndex) Then _notSelect.Add(dgvNotaCredito.CurrentCell.RowIndex)
                        MsgBox("ESTA FACTUARA YA HA SIDO CANCELADA" & vbNewLine & "NO SE PUEDE ANULAR", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                        'Else
                        '    Dim si = _objetoPagosFacturaVenta.SeleccionarPagosActivoXIdComprobante(_tipoCon, CLng(dgvNotaCredito.CurrentRow.Cells(17).Value))
                        '    If si.Rows.Count > 1 Or si.Rows(0)(2) > 1 Then
                        '        If Not _notSelect.Contains(dgvNotaCredito.CurrentCell.RowIndex) Then _notSelect.Add(dgvNotaCredito.CurrentCell.RowIndex)
                        '        MsgBox("ESTA FACTURA YA REGISTRA PAGOS. ANULE PRIMERO LOS PAGOS CORRESPONDIENTES O LA FACTURA NO SERÁ ANULADA!", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
                        '    End If
                    End If
                End If
            End If
            dgvNotaCredito.EndEdit()
        End Sub
        Private Sub dgvFacturaVenta_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotaCredito.CellEndEdit
            For Each row As DataGridViewRow In From row1 As DataGridViewRow In dgvNotaCredito.Rows Where _notSelect.Contains(row1.Index)
                row.Cells(0).Value = False
            Next
            _notSelect.Clear()
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            dgvNotaCredito.EndEdit()
            Dim sel = dgvNotaCredito.Rows.Cast(Of DataGridViewRow)().Any(Function(row) CBool(row.Cells(0).EditedFormattedValue))
            If Not sel Then
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN REGISTRO!", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If MessageBox.Show("¿ESTA SEGURA QUE DESEA ANULAR LOS REGISTROS SELECCIONADOS?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            _sqlCommands.Clear()

            ActualizarEstadoNotaCredito()
            ActualizarPagosFacturaVenta()
            AnularAsientoLibroDiarioXNumeroRegistro()


            Dim nombreU As String = "NOTA-CREDITO-ANULADA " & Username
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then ToolStripMenuItem1_Click(Nothing, Nothing)
            MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

        End Sub
        Private Sub ActualizarEstadoNotaCredito()
            For i = 0 To dgvNotaCredito.RowCount - 1
                If CBool(dgvNotaCredito.Rows(i).Cells(0).Value) Then ' Si la fila de la grilla esta checkeada 
                    With _objetoNotaCredito
                        .IdNotaCredito = dgvNotaCredito.Rows(i).Cells(1).Value
                        .EstadoNotaCredito = 0
                    End With
                    _sqlCommands.Add(_objetoNotaCredito.ActualizarEstadoNotaCreditoVenta)
                End If
            Next
        End Sub 
        Private Sub ActualizarPagosFacturaVenta()
            For i = 0 To dgvNotaCredito.RowCount - 1
                If CBool(dgvNotaCredito.Rows(i).Cells(0).Value) Then ' Si la fila de la grilla esta checkeada 

                    _idFacturaVenta = dgvNotaCredito.CurrentRow.Cells.Item(16).Value ' obtiene la factura a la que se hizo la nota de credito
                    _total = dgvNotaCredito.Rows(i).Cells(14).Value ' actualiza el total de la NC a anular

                    CargarPagosFacturaVenta() ' carga los pagos de la factura
                    ActualizarValoresPagos() ' calcula los nuevos valores y saldos

                    For n = 0 To dgvPagosFacturaVenta.Rows.Count - 1 ' recorre los pagos para actualizarlos
                        If dgvPagosFacturaVenta.Rows(n).Cells("ID INGRESO").Value.ToString() <> "..." And dgvPagosFacturaVenta.Rows(n).Cells("ID INGRESO").Value.ToString() <> "0" Then
                            With _objetoPagosFacturaVenta
                                '.IdPagoFactura = dgvPagosFacturaVenta.Rows(n).Cells("ID").Value
                                '.FechaPagoFactura = dgvPagosFacturaVenta.Rows(n).Cells("FECHA").Value
                                '.NumeroPagoFactura = dgvPagosFacturaVenta.Rows(n).Cells("NUMERO").Value
                                '.FormaPagoFactura = dgvPagosFacturaVenta.Rows(n).Cells("FORMA PAGO").Value
                                '.MontoPagoFactura = dgvPagosFacturaVenta.Rows(n).Cells("MONTO").Value
                                '.SaldoPagoFactura = dgvPagosFacturaVenta.Rows(n).Cells("SALDO").Value
                                '.EstadoPagoFactura = dgvPagosFacturaVenta.Rows(n).Cells("ESTADO").Value
                                '.IdFactura = dgvPagosFacturaVenta.Rows(n).Cells("ID FACTURA").Value
                                '.IdCliente = dgvPagosFacturaVenta.Rows(n).Cells("ID CLIENTE").Value
                                .IdComprobanteIngreso = dgvPagosFacturaVenta.Rows(n).Cells("ID INGRESO").Value
                                '.ActualizarRegistroPagosFacturaVenta()
                            End With
                            _sqlCommands.Add(_objetoPagosFacturaVenta.AnularPagosFacturaVentaByIdComprobanteIngresos)
                        End If
                       
                    Next
                End If
            Next
        End Sub 
        Private Sub AnularAsientoLibroDiarioXNumeroRegistro()
            Dim numerRegistro As Int64
            For i = 0 To dgvNotaCredito.RowCount - 1
                If CBool(dgvNotaCredito.Rows(i).Cells(0).Value) Then ' Si la fila de la grilla esta checkeada 
                    numerRegistro = _objetoNumeroRegistroAsientoNotaCredito.BuscarNumeroRegistroAsientoPorIdNotaCredito(_tipoCon, dgvNotaCredito.Rows(i).Cells(1).Value)
                    With _objetoAsientoLibroDiario
                        .NumeroRegistroAsiento = numerRegistro 
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXNumeroRegistro)
                End If
            Next
        End Sub
         
    End Class
End Namespace