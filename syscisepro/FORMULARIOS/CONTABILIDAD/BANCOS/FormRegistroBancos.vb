Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormRegistroBancos
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
        Public IdUsuario As Integer

        ReadOnly _objetoBancos As New ClassBancos
        Private ReadOnly _objAuditoria As New ClassAuditoriaGeneral
         
        Dim _botonSeleccionado As Integer

        Private Sub DesabilitadoInicio() 'Desabilita lo que no tiene que cargase al inicio del formulario
            txtIdBanco.Enabled = False
            txtCodigoCuentaBanco.Enabled = False
            txtNombreBanco.Enabled = False
            txtDireccionBanco.Enabled = False
            txtOficialCreditoBanco.Enabled = False
            txtTelefonoBanco.Enabled = False
            txtFaxBanco.Enabled = False
            txtEMailBanco.Enabled = False
            btnGuardarBanco.Enabled = False
            btnCancelarBanco.Enabled = False
            btnReporteBanco.Enabled = True
            btnNuevoBanco.Enabled = True
            btnModificarBanco.Enabled = True
        End Sub

        Private Sub HabilitadoNuevo()
            txtCodigoCuentaBanco.Enabled = False
            txtNombreBanco.Enabled = True
            txtDireccionBanco.Enabled = True
            txtOficialCreditoBanco.Enabled = True
            txtTelefonoBanco.Enabled = True
            txtFaxBanco.Enabled = True
            txtEMailBanco.Enabled = True
            btnGuardarBanco.Enabled = True
            btnCancelarBanco.Enabled = True
            btnNuevoBanco.Enabled = False
            btnModificarBanco.Enabled = False
            btnReporteBanco.Enabled = False
        End Sub

        Private Sub LimpiarParametros()
            txtIdBanco.Text = ""
            txtCodigoCuentaBanco.Text = ""
            txtNombreBanco.Text = ""
            txtDireccionBanco.Text = ""
            txtOficialCreditoBanco.Text = ""
            txtTelefonoBanco.Text = ""
            txtFaxBanco.Text = ""
            txtEMailBanco.Text = ""
        End Sub

        Private Function ValidacionParametros() As Boolean
            If txtIdBanco.Text <> "" And txtCodigoCuentaBanco.Text <> "" And txtNombreBanco.Text <> "" And txtDireccionBanco.Text <> "" And txtOficialCreditoBanco.Text <> "" And txtTelefonoBanco.Text <> "" _
               And txtFaxBanco.Text <> "" And txtEMailBanco.Text <> "" Then
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

        Private Sub CargarBancos()
            Try
                dgvBancos.DataSource = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                dgvBancos.AutoResizeColumns()
                dgvBancos.AutoResizeRows()
                dgvBancos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(0).HeaderText = "ID"
                dgvBancos.Columns(0).Width = 50

                dgvBancos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(1).HeaderText = "CÓDIGO"
                dgvBancos.Columns(1).Width = 80

                dgvBancos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(2).HeaderText = "BANCO"

                dgvBancos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(3).HeaderText = "DIRECCION"

                dgvBancos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(4).HeaderText = "OFICIAL"

                dgvBancos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(5).HeaderText = "TELEFONO"

                dgvBancos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(6).HeaderText = "FAX"

                dgvBancos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(7).HeaderText = "EMAIL"

                dgvBancos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvBancos.Columns(8).HeaderText = "ESTADO"

                dgvBancos.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub GuardarBancosNuevo()
            With _objetoBancos
                .IdBancos = txtIdBanco.Text
                .Codigo = txtCodigoCuentaBanco.Text
                .Nombre = txtNombreBanco.Text.Trim.ToUpper
                .Direccion = txtDireccionBanco.Text.ToUpper
                .OficialCredito = txtOficialCreditoBanco.Text.ToUpper
                .Telefono = txtTelefonoBanco.Text
                .Fax = txtFaxBanco.Text
                .Email = txtEMailBanco.Text
                .Estado = 1
                .NuevoRegistroBancos(_tipoCon)
                cargarBancos()
                desabilitadoInicio()
            End With
            _objAuditoria.AccionAuditoria = "CREO UN NUEVO BANCO" + txtIdBanco.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            auditoria()
        End Sub

        Private Sub GuardarBancosModificar()
            With _objetoBancos
                .IdBancos = txtIdBanco.Text
                .Nombre = txtNombreBanco.Text.Trim.ToUpper
                .Direccion = txtDireccionBanco.Text.ToUpper
                .OficialCredito = txtOficialCreditoBanco.Text.ToUpper
                .Telefono = txtTelefonoBanco.Text
                .Fax = txtFaxBanco.Text
                .Email = txtEMailBanco.Text
                .Estado = 1
                .ModificarRegistroBancos(_tipoCon)
                CargarBancos()
                DesabilitadoInicio()
            End With
            _objAuditoria.AccionAuditoria = "MODIFICO REGISTRO BANCO" + txtIdBanco.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            Auditoria()
        End Sub

        Private Sub FormRegistroBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvBancos.Font = New Font("Roboto", 8, FontStyle.Regular)
            CargarBancos()
            desabilitadoInicio()
        End Sub
 
        Private Sub btnNuevoBanco_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoBanco.Click
            Try
                _botonSeleccionado = 1
                limpiarParametros()

                txtIdBanco.Text = _objetoBancos.BuscarMayorIdBancos(_tipoCon) + 1
                txtCodigoCuentaBanco.Text = "1.1.1.4." + txtIdBanco.Text
                habilitadoNuevo()
            Catch ex As Exception
            End Try
        End Sub
        Private Sub btnModificarBanco_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarBanco.Click
            Try
                _botonSeleccionado = 2
                habilitadoNuevo()
            Catch ex As Exception
            End Try
        End Sub
        Private Sub btnGuardarBanco_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarBanco.Click
            Try
                If validacionParametros() = True Then
                    Select Case (_botonSeleccionado)
                        Case 1 : GuardarBancosNuevo()
                        Case 2 : GuardarBancosModificar()
                    End Select
                Else
                    MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                    txtNombreBanco.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "NO GUARDO. BANCOS")
            End Try
        End Sub
        Private Sub btnCancelarBanco_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarBanco.Click
            limpiarParametros()
            desabilitadoInicio()
        End Sub
        Private Sub btnReporteBanco_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporteBanco.Click
            Dim f = New FormReporteBancos
            f.TipoCox = TipoCox
            f.ShowDialog()
        End Sub

        Private Sub dgvBancos_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvBancos.SelectionChanged
            If dgvBancos.CurrentRow Is Nothing Then Return

            If dgvBancos.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdBanco.Text = ""
            Else
                txtIdBanco.Text = dgvBancos.CurrentRow.Cells.Item(0).Value
                txtCodigoCuentaBanco.Text = dgvBancos.CurrentRow.Cells.Item(1).Value
                txtNombreBanco.Text = dgvBancos.CurrentRow.Cells.Item(2).Value
                txtDireccionBanco.Text = dgvBancos.CurrentRow.Cells.Item(3).Value.ToString
                txtOficialCreditoBanco.Text = dgvBancos.CurrentRow.Cells.Item(4).Value.ToString
                txtTelefonoBanco.Text = dgvBancos.CurrentRow.Cells.Item(5).Value.ToString
                txtFaxBanco.Text = dgvBancos.CurrentRow.Cells.Item(6).Value.ToString
                txtEMailBanco.Text = dgvBancos.CurrentRow.Cells.Item(7).Value.ToString
            End If
        End Sub
    End Class
End Namespace