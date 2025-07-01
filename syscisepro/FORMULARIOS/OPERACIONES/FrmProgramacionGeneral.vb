Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports Krypton.Toolkit

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmProgramacionGeneral
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
        Public IdUsuario As Integer

        'ReadOnly _crSitiosCisepro As New rptHorariosProgramacion
        ReadOnly _crSitiosCisepro As New rptHorariosProgramacionNew
        ReadOnly _objProgramacionOps As New ClassProgramacionOperaciones
        ReadOnly _objdetaProgramacionOps As New ClassDetallesProgramacion
        ReadOnly _objGuardiaPlantilla As New ClassGuardiaPlantilla

        Dim _frmDetail As FrmEditarRegistroPorgramacion

        Private _hoy As DateTime
        Private _estadoAccion As Integer
          
        Private Sub FrmAsignarPuestoTrabajoOperaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava

                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White

                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White

            End Select

            _hoy = ValidationForms.FechaActual(_tipoCon)
            dtpMes.Value = New Date(_hoy.Year, _hoy.Month, 1)

            _frmDetail = New FrmEditarRegistroPorgramacion

            ResetTimes()
            btnNoProgramacion.Enabled = False
            btnNoSitiosProgramacion.Enabled = False
            _sqlCommands = New List(Of SqlCommand)
            cbmMotivo.Enabled = False

            cbmMotivo.SelectedIndex = 0

            Text = "ASIGNAR A PUESTO DE TRABAJO VIGILANTES DE SEGURIDAD"
        End Sub

        Private Sub ResetTimes()
            dtpDLunes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpALunes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDMartes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAMartes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDMiercoles.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAMiercoles.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDJueves.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAJueves.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDViernes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpAViernes.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDSabado.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpASabado.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpDDomingo.Value = _hoy.ToShortDateString & " 00:00:00"
            dtpADomingo.Value = _hoy.ToShortDateString & " 00:00:00"
        End Sub
        
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            btnPersonal.Enabled = True
            bntPuesto.Enabled = True
            bntHorarios.Enabled = True
            btnMesAnterior.Enabled = True

            txtIdPersonal.Clear()
            txtPersonal.Clear()
            txtCargo.Clear()
            txtArea.Clear()

            ListView1.Items.Clear()
            ListView1.Groups.Clear()

            txtIdSitio.Clear()
            txtIdSitio.Tag = Nothing
            txtSitio.Clear()
            txtSitio.Tag = Nothing
            txtCliente.Clear()
            txtDetalle.Clear()

            txtDetalle.Enabled = True

            btnNoProgramacion.Enabled = False
            btnNoSitiosProgramacion.Enabled = False
            
            _objProgramacionOps.Idprogramcion = _objProgramacionOps.BuscarMayorIdProgramacion(_tipoCon) + 1
            TextBox3.Text = _objProgramacionOps.idprogramcion

            dtpMes.Value = New Date(_hoy.Year, _hoy.Month, 1)
            DateTimePicker3.Value = dtpMes.Value

            Dim ultima = _objProgramacionOps.GetUltimaFechaProgramacion(_tipoCon)
            If ultima.Year > 2018 Then dtpMes.Value = ultima.AddSeconds(1)

            'If ultima.Month = 1 And ultima.Day > 28 Then
            '    ultima = New Date(ultima.Year, ultima.Month, 28, 0, 0, 0)
            '    dtpMes.Value = ultima
            'End If

            DateTimePicker1.Value = dtpMes.Value
            DateTimePicker2.Value = New Date(dtpMes.Value.Year, dtpMes.Value.Month, 1).AddMonths(1).AddDays(-1)

            Select Case DateTimePicker2.Value.DayOfWeek
                Case DayOfWeek.Monday
                    DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-1)
                Case DayOfWeek.Tuesday
                    DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-2)
                Case DayOfWeek.Wednesday
                    DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-3)
                Case DayOfWeek.Thursday
                    DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-4)
                Case DayOfWeek.Friday
                    DateTimePicker2.Value = DateTimePicker2.Value.AddDays(2)
                Case DayOfWeek.Saturday
                    DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1)
            End Select

            dtpDesdeP.Value = DateTimePicker1.Value
            dtpHastaP.Value = DateTimePicker2.Value

            dtpDesdeP.Enabled = True
            dtpHastaP.Enabled = True

            lblIdHorario.Text = String.Empty
            chkLunes.Checked = False
            chkMartes.Checked = False
            chkMiercoles.Checked = False
            chkJueves.Checked = False
            chkViernes.Checked = False
            chkSabado.Checked = False
            chkDomingo.Checked = False

            ResetTimes()

            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnEditar.Enabled = False

            dtpMes.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            btnAdd.Enabled = True
            btnRemove.Enabled = True

            _estadoAccion = 1

            cbmMotivo.SelectedIndex = 0
            cbmMotivo.Enabled = False
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Try
                 
                If ListView1.Items.Count = 0 Then
                    'MessageBox.Show("Debe agregar al menos un registro para guardar la programción!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    KryptonMessageBox.Show("Debe agregar al menos un registro para guardar la programción!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                    Return
                End If

                If DateTimePicker2.Value <= DateTimePicker1.Value Then
                    'MessageBox.Show("La fecha de finalización debe ser mayor a la fecha de inicio!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    KryptonMessageBox.Show("La fecha de finalización debe ser mayor a la fecha de inicio!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                    Return
                End If

                'If MessageBox.Show("Está seguro que desea guardar los cambios realizados?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                If KryptonMessageBox.Show("Está seguro que desea guardar los cambios realizados?", "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.No Then

                    Return
                End If

                If _estadoAccion = 1 Then
                    If _objProgramacionOps.ExisteProgramacionMesAnio(_tipoCon, dtpMes.Value.Month, dtpMes.Value.Year) Then
                        'MessageBox.Show("Ya existe una programación para el mes/año seleccionado!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        KryptonMessageBox.Show("Ya existe una programación para el mes/año seleccionado!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                        Return
                    End If

                    DateTimePicker1.Value = New Date(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, DateTimePicker1.Value.Day, 0, 0, 0)
                    DateTimePicker2.Value = New Date(DateTimePicker2.Value.Year, DateTimePicker2.Value.Month, DateTimePicker2.Value.Day, 23, 59, 59)

                    _sqlCommands.Clear()
                    With _objProgramacionOps
                        .Idprogramcion = TextBox3.Text.Trim
                        .Mes = dtpMes.Value.Month
                        .Anio = dtpMes.Value.Year
                        .Fechadesde = DateTimePicker1.Value
                        .Fechahasta = DateTimePicker2.Value
                        .Estado = 1
                    End With
                    _sqlCommands.Add(_objProgramacionOps.RegistrarNuevoProgramacionMesOperacionCommand())

                    Dim i = 0
                    For Each item As ListViewItem In ListView1.Items
                        With _objdetaProgramacionOps
                            .Idprogrmacion = TextBox3.Text.Trim
                            .Idpersonal = item.SubItems(0).Text
                            .Idsitiopuesto = item.SubItems(2).Text
                            .Idhorario = item.SubItems(4).Text
                            .Estado = 1
                            .Fechadesde = item.SubItems(15).Text
                            .Fechahasta = item.SubItems(16).Text
                            .Detalle = item.SubItems(14).Text
                            .Tipo = 0 'asistencia normal
                        End With
                        _sqlCommands.Add(_objdetaProgramacionOps.RegistrarNuevoDetalleProgramacionMesOperacionCommand())

                        i = i + 1
                    Next
                End If

                If _estadoAccion = 2 Then
                    _sqlCommands.Clear()
                    With _objProgramacionOps
                        .Idprogramcion = TextBox3.Text.Trim
                    End With
                    _sqlCommands.Add(_objdetaProgramacionOps.DeleteDetallesProgramacionOperacionByIdCommand(_objProgramacionOps.Idprogramcion))

                    Dim i = 0
                    For Each item As ListViewItem In ListView1.Items
                        With _objdetaProgramacionOps
                            .Idprogrmacion = TextBox3.Text.Trim()
                            .Idpersonal = item.SubItems(0).Text
                            .Idsitiopuesto = item.SubItems(2).Text
                            .Idhorario = item.SubItems(4).Text
                            .Estado = 1
                            .Fechadesde = item.SubItems(15).Text
                            .Fechahasta = item.SubItems(16).Text
                            .Detalle = item.SubItems(14).Text
                            .Tipo = item.SubItems(17).Text
                        End With
                        _sqlCommands.Add(_objdetaProgramacionOps.RegistrarNuevoDetalleProgramacionMesOperacionCommand())

                        i = i + 1
                    Next
                End If

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)

                If res(0) Then
                    btnPersonal.Enabled = False
                    bntPuesto.Enabled = False
                    bntHorarios.Enabled = False
                    btnMesAnterior.Enabled = False

                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnCancelar.Enabled = False
                    _estadoAccion = 0

                    dtpDesdeP.Enabled = False
                    dtpHastaP.Enabled = False
                    btnNoProgramacion.Enabled = True
                    btnNoSitiosProgramacion.Enabled = True
                    txtDetalle.Enabled = False
                    dtpMes.Enabled = False
                    btnAdd.Enabled = False
                    btnRemove.Enabled = False
                    btnEditar.Enabled = True
                    DateTimePicker1.Enabled = False
                    DateTimePicker2.Enabled = False
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If

                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                'MsgBox("ERROR AL GUARDAR PROGRAMACIÓN DE TRABAJO: " & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Error al guardar programación de trabajo: " & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            btnPersonal.Enabled = False
            bntPuesto.Enabled = False
            bntHorarios.Enabled = False
            btnMesAnterior.Enabled = False

            txtIdPersonal.Clear()
            txtPersonal.Clear()
            txtCargo.Clear()
            txtArea.Clear()

            txtIdSitio.Clear()
            txtIdSitio.Tag = Nothing
            txtCliente.Clear()
            txtSitio.Clear()
            txtSitio.Tag = Nothing
            txtCliente.Clear()
            btnNoProgramacion.Enabled = False
            btnNoSitiosProgramacion.Enabled = False
            txtDetalle.Clear()
            txtDetalle.Enabled = True

            dtpDesdeP.Value = DateTimePicker1.Value
            dtpHastaP.Value = DateTimePicker2.Value
            dtpDesdeP.Enabled = False
            dtpHastaP.Enabled = False

            lblIdHorario.Text = String.Empty
            chkLunes.Checked = False
            chkMartes.Checked = False
            chkMiercoles.Checked = False
            chkJueves.Checked = False
            chkViernes.Checked = False
            chkSabado.Checked = False
            chkDomingo.Checked = False

            ResetTimes()

            ListView1.Items.Clear()

            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False

            dtpMes.Enabled = False
            btnAdd.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            btnRemove.Enabled = False
            btnEditar.Enabled = False

            cbmMotivo.Enabled = False

            _estadoAccion = 0
            TextBox3.Text = String.Empty
        End Sub

        Private Function GetListViewGroup(ByVal name As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView1.Groups Where grupo1.ToString.Trim.Equals(name.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub bntPuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntPuesto.Click
            Dim frm As New FrmBuscarPuestoTrabajo
            frm.TipoCox = TipoCox
            frm.Label3.Text = "TODOS LOS PUESTOS REGISTRADOS"
            frm.Text = "BUSCAR SITIOS DE TRABAJO"

            Try
                If frm.ShowDialog = vbOK Then
                    txtIdSitio.Text = frm.ListView1.SelectedItems(0).SubItems(0).Text.Trim
                    txtSitio.Text = frm.ListView1.SelectedItems(0).SubItems(2).Text.Trim
                    txtCliente.Text = frm.ListView1.SelectedItems(0).Group.Header.Trim

                    txtIdSitio.Tag = frm.ListView1.SelectedItems(0).SubItems(1).Text.Trim ' river 

                    txtP24.Text = frm.ListView1.SelectedItems(0).SubItems(24).Text.Trim
                    txtP12.Text = frm.ListView1.SelectedItems(0).SubItems(25).Text.Trim
                    txtP8.Text = frm.ListView1.SelectedItems(0).SubItems(26).Text.Trim
                    txtPo.Text = frm.ListView1.SelectedItems(0).SubItems(27).Text.Trim

                End If
            Catch ex As Exception
                txtSitio.Text = "AUN NO SE ESPECIFICA"
                txtIdSitio.Text = "0"
            End Try
        End Sub

        Private Sub btnPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.IsOperaciones = True
            frm.IsAdmin = False
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        txtIdPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                        txtCargo.Text = frm.dgvCustodios.CurrentRow.Cells.Item(7).Value
                        txtArea.Text = frm.dgvCustodios.CurrentRow.Cells.Item(8).Value
                        txtDetalle.Clear()
                    End If
                End If
            Catch ex As Exception
                txtPersonal.Text = "NO DEFINIDO"
                txtIdPersonal.Clear()
                txtCargo.Clear()
                txtArea.Clear()
            End Try
        End Sub

        Private Sub bntHorarios_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntHorarios.Click
            Dim frm As New FrmSeleccionarHorario
            frm.TipoCox = TipoCox
            Try
                If frm.ShowDialog = vbOK Then
                    Dim row = frm.dgvCustodios.CurrentRow

                    lblIdHorario.Text = row.Cells("ID").Value

                    txtNumHorario.Text = row.Cells("DETALLE").Value
                    chkLunes.Checked = row.Cells("DIAS").Value.ToString.Contains("LU")
                    chkMartes.Checked = row.Cells("DIAS").Value.ToString.Contains("MA")
                    chkMiercoles.Checked = row.Cells("DIAS").Value.ToString.Contains("MI")
                    chkJueves.Checked = row.Cells("DIAS").Value.ToString.Contains("JU")
                    chkViernes.Checked = row.Cells("DIAS").Value.ToString.Contains("VI")
                    chkSabado.Checked = row.Cells("DIAS").Value.ToString.Contains("SA")
                    chkDomingo.Checked = row.Cells("DIAS").Value.ToString.Contains("DO")

                    dtpDLunes.Text = If(row.Cells("LUNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("LUNES").Value.ToString.Split("~")(0).Trim)
                    dtpALunes.Text = If(row.Cells("LUNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("LUNES").Value.ToString.Split("~")(1).Trim)
                    dtpDMartes.Text = If(row.Cells("MARTES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MARTES").Value.ToString.Split("~")(0).Trim)
                    dtpAMartes.Text = If(row.Cells("MARTES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MARTES").Value.ToString.Split("~")(1).Trim)
                    dtpDMiercoles.Text = If(row.Cells("MIERCOLES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MIERCOLES").Value.ToString.Split("~")(0).Trim)
                    dtpAMiercoles.Text = If(row.Cells("MIERCOLES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MIERCOLES").Value.ToString.Split("~")(1).Trim)
                    dtpDJueves.Text = If(row.Cells("JUEVES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("JUEVES").Value.ToString.Split("~")(0).Trim)
                    dtpAJueves.Text = If(row.Cells("JUEVES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("JUEVES").Value.ToString.Split("~")(1).Trim)
                    dtpDViernes.Text = If(row.Cells("VIERNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("VIERNES").Value.ToString.Split("~")(0).Trim)
                    dtpAViernes.Text = If(row.Cells("VIERNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("VIERNES").Value.ToString.Split("~")(1).Trim)
                    dtpDSabado.Text = If(row.Cells("SABADO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("SABADO").Value.ToString.Split("~")(0).Trim)
                    dtpASabado.Text = If(row.Cells("SABADO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("SABADO").Value.ToString.Split("~")(1).Trim)
                    dtpDDomingo.Text = If(row.Cells("DOMINGO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("DOMINGO").Value.ToString.Split("~")(0).Trim)
                    dtpADomingo.Text = If(row.Cells("DOMINGO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("DOMINGO").Value.ToString.Split("~")(1).Trim)

                    bntHorarios.Tag = row.Cells("DETALLE").Value
                End If
            Catch ex As Exception
                lblIdHorario.Text = String.Empty
                chkLunes.Checked = False
                chkMartes.Checked = False
                chkMiercoles.Checked = False
                chkJueves.Checked = False
                chkViernes.Checked = False
                chkSabado.Checked = False
                chkDomingo.Checked = False

                dtpDLunes.Text = "00:00"
                dtpALunes.Text = "00:00"
                dtpDMartes.Text = "00:00"
                dtpAMartes.Text = "00:00"
                dtpDMiercoles.Text = "00:00"
                dtpAMiercoles.Text = "00:00"
                dtpDJueves.Text = "00:00"
                dtpAJueves.Text = "00:00"
                dtpDViernes.Text = "00:00"
                dtpAViernes.Text = "00:00"
                dtpDSabado.Text = "00:00"
                dtpASabado.Text = "00:00"
                dtpDDomingo.Text = "00:00"
                dtpADomingo.Text = "00:00"

                bntHorarios.Tag = Nothing
            End Try
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            Try
                If ListView1.Items.Count = 0 Then
                    MessageBox.Show("Debe seleccionar una programación para generar reporte!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                'Dim ds As New dsOperaciones
                Dim ds As New dsOperaciones2
                'For Each item As ListViewItem In ListView1.Items
                '    ds.Tables("PROGRAMACION_GENERAL").Rows.Add(item.SubItems(0).Text, item.SubItems(1).Text,
                '                                               item.SubItems(2).Text, "", item.SubItems(3).Text,
                '                                               item.SubItems(4).Text, item.SubItems(5).Text, item.SubItems(6).Text,
                '                                               If(item.SubItems(7).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(7).Text.Trim),
                '                                               If(item.SubItems(8).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(8).Text.Trim),
                '                                               If(item.SubItems(9).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(9).Text.Trim),
                '                                               If(item.SubItems(10).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(10).Text.Trim),
                '                                               If(item.SubItems(11).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(11).Text.Trim),
                '                                               If(item.SubItems(12).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(12).Text.Trim),
                '                                               If(item.SubItems(13).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(13).Text.Trim),
                '                                               item.SubItems(2).Text, item.SubItems(14).Text)
                'Next
                For Each item As ListViewItem In ListView1.Items
                    ds.Tables("PROGRAMACION_GENERAL").Rows.Add(item.SubItems(0).Text, item.SubItems(1).Text,
                                                               item.SubItems(2).Text, item.SubItems(3).Text,
                                                               If(item.SubItems(7).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(7).Text.Trim),
                                                               If(item.SubItems(8).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(8).Text.Trim),
                                                               If(item.SubItems(9).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(9).Text.Trim),
                                                               If(item.SubItems(10).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(10).Text.Trim),
                                                               If(item.SubItems(11).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(11).Text.Trim),
                                                               If(item.SubItems(12).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(12).Text.Trim),
                                                               If(item.SubItems(13).Text.Trim.Equals("00:00 ~ 00:00"), "D", item.SubItems(13).Text.Trim),
                                                               item.SubItems(15).Text, item.SubItems(16).Text)
                Next




                _crSitiosCisepro.SetDataSource(ds.Tables("PROGRAMACION_GENERAL"))
                _crSitiosCisepro.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                _crSitiosCisepro.SetParameterValue("mes", ValidationForms.Mes(dtpMes.Value.Month) & " - " & dtpMes.Value.Year)
                _crSitiosCisepro.SetParameterValue("desde", DateTimePicker1.Value.ToLongDateString())
                _crSitiosCisepro.SetParameterValue("hasta", DateTimePicker2.Value.ToLongDateString())
                crvSitios.ReportSource = _crSitiosCisepro

                crvSitios.Zoom(75)
                crvSitios.Refresh()
            Catch ex As Exception
                'MsgBox("ERROR AL GENERAR REPORTE: " & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Error al generar reporte: " & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            Dim frm As New FrmBuscarProgramacion
            frm.TipoCox = TipoCox
            Try
                If frm.ShowDialog = vbOK Then
                    Dim idp = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value

                    TextBox3.Text = idp
                    dtpMes.Value = New Date(frm.dgvCustodios.CurrentRow.Cells.Item(2).Value, frm.dgvCustodios.CurrentRow.Cells.Item(5).Value, 1)
                    DateTimePicker1.Value = Convert.ToDateTime(frm.dgvCustodios.CurrentRow.Cells.Item(3).Value)
                    DateTimePicker2.Value = frm.dgvCustodios.CurrentRow.Cells.Item(4).Value

                    Dim grupos = _objdetaProgramacionOps.SeleccionarGruposDetallesProgramacionById(_tipoCon, idp)
                    Dim detalle = _objdetaProgramacionOps.SeleccionarDetalleProgramacionById(_tipoCon, idp)

                    ListView1.Items.Clear()
                    ListView1.Groups.Clear()

                    ' grupos
                    For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                        ListView1.Groups.Add(group)
                    Next

                    ' detalles
                    For Each row As DataRow In detalle.Rows
                        Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(3).ToString.Trim))
                        lst.UseItemStyleForSubItems = False
                        For i = 1 To detalle.Columns.Count - 1

                            If i > 14 Then
                                lst.SubItems.Add(row.Item(i).ToString.Split(" ")(0).Trim)
                            Else
                                lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                            End If
                            If row.Item(18).ToString.Equals("0") Then lst.SubItems(1).BackColor = Color.FromArgb(255, 240, 128, 128)

                        Next
                        ListView1.Items.Add(lst)
                    Next
                    'ListView1.Sort()
                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = False
                    btnCancelar.Enabled = False
                    btnEditar.Enabled = True
                    btnNoProgramacion.Enabled = True
                    btnNoSitiosProgramacion.Enabled = True
                End If
            Catch ex As Exception
                'MsgBox("ERROR AL CARGAR PROGRAMACIÓN SELECCIONADA: " & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Error al cargar programación seleccionada: " & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
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

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAdd.Click
            If (dtpDesdeP.Value < DateTimePicker1.Value Or dtpDesdeP.Value > DateTimePicker2.Value) Then
                KryptonMessageBox.Show("La fecha de inicio para el vigilante " & txtPersonal.Text.Trim & " debe estar dentro del rango de la fecha de la programación!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            If (dtpHastaP.Value < DateTimePicker1.Value Or dtpHastaP.Value > DateTimePicker2.Value Or dtpHastaP.Value < dtpDesdeP.Value) Then
                KryptonMessageBox.Show("La fecha de fin para el vigilante " & txtPersonal.Text.Trim & " debe estar dentro del rango de la fecha de la programación y debe ser mayor  o igual a la fecha de inicio!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            If (txtIdSitio.Text.Trim.Length = 0 Or txtIdPersonal.Text.Trim.Length = 0 Or lblIdHorario.Text.Trim.Length = 0) Then
                KryptonMessageBox.Show("Debe seleccionar Sitio, Horario y Personal para agregar a la programación!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            If (txtIdSitio.Text.Trim = "0" Or txtIdPersonal.Text.Trim = "0" Or lblIdHorario.Text.Trim = "0") Then
                KryptonMessageBox.Show("Debe seleccionar Sitio, Horario y Personal para agregar a la programación!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            Dim table As New DataTable()
            For i = 0 To 17
                table.Columns.Add()
            Next

            Dim grupo = txtIdSitio.Tag & "     -  " & txtSitio.Text.Trim & " (" & txtCliente.Text.Trim() & ")"

            Dim detahor = If(bntHorarios.Tag Is Nothing, String.Empty, bntHorarios.Tag.ToString)

            table.Rows.Add(New String() {txtIdPersonal.Text.Trim, txtPersonal.Text.Trim(), txtIdSitio.Text.Trim(), grupo.Trim,
                                         lblIdHorario.Text.Trim, detahor, GetDias(), dtpDLunes.Text & " ~ " & dtpALunes.Text,
                                         dtpDMartes.Text & " ~ " & dtpAMartes.Text, dtpDMiercoles.Text & " ~ " & dtpAMiercoles.Text, dtpDJueves.Text & " ~ " & dtpAJueves.Text,
                                         dtpDViernes.Text & " ~ " & dtpAViernes.Text, dtpDSabado.Text & " ~ " & dtpASabado.Text, dtpDDomingo.Text & " ~ " & dtpADomingo.Text, txtDetalle.Text.Trim, dtpDesdeP.Value, dtpHastaP.Value, cbmMotivo.SelectedIndex})

            AgregarRegistro(table.Rows(0), txtPersonal.Text.Trim())
        End Sub

        Private Sub AgregarRegistro(ByVal row As DataRow, ByVal nombre As String)
            If VerificarRepetidoSitioHorario(row.Item(0).ToString, row.Item(4).ToString) Then
                KryptonMessageBox.Show(nombre & " ya se encuentra asignado a este u otro puesto con el mismo horario!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            Try
                ' grupo
                ListView1.Groups.Add(New ListViewGroup(row.Item(3).ToString)) ' sitio 

                ' detalles
                Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(3).ToString.Trim))
                For i = 1 To row.ItemArray().Length - 1
                    lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                Next
                ListView1.Items.Add(lst)

                ListView1.Refresh()

                lst.EnsureVisible()

                ListView1.Items(lst.Index).Selected = True
                ListView1.Select()

            Catch ex As Exception
                ListView1.Items.Clear()
            End Try
        End Sub

        Private Function VerificarRepetidoSitioHorario(ByVal idpersonal As String, ByVal idhorario As String) As Boolean
            Return ListView1.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(0).Text.Equals(idpersonal) And item.SubItems(4).Text.Equals(idhorario) And item.SubItems(15).Text = dtpDesdeP.Value.ToString().Split(" ")(0).Trim And item.SubItems(16).Text = dtpHastaP.Value.ToString().Split(" ")(0).Trim)
        End Function

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRemove.Click
            If ListView1.Items.Count = 0 Or ListView1.SelectedItems.Count = 0 Then Return
            'If MessageBox.Show("Seguro que desea quitar este registro", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            If KryptonMessageBox.Show("Seguro que desea quitar este registro", "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        End Sub

        Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEditar.Click
            btnPersonal.Enabled = True
            bntPuesto.Enabled = True
            bntHorarios.Enabled = True
            btnMesAnterior.Enabled = True

            txtIdPersonal.Clear()
            txtPersonal.Clear()
            txtCargo.Clear()
            txtArea.Clear()

            txtIdSitio.Clear()
            txtIdSitio.Tag = Nothing
            txtSitio.Clear()
            txtSitio.Tag = Nothing
            txtCliente.Clear()

            btnNoProgramacion.Enabled = True
            btnNoSitiosProgramacion.Enabled = True

            lblIdHorario.Text = String.Empty
            chkLunes.Checked = False
            chkMartes.Checked = False
            chkMiercoles.Checked = False
            chkJueves.Checked = False
            chkViernes.Checked = False
            chkSabado.Checked = False
            chkDomingo.Checked = False
            txtDetalle.Clear()
            txtDetalle.Enabled = True

            dtpDesdeP.Value = DateTimePicker1.Value
            dtpHastaP.Value = DateTimePicker2.Value
            dtpDesdeP.Enabled = True
            dtpHastaP.Enabled = True

            ResetTimes()

            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnEditar.Enabled = False

            btnAdd.Enabled = True
            btnRemove.Enabled = True

            cbmMotivo.SelectedIndex = 0
            cbmMotivo.Enabled = False

            _estadoAccion = 2
        End Sub

        Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.DoubleClick
            If ListView1.Items.Count = 0 Or _estadoAccion = 0 Then Return
            _frmDetail.TipoCox = TipoCox
            _frmDetail.txtIdPersonal.Text = ListView1.SelectedItems(0).SubItems(0).Text
            _frmDetail.txtPersonal.Text = ListView1.SelectedItems(0).SubItems(1).Text

            _frmDetail.txtIdPuesto.Text = ListView1.SelectedItems(0).SubItems(2).Text
            _frmDetail.txtUbicacionPuesto.Text = ListView1.SelectedItems(0).SubItems(3).Text

            _frmDetail.lblIdHorario.Text = ListView1.SelectedItems(0).SubItems(4).Text
            _frmDetail.txtNumHorario.Text = ListView1.SelectedItems(0).SubItems(5).Text
            _frmDetail.bntHorarios.Tag = ListView1.SelectedItems(0).SubItems(6).Text

            _frmDetail.chkLunes.Checked = ListView1.SelectedItems(0).SubItems(6).Text.Contains("LU")
            _frmDetail.chkMartes.Checked = ListView1.SelectedItems(0).SubItems(6).Text.Contains("MA")
            _frmDetail.chkMiercoles.Checked = ListView1.SelectedItems(0).SubItems(6).Text.Contains("MI")
            _frmDetail.chkJueves.Checked = ListView1.SelectedItems(0).SubItems(6).Text.Contains("JU")
            _frmDetail.chkViernes.Checked = ListView1.SelectedItems(0).SubItems(6).Text.Contains("VI")
            _frmDetail.chkSabado.Checked = ListView1.SelectedItems(0).SubItems(6).Text.Contains("SA")
            _frmDetail.chkDomingo.Checked = ListView1.SelectedItems(0).SubItems(6).Text.Contains("DO")

            _frmDetail.dtpDeLunes.Text = ListView1.SelectedItems(0).SubItems(7).Text.Split("~")(0).Trim
            _frmDetail.dtpALunes.Text = ListView1.SelectedItems(0).SubItems(7).Text.Split("~")(1).Trim
            _frmDetail.dtpDeMartes.Text = ListView1.SelectedItems(0).SubItems(8).Text.Split("~")(0).Trim
            _frmDetail.dtpAMartes.Text = ListView1.SelectedItems(0).SubItems(8).Text.Split("~")(1).Trim
            _frmDetail.dtpDeMiercoles.Text = ListView1.SelectedItems(0).SubItems(9).Text.Split("~")(0).Trim
            _frmDetail.dtpAMiercoles.Text = ListView1.SelectedItems(0).SubItems(9).Text.Split("~")(1).Trim
            _frmDetail.dtpDeJueves.Text = ListView1.SelectedItems(0).SubItems(10).Text.Split("~")(0).Trim
            _frmDetail.dtpAJueves.Text = ListView1.SelectedItems(0).SubItems(10).Text.Split("~")(1).Trim
            _frmDetail.dtpDeViernes.Text = ListView1.SelectedItems(0).SubItems(11).Text.Split("~")(0).Trim
            _frmDetail.dtpAViernes.Text = ListView1.SelectedItems(0).SubItems(11).Text.Split("~")(1).Trim
            _frmDetail.dtpDeSabado.Text = ListView1.SelectedItems(0).SubItems(12).Text.Split("~")(0).Trim
            _frmDetail.dtpASabado.Text = ListView1.SelectedItems(0).SubItems(12).Text.Split("~")(1).Trim
            _frmDetail.dtpDeDomingo.Text = ListView1.SelectedItems(0).SubItems(13).Text.Split("~")(0).Trim
            _frmDetail.dtpADomingo.Text = ListView1.SelectedItems(0).SubItems(13).Text.Split("~")(1).Trim

            _frmDetail.txtDetalle.Text = ListView1.SelectedItems(0).SubItems(14).Text
            _frmDetail.dtpDesdeP.Value = ListView1.SelectedItems(0).SubItems(15).Text
            _frmDetail.dtpHastaP.Value = ListView1.SelectedItems(0).SubItems(16).Text

            _frmDetail.cbmMotivo.SelectedIndex = ListView1.SelectedItems(0).SubItems(17).Text

            If _frmDetail.ShowDialog = vbOK Then

                If _frmDetail.txtDetalle.Text.Trim.Length > 0 Then ListView1.SelectedItems(0).SubItems(14).Text = _frmDetail.txtDetalle.Text.Trim

                ListView1.SelectedItems(0).SubItems(4).Text = _frmDetail.lblIdHorario.Text.Trim
                ListView1.SelectedItems(0).SubItems(5).Text = _frmDetail.txtNumHorario.Text.Trim
                ListView1.SelectedItems(0).SubItems(6).Text = _frmDetail.bntHorarios.Tag

                ListView1.SelectedItems(0).SubItems(7).Text = _frmDetail.dtpDeLunes.Text & " ~ " & _frmDetail.dtpALunes.Text
                ListView1.SelectedItems(0).SubItems(8).Text = _frmDetail.dtpDeMartes.Text & " ~ " & _frmDetail.dtpAMartes.Text
                ListView1.SelectedItems(0).SubItems(9).Text = _frmDetail.dtpDeMiercoles.Text & " ~ " & _frmDetail.dtpAMiercoles.Text
                ListView1.SelectedItems(0).SubItems(10).Text = _frmDetail.dtpDeJueves.Text & " ~ " & _frmDetail.dtpAJueves.Text
                ListView1.SelectedItems(0).SubItems(11).Text = _frmDetail.dtpDeViernes.Text & " ~ " & _frmDetail.dtpAViernes.Text
                ListView1.SelectedItems(0).SubItems(12).Text = _frmDetail.dtpDeSabado.Text & " ~ " & _frmDetail.dtpASabado.Text
                ListView1.SelectedItems(0).SubItems(13).Text = _frmDetail.dtpDeDomingo.Text & " ~ " & _frmDetail.dtpADomingo.Text

                ListView1.SelectedItems(0).SubItems(15).Text = _frmDetail.dtpDesdeP.Value
                ListView1.SelectedItems(0).SubItems(16).Text = _frmDetail.dtpHastaP.Value

                ListView1.SelectedItems(0).SubItems(17).Text = _frmDetail.cbmMotivo.SelectedIndex

            End If

        End Sub

        Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNoProgramacion.Click
            Try
                Dim frm As New FrmBuscarProveedorCliente
                frm.TipoCox = TipoCox
                frm.IsOperaciones = True
                frm.IsAdmin = False
                frm.rbtProveedor.Visible = False
                frm.rbtPersonal.Visible = False
                frm.rbtCliente.Visible = False
                frm.txtParametrobusqueda.Visible = False
                frm.Label1.Text = "El personal en esta lista NO está asignado a un puesto en la programacion de " & dtpMes.Text
                frm.cargarPersonalNoProgramacion(TextBox3.Text.Trim)
                frm.ShowDialog()
            Catch ex As Exception
                KryptonMessageBox.Show("Error al visualizar lista!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            End Try
        End Sub

        Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNoSitiosProgramacion.Click
            Try
                Dim frm As New FrmBuscarProveedorCliente
                frm.TipoCox = TipoCox
                frm.IsOperaciones = True
                frm.IsAdmin = False
                frm.rbtProveedor.Visible = False
                frm.rbtPersonal.Visible = False
                frm.rbtCliente.Visible = False
                frm.txtParametrobusqueda.Visible = False
                frm.Label1.Text = "Los puestos en esta lista NO están asignados a la programacion de " & dtpMes.Text
                frm.cargarSitiosNoProgramacion(TextBox3.Text.Trim)
                frm.ShowDialog()
            Catch ex As Exception
                KryptonMessageBox.Show("Error al visualizar lista!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            End Try
        End Sub

        Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
            If ListView1.Items.Count = 0 Then Return
            If ListView1.SelectedItems.Count = 0 Then Return
            If ListView1.SelectedItems(0).SubItems.Count = 0 Then Return
            cbmMotivo.SelectedIndex = ListView1.SelectedItems(0).SubItems(17).Text
        End Sub

        Private Sub btnMesAnterior_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMesAnterior.Click
            Dim ulm = _objProgramacionOps.BuscarMesAnioUltimaProgramacion(_tipoCon)
            If ulm.Rows.Count = 0 Then Return
            If String.IsNullOrEmpty(ulm.Rows(0)(0)) Then Return

            If KryptonMessageBox.Show("Desea cargar la programación del mes anterior (" & ValidationForms.Mes(ulm.Rows(0)(1)) & "-" & ulm.Rows(0)(2) & ")?", "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

            Dim pro = _objProgramacionOps.SeleccionarProgramacionById(_tipoCon, ulm.Rows(0)(0))
            If pro Is Nothing Or pro.Rows.Count = 0 Then

                KryptonMessageBox.Show("Los datos de la programación del mes anterior (" & ValidationForms.Mes(ulm.Rows(0)(1)) & "-" & ulm.Rows(0)(2) & " no han podido ser cargados!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            Try

                Dim fechaDesde = DateTimePicker1.Value.Year.ToString & "-" & DateTimePicker1.Value.Month.ToString & "-" & DateTimePicker1.Value.Day.ToString & " 00:00:00"
                Dim fechaHasta = DateTimePicker2.Value.Year.ToString & "-" & DateTimePicker2.Value.Month.ToString & "-" & DateTimePicker2.Value.Day.ToString & " 23:59:59"

                Dim grupos = _objdetaProgramacionOps.SeleccionarGruposDetallesProgramacionById2(_tipoCon, ulm.Rows(0)(0))
                Dim detalle = _objdetaProgramacionOps.SeleccionarDetalleProgramacionByIdFecha2(_tipoCon, ulm.Rows(0)(0), fechaDesde, fechaHasta)

                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                ' grupos
                For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                    ListView1.Groups.Add(group)
                Next

                ' detalles
                For Each row As DataRow In detalle.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(3).ToString.Trim))
                    lst.UseItemStyleForSubItems = False
                    For i = 1 To detalle.Columns.Count - 1
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                        If row.Item(18).ToString.Equals("0") Then lst.SubItems(1).BackColor = Color.FromArgb(255, 240, 128, 128)
                    Next
                    ListView1.Items.Add(lst)
                Next

            Catch ex As Exception
                ListView1.Items.Clear()
            End Try
        End Sub

        Private Sub dtpMes_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpMes.ValueChanged
            Try


                If _estadoAccion = 0 Then Return

                Dim ultima = _objProgramacionOps.GetUltimaFechaProgramacionByMesAnio(_tipoCon, dtpMes.Value.Month, dtpMes.Value.Year)

                'If ultima.Year > 2018 Then dtpMes.Value = ultima.AddSeconds(1)
                'If ultima.Month = 1 And ultima.Day > 28 Then
                '    ultima = New Date(ultima.Year, ultima.Month, 28, 0, 0, 0)
                '    dtpMes.Value = ultima
                'End If

                DateTimePicker1.Value = dtpMes.Value
                DateTimePicker2.Value = New Date(dtpMes.Value.Year, dtpMes.Value.Month, 1).AddMonths(1).AddDays(-1)

                Select Case DateTimePicker2.Value.DayOfWeek
                    Case DayOfWeek.Monday
                        DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-1)
                    Case DayOfWeek.Tuesday
                        DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-2)
                    Case DayOfWeek.Wednesday
                        DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-3)
                    Case DayOfWeek.Thursday
                        DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-4)
                    Case DayOfWeek.Friday
                        DateTimePicker2.Value = DateTimePicker2.Value.AddDays(2)
                    Case DayOfWeek.Saturday
                        DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1)
                End Select

                dtpDesdeP.Value = DateTimePicker1.Value
                dtpHastaP.Value = DateTimePicker2.Value
            Catch
                dtpDesdeP.Value = DateTimePicker1.Value
                dtpHastaP.Value = DateTimePicker2.Value
            End Try
        End Sub

        Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker1.ValueChanged
            dtpDesdeP.Value = DateTimePicker1.Value
            dtpHastaP.Value = DateTimePicker2.Value

            CambiarFechas()
        End Sub

        Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker2.ValueChanged
            dtpDesdeP.Value = DateTimePicker1.Value
            dtpHastaP.Value = DateTimePicker2.Value

            CambiarFechas()
        End Sub

        Private Sub CambiarFechas()
            For Each row As ListViewItem In ListView1.Items
                row.SubItems(15).Text = DateTimePicker1.Value.ToString
                row.SubItems(16).Text = DateTimePicker2.Value.ToString
            Next
        End Sub

        Private Sub KryptonGroupBox1_Panel_Paint(sender As Object, e As PaintEventArgs) Handles KryptonGroupBox1.Panel.Paint

        End Sub

        Private Sub KryptonGroupBox1_Paint(sender As Object, e As PaintEventArgs) Handles KryptonGroupBox1.Paint

        End Sub

        Private Sub KryptonLabel4_Click(sender As Object, e As EventArgs) Handles KryptonLabel4.Click

        End Sub

        Private Sub KryptonLabel3_Click(sender As Object, e As EventArgs) Handles KryptonLabel3.Click

        End Sub

        Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
            Try
                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                Dim openFileDialog As New OpenFileDialog With {
                    .Filter = "Archivos de Excel (*.xlsx)|*.xlsx",
                    .Title = "Seleccione el archivo de Excel"
                }

                If openFileDialog.ShowDialog() <> DialogResult.OK Then Return

                Dim dtExcel = 


            Catch ex As Exception

            End Try
        End Sub


    End Class
End Namespace