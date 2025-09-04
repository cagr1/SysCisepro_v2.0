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
            "Fecha: " & fechaReporte

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

            Dim cell1 As New PdfPCell(parrafoCelda1)
            cell1.HorizontalAlignment = Element.ALIGN_LEFT
            cell1.VerticalAlignment = Element.ALIGN_TOP
            cell1.Border = Rectangle.NO_BORDER
            cell1.Padding = 2
            table1.AddCell(cell1)

            ' ==== Celda 2 ====
            Dim parrafoCelda2 As New Paragraph()
            parrafoCelda2.Alignment = Element.ALIGN_CENTER
            parrafoCelda2.Add(New Phrase("Servicios en Seguridad Fisica y Electronica" & vbCrLf, fuente10))
            parrafoCelda2.Add(New Phrase("CISEPRO C Ltda" & vbCrLf, fuente12)) ' bold 12
            parrafoCelda2.Add(New Phrase("Dirección: Av. Alejandro Castro Benitez y El Bosque sector 5" & vbCrLf, fuente10))
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


            'Detalle Orden Compra

            table2.SpacingAfter = 10


            document.Add(table1)
            document.Add(table2)

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