Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBuscarActivoFijo

        Private _tipoCon As TipoConexion

        WriteOnly Property TipoCox As Integer
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

        Private Sub FrmBuscarActivoFijo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    Label1.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvActivosFijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label1.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    dgvActivosFijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label1.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    dgvActivosFijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            cbmTipoActivo.SelectedIndex = 0
        End Sub

        Private Sub BuscarActivo(ByVal filtro As String)
            dgvActivosFijos.DataSource = Nothing

            CargarActivos(cbmTipoActivo.Text, filtro)

            If dgvActivosFijos.ColumnCount > 0 Then
                dgvActivosFijos.Columns(0).Width = 50
                dgvActivosFijos.Columns(1).Visible = False
                dgvActivosFijos.Columns(2).Visible = False
                dgvActivosFijos.Columns(3).Visible = False
                dgvActivosFijos.Columns(4).Visible = False
                dgvActivosFijos.Columns(5).Visible = False
                dgvActivosFijos.Columns(6).Width = 140
                dgvActivosFijos.Columns(7).Width = 475 
                dgvActivosFijos.Columns(8).Width = 60
            End If

            dgvActivosFijos.AutoResizeRows()
        End Sub

        ReadOnly _objActivo As New ClassActivoFijo

        Private Sub CargarActivos(ByVal tipo As String, ByVal filtro As String)
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarActivoFijoFiltro(_tipoCon, tipo, filtro)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            If e.KeyCode <> 13 Then Return 
            BuscarActivo(txtParametrobusqueda.Text.Trim()) 
        End Sub

        Private Sub dgvActivosFijos_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvActivosFijos.CellDoubleClick
            If e.RowIndex < 0 Then Return
            DialogResult = DialogResult.OK
        End Sub

        Private Sub cbmTipoActivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmTipoActivo.SelectedIndexChanged
            BuscarActivo(txtParametrobusqueda.Text.Trim())
        End Sub

        Private Sub txtParametrobusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParametrobusqueda.TextChanged

        End Sub
    End Class
End Namespace