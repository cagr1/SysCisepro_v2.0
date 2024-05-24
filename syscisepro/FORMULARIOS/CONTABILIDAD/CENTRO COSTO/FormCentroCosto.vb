Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.CENTRO_COSTO.REPORTES

Namespace FORMULARIOS.CONTABILIDAD.CENTRO_COSTO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormCentroCosto
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

        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        Public ReadOnly ObjAuditoria As New ClassAuditoriaGeneral

        Dim _botonSeleccionado As Integer

        Private Sub DesabilitadoInicio() 'Desabilita lo que no tiene que cargase al inicio del formulario
            txtIdCentroCosto.Enabled = False
            txtDetalleCentroCosto.Enabled = False
            txtCodigoCentroCosto.Enabled = False
            btnGuardarCentroCosto.Enabled = False
            btnReporteCentroCosto.Enabled = False
            btnNuevoCentroCosto.Enabled = True
            btnModificarCentroCosto.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtIdCentroCosto.Enabled = False
            txtDetalleCentroCosto.Enabled = True
            txtCodigoCentroCosto.Enabled = True
            btnGuardarCentroCosto.Enabled = True
            btnReporteCentroCosto.Enabled = True
            btnNuevoCentroCosto.Enabled = False
            btnModificarCentroCosto.Enabled = False
        End Sub

        Private Sub DesabilitadoCancelar()
            desabilitadoInicio()
            btnNuevoCentroCosto.Enabled = True
            btnModificarCentroCosto.Enabled = True
            btnReporteCentroCosto.Enabled = True
        End Sub

        Private Function ValidacionParametros() As Boolean
            Return txtIdCentroCosto.Text <> "" And txtDetalleCentroCosto.Text <> "" And txtCodigoCentroCosto.Text <> "" 
        End Function

        Private Sub LimpiarParametros()
            txtIdCentroCosto.Text = ""
            txtDetalleCentroCosto.Text = ""
            txtCodigoCentroCosto.Text = ""
        End Sub

        Private Sub CargarCentroCosto()
            Try
                dgvCentroCosto.DataSource = _objetoCentroCosto.SeleccionarCentroCosto(_tipoCon)

                dgvCentroCosto.EditMode = DataGridViewEditMode.EditProgrammatically

                dgvCentroCosto.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCentroCosto.Columns(0).HeaderText = "ID"
                dgvCentroCosto.Columns(0).Width = 50

                dgvCentroCosto.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCentroCosto.Columns(1).HeaderText = "DETALLE"
                dgvCentroCosto.Columns(1).Width = 475

                dgvCentroCosto.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCentroCosto.Columns(2).HeaderText = "CODIGO"
                dgvCentroCosto.Columns(2).Width = 80

                dgvCentroCosto.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvCentroCosto.Columns(3).HeaderText = "EST"
                dgvCentroCosto.Columns(3).Width = 40
                 
            Catch
                dgvCentroCosto.DataSource = Nothing
            End Try 
        End Sub

        Private Sub Auditoria()
            With objAuditoria 
                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = idUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = Date.Now
                .NuevaAuditoria(_tipoCon)
            End With
        End Sub

        Private Sub GuardarCentroCostoNuevo()
            With _objetoCentroCosto
                .IdCentroC = txtIdCentroCosto.Text
                .DetalleCentroC = txtDetalleCentroCosto.Text.Trim
                .CodigoCentroC = txtCodigoCentroCosto.Text
                .EstadoCentroC = 1
                .NuevoRegistroCentroCosto(_tipoCon) 
            End With
            objAuditoria.AccionAuditoria = "CREO UN NUEVO CENTRO DE COSTO" + txtIdCentroCosto.Text
            objAuditoria.FormularioAuditoria = Text.ToUpper
            auditoria()
        End Sub

        Private Sub GuardarCentroCostoModificado()
            With _objetoCentroCosto
                .IdCentroC = txtIdCentroCosto.Text
                .DetalleCentroC = txtDetalleCentroCosto.Text.Trim
                .CodigoCentroC = txtCodigoCentroCosto.Text
                .EstadoCentroC = 1
                .ModificarRegistroCentroCosto(_tipoCon) 
            End With
            ObjAuditoria.AccionAuditoria = "ACTUALIZÓ EL CENTRO DE COSTO" + txtIdCentroCosto.Text
            ObjAuditoria.FormularioAuditoria = Text.ToUpper
            Auditoria()
        End Sub
        Private Sub FormCentroCosto_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCentroCosto.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvCentroCosto.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvCentroCosto.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            DesabilitadoInicio()
        End Sub

        Private Sub btnNuevoCentroCosto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevoCentroCosto.Click
            _botonSeleccionado = 1
            limpiarParametros()

            txtIdCentroCosto.Text = _objetoCentroCosto.BuscarMayorIdCentroCosto(_tipoCon) + 1
            habilitadoNuevo()
        End Sub
        Private Sub btnModificarCentroCosto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModificarCentroCosto.Click
            _botonSeleccionado = 2
            habilitadoNuevo()
        End Sub
        Private Sub btnGuardarCentroCosto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardarCentroCosto.Click
            If MessageBox.Show("Seguro que desea guardar los cambios realizados?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
            
            If ValidacionParametros() Then
                Select Case (_botonSeleccionado)
                    Case 1 : GuardarCentroCostoNuevo()
                    Case 2 : GuardarCentroCostoModificado()
                End Select

                DesabilitadoCancelar()
                CargarCentroCosto()
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                txtIdCentroCosto.Focus()
            End If
        End Sub
        Private Sub btnCancelarCentroCosto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReporteCentroCosto.Click
            LimpiarParametros()
            desabilitadoCancelar()
        End Sub

        Private Sub btnReporteCentroCosto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            Dim f = New FormReporteCentrosCosto
            f.TipoCox = TipoCox
            f.Show()
        End Sub

        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            cargarCentroCosto()
        End Sub

        Private Sub dgvCentroCosto_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvCentroCosto.SelectionChanged
            If dgvCentroCosto.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdCentroCosto.Text = ""
            Else
                txtIdCentroCosto.Text = dgvCentroCosto.CurrentRow.Cells.Item(0).Value
                txtDetalleCentroCosto.Text = dgvCentroCosto.CurrentRow.Cells.Item(1).Value.ToString.ToUpper
                txtCodigoCentroCosto.Text = dgvCentroCosto.CurrentRow.Cells.Item(2).Value.ToString.ToUpper
                btnModificarCentroCosto.Enabled = True
            End If
        End Sub
    End Class
End Namespace