Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarVehiculo
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

        ReadOnly _objVehiculos As New ClassVehiculo

        Public Sub CargarVehiculo(ByVal filter As String)
            Try
                dgvVehiculos.DataSource = _objVehiculos.SeleccionarTodosLosRegistrosVehiculosFiltro(_tipoCon, filter).Tables("VEHICULOS")

                dgvVehiculos.ReadOnly = True

                For Each row As DataGridViewColumn In dgvVehiculos.Columns
                    row.Visible = False
                Next

                dgvVehiculos.Columns(0).HeaderText = "ID"
                dgvVehiculos.Columns(0).Width = 50
                dgvVehiculos.Columns(0).Visible = True

                dgvVehiculos.Columns(9).HeaderText = "VEHICULO"
                dgvVehiculos.Columns(9).Width = 300
                dgvVehiculos.Columns(9).Visible = True

                dgvVehiculos.Columns(33).Width = 80
                dgvVehiculos.Columns(33).Visible = True

                dgvVehiculos.Columns(34).Width = 80
                dgvVehiculos.Columns(34).Visible = True

                dgvVehiculos.Columns(35).Width = 80
                dgvVehiculos.Columns(35).Visible = True

                dgvVehiculos.Columns(36).Width = 80
                dgvVehiculos.Columns(36).Visible = True


                dgvVehiculos.AutoResizeRows()
            Catch ex As Exception
                dgvVehiculos.DataSource = Nothing
            End Try
        End Sub
        Private Sub FormBusquedaVehiculoControlCombustibleCaja_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            CargarVehiculo(String.Empty)
            txtNombresRecibe.Focus()
        End Sub

        Private Sub dgvVehiculos_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvVehiculos.CellDoubleClick
            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub txtNombresRecibe_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombresRecibe.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            cargarVehiculo(txtNombresRecibe.Text.Trim)
        End Sub
    End Class
End Namespace