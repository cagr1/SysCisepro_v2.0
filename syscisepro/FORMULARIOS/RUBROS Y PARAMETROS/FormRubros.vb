Imports System.Data.SqlClient
Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports Krypton.Toolkit

Namespace FORMULARIOS.RUBROS_Y_PARAMETROS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormRubros
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

        ReadOnly _objetoRubros As New ClassRubrosFondoRotativo
        Dim _botonSeleccionado As New Integer

        Private Sub DesabilitadoInicio() 'Desabilita lo que no tiene que cargase al inicio del formulario
            txtIdRubro.Enabled = False
            cmbRubro.Enabled = False
            txtValorRubro.Enabled = False
            btnGuardarRubroFondoRotativo.Enabled = False
            btnCancelarRubroFondorotativo.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtIdRubro.Enabled = False
            cmbRubro.Enabled = True
            txtValorRubro.Enabled = True
            btnGuardarRubroFondoRotativo.Enabled = True
            btnCancelarRubroFondorotativo.Enabled = True
            btnNuevoRubroFondoRotativo.Enabled = False
        End Sub

        Private Sub DesabilitadoCancelar()
            DesabilitadoInicio()
            btnNuevoRubroFondoRotativo.Enabled = True
            btnGuardarRubroFondoRotativo.Enabled = False
        End Sub

        Private Sub LimpiarParametros()
            txtIdRubro.Text = ""
            cmbRubro.Text = ""
            txtValorRubro.Text = ""
        End Sub

        Private Sub CargarRubrosFondoRotativo()
            Try
                dgvRubrosFondoRotativo.DataSource = _objetoRubros.SeleccionarRegistrosRubros(_tipoCon)

                dgvRubrosFondoRotativo.Columns(0).HeaderText = "ID"
                dgvRubrosFondoRotativo.Columns(1).HeaderText = "NOMBRE"
                dgvRubrosFondoRotativo.Columns(2).HeaderText = "VALOR"
                dgvRubrosFondoRotativo.Columns(3).HeaderText = "EST."
                dgvRubrosFondoRotativo.AutoResizeColumns()
                dgvRubrosFondoRotativo.AutoResizeRows()
                dgvRubrosFondoRotativo.ReadOnly = True
            Catch
                dgvRubrosFondoRotativo.DataSource = Nothing
            End Try
        End Sub

        Private Sub GuardarRubros()
            With _objetoRubros
                .IdRubro = _objetoRubros.BuscarMayorIdRubros(_tipoCon) + 1
                .NombreRubro = cmbRubro.Text.Trim
                .ValorRubro = txtValorRubro.Text
                .EstadoRubro = 1
            End With
            _sqlCommands.Add(_objetoRubros.NuevoRegistroRubros)
        End Sub

        Private Sub GuardarRubrosModificado()
            With _objetoRubros
                .IdRubro = txtIdRubro.Text
                .NombreRubro = cmbRubro.Text.Trim
                .ValorRubro = txtValorRubro.Text
                .EstadoRubro = 1
            End With
            _sqlCommands.Add(_objetoRubros.ModificarRegistrosRubros)
        End Sub

        Private Function ValidacionParametros() As Boolean
            Return cmbRubro.Text <> "" And txtValorRubro.Text <> ""
        End Function

        Private Sub btnNuevoRubroFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoRubroFondoRotativo.Click
            HabilitadoNuevo()
            LimpiarParametros()
            _botonSeleccionado = 1
        End Sub
        Private Sub btnModificarRubroFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarRubroFondoRotativo.Click
            _botonSeleccionado = 2
            HabilitadoNuevo() 
        End Sub
        Private Sub btnCancelarRubroFondorotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarRubroFondorotativo.Click
            LimpiarParametros()
            DesabilitadoCancelar()
        End Sub
        Private Sub btnGuardarRubroFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarRubroFondoRotativo.Click
            If ValidacionParametros() Then
                If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                Select Case (_botonSeleccionado)
                    Case 1 : GuardarRubros()
                    Case 2 : GuardarRubrosModificado()
                End Select
              
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then

                    DesabilitadoCancelar()
                    CargarRubrosFondoRotativo()
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                'MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No se han llenado todos los campos necesarios.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub dgvRubrosFondoRotativo_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvRubrosFondoRotativo.CellClick
            If dgvRubrosFondoRotativo.RowCount = 0 Or dgvRubrosFondoRotativo.CurrentRow Is Nothing Then Return
            If dgvRubrosFondoRotativo.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdRubro.Text = ""
            Else
                txtIdRubro.Text = dgvRubrosFondoRotativo.CurrentRow.Cells.Item(0).Value
                cmbRubro.Text = dgvRubrosFondoRotativo.CurrentRow.Cells.Item(1).Value
                txtValorRubro.Text = dgvRubrosFondoRotativo.CurrentRow.Cells.Item(2).Value
                dgvRubrosFondoRotativo.Rows(dgvRubrosFondoRotativo.CurrentCell.RowIndex.ToString()).Selected = True
                btnModificarRubroFondoRotativo.Enabled = True
            End If
        End Sub

        Private Sub FormRubros_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvRubrosFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvRubrosFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvRubrosFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvRubrosFondoRotativo.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            DesabilitadoInicio()
            CargarRubrosFondoRotativo()
        End Sub

        Private Sub cmbRubro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRubro.KeyPress
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End Sub
    End Class
End Namespace