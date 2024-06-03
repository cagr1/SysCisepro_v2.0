Imports System.Windows.Forms
Imports System.Drawing

Public Class ClassCustomTextBox
    Inherits TextBox

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Const WM_PAINT As Integer = &HF

        If m.Msg = WM_PAINT Then ' WM_PAINT
            Using g As Graphics = Me.CreateGraphics()
                Dim rect As Rectangle = Me.ClientRectangle
                Dim format As New StringFormat()
                format.Alignment = StringAlignment.Near
                format.LineAlignment = StringAlignment.Center

                g.Clear(Me.BackColor)
                TextRenderer.DrawText(g, Me.Text, Me.Font, rect, Me.ForeColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
            End Using
        End If
    End Sub

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.BorderStyle = BorderStyle.None
        'Me.BackColor = Color.Transparent
    End Sub

End Class
