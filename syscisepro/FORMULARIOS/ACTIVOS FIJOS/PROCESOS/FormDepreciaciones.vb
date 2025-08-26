Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.DEPRECIACIONES
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.DATOS
Imports Krypton.Toolkit
Imports syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormDepreciaciones
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
        Dim _sqlCommands As List(Of SqlCommand)
        Public IdUsuario As Integer

        ReadOnly _objActivoFijo As New ClassActivoFijo
        ReadOnly _objDepreciacion As New ClassDepreciaciones
        ReadOnly _objDetalleDepreciacion As New ClassDetalleDepreciaciones
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral

        Private Sub Auditoria()
            _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.Trim
            _objAuditoria.EstadoAuditoria = 1
            _objAuditoria.IdUsuarioAuditoria = IdUsuario
            _objAuditoria.AccionAuditoria = "REALIZO UNA DEPRECIACION DE ACTIVO FIJO CON N° DE REGISTRO:" + lblIdDepreciacion.Text + " CON ULTIMO VALOR EN EL MERCADO DE: " + lblDepreciacion.Text
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            Try
                Dim _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00"
                Dim _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59"

                LimpiarParametros()
                dgvActivoFijo.DataSource = _objDepreciacion.BuscarActivoFijoPorIdActivoEnDepreciacionGeneral(_tipoCon, txtCodigoActivo.Text, _fechaDesde, _fechaHasta)


                dgvActivoFijo.Columns(0).HeaderText = "Id Activo"
                dgvActivoFijo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(1).HeaderText = "Tipo"
                dgvActivoFijo.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(2).HeaderText = "Nombre"
                dgvActivoFijo.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(3).HeaderText = "Valor"
                dgvActivoFijo.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(4).HeaderText = "Vida Util"
                dgvActivoFijo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(5).HeaderText = "Porcentaje"
                dgvActivoFijo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(6).HeaderText = "Cuenta"
                dgvActivoFijo.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(7).HeaderText = "Valor Residual"
                dgvActivoFijo.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'do not show the column 8
                dgvActivoFijo.Columns(8).Visible = False
                dgvActivoFijo.Columns(9).HeaderText = "Proveedor"
                dgvActivoFijo.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(10).HeaderText = "Fecha"
                dgvActivoFijo.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(11).HeaderText = "Num Factura"
                dgvActivoFijo.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns(12).HeaderText = "Cuenta Depreciacion"

                dgvActivoFijo.AutoResizeColumns()
                dgvActivoFijo.AutoResizeRows()
                dgvActivoFijo.ReadOnly = False
                dgvActivoFijo.EditMode = DataGridViewEditMode.EditProgrammatically





            Catch ex As Exception
                KryptonMessageBox.Show("Error al cargar los Activos Fijos. " & ex.Message, "Mensaje de error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                dgvActivoFijo.DataSource = Nothing
            End Try
        End Sub

        Private Sub LimpiarParametros()
            txtIdDepreciacion.Clear()
            txtFecha.Clear()
            txtNroDepreciacion.Clear()
            txtValorDepreciacion.Clear()
            txtValorResidual.Clear()
            txtTope.Clear()
            lblIdDepreciacion.Text = String.Empty
            lblFecha.Text = String.Empty
            lblNro.Text = String.Empty
            lblDepreciacion.Text = String.Empty
            lblValorResidual.Text = String.Empty
            lblTope.Text = String.Empty
            dgvMantenimientoDepreciaciones.Rows.Clear()

        End Sub


        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            Try
                Dim ids As New List(Of String)()

                For Each row As DataGridViewRow In dgvActivoFijo.Rows
                    Dim id As String = row.Cells(0).Value.ToString()
                    ids.Add(id)
                Next

                dgvMantenimientoDepreciaciones.DataSource = _objDetalleDepreciacion.SeleccionarDetallesDepreciacionPorIdDepreciacion(_tipoCon, ids)
                dgvMantenimientoDepreciaciones.AutoResizeColumns()
                dgvMantenimientoDepreciaciones.AutoResizeRows()
                dgvMantenimientoDepreciaciones.ReadOnly = False
                dgvMantenimientoDepreciaciones.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvMantenimientoDepreciaciones.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvMantenimientoDepreciaciones_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvMantenimientoDepreciaciones.CellClick
            If dgvMantenimientoDepreciaciones.RowCount = 0 Or dgvMantenimientoDepreciaciones.CurrentRow Is Nothing Then Return
            txtIdDepreciacion.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(0).Value.ToString()
            txtFecha.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(1).Value.ToString()
            txtNroDepreciacion.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(2).Value.ToString()
            txtValorDepreciacion.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(3).Value.ToString()
            txtValorResidual.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(4).Value.ToString()
            txtTope.Text = dgvActivoFijo.CurrentRow.Cells.Item(4).Value.ToString()
        End Sub
        Private Sub btnDepreciar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDepreciar.Click
            Try
                Dim Valor As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(6).Value) 'Valor de Factura
                Dim Porcentaje As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(2).Value)

                If dgvActivoFijo.CurrentRow.Cells.Item(6).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(dgvActivoFijo.CurrentRow.Cells.Item(6).Value.ToString()) Then
                    Valor = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(6).Value)
                Else
                    MsgBox("El valor de factura no puede estar vacío.", MsgBoxStyle.Information, "Mensaje de información")
                    Return
                End If

                If dgvActivoFijo.CurrentRow.Cells.Item(2).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(dgvActivoFijo.CurrentRow.Cells.Item(2).Value.ToString()) Then
                    Porcentaje = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(2).Value)
                Else
                    MsgBox("El porcentaje no puede estar vacío.", MsgBoxStyle.Information, "Mensaje de información")
                    Return
                End If

                lblIdDepreciacion.Text = dgvActivoFijo.CurrentRow.Cells.Item(0).Value.ToString()
                lblFecha.Text = dgvActivoFijo.CurrentRow.Cells.Item(7).Value.ToString()
                lblNro.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(2).Value.ToString() + 1
                lblDepreciacion.Text = (Valor * Porcentaje)
                lblValorResidual.Text = Decimal.Round((Valor * Porcentaje), 3).ToString()
                lblTope.Text = dgvActivoFijo.CurrentRow.Cells.Item(4).Value.ToString()
            Catch
                MsgBox("Por favor cargue el detalle de Depreciacion anterior", MsgBoxStyle.Information, "Mensaje de información")
            End Try

        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtIdDepreciacion.Text <> "" Then

                If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()
                Dim id = Convert.ToInt32(dgvActivoFijo.CurrentRow.Cells.Item(0).Value)
                Dim Idrepe = _objDetalleDepreciacion.BuscarIdDetalleDepreciacionRepetido(_tipoCon, id)

                If (Idrepe = id) Then
                    MessageBox.Show("La depreciacion ya se realizo!!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                Dim idde = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + 1
                Dim Valor As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(6).Value) 'Valor de Factura
                Dim Porcentaje As Decimal = Convert.ToDecimal(lblValorResidual.Text.ToString())
                Dim Fech As String = lblFecha.Text
                Dim fecha As DateTime = DateTime.Parse(Fech)

                _objDetalleDepreciacion.ValorResidualDepreciacion = Valor
                _objDetalleDepreciacion.ValorDepreciacion = 0.0


                For i = 1 To Convert.ToInt32(lblTope.Text)

                    With _objDetalleDepreciacion
                        .IdDetalle = idde
                        .Fecha = fecha
                        .NumeroDepreciacion = i
                        .ValorDepreciacion += Porcentaje
                        .ValorResidualDepreciacion -= Porcentaje
                        .Estado = 1
                        .IdDetalleGeneral = dgvActivoFijo.CurrentRow.Cells.Item(0).Value.ToString()
                        _sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion())
                    End With
                    fecha = fecha.AddYears(1)
                    idde += 1

                Next
                Auditoria()
                'With _objDetalleDepreciacion
                '    .IdDetalle = lblIdDepreciacion.Text
                '    .Fecha = Date.Now
                '    .NumeroDepreciacion = lblNro.Text
                '    .ValorResidualDepreciacion = CDec(lblValorResidual.Text)
                '    .ValorDepreciacion = CDec(lblDepreciacion.Text)
                '    .Estado = 1
                'End With
                '_sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion)


                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then btnCargar_Click(Nothing, Nothing)
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No se puede guardar si no tiene un identificador de Depreciación", MsgBoxStyle.Information, "Mensaje de información")
            End If
        End Sub
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            'Dim formReporteDepreciacion As New FormReporteDepreciaciones
            'formReporteDepreciacion.TipoCox = TipoCox
            'formReporteDepreciacion.lblIdDepreciacion.Text = txtIdDepreciacion.Text
            'formReporteDepreciacion.ShowDialog()

            If dgvActivoFijo.Rows.Count = 0 Then
                KryptonMessageBox.Show("No hay ningun Activo Fijo cargado.", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
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

            Dim baseFont As BaseFont = baseFont.CreateFont(baseFont.HELVETICA, baseFont.CP1252, baseFont.EMBEDDED)
                Dim fuente12 As iTextSharp.text.Font = New Font(baseFont, 12, iTextSharp.text.Font.BOLD)
                Dim fuente10Bold As iTextSharp.text.Font = New Font(baseFont, 10, iTextSharp.text.Font.BOLD)
                Dim fuente10 As iTextSharp.text.Font = New Font(baseFont, 10)
                Dim fuente8 As iTextSharp.text.Font = New Font(baseFont, 8)
                Dim fuente8Bold As iTextSharp.text.Font = New Font(baseFont, 8, iTextSharp.text.Font.BOLD)

                Dim rutaImagen As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
            logo.ScaleToFit(50, 50)

            Dim NombreEmpresa As String = ValidationForms.NombreCompany(_tipoCon)
                Dim Ciudad As String = "Machala - El Oro - Ecuador"
                Dim Direccion As String = "Avenida Alejandro Castro Benitez, El Bosque Sector 5"



            '=================Bloque 1 ==================

            Dim headerTable As New PdfPTable(2)
            headerTable.WidthPercentage = 105
            headerTable.SetWidths(New Single() {80, 35})

            Dim cellLeft As New PdfPCell()
            cellLeft.Border = PdfPCell.NO_BORDER
            cellLeft.AddElement(New Phrase(NombreEmpresa, fuente12))
            cellLeft.AddElement(New Phrase(Ciudad, fuente10))
            cellLeft.AddElement(New Phrase(Direccion, fuente10))
            cellLeft.AddElement(New Phrase("Id Activo Fijo: " & dgvActivoFijo.CurrentRow.Cells(0).Value.ToString(), fuente10Bold))
            headerTable.AddCell(cellLeft)

            Dim cellRight As New PdfPCell(logo)
            cellRight.HorizontalAlignment = Element.ALIGN_CENTER
            cellRight.VerticalAlignment = Element.ALIGN_MIDDLE
            cellRight.Border = PdfPCell.NO_BORDER
            headerTable.AddCell(cellRight)

            document.Add(headerTable)
            document.Add(New Paragraph(" "))

            'headerTable.WriteSelectedRows(0, -1, 20, 575, writer.DirectContent)

            Dim rectTabla1 As PdfContentByte = writer.DirectContent
            rectTabla1.RoundRectangle(10.0F, 485.0F, 390.0F, 75.0F, 10.0F)
            rectTabla1.Stroke()
            ' ================== BLOQUE 2 ==================
            Dim infoTable As New PdfPTable(2)
            infoTable.WidthPercentage = 100
            infoTable.SetWidths(New Single() {50, 50})

            ' Fila 1
            infoTable.AddCell(New PdfPCell(New Phrase("Cuenta: ", fuente8Bold)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase(dgvActivoFijo.CurrentRow.Cells(6).Value.ToString(), fuente8)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase("Fecha de Compra: ", fuente8Bold)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase(dgvActivoFijo.CurrentRow.Cells(10).Value.ToString(), fuente8)) With {.Border = PdfPCell.NO_BORDER})

            ' Fila 2 → Nombre de Activo ocupa doble columna
            Dim nombreActivoCell As New PdfPCell(New Phrase("Nombre de Activo: " & dgvActivoFijo.CurrentRow.Cells(2).Value.ToString(), fuente8))
            nombreActivoCell.Colspan = 2
            nombreActivoCell.Border = PdfPCell.NO_BORDER
            infoTable.AddCell(nombreActivoCell)

            ' Fila 3
            infoTable.AddCell(New PdfPCell(New Phrase("Tipo de Activo: ", fuente8Bold)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase(dgvActivoFijo.CurrentRow.Cells(1).Value.ToString(), fuente8)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase("Número de Factura: ", fuente8Bold)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase(dgvActivoFijo.CurrentRow.Cells(11).Value.ToString(), fuente8)) With {.Border = PdfPCell.NO_BORDER})

            ' Fila 4
            infoTable.AddCell(New PdfPCell(New Phrase("Valor de Factura: ", fuente8Bold)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase(dgvActivoFijo.CurrentRow.Cells(3).Value.ToString(), fuente8)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase("Años Vida Útil: ", fuente8Bold)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase(dgvActivoFijo.CurrentRow.Cells(4).Value.ToString(), fuente8)) With {.Border = PdfPCell.NO_BORDER})

            ' Fila 5
            infoTable.AddCell(New PdfPCell(New Phrase("Proveedor: ", fuente8Bold)) With {.Border = PdfPCell.NO_BORDER})
            infoTable.AddCell(New PdfPCell(New Phrase(dgvActivoFijo.CurrentRow.Cells(9).Value.ToString(), fuente8)) With {.Border = PdfPCell.NO_BORDER})

            document.Add(infoTable)
            document.Add(New Paragraph(" "))

            'infoTable.WriteSelectedRows(0, -1, 20, 510, writer.DirectContent)

            Dim rectTabla2 As PdfContentByte = writer.DirectContent
            rectTabla2.RoundRectangle(10.0F, 370.0F, 390.0F, 110.0F, 10.0F)
            rectTabla2.Stroke()

            ' ================== BLOQUE 3 (Depreciación Anual) ==================
            Dim fechaCompra As Date = Convert.ToDateTime(dgvActivoFijo.CurrentRow.Cells(10).Value)
            Dim costo As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells(3).Value)
            Dim valorResidual As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells(7).Value)
            Dim vidaUtilAnios As Integer = Convert.ToInt32(dgvActivoFijo.CurrentRow.Cells(4).Value)

            Dim dtAnual As DataTable = GenerarTablaDepreciacionAnual(fechaCompra, costo, valorResidual, vidaUtilAnios)

            Dim tabla As New PdfPTable(5)
            tabla.WidthPercentage = 110
            tabla.SetWidths(New Single() {50, 200, 80, 80, 80})

            ' Encabezados
            Dim headers() As String = {"No Periodos", "Concepto", "Depreciacion Anual", "Depreciacion Acumulada", "Importe en Libros"}
            For Each h In headers
                Dim cell As New PdfPCell(New Phrase(h, fuente10Bold))
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                tabla.AddCell(cell)
            Next

            ' Poblar datos
            For Each row As DataRow In dtAnual.Rows
                tabla.AddCell(New PdfPCell(New Phrase(row("Periodo").ToString(), fuente8)))
                tabla.AddCell(New PdfPCell(New Phrase(row("Concepto").ToString(), fuente8)))
                tabla.AddCell(New PdfPCell(New Phrase(Format(row("DepreciacionAnual"), "N2"), fuente8)) With {.HorizontalAlignment = Element.ALIGN_RIGHT})
                tabla.AddCell(New PdfPCell(New Phrase(Format(row("DepreciacionAcumulada"), "N2"), fuente8)) With {.HorizontalAlignment = Element.ALIGN_RIGHT})
                tabla.AddCell(New PdfPCell(New Phrase(Format(row("ImporteEnLibros"), "N2"), fuente8)) With {.HorizontalAlignment = Element.ALIGN_RIGHT})
            Next

            document.Add(tabla)

            ' ================== BLOQUE 4 (FIRMAS) ==================
            Dim Gerente As String
            If _tipoCon = 1 Then
                Gerente = "Ing. Jose Navarrete"
            Else
                Gerente = "Ing. Marjorie Loor"
            End If

            Dim firmasTable As New PdfPTable(2)
            firmasTable.WidthPercentage = 100
            firmasTable.SetWidths(New Single() {50, 50})

            ' Fila 1 → Nombres
            firmasTable.AddCell(New PdfPCell(New Phrase(Gerente, fuente10Bold)) With {.Border = PdfPCell.NO_BORDER, .HorizontalAlignment = Element.ALIGN_CENTER, .PaddingTop = 30})
            firmasTable.AddCell(New PdfPCell(New Phrase("Ing. Magdalena Chato", fuente10Bold)) With {.Border = PdfPCell.NO_BORDER, .HorizontalAlignment = Element.ALIGN_CENTER, .PaddingTop = 30})

            ' Fila 2 → Cargos
            firmasTable.AddCell(New PdfPCell(New Phrase("Gerente General", fuente8)) With {.Border = PdfPCell.NO_BORDER, .HorizontalAlignment = Element.ALIGN_CENTER})
            firmasTable.AddCell(New PdfPCell(New Phrase("Contadora", fuente8)) With {.Border = PdfPCell.NO_BORDER, .HorizontalAlignment = Element.ALIGN_CENTER})

            document.Add(New Paragraph(" "))
            document.Add(firmasTable)

            ' ================== CIERRE ==================
            document.Close()
            pdfStream.Position = 0


            document.Close()
            writer.Close()

            pdfStream.Seek(0, SeekOrigin.Begin)
            PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
            PdfViewer1.ZoomMode = 1


        End Sub

        Private Function GenerarTablaDepreciacionAnual(
            fechaCompra As Date,
            costo As Decimal,
            valorResidual As Decimal,
            vidaUtilAnios As Integer
        ) As DataTable

            Dim dt As New DataTable
            dt.Columns.Add("Periodo", GetType(Integer))
            dt.Columns.Add("Concepto", GetType(String))
            dt.Columns.Add("DepreciacionAnual", GetType(Decimal))
            dt.Columns.Add("DepreciacionAcumulada", GetType(Decimal))
            dt.Columns.Add("ImporteEnLibros", GetType(Decimal))

            Dim baseDepreciable As Decimal = costo - valorResidual
            Dim depAnual As Decimal = Math.Round(baseDepreciable / vidaUtilAnios, 2)

            Dim depAcumulada As Decimal = 0
            Dim importeEnLibros As Decimal = costo

            For i As Integer = 1 To vidaUtilAnios
                Dim depEjercicio As Decimal

                If i = 1 Then
                    ' Prorratear primer año según fecha de compra
                    Dim mesesRestantes As Integer = 12 - fechaCompra.Month + 1
                    depEjercicio = Math.Round(depAnual / 12 * mesesRestantes, 2)
                ElseIf i = vidaUtilAnios Then
                    ' Ajuste final para cuadrar con valor residual
                    depEjercicio = importeEnLibros - valorResidual
                Else
                    depEjercicio = depAnual
                End If

                depAcumulada += depEjercicio
                importeEnLibros -= depEjercicio

                dt.Rows.Add(
            i,
            "Depreciación Activo Fijo Año " & fechaCompra.Year + (i - 1),
            depEjercicio,
            depAcumulada,
            importeEnLibros
        )
            Next

            Return dt
        End Function


        Private Sub FormDepreciaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvMantenimientoDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvMantenimientoDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvMantenimientoDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvActivoFijo.Font = New Drawing.Font("Roboto", 8, FontStyle.Regular)
            'dgvMantenimientoDepreciaciones.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)

            Dim validation As New ValidationForms()
            validation.SetPlaceholder(txtCodigoActivo, "Buscar por Codigo, Tipo o Custodio de Activo")

        End Sub


    End Class
End Namespace