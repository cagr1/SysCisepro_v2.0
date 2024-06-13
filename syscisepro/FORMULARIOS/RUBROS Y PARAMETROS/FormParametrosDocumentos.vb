Imports System.Data.SqlClient
Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.RUBROS_Y_PARAMETROS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormParametrosDocumentos
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

        Private ReadOnly _objetoParametros As New ClassParametroDocumentos
        Private ReadOnly _objetoAuditoria As New ClassAuditoriaGeneral
        Dim _botonSeleccionado As New Integer

        Private Sub Auditoria()
            _objetoAuditoria.IdAuditoria = _objetoAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objetoAuditoria.FechaAuditoria = _objetoAuditoria.FechaExactaAuditoria(_tipoCon)
            _objetoAuditoria.FormularioAuditoria = Text.Trim
            _objetoAuditoria.EstadoAuditoria = 1
            _objetoAuditoria.IdUsuarioAuditoria = IdUsuario
            _sqlCommands.Add(_objetoAuditoria.NuevaAuditoria) 
        End Sub

        Private Sub DesabilitadoInicio()
            txtIdParametro.Enabled = False
            txtDetalleParametro.Enabled = False
            btnGuardarParametroDocumentos.Enabled = False
            btnCancelarParametroDocumentos.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtIdParametro.Enabled = False
            txtDetalleParametro.Enabled = True
            btnGuardarParametroDocumentos.Enabled = True
            btnCancelarParametroDocumentos.Enabled = True
            btnNuevoParametroDocumentos.Enabled = False
            btnModificarParametroDocumentos.Enabled = False
            rbDeducible.Enabled = True
            rbNoDeducible.Enabled = True
        End Sub

        Private Sub DesabilitadoCancelar()
            DesabilitadoInicio()
            btnNuevoParametroDocumentos.Enabled = True
            btnModificarParametroDocumentos.Enabled = True
            rbDeducible.Enabled = False
            rbNoDeducible.Enabled = False
        End Sub

        Private Sub LimpiarParametros()
            txtIdParametro.Clear()
            txtDetalleParametro.Clear()
            rbDeducible.Checked = False
            rbNoDeducible.Checked = False
            txtTipoDocumento.Clear()
        End Sub

        Private Function ValidacionParametros() As Boolean
            Return txtDetalleParametro.Text <> "" And txtTipoDocumento.Text <> ""
        End Function

        Private Sub CargarParametrosDocumentos()
            Try
                dgvParametrosDocumentos.DataSource = _objetoParametros.SeleccionarParametrosDocumentos(_tipoCon)
                 
                dgvParametrosDocumentos.Columns(0).HeaderText = "ID" 
                dgvParametrosDocumentos.Columns(1).HeaderText = "DETALLE" 
                dgvParametrosDocumentos.Columns(2).HeaderText = "TIPO" 
                dgvParametrosDocumentos.Columns(3).HeaderText = "EST" 
                dgvParametrosDocumentos.AutoResizeColumns()
                dgvParametrosDocumentos.AutoResizeRows() 
            Catch
                dgvParametrosDocumentos.DataSource = Nothing
            End Try
        End Sub

        Private Sub GuardarParametrosNuevo()
            With _objetoParametros
                .IdParametroDocumentos = _objetoParametros.BuscarMayorIdParametroDocumentos(_tipoCon) + 1
                .NombreParametrosDocumentos = txtDetalleParametro.Text
                .TipoParametroDocumentos = txtTipoDocumento.Text
                .EstadoParametroDocumentos = 1 
            End With
            _sqlCommands.Add(_objetoParametros.NuevoParametrosDocumentos)

            _objetoAuditoria.AccionAuditoria = "CREO UN NUEVO PARAMETRO" + txtIdParametro.Text 
            Auditoria()
        End Sub

        Private Sub GuardarParametrosModificado()
            With _objetoParametros
                .IdParametroDocumentos = txtIdParametro.Text
                .NombreParametrosDocumentos = txtDetalleParametro.Text
                .TipoParametroDocumentos = txtTipoDocumento.Text
                .EstadoParametroDocumentos = 1
            End With
            _sqlCommands.Add(_objetoParametros.ModificarParametrosDocumentos)

            _objetoAuditoria.AccionAuditoria = "MODIFICO UN PARAMETRO" + txtIdParametro.Text 
            Auditoria()
        End Sub
        Private Sub btnNuevoParametroDocumentos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoParametroDocumentos.Click
            HabilitadoNuevo()
            LimpiarParametros()
            _botonSeleccionado = 1
        End Sub
        Private Sub btnModificarParametroDocumentos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarParametroDocumentos.Click
            HabilitadoNuevo()
            _botonSeleccionado = 2
        End Sub
        Private Sub btnGuardarParametroDocumentos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarParametroDocumentos.Click
            If ValidacionParametros() Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()
                 
                Select Case (_botonSeleccionado)
                    Case 1 : GuardarParametrosNuevo()
                    Case 2 : GuardarParametrosModificado()
                End Select

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    DesabilitadoCancelar()
                    CargarParametrosDocumentos()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema") 
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                txtDetalleParametro.Focus()
            End If
        End Sub
        Private Sub btnCancelarParametroDocumentos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarParametroDocumentos.Click
            LimpiarParametros()
            DesabilitadoCancelar()
        End Sub

        Private Sub FormParametrosDocumentos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvParametrosDocumentos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvParametrosDocumentos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvParametrosDocumentos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvParametrosDocumentos.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            DesabilitadoInicio()
            CargarParametrosDocumentos()
        End Sub

        Private Sub rbDeducible_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbDeducible.CheckedChanged
            If rbDeducible.Checked Then txtTipoDocumento.Text = rbDeducible.Text
        End Sub

        Private Sub rbNoDeducible_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNoDeducible.CheckedChanged
            If rbNoDeducible.Checked Then txtTipoDocumento.Text = rbNoDeducible.Text 
        End Sub

        Private Sub dgvParametrosDocumentos_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvParametrosDocumentos.CellClick
            If dgvParametrosDocumentos.RowCount = 0 Or dgvParametrosDocumentos.CurrentRow Is Nothing Then Return
            If dgvParametrosDocumentos.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                MsgBox("La tabla PARAMETROS DOCUMENTOS esta vacía", MsgBoxStyle.Information, "Mensaje de Información")
            Else
                txtIdParametro.Text = dgvParametrosDocumentos.CurrentRow.Cells.Item(0).Value
                txtDetalleParametro.Text = dgvParametrosDocumentos.CurrentRow.Cells.Item(1).Value.ToString
                txtTipoDocumento.Text = dgvParametrosDocumentos.CurrentRow.Cells.Item(2).Value.ToString

                btnModificarParametroDocumentos.Enabled = True
            End If
        End Sub
    End Class
End Namespace