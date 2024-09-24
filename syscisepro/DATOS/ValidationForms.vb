Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports System.IO

Namespace DATOS
    Public Class ValidationForms

        Public Shared Function GetColorSistema(ByVal tipoCon As TipoConexion) As Color
            Dim color As Color
            Select Case tipoCon
                Case TipoConexion.Asenava
                    color = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    color = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    color = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            Return color
        End Function

        Public Shared Function ImageToBytes(ByVal image As Image) As Byte()
            If image Is Nothing Then Return Nothing
            Dim bin = New MemoryStream
            image.Save(bin, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return bin.GetBuffer
        End Function

        Public Shared Function BytesToImage(ByVal buffer As Byte()) As Image
            If buffer Is Nothing Then Return Nothing
            Return Image.FromStream(New MemoryStream(buffer))
        End Function


        Public Shared Function Logo(ByVal tipoCon As TipoConexion) As Bitmap
            Dim img As Bitmap
            Select Case tipoCon
                Case TipoConexion.Asenava
                    img = Nothing
                Case TipoConexion.Seportpac
                    img = New Bitmap(My.Resources.SeportPac_wall_min, 60, 60)
                Case Else
                    img = New Bitmap(My.Resources.Cisepro_wall_min, 60, 60)
            End Select
            Return img
        End Function

        Public Shared Function FechaActual(ByVal tipoCon As TipoConexion) As DateTime
            Dim usr = New ClassProgramacionOperaciones
            Return usr.FechaActual(tipoCon)
        End Function

        Public Shared Function NumToCharExcelFromVisibleColumnsDataGrid(ByVal grid As DataGridView) As String
            Dim c = -1
            For i = 0 To grid.ColumnCount - 1
                If Not grid.Columns(i).Visible Then Continue For
                c += 1
            Next
            Dim dividend = c + 1
            Dim columnName = String.Empty
            While dividend > 0
                Dim modulo = (dividend - 1) Mod 26
                columnName = Convert.ToChar(65 + modulo) + columnName
                dividend = (dividend - modulo) / 26
            End While
            Return columnName
        End Function

        Public Shared Function NumToCharExcelFromVisibleColumnsDataTable(ByVal table As DataTable) As String
            Dim c = -1
            For i = 0 To table.Columns.Count - 1
                'If Not table.Columns(i).Visible Then Continue For
                c += 1
            Next
            Dim dividend = c + 1
            Dim columnName = String.Empty
            While dividend > 0
                Dim modulo = (dividend - 1) Mod 26
                columnName = Convert.ToChar(65 + modulo) + columnName
                dividend = (dividend - modulo) / 26
            End While
            Return columnName
        End Function

        Public Shared Function NombreLogo(ByVal tipoCon As TipoConexion, ByVal stp As String)
            Dim name As String
            Select Case tipoCon
                Case TipoConexion.Asenava
                    name = stp & "\logoas.png"
                Case TipoConexion.Seportpac
                    name = stp & "\logose.png"
                Case Else
                    name = stp & "\logoci.png"
            End Select
            Return name
        End Function

        Public Shared Function NombreLogoNuevo(ByVal tipoCon As TipoConexion, ByVal stp As String)
            Dim name As String
            Select Case tipoCon
                Case TipoConexion.Asenava
                    name = stp & "\logoas.png"
                Case TipoConexion.Seportpac
                    name = stp & "\seportpac.png"
                Case Else
                    name = stp & "\cisepro.png"
            End Select
            Return name
        End Function

        Public Shared Function NombreCompany(ByVal tipoCon As TipoConexion)
            Dim company As String
            Select Case tipoCon
                Case TipoConexion.Asenava
                    company = "ASENAVA C. LTDA."
                Case TipoConexion.Seportpac
                    company = "SEPORTPAC C. LTDA."
                Case Else
                    company = "CISEPRO C. LTDA."
            End Select
            Return company
        End Function

        Public Shared Function Mes(ByVal m As Integer) As String
            Dim ms = ""
            Select Case m
                Case 1 : ms = "ENERO"
                Case 2 : ms = "FEBRERO"
                Case 3 : ms = "MARZO"
                Case 4 : ms = "ABRIL"
                Case 5 : ms = "MAYO"
                Case 6 : ms = "JUNIO"
                Case 7 : ms = "JULIO"
                Case 8 : ms = "AGOSTO"
                Case 9 : ms = "SEPTIEMBRE"
                Case 10 : ms = "OCTUBRE"
                Case 11 : ms = "NOVIEMBRE"
                Case 12 : ms = "DICIEMBRE"
            End Select
            Return ms
        End Function

        Public Shared Function GenerarClaveAccesoComprobantesElectronicos(ByVal tipoClave As String, ByVal fecha As DateTime, ByVal ruc As String, ByVal ambiente As String, ByVal establecimiento As String, ByVal ptoEmision As String, ByVal secVenta As String, ByVal tipoEmision As String) As String
            Dim claveAcceso = String.Empty

            claveAcceso = claveAcceso.ToString + Format(fecha, "ddMMyyyy").ToString  '1 - Fecha de emisión [ddmmaaaa]
            claveAcceso = claveAcceso.ToString + tipoClave  '2 - Tipo de comprobante [FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07]
            claveAcceso = claveAcceso.ToString + ruc  '3 - Número de RUC
            claveAcceso = claveAcceso.ToString + ambiente '4 - Tipo de ambniente [PRUEBA 1, PRODUCCIÓN 2]
            claveAcceso = claveAcceso.ToString + establecimiento + ptoEmision   '5 - Serie [ESTABLECIMIENTO + PUNTO DE EMISIÓN]
            claveAcceso = claveAcceso.ToString + secVenta     '6 - Número del comprobante [SECUENCIAL]
            claveAcceso = claveAcceso.ToString + "26101984" '7 - Código numérico [CÓDIGO PROPIO ]
            claveAcceso = claveAcceso.ToString + tipoEmision '8 - Tipo de emisión [EMISIÓN NORMAL 1, EMISIÓN POR INDISPONIBILIDAD DEL SISTEMA 2]

            '9 - Digito verificador [ALGORITMO Modulo 11]
            Dim invertida = "" ' cadena de la clave  de acceso inverdia
            For indiceClave = 1 To claveAcceso.ToString.Count ' se recorre la cadena claveAcceso
                invertida = Mid(claveAcceso, indiceClave, 1) + invertida ' se forma la cadena invertida agregando el nuevo valor delante de los anteriores
            Next

            'algoritmo módulo 11
            Dim pivote = 2 ' valorr por cual se va multiplicando los elementos de la cadena se incrementa en 1 hasta llegar a 7 y vuelve a 2
            Dim suma = 0 ' acumula los valore de la multiplicacion del pivote * actual
            For indiceInvertida = 1 To invertida.ToString.Count ' recorremos la cadena invertida
                If pivote = 8 Then pivote = 2 ' si el pivote se pasa de 7 lo reseteamos a 2
                suma += CInt(Mid(invertida, indiceInvertida, 1)) * pivote ' multiplica el valor actual por elpivote y se va acumulando
                pivote += 1 ' se aumenta el valor del pivote
            Next

            Dim verificador = 11 - (suma Mod 11) ' se resta de 11 el residuo de la división
            If verificador = 11 Then ' se valida si el digito verificador = 11 se cambia por 0
                verificador = 0
            ElseIf verificador = 10 Then ' se valida si el digito verificador = 10 se cambia por 1
                verificador = 1
            End If
            claveAcceso = claveAcceso.ToString + verificador.ToString

            Return claveAcceso
        End Function

        Public Shared Function GenerarClaveAccesoFacturacionElectronica(ByVal tipoClave As String, ByVal fecha As DateTime, ByVal ruc As String, ByVal ambiente As String, ByVal establecimiento As String, ByVal ptoEmision As String, ByVal secVenta As String, ByVal tipoEmision As String) As String
            Dim claveAcceso = ""

            claveAcceso = claveAcceso.ToString + Format(fecha, "ddMMyyyy").ToString '1 - Fecha de emisión [ddmmaaaa]
            claveAcceso = claveAcceso.ToString + tipoClave '2 - Tipo de comprobante [FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓ 07]
            claveAcceso = claveAcceso.ToString + ruc.ToString '3 - Número de RUC
            claveAcceso = claveAcceso.ToString + ambiente.ToString   '4 - Tipo de ambniente [PRUEBA 1, PRODUCCIÓN 2]
            claveAcceso = claveAcceso.ToString + establecimiento.ToString + ptoEmision.ToString  '5 - Serie [ESTABLECIMIENTO + PUNTO DE EMISIÓN]
            claveAcceso = claveAcceso.ToString + secVenta.ToString '6 - Número del comprobante [SECUENCIAL]
            claveAcceso = claveAcceso.ToString + "19842610"   '7 - Código numérico [CÓDIGO PROPIO ]
            claveAcceso = claveAcceso.ToString + tipoEmision.ToString  '8 - Tipo de emisión [EMISIÓN NORMAL 1, EMISIÓN POR INDISPONIBILIDAD DEL SISTEMA 2]

            '9 - Digito verificador [ALGORITMO Modulo 11]
            Dim invertida = "" ' cadena de la clave  de acceso inverdia
            For indiceClave = 1 To claveAcceso.ToString.Count ' se recorre la cadena claveAcceso
                invertida = Mid(claveAcceso, indiceClave, 1) + invertida ' se forma la cadena invertida agregando el nuevo valor delante de los anteriores
            Next

            'algoritmo módulo 11
            Dim pivote = 2 ' valorr por cual se va multiplicando los elementos de la cadena se incrementa en 1 hasta llegar a 7 y vuelve a 2
            Dim suma = 0 ' acumula los valore de la multiplicacion del pivote * actual
            For indiceInvertida = 1 To invertida.ToString.Count ' recorremos la cadena invertida
                If pivote = 8 Then pivote = 2 ' si el pivote se pasa de 7 lo reseteamos a 2
                suma += CInt(Mid(invertida, indiceInvertida, 1)) * pivote ' multiplica el valor actual por elpivote y se va acumulando
                pivote += 1 ' se aumenta el valor del pivote
            Next

            Dim verificador = 11 - (suma Mod 11) ' se resta de 11 el residuo de la división
            If verificador = 11 Then ' se valida si el digito verificador = 11 se cambia por 0
                verificador = 0
            ElseIf verificador = 10 Then ' se valida si el digito verificador = 10 se cambia por 1
                verificador = 1
            End If
            claveAcceso = claveAcceso.ToString + verificador.ToString

            Return claveAcceso
        End Function

        Public Sub SetPlaceholder(txtBox As TextBox, placeholderText As String)

            txtBox.Text = placeholderText
            txtBox.ForeColor = Color.Gray


            AddHandler txtBox.Enter, Sub(sender, e)
                                         If txtBox.Text = placeholderText Then
                                             txtBox.Text = String.Empty
                                             txtBox.ForeColor = Color.Black
                                         End If
                                     End Sub

            AddHandler txtBox.Leave, Sub(sender, e)
                                         If String.IsNullOrWhiteSpace(txtBox.Text) Then
                                             txtBox.Text = placeholderText
                                             txtBox.ForeColor = Color.Gray
                                         End If
                                     End Sub
        End Sub
    End Class
End Namespace