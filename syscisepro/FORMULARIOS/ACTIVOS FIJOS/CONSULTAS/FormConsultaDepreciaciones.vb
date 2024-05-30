Imports ClassLibraryCisepro.ACTIVOS_FIJOS.DEPRECIACIONES
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaDepreciaciones
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

        ReadOnly _objDepreciaciones As New ClassDepreciaciones
        Private Sub FormConsultaDepreciaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dgvDepreciaciones.DataSource = _objDepreciaciones.SeleccionarTodasLosRegistrosDepreciaciones(_tipoCon)
            dgvDepreciaciones.AutoResizeColumns()
            dgvDepreciaciones.AutoResizeRows()
            dgvDepreciaciones.ReadOnly = False
            dgvDepreciaciones.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvDepreciaciones.Font = New Font("Roboto", 8, FontStyle.Regular)
        End Sub
    End Class
End Namespace