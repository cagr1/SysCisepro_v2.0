Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports Krypton.Toolkit
Imports syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS

Public Class FormGrupo
    Private _tipoCon As TipoConexion
    Dim _sqlCommands As List(Of SqlCommand)
    Public Usuario As String
    Dim _botonSeleccionadoSitio As Integer = 0


    ReadOnly _objetoSitio As New ClassSitiosTrabajo
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

    Private Sub FormGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _tipoCon
            Case TipoConexion.Asenava
                Icon = My.Resources.logo_a
                dgvGrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
            Case TipoConexion.Seportpac
                Icon = My.Resources.logo_s
                dgvGrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
            Case Else
                Icon = My.Resources.logo_c
                dgvGrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
        End Select
        dgvGrupos.Font = New Font("Roboto", 8, FontStyle.Regular)
        _sqlCommands = New List(Of SqlCommand)

        llenarGrupos()
    End Sub


    Private Sub llenarGrupos()
        Dim data = _objetoSitio.SeleccionarGruposSitioTrabajo(_tipoCon)
        dgvGrupos.DataSource = data
        dgvGrupos.Columns(0).HeaderText = "GRUPOS"
        dgvGrupos.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGrupos.DefaultCellStyle.SelectionForeColor = Color.White
        dgvGrupos.AutoResizeColumns()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtNombre.Text = "" Then
                KryptonMessageBox.Show("Debe ingresar un nombre para el grupo", "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If

            _botonSeleccionadoSitio = 1
            txtNombre.Text = ""
            txtNombre.Enabled = True


        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtNombre.Text = "" Then
                KryptonMessageBox.Show("No ha seleccionado grupo para editar", "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If

            _botonSeleccionadoSitio = 2
            txtNombre.Enabled = True

        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            Return
        End Try
    End Sub



    Private Sub dgvGrupos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvGrupos.SelectionChanged
        Try
            If dgvGrupos.SelectedRows.Count > 0 Then
                txtNombre.Text = dgvGrupos.SelectedRows(0).Cells(0).Value.ToString()
            End If
        Catch ex As Exception
            KryptonMessageBox.Show("Error al seleccionar: " & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            Exit Try
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If txtNombre.Text = "" Then
                KryptonMessageBox.Show("No ha seleccionado grupo para editar", "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If
            _sqlCommands.Clear()
            Dim g = _objetoSitio.SeleccionarGruposSitioTrabajo(_tipoCon, txtNombre.Text)
            If _botonSeleccionadoSitio = 1 Then
                If g.Rows.Count = 0 Then
                    _sqlCommands.Add(_objetoSitio.GuardarGruposSitioTrabajoCommand(txtNombre.Text.ToUpper()))
                Else
                    KryptonMessageBox.Show("El grupo ya existe", "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End If

            ElseIf _botonSeleccionadoSitio = 2 Then
                If g.Rows.Count = 0 Then
                    _sqlCommands.Add(_objetoSitio.EditarGruposSitioTrabajoCommand(dgvGrupos.SelectedRows(0).Cells(0).Value.ToString(), txtNombre.Text.ToUpper()))
                Else
                    KryptonMessageBox.Show("El grupo ya existe", "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End If

            End If

            Dim nombreU As String = ""
            If _botonSeleccionadoSitio = 1 Then
                nombreU = "Ingreso de nuevo grupo por: " & Usuario
            ElseIf _botonSeleccionadoSitio = 2 Then
                nombreU = "Grupo editado por: " & Usuario
            End If

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then

                txtNombre.Enabled = False
                llenarGrupos()
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                KryptonMessageBox.Show(res(1), "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If


        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            Return
        End Try
    End Sub
End Class