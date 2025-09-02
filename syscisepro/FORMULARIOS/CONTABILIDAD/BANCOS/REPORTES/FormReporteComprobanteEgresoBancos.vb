Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit
Imports DocumentFormat.OpenXml.Spreadsheet


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
        'Public Property Row As DataGridViewRow

        Public Sub conectarReporteComprobanteEgreso()
            Try

                numeroRegistro = objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64))

                'If Tipo = 0 Then
                '    crComprobanteEgreso.SetDataSource(objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), numeroRegistro))
                'Else
                '    crComprobanteEgresoHorizontal.SetDataSource(objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), numeroRegistro))
                'End If

                'crComprobanteEgreso.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                'crvComprovanteEgresoBancos.ReportSource = crComprobanteEgreso
                'crvComprovanteEgresoBancos.Zoom(75)
                'crvComprovanteEgresoBancos.Refresh()

                Dim dt = objetoComprobanteEgresoBancos.BuscarComprobantesEgresoBancoXIdComprobanteReporte(_tipoCon, CInt(lblIdComprobanteEgreso.Text))

                Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ComprobanteEgresoBanco.pdf")
                PdfViewer2.Document?.Dispose()
                PdfViewer2.Document = Nothing

                Dim pdfStream As New MemoryStream()
                Dim document As New iTextSharp.text.Document(PageSize.A5)
                Dim writer As PdfWriter = PdfWriter.GetInstance(document, pdfStream)
                writer.CloseStream = False
                document.Open()


                Dim rutaImagen As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
                logo.ScaleToFit(30, 30)

                Dim paginaAgregada As Boolean = False
                ' Agregar el logo al documento

                Dim ds As DataSet

                ds = objetoComprobanteEgresoBancos.BuscarComporbanteEgresoBancoxIdComprobanteNumeroRegistro2(_tipoCon, numeroRegistro)

                If ds.Tables(0).Rows.Count > 0 Then

                    Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
                    Dim fuente12 As New iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD)
                    Dim fuente10 As New iTextSharp.text.Font(baseFont, 10)
                    Dim fuente8 As New iTextSharp.text.Font(baseFont, 8)
                    Dim fuente8Bold As iTextSharp.text.Font = New iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD)


                    'document.NewPage()


                    'document.Add(logo)
                    'crea reporte
                    Dim headerTable As PdfPTable = New PdfPTable(3)
                    headerTable.TotalWidth = 400

                    Dim ColumnWidhts As Single() = New Single() {120, 200, 80}
                    headerTable.SetWidths(ColumnWidhts)



                    Dim idContent As New Phrase()
                    idContent.Add(New Chunk("Numero    ", fuente8Bold))
                    idContent.Add(New Chunk("   " & dt.Rows(0)(0).ToString(), fuente8))
                    idContent.Add(New Chunk(vbLf, fuente10))
                    idContent.Add(New Chunk(vbLf & "Fecha  ", fuente8Bold))
                    idContent.Add(New Chunk(dt.Rows(0)(1).ToString(), fuente8))



                    Dim idCell As New PdfPCell(idContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    headerTable.AddCell(idCell)

                    Dim tituloCell As New PdfPCell(New Phrase("COMPROBANTE DE EGRESO", fuente12)) With {
                            .HorizontalAlignment = Element.ALIGN_CENTER,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    headerTable.AddCell(tituloCell)

                    Dim logoCell As New PdfPCell(logo) With {
                            .HorizontalAlignment = Element.ALIGN_CENTER,
                            .VerticalAlignment = Element.ALIGN_CENTER,
                            .Border = PdfPCell.NO_BORDER
                        }
                    headerTable.AddCell(logoCell)
                    headerTable.WriteSelectedRows(0, -1, 20, 575, writer.DirectContent)

                    Dim rectTabla1 As PdfContentByte = writer.DirectContent
                    rectTabla1.RoundRectangle(10.0F, 540.0F, 390.0F, 40.0F, 10.0F)
                    rectTabla1.Stroke()


                    Dim tabla1 As PdfPTable = New PdfPTable(2)
                    tabla1.TotalWidth = 400

                    Dim ColumnWidhts1 As Single() = New Single() {120, 280}
                    tabla1.SetWidths(ColumnWidhts1)

                    Dim FacturContent As New Phrase()
                    FacturContent.Add(New Chunk("Factura: ", fuente8Bold))
                    FacturContent.Add(New Chunk(dt.Rows(0)(2).ToString(), fuente8))

                    Dim FacturCell As New PdfPCell(FacturContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla1.AddCell(FacturCell)


                    Dim PagadoAContent As New Phrase()
                    PagadoAContent.Add(New Chunk("Pagado a: ", fuente8Bold))
                    PagadoAContent.Add(New Chunk(dt.Rows(0)(3).ToString(), fuente8))

                    Dim PagadoACell As New PdfPCell(PagadoAContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla1.AddCell(PagadoACell)


                    Dim RucContent As New Phrase()
                    RucContent.Add(New Chunk("RUC/CI: ", fuente8Bold))
                    RucContent.Add(New Chunk(dt.Rows(0)(4).ToString(), fuente8))

                    Dim RucCell As New PdfPCell(RucContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla1.AddCell(RucCell)


                    Dim ConceptoContent As New Phrase()
                    ConceptoContent.Add(New Chunk("Concepto: ", fuente8Bold))
                    ConceptoContent.Add(New Chunk(dt.Rows(0)(5).ToString(), fuente8))

                    Dim ConceptoCell As New PdfPCell(ConceptoContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla1.AddCell(ConceptoCell)

                    Dim ActividadContent As New Phrase()
                    ActividadContent.Add(New Chunk("Actividad: ", fuente8Bold))
                    ActividadContent.Add(New Chunk(dt.Rows(0)(6).ToString(), fuente8))

                    Dim ActividadCell As New PdfPCell(ActividadContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla1.AddCell(ActividadCell)

                    Dim TipoPago As New Phrase()
                    TipoPago.Add(New Chunk("Tipo Pago: ", fuente8Bold))
                    TipoPago.Add(New Chunk(dt.Rows(0)(7).ToString(), fuente8))

                    Dim TipoPagoCell As New PdfPCell(TipoPago) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla1.AddCell(TipoPagoCell)

                    Dim tabla2 As PdfPTable = New PdfPTable(3)
                    tabla2.TotalWidth = 400
                    Dim ColumnWidhts2 As Single() = New Single() {120, 120, 160}
                    tabla2.SetWidths(ColumnWidhts2)

                    Dim BancoContent As New Phrase()
                    BancoContent.Add(New Chunk("Banco: ", fuente8Bold))
                    BancoContent.Add(New Chunk(dt.Rows(0)(8).ToString(), fuente8))

                    Dim BancoCell As New PdfPCell(BancoContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla2.AddCell(BancoCell)

                    Dim CuentaContent As New Phrase()
                    CuentaContent.Add(New Chunk("Cuenta: ", fuente8Bold))
                    CuentaContent.Add(New Chunk(dt.Rows(0)(9).ToString(), fuente8))

                    Dim CuentaCell As New PdfPCell(CuentaContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla2.AddCell(CuentaCell)

                    Dim ChequeContent As New Phrase()
                    ChequeContent.Add(New Chunk("Cheque: ", fuente8Bold))
                    ChequeContent.Add(New Chunk(dt.Rows(0)(10).ToString(), fuente8))

                    Dim ChequeCell As New PdfPCell(ChequeContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
                    tabla2.AddCell(ChequeCell)

                    Dim tabla2cell As PdfPCell = New PdfPCell(tabla2) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER,
                            .Colspan = 2
                        }
                    tabla1.AddCell(tabla2cell)



                    Dim EspacioVacío1 As New Phrase()
                    EspacioVacío1.Add(New Chunk(" ", fuente8))

                    Dim EspacioVacíoCell1 As New PdfPCell(EspacioVacío1) With {
                .HorizontalAlignment = Element.ALIGN_LEFT,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER,
                .Colspan = 2
            }
                    tabla1.AddCell(EspacioVacíoCell1)

                    ' Crear la segunda fila vacía
                    Dim EspacioVacío2 As New Phrase()
                    EspacioVacío2.Add(New Chunk(" ", fuente8))

                    Dim EspacioVacíoCell2 As New PdfPCell(EspacioVacío2) With {
                    .HorizontalAlignment = Element.ALIGN_LEFT,
                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                    .Border = PdfPCell.NO_BORDER,
                    .Colspan = 2
                }
                    tabla1.AddCell(EspacioVacíoCell2)

                    ' Crear la línea de separación (subrayado)
                    Dim LineaSeparacion As New Phrase()
                    LineaSeparacion.Add(New Chunk("___________________", fuente8))

                    Dim LineaCell As New PdfPCell(LineaSeparacion) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER,
                .Colspan = 2
            }
                    tabla1.AddCell(LineaCell)

                    ' Agregar el texto "Recibi conforme"
                    Dim RecibiConformeContent As New Phrase()
                    RecibiConformeContent.Add(New Chunk("Recibi conforme", fuente8Bold))

                    Dim RecibiConformeCell As New PdfPCell(RecibiConformeContent) With {
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Border = PdfPCell.NO_BORDER,
            .Colspan = 2
            }


                    tabla1.AddCell(RecibiConformeCell)


                    tabla1.WriteSelectedRows(0, -1, 20, 520, writer.DirectContent)

                    'insert 2 row empty

                    Dim table2 As New PdfPTable(4)
                    table2.TotalWidth = 400
                    Dim asientoTable As DataTable = ds.Tables("ASIENTOS_LIBRO_DIARIO")
                    Dim columnWidthsTable2() As Single = {80, 180, 70, 70}
                    table2.SetWidths(columnWidthsTable2)


                    Dim tituloTable2 As New PdfPCell(New Phrase("ASIENTOS DE DIARIO", fuente10)) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Colspan = 4,
                .Border = PdfPCell.NO_BORDER
            }
                    table2.AddCell(tituloTable2)

                    Dim emptyCell2 As New PdfPCell(New Phrase(" ", fuente8)) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Colspan = 4,
                .Border = PdfPCell.NO_BORDER
            }
                    tabla2.AddCell(emptyCell2)

                    Dim emptyCell3 As New PdfPCell(New Phrase(" ", fuente8)) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Colspan = 4,  ' Ocupa las 4 columnas
                .Border = PdfPCell.NO_BORDER
            }
                    table2.AddCell(emptyCell3)

                    table2.AddCell(New Phrase("Codigo", fuente8Bold))
                    table2.AddCell(New Phrase("Detalle", fuente8Bold))
                    table2.AddCell(New Phrase("Debe", fuente8Bold))
                    table2.AddCell(New Phrase("Haber", fuente8Bold))


                    Dim totalDebe As Decimal = 0
                    Dim totalHaber As Decimal = 0

                    For Each rowTable As DataRow In asientoTable.Rows
                        table2.AddCell(New Phrase(rowTable.Item("CODIGO_CUENTA_ASIENTO").ToString(), fuente8))
                        table2.AddCell(New Phrase(rowTable.Item("NOMBRE_CUENTA_ASIENTO").ToString(), fuente8))
                        table2.AddCell(New Phrase(rowTable.Item("VALOR_DEBE_ASIENTO").ToString(), fuente8))
                        table2.AddCell(New Phrase(rowTable.Item("VALOR_HABER_ASIENTO").ToString(), fuente8))

                        totalDebe += rowTable.Item("VALOR_DEBE_ASIENTO")
                        totalHaber += rowTable.Item("VALOR_HABER_ASIENTO")

                    Next

                    table2.WriteSelectedRows(0, -1, 10, 350, writer.DirectContent)

                    Dim table3 As New PdfPTable(2)
                    Dim columnWidthsTotal() As Single = {70, 70}
                    table3.TotalWidth = 140
                    Dim table2Height As Single = table2.TotalHeight
                    table3.SetWidths(columnWidthsTotal)

                    table3.AddCell(New Phrase(totalDebe.ToString("#,##0.00"), fuente8Bold))
                    table3.AddCell(New Phrase(totalHaber.ToString("#,##0.00"), fuente8Bold))
                    Dim baseY As Single = 350 - table2Height

                    table3.WriteSelectedRows(0, -1, 270, baseY, writer.DirectContent)

                    Dim table4 As New PdfPTable(3)
                    Dim columnWidthsTotal2() As Single = {120, 120, 120}
                    table4.TotalWidth = 360
                    table4.SetWidths(columnWidthsTotal2)

                    Dim LineaSeparacion1 As New Phrase()
                    LineaSeparacion1.Add(New Chunk("___________________", fuente8))

                    Dim LineaCell1 As New PdfPCell(LineaSeparacion1) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
                    table4.AddCell(LineaCell1)

                    Dim LineaSeparacion2 As New Phrase()
                    LineaSeparacion2.Add(New Chunk("___________________", fuente8))

                    Dim LineaCell2 As New PdfPCell(LineaSeparacion2) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
                    table4.AddCell(LineaCell2)

                    Dim LineaSeparacion3 As New Phrase()
                    LineaSeparacion3.Add(New Chunk("___________________", fuente8))

                    Dim LineaCell3 As New PdfPCell(LineaSeparacion3) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
                    table4.AddCell(LineaCell3)

                    Dim Contadora As New Phrase()
                    Contadora.Add(New Chunk("Contadora", fuente8Bold))

                    Dim ContadoraCell As New PdfPCell(Contadora) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
                    table4.AddCell(ContadoraCell)

                    Dim Gerente As New Phrase()
                    Gerente.Add(New Chunk("Gerente Admin - Finan", fuente8Bold))

                    Dim GerenteCell As New PdfPCell(Gerente) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
                    table4.AddCell(GerenteCell)

                    Dim GerenteGeneral As New Phrase()
                    GerenteGeneral.Add(New Chunk("Gerente General", fuente8Bold))

                    Dim GerenteGeneralCell As New PdfPCell(GerenteGeneral) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }

                    table4.AddCell(GerenteGeneralCell)

                    table4.WriteSelectedRows(0, -1, 20, 150, writer.DirectContent)


                    document.Close()
                    writer.Close()

                    pdfStream.Seek(0, SeekOrigin.Begin)
                    PdfViewer2.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
                    PdfViewer2.ZoomMode = 1

                End If


            Catch ex As Exception
                KryptonMessageBox.Show(ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                'Console.WriteLine(ex.Message)
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
            Try
                crChequeEmitido.SetDataSource(objetoChequeEmitido.SeleccionarChequeEmitidoXIdComprobanteEgreso(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64)))
                crvChequeEmitido.ReportSource = crChequeEmitido
                crvChequeEmitido.Zoom(75)
                crvChequeEmitido.Refresh()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try


            'Try
            '    'If lblIdComprobanteEgreso.Text = "000" Then Return

            '    If lblIdComprobanteEgreso.Text <> "" Then
            '        Dim ds As DataSet = objetoChequeEmitido.SeleccionarChequeEmitidoXIdComprobante(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64))

            '        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            '            Dim row As DataRow = ds.Tables(0).Rows(0)
            '            Dim nombre As String = row("Nombre").ToString()
            '            Dim valor As Decimal = Convert.ToDecimal(row("Valor"))
            '            Dim ciudad As String = row("Ciudad").ToString()
            '            Dim fecha As DateTime = Convert.ToDateTime(row("Fecha"))
            '            Dim Letras As String = Convert.ToString(valor) + " dólares"

            '            Dim pdfStream As New MemoryStream()
            '            Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ComprobanteCompraCheque.pdf")
            '            PdfViewer1.Document?.Dispose()
            '            PdfViewer1.Document = Nothing

            '            ' Configurar el documento con las medidas del cheque (15.5cm ancho × 7.5cm alto)
            '            Dim chequeWidth As Single = Utilities.MillimetersToPoints(155) ' 15.5 cm
            '            Dim chequeHeight As Single = Utilities.MillimetersToPoints(75) ' 7.5 cm
            '            Dim pageSize As New Rectangle(chequeWidth, chequeHeight)

            '            Dim document As New iTextSharp.text.Document(pageSize, 0, 0, 0, 0) ' Márgenes de 20 puntos
            '            Dim writer As PdfWriter = PdfWriter.GetInstance(document, pdfStream)
            '            writer.CloseStream = False
            '            document.Open()

            '            ' Configurar fuentes
            '            Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
            '            Dim fuente12Bold As New Font(baseFont, 12, Font.Bold)
            '            Dim fuente10Bold As New Font(baseFont, 10, Font.Bold)
            '            Dim fuente10 As New Font(baseFont, 10)
            '            Dim fuente8 As New Font(baseFont, 8)
            '            Dim fuente8Bold As New Font(baseFont, 8, Font.Bold)

            '            ' Obtener el valor en letras (necesitarías implementar esta función)
            '            Dim valorEnLetras As String = _objValidaciones.Letras(Letras)

            '            ' Convertir las coordenadas cm a puntos (1 cm = 28.35 puntos)
            '            Dim cmToPoints As Single = 28.35F

            '            ' 1. Nombre del beneficiario - Posición: X=2cm, Y=2.5cm
            '            Dim nombreX As Single = 2 * cmToPoints
            '            Dim nombreY As Single = chequeHeight - (2.3 * cmToPoints) ' Y se mide desde arriba
            '            Dim ctNombre As New ColumnText(writer.DirectContent)
            '            ctNombre.SetSimpleColumn(nombreX, nombreY, nombreX + 200, nombreY + 20)
            '            ctNombre.AddElement(New Paragraph(nombre, fuente8Bold))
            '            ctNombre.Go()

            '            ' 2. Valor numérico - Posición: X=12.5cm, Y=2.5cm
            '            Dim valorX As Single = 12.5 * cmToPoints
            '            Dim valorY As Single = chequeHeight - (2.3 * cmToPoints)
            '            Dim ctValor As New ColumnText(writer.DirectContent)
            '            ctValor.SetSimpleColumn(valorX, valorY, valorX + 100, valorY + 20)
            '            ctValor.AddElement(New Paragraph(String.Format("** {0:N2} **", valor), fuente10Bold))
            '            ctValor.Go()

            '            ' 3. Valor en letras - Posición: Centrado, Y=3cm
            '            Dim letrasY As Single = chequeHeight - (3 * cmToPoints)
            '            Dim letrasX As Single = 2 * cmToPoints
            '            Dim ctLetras As New ColumnText(writer.DirectContent)
            '            ctLetras.SetSimpleColumn(letrasX, letrasY, chequeWidth, letrasY + 20)
            '            ctLetras.Alignment = Element.ALIGN_CENTER
            '            ctLetras.AddElement(New Paragraph(valorEnLetras, fuente8))
            '            ctLetras.Go()

            '            ' 4. Ciudad y fecha - Posición: X=2cm, Y=4.3cm
            '            Dim ciudadX As Single = 2 * cmToPoints
            '            Dim ciudadY As Single = chequeHeight - (4.3 * cmToPoints)
            '            Dim ctCiudad As New ColumnText(writer.DirectContent)
            '            ctCiudad.SetSimpleColumn(ciudadX, ciudadY, ciudadX + 200, ciudadY + 20)
            '            ctCiudad.AddElement(New Paragraph($"{ciudad}, {fecha:yyyy-MM-dd}", fuente8))
            '            ctCiudad.Go()

            '            ' Cerrar documento
            '            document.Close()

            '            ' Mostrar el PDF en el visor
            '            pdfStream.Seek(0, SeekOrigin.Begin)
            '            PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
            '            PdfViewer1.ZoomMode = 1

            '            ' Opcional: Guardar en archivo temporal
            '            File.WriteAllBytes(ruta, pdfStream.ToArray())
            '        End If

            '    End If
            'Catch ex As Exception
            '    KryptonMessageBox.Show("Error al generar el comprobante de compra: " + ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            'End Try


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