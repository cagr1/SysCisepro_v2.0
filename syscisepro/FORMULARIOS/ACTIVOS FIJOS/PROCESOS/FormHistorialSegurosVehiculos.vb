Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES.VEHICULOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormHistorialSegurosVehiculos
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

        ReadOnly _objActivoFijo As New ClassActivoFijo
        ReadOnly _objHistorialVehiculos As New ClassHistorialVehiculos
        ReadOnly _objVehiculos As New ClassVehiculo

        Private Sub CargarTodos()
            Try
                dgvHistorial.DataSource = _objHistorialVehiculos.SeleccionarTodosHistorialVehiculos(_tipoCon)
                dgvHistorial.AutoResizeColumns()
                dgvHistorial.AutoResizeRows()
                dgvHistorial.ReadOnly = False
            Catch ex As Exception

            End Try

        End Sub

        Private Sub CargarHistoriasPorIdActivo(ByVal idActivoFijo As Integer)
            Try
                dgvHistorial.DataSource = _objHistorialVehiculos.BuscarHistorialPorIdActivoFijo(_tipoCon, idActivoFijo)
                dgvHistorial.AutoResizeColumns()
                dgvHistorial.AutoResizeRows()
                dgvHistorial.ReadOnly = False
            Catch
                dgvHistorial.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboVehiculos()
            Try
                cbmVehiculos.DataSource = _objVehiculos.SeleccionarTodosLosRegistrosVehiculos(_tipoCon).Tables("VEHICULOS")
                cbmVehiculos.DisplayMember = "NOMBRE_ACTIVO"
                cbmVehiculos.ValueMember = "NOMBRE_ACTIVO"
            Catch
                cbmVehiculos.DataSource = Nothing
            End Try
        End Sub
        Private Sub FormHistorialSegurosVehiculos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvHistorial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvHistorial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                     dgvHistorial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            CargarTodos()
            LlenarComboVehiculos()

        End Sub
        Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFiltrar.Click
            CargarHistoriasPorIdActivo(lblIdActivo.Text)
        End Sub

        Private Sub cbmVehiculos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmVehiculos.SelectedIndexChanged
            lblIdActivo.Text = _objActivoFijo.BuscarIdActivoActivoFijoPorNombreActivo(_tipoCon, cbmVehiculos.Text)
        End Sub
    End Class
End Namespace