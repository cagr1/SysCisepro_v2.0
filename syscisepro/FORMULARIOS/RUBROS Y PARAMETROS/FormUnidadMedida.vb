Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.PARAMETROS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.RUBROS_Y_PARAMETROS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormUnidadMedida
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

        Private ReadOnly _objetoAuditoria As New ClassAuditoriaGeneral
        Private ReadOnly _objetoUnidadMedida As New ClassUnidadMedida
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
            txtIdUnidadMedida.Enabled = False
            txtDetalleUnidadMedida.Enabled = False
            txtCodigoUnidadMedida.Enabled = False
            btnGuardarUnidadMedida.Enabled = False
            btnCancelarUnidadMedida.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtIdUnidadMedida.Enabled = False
            txtDetalleUnidadMedida.Enabled = True
            txtCodigoUnidadMedida.Enabled = True
            btnGuardarUnidadMedida.Enabled = True
            btnCancelarUnidadMedida.Enabled = True
            btnNuevoUnidadMedida.Enabled = False
            btnModificarUnidadMedida.Enabled = False
        End Sub

        Private Sub DesabilitadoCancelar()
            DesabilitadoInicio()
            btnNuevoUnidadMedida.Enabled = True
            btnModificarUnidadMedida.Enabled = True
        End Sub

        Private Sub LimpiarParametros()
            txtIdUnidadMedida.Text = ""
            txtDetalleUnidadMedida.Text = ""
            txtCodigoUnidadMedida.Text = ""
        End Sub

        Private Function ValidacionParametros() As Boolean
            Return txtDetalleUnidadMedida.Text <> "" And txtCodigoUnidadMedida.Text <> ""
        End Function

        Private Sub CargarUnidadMedida()
            Try
                dgvUnidadMedida.DataSource = _objetoUnidadMedida.SeleccionarRegistrosUnidadMedida(_tipoCon)

                dgvUnidadMedida.Columns(0).HeaderText = "ID" 
                dgvUnidadMedida.Columns(1).HeaderText = "DETALLE UNIDAD MEDIDA" 
                dgvUnidadMedida.Columns(2).HeaderText = "CODIGO" 
                dgvUnidadMedida.Columns(3).HeaderText = "EST" 
                dgvUnidadMedida.AutoResizeColumns()
                dgvUnidadMedida.AutoResizeRows() 
            Catch
                dgvUnidadMedida.DataSource = Nothing
            End Try
        End Sub

        Private Sub GuardarUnidadMedidaNuevo()
            With _objetoUnidadMedida
                .IdUnidadMedida = _objetoUnidadMedida.BuscarMayorIdUnidadMedida(_tipoCon) + 1
                .DetalleUnidadMedida = txtDetalleUnidadMedida.Text
                .CodigoUnidadMedida = txtCodigoUnidadMedida.Text
                .EstadoUnidadMedida = 1
            End With
            _sqlCommands.Add(_objetoUnidadMedida.NuevoRegistroUnidadMedida)

            _objetoAuditoria.AccionAuditoria = "CREO UNA NUEVA UNIDAD DE MEDIDA" + txtIdUnidadMedida.Text
            Auditoria()
        End Sub

        Private Sub GuardarUnidadMedidaModificado()
            With _objetoUnidadMedida
                .IdUnidadMedida = txtIdUnidadMedida.Text
                .DetalleUnidadMedida = txtDetalleUnidadMedida.Text 
                .CodigoUnidadMedida = txtCodigoUnidadMedida.Text
                .EstadoUnidadMedida = 1 
            End With
            _sqlCommands.Add(_objetoUnidadMedida.ModificarRegistroUnidadMedida)

            _objetoAuditoria.AccionAuditoria = "MODIFICO UNA UNIDAD DE MEDIDA" + txtIdUnidadMedida.Text
            Auditoria()
        End Sub

        Private Sub FormUnidadMedida_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvUnidadMedida.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvUnidadMedida.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvUnidadMedida.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvUnidadMedida.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            DesabilitadoInicio()
            CargarUnidadMedida()
        End Sub

        Private Sub btnNuevoUnidadMedida_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoUnidadMedida.Click
            _botonSeleccionado = 1
            HabilitadoNuevo()
            LimpiarParametros()
        End Sub
        Private Sub btnModificarUnidadMedida_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarUnidadMedida.Click
            _botonSeleccionado = 2
            HabilitadoNuevo()
        End Sub
        Private Sub btnGuardarUnidadMedida_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarUnidadMedida.Click
            If ValidacionParametros() Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                Select Case (_botonSeleccionado)
                    Case 1 : GuardarUnidadMedidaNuevo()
                    Case 2 : GuardarUnidadMedidaModificado()
                End Select

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    DesabilitadoCancelar()
                    CargarUnidadMedida()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Information, "MENSAJE DE VALIDACION")
            End If
        End Sub
        Private Sub btnCancelarUnidadMedida_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarUnidadMedida.Click
            LimpiarParametros()
            DesabilitadoCancelar()
        End Sub
         
        Private Sub dgvUnidadMedida_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUnidadMedida.SelectionChanged
            If dgvUnidadMedida.RowCount = 0 Or dgvUnidadMedida.CurrentRow Is Nothing Then Return
            If dgvUnidadMedida.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                MsgBox("La tabla UNIDAD MEDIDA esta vacía", MsgBoxStyle.Information, "Mensaje de Información")
            Else
                txtIdUnidadMedida.Text = dgvUnidadMedida.CurrentRow.Cells.Item(0).Value
                txtDetalleUnidadMedida.Text = dgvUnidadMedida.CurrentRow.Cells.Item(1).Value.ToString
                txtCodigoUnidadMedida.Text = dgvUnidadMedida.CurrentRow.Cells.Item(2).Value.ToString
                btnModificarUnidadMedida.Enabled = True
            End If
        End Sub
    End Class
End Namespace