Namespace VALIDACIONES
    Public Class ClassGenerarSerie
        Private _cadena As String

        Public Function Serie(ByVal numero As Int64) As String             
            _cadena = Convert.ToString(numero)
            Try
                Select Case (_cadena.Length)
                    Case "1" : _cadena = "000000" + _cadena
                    Case "2" : _cadena = "00000" + _cadena
                    Case "3" : _cadena = "0000" + _cadena
                    Case "4" : _cadena = "000" + _cadena
                    Case "5" : _cadena = "00" + _cadena
                    Case "6" : _cadena = "0" + _cadena
                End Select
                Return _cadena
            Catch ex As Exception
                MsgBox("La cadena que ingreso sobrepasa el limite de 7 caracteres", MsgBoxStyle.Critical, "MENSAJE DE VALIDACION")
                Return Nothing
            End Try
        End Function

        Public Function SerieDeDos(ByVal numero As Integer) As String          
            _cadena = Convert.ToString(numero)
            Try
                Select Case (_cadena.Length)
                    Case "1" : _cadena = "0" + _cadena
                End Select
                Return _cadena
            Catch ex As Exception
                MsgBox("La cadena que ingreso sobrepasa el limite de 2 caracteres", MsgBoxStyle.Critical, "MENSAJE DE VALIDACION")
                Return Nothing
            End Try
        End Function

        Public Function SerieCambiaLetras(ByVal numero As Integer) As String
            Dim constante = 27
            Try
                Select Case (numero)
                    Case 1 : _cadena = _cadena & "A"
                    Case 2 : _cadena = _cadena & "B"
                    Case 3 : _cadena = _cadena & "C"
                    Case 4 : _cadena = _cadena & "D"
                    Case 5 : _cadena = _cadena & "E"
                    Case 6 : _cadena = _cadena & "F"
                    Case 7 : _cadena = _cadena & "G"
                    Case 8 : _cadena = _cadena & "H"
                    Case 9 : _cadena = _cadena & "I"
                    Case 10 : _cadena = _cadena & "J"
                    Case 11 : _cadena = _cadena & "K"
                    Case 12 : _cadena = _cadena & "L"
                    Case 13 : _cadena = _cadena & "M"
                    Case 14 : _cadena = _cadena & "N"
                    Case 15 : _cadena = _cadena & "Ñ"
                    Case 16 : _cadena = _cadena & "O"
                    Case 17 : _cadena = _cadena & "P"
                    Case 18 : _cadena = _cadena & "Q"
                    Case 19 : _cadena = _cadena & "R"
                    Case 20 : _cadena = _cadena & "S"
                    Case 21 : _cadena = _cadena & "T"
                    Case 22 : _cadena = _cadena & "U"
                    Case 23 : _cadena = _cadena & "V"
                    Case 24 : _cadena = _cadena & "W"
                    Case 25 : _cadena = _cadena & "X"
                    Case 26 : _cadena = _cadena & "Y"
                    Case 27 : _cadena = _cadena & "Z"
                    Case Else
                        If numero > 27 And numero < 55 Then
                            numero = numero - (constante * 1)
                            _cadena = "A" & serieCambiaLetras(numero)
                        ElseIf numero > 54 And numero < 82 Then
                            numero = numero - (constante * 2)
                            _cadena = "B" & serieCambiaLetras(numero)
                        ElseIf numero > 81 And numero < 109 Then
                            numero = numero - (constante * 3)
                            _cadena = "C" & serieCambiaLetras(numero)
                        ElseIf numero > 108 And numero < 136 Then
                            numero = numero - (constante * 4)
                            _cadena = "D" & serieCambiaLetras(numero)
                        ElseIf numero > 135 And numero < 163 Then
                            numero = numero - (constante * 5)
                            _cadena = "E" & serieCambiaLetras(numero)
                        ElseIf numero > 162 And numero < 190 Then
                            numero = numero - (constante * 6)
                            _cadena = "F" & serieCambiaLetras(numero)
                        ElseIf numero > 189 And numero < 217 Then
                            numero = numero - (constante * 7)
                            _cadena = "G" & serieCambiaLetras(numero)
                        ElseIf numero > 216 And numero < 244 Then
                            numero = numero - (constante * 8)
                            _cadena = "H" & serieCambiaLetras(numero)
                        ElseIf numero > 243 And numero < 271 Then
                            numero = numero - (constante * 9)
                            _cadena = "I" & serieCambiaLetras(numero)
                        ElseIf numero > 270 And numero < 298 Then
                            numero = numero - (constante * 10)
                            _cadena = "J" & serieCambiaLetras(numero)
                        ElseIf numero > 297 And numero < 325 Then
                            numero = numero - (constante * 11)
                            _cadena = "K" & serieCambiaLetras(numero)
                        ElseIf numero > 324 And numero < 352 Then
                            numero = numero - (constante * 12)
                            _cadena = "L" & serieCambiaLetras(numero)
                        ElseIf numero > 351 And numero < 379 Then
                            numero = numero - (constante * 13)
                            _cadena = "M" & serieCambiaLetras(numero)
                        ElseIf numero > 378 And numero < 406 Then
                            numero = numero - (constante * 14)
                            _cadena = "N" & serieCambiaLetras(numero)
                        ElseIf numero > 405 And numero < 433 Then
                            numero = numero - (constante * 15)
                            _cadena = "0" & serieCambiaLetras(numero)
                        ElseIf numero > 432 And numero < 460 Then
                            numero = numero - (constante * 16)
                            _cadena = "P" & serieCambiaLetras(numero)
                        ElseIf numero > 459 And numero < 487 Then
                            numero = numero - (constante * 17)
                            _cadena = "Q" & serieCambiaLetras(numero)
                        ElseIf numero > 486 And numero < 514 Then
                            numero = numero - (constante * 18)
                            _cadena = "R" & serieCambiaLetras(numero)
                        ElseIf numero > 513 And numero < 541 Then
                            numero = numero - (constante * 19)
                            _cadena = "S" & serieCambiaLetras(numero)
                        ElseIf numero > 540 And numero < 568 Then
                            numero = numero - (constante * 20)
                            _cadena = "T" & serieCambiaLetras(numero)
                        ElseIf numero > 567 And numero < 595 Then
                            numero = numero - (constante * 21)
                            _cadena = "U" & serieCambiaLetras(numero)
                        ElseIf numero > 594 And numero < 622 Then
                            numero = numero - (constante * 22)
                            _cadena = "V" & serieCambiaLetras(numero)
                        ElseIf numero > 621 And numero < 649 Then
                            numero = numero - (constante * 23)
                            _cadena = "W" & serieCambiaLetras(numero)
                        ElseIf numero > 648 And numero < 676 Then
                            numero = numero - (constante * 24)
                            _cadena = "X" & serieCambiaLetras(numero)
                        ElseIf numero > 675 And numero < 703 Then
                            numero = numero - (constante * 25)
                            _cadena = "Y" & serieCambiaLetras(numero)
                        ElseIf numero > 702 And numero < 730 Then
                            numero = numero - (constante * 26)
                            _cadena = "Z" & serieCambiaLetras(numero)
                        Else
                            Return Nothing
                        End If
                End Select
                Return _cadena
            Catch ex As Exception
                MsgBox("La cadena que ingreso sobrepasa el limite de 27 caracteres", MsgBoxStyle.Critical, "MENSAJE DE VALIDACION")
                Return Nothing
            End Try
        End Function

    End Class
End Namespace

