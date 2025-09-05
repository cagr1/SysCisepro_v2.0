Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS
Imports Krypton.Toolkit
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports System.IO

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarOrdenCompra
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

        ReadOnly _objetoOrdenCompra As New ClassOrdenCompra
        ReadOnly _objetoDetalleOrdenCompra As New ClassDetalleOrdenCompra
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objValidaciones As New ClassConversion
        Public Sub CargarOrdenCompra()
            Try
                dgvOrdenCompra.DataSource = _objetoOrdenCompra.SeleccionarRegistrosOrdenCompraAprobacion(_tipoCon)
                dgvOrdenCompra.Columns(0).HeaderText = "N°"
                dgvOrdenCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(1).HeaderText = "FECHA"
                dgvOrdenCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(2).HeaderText = "ID PROVEEDOR"
                dgvOrdenCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(3).HeaderText = "FORMA PAGO"
                dgvOrdenCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(4).HeaderText = "TIPO PAGO"
                dgvOrdenCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(5).HeaderText = "OBSERVACIONES"
                dgvOrdenCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(6).HeaderText = "SUBTOTAL 12"
                dgvOrdenCompra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(7).HeaderText = "SUBTOTAL 0"
                dgvOrdenCompra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(8).HeaderText = "DESCUENTO"
                dgvOrdenCompra.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(9).HeaderText = "IVA (12%)"
                dgvOrdenCompra.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(10).HeaderText = "TOTAL"
                dgvOrdenCompra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.AutoResizeColumns()
                dgvOrdenCompra.AutoResizeRows()
                dgvOrdenCompra.ReadOnly = True
                dgvOrdenCompra.EditMode = DataGridViewEditMode.EditProgrammatically 
            Catch ex As Exception
                'MsgBox("METODO CARGAR ORDEN DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar orden de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Public Sub CargarDetalleOrdenCompra()
            Try
                dgvDetalleOrdenCompra.DataSource = _objetoDetalleOrdenCompra.SeleccionarDetalleOrdenCompraXIdOrden(_tipoCon, CLng(txtIdOrdenCompra.Text))
                dgvDetalleOrdenCompra.AutoResizeColumns()
                dgvDetalleOrdenCompra.AutoResizeRows()
                dgvDetalleOrdenCompra.Columns(0).HeaderText = "ID"
                dgvDetalleOrdenCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(0).Width = 40
                dgvDetalleOrdenCompra.Columns(1).HeaderText = "ITEM"
                dgvDetalleOrdenCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(1).Width = 600
                dgvDetalleOrdenCompra.Columns(2).HeaderText = "UM"
                dgvDetalleOrdenCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(2).Width = 60
                dgvDetalleOrdenCompra.Columns(3).HeaderText = "CANT"
                dgvDetalleOrdenCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(3).Width = 60
                dgvDetalleOrdenCompra.Columns(4).HeaderText = "V. UNITARIO"
                dgvDetalleOrdenCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(4).Width = 60
                dgvDetalleOrdenCompra.Columns(5).HeaderText = "V. TOTAL"
                dgvDetalleOrdenCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(5).Width = 50
                dgvDetalleOrdenCompra.Columns(6).HeaderText = "EST"
                dgvDetalleOrdenCompra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(6).Width = 50
                dgvDetalleOrdenCompra.Columns(7).HeaderText = "ID-OC"
                dgvDetalleOrdenCompra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(7).Width = 50

                dgvDetalleOrdenCompra.Columns(8).Visible = False
                dgvDetalleOrdenCompra.Columns(9).Visible = False
                dgvDetalleOrdenCompra.Columns(10).Visible = False
                dgvDetalleOrdenCompra.Columns(11).Visible = False
                dgvDetalleOrdenCompra.Columns(12).Visible = False

                dgvDetalleOrdenCompra.ReadOnly = True
            Catch ex As Exception
                'MsgBox("METODO CARGAR DETALLE ORDEN COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar detalle orden compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub FormBuscarOrdenCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvDetalleOrdenCompra.Font = New System.Drawing.Font("Roboto", 8, FontStyle.Regular)
            dgvOrdenCompra.Font = New Drawing.Font("Roboto", 8, FontStyle.Regular)
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If txtIdOrdenCompra.Text = "..." Then Return

            Dim dt = _objetoOrdenCompra.SeleccionarRegistrosOrdenCompraXIdOrdenCompra(_tipoCon, CInt(txtIdOrdenCompra.Text))

            If dt.Rows.Count = 0 Then
                KryptonMessageBox.Show("No se encontraron registros", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If



            Dim pdfStream As New MemoryStream()

            Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "InformeDepreciaciones.pdf")
            PdfViewer1.Document?.Dispose()
            PdfViewer1.Document = Nothing

            'Using fs As New FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim document As New iTextSharp.text.Document(PageSize.A5)
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, pdfStream)
            writer.CloseStream = False
            document.Open()
            Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
            Dim fuente12 As iTextSharp.text.Font = New Font(baseFont, 12, iTextSharp.text.Font.BOLD)
            Dim fuente10Bold As iTextSharp.text.Font = New Font(baseFont, 10, iTextSharp.text.Font.BOLD)
            Dim fuente10 As iTextSharp.text.Font = New Font(baseFont, 10)
            Dim fuente8 As iTextSharp.text.Font = New Font(baseFont, 8)
            Dim fuente8Bold As iTextSharp.text.Font = New Font(baseFont, 8, iTextSharp.text.Font.BOLD)

            Dim rutaImagen As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
            Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
            logo.ScaleToFit(30, 30)

            Dim NombreEmpresa As String = ValidationForms.NombreCompany(_tipoCon)
            Dim Ciudad As String = "Machala - El Oro - Ecuador"
            Dim Direccion As String = "Avenida Alejandro Castro Benitez, El Bosque Sector 5"

            Dim letras = dt.Rows(0)(18).ToString()

            Dim valorEnLetras As String = _objValidaciones.Letras(Letras)

            ' ENCABEZADO
            ' ===============================
            ' ENCABEZADO (3 columnas)
            ' ===============================

            ' Creamos una tabla de 3 columnas
            Dim encabezado As New PdfPTable(3)
            encabezado.WidthPercentage = 110

            encabezado.TotalWidth = 420
            encabezado.SetWidths(New Single() {60, 240, 100}) ' proporción columnas


            ' ==== Celda 1: Logo ====
            Dim cellLogo As New PdfPCell(logo)
            cellLogo.HorizontalAlignment = Element.ALIGN_CENTER
            cellLogo.VerticalAlignment = Element.ALIGN_MIDDLE
            cellLogo.Border = Rectangle.NO_BORDER

            encabezado.AddCell(cellLogo)

            ' ==== Celda 2: Título ====
            Dim cellTitulo As New PdfPCell(New Phrase("ORDEN DE COMPRA", fuente12))

            cellTitulo.HorizontalAlignment = Element.ALIGN_CENTER
            cellTitulo.VerticalAlignment = Element.ALIGN_MIDDLE
            cellTitulo.Padding = 6
            cellTitulo.Border = Rectangle.NO_BORDER
            encabezado.AddCell(cellTitulo)

            ' ==== Celda 3: Datos en 4 líneas ====
            Dim fechaReporte As String = Convert.ToDateTime(dt.Rows(0)(1)).ToString("dd/MM/yyyy")

            Dim textoCabecera As String =
            "Código: RE 3.6.1-7" & vbCrLf &
            "Versión: 003" & vbCrLf &
            "Página: 1" & vbCrLf &
            "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")

            Dim cellInfo As New PdfPCell(New Phrase(textoCabecera, fuente8))

            cellInfo.HorizontalAlignment = Element.ALIGN_LEFT
            cellInfo.VerticalAlignment = Element.ALIGN_MIDDLE
            cellInfo.Padding = 5
            cellInfo.Border = Rectangle.NO_BORDER

            ' Importante: sin bordes internos → se deja texto en líneas
            encabezado.AddCell(cellInfo)
            encabezado.SpacingBefore = 10
            ' Agregar la tabla al documento
            document.Add(encabezado)

            'Recuadro 1
            Dim rectTabla1 As PdfContentByte = writer.DirectContent
            rectTabla1.RoundRectangle(10.0F, 515.0F, 390.0F, 50.0F, 10.0F)
            rectTabla1.Stroke()

            ' tabla 1 la cabecera

            Dim table1 As New PdfPTable(2)
            table1.TotalWidth = 400
            table1.LockedWidth = True
            table1.SetWidths(New Single() {100, 300})
            table1.SpacingBefore = 10

            ' ==== Celda 1 ====
            Dim parrafoCelda1 As New Paragraph()
            parrafoCelda1.Add(New Phrase("RUC: 0790013360001" & vbCrLf, fuente10Bold))
            parrafoCelda1.Add(New Phrase("No Orden: ", fuente10Bold))
            parrafoCelda1.Add(New Phrase(txtIdOrdenCompra.Text, fuente10))
            parrafoCelda1.Add(New Phrase(vbCrLf, fuente10))
            parrafoCelda1.Add(New Phrase("Fecha: ", fuente10Bold))
            parrafoCelda1.Add(New Phrase(fechaReporte, fuente10))


            Dim cell1 As New PdfPCell(parrafoCelda1)
            cell1.HorizontalAlignment = Element.ALIGN_LEFT
            cell1.VerticalAlignment = Element.ALIGN_TOP
            cell1.Border = Rectangle.NO_BORDER
            cell1.Padding = 2
            table1.AddCell(cell1)

            ' ==== Celda 2 ====
            Dim parrafoCelda2 As New Paragraph()
            parrafoCelda2.Alignment = Element.ALIGN_CENTER
            'parrafoCelda2.Add(New Phrase("Servicios en Seguridad Fisica y Electronica" & vbCrLf, fuente10))
            parrafoCelda2.Add(New Phrase("CISEPRO C LTDA" & vbCrLf, fuente12)) ' bold 12
            'empty line
            parrafoCelda2.Add(New Phrase(" " & vbCrLf, fuente10))
            parrafoCelda2.Add(New Phrase("Av. Alejandro Castro Benitez y El Bosque sector 5" & vbCrLf, fuente10))
            parrafoCelda2.Add(New Phrase("Email: email@cisepro.com.ec", fuente10))

            Dim cell2 As New PdfPCell(parrafoCelda2)
            cell2.HorizontalAlignment = Element.ALIGN_CENTER
            cell2.VerticalAlignment = Element.ALIGN_TOP
            cell2.Border = Rectangle.NO_BORDER
            cell2.Padding = 2
            table1.AddCell(cell2)
            table1.SpacingAfter = 20

            ' Tabla 2 Datos de Proveedor

            Dim table2 As New PdfPTable(3)
            table2.TotalWidth = 400
            table2.LockedWidth = True
            table2.SetWidths(New Single() {200, 100, 100})

            'Titulo tabla 2
            Dim parrafoTituloTabla2 As New Paragraph()
            parrafoTituloTabla2.Add(New Phrase("DATOS DEL PROVEEDOR", fuente10Bold))
            Dim cellTituloTabla2 As New PdfPCell(parrafoTituloTabla2)
            cellTituloTabla2.Colspan = 3
            cellTituloTabla2.HorizontalAlignment = Element.ALIGN_CENTER
            cellTituloTabla2.VerticalAlignment = Element.ALIGN_MIDDLE
            cellTituloTabla2.Border = Rectangle.NO_BORDER
            cellTituloTabla2.BackgroundColor = BaseColor.LIGHT_GRAY
            table2.AddCell(cellTituloTabla2)
            'espacio vacio
            Dim cellEspacioVacio As New PdfPCell(New Phrase(" ", fuente8))
            cellEspacioVacio.Border = Rectangle.NO_BORDER
            cellEspacioVacio.Colspan = 3
            table2.AddCell(cellEspacioVacio)

            'Fila 1
            Dim Celda1Tabla2 As New Paragraph()
            Celda1Tabla2.Add(New Phrase("Nombre: ", fuente8Bold))
            Celda1Tabla2.Add(New Phrase(txtNombreProveedor.Text, fuente8))
            Dim cellNombre As New PdfPCell(Celda1Tabla2)
            cellNombre.HorizontalAlignment = Element.ALIGN_LEFT
            cellNombre.Border = Rectangle.NO_BORDER
            table2.AddCell(cellNombre)

            Dim Celda2Tabla2 As New Paragraph()
            Celda2Tabla2.Add(New Phrase("RUC: ", fuente8Bold))
            Celda2Tabla2.Add(New Phrase(txtRucProveedor.Text, fuente8))
            Dim cellRuc As New PdfPCell(Celda2Tabla2)
            cellRuc.HorizontalAlignment = Element.ALIGN_LEFT
            cellRuc.Border = Rectangle.NO_BORDER
            table2.AddCell(cellRuc)

            Dim Celda3Tabla2 As New Paragraph()
            Celda3Tabla2.Add(New Phrase("Ciudad: ", fuente8Bold))
            Celda3Tabla2.Add(New Phrase(dt.Rows(0)(4).ToString, fuente8))
            Dim cellCiudad As New PdfPCell(Celda3Tabla2)
            cellCiudad.HorizontalAlignment = Element.ALIGN_LEFT
            cellCiudad.Border = Rectangle.NO_BORDER
            table2.AddCell(cellCiudad)

            'Fila 2
            Dim Celda4Tabla2 As New Paragraph()
            Celda4Tabla2.Add(New Phrase("Direccion: ", fuente8Bold))
            Celda4Tabla2.Add(New Phrase(dt.Rows(0)(7).ToString, fuente8))
            Dim cellDireccion As New PdfPCell(Celda4Tabla2)
            cellDireccion.HorizontalAlignment = Element.ALIGN_LEFT
            cellDireccion.Border = Rectangle.NO_BORDER
            table2.AddCell(cellDireccion)



            Dim Celda6Tabla2 As New Paragraph()
            Celda6Tabla2.Add(New Phrase("Email: ", fuente8Bold))
            Celda6Tabla2.Add(New Phrase(dt.Rows(0)(6).ToString, fuente8))
            Dim cellEmail As New PdfPCell(Celda6Tabla2)
            cellEmail.HorizontalAlignment = Element.ALIGN_LEFT
            cellEmail.Border = Rectangle.NO_BORDER
            cellEmail.Colspan = 2
            table2.AddCell(cellEmail)

            'Fila 3

            Dim Celda5Tabla2 As New Paragraph()
            Celda5Tabla2.Add(New Phrase("Telefono: ", fuente8Bold))
            Celda5Tabla2.Add(New Phrase(dt.Rows(0)(5).ToString, fuente8))
            Dim cellTelefono As New PdfPCell(Celda5Tabla2)
            cellTelefono.HorizontalAlignment = Element.ALIGN_LEFT
            cellTelefono.Border = Rectangle.NO_BORDER
            table2.AddCell(cellTelefono)

            Dim Celda7Tabla2 As New Paragraph()
            Celda7Tabla2.Add(New Phrase("Obli Contabilidad: ", fuente8Bold))
            Celda7Tabla2.Add(New Phrase(dt.Rows(0)(8).ToString, fuente8))
            Dim cellContacto As New PdfPCell(Celda7Tabla2)
            cellContacto.HorizontalAlignment = Element.ALIGN_LEFT
            cellContacto.Border = Rectangle.NO_BORDER
            table2.AddCell(cellContacto)

            Dim Celda8Tabla2 As New Paragraph()
            Celda8Tabla2.Add(New Phrase("Contribuyente E: ", fuente8Bold))
            Celda8Tabla2.Add(New Phrase(dt.Rows(0)(9).ToString, fuente8))
            Dim cellObliContabilidad As New PdfPCell(Celda8Tabla2)
            cellObliContabilidad.HorizontalAlignment = Element.ALIGN_LEFT
            cellObliContabilidad.Border = Rectangle.NO_BORDER
            table2.AddCell(cellObliContabilidad)


            table2.SpacingAfter = 10

            ' Table3 Detalles Orden Compra

            Dim table3 As New PdfPTable(4)
            table3.TotalWidth = 400
            table3.LockedWidth = True
            table3.SetWidths(New Single() {180, 60, 80, 80})


            Dim headers() As String = {"Item", "Cantidad", "Valor Unitario", "Valor Total"}
            For Each header As String In headers
                Dim headerCell As New PdfPCell(New Phrase(header, fuente8Bold)) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .BackgroundColor = BaseColor.LIGHT_GRAY
            }
                table3.AddCell(headerCell)
            Next

            'detalle
            For Each dr As DataRow In dt.Rows
                Dim cellItem As New PdfPCell(New Phrase(dr(10).ToString(), fuente8)) With {
                    .HorizontalAlignment = Element.ALIGN_LEFT
                }
                table3.AddCell(cellItem)


                Dim cellCantidad As New PdfPCell(New Phrase(dr(11).ToString(), fuente8)) With {
                    .HorizontalAlignment = Element.ALIGN_CENTER
                }
                table3.AddCell(cellCantidad)


                Dim valorUnitario As Decimal = If(IsDBNull(dr(12)), 0D, Convert.ToDecimal(dr(12)))
                table3.AddCell(New PdfPCell(New Phrase(String.Format("{0:N2}", valorUnitario), fuente8)) With {
                    .HorizontalAlignment = Element.ALIGN_RIGHT
                })

                ' Valor Total (formato contable 1,000.65)
                Dim valorTotal As Decimal = If(IsDBNull(dr(13)), 0D, Convert.ToDecimal(dr(13)))
                table3.AddCell(New PdfPCell(New Phrase(String.Format("{0:N2}", valorTotal), fuente8)) With {
                    .HorizontalAlignment = Element.ALIGN_RIGHT
                })

            Next

            table3.SpacingAfter = 5

            'table4 detale valores 

            Dim table4 As New PdfPTable(2)
            table4.TotalWidth = 400
            table4.LockedWidth = True
            table4.SetWidths(New Single() {240, 160})

            'subtabla 1
            Dim table4Sub1 As New PdfPTable(2)
            table4Sub1.TotalWidth = 240
            table4Sub1.LockedWidth = True
            table4Sub1.SetWidths(New Single() {120, 120})

            Dim Celda1Tabla4 As New Paragraph()
            Celda1Tabla4.Add(New Phrase("Son: ", fuente8Bold))
            Celda1Tabla4.Add(New Phrase(valorEnLetras, fuente8))
            Dim cellSubtotal As New PdfPCell(Celda1Tabla4)
            cellSubtotal.HorizontalAlignment = Element.ALIGN_LEFT
            cellSubtotal.Border = Rectangle.NO_BORDER
            cellSubtotal.Colspan = 2
            table4Sub1.AddCell(cellSubtotal)

            'forma de pago
            Dim Celda2Tabla4 As New Paragraph()
            Celda2Tabla4.Add(New Phrase("Forma de Pago: ", fuente8Bold))
            Celda2Tabla4.Add(New Phrase(dt.Rows(0)(19).ToString, fuente8))
            Dim cellTotal As New PdfPCell(Celda2Tabla4)
            cellTotal.HorizontalAlignment = Element.ALIGN_LEFT
            cellTotal.Border = Rectangle.NO_BORDER
            table4Sub1.AddCell(cellTotal)

            'Tipo de pago
            Dim Celda3Tabla4 As New Paragraph()
            Celda3Tabla4.Add(New Phrase("Tipo de Pago: ", fuente8Bold))
            Celda3Tabla4.Add(New Phrase(dt.Rows(0)(20).ToString, fuente8))
            Dim cellFormaPago As New PdfPCell(Celda3Tabla4)
            cellFormaPago.HorizontalAlignment = Element.ALIGN_LEFT
            cellFormaPago.Border = Rectangle.NO_BORDER
            table4Sub1.AddCell(cellFormaPago)

            'Observaciones
            Dim Celda4Tabla4 As New Paragraph()
            Celda4Tabla4.Add(New Phrase("Observaciones: ", fuente8Bold))
            Celda4Tabla4.Add(New Phrase(dt.Rows(0)(21).ToString, fuente8))
            Dim cellObservaciones As New PdfPCell(Celda4Tabla4)
            cellObservaciones.HorizontalAlignment = Element.ALIGN_LEFT
            cellObservaciones.Border = Rectangle.NO_BORDER
            cellObservaciones.Colspan = 2
            table4Sub1.AddCell(cellObservaciones)

            'subtabla 2
            'subototal
            Dim table4Sub2 As New PdfPTable(2)
            table4Sub2.TotalWidth = 160
            table4Sub2.LockedWidth = True
            table4Sub2.SetWidths(New Single() {80, 80})

            ' Subtotal
            Dim cellLabelSubtotal As New PdfPCell(New Phrase("Subtotal", fuente8Bold))
            cellLabelSubtotal.HorizontalAlignment = Element.ALIGN_LEFT
            cellLabelSubtotal.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellLabelSubtotal)

            Dim subtotal As Decimal = If(IsNumeric(txtSubtotal12OrdenCompra.Text), Convert.ToDecimal(txtSubtotal12OrdenCompra.Text), 0D)
            Dim cellValueSubtotal As New PdfPCell(New Phrase(String.Format("{0:N2}", subtotal), fuente8))
            cellValueSubtotal.HorizontalAlignment = Element.ALIGN_RIGHT
            cellValueSubtotal.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellValueSubtotal)


            'subtotal 0
            Dim celllabelSubtotal0 As New PdfPCell(New Phrase("Subtotal 0%", fuente8Bold))
            celllabelSubtotal0.HorizontalAlignment = Element.ALIGN_LEFT
            celllabelSubtotal0.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(celllabelSubtotal0)

            Dim subtotal0 As Decimal = If(IsNumeric(txtSubtotal0OrdenCompra.Text), Convert.ToDecimal(txtSubtotal0OrdenCompra.Text), 0D)
            Dim cellValueSubtotal0 As New PdfPCell(New Phrase(String.Format("{0:N2}", subtotal0), fuente8))
            cellValueSubtotal0.HorizontalAlignment = Element.ALIGN_RIGHT
            cellValueSubtotal0.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellValueSubtotal0)

            'descuento
            Dim cellLabelDescuento As New PdfPCell(New Phrase("Descuento", fuente8Bold))
            cellLabelDescuento.HorizontalAlignment = Element.ALIGN_LEFT
            cellLabelDescuento.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellLabelDescuento)

            Dim descuento As Decimal = If(IsNumeric(txtDescuentoOrdenCompra.Text), Convert.ToDecimal(txtDescuentoOrdenCompra.Text), 0D)
            Dim cellValueDescuento As New PdfPCell(New Phrase(String.Format("{0:N2}", descuento), fuente8))
            cellValueDescuento.HorizontalAlignment = Element.ALIGN_RIGHT
            cellValueDescuento.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellValueDescuento)

            'iva
            Dim cellLabelIva As New PdfPCell(New Phrase("IVA", fuente8Bold))
            cellLabelIva.HorizontalAlignment = Element.ALIGN_LEFT
            cellLabelIva.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellLabelIva)

            Dim iva As Decimal = If(IsNumeric(txtIvaOrdenCompra.Text), Convert.ToDecimal(txtIvaOrdenCompra.Text), 0D)
            Dim cellValueIva As New PdfPCell(New Phrase(String.Format("{0:N2}", iva), fuente8))
            cellValueIva.HorizontalAlignment = Element.ALIGN_RIGHT
            cellValueIva.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellValueIva)

            'total
            Dim cellLabelTotal As New PdfPCell(New Phrase("Total", fuente8Bold))
            cellLabelTotal.HorizontalAlignment = Element.ALIGN_LEFT
            cellLabelTotal.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellLabelTotal)

            Dim total As Decimal = If(IsNumeric(txtTotalOrdenCompra.Text), Convert.ToDecimal(txtTotalOrdenCompra.Text), 0D)
            Dim cellValueTotal As New PdfPCell(New Phrase(String.Format("{0:N2}", total), fuente8))
            cellValueTotal.HorizontalAlignment = Element.ALIGN_RIGHT
            cellValueTotal.Border = Rectangle.NO_BORDER
            table4Sub2.AddCell(cellValueTotal)


            'agregar las subtablas a la tabla principal
            table4.AddCell(table4Sub1)
            table4.AddCell(table4Sub2)




            document.Add(table1)
            document.Add(table2)
            document.Add(table3)
            document.Add(table4)
            'Cierre
            document.Close()
            pdfStream.Position = 0


            document.Close()
            writer.Close()

            pdfStream.Seek(0, SeekOrigin.Begin)
            PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
            PdfViewer1.ZoomMode = 1

            KryptonNavigator1.SelectedPage = KryptonPage2

        End Sub

        Private Sub dgvOrdenCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvOrdenCompra.SelectionChanged
            If dgvOrdenCompra.RowCount = 0 Then Return
            If dgvOrdenCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdOrdenCompra.Text = ""
            Else
                txtIdOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(0).Value
                txtFechaOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(1).Value
                txtNombreProveedor.Text = _objetoProveedorGeneral.BuscarNombreComercialProveedorXIdProveedor(_tipoCon, dgvOrdenCompra.CurrentRow.Cells.Item(2).Value)
                txtRucProveedor.Text = _objetoProveedorGeneral.BuscarRucProveedorXIdProveedor(_tipoCon, dgvOrdenCompra.CurrentRow.Cells.Item(2).Value)
                txtFormaPagoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(3).Value.ToString
                txtTipoPagoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(4).Value.ToString
                txtSubtotal12OrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(6).Value.ToString
                txtSubtotal0OrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(7).Value.ToString
                txtDescuentoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(8).Value.ToString
                txtIvaOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(9).Value.ToString
                txtTotalOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(10).Value.ToString
                CargarDetalleOrdenCompra()
            End If
        End Sub

        Private Sub btnRecargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecargar.Click
            CargarOrdenCompra()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            If dgvOrdenCompra.RowCount = 0 Then DialogResult = Windows.Forms.DialogResult.Cancel
            If dgvOrdenCompra.CurrentRow Is Nothing Then DialogResult = Windows.Forms.DialogResult.Cancel
            DialogResult = Windows.Forms.DialogResult.OK
        End Sub
    End Class
End Namespace