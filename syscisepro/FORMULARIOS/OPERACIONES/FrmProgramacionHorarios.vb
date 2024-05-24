Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports ClassLibraryCisepro.ProcesosSql
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmProgramacionHorarios
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

        Private _hoy As DateTime
        Dim _estadoAccion As Integer = 0
        Dim _diasuma As Integer = 0
        ReadOnly _objetoHorario As New ClassHorariosOperacion

        ReadOnly _crHorariosOperacionCisepro As New rptHorariosOperacion

        Private Sub FrmProgramacionHorarios_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label21.ForeColor = Color.White
                    Label21.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvHorarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    Label21.ForeColor = Color.White
                    Label21.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvHorarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    Label21.ForeColor = Color.White
                    Label21.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvHorarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _hoy = DateTime.Now
            ResetTimes()
            _sqlCommands = New List(Of SqlCommand)

            LlenarComboCategoria()
        End Sub

        Private Sub LlenarComboCategoria()
            Try
                Dim data = _objetoHorario.SeleccionarCategoriasHorariosOperacion(_tipoCon)
                For Each row As DataRow In data.Rows
                    cbmCategoria.Items.Add(row.Item(0))
                Next
            Catch
                cbmCategoria.DataSource = Nothing
            End Try
        End Sub

        Private Sub ResetTimes()
            dtpDeLunes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpALunes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDeMartes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAMartes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDeMiercoles.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAMiercoles.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDeJueves.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAJueves.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDeViernes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAViernes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDeSabado.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpASabado.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDeDomingo.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpADomingo.Value = _hoy.ToShortDateString & " 00:00:00"
        End Sub

        Private Sub EnableChekTimes(ByVal enable As Boolean, ByVal enableDtp As Boolean)
            chkLunes.Enabled = enable
            chkMartes.Enabled = enable
            chkMiercoles.Enabled = enable
            chkJueves.Enabled = enable
            chkViernes.Enabled = enable
            chkSabado.Enabled = enable
            chkDomingo.Enabled = enable

            dtpDeLunes.Enabled = enableDtp
            dtpALunes.Enabled = enableDtp
            dtpDeMartes.Enabled = enableDtp
            dtpAMartes.Enabled = enableDtp
            dtpDeMiercoles.Enabled = enableDtp
            dtpAMiercoles.Enabled = enableDtp
            dtpDeJueves.Enabled = enableDtp
            dtpAJueves.Enabled = enableDtp
            dtpDeViernes.Enabled = enableDtp
            dtpAViernes.Enabled = enableDtp
            dtpDeSabado.Enabled = enableDtp
            dtpASabado.Enabled = enableDtp
            dtpDeDomingo.Enabled = enableDtp
            dtpADomingo.Enabled = enableDtp
        End Sub

        Private Sub CheckedChekTimes(ByVal checked As Boolean)
            chkLunes.Checked = checked
            chkMartes.Checked = checked
            chkMiercoles.Checked = checked
            chkJueves.Checked = checked
            chkViernes.Checked = checked
            chkSabado.Checked = checked
            chkDomingo.Checked = checked
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            txtDefinicion.Enabled = True
            txtDefinicion.Clear()
            txtObservacion.Clear()

            LlenarComboCategoria()

            EnableChekTimes(True, False)
            CheckedChekTimes(False)
            ResetTimes()

            txtTotalHoras.Text = 0
            txtHorasRegular.Enabled = True
            txtHorasRegular.Text = 0
            txtRecargoNocturno.Enabled = True
            txtRecargoNocturno.Text = 0
            txtHoras50.Enabled = True
            txtHoras50.Text = 0
            txtHoras100.Enabled = True
            txtHoras100.Text = 0

            txtObservacion.Enabled = True
            btnCalcular.Enabled = True
            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnAnular.Enabled = False
            btnCancelar.Enabled = True

            _estadoAccion = 1
            CmbTipo.SelectedIndex = 1

            txtIdHorario.Text = _objetoHorario.BuscarMayorIdHorarios(_tipoCon) + 1

        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Try
                If MessageBox.Show("Está seguro que desea guardar los cambios realizados", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If

                If txtHorasRegular.Text.Trim.Length = 0 Then
                    MessageBox.Show("Debe definir los horarios para guardar (Presione el botón 'CALCULAR')!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                Dim dias = GetDias()
                Dim lunes = dtpDeLunes.Text & " ~ " & dtpALunes.Text
                Dim martes = dtpDeMartes.Text & " ~ " & dtpAMartes.Text
                Dim miercoles = dtpDeMiercoles.Text & " ~ " & dtpAMiercoles.Text
                Dim jueves = dtpDeJueves.Text & " ~ " & dtpAJueves.Text
                Dim viernes = dtpDeViernes.Text & " ~ " & dtpAViernes.Text
                Dim sabado = dtpDeSabado.Text & " ~ " & dtpASabado.Text
                Dim domingo = dtpDeDomingo.Text & " ~ " & dtpADomingo.Text

                If _objetoHorario.ExisteHorarioOperacion(_tipoCon, txtIdHorario.Text, dias, lunes, martes, miercoles, jueves, viernes, sabado, domingo) > 0 Then
                    MessageBox.Show("Ya existe un horario registrado con los mismos días y horas!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                _sqlCommands.Clear()
                If _estadoAccion = 1 Then ' nuevo
                    With _objetoHorario

                        .IdHorario = .BuscarMayorIdHorarios(_tipoCon) + 1
                        .Detalle = txtDefinicion.Text
                        .Dias = dias
                        .Lunes = lunes
                        .Martes = martes
                        .Miercoles = miercoles
                        .Jueves = jueves
                        .Viernes = viernes
                        .Sabado = sabado
                        .Domingo = domingo
                        .HoraRegular = txtHorasRegular.Text
                        .RecNocturno = txtRecargoNocturno.Text
                        .Horas50 = txtHoras50.Text
                        .Horas100 = txtHoras100.Text
                        .Estado = 1
                        .Observacion = txtObservacion.Text
                        .Tipo = CmbTipo.SelectedIndex
                        .Categoria = cbmCategoria.Text
                        .Totalhoras = Convert.ToDecimal(txtTotalHoras.Text)
                        .Ludi = If(HoraEstaEnElDia(HoraString(dtpDeLunes.Text & ":00")), 1, 0)
                        .Madi = If(HoraEstaEnElDia(HoraString(dtpDeMartes.Text & ":00")), 1, 0)
                        .Midi = If(HoraEstaEnElDia(HoraString(dtpDeMiercoles.Text & ":00")), 1, 0)
                        .Judi = If(HoraEstaEnElDia(HoraString(dtpDeJueves.Text & ":00")), 1, 0)
                        .Vidi = If(HoraEstaEnElDia(HoraString(dtpDeViernes.Text & ":00")), 1, 0)
                        .Sadi = If(HoraEstaEnElDia(HoraString(dtpDeSabado.Text & ":00")), 1, 0)
                        .Dodi = If(HoraEstaEnElDia(HoraString(dtpDeDomingo.Text & ":00")), 1, 0)
                        '.NuevoHorarioOperacion()
                    End With
                    _sqlCommands.Add(_objetoHorario.RegistrarNuevoHorarioOperacionCommand())
                End If

                If _estadoAccion = 2 Then ' modificar
                    With _objetoHorario
                        .IdHorario = txtIdHorario.Text
                        .Detalle = txtDefinicion.Text
                        .Dias = dias
                        .Lunes = lunes
                        .Martes = martes
                        .Miercoles = miercoles
                        .Jueves = jueves
                        .Viernes = viernes
                        .Sabado = sabado
                        .Domingo = domingo
                        .HoraRegular = txtHorasRegular.Text
                        .RecNocturno = txtRecargoNocturno.Text
                        .Horas50 = txtHoras50.Text
                        .Horas100 = txtHoras100.Text
                        .Observacion = txtObservacion.Text
                        .Tipo = CmbTipo.SelectedIndex
                        .Categoria = cbmCategoria.Text
                        .Totalhoras = Convert.ToDecimal(txtTotalHoras.Text)
                        .Ludi = If(HoraEstaEnElDia(HoraString(dtpDeLunes.Text & ":00")), 1, 0)
                        .Madi = If(HoraEstaEnElDia(HoraString(dtpDeMartes.Text & ":00")), 1, 0)
                        .Midi = If(HoraEstaEnElDia(HoraString(dtpDeMiercoles.Text & ":00")), 1, 0)
                        .Judi = If(HoraEstaEnElDia(HoraString(dtpDeJueves.Text & ":00")), 1, 0)
                        .Vidi = If(HoraEstaEnElDia(HoraString(dtpDeViernes.Text & ":00")), 1, 0)
                        .Sadi = If(HoraEstaEnElDia(HoraString(dtpDeSabado.Text & ":00")), 1, 0)
                        .Dodi = If(HoraEstaEnElDia(HoraString(dtpDeDomingo.Text & ":00")), 1, 0)
                        '.EditarHorarioOperacion()
                    End With
                    _sqlCommands.Add(_objetoHorario.ModificarHorarioOperacionCommand())
                End If

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    txtDefinicion.Enabled = False

                    EnableChekTimes(False, False)

                    txtHorasRegular.Enabled = False
                    txtRecargoNocturno.Enabled = False
                    txtHoras50.Enabled = False
                    txtHoras100.Enabled = False

                    txtObservacion.Enabled = False
                    btnCalcular.Enabled = False
                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnModificar.Enabled = True
                    btnAnular.Enabled = True
                    btnCancelar.Enabled = False
                    _estadoAccion = 0

                    CmbTipo.Enabled = False
                    cbmCategoria.Enabled = False

                    txtFiltro.Clear()
                    CargarHorariosOperacion(String.Empty)
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Catch ex As Exception
                MsgBox("ERROR AL GUARDAR HORARIO DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End Try
        End Sub

        Private Function GetDias() As String
            Dim dias = ""
            If chkLunes.Checked Then
                dias = dias + "LU;"
            End If
            If chkMartes.Checked Then
                dias = dias + "MA;"
            End If
            If chkMiercoles.Checked Then
                dias = dias + "MI;"
            End If
            If chkJueves.Checked Then
                dias = dias + "JU;"
            End If
            If chkViernes.Checked Then
                dias = dias + "VI;"
            End If
            If chkSabado.Checked Then
                dias = dias + "SA;"
            End If
            If chkDomingo.Checked Then
                dias = dias + "DO;"
            End If
            Return dias.Substring(0, dias.Length - 1)
        End Function

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            txtDefinicion.Enabled = True

            EnableChekTimes(True, True)

            txtHorasRegular.Enabled = True
            txtRecargoNocturno.Enabled = True
            txtHoras50.Enabled = True
            txtHoras100.Enabled = True

            _estadoAccion = 2

            txtObservacion.Enabled = True
            btnCalcular.Enabled = True
            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnAnular.Enabled = False
            btnCancelar.Enabled = True

            CmbTipo_SelectedIndexChanged(Nothing, Nothing)
        End Sub

        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnular.Click
            Try
                If MessageBox.Show("Seguro que desea anular el horario seleccionado?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If

                _sqlCommands.Clear()
                With _objetoHorario
                    .IdHorario = txtIdHorario.Text
                    .Estado = 0
                    .EditarEstadoHorarioOperacion(_tipoCon)
                End With
                _sqlCommands.Add(_objetoHorario.ModificarEstadoHorarioOperacionCommand())

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    txtDefinicion.Enabled = False
                    txtDefinicion.Clear()
                    txtObservacion.Clear()

                    EnableChekTimes(False, False)
                    CheckedChekTimes(False)
                    ResetTimes()

                    txtHorasRegular.Enabled = False
                    txtRecargoNocturno.Enabled = False
                    txtHoras50.Enabled = False
                    txtHoras100.Enabled = False
                    CmbTipo.Enabled = False
                    cbmCategoria.Enabled = False
                    txtObservacion.Enabled = False
                    btnCalcular.Enabled = False
                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnModificar.Enabled = False
                    btnAnular.Enabled = False
                    btnCancelar.Enabled = False
                    _estadoAccion = 0
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                MsgBox("ERROR AL GUARDAR HORARIO DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End Try
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            txtDefinicion.Enabled = False
            txtDefinicion.Clear()
            txtObservacion.Clear()

            EnableChekTimes(False, False)
            CheckedChekTimes(False)
            ResetTimes()

            txtHorasRegular.Enabled = False
            txtRecargoNocturno.Enabled = False
            txtHoras50.Enabled = False
            txtHoras100.Enabled = False
            CmbTipo.Enabled = False
            cbmCategoria.Enabled = False
            txtObservacion.Enabled = False
            btnCalcular.Enabled = False
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnAnular.Enabled = True
            btnCancelar.Enabled = False
            _estadoAccion = 0
        End Sub

        Private Sub chkLunes_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkLunes.CheckedChanged
            If _estadoAccion = 0 Then Return
            If chkLunes.Checked Then
                dtpDeLunes.Enabled = True
                dtpALunes.Enabled = True
                dtpDeLunes.Value = _hoy.ToShortDateString & " 08:00:00"
                dtpALunes.Value = _hoy.ToShortDateString & " 17:00:00"
            Else
                dtpDeLunes.Enabled = False
                dtpALunes.Enabled = False
                dtpDeLunes.Value = _hoy.ToShortDateString & " 00:00:00"
                dtpALunes.Value = _hoy.ToShortDateString & " 00:00:00"
            End If
        End Sub

        Private Sub chkMartes_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkMartes.CheckedChanged
            If _estadoAccion = 0 Then Return
            If chkMartes.Checked Then
                dtpDeMartes.Enabled = True
                dtpAMartes.Enabled = True
                dtpDeMartes.Value = _hoy.ToShortDateString & " 08:00:00"
                dtpAMartes.Value = _hoy.ToShortDateString & " 17:00:00"
            Else
                dtpDeMartes.Enabled = False
                dtpAMartes.Enabled = False
                dtpDeMartes.Value = _hoy.ToShortDateString & " 00:00:00"
                dtpAMartes.Value = _hoy.ToShortDateString & " 00:00:00"
            End If
        End Sub

        Private Sub chkMiercoles_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkMiercoles.CheckedChanged
            If _estadoAccion = 0 Then Return
            If chkMiercoles.Checked Then
                dtpDeMiercoles.Enabled = True
                dtpAMiercoles.Enabled = True
                dtpDeMiercoles.Value = _hoy.ToShortDateString & " 08:00:00"
                dtpAMiercoles.Value = _hoy.ToShortDateString & " 17:00:00"
            Else
                dtpDeMiercoles.Enabled = False
                dtpAMiercoles.Enabled = False
                dtpDeMiercoles.Value = _hoy.ToShortDateString & " 00:00:00"
                dtpAMiercoles.Value = _hoy.ToShortDateString & " 00:00:00"
            End If
        End Sub

        Private Sub chkJueves_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkJueves.CheckedChanged
            If _estadoAccion = 0 Then Return
            If chkJueves.Checked Then
                dtpDeJueves.Enabled = True
                dtpAJueves.Enabled = True
                dtpDeJueves.Value = _hoy.ToShortDateString & " 08:00:00"
                dtpAJueves.Value = _hoy.ToShortDateString & " 17:00:00"
            Else
                dtpDeJueves.Enabled = False
                dtpAJueves.Enabled = False
                dtpDeJueves.Value = _hoy.ToShortDateString & " 00:00:00"
                dtpAJueves.Value = _hoy.ToShortDateString & " 00:00:00"
            End If
        End Sub

        Private Sub chkViernes_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkViernes.CheckedChanged
            If _estadoAccion = 0 Then Return
            If chkViernes.Checked Then
                dtpDeViernes.Enabled = True
                dtpAViernes.Enabled = True
                dtpDeViernes.Value = _hoy.ToShortDateString & " 08:00:00"
                dtpAViernes.Value = _hoy.ToShortDateString & " 17:00:00"
            Else
                dtpDeViernes.Enabled = False
                dtpAViernes.Enabled = False
                dtpDeViernes.Value = _hoy.ToShortDateString & " 00:00:00"
                dtpAViernes.Value = _hoy.ToShortDateString & " 00:00:00"
            End If
        End Sub

        Private Sub chkSabado_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkSabado.CheckedChanged
            If _estadoAccion = 0 Then Return
            If chkSabado.Checked Then
                dtpDeSabado.Enabled = True
                dtpASabado.Enabled = True
                dtpDeSabado.Value = _hoy.ToShortDateString & " 08:00:00"
                dtpASabado.Value = _hoy.ToShortDateString & " 17:00:00"
            Else
                dtpDeSabado.Enabled = False
                dtpASabado.Enabled = False
                dtpDeSabado.Value = _hoy.ToShortDateString & " 00:00:00"
                dtpASabado.Value = _hoy.ToShortDateString & " 00:00:00"
            End If
        End Sub

        Private Sub chkDomingo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkDomingo.CheckedChanged
            If _estadoAccion = 0 Then Return
            If chkDomingo.Checked Then
                dtpDeDomingo.Enabled = True
                dtpADomingo.Enabled = True
                dtpDeDomingo.Value = _hoy.ToShortDateString & " 08:00:00"
                dtpADomingo.Value = _hoy.ToShortDateString & " 17:00:00"
            Else
                dtpDeDomingo.Enabled = False
                dtpADomingo.Enabled = False
                dtpDeDomingo.Value = _hoy.ToShortDateString & " 00:00:00"
                dtpADomingo.Value = _hoy.ToShortDateString & " 00:00:00"
            End If
        End Sub

        Private Function HoraString(ByVal hora As Date) As String
            Dim h = If(hora.Hour < 10, ("0" & hora.Hour), hora.Hour) & ":" & If(hora.Minute < 10, ("0" & hora.Minute), hora.Minute) & ":00"
            Return h
        End Function

        Private Function HoraEstaEnElDia(ByVal hora As String) As Boolean
            Return _objetoHorario.HoraEstaEnRangoHorarioDiurno(_tipoCon, hora)
        End Function

        Private Function HoraEstaEnLaNoche(ByVal hora As String) As Boolean
            Return _objetoHorario.HoraEstaEnRangoHorarioNocturno(_tipoCon, hora)
        End Function

        Private Sub CarcularHorario()
            Dim th = 0.0
            Dim hr = 0.0
            Dim rn = 0.0
            Dim h50 = 0.0
            Dim h100 = 0.0
            Try
                If chkLunes.Checked Then
                    th = th + ContarHoras(dtpDeLunes.Text & ":00", dtpALunes.Text & ":00")
                    ContarHorasPorDia(1, dtpDeLunes.Text & ":00", dtpALunes.Text & ":00")

                    hr += If(_diasuma > 5, 0, If(chkLunes.Tag Is Nothing, 0, Convert.ToDouble(chkLunes.Tag.ToString.Split("-")(0))))
                    rn += If(_diasuma > 5, 0, If(chkLunes.Tag Is Nothing, 0, Convert.ToDouble(chkLunes.Tag.ToString.Split("-")(1))))

                    'hr = hr + ContarHorasRegular(dtpDeLunes.Text & ":00", dtpALunes.Text & ":00")
                    'rn = rn + ContarHorasRecargoNocturno(dtpDeLunes.Text & ":00", dtpALunes.Text & ":00")
                    'h50 = h50 + ContarHoras50(dtpDeLunes.Text & ":00", dtpALunes.Text & ":00")
                    'h100 = h100 + ContarHoras100(dtpDeLunes.Text & ":00", dtpALunes.Text & ":00")
                End If

                If chkMartes.Checked Then
                    th = th + ContarHoras(dtpDeMartes.Text & ":00", dtpAMartes.Text & ":00")
                    ContarHorasPorDia(2, dtpDeMartes.Text & ":00", dtpAMartes.Text & ":00")
                    hr += If(_diasuma > 5, 0, If(chkMartes.Tag Is Nothing, 0, Convert.ToDouble(chkMartes.Tag.ToString.Split("-")(0))))
                    rn += If(_diasuma > 5, 0, If(chkMartes.Tag Is Nothing, 0, Convert.ToDouble(chkMartes.Tag.ToString.Split("-")(1))))

                    'hr = hr + ContarHorasRegular(dtpDeMartes.Text & ":00", dtpAMartes.Text & ":00")
                    'rn = rn + ContarHorasRecargoNocturno(dtpDeMartes.Text & ":00", dtpAMartes.Text & ":00")
                    'h50 = h50 + ContarHoras50(dtpDeMartes.Text & ":00", dtpAMartes.Text & ":00")
                    'h100 = h100 + ContarHoras100(dtpDeMartes.Text & ":00", dtpAMartes.Text & ":00")
                End If

                If chkMiercoles.Checked Then
                    th = th + ContarHoras(dtpDeMiercoles.Text & ":00", dtpAMiercoles.Text & ":00")
                    ContarHorasPorDia(3, dtpDeMiercoles.Text & ":00", dtpAMiercoles.Text & ":00")
                    hr += If(_diasuma > 5, 0, If(chkMiercoles.Tag Is Nothing, 0, Convert.ToDouble(chkMiercoles.Tag.ToString.Split("-")(0))))
                    rn += If(_diasuma > 5, 0, If(chkMiercoles.Tag Is Nothing, 0, Convert.ToDouble(chkMiercoles.Tag.ToString.Split("-")(1))))

                    'hr = hr + ContarHorasRegular(dtpDeMiercoles.Text & ":00", dtpAMiercoles.Text & ":00")
                    'rn = rn + ContarHorasRecargoNocturno(dtpDeMiercoles.Text & ":00", dtpAMiercoles.Text & ":00")
                    'h50 = h50 + ContarHoras50(dtpDeMiercoles.Text & ":00", dtpAMiercoles.Text & ":00")
                    'h100 = h100 + ContarHoras100(dtpDeMiercoles.Text & ":00", dtpAMiercoles.Text & ":00")
                End If

                If chkJueves.Checked Then
                    th = th + ContarHoras(dtpDeJueves.Text & ":00", dtpAJueves.Text & ":00")
                    ContarHorasPorDia(4, dtpDeJueves.Text & ":00", dtpAJueves.Text & ":00")
                    hr += If(_diasuma > 5, 0, If(chkJueves.Tag Is Nothing, 0, Convert.ToDouble(chkJueves.Tag.ToString.Split("-")(0))))
                    rn += If(_diasuma > 5, 0, If(chkJueves.Tag Is Nothing, 0, Convert.ToDouble(chkJueves.Tag.ToString.Split("-")(1))))

                    'hr = hr + ContarHorasRegular(dtpDeJueves.Text & ":00", dtpAJueves.Text & ":00")
                    'rn = rn + ContarHorasRecargoNocturno(dtpDeJueves.Text & ":00", dtpAJueves.Text & ":00")
                    'h50 = h50 + ContarHoras50(dtpDeJueves.Text & ":00", dtpAJueves.Text & ":00")
                    'h100 = h100 + ContarHoras100(dtpDeJueves.Text & ":00", dtpAJueves.Text & ":00")
                End If

                If chkViernes.Checked Then
                    th = th + ContarHoras(dtpDeViernes.Text & ":00", dtpAViernes.Text & ":00")
                    ContarHorasPorDia(5, dtpDeViernes.Text & ":00", dtpAViernes.Text & ":00")
                    hr += If(_diasuma > 5, 0, If(chkViernes.Tag Is Nothing, 0, Convert.ToDouble(chkViernes.Tag.ToString.Split("-")(0))))
                    rn += If(_diasuma > 5, 0, If(chkViernes.Tag Is Nothing, 0, Convert.ToDouble(chkViernes.Tag.ToString.Split("-")(1))))

                    'hr = hr + ContarHorasRegular(dtpDeViernes.Text & ":00", dtpAViernes.Text & ":00")
                    'rn = rn + ContarHorasRecargoNocturno(dtpDeViernes.Text & ":00", dtpAViernes.Text & ":00")
                    'h50 = h50 + ContarHoras50(dtpDeViernes.Text & ":00", dtpAViernes.Text & ":00")
                    'h100 = h100 + ContarHoras100(dtpDeViernes.Text & ":00", dtpAViernes.Text & ":00")
                End If

                If chkSabado.Checked Then
                    th = th + ContarHoras(dtpDeSabado.Text & ":00", dtpASabado.Text & ":00")
                    ContarHorasPorDia(6, dtpDeSabado.Text & ":00", dtpASabado.Text & ":00")
                    hr += If(_diasuma > 5, 0, If(chkSabado.Tag Is Nothing, 0, Convert.ToDouble(chkSabado.Tag.ToString.Split("-")(0))))
                    rn += If(_diasuma > 5, 0, If(chkSabado.Tag Is Nothing, 0, Convert.ToDouble(chkSabado.Tag.ToString.Split("-")(1))))

                    'hr = hr + ContarHorasRegular(dtpDeSabado.Text & ":00", dtpASabado.Text & ":00")
                    'rn = rn + ContarHorasRecargoNocturno(dtpDeSabado.Text & ":00", dtpASabado.Text & ":00")
                    'h50 = h50 + ContarHoras50(dtpDeSabado.Text & ":00", dtpASabado.Text & ":00")
                    'h100 = h100 + ContarHoras100(dtpDeSabado.Text & ":00", dtpASabado.Text & ":00")
                End If

                If chkDomingo.Checked Then
                    th = th + ContarHoras(dtpDeDomingo.Text & ":00", dtpADomingo.Text & ":00")
                    ContarHorasPorDia(7, dtpDeDomingo.Text & ":00", dtpADomingo.Text & ":00")

                    hr += If(_diasuma > 5, 0, If(chkDomingo.Tag Is Nothing, 0, Convert.ToDouble(chkDomingo.Tag.ToString.Split("-")(0))))
                    rn += If(_diasuma > 5, 0, If(chkDomingo.Tag Is Nothing, 0, Convert.ToDouble(chkDomingo.Tag.ToString.Split("-")(1))))

                    'hr = hr + ContarHorasRegular(dtpDeDomingo.Text & ":00", dtpADomingo.Text & ":00")
                    'rn = rn + ContarHorasRecargoNocturno(dtpDeDomingo.Text & ":00", dtpADomingo.Text & ":00")
                    'h50 = h50 + ContarHoras50(dtpDeDomingo.Text & ":00", dtpADomingo.Text & ":00")
                    'h100 = h100 + ContarHoras100(dtpDeDomingo.Text & ":00", dtpADomingo.Text & ":00")
                End If
            Catch
                th = 0.0
                hr = 0.0
                rn = 0.0
                h50 = 0.0
                h100 = 0.0
            End Try

            txtTotalHoras.Text = th
            txtHorasRegular.Text = hr
            txtRecargoNocturno.Text = rn
            txtHoras50.Text = h50
            txtHoras100.Text = h100
        End Sub

        Private Function ContarHoras(ByVal horaInicio As Date, ByVal horaFinal As Date) As Double
            Dim diferencia As TimeSpan
            If horaInicio = horaFinal Then
                Return 0
            ElseIf horaInicio > horaFinal Then
                horaFinal = horaFinal.AddHours(24)
            End If
            diferencia = horaFinal.Subtract(horaInicio)
            Return Math.Ceiling(diferencia.TotalHours)
        End Function

        Private Sub ContarHorasPorDia(ByVal dia As Integer, ByVal horaInicio As Date, ByVal horaFinal As Date)
            Dim hr = 0.0
            Dim hn = 0.0

            If ContarHoras(horaInicio, horaFinal) > 8 Then horaFinal = horaInicio.AddHours(8)
              
            horaInicio = horaInicio.AddHours(1)
            While HoraString(horaInicio) <> HoraString(horaFinal.AddHours(1))
                If HoraEstaEnElDia(HoraString(horaInicio)) Then hr = hr + 1
                If HoraEstaEnLaNoche(HoraString(horaInicio)) Then hn = hn + 1
                horaInicio = horaInicio.AddHours(1)
            End While

            Select Case dia
                Case 1
                    chkLunes.Tag = (hr & "-" & hn)
                    _diasuma += 1
                Case 2
                    chkMartes.Tag = (hr & "-" & hn)
                    _diasuma += 1
                Case 3
                    chkMiercoles.Tag = (hr & "-" & hn)
                    _diasuma += 1
                Case 4
                    chkJueves.Tag = (hr & "-" & hn)
                    _diasuma += 1
                Case 5
                    chkViernes.Tag = (hr & "-" & hn)
                    _diasuma += 1
                Case 6
                    chkSabado.Tag = (hr & "-" & hn)
                    _diasuma += 1
                Case 7
                    chkDomingo.Tag = (hr & "-" & hn)
                    _diasuma += 1
            End Select
        End Sub

        Private Sub CargarHorariosOperacion(ByVal filtro As String)
            Try
                dgvHorarios.DataSource = _objetoHorario.SeleccionarHorariosOperacion(_tipoCon, filtro)

                dgvHorarios.Columns(0).Visible = False
                dgvHorarios.Columns(1).HeaderText = "N°"
                dgvHorarios.Columns(1).Width = 40
                dgvHorarios.Columns(2).Visible = False
                dgvHorarios.Columns(3).Width = 90
                dgvHorarios.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(4).Width = 90
                dgvHorarios.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(5).Width = 90
                dgvHorarios.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(6).Width = 90
                dgvHorarios.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(7).Width = 90
                dgvHorarios.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(8).Width = 90
                dgvHorarios.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(9).Width = 90
                dgvHorarios.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(10).HeaderText = "H.R"
                dgvHorarios.Columns(10).Width = 50
                dgvHorarios.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(11).HeaderText = "R.N"
                dgvHorarios.Columns(11).Width = 50
                dgvHorarios.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(12).HeaderText = "H.50%"
                dgvHorarios.Columns(12).Width = 50
                dgvHorarios.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(13).HeaderText = "H.100%"
                dgvHorarios.Columns(13).Width = 50
                dgvHorarios.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(14).HeaderText = "TOT. H."
                dgvHorarios.Columns(14).Width = 65
                dgvHorarios.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvHorarios.Columns(16).Visible = False
                dgvHorarios.Columns(17).Visible = False
                dgvHorarios.Columns(18).Visible = False

                dgvHorarios.ReadOnly = False
                dgvHorarios.EditMode = DataGridViewEditMode.EditProgrammatically

                For Each row As DataGridViewRow In dgvHorarios.Rows
                    If row.Cells("ESTADO").Value = 0 Then
                        row.DefaultCellStyle.BackColor = Color.Coral
                    End If
                    If Not row.Cells("DIAS").Value.ToString.Contains("LU") Then
                        row.Cells("LUNES").Value = "-"
                    End If
                    If Not row.Cells("DIAS").Value.ToString.Contains("MA") Then
                        row.Cells("MARTES").Value = "-"
                    End If
                    If Not row.Cells("DIAS").Value.ToString.Contains("MI") Then
                        row.Cells("MIERCOLES").Value = "-"
                    End If
                    If Not row.Cells("DIAS").Value.ToString.Contains("JU") Then
                        row.Cells("JUEVES").Value = "-"
                    End If
                    If Not row.Cells("DIAS").Value.ToString.Contains("VI") Then
                        row.Cells("VIERNES").Value = "-"
                    End If
                    If Not row.Cells("DIAS").Value.ToString.Contains("SA") Then
                        row.Cells("SABADO").Value = "-"
                    End If
                    If Not row.Cells("DIAS").Value.ToString.Contains("DO") Then
                        row.Cells("DOMINGO").Value = "-"
                    End If
                Next

            Catch ex As Exception
                dgvHorarios.DataSource = Nothing
            End Try
        End Sub

        Private Sub dgvHorarios_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvHorarios.SelectionChanged
            If _estadoAccion <> 0 Or dgvHorarios.CurrentRow Is Nothing Then
                Return
            End If

            txtIdHorario.Text = dgvHorarios.CurrentRow.Cells("ID").Value
            txtDefinicion.Text = dgvHorarios.CurrentRow.Cells("DETALLE").Value
            chkLunes.Checked = dgvHorarios.CurrentRow.Cells("DIAS").Value.ToString.Contains("LU")
            chkMartes.Checked = dgvHorarios.CurrentRow.Cells("DIAS").Value.ToString.Contains("MA")
            chkMiercoles.Checked = dgvHorarios.CurrentRow.Cells("DIAS").Value.ToString.Contains("MI")
            chkJueves.Checked = dgvHorarios.CurrentRow.Cells("DIAS").Value.ToString.Contains("JU")
            chkViernes.Checked = dgvHorarios.CurrentRow.Cells("DIAS").Value.ToString.Contains("VI")
            chkSabado.Checked = dgvHorarios.CurrentRow.Cells("DIAS").Value.ToString.Contains("SA")
            chkDomingo.Checked = dgvHorarios.CurrentRow.Cells("DIAS").Value.ToString.Contains("DO")

            dtpDeLunes.Text = If(dgvHorarios.CurrentRow.Cells("LUNES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("LUNES").Value.ToString.Split("~")(0).Trim)
            dtpALunes.Text = If(dgvHorarios.CurrentRow.Cells("LUNES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("LUNES").Value.ToString.Split("~")(1).Trim)
            dtpDeMartes.Text = If(dgvHorarios.CurrentRow.Cells("MARTES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("MARTES").Value.ToString.Split("~")(0).Trim)
            dtpAMartes.Text = If(dgvHorarios.CurrentRow.Cells("MARTES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("MARTES").Value.ToString.Split("~")(1).Trim)
            dtpDeMiercoles.Text = If(dgvHorarios.CurrentRow.Cells("MIERCOLES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("MIERCOLES").Value.ToString.Split("~")(0).Trim)
            dtpAMiercoles.Text = If(dgvHorarios.CurrentRow.Cells("MIERCOLES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("MIERCOLES").Value.ToString.Split("~")(1).Trim)
            dtpDeJueves.Text = If(dgvHorarios.CurrentRow.Cells("JUEVES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("JUEVES").Value.ToString.Split("~")(0).Trim)
            dtpAJueves.Text = If(dgvHorarios.CurrentRow.Cells("JUEVES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("JUEVES").Value.ToString.Split("~")(1).Trim)
            dtpDeViernes.Text = If(dgvHorarios.CurrentRow.Cells("VIERNES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("VIERNES").Value.ToString.Split("~")(0).Trim)
            dtpAViernes.Text = If(dgvHorarios.CurrentRow.Cells("VIERNES").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("VIERNES").Value.ToString.Split("~")(1).Trim)
            dtpDeSabado.Text = If(dgvHorarios.CurrentRow.Cells("SABADO").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("SABADO").Value.ToString.Split("~")(0).Trim)
            dtpASabado.Text = If(dgvHorarios.CurrentRow.Cells("SABADO").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("SABADO").Value.ToString.Split("~")(1).Trim)
            dtpDeDomingo.Text = If(dgvHorarios.CurrentRow.Cells("DOMINGO").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("DOMINGO").Value.ToString.Split("~")(0).Trim)
            dtpADomingo.Text = If(dgvHorarios.CurrentRow.Cells("DOMINGO").Value.ToString.Trim.Length = 1, "00:00", dgvHorarios.CurrentRow.Cells("DOMINGO").Value.ToString.Split("~")(1).Trim)

            txtHorasRegular.Text = dgvHorarios.CurrentRow.Cells("HORA_REGULAR").Value
            txtRecargoNocturno.Text = dgvHorarios.CurrentRow.Cells("RECARGO_NOCTURNO").Value
            txtHoras50.Text = dgvHorarios.CurrentRow.Cells("HORA_CINCUENTA").Value
            txtHoras100.Text = dgvHorarios.CurrentRow.Cells("HORA_CIEN").Value
            txtObservacion.Text = dgvHorarios.CurrentRow.Cells("OBSERVACION").Value

            CmbTipo.SelectedIndex = dgvHorarios.CurrentRow.Cells("TIPO").Value
            cbmCategoria.Text = dgvHorarios.CurrentRow.Cells("CATEGORIA").Value
            txtTotalHoras.Text = dgvHorarios.CurrentRow.Cells("TOT_HORAS").Value

            btnNuevo.Enabled = True ' nuevo
            btnGuardar.Enabled = False ' guardar
            btnModificar.Enabled = (CmbTipo.SelectedIndex = 1) ' actualizar
            btnAnular.Enabled = True ' anular
            btnCancelar.Enabled = False ' cancelar         
        End Sub

        Private Sub txtFiltro_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyUp
            CargarHorariosOperacion(txtFiltro.Text.Trim)
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            Try
                ExportarDatosExcel(dgvHorarios, "HORARIOS DE OPERACIÓN")
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub ExportarDatosExcel(ByVal DataGridViewExp As DataGridView, ByVal titulo As String)

            Dim app As Excel._Application = New Excel.Application()
            Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

            worksheet.Name = titulo

            worksheet.Range("A1:Z" & DataGridViewExp.RowCount + DataGridViewExp.RowCount + 25).Font.Size = 10

            Dim ic = "S"

            worksheet.Range("A1:" & ic & "1").Merge()
            worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
            worksheet.Range("A1:" & ic & "1").Font.Bold = True
            worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
            worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
            worksheet.Range("A1:" & ic & "1").Font.Size = 12
            'Copete  
            worksheet.Range("A2:" & ic & "2").Merge()
            worksheet.Range("A2:" & ic & "2").Value = titulo
            worksheet.Range("A2:" & ic & "2").Font.Size = 12
            'Fecha  
            worksheet.Range("A3:" & ic & "3").Merge()
            worksheet.Range("A3:" & ic & "3").Value = "Fecha de Impresión: " + Date.Now
            worksheet.Range("A3:" & ic & "3").Font.Size = 12

            Dim DataGridViewExpRowCount As Integer = DataGridViewExp.Rows.Cast(Of DataGridViewRow)().Count(Function(row) row.Visible)

            'Aca se agregan las cabeceras de nuestro datagrid.
            Dim head As Integer
            Dim foot As Integer
            head = 4
            foot = head + DataGridViewExpRowCount + 2

            For i As Integer = 1 To DataGridViewExp.Columns.Count
                worksheet.Cells(1 + head, i) = DataGridViewExp.Columns(i - 1).HeaderText
                worksheet.Cells(1 + head, i).Font.Bold = True
                worksheet.Cells(1 + head, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(1 + head, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Cells(1 + head, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Cells(1 + head, i).Font.Color = Color.White
            Next

            DataGridViewExpRowCount = 0
            For Each row As DataGridViewRow In DataGridViewExp.Rows
                If row.Visible Then
                    For j As Integer = 0 To DataGridViewExp.Columns.Count - 1
                        worksheet.Cells(DataGridViewExpRowCount + 2 + head, j + 1) = row.Cells(j).Value
                        ' definir bordes
                        worksheet.Cells(DataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(DataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If DataGridViewExpRowCount = DataGridViewExp.RowCount - 1 Then
                            worksheet.Cells(DataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                    Next
                    DataGridViewExpRowCount += 1
                End If
            Next

            worksheet.Range("A1:Z" & DataGridViewExp.RowCount + DataGridViewExp.RowCount + 25).Columns.AutoFit()

            app.DisplayAlerts = False
            app.Visible = True
            app.DisplayAlerts = True
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
            Try
                _crHorariosOperacionCisepro.SetDataSource(_objetoHorario.SeleccionarHorariosOperacion(_tipoCon, String.Empty))
                _crHorariosOperacionCisepro.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvSitios.ReportSource = _crHorariosOperacionCisepro
                crvSitios.Zoom(75)
                crvSitios.Refresh()
            Catch ex As Exception
                MsgBox("ERROR AL GENERAR REPORTE: " & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End Try
        End Sub

        Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCalcular.Click
            _diasuma = 0

            txtTotalHoras.Text = If(txtTotalHoras.Text.Trim().Length = 0, "0", txtTotalHoras.Text)

            txtHorasRegular.Text = If(txtHorasRegular.Text.Trim().Length = 0, "0", txtHorasRegular.Text)

            txtRecargoNocturno.Text = If(txtRecargoNocturno.Text.Trim().Length = 0, "0", txtRecargoNocturno.Text)

            txtHoras50.Text = If(txtHoras50.Text.Trim().Length = 0, "0", txtHoras50.Text)

            txtHoras100.Text = If(txtHoras100.Text.Trim().Length = 0, "0", txtHoras100.Text)

            CarcularHorario()
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            CargarHorariosOperacion(String.Empty)
        End Sub

        Private Sub CmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles CmbTipo.SelectedIndexChanged
            If _estadoAccion = 0 Then Return
            cbmCategoria.Enabled = (CmbTipo.SelectedIndex = 1)
        End Sub

    End Class
End Namespace