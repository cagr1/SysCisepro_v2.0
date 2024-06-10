Imports System.Windows.Forms 
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarAsientoDiario
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

        Public NumeroRegsitroBusqueda As Integer = 0


        ReadOnly _objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario
         

        Private Sub CargarAsientoLibroDiarioBusqueda()

            lblNumeroRegistro.Text = NumeroRegsitroBusqueda
            dgvAsientoDiario.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioResumidoXNumeroRegistro(_tipoCon, NumeroRegsitroBusqueda)
            dgvAsientoDiario.AutoResizeColumns()
            dgvAsientoDiario.AutoResizeRows() 
            dgvAsientoDiario.Columns(1).HeaderText = "FECHA"
            dgvAsientoDiario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvAsientoDiario.Columns(2).HeaderText = "CODIGO CTA"
            dgvAsientoDiario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvAsientoDiario.Columns(3).HeaderText = "NOMBRE CTA"
            dgvAsientoDiario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvAsientoDiario.Columns(4).HeaderText = "CONCEPTO"
            dgvAsientoDiario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvAsientoDiario.Columns(5).HeaderText = "DETALLE"
            dgvAsientoDiario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvAsientoDiario.Columns(6).HeaderText = "VALOR DEBE"
            dgvAsientoDiario.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvAsientoDiario.Columns(7).HeaderText = "VALOR HABER"
            dgvAsientoDiario.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvAsientoDiario.Columns(8).HeaderText = "ASIENTO"
            dgvAsientoDiario.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft

            dgvAsientoDiario.EditMode = DataGridViewEditMode.EditProgrammatically 
            dgvAsientoDiario.Columns(1).Width = 90
            dgvAsientoDiario.Columns(2).Width = 90
            dgvAsientoDiario.Columns(3).Width = 150
            dgvAsientoDiario.Columns(4).Width = 200
            dgvAsientoDiario.Columns(5).Width = 240
            dgvAsientoDiario.Columns(6).Width = 70
            dgvAsientoDiario.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvAsientoDiario.Columns(7).Width = 70
            dgvAsientoDiario.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            dgvAsientoDiario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        End Sub

        Private Sub SumarTotalAsientoDiarioBusqueda()
            Dim totalDebe = 0.0
            Dim totalHaber = 0.0
            Try
                For indice = 0 To dgvAsientoDiario.RowCount - 1
                    totalDebe = totalDebe + CType(dgvAsientoDiario.Rows(indice).Cells(6).Value, Decimal)
                    totalHaber = totalHaber + CType(dgvAsientoDiario.Rows(indice).Cells(7).Value, Decimal)
                Next 
            Catch ex As Exception
                totalDebe = 0.0
                totalHaber = 0.0
            End Try
            txtTotalDebe.Text = totalDebe
            txtTotalHaber.Text = totalHaber

            If txtTotalDebe.Text <> txtTotalHaber.Text Then
                PictureBoxErrorSumaAsiento.Visible = True
            Else
                PictureBoxErrorSumaAsiento.Visible = False
            End If

            If txtTotalDebe.Text <> txtTotalHaber.Text Then
                PictureBoxErrorSumaAsiento.Visible = True
            Else
                PictureBoxErrorSumaAsiento.Visible = False
            End If
        End Sub
        Private Sub FormBuscarAsientoDiarioXCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvAsientoDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
            PictureBoxErrorSumaAsiento.Visible = False ' oculta la imagen de no coinciden debe y haber
            cargarAsientoLibroDiarioBusqueda()
            sumarTotalAsientoDiarioBusqueda()
        End Sub
         
    End Class
End Namespace