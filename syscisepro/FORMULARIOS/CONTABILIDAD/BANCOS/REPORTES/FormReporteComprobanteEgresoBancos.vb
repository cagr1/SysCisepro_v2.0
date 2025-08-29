Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteComprobanteEgresoBancos
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
        Public IdUsuario As Integer
        Public Tipo As Integer

        Dim objetoComprobanteEgresoBancos As New ClassComprobanteEgresoBanco
        Dim objetoChequeEmitido As New ClassChequesEmitidosCxp

        Dim crComprobanteEgreso As New crComprobanteEgresoBancos
        ReadOnly _crComprobanteEgresoMachala As New crComprobanteEgresoBancoMachala2
        Dim crComprobanteEgresoHorizontal As New crComprobanteEgresoBancosHorizontal

        Dim crChequeEmitido As New crChequesEmitidos
        Dim objetoNumeroRegistroAsientoCompEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso
        Dim _objValidaciones As New ClassConversion


        Dim numeroRegistro As Int64 = 0
        Public Sub conectarReporteComprobanteEgreso()
            Try
                numeroRegistro = objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgreso.Text)

                If Tipo = 0 Then
                    crComprobanteEgreso.SetDataSource(objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), numeroRegistro))
                Else
                    crComprobanteEgresoHorizontal.SetDataSource(objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), numeroRegistro))
                End If

                crComprobanteEgreso.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvComprovanteEgresoBancos.ReportSource = crComprobanteEgreso
                crvComprovanteEgresoBancos.Zoom(75)
                crvComprovanteEgresoBancos.Refresh()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Public Sub conectarReporteComprobanteEgresoMachala()
            Try


                _crComprobanteEgresoMachala.SetDataSource(objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoMachalaXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), numeroRegistro))
                crvMachala.ReportSource = _crComprobanteEgresoMachala
                crvMachala.Zoom(75)
                crvMachala.Refresh()
            Catch ex As Exception
            End Try
        End Sub

        Public Sub conectarReporteChequeEmitido()
            'Try
            '    crChequeEmitido.SetDataSource(objetoChequeEmitido.SeleccionarChequeEmitidoXIdComprobanteEgreso(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64)))
            '    crvChequeEmitido.ReportSource = crChequeEmitido
            '    crvChequeEmitido.Zoom(75)
            '    crvChequeEmitido.Refresh()
            'Catch ex As Exception
            '    Console.WriteLine(ex.Message)
            'End Try


            Try
                'If lblIdComprobanteEgreso.Text = "000" Then Return

                If lblIdComprobanteEgreso.Text <> "" Then
                    Dim ds As DataSet = objetoChequeEmitido.SeleccionarChequeEmitidoXIdComprobante(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64))

                    If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                        Dim row As DataRow = ds.Tables(0).Rows(0)
                        Dim nombre As String = row("Nombre").ToString()
                        Dim valor As Decimal = Convert.ToDecimal(row("Valor"))
                        Dim ciudad As String = row("Ciudad").ToString()
                        Dim fecha As DateTime = Convert.ToDateTime(row("Fecha"))
                        Dim Letras As String = Convert.ToString(valor) + " dólares"

                        Dim pdfStream As New MemoryStream()
                        Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ComprobanteCompraCheque.pdf")
                        PdfViewer1.Document?.Dispose()
                        PdfViewer1.Document = Nothing

                        ' Configurar el documento con las medidas del cheque (15.5cm ancho × 7.5cm alto)
                        Dim chequeWidth As Single = Utilities.MillimetersToPoints(155) ' 15.5 cm
                        Dim chequeHeight As Single = Utilities.MillimetersToPoints(75) ' 7.5 cm
                        Dim pageSize As New Rectangle(chequeWidth, chequeHeight)

                        Dim document As New iTextSharp.text.Document(pageSize, 0, 0, 0, 0) ' Márgenes de 20 puntos
                        Dim writer As PdfWriter = PdfWriter.GetInstance(document, pdfStream)
                        writer.CloseStream = False
                        document.Open()

                        ' Configurar fuentes
                        Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
                        Dim fuente12Bold As New Font(baseFont, 12, Font.Bold)
                        Dim fuente10Bold As New Font(baseFont, 10, Font.Bold)
                        Dim fuente10 As New Font(baseFont, 10)
                        Dim fuente8 As New Font(baseFont, 8)
                        Dim fuente8Bold As New Font(baseFont, 8, Font.Bold)

                        ' Obtener el valor en letras (necesitarías implementar esta función)
                        Dim valorEnLetras As String = _objValidaciones.Letras(Letras)

                        ' Convertir las coordenadas cm a puntos (1 cm = 28.35 puntos)
                        Dim cmToPoints As Single = 28.35F

                        ' 1. Nombre del beneficiario - Posición: X=2cm, Y=2.5cm
                        Dim nombreX As Single = 2 * cmToPoints
                        Dim nombreY As Single = chequeHeight - (2.3 * cmToPoints) ' Y se mide desde arriba
                        Dim ctNombre As New ColumnText(writer.DirectContent)
                        ctNombre.SetSimpleColumn(nombreX, nombreY, nombreX + 200, nombreY + 20)
                        ctNombre.AddElement(New Paragraph(nombre, fuente8Bold))
                        ctNombre.Go()

                        ' 2. Valor numérico - Posición: X=12.5cm, Y=2.5cm
                        Dim valorX As Single = 12.5 * cmToPoints
                        Dim valorY As Single = chequeHeight - (2.3 * cmToPoints)
                        Dim ctValor As New ColumnText(writer.DirectContent)
                        ctValor.SetSimpleColumn(valorX, valorY, valorX + 100, valorY + 20)
                        ctValor.AddElement(New Paragraph(String.Format("** {0:N2} **", valor), fuente10Bold))
                        ctValor.Go()

                        ' 3. Valor en letras - Posición: Centrado, Y=3cm
                        Dim letrasY As Single = chequeHeight - (3 * cmToPoints)
                        Dim letrasX As Single = 2 * cmToPoints
                        Dim ctLetras As New ColumnText(writer.DirectContent)
                        ctLetras.SetSimpleColumn(letrasX, letrasY, chequeWidth, letrasY + 20)
                        ctLetras.Alignment = Element.ALIGN_CENTER
                        ctLetras.AddElement(New Paragraph(valorEnLetras, fuente8))
                        ctLetras.Go()

                        ' 4. Ciudad y fecha - Posición: X=2cm, Y=4.3cm
                        Dim ciudadX As Single = 2 * cmToPoints
                        Dim ciudadY As Single = chequeHeight - (4.3 * cmToPoints)
                        Dim ctCiudad As New ColumnText(writer.DirectContent)
                        ctCiudad.SetSimpleColumn(ciudadX, ciudadY, ciudadX + 200, ciudadY + 20)
                        ctCiudad.AddElement(New Paragraph($"{ciudad}, {fecha:yyyy-MM-dd}", fuente8))
                        ctCiudad.Go()

                        ' Cerrar documento
                        document.Close()

                        ' Mostrar el PDF en el visor
                        pdfStream.Seek(0, SeekOrigin.Begin)
                        PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
                        PdfViewer1.ZoomMode = 1

                        ' Opcional: Guardar en archivo temporal
                        File.WriteAllBytes(ruta, pdfStream.ToArray())
                    End If

                End If
            Catch ex As Exception
                KryptonMessageBox.Show("Error al generar el comprobante de compra: " + ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try


        End Sub
        Private Sub crvComprovanteEgresoBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvComprovanteEgresoBancos.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select

            conectarReporteComprobanteEgreso()
            conectarReporteChequeEmitido()
            conectarReporteComprobanteEgresoMachala()

        End Sub

        Private Sub txtIdComprobanteEgreso_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtIdComprobanteEgreso.KeyDown
            If e.KeyCode = Keys.Enter Then
                If txtIdComprobanteEgreso.Text <> "" Then
                    lblIdComprobanteEgreso.Text = txtIdComprobanteEgreso.Text
                    txtIdComprobanteEgreso.Enabled = False
                    conectarReporteComprobanteEgreso()
                    conectarReporteChequeEmitido()
                    txtIdComprobanteEgreso.Enabled = True
                End If
            End If
        End Sub

        Private Sub txtIdComprobamteEgreso2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdComprobamteEgreso2.KeyDown
            If e.KeyCode = Keys.Enter Then
                If txtIdComprobamteEgreso2.Text <> "" Then
                    lblIdComprobanteEgreso.Text = txtIdComprobamteEgreso2.Text
                    txtIdComprobamteEgreso2.Enabled = False
                    conectarReporteComprobanteEgreso()
                    conectarReporteChequeEmitido()
                    txtIdComprobamteEgreso2.Enabled = True
                End If
            End If
        End Sub

        Private Sub FormReporteComprobanteEgresoBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
        End Sub

        Private Sub crvChequeEmitido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvChequeEmitido.Load

        End Sub

        Private Sub txtIdComprobanteEgreso_TextChanged(sender As Object, e As EventArgs) Handles txtIdComprobanteEgreso.TextChanged

        End Sub
    End Class
End Namespace