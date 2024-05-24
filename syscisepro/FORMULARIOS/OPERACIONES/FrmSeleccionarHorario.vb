
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmSeleccionarHorario
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
        ReadOnly _objHorarios As New ClassHorariosOperacion

        Public EsMin As Boolean
        Public NomDia As String
        Public EsDiurno As Boolean

        Private Sub CargarPersonalGeneralOperaciones(ByVal parametroBusqueda As String)
            Try
                If EsMin Then
                    dgvCustodios.DataSource = _objHorarios.SeleccionarHorariosOperacionDia(_tipoCon, NomDia, EsDiurno)

                    dgvCustodios.Columns(0).HeaderText = NomDia
                    dgvCustodios.Columns(0).Width = 120
                    dgvCustodios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Else
                    dgvCustodios.DataSource = _objHorarios.SeleccionarHorariosOperacion(_tipoCon, parametroBusqueda)
                    dgvCustodios.Columns(0).Visible = False
                    dgvCustodios.Columns(1).HeaderText = "N°"
                    dgvCustodios.Columns(1).Width = 40
                    dgvCustodios.Columns(2).Width = 120
                    dgvCustodios.Columns(3).Width = 80
                    dgvCustodios.Columns(4).Width = 80
                    dgvCustodios.Columns(5).Width = 80
                    dgvCustodios.Columns(6).Width = 80
                    dgvCustodios.Columns(7).Width = 80
                    dgvCustodios.Columns(8).Width = 80
                    dgvCustodios.Columns(9).Width = 80
                    dgvCustodios.Columns(10).Visible = False
                    dgvCustodios.Columns(11).Visible = False
                    dgvCustodios.Columns(12).Visible = False
                    dgvCustodios.Columns(13).Visible = False
                    dgvCustodios.Columns(14).Visible = False
                    dgvCustodios.Columns(15).Visible = False
                    dgvCustodios.Columns(16).Visible = False
                    dgvCustodios.Columns(17).Visible = False
                    dgvCustodios.Columns(18).Visible = False
                End If

            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            CargarPersonalGeneralOperaciones(txtParametrobusqueda.Text.Trim)
        End Sub

        Private Sub dgvCustodios_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustodios.CellDoubleClick
            If e.RowIndex > -1 Then
                DialogResult = DialogResult.OK
            End If
        End Sub

        Private Sub FrmSeleccionarHorario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    BackColor = My.MySettingsProperty.Settings.ColorAsenava 
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            CargarPersonalGeneralOperaciones(txtParametrobusqueda.Text.Trim)
        End Sub
    End Class
End Namespace