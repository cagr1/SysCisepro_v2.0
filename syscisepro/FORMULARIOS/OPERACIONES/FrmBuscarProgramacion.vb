
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBuscarProgramacion
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
        ReadOnly _objCliente As New ClassProgramacionOperaciones

        Public Sub CargarClienteGeneral()
            Try

                dgvCustodios.DataSource = _objCliente.BuscarProgramacion(_tipoCon, dtpMes.Value.Year)
                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40

                dgvCustodios.Columns(1).HeaderText = "MES"
                dgvCustodios.Columns(1).Width = 400

                dgvCustodios.Columns(2).HeaderText = "AÑO"
                dgvCustodios.Columns(2).Width = 40

                dgvCustodios.Columns(3).HeaderText = "DESDE"
                dgvCustodios.Columns(3).Width = 100

                dgvCustodios.Columns(4).HeaderText = "HASTA"
                dgvCustodios.Columns(4).Width = 100

                dgvCustodios.Columns(5).Visible = False
                dgvCustodios.ClearSelection()

                For Each row As DataGridViewRow In dgvCustodios.Rows
                    If row.Cells(2).Value = dtpMes.Value.Year And row.Cells(5).Value = dtpMes.Value.Month Then
                        row.Selected = True
                        dgvCustodios.FirstDisplayedScrollingRowIndex = 0
                        Exit For
                    End If
                Next

            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub dgvCustodios_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustodios.CellDoubleClick
            If e.RowIndex > -1 Then
                DialogResult = DialogResult.OK
            End If
        End Sub

        Private Sub FrmBuscarProgramacion_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label1.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label1.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label1.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dtpMes.Value = New Date(dtpMes.Value.Year, dtpMes.Value.Month, 1)
            CargarClienteGeneral()
        End Sub

        Private Sub dtpMes_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpMes.ValueChanged
            CargarClienteGeneral()
        End Sub
    End Class
End Namespace