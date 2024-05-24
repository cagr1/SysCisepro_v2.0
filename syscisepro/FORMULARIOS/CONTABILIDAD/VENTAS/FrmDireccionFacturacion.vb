Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    Public Class FrmDireccionFacturacion
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
        ReadOnly _objetoDireccionesFacturacion As New ClassDireccionesFacturacion

        Private Sub FrmDireccionFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing 
                    DataGridView3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                    DataGridView3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c 
                    DataGridView3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            DataGridView3.Rows.Clear()
            Try

                Dim dir = _objetoDireccionesFacturacion.BuscarDireccionesFacturacionClienteXIdClienteEnVentas(_tipoCon, Label44.Text.Trim)
                If dir.Rows.Count > 0 Then
                    For Each row As DataRow In dir.Rows
                        DataGridView3.Rows.Add(row(0).ToString)
                    Next
                End If
            Catch ex As Exception
                DataGridView3.Rows.Clear()
            End Try
        End Sub

        Private Sub DataGridView3_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
            If DataGridView3.CurrentRow Is Nothing Then DialogResult = DialogResult.Cancel
            DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace