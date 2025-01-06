Imports System.IO
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.ENUMS
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteComprobanteCompra
        Private _tipoCon As TipoConexion

        ReadOnly _objetoNumeroRegistroAsientoCompCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
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
        Public _porcentaje As String
        Public _tipoComprobante As String
        Public _proveedorCompra As String
        Public _fechaEmision As String
        Public _numeroComprobante As String


        Dim objetoComprobanteCompra As New ClassComprobantesCompra
        Dim objetoNumeroRegistroComprobanteCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        Dim crComprobanteCompra As New CrComprobanteCompra

        Dim numeroRegistro As Int64 = 0

        Public Sub conectarReporteComprobanteCompra()

            numeroRegistro = objetoNumeroRegistroComprobanteCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)

            Dim iva5 As DataTable = objetoComprobanteCompra.IvaComprobanteTabla(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))

            Dim subtotal5Value As String = "0"
            Dim iva5Value As String = "0"
            If iva5.Rows.Count > 0 Then

                subtotal5Value = If(iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA") IsNot DBNull.Value, iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA").ToString(), "0")
                iva5Value = If(iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA") IsNot DBNull.Value, iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA").ToString(), "0")
            End If

            crComprobanteCompra.SetDataSource(objetoComprobanteCompra.BuscarReporteComprobanteCompraXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64), numeroRegistro))
            crComprobanteCompra.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crComprobanteCompra.SetParameterValue("porcentaje", _porcentaje)
            crComprobanteCompra.SetParameterValue("subtotal5", subtotal5Value)
            crComprobanteCompra.SetParameterValue("iva5", iva5Value)
            crvComprobanteCompra.ReportSource = crComprobanteCompra
            crvComprobanteCompra.Zoom(75)
            crvComprobanteCompra.Refresh()
        End Sub

        Private Sub FormReporteComprobanteCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            conectarReporteComprobanteCompra()
            nuevoReporte()
        End Sub

        Private Sub nuevoReporte()
            Dim numeroRegistro = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
            Dim ds As DataSet = _objetoComprobantesCompra.BuscarReporteComprobanteCompraXIdComprobanteNumeroRegistro2(_tipoCon, Convert.ToInt32(lblIdComprobanteCompra.Text), numeroRegistro)

            Dim iva5 As DataTable = _objetoComprobantesCompra.IvaComprobanteTabla(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))

            Dim subtotal5Value As Decimal = 0.0
            Dim iva5Value As Decimal = 0.0
            If iva5.Rows.Count > 0 Then

                subtotal5Value = If(iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA") IsNot DBNull.Value, Convert.ToDecimal(iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA")).ToString("#,##0.00"), "0,00")
                iva5Value = If(iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA") IsNot DBNull.Value, Convert.ToDecimal(iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA")).ToString("#,##0.00"), "0,00")
            End If

            Dim pdfStream As New MemoryStream()

            Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ComprobanteCompra.pdf")
            PdfViewer1.Document?.Dispose()
            PdfViewer1.Document = Nothing

            'Using fs As New FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim document As New iTextSharp.text.Document(PageSize.A5)
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, pdfStream)
            writer.CloseStream = False
            document.Open()

            Dim baseFont As BaseFont = baseFont.CreateFont(baseFont.HELVETICA, baseFont.CP1252, baseFont.EMBEDDED)
            Dim fuente12 As iTextSharp.text.Font = New Font(baseFont, 12, iTextSharp.text.Font.BOLD)
            Dim fuente10Bold As iTextSharp.text.Font = New Font(baseFont, 10, iTextSharp.text.Font.BOLD)
            Dim fuente10 As iTextSharp.text.Font = New Font(baseFont, 10)
            Dim fuente8 As iTextSharp.text.Font = New Font(baseFont, 8)
            Dim fuente8Bold As iTextSharp.text.Font = New Font(baseFont, 8, iTextSharp.text.Font.BOLD)

            Dim rutaImagen As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
            Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
            logo.ScaleToFit(30, 30)



            Dim headerTable As PdfPTable = New PdfPTable(3)
            headerTable.TotalWidth = 400

            Dim ColumnWidhts As Single() = New Single() {120, 200, 80}
            headerTable.SetWidths(ColumnWidhts)



            Dim idContent As New Phrase()
            idContent.Add(New Chunk("Id    ", fuente8Bold))
            idContent.Add(New Chunk("   " & lblIdComprobanteCompra.Text, fuente8))
            idContent.Add(New Chunk(vbLf, fuente10))
            idContent.Add(New Chunk(vbLf & "Tipo  ", fuente8Bold))
            idContent.Add(New Chunk(_tipoComprobante, fuente8))



            Dim idCell As New PdfPCell(idContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
            headerTable.AddCell(idCell)

            Dim tituloCell As New PdfPCell(New Phrase("COMPROBANTE DE COMPRA", fuente12)) With {
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
            rectTabla1.RoundRectangle(10.0F, 530.0F, 390.0F, 50.0F, 10.0F)
            rectTabla1.Stroke()



            Dim tabla1 As PdfPTable = New PdfPTable(2)
            tabla1.TotalWidth = 380

            Dim ColumnWidhts1 As Single() = New Single() {200, 180}
            tabla1.SetWidths(ColumnWidhts1)

            Dim proveedorContent As New Phrase()
            proveedorContent.Add(New Chunk("Proveedor   ", fuente8Bold))
            proveedorContent.Add(New Chunk(_proveedorCompra, fuente8))

            Dim proveedorCell As New PdfPCell(proveedorContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
            tabla1.AddCell(proveedorCell)

            Dim fechaContent As New Phrase()
            fechaContent.Add(New Chunk("Fecha   ", fuente8Bold))
            fechaContent.Add(New Chunk(_fechaEmision, fuente8))

            Dim fechaCell As New PdfPCell(fechaContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
            tabla1.AddCell(fechaCell)

            Dim emptyCell As New PdfPCell(New Phrase("")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
            Dim emptyCell2 As New PdfPCell(New Phrase("")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                 }


            Dim separatorCell As New PdfPCell() With {
                                    .Colspan = 2,
                                    .BorderWidthTop = 0.5F,
                                    .BorderWidthLeft = 0,
                                    .BorderWidthRight = 0,
                                    .BorderWidthBottom = 0
                                }



            'Comprobante Compra

            Dim NroComprobanteContent As New Phrase()
            NroComprobanteContent.Add(New Chunk("Nro. Comprobante   ", fuente8Bold))
            NroComprobanteContent.Add(New Chunk(_numeroComprobante, fuente8))

            Dim NroComprobanteCell As New PdfPCell(NroComprobanteContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla1.AddCell(NroComprobanteCell)

            Dim comproTable As DataTable = ds.Tables("COMPROBANTES_COMPRA")
            Dim DocModComprobanteContent As New Phrase()
            DocModComprobanteContent.Add(New Chunk("Doc Modf   ", fuente8Bold))
            DocModComprobanteContent.Add(New Chunk(comproTable.Rows(0)("DOC_MOD_COMPROBANTE_COMPRA").ToString(), fuente8))

            Dim DocNroComprobanteCell As New PdfPCell(DocModComprobanteContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla1.AddCell(DocNroComprobanteCell)
            tabla1.AddCell(emptyCell2)
            'tabla1.AddCell(separatorCell)


            Dim numAutorizacionContent As New Phrase()
            numAutorizacionContent.Add(New Chunk("Nro. Autorización SRI ", fuente8Bold))
            numAutorizacionContent.Add(New Chunk(comproTable.Rows(0)("NUM_AUTO_SRI_COMPROBANTE_COMPRA").ToString(), fuente8))

            Dim numAutorizacionCell As New PdfPCell(numAutorizacionContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                }

            tabla1.AddCell(numAutorizacionCell)

            Dim fechaAutorizacion As New Phrase()
            fechaAutorizacion.Add(New Chunk("Fecha Autorización SRI ", fuente8Bold))
            fechaAutorizacion.Add(New Chunk(comproTable.Rows(0)("FECHA_AUTO_SRI_COMPROBANTE_COMPRA").ToString(), fuente8))

            Dim fechaAutorizacionCell As New PdfPCell(fechaAutorizacion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                }

            tabla1.AddCell(fechaAutorizacionCell)
            tabla1.AddCell(emptyCell2)

            Dim ObservacionContent As New Phrase()
            ObservacionContent.Add(New Chunk("Observación   ", fuente8Bold))
            ObservacionContent.Add(New Chunk(comproTable.Rows(0)("OBSERVACION_COMPROBANTE_COMPRA").ToString(), fuente8))

            Dim ObservacionCell As New PdfPCell(ObservacionContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla1.AddCell(ObservacionCell)

            Dim table2 As PdfPTable = New PdfPTable(2)
            table2.TotalWidth = 180
            table2.HorizontalAlignment = Element.ALIGN_CENTER
            'Dim columnWidthsTable5() As Single = {150, 50}

            Dim subtotal12 As Decimal = Convert.ToDecimal(comproTable.Rows(0)("SUBTOTAL_12_COMPROBANTE_COMPRA"))
            Dim formatSubtotal12 As String = subtotal12.ToString("#,##0.00")
            Dim cell1Row1 As New PdfPCell(New Phrase("Subtotal " & _porcentaje & "%", fuente8Bold))
            Dim cell2Row1 As New PdfPCell(New Phrase(formatSubtotal12, fuente8))
            cell2Row1.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row1)
            table2.AddCell(cell2Row1)

            Dim cell1Row2 As New PdfPCell(New Phrase("Subtotal 5%", fuente8Bold))
            Dim cell2Row2 As New PdfPCell(New Phrase(subtotal5Value, fuente8))
            cell2Row2.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row2)
            table2.AddCell(cell2Row2)


            Dim subtotal0 As Decimal = Convert.ToDecimal(comproTable.Rows(0)("SUBTOTAL_0_COMPROBANTE_COMPRA"))
            Dim formatSubtotal0 As String = subtotal0.ToString("#,##0.00")
            Dim cell1Row3 As New PdfPCell(New Phrase("Subtotal 0%", fuente8Bold))
            Dim cell2Row3 As New PdfPCell(New Phrase(formatSubtotal0, fuente8))
            cell2Row3.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row3)
            table2.AddCell(cell2Row3)

            Dim cell1Row4 As New PdfPCell(New Phrase("Descuento", fuente8Bold))
            Dim cell2Row4 As New PdfPCell(New Phrase(comproTable.Rows(0)("DESCUENTO_COMPROBANTE_COMPRA").ToString(), fuente8))
            cell2Row4.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row4)
            table2.AddCell(cell2Row4)

            Dim subtotal As Decimal = Convert.ToDecimal(comproTable.Rows(0)("SUBTOTAL_COMPROBANTE_COMPRA"))
            Dim formatSubtotal As String = subtotal.ToString("#,##0.00")
            Dim cell1Row5 As New PdfPCell(New Phrase("Subtotal", fuente8Bold))
            Dim cell2Row5 As New PdfPCell(New Phrase(formatSubtotal, fuente8))
            cell2Row5.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row5)
            table2.AddCell(cell2Row5)

            Dim cell1Row6 As New PdfPCell(New Phrase("IVA 5%", fuente8Bold))
            Dim cell2Row6 As New PdfPCell(New Phrase(iva5Value, fuente8))
            cell2Row6.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row6)
            table2.AddCell(cell2Row6)


            Dim cell1Row7 As New PdfPCell(New Phrase("IVA " & _porcentaje & "%", fuente8Bold))
            Dim cell2Row7 As New PdfPCell(New Phrase(comproTable.Rows(0)("IVA_COMPROBANTE_COMPRA").ToString(), fuente8))
            cell2Row7.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row7)
            table2.AddCell(cell2Row7)

            Dim total As Decimal = Convert.ToDecimal(comproTable.Rows(0)("TOTAL_COMPROBANTE_COMPRA"))
            Dim formatTotal As String = total.ToString("#,##0.00")
            Dim cell1Row8 As New PdfPCell(New Phrase("TOTAL ", fuente8Bold))
            Dim cell2Row8 As New PdfPCell(New Phrase(formatTotal, fuente8Bold))
            cell2Row8.HorizontalAlignment = Element.ALIGN_RIGHT
            table2.AddCell(cell1Row8)
            table2.AddCell(cell2Row8)

            Dim nestedTableCell As New PdfPCell(table2) With {
                                        .Border = PdfPCell.NO_BORDER,
                                        .HorizontalAlignment = Element.ALIGN_RIGHT,
                                        .VerticalAlignment = Element.ALIGN_TOP}
            tabla1.AddCell(nestedTableCell)
            tabla1.WriteSelectedRows(0, -1, 10, 520, writer.DirectContent)


            Dim tabla3 As PdfPTable = New PdfPTable(2)
            tabla3.TotalWidth = 400

            Dim ColumnWidhts3 As Single() = New Single() {200, 200}
            tabla3.SetWidths(ColumnWidhts3)

            Dim TituloTabla3 As New PdfPCell(New Phrase("COMPROBANTE DE RETENCIÓN", fuente10Bold)) With {
                                    .HorizontalAlignment = Element.ALIGN_CENTER,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.BOTTOM_BORDER,
                                    .Colspan = 2
                                }

            tabla3.AddCell(TituloTabla3)

            Dim emptyCellTable3 As New PdfPCell(New Phrase(" ")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                 }

            tabla3.AddCell(emptyCellTable3)
            Dim retencionTable As DataTable = ds.Tables("COMPROBANTE_RETENCION_COMPRA")


            Dim IdRetencion As New Phrase()
            IdRetencion.Add(New Chunk("ID   ", fuente8Bold))
            IdRetencion.Add(New Chunk(retencionTable.Rows(0)("ID_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))



            Dim IdRetencionCell As New PdfPCell(IdRetencion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                                                    }

            tabla3.AddCell(IdRetencionCell)

            Dim TipoComprobante As New Phrase()
            TipoComprobante.Add(New Chunk("Tipo Comprobante   ", fuente8Bold))
            TipoComprobante.Add(New Chunk(retencionTable.Rows(0)("TIPO_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

            Dim TipoComprobanteCell As New PdfPCell(TipoComprobante) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla3.AddCell(TipoComprobanteCell)

            Dim NroComprobanteRetencion As New Phrase()
            NroComprobanteRetencion.Add(New Chunk("Nro. Retencion   ", fuente8Bold))
            NroComprobanteRetencion.Add(New Chunk(retencionTable.Rows(0)("NUMERO_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

            Dim NroComprobanteRetencionCell As New PdfPCell(NroComprobanteRetencion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla3.AddCell(NroComprobanteRetencionCell)

            Dim FechaEmision As New Phrase()
            FechaEmision.Add(New Chunk("Fecha Emisión   ", fuente8Bold))
            FechaEmision.Add(New Chunk(retencionTable.Rows(0)("FECHA_EMISION_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

            Dim FechaEmisionCell As New PdfPCell(FechaEmision) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla3.AddCell(FechaEmisionCell)

            Dim NroAutorizacion As New Phrase()
            NroAutorizacion.Add(New Chunk("Nro. Autorización SRI   ", fuente8Bold))
            NroAutorizacion.Add(New Chunk(retencionTable.Rows(0)("NUM_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

            Dim NroAutorizacionCell As New PdfPCell(NroAutorizacion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla3.AddCell(NroAutorizacionCell)

            Dim FechaAutorizacionSRI As New Phrase()
            FechaAutorizacionSRI.Add(New Chunk("Fecha Autorización SRI   ", fuente8Bold))
            FechaAutorizacionSRI.Add(New Chunk(retencionTable.Rows(0)("FECHA_AUTO_SRI_COMPROBANTE_RETENCION_COMPA").ToString(), fuente8))

            Dim FechaAutorizacionSRICell As New PdfPCell(FechaAutorizacionSRI) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            tabla3.AddCell(FechaAutorizacionSRICell)

            tabla3.WriteSelectedRows(0, -1, 10, 360, writer.DirectContent)

            Dim table4 As New PdfPTable(6)
            table4.TotalWidth = 380

            Dim detalleRetencionTable As DataTable = ds.Tables("DETALLE_COMPROBANTE_RETENCION_COMPRA")
            Dim columnWidthsTable4() As Single = {63, 63, 63, 65, 63, 63}
            table4.SetWidths(columnWidthsTable4)

            ' First row (header)
            table4.AddCell(New Phrase("Ejercicio Fiscal", fuente8Bold))
            table4.AddCell(New Phrase("Codigo", fuente8Bold))
            table4.AddCell(New Phrase("Base Imponible", fuente8Bold))
            table4.AddCell(New Phrase("Impuesto", fuente8Bold))
            table4.AddCell(New Phrase("Porcentaje", fuente8Bold))
            table4.AddCell(New Phrase("Valor", fuente8Bold))

            Dim totalRetencion As Decimal = 0
            For Each row In detalleRetencionTable.Rows
                table4.AddCell(New Phrase(row("EJ_FISCAL_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                table4.AddCell(New Phrase(row("CODIGO_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                Dim baseimponible As Decimal = Convert.ToDecimal(row("BASE_IMPONIBLE_DETALLE_COMPROBANTE_RETENCION_COMPRA"))
                table4.AddCell(New Phrase(baseimponible.ToString("#,##0.00"), fuente8))
                table4.AddCell(New Phrase(row("IMPUESTO_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                table4.AddCell(New Phrase(row("PORCENTAJE_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                Dim valor As Decimal = Convert.ToDecimal(row("VALOR_DETALLE_COMPROBANTE_RETENCION_COMPRA"))
                table4.AddCell(New Phrase(valor.ToString("#,##0.00"), fuente8))
                totalRetencion += valor
            Next

            table4.WriteSelectedRows(0, -1, 10, 280, writer.DirectContent)

            Dim totalRetencionTable As New PdfPTable(2)
            totalRetencionTable.TotalWidth = 140
            Dim columnWidthsTotalRentencion() As Single = {70, 70}

            totalRetencionTable.SetWidths(columnWidthsTotalRentencion)

            Dim TotalRetencionTi As New PdfPCell(New Phrase("Total Retención", fuente8Bold)) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                                                    }

            totalRetencionTable.AddCell(TotalRetencionTi)
            Dim totalRetencionCell As New PdfPCell(New Phrase(totalRetencion.ToString("#,##0.00"), fuente8Bold)) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
            totalRetencionTable.AddCell(totalRetencionCell)
            totalRetencionTable.WriteSelectedRows(0, -1, 260, 240, writer.DirectContent)


            Dim asientoTable As DataTable = ds.Tables("ASIENTOS_LIBRO_DIARIO")
            Dim table5 As New PdfPTable(4)
            table5.TotalWidth = 380

            Dim columnWidthsTable5() As Single = {60, 120, 50, 50}
            table5.SetWidths(columnWidthsTable5)

            Dim TituloTabla5 As New PdfPCell(New Phrase("ASIENTO DE DIARIO", fuente10Bold)) With {
                                    .HorizontalAlignment = Element.ALIGN_CENTER,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.BOTTOM_BORDER,
                                    .Colspan = 4
                                }
            table5.AddCell(TituloTabla5)

            Dim emptyCell4Table5 As New PdfPCell(New Phrase(" ")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 4,
                                    .PaddingTop = 10
                                 }

            table5.AddCell(emptyCell4Table5)

            table5.AddCell(New Phrase("Codigo", fuente8Bold))
            table5.AddCell(New Phrase("Cuenta", fuente8Bold))
            table5.AddCell(New Phrase("Debe", fuente8Bold))
            table5.AddCell(New Phrase("Haber", fuente8Bold))

            Dim valorDebe As Decimal = 0
            Dim valorHaber As Decimal = 0
            For Each row As DataRow In asientoTable.Rows
                table5.AddCell(New Phrase(row("CODIGO_CUENTA_ASIENTO").ToString(), fuente8))
                table5.AddCell(New Phrase(row("NOMBRE_CUENTA_ASIENTO").ToString(), fuente8))
                Dim valorDebeAsiento As Decimal = Convert.ToDecimal(row("VALOR_DEBE_ASIENTO"))
                table5.AddCell(New Phrase(valorDebeAsiento.ToString("#,##0.00"), fuente8))
                Dim valorHaberAsiento As Decimal = Convert.ToDecimal(row("VALOR_HABER_ASIENTO"))
                table5.AddCell(New Phrase(valorHaberAsiento.ToString("#,##0.00"), fuente8))
                valorDebe += Convert.ToDecimal(row("VALOR_DEBE_ASIENTO"))
                valorHaber += Convert.ToDecimal(row("VALOR_HABER_ASIENTO"))
            Next

            table5.WriteSelectedRows(0, -1, 10, 220, writer.DirectContent)

            Dim table6 As New PdfPTable(2)
            Dim columnWidthsTotal() As Single = {67, 67}
            table6.TotalWidth = 135
            Dim table5Height As Single = table5.TotalHeight
            table6.SetWidths(columnWidthsTotal)

            table6.AddCell(New Phrase(valorDebe.ToString("#,##0.00"), fuente8Bold))
            table6.AddCell(New Phrase(valorHaber.ToString("#,##0.00"), fuente8Bold))
            Dim baseY As Single = 220 - table5Height

            table6.WriteSelectedRows(0, -1, 255, baseY, writer.DirectContent)



            'add the actual date in the document footer
            Dim footerTable As PdfPTable = New PdfPTable(1)
            footerTable.TotalWidth = 400
            Dim footerCell As New PdfPCell(New Phrase("Fecha de Reporte: " & DateAndTime.DateString() & " " & DateAndTime.TimeString(), fuente8)) With {
                                    .HorizontalAlignment = Element.ALIGN_RIGHT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

            footerTable.AddCell(footerCell)
            footerTable.WriteSelectedRows(0, -1, 10, 50, writer.DirectContent)

            document.Close()
            writer.Close()

            pdfStream.Seek(0, SeekOrigin.Begin)
            PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
            PdfViewer1.ZoomMode = 1

        End Sub
    End Class
End Namespace