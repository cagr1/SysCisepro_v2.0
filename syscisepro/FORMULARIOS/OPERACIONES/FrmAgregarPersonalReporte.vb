
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmAgregarPersonalReporte
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
        ReadOnly _objHorarios As New ClassHorariosOperacion

        Public NomDia As String
        Public EsDiurno As Boolean

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
                    End If
                End If
            Catch ex As Exception
                txtPersonal.Text = "NO DEFINIDO"
                txtIdPersonal.Clear()
                txtCargo.Clear()
                txtArea.Clear()
            End Try
        End Sub

        Private Sub bntPuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntPuesto.Click
            If txtIdPersonal.Text.Trim.Length = 0 Then
                MsgBox("Por favor, seleccione un empleado o personal", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            Dim frm As New FrmBuscarPuestoTrabajo
            frm.TipoCox = TipoCox
            frm.Label3.Text = "TODOS LOS PUESTOS REGISTRADOS"
            frm.Text = "BUSCAR SITIOS DE TRABAJO"

            Try
                If frm.ShowDialog = vbOK Then
                    lblRiver.Text = frm.ListView1.SelectedItems(0).SubItems(1).Text
                    txtIdPuesto.Text = frm.ListView1.SelectedItems(0).SubItems(0).Text
                    txtUbicacionPuesto.Text = frm.ListView1.SelectedItems(0).SubItems(2).Text
                    txtCliente.Text = frm.ListView1.SelectedItems(0).Group.Header
                    lblDireccion.Text = frm.ListView1.SelectedItems(0).SubItems(3).Text
                End If
            Catch ex As Exception
                txtUbicacionPuesto.Text = "AUN NO SE ESPECIFICA"
                txtIdPuesto.Text = "0"
                lblRiver.Text = ""
                lblDireccion.Text = ""
            End Try
        End Sub

        Private Sub bntHorarios_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntHorarios.Click
            If txtIdPersonal.Text.Trim.Length = 0 Then
                MsgBox("Por favor, seleccione un empleado o personal", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            Dim frm As New FrmSeleccionarHorario
            frm.TipoCox = TipoCox
            frm.EsMin = True
            frm.EsDiurno = EsDiurno
            frm.NomDia = NomDia

            Try
                If frm.ShowDialog = vbOK Then

                    Dim row = _objHorarios.SeleccionarHorariosMasUsadoDia(_tipoCon, frm.dgvCustodios.CurrentRow.Cells(0).Value, NomDia).Rows(0)

                    lblIdHorario.Text = row.Item("id_horario")
                    chkLunes.Checked = row.Item("DIAS").ToString.Contains("LU")
                    chkMartes.Checked = row.Item("DIAS").ToString.Contains("MA")
                    chkMiercoles.Checked = row.Item("DIAS").ToString.Contains("MI")
                    chkJueves.Checked = row.Item("DIAS").ToString.Contains("JU")
                    chkViernes.Checked = row.Item("DIAS").ToString.Contains("VI")
                    chkSabado.Checked = row.Item("DIAS").ToString.Contains("SA")
                    chkDomingo.Checked = row.Item("DIAS").ToString.Contains("DO")

                    dtpDeLunes.Text = If(row.Item("LUNES").ToString.Trim.Length = 1, "00:00", row.Item("LUNES").ToString.Split("~")(0).Trim)
                    dtpALunes.Text = If(row.Item("LUNES").ToString.Trim.Length = 1, "00:00", row.Item("LUNES").ToString.Split("~")(1).Trim)
                    dtpDeMartes.Text = If(row.Item("MARTES").ToString.Trim.Length = 1, "00:00", row.Item("MARTES").ToString.Split("~")(0).Trim)
                    dtpAMartes.Text = If(row.Item("MARTES").ToString.Trim.Length = 1, "00:00", row.Item("MARTES").ToString.Split("~")(1).Trim)
                    dtpDeMiercoles.Text = If(row.Item("MIERCOLES").ToString.Trim.Length = 1, "00:00", row.Item("MIERCOLES").ToString.Split("~")(0).Trim)
                    dtpAMiercoles.Text = If(row.Item("MIERCOLES").ToString.Trim.Length = 1, "00:00", row.Item("MIERCOLES").ToString.Split("~")(1).Trim)
                    dtpDeJueves.Text = If(row.Item("JUEVES").ToString.Trim.Length = 1, "00:00", row.Item("JUEVES").ToString.Split("~")(0).Trim)
                    dtpAJueves.Text = If(row.Item("JUEVES").ToString.Trim.Length = 1, "00:00", row.Item("JUEVES").ToString.Split("~")(1).Trim)
                    dtpDeViernes.Text = If(row.Item("VIERNES").ToString.Trim.Length = 1, "00:00", row.Item("VIERNES").ToString.Split("~")(0).Trim)
                    dtpAViernes.Text = If(row.Item("VIERNES").ToString.Trim.Length = 1, "00:00", row.Item("VIERNES").ToString.Split("~")(1).Trim)
                    dtpDeSabado.Text = If(row.Item("SABADO").ToString.Trim.Length = 1, "00:00", row.Item("SABADO").ToString.Split("~")(0).Trim)
                    dtpASabado.Text = If(row.Item("SABADO").ToString.Trim.Length = 1, "00:00", row.Item("SABADO").ToString.Split("~")(1).Trim)
                    dtpDeDomingo.Text = If(row.Item("DOMINGO").ToString.Trim.Length = 1, "00:00", row.Item("DOMINGO").ToString.Split("~")(0).Trim)
                    dtpADomingo.Text = If(row.Item("DOMINGO").ToString.Trim.Length = 1, "00:00", row.Item("DOMINGO").ToString.Split("~")(1).Trim)

                    lblDias.Text = row.Item("DIAS")
                    lblDiaNoche.Text = row.Item(NomDia.Substring(0, 2).Trim & "_DI")

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

                dtpDeLunes.Text = "00:00"
                dtpALunes.Text = "00:00"
                dtpDeMartes.Text = "00:00"
                dtpAMartes.Text = "00:00"
                dtpDeMiercoles.Text = "00:00"
                dtpAMiercoles.Text = "00:00"
                dtpDeJueves.Text = "00:00"
                dtpAJueves.Text = "00:00"
                dtpDeViernes.Text = "00:00"
                dtpAViernes.Text = "00:00"
                dtpDeSabado.Text = "00:00"
                dtpASabado.Text = "00:00"
                dtpDeDomingo.Text = "00:00"
                dtpADomingo.Text = "00:00"

                lblDias.Text = ""
                lblDiaNoche.Text = ""
            End Try
        End Sub

        Private Sub FrmAgregarPersonalReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    GroupBox1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    GroupBox1.ForeColor = Color.White
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    GroupBox1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    GroupBox1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    GroupBox1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    GroupBox1.ForeColor = Color.White 
            End Select
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        End Sub
    End Class
End Namespace