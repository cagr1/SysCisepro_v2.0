
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBuscarPuestoTrabajo
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

        ReadOnly _objetoSitio As New ClassSitiosTrabajo

        Private Cargado As Boolean = False

        Private Sub CargarSitios(ByVal filtro As String)
            Try
                Dim grupos = _objetoSitio.SeleccionarSitiosTrabajo2Grupos(_tipoCon, filtro, 1)
                Dim datos = _objetoSitio.SeleccionarSitiosTrabajo4(_tipoCon, filtro, 1)

                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                ' grupos
                For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                    ListView1.Groups.Add(group)
                Next

                ' detalles
                For Each row As DataRow In datos.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(18).ToString.Trim))
                    For i = 1 To datos.Columns.Count - 1
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next
                    ListView1.Items.Add(lst)
                Next

                ' autosize columns
                For Each column As ColumnHeader In From column1 As ColumnHeader In ListView1.Columns Where column1.Width > 5
                    column.Width = -2
                Next

                Cargado = False
            Catch ex As Exception
                ListView1.Items.Clear()
            End Try
        End Sub

        Private Function GetListViewGroup(ByVal name As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView1.Groups Where grupo1.ToString.Trim.Equals(name.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            CargarSitios(txtParametrobusqueda.Text.Trim)
        End Sub

        Private Sub ListView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
            If ListView1.SelectedItems.Count > 0 Then
                DialogResult = DialogResult.OK
            End If
        End Sub

        Private Sub FrmBuscarPuestoTrabajo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a



                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s


                Case Else
                    Icon = My.Resources.logo_c


            End Select

            If Cargado Then txtParametrobusqueda_KeyUp(Nothing, Nothing)
        End Sub

    End Class
End Namespace