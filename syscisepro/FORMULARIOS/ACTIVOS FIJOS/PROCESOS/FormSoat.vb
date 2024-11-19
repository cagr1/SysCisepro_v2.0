Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormSoat
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
        ReadOnly _sonido As New ClassBeep
        ReadOnly _objVehiculos As New ClassVehiculo

        Private Sub FormSoat_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvSoat.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvSoat.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvSoat.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvSoat.Font = New Font("Roboto", 8, FontStyle.Regular)
            txtFechaActual.Text = Date.Now
            Consultar()
            If dgvSoat.RowCount > 1 Then
                MsgBox("Algunos Vehículos necesitan renovar el SOAT esta semana", MsgBoxStyle.Critical, "Mensaje de validación")
                _sonido.Intermitente()
            Else
                MsgBox("No existen Vehículos que necesiten renovar el SOAT esta semana", MsgBoxStyle.Information, "Mensaje de validación")
                Close()
            End If 
        End Sub

        Private Sub Consultar()
            dgvSoat.DataSource = _objVehiculos.SeleccionarSoatProximosSemana(_tipoCon).Tables("ACTIVO_FIJO_GENERAL")
            dgvSoat.AutoResizeColumns()
            dgvSoat.AutoResizeRows()
            dgvSoat.ReadOnly = False
            dgvSoat.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvSoat.Columns("SOAT").DefaultCellStyle.BackColor = Color.Red
        End Sub
        Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnConsultar.Click
            Consultar()
        End Sub
    End Class
End Namespace