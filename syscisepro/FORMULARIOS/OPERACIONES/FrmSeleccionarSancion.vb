Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.TALENTO_HUMANO

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmSeleccionarSancion
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
        ReadOnly _objSancionesPersonal As New ClassSanciones

        Private Sub CargarPersonalGeneralOperaciones(ByVal parametroBusqueda As String)
            Try
                Dim grupos = _objSancionesPersonal.SeleccionarTiposSanciones(_tipoCon)
                Dim datos = _objSancionesPersonal.SeleccionarSancionesFiltro(_tipoCon, parametroBusqueda)

                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                ' grupos
                For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                    ListView1.Groups.Add(group)
                Next

                ' detalles
                For Each row As DataRow In datos.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(1).ToString.Trim))
                    For i = 1 To datos.Columns.Count - 1
                        If i = 1 Then ' excepto el titulode grupo (porque ya esta especificado en el grupo)
                            Continue For
                        End If
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next
                    ListView1.Items.Add(lst)
                Next

                ' autosize columns
                For Each column As ColumnHeader In From column1 As ColumnHeader In ListView1.Columns Where column1.Width > 5
                    column.Width = -2
                Next
            Catch ex As Exception
                ListView1.Items.Clear()
            End Try
        End Sub

        Private Function GetListViewGroup(ByVal nm As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView1.Groups Where grupo1.ToString.Trim.Equals(nm.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            CargarPersonalGeneralOperaciones(txtParametrobusqueda.Text.Trim)
        End Sub

        Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.DoubleClick
            If ListView1.SelectedItems Is Nothing Then Return
            DialogResult = DialogResult.OK
        End Sub

        Private Sub FrmSeleccionarSancion_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c  
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    BackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
        End Sub
    End Class
End Namespace