Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS 
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmGenerarDebitoBancarioClientes
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

        ReadOnly _objPlanilla As New ClassPlanillaCobrosPagos
        ReadOnly _objDetaPlanilla As New ClassDetallePlanillaCobrosPagos
        Dim _sqlCommands As List(Of SqlCommand)

        Dim _tipoGuardar As Integer

        Private Sub FrmGenerarDebitoBancarioClientes_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    Label8.ForeColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label9.ForeColor = Color.White
                    Label9.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    lblComprobante.ForeColor = My.MySettingsProperty.Settings.ColorAsenava 
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDebitos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvHoy.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    Label9.ForeColor = Color.White
                    Label9.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label8.ForeColor = My.MySettingsProperty.Settings.ColorSeportpac 
                    lblComprobante.ForeColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDebitos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvHoy.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    Label9.ForeColor = Color.White
                    Label9.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label8.ForeColor = My.MySettingsProperty.Settings.ColorCisepro
                    lblComprobante.ForeColor = My.MySettingsProperty.Settings.ColorCisepro 
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    dgvComprobantesIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDebitos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobate.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvHoy.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            dgvComprobantesIngreso.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDebitos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobate.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvHoy.Font = New Font("Roboto", 8, FontStyle.Regular)
            txtBeneficiario.Text = ValidationForms.NombreCompany(_tipoCon)
            cbxTipoCuenta.SelectedIndex = 0
            cbxTipoNegociacion.SelectedIndex = 0
            _tipoGuardar = 0
            dtpFiltroDesde.Value = DateTime.Now
        End Sub

        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmNuevo.Click
            dtpFechaProceso.Enabled = True
            dtpFechaVence.Enabled = True
            cbxTipoCuenta.Enabled = True
            txtNumCuenta.Enabled = True
            cbxTipoNegociacion.Enabled = True
            txtObservacion.Enabled = True

            dgvHoy.Enabled = False
            dgvDebitos.Rows.Clear()
            dgvDebitos.ReadOnly = False
            dgvDebitos.Columns(1).ReadOnly = True
            dgvDebitos.Columns(2).ReadOnly = True
            dgvDebitos.Columns(13).ReadOnly = True
            dgvDebitos.Columns(14).ReadOnly = True
            dgvDebitos.Columns(15).ReadOnly = True
            dgvDebitos.Columns(16).ReadOnly = True

            dtpFiltroDesde.Enabled = False
            btnAdd.Enabled = True
            btnRemove.Enabled = True

            lblComprobante.Text = _objPlanilla.BuscarMayorIdPlanilla(_tipoCon) + 1

            _tipoGuardar = 1 ' nuevo

            CalcularTotales()

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmEditar.Enabled = False 
            tsmCancelar.Enabled = True
        End Sub

        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmGuardar.Click
            If lblComprobante.Text.Trim.Equals("S/N") Or txtBeneficiario.Text.Trim.Length = 0 Or _
               txtTipoServicio.Text.Trim.Length = 0 Or txtNumCuenta.Text.Trim.Length = 0 Or _
               txtReferencia.Text.Trim.Length = 0 Or dgvDebitos.RowCount = 0 Then
                MessageBox.Show("Por favor llene la información de la planilla para guardar", "VALIDACIÓN DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                If MessageBox.Show("Seguro que desea guardar la planilla actual?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    _sqlCommands.Clear()

                    If _tipoGuardar = 1 Then ' nuevo

                        With _objPlanilla
                            .IdPlanilla = _objPlanilla.BuscarMayorIdPlanilla(_tipoCon) + 1
                            .NumComprobante = .IdPlanilla
                            .Beneficiario = txtBeneficiario.Text.Trim
                            .TipoServicio = txtTipoServicio.Text.Trim
                            .FechaProceso = dtpFechaProceso.Value
                            .FechaVence = dtpFechaVence.Value
                            .TipoCuenta = cbxTipoCuenta.SelectedItem.ToString
                            .NumCuenta = txtNumCuenta.Text.Trim
                            .Referencia = txtReferencia.Text.Trim
                            .TipoNegociacion = cbxTipoNegociacion.SelectedItem.ToString
                            .CantCuentas = lblCant.Text
                            .TotCuentas = lblTotal.Text
                            .Estado = 1
                            .Observacion = txtObservacion.Text.Trim 
                        End With
                        _sqlCommands.Add(_objPlanilla.NuevoRegistroPlanillaCobrosPagos())


                        Dim iddet = _objDetaPlanilla.BuscarMayorIdDetallePlanilla(_tipoCon) + 1
                        For Each row As DataGridViewRow In dgvDebitos.Rows
                            With _objDetaPlanilla
                                .IdPlanilla = _objPlanilla.IdPlanilla
                                .IdDetallePlanilla = iddet
                                .TipoDocum = row.Cells("TipDoc").Value.ToString
                                .CiRuc = row.Cells("CiRuc").Value.ToString
                                .Ordenante = row.Cells("Ordenante").Value.ToString
                                .Contrato = row.Cells("Contrato").Value.ToString
                                .FormaPago = row.Cells("FormaPago").Value.ToString
                                .Banco = row.Cells("Banco").Value.ToString
                                .TipoCuenta = row.Cells("TipoCuenta").Value.ToString
                                .NumCuenta = row.Cells("NumCuenta").Value.ToString
                                .Valor = row.Cells("Valor").Value.ToString
                                .Submotivo = row.Cells("Motivo").Value.ToString
                                .Idfactura = row.Cells("IdFactura").Value.ToString
                                .Numfactura = row.Cells("NumFactura").Value.ToString
                                .Idcliente = row.Cells("IdCliente").Value.ToString
                                .Cliente = row.Cells("Cliente").Value.ToString 
                            End With
                            _sqlCommands.Add(_objDetaPlanilla.NuevoRegistroDetallePlanillaCobrosPagos())
                            iddet += 1
                        Next 
                        lblComprobante.Text = _objPlanilla.IdPlanilla

                    End If


                    If _tipoGuardar = 2 Then ' editar
                        With _objPlanilla
                            .IdPlanilla = lblComprobante.Text
                            .CantCuentas = lblCant.Text
                            .TotCuentas = lblTotal.Text
                            .Estado = 1
                            .Observacion = txtObservacion.Text.Trim
                        End With
                        _sqlCommands.Add(_objPlanilla.EditarRegistroPlanillaCobrosPagos())


                        _objDetaPlanilla.IdPlanilla = _objPlanilla.IdPlanilla
                        _sqlCommands.Add(_objDetaPlanilla.EliminarRegistroDetallePlanillaCobrosPagos())

                        Dim iddet = _objDetaPlanilla.BuscarMayorIdDetallePlanilla(_tipoCon) + 1
                        For Each row As DataGridViewRow In dgvDebitos.Rows
                            With _objDetaPlanilla
                                .IdPlanilla = _objPlanilla.IdPlanilla
                                .IdDetallePlanilla = iddet
                                .TipoDocum = row.Cells("TipDoc").Value.ToString
                                .CiRuc = row.Cells("CiRuc").Value.ToString
                                .Ordenante = row.Cells("Ordenante").Value.ToString
                                .Contrato = row.Cells("Contrato").Value.ToString
                                .FormaPago = row.Cells("FormaPago").Value.ToString
                                .Banco = row.Cells("Banco").Value.ToString
                                .TipoCuenta = row.Cells("TipoCuenta").Value.ToString
                                .NumCuenta = row.Cells("NumCuenta").Value.ToString
                                .Valor = row.Cells("Valor").Value.ToString
                                .Submotivo = row.Cells("Motivo").Value.ToString
                                .Idfactura = row.Cells("IdFactura").Value.ToString
                                .Numfactura = row.Cells("NumFactura").Value.ToString
                                .Idcliente = row.Cells("IdCliente").Value.ToString
                                .Cliente = row.Cells("Cliente").Value.ToString
                            End With
                            _sqlCommands.Add(_objDetaPlanilla.NuevoRegistroDetallePlanillaCobrosPagos())
                            iddet += 1
                        Next 
                    End If



                     
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                    If res(0) Then
                        dtpFechaProceso.Enabled = False
                        dtpFechaVence.Enabled = False
                        cbxTipoCuenta.Enabled = False
                        txtNumCuenta.Enabled = False
                        cbxTipoNegociacion.Enabled = False
                        txtObservacion.Enabled = False

                        dgvHoy.Enabled = True
                        dtpFiltroDesde.Enabled = True
                        dgvDebitos.Columns(0).Visible = False
                        dgvDebitos.ReadOnly = True
                        _tipoGuardar = 0

                        btnAdd.Enabled = False
                        btnRemove.Enabled = False

                        tsmNuevo.Enabled = True
                        tsmGuardar.Enabled = False
                        tsmEditar.Enabled = True 
                        tsmCancelar.Enabled = False

                        LoadPlanillasRecientes()
                    End If

                    MsgBox(If(res(0), res(1) & " Ahora puede generar el archivo BIZ!", res(1)), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

                End If
            End If
        End Sub
         
        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmCancelar.Click
            dtpFechaProceso.Enabled = False
            dtpFechaVence.Enabled = False
            cbxTipoCuenta.Enabled = False
            txtNumCuenta.Enabled = False
            cbxTipoNegociacion.Enabled = False
            txtObservacion.Enabled = False

            dgvHoy.Enabled = True
            dtpFiltroDesde.Enabled = True
            dgvDebitos.Columns(0).Visible = False
            dgvDebitos.ReadOnly = True
            _tipoGuardar = 0

            btnAdd.Enabled = False
            btnRemove.Enabled = False

            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            tsmEditar.Enabled = False 
            tsmCancelar.Enabled = False

            LoadPlanillasRecientes()

            dgvDebitos.Columns(0).Visible = False
        End Sub

        Private Sub dgvDebitos_DataError(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDebitos.DataError
            ' nothing
        End Sub

        Private Sub LoadPlanillasRecientes()
            Try
                dgvDebitos.Rows.Clear()
                Dim datos As DataTable = _objPlanilla.CargarPlanillaCobrosPagosRecientesPorFecha(_tipoCon, (dtpFiltroDesde.Value.Day.ToString & "-" & dtpFiltroDesde.Value.Month.ToString & "-" & dtpFiltroDesde.Value.Year.ToString & " 00:00:00"))
                dgvHoy.Rows.Clear()
                For Each row As DataRow In datos.Rows
                    dgvHoy.Rows.Add(row(0).ToString.Trim, row(1).ToString.Trim, row(2).ToString.Trim, row(3).ToString.Trim)
                Next
                dgvHoy.AutoResizeRows()
                'tsmProcesar.Enabled = dgvDebitos.RowCount > 0
            Catch ex As Exception
                dgvHoy.Rows.Clear()
                dgvHoy.DataSource = Nothing
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRemove.Click
            If dgvDebitos.RowCount > 0 Then
                dgvDebitos.Rows.Remove(dgvDebitos.SelectedRows(0))
            End If
            CalcularTotales()
        End Sub

        Private Sub btnGenerarExcel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGenerarExcel.Click
            If _tipoGuardar <> 0 Then
                MessageBox.Show("No se puede generar el archivo mientras está activa una opción de guardar o procesar", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If _tipoGuardar <> 0 Then
                MessageBox.Show("No ha seleccionado ninguna orden para generar el archivo!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                Dim fec = DateTime.Now
                Dim sfd = New SaveFileDialog()
                sfd.Filter = "Text Files (*.txt)|*.txt"
                sfd.FileName = "MACH_" & fec.Year & fec.Month & fec.Day & "_" & fec.Hour & fec.Minute & ".txt"

                If sfd.ShowDialog = DialogResult.OK Then
                    If File.Exists(sfd.FileName) = False Then
                        File.Create(sfd.FileName).Dispose()
                    End If

                    Dim objWriter As New StreamWriter(sfd.FileName, True)

                    For Each row As DataGridViewRow In dgvDebitos.Rows
                        Dim ba = ""
                        Dim b = Convert.ToInt32(row.Cells(8).Value.ToString.Trim.Split(" ")(0).Trim)
                        If b = 25 Then
                            ba = CompletarConEspacio(Convert.ToInt32(row.Cells(8).Value.ToString.Trim.Split(" ")(0).Trim), 3, False)
                        Else
                            ba = row.Cells(8).Value.ToString.Trim.Split(" ")(0).Trim
                        End If

                        objWriter.WriteLine(
                            "DET" & _
                            CompletarConCero(row.Index, 7, True) & _
                            CompletarConEspacio(row.Cells(4).Value, 15, False) & _
                            row.Cells(7).Value.ToString.Trim.Split(" ")(0).Trim & _
                            CompletarConEspacio("EC", 3, False) & _
                            ba & _
                            row.Cells(9).Value.ToString.Trim.Split(" ")(0).Trim & _
                            CompletarConEspacio(row.Cells(10).Value.ToString, 20, False) & _
                            "00" & _
                            "00" & _
                            CompletarConEspacio(row.Cells(5).Value.ToString, 40, False) & _
                            CompletarConEspacio(row.Cells(6).Value.ToString, 40, False) & _
                            "C" & _
                            "00000" & _
                            "000000" & _
                            "000000" & _
                            "00000000" & _
                            "0000" & _
                            CompletarConCero(row.Cells(11).Value.ToString.Replace(".", ""), 15, True) & _
                            "USD" & _
                            CompletarConEspacio("", 40, False) & _
                            row.Cells(3).Value.ToString.Trim.Split(" ")(0).Trim & _
                            CompletarConEspacio(row.Cells(4).Value.ToString, 14, False) & _
                            CompletarConEspacio("", 60, False) & _
                            CompletarConEspacio("", 10, False) & _
                            CompletarConEspacio("", 20, False) & _
                            CompletarConEspacio("", 15, False) & _
                            CompletarConEspacio("", 8, False) & _
                            CompletarConEspacio("", 10, False) & _
                            CompletarConEspacio("", 1, False) & _
                            CompletarConEspacio("", 7, False) & _
                            CompletarConEspacio("", 15, False) & _
                            CompletarConEspacio("", 4, False) & _
                            "05839" & _
                            CompletarConCero("", 15, False) & _
                            CompletarConCero("", 15, False) & _
                            CompletarConCero("", 15, False) & _
                            CompletarConCero("", 15, False) & _
                            cbxTipoNegociacion.Text.ToString.Trim.Split(" ")(0).Trim
                            )
                    Next

                    objWriter.Close()
                    MessageBox.Show("Archivo generado correctamente", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Ocurrió un problema al generar el archivo. Por favor, contácte al administrador!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAdd.Click
            Dim frm As New FrmBuscarClientesFacturaImpagaGeneral
            frm.TipoCox = TipoCox
            Try
                If frm.ShowDialog = vbOK Then
                    For Each row As DataGridViewRow In frm.dgvDebitos.SelectedRows ' 10, 12

                        Dim exist = dgvDebitos.Rows.Cast(Of DataGridViewRow)().Any(Function(old) old.Cells(11).Value.ToString.Trim.Equals(row.Cells(10).Value.ToString.Trim) And old.Cells(15).Value.ToString.Trim.Equals(row.Cells(12).Value.ToString.Trim))

                        If Not exist Then
                            Dim valor As Decimal

                            If CDbl(row.Cells(13).Value) <> CDbl(row.Cells(14).Value) Or CDbl(row.Cells(14).Value) <> CDbl(row.Cells(15).Value) Then
                                Dim res = New FrmSeleccionarDebito(row.Cells(1).Value, row.Cells(13).Value, row.Cells(14).Value, row.Cells(15).Value)
                                If res.ShowDialog() <> DialogResult.OK Then Return
                                valor = If(res.Boton = 1, CDec(res.Button1.Tag), If(res.Boton = 2, CDec(res.Button2.Tag), CDec(res.Button3.Tag)))
                            Else
                                valor = CDec(row.Cells(15).Value)
                            End If

                            dgvDebitos.Rows.Add(
                                False,
                                row.Cells(0).Value,
                                row.Cells(1).Value,
                                row.Cells(3).Value,
                                row.Cells(4).Value,
                                row.Cells(2).Value,
                                row.Cells(5).Value,
                                row.Cells(6).Value,
                                row.Cells(7).Value,
                                row.Cells(8).Value,
                                row.Cells(9).Value,
                                valor,
                                row.Cells(10).Value,
                                Nothing,
                                Nothing,
                                row.Cells(11).Value,
                                row.Cells(12).Value)
                        End If
                    Next

                    dgvDebitos.Sort(dgvDebitos.Columns(15), ListSortDirection.Ascending)
                End If
                CalcularTotales()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub dtpFiltroDesde_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpFiltroDesde.ValueChanged
            LoadPlanillasRecientes()
        End Sub

        Private Sub dgvHoy_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvHoy.SelectionChanged
            If dgvHoy.RowCount = 0 Or dgvHoy.CurrentRow Is Nothing Then Return
            Try
                Dim data = _objPlanilla.CargarPlanillaCobrosPagosPorId(_tipoCon, dgvHoy.CurrentRow.Cells(0).Value)

                lblComprobante.Text = data.Rows(0).Item("ID_PLANILLA")
                txtBeneficiario.Text = data.Rows(0).Item("BENEFICIARIO")
                txtTipoServicio.Text = data.Rows(0).Item("TIPO_SERVICIO")
                dtpFechaProceso.Value = data.Rows(0).Item("FECHA_PROCESO")
                dtpFechaVence.Value = data.Rows(0).Item("FECHA_VENCE")
                cbxTipoCuenta.SelectedItem = data.Rows(0).Item("TIPO_CUENTA")
                txtNumCuenta.Text = data.Rows(0).Item("NUM_CUENTA")
                txtReferencia.Text = data.Rows(0).Item("REFERENCIA")
                cbxTipoNegociacion.SelectedItem = data.Rows(0).Item("TIPO_NEGOCIACION")
                txtObservacion.Text = data.Rows(0).Item("OBSERVACION")

                dgvDebitos.Rows.Clear()
                Dim datos As DataTable = _objPlanilla.CargarDetallesPlanillaCobrosPagosPorId(_tipoCon, lblComprobante.Text.Trim)
                For Each row As DataRow In datos.Rows
                    Dim pro = row(15).ToString.Trim.Equals("1")

                    dgvDebitos.Rows.Add(pro, row(21).ToString, row(22).ToString, row(1).ToString, row(2).ToString, row(3).ToString, row(4).ToString,
                                        row(5).ToString, row(6).ToString, row(7).ToString, row(8).ToString,
                                        row(9).ToString, row(10).ToString, row(17).ToString, row(18).ToString, row(19).ToString, row(20).ToString)
                Next

                tsmEditar.Enabled = dgvDebitos.RowCount > 0

                dgvDebitos.AutoResizeRows()
                lblCant.Text = data.Rows(0).Item("CANT_CUENTAS")
                lblTotal.Text = data.Rows(0).Item("TOTAL_CUENTAS")

            Catch ex As Exception
                MessageBox.Show("Error al cargar planilla: " + ex.Message)
            End Try
        End Sub

        Private Sub CalcularTotales()
            Dim total = dgvDebitos.Rows.Cast(Of DataGridViewRow)().Aggregate(0.0, Function(current, row) current + CDec(row.Cells("Valor").Value))
            lblCant.Text = dgvDebitos.RowCount
            lblTotal.Text = total.ToString("N")
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            CargarComprobantesGenerados()
        End Sub

        Private Sub CargarComprobantesGenerados()
            Try
                dgvComprobantesIngreso.DataSource = Nothing
                dgvDetalleComprobate.DataSource = Nothing

                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"

                If chkTodos.Checked Then
                    dgvComprobantesIngreso.DataSource = _objPlanilla.SeleccionarPlanillaCobrosPagosxRengoFechas(_tipoCon, fechaDesde, fechaHasta)
                Else
                    If rbtNum.Checked Then
                        dgvComprobantesIngreso.DataSource = _objPlanilla.SeleccionarPlanillaCobrosPagosxNroComprobante(_tipoCon, txtNroComprobante.Text.Trim)
                    Else
                        dgvComprobantesIngreso.DataSource = _objPlanilla.SeleccionarPlanillaCobrosPagosxDetalle(_tipoCon, txtDetail.Text.Trim)
                    End If
                End If

                dgvComprobantesIngreso.AutoResizeColumns()
                dgvComprobantesIngreso.AutoResizeRows()
                dgvComprobantesIngreso.EditMode = DataGridViewEditMode.EditProgrammatically

            Catch ex As Exception
                dgvComprobantesIngreso.DataSource = Nothing
            End Try
        End Sub

        Private Sub dgvDebitos_CellBeginEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDebitos.CellBeginEdit
            If e.RowIndex > -1 Then
                If e.ColumnIndex = 0 Then
                    If Not String.IsNullOrEmpty(dgvDebitos.Rows(e.RowIndex).Cells("FecProceso").Value) Then
                        e.Cancel = True
                    End If
                End If
            End If
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

        Private Sub btnExportarComprobantes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarComprobantes.Click
            Try
                ExportarDatosExcel(dgvComprobantesIngreso, "COMPROBANTES DE COBROS / PAGOS BANCARIOS ")
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub btnExportarDetalleComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarDetalleComprobante.Click
            Try
                ExportarDatosExcel(dgvDetalleComprobate, "DETALLE DE COMPROABANTE DE COBROS / PAGOS BANCARIOS N°: " & CType(dgvComprobantesIngreso.CurrentRow.Cells.Item(0).Value, String))
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "PLANILLA COBROS / PAGOS BANCO MACHALA"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaProceso.Value.ToLongDateString() & "  AL " & dtpFechaVence.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1

                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosDiario.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvAsientosDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try             
        End Sub

        Private Sub dgvComprobantesIngreso_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesIngreso.SelectionChanged
            If dgvComprobantesIngreso.RowCount = 0 Or dgvComprobantesIngreso.CurrentRow Is Nothing Then Return
            CargarDetalleComprobante(dgvComprobantesIngreso.CurrentRow.Cells.Item(0).Value)
        End Sub

        Private Sub CargarDetalleComprobante(ByVal idcomprobante As String)
            Try
                dgvDetalleComprobate.DataSource = _objDetaPlanilla.SeleccionarDetallesComprobantesPlanillaCobrosPagosPorId(_tipoCon, idcomprobante)
                dgvDetalleComprobate.AutoResizeRows()
                dgvDetalleComprobate.AutoResizeColumns()

                dgvDetalleComprobate.Columns(0).Visible = False
                dgvDetalleComprobate.Columns(1).Width = 70
                dgvDetalleComprobate.Columns(2).Width = 150
                dgvDetalleComprobate.Columns(3).Width = 200

                dgvDetalleComprobate.Columns(4).Width = 80
                dgvDetalleComprobate.Columns(5).Width = 80
                dgvDetalleComprobate.Columns(6).Width = 80
                dgvDetalleComprobate.Columns(7).Width = 80
                dgvDetalleComprobate.Columns(8).Width = 80
                dgvDetalleComprobate.Columns(9).Width = 100
                dgvDetalleComprobate.Columns(10).Width = 100
                dgvDetalleComprobate.Columns(11).Width = 60
                dgvDetalleComprobate.Columns(12).Width = 200

                dgvDetalleComprobate.Columns(13).Visible = False
                dgvDetalleComprobate.Columns(14).Visible = False
                dgvDetalleComprobate.Columns(15).Visible = False
                dgvDetalleComprobate.Columns(16).Width = 100
                dgvDetalleComprobate.Columns(17).Visible = False

                dgvDetalleComprobate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            Catch ex As Exception
                dgvDetalleComprobate.DataSource = Nothing
            End Try
        End Sub

        Private Function CompletarConCero(ByVal cadena As String, ByVal longitudCadena As Int32, ByVal derecha As Boolean) As String
            Dim newCadena As String = cadena
            For i = 0 To (longitudCadena - cadena.Length) - 1
                If derecha Then
                    newCadena = "0" & newCadena
                Else
                    newCadena = newCadena & "0"
                End If
            Next
            Return newCadena
        End Function

        Private Function CompletarConEspacio(ByVal cadena As String, ByVal longitudCadena As Int32, ByVal derecha As Boolean) As String
            Dim newCadena As String = cadena
            For i = 0 To (longitudCadena - cadena.Length) - 1
                If derecha Then
                    newCadena = " " & newCadena
                Else
                    newCadena = newCadena & " "
                End If
            Next
            Return newCadena
        End Function

        Private Sub tsmEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEditar.Click
            dtpFechaProceso.Enabled = True
            dtpFechaVence.Enabled = True
            cbxTipoCuenta.Enabled = True
            txtNumCuenta.Enabled = True
            cbxTipoNegociacion.Enabled = True
            txtObservacion.Enabled = True

            dgvHoy.Enabled = False 
            dgvDebitos.ReadOnly = False 
            dgvDebitos.Columns(1).ReadOnly = True
            dgvDebitos.Columns(2).ReadOnly = True
            dgvDebitos.Columns(13).ReadOnly = True
            dgvDebitos.Columns(14).ReadOnly = True
            dgvDebitos.Columns(15).ReadOnly = True
            dgvDebitos.Columns(16).ReadOnly = True

            dtpFiltroDesde.Enabled = False
            btnAdd.Enabled = True
            btnRemove.Enabled = True
             
            _tipoGuardar = 2 ' editar

            CalcularTotales()

            tsmNuevo.Enabled = False
            tsmGuardar.Enabled = True
            tsmEditar.Enabled = False 
            tsmCancelar.Enabled = True
        End Sub
    End Class
End Namespace