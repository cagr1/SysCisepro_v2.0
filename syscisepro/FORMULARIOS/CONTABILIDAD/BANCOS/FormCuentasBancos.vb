Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormCuentasBancos
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

        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentasBancos As New ClassCuentasBancos
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral

        Dim _botonSeleccionado As Integer

        Private Sub DesabilitadoInicio() 'Desabilita lo que no tiene que cargase al inicio del formulario
            cmbBanco.Enabled = False
            txtIdCuentaBancos.Enabled = False
            txtNumeroCuentasBancos.Enabled = False
            txtMontoCuentasBancos.Enabled = False
            cmbTipoCuenta.Enabled = False
            btnGuardarCuentaBancos.Enabled = False
            btnCancelarCuentaBancos.Enabled = False 
            btnNuevoCuentaBancos.Enabled = True
            btnModificarCuentaBancos.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            cmbBanco.Enabled = True
            txtIdCuentaBancos.Enabled = False
            txtNumeroCuentasBancos.Enabled = True
            txtMontoCuentasBancos.Enabled = True
            cmbTipoCuenta.Enabled = True
            btnGuardarCuentaBancos.Enabled = True
            btnCancelarCuentaBancos.Enabled = True 
            btnNuevoCuentaBancos.Enabled = False
            btnModificarCuentaBancos.Enabled = False
        End Sub

        Private Sub LimpiarParametros()
            cmbBanco.Text = ""
            lblIdBanco.Text = "00"
            txtIdCuentaBancos.Text = ""
            txtNumeroCuentasBancos.Text = ""
            txtMontoCuentasBancos.Text = "0.00"
            cmbTipoCuenta.Text = ""
        End Sub

        Private Function ValidacionParametros() As Boolean
            If txtIdCuentaBancos.Text <> "" And txtNumeroCuentasBancos.Text <> "" And txtMontoCuentasBancos.Text <> "" And cmbTipoCuenta.Text <> "" And lblIdBanco.Text <> "" Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub Auditoria()
            With _objAuditoria

                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = Date.Now
                .NuevaAuditoria(_tipoCon)
            End With
        End Sub

        Private Sub CargarComboBanco()
            Try
                Dim data = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBanco.DataSource = data
                cmbBanco.DisplayMember = data.Columns(2).ToString
                cmbBanco.ValueMember = data.Columns(2).ToString
            Catch
                cmbBanco.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarCuentasBancos()
            Try
                dgvCuentasBancos.DataSource = _objetoCuentasBancos.SeleccionarRegistrosCuentasBancos(_tipoCon)
                dgvCuentasBancos.AutoResizeColumns()
                dgvCuentasBancos.AutoResizeRows()

                dgvCuentasBancos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCuentasBancos.Columns(0).HeaderText = "ID"
                dgvCuentasBancos.Columns(0).Width = 50
                dgvCuentasBancos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCuentasBancos.Columns(1).HeaderText = "CUENTA"
                dgvCuentasBancos.Columns(1).Width = 70
                dgvCuentasBancos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCuentasBancos.Columns(2).HeaderText = "MONTO"
                dgvCuentasBancos.Columns(2).Width = 80
                dgvCuentasBancos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCuentasBancos.Columns(3).HeaderText = "TIPO"
                dgvCuentasBancos.Columns(3).Width = 120
                dgvCuentasBancos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCuentasBancos.Columns(4).HeaderText = "ESATDO"
                dgvCuentasBancos.Columns(4).Width = 60
                dgvCuentasBancos.Columns(5).Visible = False
                dgvCuentasBancos.Columns(6).HeaderText = "CODIGO"
                dgvCuentasBancos.Columns(6).Width = 90
                dgvCuentasBancos.ReadOnly = False
                dgvCuentasBancos.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvCuentasBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub GuardarCuentasBancosNuevo()
            With _objetoCuentasBancos
                .IdCuentaBancos = txtIdCuentaBancos.Text
                .NumeroCuentaBancos = txtNumeroCuentasBancos.Text.Trim
                .MontoCuentaBancos = txtMontoCuentasBancos.Text
                .TipoCuentaBancos = cmbTipoCuenta.SelectedItem.ToString
                .EstadoCuentaBancos = 1
                .IdBancos = lblIdBanco.Text
                .NuevoRegistroCuentasBancos(_tipoCon)
                cargarCuentasBancos()
                desabilitadoInicio()
            End With
            _objAuditoria.AccionAuditoria = "CREO UNA NUEVA CUENTA DE BANCO" + txtIdCuentaBancos.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            auditoria()
        End Sub

        Private Sub GuardarCuentasBancosModificar()
            With _objetoCuentasBancos
                .IdCuentaBancos = txtIdCuentaBancos.Text
                .NumeroCuentaBancos = txtNumeroCuentasBancos.Text.Trim
                .MontoCuentaBancos = txtMontoCuentasBancos.Text
                .TipoCuentaBancos = cmbTipoCuenta.SelectedItem.ToString
                .EstadoCuentaBancos = 1
                .IdBancos = lblIdBanco.Text
                .NuevoRegistroCuentasBancos(_tipoCon)
                cargarCuentasBancos()
                desabilitadoInicio()
            End With
            _objAuditoria.AccionAuditoria = "MODIFICO UNA CUENTA DE BANCO" + txtIdCuentaBancos.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            auditoria()
        End Sub

        Private Sub FormCuentasBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCuentasBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    dgvCuentasBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    dgvCuentasBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCuentasBancos.Font = New Font("Roboto", 8, FontStyle.Regular)
            CargarComboBanco()
            cargarCuentasBancos()
            desabilitadoInicio()
        End Sub

        Private Sub dgvCuentasBancos_CellClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentasBancos.CellClick
            If dgvCuentasBancos.CurrentRow Is Nothing Then Return
            If dgvCuentasBancos.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdCuentaBancos.Text = ""
            Else
                txtIdCuentaBancos.Text = dgvCuentasBancos.CurrentRow.Cells.Item(0).Value
                txtNumeroCuentasBancos.Text = dgvCuentasBancos.CurrentRow.Cells.Item(1).Value
                txtMontoCuentasBancos.Text = dgvCuentasBancos.CurrentRow.Cells.Item(2).Value.ToString
                cmbTipoCuenta.Text = dgvCuentasBancos.CurrentRow.Cells.Item(3).Value.ToString
                dgvCuentasBancos.Rows(dgvCuentasBancos.CurrentCell.RowIndex.ToString()).Selected = True
            End If
        End Sub
        Private Sub btnNuevoCuentaBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoCuentaBancos.Click
            _botonSeleccionado = 1
            LimpiarParametros()
            txtIdCuentaBancos.Text = _objetoCuentasBancos.BuscarMayorIdCuentasBancos(_tipoCon) + 1
            HabilitadoNuevo()
        End Sub
        Private Sub btnModificarCuentaBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarCuentaBancos.Click
            _botonSeleccionado = 2
            HabilitadoNuevo()
        End Sub
        Private Sub btnGuardarCuentaBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarCuentaBancos.Click
            Try
                If validacionParametros() = True Then
                    Select Case (_botonSeleccionado)
                        Case 1 : guardarCuentasBancosNuevo()
                        Case 2 : GuardarCuentasBancosModificar()
                    End Select
                Else
                    MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                    txtNumeroCuentasBancos.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "NO GUARDO. CUENTAS BANCOS")
            End Try
        End Sub
        Private Sub btnCancelarCuentaBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarCuentaBancos.Click
            limpiarParametros()
            desabilitadoInicio()
        End Sub

        Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBanco.SelectedIndexChanged
            lblIdBanco.Text = _objetoBancos.BuscarIdBancoXNombreBanco(_tipoCon, cmbBanco.SelectedValue.ToString)
            txtCodigoBanco.Text = _objetoBancos.BuscarCodigoBancoXNombreBanco(_tipoCon, cmbBanco.SelectedValue.ToString)
        End Sub
         
    End Class
End Namespace