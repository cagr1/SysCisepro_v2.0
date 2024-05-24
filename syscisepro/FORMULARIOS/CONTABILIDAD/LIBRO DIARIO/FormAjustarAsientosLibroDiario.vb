Imports System.Data.SqlClient
Imports System.Drawing 
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS 
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.REPORTES
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAjustarAsientosLibroDiario

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

        ReadOnly _objetoNumerico As New ClassNumerico
        ReadOnly _objetoDecimal As New ClassDecimal
        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoCentroCosto As New ClassCentroCosto 
        ReadOnly _objetoComprobanteEgresoBancos As New ClassComprobanteEgresoBanco
        ReadOnly _objetoComprobanteIngresoBancos As New ClassComprobanteIngresoBanco
        ReadOnly _objetoBanco As New ClassBancos
        ReadOnly _objetoCuentasBancos As New ClassCuentasBancos

        Private _parametroBusqueda As Integer = 0
        Private _botonseleccionado As Integer = 0
         
        Private Sub FormAjustarAsientosLibroDiario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoBuscado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvNumeroRegistroAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoBuscado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvNumeroRegistroAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoBuscado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvNumeroRegistroAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)

            CargarNumeroRegistroAsientoLibroDiario()
            CargarAsientoLibroDiario()

            dgvAsientosDiario.Visible = True
            dgvAsientoBuscado.Visible = False

            DeshabilitadoInicio()

            rbNumeroAsiento_CheckedChanged(Nothing, Nothing)

            LlenarComboCentroCosto()
            LlenarCuentasContables()

            LlenarComboBancos()
            LlenarComboCuentasBancos()
            cmbConcepto.SelectedIndex = 1
            txtNumeroAsientoBuscar.Focus()
        End Sub
        Private Sub CargarNumeroRegistroAsientoLibroDiario()
            Try
                dgvNumeroRegistroAsiento.DataSource = _objetoAsientoLibroDiario.SeleccionarNumeroRegistroAsientosLibroDiario(_tipoCon)
                dgvNumeroRegistroAsiento.Columns(0).HeaderText = "Nº ASIE."
                dgvNumeroRegistroAsiento.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNumeroRegistroAsiento.Columns(0).Width = 55

                dgvNumeroRegistroAsiento.Columns(1).HeaderText = "# TR"
                dgvNumeroRegistroAsiento.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNumeroRegistroAsiento.Columns(1).Width = 25

                dgvNumeroRegistroAsiento.Columns(2).HeaderText = "FECHA"
                dgvNumeroRegistroAsiento.Columns(2).DefaultCellStyle.Format = "d"
                dgvNumeroRegistroAsiento.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNumeroRegistroAsiento.Columns(2).Width = 80

                dgvNumeroRegistroAsiento.ReadOnly = True
            Catch
                dgvNumeroRegistroAsiento.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvNumeroRegistroAsiento_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvNumeroRegistroAsiento.SelectionChanged
            If dgvNumeroRegistroAsiento.RowCount = 0 Or dgvNumeroRegistroAsiento.CurrentRow Is Nothing Then Return

            Try
                txtNumeroAsientoBuscar.Text = dgvNumeroRegistroAsiento.CurrentRow.Cells(0).Value
                rbNumeroAsiento.Checked = True
                _parametroBusqueda = 1

                btnBuscarAsiento_Click(Nothing, Nothing)

            Catch ex As Exception
                MsgBox("ERROR. SELECCIONAR ASIENTO LIBRO DIARIO" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            Try
                If (rbNumeroAsiento.Checked And txtNumeroAsientoBuscar.Text.Trim().Length = 0) Then Return

                CargarAsientoLibroDiarioBusqueda()
                SumarTotalAsientoDiarioBusqueda()

                dgvAsientoBuscado.Visible = True
                dgvAsientosDiario.Visible = False
                _botonseleccionado = 2
            Catch ex As Exception
                MsgBox("ERROR. BUSCAR ASIENTO LIBRO DIARIO" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarAsientoLibroDiarioBusqueda()
            Try
                Select Case _parametroBusqueda
                    Case 1
                        dgvAsientoBuscado.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, txtNumeroAsientoBuscar.Text)
                    Case 2
                        dgvAsientoBuscado.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXRangoFecha(_tipoCon, dtpAsientoDesde.Value, dtpAsientoHasta.Value)
                    Case Else
                        dgvAsientoBuscado.DataSource = Nothing
                        MsgBox("NO HA SELECCIONADO UN PARAMETRO DE BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End Select

                dgvAsientoBuscado.AutoResizeColumns()

                dgvAsientoBuscado.Columns(0).Width = 60 '"ORD"
                dgvAsientoBuscado.Columns(1).Width = 100 '"FECHA"
                dgvAsientoBuscado.Columns(1).DefaultCellStyle.Format = "g"
                dgvAsientoBuscado.Columns(2).Width = 120 '"CODIGO CTA"
                dgvAsientoBuscado.Columns(3).Width = 250 '"NOMBRE CTA"
                dgvAsientoBuscado.Columns(4).Width = 250 '"CONCEPTO"
                dgvAsientoBuscado.Columns(5).Width = 500 '"DETALLE"
                dgvAsientoBuscado.Columns(6).Width = 70 '"VALOR DEBE"
                dgvAsientoBuscado.Columns(7).Width = 70 '"VALOR HABER"
                dgvAsientoBuscado.Columns(8).Width = 90 '"ASIENTO"

                dgvAsientoBuscado.AutoResizeRows()

            Catch ex As Exception
                dgvAsientoBuscado.DataSource = Nothing
                MsgBox("CARGAR ASIENTOS DIARIO BUSQUEDA" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub SumarTotalAsientoDiarioBusqueda()
            Dim totalDebe = 0.0
            Dim totalHaber = 0.0
            Try
                For indice = 0 To dgvAsientoBuscado.RowCount - 1
                    totalDebe += CDec(dgvAsientoBuscado.Rows(indice).Cells(6).Value)
                    totalHaber += CDec(dgvAsientoBuscado.Rows(indice).Cells(7).Value)
                Next
            Catch
                totalDebe = 0
                totalHaber = 0
            End Try
            txtTotalDebe.Text = totalDebe
            txtTotalHaber.Text = totalHaber
        End Sub
        Private Sub dgvAsientoBuscado_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvAsientoBuscado.SelectionChanged
            If dgvAsientoBuscado.CurrentRow Is Nothing Then Return

            If dgvAsientoBuscado.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                MsgBox("NO HAY COINCIDENCIAS. REVISE LOS PARAMETROS DE BUSQUEDA", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            Else
                txtIdAsiento.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(0).Value
                dtpFechaAsiento.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(1).Value

                lblCodigoCuentaContable.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(2).Value
                cmbCuentasContables.SelectedValue = lblCodigoCuentaContable.Text

                cmbConcepto.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(4).Value
                txtDetalleAsiento.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(5).Value
                txtValorDebeAsiento.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(6).Value
                txtValorHaberAsiento.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(7).Value
                txtNumeroRegistro.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(8).Value
                txtDebeHaber.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(9).Value

                txtEstadoAsiento.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(10).Value
                txtIdLibroDiario.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(11).Value

                If dgvAsientoBuscado.ColumnCount > 13 Then txtConciliarAsiento.Text = dgvAsientoBuscado.CurrentRow.Cells.Item(14).Value
            End If
        End Sub
        Private Sub CargarAsientoLibroDiario()
            Try
                dgvAsientosDiario.AutoResizeColumns()
                dgvAsientosDiario.Columns(0).HeaderText = "ORD"
                dgvAsientosDiario.Columns(0).Width = 60
                dgvAsientosDiario.Columns(1).HeaderText = "FECHA"
                dgvAsientosDiario.Columns(1).DefaultCellStyle.Format = "g"
                dgvAsientosDiario.Columns(1).Width = 100
                dgvAsientosDiario.Columns(2).HeaderText = "CODIGO"
                dgvAsientosDiario.Columns(2).Width = 120
                dgvAsientosDiario.Columns(3).HeaderText = "CUENTA"
                dgvAsientosDiario.Columns(3).Width = 250
                dgvAsientosDiario.Columns(4).HeaderText = "CONCEPTO"
                dgvAsientosDiario.Columns(4).Width = 250
                dgvAsientosDiario.Columns(5).HeaderText = "DETALLE"
                dgvAsientosDiario.Columns(5).Width = 500
                dgvAsientosDiario.Columns(6).HeaderText = "DEBE"
                dgvAsientosDiario.Columns(6).Width = 70
                dgvAsientosDiario.Columns(7).HeaderText = "HABER"
                dgvAsientosDiario.Columns(7).Width = 70
                dgvAsientosDiario.Columns(8).HeaderText = "ASIENTO"
                dgvAsientosDiario.Columns(8).Width = 90
                dgvAsientosDiario.Columns(9).HeaderText = "D/H"
                dgvAsientosDiario.Columns(9).Width = 70
                dgvAsientosDiario.Columns(10).HeaderText = "CON"
                dgvAsientosDiario.Columns(10).Width = 70
                dgvAsientosDiario.Columns(11).HeaderText = "EST"
                dgvAsientosDiario.Columns(11).Width = 70
                dgvAsientosDiario.Columns(12).HeaderText = "ID LD"
                dgvAsientosDiario.Columns(12).Width = 90
                dgvAsientosDiario.ReadOnly = False
            Catch ex As Exception
                MsgBox("CARGAR ASIENTOS DIARIO" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub DeshabilitadoInicio()
            '===
            rbNumeroAsiento.Enabled = True
            rbFechaAsiento.Enabled = True
            rbCheque.Checked = False
            rbEfectivo.Checked = False
            rbTarjetaCredido.Checked = False
            rbTransaccionExterna.Checked = False
            rbTransaccionInterna.Checked = False
            '===
            txtNumeroAsientoBuscar.Enabled = False
            dtpAsientoDesde.Enabled = False
            dtpAsientoHasta.Enabled = False
            '===
            btnBuscarAsiento.Enabled = True
            btnNuevoAsiento.Enabled = True
            btnModificarAsiento.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
            btnAgregar.Enabled = False
            btnEliminar.Enabled = False
            '===
            gbBanco.Enabled = False
            gbFormaPago.Enabled = False
            gbClienteProveedorPersonal.Enabled = False

            dtpFechaAsiento.Enabled = False
            cmbCuentasContables.Enabled = False
            cmbConcepto.Enabled = False
            txtDetalleAsiento.Enabled = False
            cmbCentroCosto.Enabled = False
            txtValorDebeAsiento.Enabled = False
            txtValorHaberAsiento.Enabled = False
            txtNumeroRegistro.Enabled = False
            txtDebeHaber.Enabled = False
            txtConciliarAsiento.Enabled = False
            txtEstadoAsiento.Enabled = False
            txtIdLibroDiario.Enabled = False
        End Sub
        Private Sub LlenarComboCentroCosto()
            Try
                Dim data = _objetoCentroCosto.SeleccionarCentroCosto(_tipoCon)
                cmbCentroCosto.DataSource = data
                cmbCentroCosto.DisplayMember = data.Columns(1).ToString
                cmbCentroCosto.ValueMember = data.Columns(0).ToString
                If (CType(cmbCentroCosto.DataSource, DataTable).Rows.Count > 0) Then cmbCentroCosto.SelectedIndex = 0
            Catch
                cmbCentroCosto.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarCuentasContables()
            Try
                Dim data = _objetoPlanCuentas.SeleccionarCuentasYDetallePlanDeCuentas(_tipoCon)
                cmbCuentasContables.DataSource = data
                cmbCuentasContables.DisplayMember = data.Columns(0).ToString
                cmbCuentasContables.ValueMember = data.Columns(1).ToString
                If (CType(cmbCuentasContables.DataSource, DataTable).Rows.Count > 0) Then cmbCuentasContables.SelectedIndex = 0 
            Catch
                cmbCuentasContables.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboBancos()
            Try
                Dim data = _objetoBanco.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
                If (CType(cmbBancos.DataSource, DataTable).Rows.Count > 0) Then cmbBancos.SelectedIndex = 0
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbBancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBancos.SelectedIndexChanged
            LlenarComboCuentasBancos()
        End Sub
        Private Sub LlenarComboCuentasBancos()
            Try
                Dim data = _objetoCuentasBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, CInt(cmbBancos.SelectedValue))
                cmbCuentaBancos.DataSource = data
                cmbCuentaBancos.DisplayMember = data.Columns(1).ToString
                cmbCuentaBancos.ValueMember = data.Columns(0).ToString
                If (CType(cmbCuentaBancos.DataSource, DataTable).Rows.Count > 0) Then cmbCuentaBancos.SelectedIndex = 0
            Catch
                cmbCuentaBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbConcepto.SelectedIndexChanged
            cmbConcepto.SelectedIndex = 0
            If cmbConcepto.Text = "COMPROBANTE DE EGRESO" Or cmbConcepto.Text = "COMPROBANTE DE INGRESO" Or
                cmbConcepto.Text = "COMPROBANTE DE INGRESO CUENTAS POR PAGAR" Then
                gbBanco.Enabled = True
                gbFormaPago.Enabled = True
            Else
                gbBanco.Enabled = False
                gbFormaPago.Enabled = False
                LlenarComboBancos()
                LlenarComboCuentasBancos()
            End If
        End Sub
        Private Sub txtNumeroAsientoBuscar_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroAsientoBuscar.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            If txtNumeroAsientoBuscar.Text.Trim().Length = 0 Then Return
            btnBuscarAsiento_Click(Nothing, Nothing)
        End Sub
        Private Sub txtNumeroAsientoBuscar_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNumeroAsientoBuscar.KeyPress
            e.Handled = Not _objetoNumerico.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtValorDebeAsiento_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorHaberAsiento.KeyPress, txtValorDebeAsiento.KeyPress
            Dim txt = CType(sender, TextBox)
            e.Handled = Not _objetoDecimal.EsDecimal(e.KeyChar, txt.Text)
        End Sub
        Private Sub rbNumeroAsiento_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNumeroAsiento.CheckedChanged
            If Not rbNumeroAsiento.Checked Then Return
            dtpAsientoDesde.Enabled = False
            dtpAsientoHasta.Enabled = False
            _parametroBusqueda = 1
            txtNumeroAsientoBuscar.Enabled = True
            txtNumeroAsientoBuscar.Focus()
        End Sub
        Private Sub rbFechaAsiento_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFechaAsiento.CheckedChanged
            If Not rbFechaAsiento.Checked Then Return
            txtNumeroAsientoBuscar.Enabled = False
            dtpAsientoDesde.Enabled = True
            dtpAsientoHasta.Enabled = True
            _parametroBusqueda = 2
        End Sub
        Private Sub rbTransaccionInterna_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTransaccionInterna.CheckedChanged
            If rbTransaccionInterna.Checked = True Then
                Dim em = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                lblRucClienteProveedorPersonal.Text = em.Rows(0)(2)
                txtNombreClienteProveedorPersonal.Text = em.Rows(0)(4) 
                gbClienteProveedorPersonal.Enabled = False
            Else
                lblRucClienteProveedorPersonal.Text = "0"
                txtNombreClienteProveedorPersonal.Text = ""
                gbClienteProveedorPersonal.Enabled = True
            End If
        End Sub
        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.Todos = True
 
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtProveedor.Checked Then
                        lblIdClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        lblRucClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(2).Value
                        txtNombreClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(3).Value & " (" & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value & ")"
                    ElseIf frm.rbtCliente.Checked Then
                        lblIdClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        lblRucClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(3).Value
                        txtNombreClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(4).Value & " (" & frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & ")"
                    Else
                        lblIdClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        lblRucClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(3).Value
                        txtNombreClienteProveedorPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(4).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(5).Value
                    End If
                     
                End If
            Catch ex As Exception
                MsgBox("BOTÓN BUSCAR PERSONAL." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub btnNuevoAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoAsiento.Click
            LlenarComboCentroCosto()
            LlenarCuentasContables()
            LlenarComboBancos()
            LlenarComboCuentasBancos()

            HabilitadoNuevo()
            
            dgvAsientoBuscado.Visible = False
            dgvAsientosDiario.Visible = True

            txtIdAsiento.Clear()
            LimpiarParametros()

            cmbConcepto.SelectedIndex = 0
            cmbCuentasContables.SelectedIndex = 0
            _botonseleccionado = 1
            txtNombreClienteProveedorPersonal.Focus()
        End Sub
        Private Sub LimpiarParametros()
            dgvAsientoBuscado.DataSource = Nothing
            dgvAsientosDiario.Rows.Clear()

            cmbConcepto.SelectedIndex = 0
            cmbCuentasContables.SelectedValue = 0

            dtpFechaAsiento.ResetText()
             
            rbEfectivo.Checked = True 
            txtDetalleAsiento.Text = "..."
            txtValorDebeAsiento.Text = "0.00"
            txtValorHaberAsiento.Text = "0.00"
            txtTotalDebe.Text = "0.00"
            txtTotalHaber.Text = "0.00"
            txtNumeroRegistro.Text = ""
            txtDebeHaber.Text = "0"
            txtConciliarAsiento.Text = "1"
            txtEstadoAsiento.Text = "1"
            txtIdLibroDiario.Text = "0"
        End Sub
        Private Sub HabilitadoNuevo()
            '===
            rbNumeroAsiento.Enabled = True
            rbFechaAsiento.Enabled = True
            '===
            txtNumeroAsientoBuscar.Enabled = False
            dtpAsientoDesde.Enabled = False
            dtpAsientoHasta.Enabled = False
            '===
            btnBuscarAsiento.Enabled = False
            btnNuevoAsiento.Enabled = False
            btnModificarAsiento.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            btnAgregar.Enabled = True
            btnEliminar.Enabled = True
            '===
            gbBanco.Enabled = False
            gbFormaPago.Enabled = True
            gbClienteProveedorPersonal.Enabled = True

            dtpFechaAsiento.Enabled = True
            cmbCuentasContables.Enabled = True
            cmbConcepto.Enabled = True
            txtDetalleAsiento.Enabled = True
            cmbCentroCosto.Enabled = True
            txtValorDebeAsiento.Enabled = True
            txtValorHaberAsiento.Enabled = True
            txtNumeroRegistro.Enabled = True
            txtDebeHaber.Enabled = True
            txtConciliarAsiento.Enabled = True
            txtEstadoAsiento.Enabled = True
            txtIdLibroDiario.Enabled = True
        End Sub
        Private Sub btnModificarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarAsiento.Click
            If txtIdAsiento.Text.Trim().Length > 0 Then
                If txtIdAsiento.Text = "ID" Then
                    MsgBox("SELECCIONE UN REGISTRO A MODIFICAR", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                Else
                    HabilitadoNuevo()
                    
                    rbEfectivo.Checked = True
                    dgvAsientoBuscado.Visible = True
                    dgvAsientosDiario.Visible = False
                    _botonseleccionado = 2

                    cmbConcepto.SelectedIndex = 1
                    cmbConcepto.Enabled = False
                    gbClienteProveedorPersonal.Enabled = False
                    txtDetalleAsiento.Focus()
                End If                
            Else
                MsgBox("SELECCIONE UN REGISTRO A MODIFICAR", MsgBoxStyle.Information, "MENSAJE")
            End If           
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            LimpiarParametros()
            DeshabilitadoInicio()
        End Sub
        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            Try
                If cmbConcepto.Text <> "" And cmbCuentasContables.Text <> "" And lblCodigoCuentaContable.Text <> "" And txtDetalleAsiento.Text <> "" And txtValorDebeAsiento.Text <> "" And txtValorHaberAsiento.Text <> "" Then
                    If txtValorDebeAsiento.Text <> txtValorHaberAsiento.Text Then
                        Dim codicuenta = cmbCuentasContables.Text.Trim()
                        Dim cod = codicuenta.Split("-")(0).Trim
                        Dim cue = codicuenta.Replace((cod.Trim & " - "), String.Empty).Trim

                        If _botonseleccionado = 1 Then
                            dgvAsientosDiario.Rows.Add(0, dtpFechaAsiento.Value, lblCodigoCuentaContable.Text, cue, cmbConcepto.Text, txtDetalleAsiento.Text, txtValorDebeAsiento.Text, txtValorHaberAsiento.Text, txtNumeroRegistro.Text, txtDebeHaber.Text, txtConciliarAsiento.Text, txtEstadoAsiento.Text, txtIdLibroDiario.Text)
                            dgvAsientosDiario.AutoResizeRows()
                            SumarTotalAsientoDiario()
                        ElseIf _botonseleccionado = 2 Then
                            For indice = 0 To dgvAsientoBuscado.RowCount - 1
                                If txtIdAsiento.Text = dgvAsientoBuscado.Rows(indice).Cells(0).Value Then
                                    dgvAsientoBuscado.Rows(indice).Cells(1).Value = dtpFechaAsiento.Value
                                    dgvAsientoBuscado.Rows(indice).Cells(2).Value = cod
                                    dgvAsientoBuscado.Rows(indice).Cells(3).Value = cue
                                    dgvAsientoBuscado.Rows(indice).Cells(4).Value = cmbConcepto.Text
                                    If cmbConcepto.Text = "COMPROBANTE DE EGRESO" Then
                                        dgvAsientoBuscado.Rows(indice).Cells(5).Value = "ID CE:" & (_objetoComprobanteEgresoBancos.BuscarMayorIdComprobanteEgresoBancos(_tipoCon) + 1) & " PAGADO A: " & txtNombreClienteProveedorPersonal.Text & " BANCO: " & cmbBancos.Text & " CTA: " & cmbCuentaBancos.Text & " " & txtDetalleAsiento.Text
                                    ElseIf cmbConcepto.Text = "COMPROBANTE DE INGRESO" Then
                                        dgvAsientoBuscado.Rows(indice).Cells(5).Value = "ID CI:" & (_objetoComprobanteIngresoBancos.BuscarMayorIdComprobanteIngresoBancos(_tipoCon) + 1) & " " & txtDetalleAsiento.Text
                                    ElseIf cmbConcepto.Text = "COMPROBANTE DE INGRESO CUENTAS POR PAGAR" Then
                                        dgvAsientoBuscado.Rows(indice).Cells(5).Value = txtDetalleAsiento.Text
                                    Else
                                        dgvAsientoBuscado.Rows(indice).Cells(5).Value = txtDetalleAsiento.Text
                                    End If
                                    dgvAsientoBuscado.Rows(indice).Cells(6).Value = CDec(txtValorDebeAsiento.Text).ToString("N")
                                    dgvAsientoBuscado.Rows(indice).Cells(7).Value = CDec(txtValorHaberAsiento.Text).ToString("N")
                                    dgvAsientoBuscado.Rows(indice).Cells(8).Value = txtNumeroRegistro.Text
                                    If CDec(dgvAsientoBuscado.Rows(indice).Cells(6).Value) > CDec(dgvAsientoBuscado.Rows(indice).Cells(7).Value) Then
                                        dgvAsientoBuscado.Rows(indice).Cells(9).Value = 1
                                    ElseIf CDec(dgvAsientoBuscado.Rows(indice).Cells(7).Value) > CDec(dgvAsientoBuscado.Rows(indice).Cells(6).Value) Then
                                        dgvAsientoBuscado.Rows(indice).Cells(9).Value = 2
                                    End If
                                    dgvAsientoBuscado.Rows(indice).Cells(11).Value = 1
                                End If
                            Next
                            SumarTotalAsientoDiarioBusqueda()
                        End If
                    Else
                        MsgBox("EL VALOR DEL DEBE NO PUEDE SER IGUAL AL DEL HABER", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    End If
                Else
                    MsgBox("POR FAVOR REVISE QUE TODOS LOS PARAMETROS ESTEN CORRECTOS PARA AGREGAR.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
            Catch ex As Exception
                MsgBox("AGREGAR ASIENTO." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub SumarTotalAsientoDiario()
            Try
                Dim totalDebe As Decimal = 0
                Dim totalHaber As Decimal = 0
                For indice = 0 To dgvAsientosDiario.RowCount - 1
                    totalDebe += CDec(dgvAsientosDiario.Rows(indice).Cells(6).Value)
                    totalHaber += CDec(dgvAsientosDiario.Rows(indice).Cells(7).Value)
                Next
                txtTotalDebe.Text = totalDebe
                txtTotalHaber.Text = totalHaber
            Catch
                txtTotalDebe.Text = 0
                txtTotalHaber.Text = 0
            End Try
        End Sub
        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            Try 
                If _botonseleccionado = 1 Then 
                    dgvAsientosDiario.Rows.RemoveAt(dgvAsientosDiario.CurrentRow.Index)
                    SumarTotalAsientoDiario()
                ElseIf _botonseleccionado = 2 Then
                    If MessageBox.Show("La fila/cuenta seleccionada será anulada. Quiere continuar?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    dgvAsientoBuscado.CurrentRow.Cells(6).Value = 0
                    dgvAsientoBuscado.CurrentRow.Cells(7).Value = 0
                    dgvAsientoBuscado.CurrentRow.Cells(11).Value = 0
                    SumarTotalAsientoDiarioBusqueda()
                End If
            Catch ex As Exception
                MsgBox("ELIMINAR CELDAS:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub cmbCuentasContables_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbCuentasContables.SelectedValueChanged
            If cmbCuentasContables.SelectedValue Is Nothing Or TypeOf cmbCuentasContables.SelectedValue Is DataRowView Then Return
            lblCodigoCuentaContable.Text = cmbCuentasContables.SelectedValue
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If CDec(txtTotalDebe.Text) <> CDec(txtTotalHaber.Text) Then
                MessageBox.Show("El ASIENTO no cuadra, no se puede guardar los cambios!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If MessageBox.Show("Seguro que desea guardar los cambios realizados?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
            _sqlCommands.Clear()

            If _botonseleccionado = 1 Then
                _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                With _objetoNumeroRegistro
                    .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                    .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon) + 1
                End With
                _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand)

                NuevoRegistroAsientoDiario()

            ElseIf _botonseleccionado = 2 Then
                ModificarRegistroAsientoDiario()
            End If

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then
                DeshabilitadoInicio()
                LimpiarParametros()
            End If
            MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            CargarNumeroRegistroAsientoLibroDiario()
        End Sub          
        Private Sub NuevoRegistroAsientoDiario()
            Dim i = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
            For indice = 0 To dgvAsientosDiario.RowCount - 1
                With _objetoAsientoLibroDiario
                    .IdAsiento = i
                    .FechaAsiento = dgvAsientosDiario.Rows(indice).Cells(1).Value
                    .CodigoCuentaAsiento = dgvAsientosDiario.Rows(indice).Cells(2).Value.ToString.Trim
                    .NombreCuentaAsiento = dgvAsientosDiario.Rows(indice).Cells(3).Value.ToString.Trim
                    .ConceptoAsiento = dgvAsientosDiario.Rows(indice).Cells(4).Value.ToString.ToUpper
                    .DetalleTransaccionAsiento = dgvAsientosDiario.Rows(indice).Cells(5).Value.ToString.ToUpper
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = "GERENCIA GENERAL"
                    .ValorDebeAsiento = dgvAsientosDiario.Rows(indice).Cells(6).Value
                    .ValorHaberAsiento = dgvAsientosDiario.Rows(indice).Cells(7).Value
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    If dgvAsientosDiario.Rows(indice).Cells(6).Value > dgvAsientosDiario.Rows(indice).Cells(7).Value Then
                        .DebeHaberAsiento = 1
                    Else
                        .DebeHaberAsiento = 2
                    End If
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                    .EstadoMayorAsiento = 0
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                i += 1
            Next
        End Sub
        Private Sub ModificarRegistroAsientoDiario()
            For indice = 0 To dgvAsientoBuscado.RowCount - 1
                With _objetoAsientoLibroDiario
                    .IdAsiento = dgvAsientoBuscado.Rows(indice).Cells(0).Value
                    .FechaAsiento = dgvAsientoBuscado.Rows(indice).Cells(1).Value
                    .CodigoCuentaAsiento = dgvAsientoBuscado.Rows(indice).Cells(2).Value.ToString.Trim
                    .NombreCuentaAsiento = dgvAsientoBuscado.Rows(indice).Cells(3).Value.ToString.Trim
                    .ConceptoAsiento = dgvAsientoBuscado.Rows(indice).Cells(4).Value.ToString.ToUpper
                    .DetalleTransaccionAsiento = dgvAsientoBuscado.Rows(indice).Cells(5).Value.ToString.ToUpper  
                    .CentroCostoAsiento = cmbConcepto.Text
                    .ValorDebeAsiento = dgvAsientoBuscado.Rows(indice).Cells(6).Value
                    .ValorHaberAsiento = dgvAsientoBuscado.Rows(indice).Cells(7).Value 
                    .NumeroRegistroAsiento = dgvAsientoBuscado.Rows(indice).Cells(8).Value
                    If CDec(dgvAsientoBuscado.Rows(indice).Cells(6).Value) > CDec(dgvAsientoBuscado.Rows(indice).Cells(7).Value) Then
                        .DebeHaberAsiento = 1
                    ElseIf CDec(dgvAsientoBuscado.Rows(indice).Cells(7).Value) > CDec(dgvAsientoBuscado.Rows(indice).Cells(6).Value) Then
                        .DebeHaberAsiento = 2
                    End If
                    .ConciliarAsiento = 1
                    .EstadoAsiento = dgvAsientoBuscado.Rows(indice).Cells(11).Value
                    .IdLibroDiario = dgvAsientoBuscado.Rows(indice).Cells(12).Value
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.ModificarRegistroAsientoLibroDiarioCommand)
            Next
        End Sub                  
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If txtNumeroAsientoBuscar.Text.Trim().Length > 0 Then
                Dim rpt = New FormReporteAsiento
                rpt.TipoCox = TipoCox
                rpt.lblNumeroRegistro.Text = txtNumeroAsientoBuscar.Text
                rpt.NumeroRegistro = txtNumeroAsientoBuscar.Text
                rpt.ShowDialog()
            Else
                MsgBox("NO HAY ASINETOS QUE CARGAR. PRIMERO SELECCIONE", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            Try
                If _botonseleccionado = 1 Then ' SI ESCOGIO EL BOTÓN NUEVO
                    If dgvAsientosDiario.RowCount > 0 Then ExportarDatosExcel(dgvAsientosDiario, "ASIENTO DE DIARIO")
                ElseIf _botonseleccionado = 2 Then  ' SI ESCOGIO EL BOTÓN MODIFICAR
                    If dgvAsientoBuscado.RowCount > 0 Then ExportarDatosExcel(dgvAsientoBuscado, "ASIENTO DE DIARIO")
                End If
            Catch ex As Exception
                MsgBox("EXPORTAR ASIENTO DE DIARIO." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
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
                worksheet.Name = "ASIENTO_DIARIO"

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
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpAsientoDesde.Value.ToLongDateString() & "  AL " & dtpAsientoHasta.Value.ToLongDateString()
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

                ' TOTALES, ETC
                Dim foot = headin + dgvAsientosDiario.RowCount + 3
                worksheet.Cells(foot, 6).Value = "TOTAL DE TRANSACCIÓN"
                worksheet.Cells(foot, 6).Font.Bold = True
                worksheet.Cells(foot, 7).Value = txtTotalDebe.Text
                worksheet.Cells(foot, 8).Value = txtTotalHaber.Text

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub          

        Private Sub dgvAsientosDiario_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvAsientosDiario.SelectionChanged

        End Sub
    End Class
End Namespace