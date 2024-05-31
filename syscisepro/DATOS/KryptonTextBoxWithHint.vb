Imports ClassLibraryCisepro.ENUMS
Imports Krypton.Toolkit
Imports System.Drawing
Imports System.Windows.Forms
Public Class KryptonTextBoxWithHint
    Inherits KryptonTextBox

    Private _hint As String = String.Empty
    Private _isHintActive As Boolean = True

    Public Property Hint As String
        Get
            Return _hint
        End Get
        Set(value As String)
            _hint = value
            ShowHint()
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        AddHandler Me.Enter, AddressOf RemoveHint
        AddHandler Me.Leave, AddressOf ShowHint
        ShowHint()
    End Sub

    Private Sub ShowHint(sender As Object, e As EventArgs)
        ShowHint()
    End Sub

    Private Sub RemoveHint(sender As Object, e As EventArgs)
        If _isHintActive Then
            Me.Text = String.Empty
            Me.ForeColor = Color.Black
            Me._isHintActive = False
        End If
    End Sub

    Private Sub ShowHint()
        If String.IsNullOrWhiteSpace(Me.Text) Then
            Me.Text = _hint
            Me.ForeColor = Color.Gray
            Me._isHintActive = True
        Else
            Me.ForeColor = Color.Black
            Me._isHintActive = False
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        If _isHintActive AndAlso Not String.IsNullOrEmpty(_hint) Then
            Using g As Graphics = e.Graphics
                Using brush As New SolidBrush(Color.Gray)
                    Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    Dim rect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
                    g.DrawString(_hint, Me.Font, brush, rect, sf)
                End Using

            End Using
        End If
    End Sub



End Class
