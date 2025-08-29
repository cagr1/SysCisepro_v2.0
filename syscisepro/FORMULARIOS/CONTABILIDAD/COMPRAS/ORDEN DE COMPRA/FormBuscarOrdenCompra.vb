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
            encabezado.WidthPercentage = 100
            encabezado.SetWidths(New Single() {20, 50, 30}) ' proporción columnas

            ' Estilo general con bordes redondeados
            Dim bordeRedondeado As New PdfPCell()
            bordeRedondeado.Border = Rectangle.BOX
            bordeRedondeado.BorderWidth = 1.5F
            bordeRedondeado.Padding = 5
            bordeRedondeado.HorizontalAlignment = Element.ALIGN_CENTER
            bordeRedondeado.VerticalAlignment = Element.ALIGN_MIDDLE

            ' ==== Celda 1: Logo ====
            Dim cellLogo As New PdfPCell(logo, True)
            cellLogo.Border = Rectangle.BOX
            cellLogo.BorderWidth = 1.5F
            cellLogo.HorizontalAlignment = Element.ALIGN_CENTER
            cellLogo.VerticalAlignment = Element.ALIGN_MIDDLE

            encabezado.AddCell(cellLogo)

            ' ==== Celda 2: Título ====
            Dim cellTitulo As New PdfPCell(New Phrase("ORDEN DE COMPRA", fuente12))
            cellTitulo.Border = Rectangle.BOX
            cellTitulo.BorderWidth = 1.5F
            cellTitulo.HorizontalAlignment = Element.ALIGN_CENTER
            cellTitulo.VerticalAlignment = Element.ALIGN_MIDDLE
            cellTitulo.Padding = 6
            encabezado.AddCell(cellTitulo)

            ' ==== Celda 3: Datos en 4 líneas ====
            Dim fechaReporte As String = Convert.ToDateTime(dt.Rows(0)(1)).ToString("dd/MM/yyyy")

            Dim textoCabecera As String =
            "Código: RE 3.6.1-7" & vbCrLf &
            "Versión: 003" & vbCrLf &
            "Página: 1" & vbCrLf &
            "Fecha: " & fechaReporte

            Dim cellInfo As New PdfPCell(New Phrase(textoCabecera, fuente8))
            cellInfo.Border = Rectangle.BOX
            cellInfo.BorderWidth = 1.5F
            cellInfo.HorizontalAlignment = Element.ALIGN_LEFT
            cellInfo.VerticalAlignment = Element.ALIGN_MIDDLE
            cellInfo.Padding = 5

            ' Importante: sin bordes internos → se deja texto en líneas
            encabezado.AddCell(cellInfo)

            ' Agregar la tabla al documento
            document.Add(encabezado)

            'Cierre
            document.Close()
            pdfStream.Position = 0


            document.Close()
            writer.Close()

            pdfStream.Seek(0, SeekOrigin.Begin)
            PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
            PdfViewer1.ZoomMode = 1


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