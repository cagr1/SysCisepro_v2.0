Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmEditarRegistroPorgramacion
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

        Private Sub bntHorarios_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntHorarios.Click
            If txtIdPersonal.Text.Trim.Length = 0 Then
                MsgBox("Por favor, seleccione un empleado o personal", MsgBoxStyle.Exclamation, "Mensaje de validación")
                Return
            End If

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

                    dtpDeLunes.Text = If(row.Cells("LUNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("LUNES").Value.ToString.Split("~")(0).Trim)
                    dtpALunes.Text = If(row.Cells("LUNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("LUNES").Value.ToString.Split("~")(1).Trim)
                    dtpDeMartes.Text = If(row.Cells("MARTES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MARTES").Value.ToString.Split("~")(0).Trim)
                    dtpAMartes.Text = If(row.Cells("MARTES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MARTES").Value.ToString.Split("~")(1).Trim)
                    dtpDeMiercoles.Text = If(row.Cells("MIERCOLES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MIERCOLES").Value.ToString.Split("~")(0).Trim)
                    dtpAMiercoles.Text = If(row.Cells("MIERCOLES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("MIERCOLES").Value.ToString.Split("~")(1).Trim)
                    dtpDeJueves.Text = If(row.Cells("JUEVES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("JUEVES").Value.ToString.Split("~")(0).Trim)
                    dtpAJueves.Text = If(row.Cells("JUEVES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("JUEVES").Value.ToString.Split("~")(1).Trim)
                    dtpDeViernes.Text = If(row.Cells("VIERNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("VIERNES").Value.ToString.Split("~")(0).Trim)
                    dtpAViernes.Text = If(row.Cells("VIERNES").Value.ToString.Trim.Length = 1, "00:00", row.Cells("VIERNES").Value.ToString.Split("~")(1).Trim)
                    dtpDeSabado.Text = If(row.Cells("SABADO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("SABADO").Value.ToString.Split("~")(0).Trim)
                    dtpASabado.Text = If(row.Cells("SABADO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("SABADO").Value.ToString.Split("~")(1).Trim)
                    dtpDeDomingo.Text = If(row.Cells("DOMINGO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("DOMINGO").Value.ToString.Split("~")(0).Trim)
                    dtpADomingo.Text = If(row.Cells("DOMINGO").Value.ToString.Trim.Length = 1, "00:00", row.Cells("DOMINGO").Value.ToString.Split("~")(1).Trim)

                    bntHorarios.Tag = row.Cells("DIAS").Value

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
            End Try
        End Sub

        Private Sub FrmEditarRegistroPorgramacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a

                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s

                Case Else
                    Icon = My.Resources.logo_c

            End Select
        End Sub
    End Class
End Namespace