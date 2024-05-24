Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAuxiliarMantenimientos
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

        ReadOnly _objMantAct As New ClassActivoFijoMantenimiento
        ReadOnly _objAsi As New ClassAsientosLibroDiario

        Private Sub FormAuxiliarMantenimientos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvMantenimimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvMantenimimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvMantenimimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dgvMantenimimientos.DataSource = _objMantAct.SeleccionarSolictudesMantenimientosRealizadas(_tipoCon)
        End Sub

        Private Sub CargarAsientoxNroAsiento(ByVal nroAsiento As Int64)
            Try
                dgvAsientos.DataSource = _objAsi.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, nroAsiento)
                dgvAsientos.AutoResizeColumns()
                dgvAsientos.AutoResizeColumns()
            Catch ex As Exception
                dgvAsientos.DataSource = Nothing 
            End Try
        End Sub

        Private Sub dgvMantenimimientos_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvMantenimimientos.CellClick
            CargarAsientoxNroAsiento(dgvMantenimimientos.CurrentRow.Cells.Item("ASIENTO").Value)
        End Sub
          
    End Class
End Namespace