Imports System.Media

Namespace VALIDACIONES
    Public Class ClassBeep
        Private Declare Function Beep Lib "kernel32" (ByVal soundFrequency As Int32, ByVal soundDuration As Int32) As Int32
        Public Sub Intermitente()
            For i = 1 To 5
                Beep(500, 2000)
            Next
        End Sub
      
        Public Sub Advertir()
            SystemSounds.Hand.Play()
        End Sub
    End Class
End Namespace

