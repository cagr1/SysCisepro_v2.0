Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.COMPROBANTES

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBuscarComprobanteIngresoEgreso
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

        Public EsCompra As Boolean
        ReadOnly _objIngreso As New ClassComprobanteIngresoBodego
        ReadOnly _objEgreso As New ClassComprobanteEgresoBodega
        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra

        Private Sub FrmBuscarComprobanteIngresoEgreso_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    Label1.ForeColor = Color.White
                    rbtEgreso.ForeColor = Color.White
                    rbtIngreso.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label1.ForeColor = Color.White
                    rbtEgreso.ForeColor = Color.White
                    rbtIngreso.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label1.ForeColor = Color.White
                    rbtEgreso.ForeColor = Color.White
                    rbtIngreso.ForeColor = Color.White
            End Select

            ListView1.Visible = Not EsCompra
            ListView2.Visible = EsCompra
        End Sub

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            If EsCompra Then
                CargarCompras()
            Else
                If rbtIngreso.Checked Then
                    'CargarIngresos(txtParametrobusqueda.Text.Length = 0)
                Else
                    CargarEgresos(txtParametrobusqueda.Text.Length = 0)
                End If
            End If 
        End Sub

        Private Sub CargarEgresos(ByVal todos As Boolean)
            Try
                Dim grupos = _objEgreso.SeleccionarGruposComprobantesEgresoBodegaxNroComprobante(_tipoCon, txtParametrobusqueda.Text.Trim(), todos)
                Dim datos = _objEgreso.SeleccionarDatosComprobantesEgresoBodegaxNroComprobante(_tipoCon, txtParametrobusqueda.Text.Trim(), todos)

                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                ' grupos
                For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                    ListView1.Groups.Add(group)
                Next

                ' detalles
                For Each row As DataRow In datos.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup1(row.Item(0).ToString.Trim))
                    For i = 1 To datos.Columns.Count - 1
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next
                    ListView1.Items.Add(lst)
                Next

                ' autosize columns
                For Each column As ColumnHeader In From column1 As ColumnHeader In ListView1.Columns Where column1.Width > 5
                    column.Width = -2
                    If column.Index = 0 Or column.Index = 1 Then column.Width = 0
                    If column.Index = 3 Then column.Width = 500
                Next

            Catch ex As Exception
                ListView1.Items.Clear()
            End Try
        End Sub

        Private Function GetListViewGroup1(ByVal name As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView1.Groups Where grupo1.ToString.Trim.Equals(name.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Function GetListViewGroup2(ByVal name As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView2.Groups Where grupo1.ToString.Trim.Equals(name.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub ListView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
            If ListView1.SelectedItems.Count > 0 Then DialogResult = DialogResult.OK
        End Sub
         
        Private Sub CargarCompras()
            Try

                Dim grupos = _objetoComprobantesCompra.SeleccionarProveedoresParaComprasngresoBodegaGrupo(_tipoCon, txtParametrobusqueda.Text.Trim())
                Dim datos = _objetoComprobantesCompra.SeleccionarProveedoresParaComprasngresoBodegaDatos(_tipoCon, txtParametrobusqueda.Text.Trim())

                ListView2.Items.Clear()
                ListView2.Groups.Clear()

                ' grupos
                For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(0).ToString.Trim)
                    ListView2.Groups.Add(group)
                Next

                'detalles
                For Each row As DataRow In datos.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup2(row.Item(1).ToString.Trim))
                    For i = 1 To datos.Columns.Count - 1
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next
                    ListView2.Items.Add(lst)
                Next

                '' autosize columns
                For Each column As ColumnHeader In From column1 As ColumnHeader In ListView2.Columns Where column1.Width > 5
                    column.Width = -2
                    If column.Index = 1 Then column.Width = 0
                Next

            Catch ex As Exception
                ListView2.Items.Clear()
            End Try
        End Sub

        Private Sub ListView2_MouseDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.MouseEventArgs) Handles ListView2.MouseDoubleClick
            If ListView2.SelectedItems.Count > 0 Then DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace