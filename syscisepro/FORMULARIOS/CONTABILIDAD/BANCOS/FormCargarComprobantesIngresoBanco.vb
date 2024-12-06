Imports System.Data
Imports System.Data.OleDb
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ProcesosSql
Imports Excel = Microsoft.Office.Interop.Excel
Imports Krypton.Toolkit


Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormCargarComprobantesIngresoBanco
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
        Public UserName As String


        Dim objetoPlanCuentas As New ClassPlanDeCuentas
        Dim objetoLibroDiario As New ClassLibroDiario
        Dim objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        Dim objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        Dim objetoNumeroRegistroAsientoComprobanteIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso
        Dim objetoComprobanteIngresoBancos As New ClassComprobanteIngresoBanco
        Dim objetoChequeRecibido As New ClassChequesRecibidosCxc
        Dim objetoBancos As New ClassBancos
        Dim objetoCuentaBancos As New ClassCuentasBancos
        Dim objetoFacturaVenta As New ClassFacturaVenta
        Dim objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        Dim objetoClienteGeneral As New ClassClienteGeneral

        'Dim _sqlCommands As List(Of SqlCommand)
        Public validarimportacion As Integer = 0
        Dim validarNumeroFactura As Integer = 0
        Dim _sqlCommands As List(Of SqlCommand)
        Public varIdLibroDiario As Int64 

        Private Sub FormCargarComprobantesIngresoBanco_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            '_sqlCommands = New List(Of SqlCommand)
            dgvComprobantesEgresoBanco.Font = New System.Drawing.Font("Roboto", 8, FontStyle.Regular)
            autocompletarPlanCuentas()
            llenarComboBancos()
            _sqlCommands = New List(Of SqlCommand)
            dgvComprobantesEgresoBanco.ContextMenuStrip = ContextMenuStripClicDerecho 'Asigno a la propiedad contextMenuStrip del dgv el menu creado para el clic derecho
        End Sub
        Public Sub autocompletarPlanCuentas()
            Try
                txtCuentaDebe.AutoCompleteCustomSource = objetoPlanCuentas.Autocompletar(_tipoCon)
                txtCuentaDebe.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txtCuentaDebe.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
                txtCuentaDebe.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Public Sub llenarComboBancos()
            Try
                Dim data = objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbBancos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedValueChanged
            llenarComboCuentasBancos()
        End Sub
        Public Sub llenarComboCuentasBancos()
            Try
                Dim data = objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, CInt(cmbBancos.SelectedValue))
                cmbCuentaBancos.DataSource = data
                cmbCuentaBancos.DisplayMember = data.Columns(1).ToString
                cmbCuentaBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbCuentaBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvComprobantesEgresoBanco_MouseDown(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles dgvComprobantesEgresoBanco.MouseDown
            If e.Button <> MouseButtons.Right Then Return
            dgvComprobantesEgresoBanco.Rows(dgvComprobantesEgresoBanco.CurrentCell.RowIndex.ToString()).Selected = True
        End Sub
        Private Sub ToolStripMenuItemEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItemEliminar.Click
            If dgvComprobantesEgresoBanco.SelectedRows.Count <> 1 Then

                KryptonMessageBox.Show("Debe seleccionar sólo una fila!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return
            End If

            Dim lsMensage As String = "¿Esta seguro de querer eliminar este Registro" & vbCrLf & dgvComprobantesEgresoBanco.CurrentRow().Cells(2).Value.ToString()
            'If MessageBox.Show(lsMensage, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification) = DialogResult.No Then
            If KryptonMessageBox.Show(lsMensage, "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If
                dgvComprobantesEgresoBanco.Rows.RemoveAt(dgvComprobantesEgresoBanco.CurrentRow.Index)

            KryptonMessageBox.Show("Fila eliminada", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
        End Sub
        Private Sub txtCuentaDebe_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaDebe.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                Dim cad = txtCuentaDebe.Text.Trim().Split("-")
                lblCodigoCta.Text = cad(0)
            Catch ex As Exception
                lblCodigoCta.Text = "0"

                KryptonMessageBox.Show("Error al seleccionar la cuenta! " & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Try
                ofdSeleccionarArchivo.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
                ofdSeleccionarArchivo.Title = "Seleccione el archivo de Excel"
                If ofdSeleccionarArchivo.ShowDialog() = DialogResult.OK Then
                    txtRutaArchivo.Text = ofdSeleccionarArchivo.FileName
                    ImportarArchivoDeExcel(txtRutaArchivo.Text)
                    validarNumeroFacturaCanceladas()
                End If
            Catch ex As Exception

                KryptonMessageBox.Show("Error al seleccionar el archivo! " & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
        Private Sub ImportarArchivoDeExcel(ByVal archivoImportar As String)
            'Dim Conexion As OleDbConnection
            'Dim DtSet As DataSet
            'Dim misqlDa As OleDbDataAdapter
            'Dim Enlace As BindingSource
            'Dim Consulta As String
            Dim excelApp As New Excel.Application()
            Dim workbook As Excel.Workbook = Nothing
            Dim worksheet As Excel.Worksheet = Nothing
            Dim Range As Excel.Range = Nothing

            Try
                'Consulta = ""
                'Conexion = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & archivoImportar & "';Extended Properties=Excel 12.0;")
                'Conexion.Open()
                'Consulta = "select FORMA_PAGO, BANCO_CHEQUE_RECIBIDO, CTA_CHEQUE_RECIBIDO, NUMERO_CHEQUE_RECIBIDO, FECHA, CLIENTE, RAZON, NUMERO_FACTURA, VALOR, BANCO_DEPOSITO, CTA_DEPOSITO from [COMPROBANTE_INGRESO$]"
                'misqlDa = New OleDbDataAdapter(Consulta, Conexion)
                'DtSet = New DataSet()
                'Enlace = New BindingSource()
                'misqlDa.Fill(DtSet, "COMPROBANTE_INGRESO")
                'Enlace.DataSource = DtSet
                'Enlace.DataMember = "COMPROBANTE_INGRESO"
                'dgvComprobantesEgresoBanco.DataSource = Enlace
                'Conexion.Close()
                workbook = excelApp.Workbooks.Open(archivoImportar)
                worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
                Range = worksheet.UsedRange

                Dim dt As New DataTable()

                For col = 1 To Range.Columns.Count
                    dt.Columns.Add(New DataColumn(Range.Cells(1, col).Value))
                Next

                For row = 2 To Range.Rows.Count
                    Dim dr As DataRow = dt.NewRow()
                    For col = 1 To Range.Columns.Count
                        dr(col - 1) = Range.Cells(row, col).Value
                    Next
                    dt.Rows.Add(dr)
                Next

                dgvComprobantesEgresoBanco.DataSource = dt

                validarimportacion = 1
            Catch ex As Exception
                'MsgBox("LAS COLUMNAS O EL NOMBRE DE LA HOJA NO COINCIDEN. POR FAVOR REVISE QUE EL FORMATO SEA EL ESTABLECIDO." & vbNewLine & " " & vbNewLine & "NOMBRE DE LA HOJA:  COMPROBANTE_INGRESO" & vbNewLine & " " & vbNewLine & "COLUMNAS: FORMA_PAGO,  BANCO_CHEQUE_RECIBIDO,  CTA_CHEQUE_RECIBIDO,  NUMERO_CHEQUE_RECIBIDO,  FECHA,CLIENTE,  RAZON,  NUMERO_FACTURA,  VALOR,  BANCO_DEPOSITO,  CTA_DEPOSITO", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Las columnas o el nombre de la hoja no coinciden. por favor revise que el formato sea el establecido." & vbNewLine & " " & vbNewLine & "Nombre de la hoja:  comprobante_ingreso" & vbNewLine & " " & vbNewLine & "Columnas: forma_pago,  banco_cheque_recibido,  cta_cheque_recibido,  numero_cheque_recibido,  fecha,cliente,  razon,  numero_factura,  valor,  banco_deposito,  cta_deposito" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                validarimportacion = 0
            End Try
        End Sub
        Public Sub validarNumeroFacturaCanceladas()
            validarNumeroFactura = 1
            For indice = 0 To dgvComprobantesEgresoBanco.Rows.Count - 1
                dgvFacturaVenta.DataSource = objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value)
                If dgvFacturaVenta.Rows.Count > 0 Then
                    If objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.Rows(0).Cells(0).Value.ToString) = 0 Then
                        'MsgBox("LA FACTURA NÚMERO : " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString & vbNewLine & "YA ESTA CANCELADA", MsgBoxStyle.Exclamation, "Mensaje de validación")
                        KryptonMessageBox.Show("La factura número : " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString & vbNewLine & "YA ESTA CANCELADA", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        dgvComprobantesEgresoBanco.Rows(indice).DefaultCellStyle.BackColor = Color.Salmon
                        validarNumeroFactura = 0
                    End If
                Else
                    'MsgBox("LA FACTURA NÚMERO : " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString & vbNewLine & "NO ESTA REGISTRADA", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("La factura número : " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString & vbNewLine & "NO ESTA REGISTRADA", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    dgvComprobantesEgresoBanco.Rows(indice).DefaultCellStyle.BackColor = Color.Salmon
                End If
            Next
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtRutaArchivo.Text <> "" And dgvComprobantesEgresoBanco.Rows.Count > 0 Then
                If txtCuentaDebe.Text <> "" And lblCodigoCta.Text <> 0 Then
                    If validarimportacion = 1 Then
                        If validarBlancosComprobantesIngreso() Then
                            validarNumeroFacturaCanceladas()
                            If validarNumeroFactura = 1 Then

                                '_sqlCommands.Clear()

                                ' ID LIBRO DIARIO
                                varIdLibroDiario = objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                                guardarGeneralComprobanteIngresoBancos()

                                'txtRutaArchivo.Text = ""
                                'txtCuentaDebe.Text = ""
                                'lblCodigoCta.Text = "0"

                                Dim User As String = "Carga de Comprobante de Ingreso por:" + UserName

                                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, User)
                                If res(0) Then
                                    txtRutaArchivo.Text = ""
                                    txtCuentaDebe.Text = ""
                                    lblCodigoCta.Text = "0"
                                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                                Else
                                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                    Return
                                End If
                                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")


                            Else

                                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "Existen facturas ya canceladas en el archivo importado.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                            End If
                        Else

                            KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "Existen datos en blanco en el archivo importado.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    Else

                        KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "El archivo seleccionado no se cargo de forma correcta." & vbNewLine & "POR FAVOR REVISE EL FORMATO.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                Else

                    KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No se ha seleccionado una cta. contable.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
            Else
                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No se han cargado ningún archivo.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Public Function validarBlancosComprobantesIngreso() As Boolean
            Dim nulo As Integer = 1 ' si es nulo = 0 / no es nulo = 1
            For indiceFila = 0 To dgvComprobantesEgresoBanco.RowCount - 1
                For indiceColumna = 0 To dgvComprobantesEgresoBanco.ColumnCount - 1
                    If dgvComprobantesEgresoBanco.Rows(indiceFila).Cells(indiceColumna).Value Is DBNull.Value Then
                        nulo = 0
                        dgvComprobantesEgresoBanco.Rows(indiceFila).DefaultCellStyle.BackColor = Color.Salmon
                    End If
                Next
            Next
            Return nulo = 1
        End Function
        Public Sub guardarGeneralComprobanteIngresoBancos()

            Dim idComprobanteIngreso = objetoComprobanteIngresoBancos.BuscarMayorIdComprobanteIngresoBancos(_tipoCon) + 1
            Dim _idCheque = objetoChequeRecibido.BuscarMayorIdChequeRecibidoCxc(_tipoCon) + 1
            Dim _idPagoFactura = objetoPagosFacturaVenta.BuscarMayorIdPagoFacturaVenta(_tipoCon) + 1
            Dim nRegistroNuevo = objetoNumeroRegistro.BuscarMayorNumeroRegistro(_tipoCon) + 1
            Dim nRegistroAnterior = objetoNumeroRegistro.BuscarMayorNumeroAnterior(_tipoCon) + 1
            Dim varIdAsiento = objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1

            For indice = 0 To dgvComprobantesEgresoBanco.Rows.Count - 1
                dgvComprobantesEgresoBanco.ClearSelection()
                dgvComprobantesEgresoBanco.Rows(indice).Selected = True

                ' tabla COMPROBANTE_INGRESO_BANCOS
                With objetoComprobanteIngresoBancos
                    .Id = idComprobanteIngreso
                    .FechaComprobanteIngreso = dgvComprobantesEgresoBanco.Rows(indice).Cells(4).Value
                    .NumeroFactura = "FACT: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString + ";"
                    dgvFacturaVenta.DataSource = objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value)
                    If dgvFacturaVenta.Rows.Count > 0 Then
                        .IdCliente = objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, dgvFacturaVenta.Rows(0).Cells(4).Value)
                    Else
                        .IdCliente = 0
                    End If
                    .ActividadComprobanteIngreso = "1010106"
                    .ConceptoComprobanteIngreso = txtCuentaDebe.Text.Trim().Split("-")(1).Trim
                    .FormaPagoComprobanteIngreso = dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value
                    .ObservacionesComprobanteIngreso = dgvComprobantesEgresoBanco.Rows(indice).Cells(6).Value
                    .ValorComprobanteIngreso = dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value
                    .NumeroDepositoComprobanteIngreso = "0"
                    .EstadoComprobanteIngreso = 1
                    .IdProvincias = "7"
                    .IdCiudad = "58"
                    .IdParroquias = "287"
                    .IdCentro = 2
                    .IdBancos = CInt(cmbBancos.SelectedValue)
                    .IdCuentaBancos = CInt(cmbCuentaBancos.SelectedValue)
                    .NuevoRegistroComprobanteIngresoBancos(_tipoCon)
                End With
                '_sqlCommands.Add(objetoComprobanteIngresoBancos.NuevoRegistroComprobanteIngresoBancos())

                ' guardar tabla CHEQUES_RECIBIDOS
                If dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value = "CHE" Then
                    With objetoChequeRecibido
                        .IdCheque = _idCheque
                        .FechaEmision = dgvComprobantesEgresoBanco.Rows(indice).Cells(4).Value
                        If dgvFacturaVenta.Rows.Count > 0 Then
                            .Titular = dgvFacturaVenta.Rows(0).Cells(5).Value
                        Else
                            .Titular = dgvComprobantesEgresoBanco.Rows(indice).Cells(5).Value
                        End If
                        .Banco = dgvComprobantesEgresoBanco.Rows(indice).Cells(1).Value
                        .CtaCteCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(2).Value
                        .NumeroCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(3).Value
                        .Valor = dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value
                        .Estado = 1
                        .IdComprobanteIngreso = idComprobanteIngreso
                        If dgvFacturaVenta.Rows.Count > 0 Then
                            .IdClienteGeneral = objetoClienteGeneral.BuscarIdClienteXNombreComercial(_tipoCon, dgvFacturaVenta.Rows(0).Cells(4).Value)
                        Else
                            .IdClienteGeneral = 0
                        End If
                        .NuevoRegistroChequeRecibidoCxc(_tipoCon)
                    End With
                    '_sqlCommands.Add(objetoChequeRecibido.NuevoRegistroChequeRecibidoCxc())
                End If

                ' guardar tabla PAGOS_FACTURA_VENTA
                If dgvFacturaVenta.Rows.Count > 0 Then
                    With objetoPagosFacturaVenta
                        .IdPagoFactura = _idPagoFactura
                        .FechaPagoFactura = dgvComprobantesEgresoBanco.Rows(indice).Cells(4).Value
                        .NumeroPagoFactura = .BuscarMayorNumeroPagoFcturaVentaXIdFactura(_tipoCon, dgvFacturaVenta.Rows(0).Cells(0).Value) + 1
                        .FormaPagoFactura = dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value
                        .MontoPagoFactura = dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value
                        .SaldoPagoFactura = CType(.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.Rows(0).Cells(0).Value), Decimal) - CType(dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value, Decimal)
                        .EstadoPagoFactura = 1
                        .IdFactura = dgvFacturaVenta.Rows(0).Cells(0).Value
                        .IdCliente = objetoClienteGeneral.IdCliente
                        .NuevoRegistroPagosFacturaVenta(_tipoCon)
                    End With
                    '_sqlCommands.Add(objetoPagosFacturaVenta.NuevoRegistroPagosFacturaVenta())
                End If

                ' GUARDAR TABLA NUMERO_REGISTRO
                With objetoNumeroRegistro
                    .NumeroRegistro = nRegistroNuevo
                    .NumeroAnterior = nRegistroAnterior
                    .NuevoNumeroRegistroAsientoLibroDiario(_tipoCon)
                End With
                '_sqlCommands.Add(objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                ' GUARDAR TABLA ASIENTOS_LIBRO_DIARIO 'DEBE'
                With objetoAsientoLibroDiario
                    .IdAsiento = varIdAsiento
                    .FechaAsiento = dgvComprobantesEgresoBanco.Rows(indice).Cells(4).Value
                    .CodigoCuentaAsiento = objetoCuentaBancos.BuscarCodigoPlanXIdCuenta(_tipoCon, CInt(cmbCuentaBancos.SelectedValue)).Trim
                    .NombreCuentaAsiento = objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento).Trim
                    .ConceptoAsiento = "COMPROBANTE DE INGRESO BANCOS"
                    If dgvFacturaVenta.Rows.Count > 0 Then
                        .DetalleTransaccionAsiento = "ID: " + idComprobanteIngreso.ToString + " CLIENTE: " + dgvFacturaVenta.Rows(0).Cells(4).Value + " FACTURA NRO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString + " FORMA PAGO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value.ToString
                    Else
                        .DetalleTransaccionAsiento = "ID: " + idComprobanteIngreso.ToString + " CLIENTE: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(5).Value + " FACTURA NRO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString + " FORMA PAGO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value.ToString
                    End If
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = "GERENCIA ADMINISTRATIVA-FINANCIERA"
                    .ValorDebeAsiento = dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value
                    .ValorHaberAsiento = "0.00"
                    .NumeroRegistroAsiento = objetoNumeroRegistro.NumeroRegistro
                    .DebeHaberAsiento = 1   ' DEBE=1 / HABER=2 
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = varIdLibroDiario
                    .EstadoMayorAsiento = 0
                    .NuevoRegistroAsientoLibroDiario(_tipoCon)
                End With
                '_sqlCommands.Add(objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                ' GUARDAR TABLA ASIENTOS_LIBRO_DIARIO 'HABER'
                varIdAsiento += 1
                With objetoAsientoLibroDiario
                    .IdAsiento = varIdAsiento
                    .FechaAsiento = dgvComprobantesEgresoBanco.Rows(indice).Cells(4).Value
                    .CodigoCuentaAsiento = lblCodigoCta.Text.Trim
                    .NombreCuentaAsiento = txtCuentaDebe.Text.Trim().Split("-")(1).Trim
                    .ConceptoAsiento = "COMPROBANTE DE INGRESO BANCOS"
                    If dgvFacturaVenta.Rows.Count > 0 Then
                        .DetalleTransaccionAsiento = "ID: " + idComprobanteIngreso.ToString + " CLIENTE: " + dgvFacturaVenta.Rows(0).Cells(4).Value + " FACTURA NRO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString + " FORMA PAGO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value.ToString
                    Else
                        .DetalleTransaccionAsiento = "ID: " + idComprobanteIngreso.ToString + " CLIENTE: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(5).Value + " FACTURA NRO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString + " FORMA PAGO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value.ToString
                    End If
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = "GERENCIA ADMINISTRATIVA-FINANCIERA"
                    .ValorDebeAsiento = "0.00"
                    .ValorHaberAsiento = dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value
                    .NumeroRegistroAsiento = objetoNumeroRegistro.NumeroRegistro
                    .DebeHaberAsiento = 2   ' DEBE=1 / HABER=2 
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = varIdLibroDiario
                    .EstadoMayorAsiento = 0
                    .NuevoRegistroAsientoLibroDiario(_tipoCon)
                End With
                '_sqlCommands.Add(objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                ' GUARDAR TABLA NUMERO_REGISTRO_ASIENTO_
                With objetoNumeroRegistroAsientoComprobanteIngreso
                    .IdComprobanteIngreso = idComprobanteIngreso
                    .IdLibro = varIdLibroDiario
                    .IdAsiento = varIdAsiento
                    .NumeroRegistro = objetoNumeroRegistro.NumeroRegistro
                    .NuevoRegistroNumeroRegistroAsientoComprobanteIngreso(_tipoCon)
                End With
                '_sqlCommands.Add(objetoNumeroRegistroAsientoComprobanteIngreso.NuevoRegistroNumeroRegistroAsientoComprobanteIngreso())

                idComprobanteIngreso += 1
                _idCheque += 1
                _idPagoFactura += 1
                varIdAsiento += 1
                nRegistroNuevo += 1
                nRegistroAnterior += 1
            Next
        End Sub
    End Class
End Namespace