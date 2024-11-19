 
Imports System.Drawing 
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.REPORTES

Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO

    Public Class FormLibroDiario
        ReadOnly _tipoCon = [Enum].Parse(GetType(TipoConexion), 0) ' CISEPRO

        Dim objetoLibroDiario As New ClassLibroDiario
        Dim objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        Dim cantidadRegistrosLibroDiario As Integer
        Dim indice As Integer
        '===== OBJETOS PARA VALIDACIONES =============================================================================================================================================================================
        'Dim validacionesAlfabetica As New ClassAlfabetico : Dim validacionesAlfanumerica As New ClassAlfanumerico
        'Dim validacionesExpresiones As New ClassExpresionesRegulares : Dim validacionesDecimales As New ClassDecimal
        'Public idCustodio As New Integer : Public nombreUsuario As String :
        Dim validacionesNumeros As New ClassNumerico : Dim caracterIngresado As Char

        Public Sub cargarLibroDiario()
            Try
                dgvLibroDiario.DataSource = objetoLibroDiario.SeleccionarLibroDiario(_tipoCon)
                cantidadRegistrosLibroDiario = dgvLibroDiario.Rows.Count
                dgvLibroDiario.AutoResizeColumns()
                dgvLibroDiario.AutoResizeRows()
                dgvLibroDiario.Columns(0).HeaderText = "ID DIARIO"
                dgvLibroDiario.Columns(0).DefaultCellStyle.BackColor = Color.Cyan
                dgvLibroDiario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvLibroDiario.Columns(1).HeaderText = "FECHA "
                dgvLibroDiario.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvLibroDiario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvLibroDiario.Columns(2).HeaderText = "TOT. DEBE"
                dgvLibroDiario.Columns(2).DefaultCellStyle.BackColor = Color.Azure
                dgvLibroDiario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvLibroDiario.Columns(3).HeaderText = "TOT. HABER"
                dgvLibroDiario.Columns(3).DefaultCellStyle.BackColor = Color.Azure
                dgvLibroDiario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvLibroDiario.Columns(4).HeaderText = "EST."
                dgvLibroDiario.Columns(4).DefaultCellStyle.BackColor = Color.Azure
                dgvLibroDiario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvLibroDiario.AutoResizeColumns()
                dgvLibroDiario.AutoResizeRows()
                dgvLibroDiario.ReadOnly = False
                dgvLibroDiario.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
            End Try
        End Sub
        Public Sub cargarDatosAsientoLibroDiarioXIdLibro()
            Try
                dgvAsientosLibroDiario.DataSource = objetoAsientoLibroDiario.SeleccionarAsientosLibroDiarioXIdLibro(_tipoCon, CType(lblIndice.Text, Int64))
                dgvAsientosLibroDiario.AutoResizeColumns()
                dgvAsientosLibroDiario.AutoResizeRows()
                dgvAsientosLibroDiario.Columns(0).HeaderText = "ORD"
                dgvAsientosLibroDiario.Columns(0).DefaultCellStyle.BackColor = Color.Cyan
                dgvAsientosLibroDiario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(1).HeaderText = "FECHA"
                dgvAsientosLibroDiario.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(2).HeaderText = "CODIGO CTA"
                dgvAsientosLibroDiario.Columns(2).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(3).HeaderText = "NOMBRE CTA"
                dgvAsientosLibroDiario.Columns(3).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(4).HeaderText = "CONCEPTO"
                dgvAsientosLibroDiario.Columns(4).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(5).HeaderText = "DETALLE"
                dgvAsientosLibroDiario.Columns(5).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(6).HeaderText = "PROVINCIA"
                dgvAsientosLibroDiario.Columns(6).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(7).HeaderText = "CIUDAD"
                dgvAsientosLibroDiario.Columns(7).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(8).HeaderText = "PARROQUIA"
                dgvAsientosLibroDiario.Columns(8).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(9).HeaderText = "CENTRO COSTO"
                dgvAsientosLibroDiario.Columns(9).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(10).HeaderText = "VALOR DEBE"
                dgvAsientosLibroDiario.Columns(10).DefaultCellStyle.BackColor = Color.Cyan
                dgvAsientosLibroDiario.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(11).HeaderText = "VALOR HABER"
                dgvAsientosLibroDiario.Columns(11).DefaultCellStyle.BackColor = Color.Cyan
                dgvAsientosLibroDiario.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(12).HeaderText = "ASIENTO"
                dgvAsientosLibroDiario.Columns(12).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(13).HeaderText = "D/H"
                dgvAsientosLibroDiario.Columns(13).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(14).HeaderText = "CON"
                dgvAsientosLibroDiario.Columns(14).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(15).HeaderText = "EST"
                dgvAsientosLibroDiario.Columns(15).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(16).HeaderText = "ID LD"
                dgvAsientosLibroDiario.Columns(16).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.ReadOnly = False
                dgvAsientosLibroDiario.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvAsientosLibroDiario.AutoResizeColumns()
                dgvAsientosLibroDiario.AutoResizeRows()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "ERROR. CARGAR DATAGRIDVIEW ASIENTOS LIBRO DIARIO")
            End Try
        End Sub
        Public Sub cargarDatosAsientoLibroDiarioXNroAsiento()
            Try
                dgvAsientosLibroDiario.DataSource = objetoAsientoLibroDiario.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, CType(txtBuscarAsiento.Text, Int64))
                dgvAsientosLibroDiario.AutoResizeColumns()
                dgvAsientosLibroDiario.AutoResizeRows()
                dgvAsientosLibroDiario.Columns(0).HeaderText = "ORD"
                dgvAsientosLibroDiario.Columns(0).DefaultCellStyle.BackColor = Color.Cyan
                dgvAsientosLibroDiario.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(1).HeaderText = "FECHA"
                dgvAsientosLibroDiario.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(2).HeaderText = "CODIGO CTA"
                dgvAsientosLibroDiario.Columns(2).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(3).HeaderText = "NOMBRE CTA"
                dgvAsientosLibroDiario.Columns(3).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(4).HeaderText = "CONCEPTO"
                dgvAsientosLibroDiario.Columns(4).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(5).HeaderText = "DETALLE"
                dgvAsientosLibroDiario.Columns(5).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(6).HeaderText = "PROVINCIA"
                dgvAsientosLibroDiario.Columns(6).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(7).HeaderText = "CIUDAD"
                dgvAsientosLibroDiario.Columns(7).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(8).HeaderText = "PARROQUIA"
                dgvAsientosLibroDiario.Columns(8).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(9).HeaderText = "CENTRO COSTO"
                dgvAsientosLibroDiario.Columns(9).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(10).HeaderText = "VALOR DEBE"
                dgvAsientosLibroDiario.Columns(10).DefaultCellStyle.BackColor = Color.Cyan
                dgvAsientosLibroDiario.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(11).HeaderText = "VALOR HABER"
                dgvAsientosLibroDiario.Columns(11).DefaultCellStyle.BackColor = Color.Cyan
                dgvAsientosLibroDiario.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(12).HeaderText = "ASIENTO"
                dgvAsientosLibroDiario.Columns(12).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(13).HeaderText = "D/H"
                dgvAsientosLibroDiario.Columns(13).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(14).HeaderText = "CON"
                dgvAsientosLibroDiario.Columns(14).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(15).HeaderText = "EST"
                dgvAsientosLibroDiario.Columns(15).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.Columns(16).HeaderText = "ID LD"
                dgvAsientosLibroDiario.Columns(16).DefaultCellStyle.BackColor = Color.Azure
                dgvAsientosLibroDiario.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAsientosLibroDiario.ReadOnly = False
                dgvAsientosLibroDiario.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvAsientosLibroDiario.AutoResizeColumns()
                dgvAsientosLibroDiario.AutoResizeRows()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "ERROR. CARGAR DATAGRIDVIEW ASIENTOS LIBRO DIARIO")
            End Try
        End Sub
        Private Sub moverRegistro(ByVal indice As Integer)
            Try
                If cantidadRegistrosLibroDiario > 0 Then
                    lblIndice.Text = dgvLibroDiario.Rows(indice).Cells.Item(0).Value
                    dgvLibroDiario.ClearSelection()
                    dgvLibroDiario.Rows(indice).Selected = True
                    cargarDatosAsientoLibroDiarioXIdLibro()
                Else
                    MsgBox("NO HAY REGISTROS PARA DESPLAZARSE", MsgBoxStyle.Exclamation, "MENSAJE DE VALDACIÓN")
                End If
            Catch ex As Exception
                MsgBox("MOVER REGISTRO LIBRO DIARIO." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
        Public Sub sumaTotalDebe()
            Dim indiceAsientos As Decimal
            Dim acumuladorDebe As Decimal = 0
            Try
                For indiceAsientos = 0 To dgvAsientosLibroDiario.RowCount - 1
                    acumuladorDebe = acumuladorDebe + dgvAsientosLibroDiario.Rows(+indiceAsientos).Cells(10).Value
                Next
                txtTotalDebe.Text = acumuladorDebe
            Catch ex As Exception
            End Try
        End Sub
        Public Sub sumaTotalHaber()
            Dim indiceAsientos As Decimal
            Dim acumuladorHaber As Decimal = 0
            Try
                For indiceAsientos = 0 To dgvAsientosLibroDiario.RowCount - 1
                    acumuladorHaber = acumuladorHaber + dgvAsientosLibroDiario.Rows(+indiceAsientos).Cells(11).Value
                Next
                txtTotalHaber.Text = acumuladorHaber
            Catch ex As Exception
            End Try
        End Sub
        'Public Sub calculoReposicion()
        '    Dim fondo As Decimal
        '    Dim gastos As Decimal
        '    Dim saldo As Decimal
        '    Dim reposicion As Decimal
        '    Try
        '        txtCantidadFondoRotativo.Text = "600,00"
        '        fondo = CType(txtCantidadFondoRotativo.Text, Decimal)
        '        gastos = CType(txtTotalLiquidacion.Text, Decimal)
        '        saldo = fondo - gastos
        '        reposicion = fondo - saldo
        '        txtCantidadGastosFondoRotativo.Text = gastos
        '        txtCantidadSaldoFondoRotativo.Text = saldo
        '        txtCantidadReposicionFondoRotativo.Text = reposicion
        '    Catch ex As Exception
        '    End Try
        'End Sub
        Private Sub FormLibroDiario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvLibroDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientosLibroDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvLibroDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientosLibroDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvLibroDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientosLibroDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvAsientosLibroDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvLibroDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
            cargarLibroDiario()
            cargarDatosAsientoLibroDiarioXIdLibro()
        End Sub
        Private Sub btnPrimerRegistro_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPrimerRegistro.Click
            indice = 0
            btnAnteriorRegistro.Enabled = False
            btnPrimerRegistro.Enabled = False
            btnUltimoRegistro.Enabled = True
            btnSiguienteRegistro.Enabled = True
            moverRegistro(indice)
        End Sub
        Private Sub btnAnteriorRegistro_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnteriorRegistro.Click
            If indice > 0 Then
                indice = indice - 1
                btnSiguienteRegistro.Enabled = True
                btnUltimoRegistro.Enabled = True
            Else
                btnAnteriorRegistro.Enabled = False
                btnPrimerRegistro.Enabled = False
                btnSiguienteRegistro.Enabled = True
                btnUltimoRegistro.Enabled = True
            End If
            moverRegistro(indice)
        End Sub
        Private Sub btnSiguienteRegistro_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSiguienteRegistro.Click
            If indice < cantidadRegistrosLibroDiario - 1 Then
                indice = indice + 1
                btnAnteriorRegistro.Enabled = True
                btnPrimerRegistro.Enabled = True
            Else
                btnUltimoRegistro.Enabled = False
                btnSiguienteRegistro.Enabled = False
                btnAnteriorRegistro.Enabled = True
                btnPrimerRegistro.Enabled = True
            End If
            moverRegistro(indice)
        End Sub
        Private Sub btnUltimoRegistro_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnUltimoRegistro.Click
            indice = cantidadRegistrosLibroDiario - 1
            btnPrimerRegistro.Enabled = True
            btnAnteriorRegistro.Enabled = True
            btnSiguienteRegistro.Enabled = False
            btnUltimoRegistro.Enabled = False
            moverRegistro(indice)
        End Sub
        Private Sub btnCuadrarLibroDiario_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCuadrarLibroDiario.Click
            Try
                If dgvAsientosLibroDiario.Rows.Count < 2 Then
                    MsgBox("NO HAY ASIENTOS REGISTRADOS EN ESTE DIARIO", MsgBoxStyle.Information, "Mensaje de información")
                Else
                    sumaTotalDebe()
                    sumaTotalHaber()
                End If
            Catch ex As Exception
                MsgBox("NO HAY ASINETOS REGISTRADOS EN ESTE DIARIO", MsgBoxStyle.Information, "Mensaje de información")
            End Try
        End Sub
        Private Sub btnReporteLibroDiario_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporteLibroDiario.Click
            'My.Forms.FormReporteLibroDiario.lblIdLibroDiario.Text = Me.lblIndice.Text
            'My.Forms.FormReporteLibroDiario.Show()
            Dim f = New FormReporteLibroDiario
            f.lblIdLibroDiario.Text = lblIndice.Text
            f.Show()
        End Sub

        Private Sub btnAjusteLibroDiario_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAjusteLibroDiario.Click
            'FormAjustarAsientosLibroDiario.Show()
            Dim f = New FormAjustarAsientosLibroDiario
            f.Show()
        End Sub

        Private Sub dgvLibroDiario_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLibroDiario.CellClick
            Try
                If dgvLibroDiario.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    MsgBox("La Tabla LIQUIDACION FONDO ROTATIVO Esta Vacía", MsgBoxStyle.Information, "Mensaje de información")
                Else
                    lblIndice.Text = dgvLibroDiario.CurrentRow.Cells.Item(0).Value
                    indice = dgvLibroDiario.CurrentCell.RowIndex.ToString()
                    dgvLibroDiario.Rows(dgvLibroDiario.CurrentCell.RowIndex.ToString()).Selected = True
                    cargarDatosAsientoLibroDiarioXIdLibro()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "ERROR. DATAGRIDVIEW LIBRO DIARIO. EVENTO CELLCLICK")
            End Try
        End Sub

        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            If txtBuscarAsiento.Text <> "" Then
                cargarDatosAsientoLibroDiarioXNroAsiento()
            Else
                MsgBox("INGRESE UN PARAMETRO DE BUSQUEDA", MsgBoxStyle.Exclamation, "Mensaje de información")
            End If
        End Sub
        Private Sub btnBusquedaAvanzada_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBusquedaAvanzada.Click
            'FormAjustarAsientosLibroDiario.Show()
            Dim f = New FormAjustarAsientosLibroDiario
            f.Show()
        End Sub

        Private Sub txtBuscarAsiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarAsiento.KeyPress
            caracterIngresado = Convert.ToChar(e.KeyChar)
            If validacionesNumeros.EsNumero(caracterIngresado) = True Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtBuscarAsiento.Click
            gbBuscarAsiento.Enabled = True
            txtBuscarAsiento.Enabled = True
            btnBuscarAsiento.Enabled = True
            btnBusquedaAvanzada.Enabled = True
        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            Try
                If dgvAsientosLibroDiario.Rows.Count = 0 Then
                    MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "ASIENTO_DIARIO"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosLibroDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosLibroDiario.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  LIBRO DIARIO"
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: -  AL  -"
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosLibroDiario.Columns.Count - 1
                    If Not dgvAsientosLibroDiario.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvAsientosLibroDiario.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvAsientosLibroDiario.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvAsientosLibroDiario.Columns.Count - 1

                        If Not dgvAsientosLibroDiario.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosLibroDiario.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvAsientosLibroDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                ' TOTALES, ETC
                Dim foot = headin + dgvAsientosLibroDiario.RowCount + 3
                worksheet.Cells(foot, 6).Value = "TOTAL DE TRANSACCIÓN"
                worksheet.Cells(foot, 6).Font.Bold = True
                worksheet.Cells(foot, 7).Value = txtTotalDebe.Text
                worksheet.Cells(foot, 8).Value = txtTotalHaber.Text

                worksheet.Range("A1:" & ic & (dgvAsientosLibroDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try 
        End Sub
    End Class
End Namespace