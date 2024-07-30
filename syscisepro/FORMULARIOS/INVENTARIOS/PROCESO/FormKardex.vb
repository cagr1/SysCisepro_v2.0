Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Configuration
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.INVENTARIOS.KARDEX
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports ClassLibraryCisepro.INVENTARIOS.BODEGA
Imports ClassLibraryCisepro.INVENTARIOS.COMPROBANTES
Imports ClassLibraryCisepro.INVENTARIOS.CONCEPTOS
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA
Imports ClassLibraryCisepro.INVENTARIOS.UNIFORMES
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO



Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormKardex

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

        ReadOnly _objSecuencialItem As New ClassSecuencialItem
        ReadOnly _objKardex As New ClassKardex
        ReadOnly _objDetalleKardex As New ClassDetalleKardex
        ReadOnly _crKardex As New crKardex
        ReadOnly _crKardexBodega As New crKardexBodega

        Private Sub CargarDetalleKardex(ByVal idKardex As Int64)
            Try
                dgvDetalleKardex.DataSource = _objDetalleKardex.SeleccionarDetallesKardexCreados(_tipoCon, idKardex)


                 
                dgvDetalleKardex.Columns(3).DefaultCellStyle.Format = "d"
                dgvDetalleKardex.Columns(4).HeaderText = "C. INGRESO"
                dgvDetalleKardex.Columns(5).HeaderText = "V.U. INGRESO"
                dgvDetalleKardex.Columns(6).HeaderText = "V.T INGRESO"
                dgvDetalleKardex.Columns(7).HeaderText = "C. EGRESO"
                dgvDetalleKardex.Columns(8).HeaderText = "V.U. EGRESO"
                dgvDetalleKardex.Columns(9).HeaderText = "V.T EGRESO"
                dgvDetalleKardex.Columns(16).HeaderText = "SITIOS DE TRABAJO"

                dgvDetalleKardex.Columns(11).Visible = False
                dgvDetalleKardex.Columns(12).Visible = False
                dgvDetalleKardex.Columns(13).Visible = False

                dgvDetalleKardex.AutoResizeColumns()
                dgvDetalleKardex.AutoResizeRows()

            Catch
                dgvDetalleKardex.DataSource = Nothing
            End Try
        End Sub

        Private Sub ConectarReporte(ByVal idKardex As Int64)
            Try
                _crKardex.SetDataSource(_objKardex.SeleccionarKardexPorIdKardex(_tipoCon, CType(dgvKardex.CurrentRow.Cells.Item(0).Value, Int64)))
                _crKardex.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvKardex.ReportSource = _crKardex
                crvKardex.Zoom(75)
                crvKardex.Refresh()
            Catch
                crvKardex.ReportSource = Nothing
            End Try

        End Sub

        'Private Sub tsmReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmReporte.Click
        '    ConectarReporte()
        '    tcKardex.SelectedIndex = 1
        'End Sub

        'Private Sub tsmReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmReporte.Click
        '    ConectarReporte(CType(dgvKardex.CurrentRow.Cells.Item(0).Value, Int64))
        '    ConectarReporte(CType(IdUsuario, Int64))
        '    tcKardex.SelectedIndex = 1
        'End Sub
        'Private Sub ConectarReporte(ByVal idKardex As Int64)
        '    Try

        '        _crKardexBodega.SetDataSource(_objKardex.SeleccionarKardexPorIdKardex(_tipoCon, idKardex))
        '        _crKardexBodega.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
        '        crvKardex.ReportSource = _crKardexBodega
        '        crvKardex.Zoom(75)
        '        crvKardex.Refresh()
        '    Catch
        '        crvKardex.ReportSource = Nothing
        '    End Try

        'End Sub


        Private Sub tsmReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmReporte.Click

            ConectarReport(CType(dgvKardex.CurrentRow.Cells.Item(0).Value, Int64))
            'ConectarReport(CInt(IdUsuario))
            tcKardex.SelectedIndex = 1
        End Sub

        Private Sub ConectarReport(ByVal idKardex As Int64)
            Try
                _crKardexBodega.SetDataSource(_objKardex.SeleccionarKardexPorIdKardex(_tipoCon, CType(dgvKardex.CurrentRow.Cells.Item(0).Value, Int64)))
                '_crKardexBodega.SetDataSource(_objKardex.SeleccionarKardexPorIdKardex(_tipoCon, idKardex))
                _crKardexBodega.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvKardex.ReportSource = _crKardexBodega
                crvKardex.Zoom(100)
                crvKardex.Refresh()
            Catch
                crvKardex.ReportSource = Nothing
            End Try

        End Sub


        'Private Sub ConectarReporte()

        'Dim connect As New ConnectionInfo()
        'Dim username As String = "sa"
        'Dim password As String = "syscisepro"
        'Dim server As String = "VIDEOMONITOREO"
        'Dim database As String = "syscisepro"

        'connect.ServerName = "192.168.0.137"
        'connect.DatabaseName = "SYSCISEPRO"
        'connect.UserID = "syscisepro"
        'connect.Password = "syscisepro"

        '_crKardexBodega.DataSourceConnections.Clear()
        '_crKardexBodega.SetDatabaseLogon("sa", connect.Password, connect.ServerName, connect.DatabaseName, False)

        'For Each Table As CrystalDecisions.CrystalReports.Engine.Table In _crKardexBodega.Database.Tables
        '    AssignTableConnection(Table, connect)
        'Next

        'For Each Section As CrystalDecisions.CrystalReports.Engine.Section In rpt.ReportDefinition.Sections
        '    For Each crvKardex As CrystalDecisions.CrystalReports.Engine.ReportObject In Section.ReportObjects

        '        Dim subreport As SubreportObject = DirectCast(crvKardex, SubreportObject)
        '        Dim subdocument As ReportDocument = subreport.OpenSubreport(subreport.SubreportName)

        '        For Each Table As CrystalDecisions.CrystalReports.Engine.Table In subdocument.Database.Tables
        '            AssignTableConnection(Table, connect)
        '        Next

        '        subdocument.SetDatabaseLogon(connect.UserID, connect.Password, connect.ServerName, connect.DatabaseName)


        '    Next
        'Next
        '_crKardexBodega.SetDatabaseLogon(connect.UserID, connect.Password, connect.ServerName, connect.DatabaseName)
        '_crKardexBodega.SetDatabaseLogon("sa", "syscisepro", "192.168.0.137", "SYSCISEPRO", True)
        '_crKardexBodega.DataSourceConnections.Item(0).SetConnection("VIDEOMONITOREO", "syscisepro", 1)
        '    _crKardexBodega.SetDataSource(_objKardex.SeleccionarKardexPorIdKardex(_tipoCon, CType(dgvKardex.CurrentRow.Cells.Item(0).Value, Int64)))
        '    _crKardexBodega.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
        '    crvKardex.ReportSource = _crKardexBodega
        '    crvKardex.Zoom(100)
        ''crvKardex.RefreshReport()
        '    crvKardex.Refresh()
        ''crvKardex.Show()

        ''_crKardexBodega.DataSourceConnections.Clear()
        ''_crKardexBodega.DataSourceConnections.Item(0).SetConnection("192.168.0.137", "SYSCISEPRO", 1)


        'End Sub

        Private Sub AssignTableConnection(ByVal table As CrystalDecisions.CrystalReports.Engine.Table, ByVal connection As ConnectionInfo)

            Dim logOnInfo As TableLogOnInfo = table.LogOnInfo

            connection.Type = logOnInfo.ConnectionInfo.Type

            logOnInfo.ConnectionInfo = connection

            table.LogOnInfo.ConnectionInfo.DatabaseName = connection.DatabaseName
            table.LogOnInfo.ConnectionInfo.ServerName = connection.ServerName
            table.LogOnInfo.ConnectionInfo.UserID = connection.UserID
            table.LogOnInfo.ConnectionInfo.Password = connection.Password
            table.LogOnInfo.ConnectionInfo.Type = connection.Type
            table.ApplyLogOnInfo(logOnInfo)

        End Sub
        Private Sub txtBuscarKardex_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBuscarKardex.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            dgvKardex.DataSource = _objKardex.SeleccionarKardexCreadosBuscarDetalle(_tipoCon, txtBuscarKardex.Text.Trim)
            dgvKardex.AutoResizeColumns()
            dgvKardex.AutoResizeRows()

            dgvKardex.Columns(0).Width = 50
            dgvKardex.Columns(1).Visible = False
            dgvKardex.Columns(2).Width = 350
            dgvKardex.Columns(3).Width = 60
            dgvKardex.Columns(4).Width = 80
            dgvKardex.Columns(5).Width = 80
            dgvKardex.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End Sub

        Private Sub dgvKardex_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvKardex.SelectionChanged
            If dgvKardex.Rows.Count = 0 Or dgvKardex.CurrentRow Is Nothing Then Return
            CargarDetalleKardex(dgvKardex.CurrentRow.Cells(0).Value)
        End Sub

        Private Sub CargarComprobantesIngresoEgreso(ByVal ingreoegre As String, ByVal idcomprobante As Integer)
            Try
                Dim tipo As Integer = If(ingreoegre = "INGRESO", 1, 0)
                Dim table As DataTable = _objKardex.SeleccionarComprobantesIngresoEgresoBodegaPorId(_tipoCon, tipo, idcomprobante)
                If table.Rows.Count > 0 Then
                    txtNumero.Text = table.Rows(0).Item(0)
                    txtActividad.Text = table.Rows(0).Item(1)
                    txtCentroCosto.Text = table.Rows(0).Item(2)
                    txtBodega.Text = table.Rows(0).Item(3)
                    dtpFecha.Value = table.Rows(0).Item(4)
                    txtNombre.Text = table.Rows(0).Item(5)
                    txtCedula.Text = table.Rows(0).Item(6)
                    txtConcepto.Text = table.Rows(0).Item(7)
                    txtCódigo.Text = table.Rows(0).Item(8)
                    txtRazón.Text = table.Rows(0).Item(9)
                    TextBox1.Text = table.Rows(0).Item(10) + " - " + table.Rows(0).Item(11)
                    txtRazón.BackColor = Color.White
                End If
            Catch ex As Exception
                txtNumero.Clear()
                txtActividad.Clear()
                txtCentroCosto.Clear()
                txtBodega.Clear()
                dtpFecha.Value = DateTime.Now
                txtNombre.Clear()
                txtCedula.Clear()
                txtConcepto.Clear()
                txtCódigo.Clear()
                TextBox1.Clear()

                If dgvDetalleKardex.CurrentRow.Index = 0 Then
                    txtRazón.Text = "REGISTRO DE INICIALIZACIÓN DE KARDE DEL ARTÍCULO / ITEM"
                    txtRazón.BackColor = Color.Aqua
                Else
                    txtRazón.Text = "NO SE HA PODIDO CARGAR LOS DETALLES DEL COMPROBANTE"
                    txtRazón.BackColor = Color.Salmon
                End If

            End Try
        End Sub

        Private Sub dgvDetalleKardex_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvDetalleKardex.SelectionChanged
            If dgvDetalleKardex.Rows.Count = 0 Or dgvDetalleKardex.CurrentRow Is Nothing Then Return
            CargarComprobantesIngresoEgreso(dgvDetalleKardex.CurrentRow.Cells(0).Value, dgvDetalleKardex.CurrentRow.Cells(15).Value)
        End Sub

        Private Sub btnExportarComprobantes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarComprobantes.Click
            ExportarDatosExcel(dgvKardex, "REPORTE KARDEX (INVENTARIO) ")
        End Sub

        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)

            Dim app As Excel._Application = New Excel.Application()
            Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

            worksheet.Name = "COMPROBANTES DE BODEGA"

            worksheet.Range("A1:Z" & dataGridViewExp.RowCount + dataGridViewExp.RowCount + 25).Font.Size = 10

            Dim ic As String = If(titulo.Contains("INVENTARIO"), "E", "O")

            worksheet.Range("A1:" & ic & "1").Merge()
            worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
            worksheet.Range("A1:" & ic & "1").Font.Bold = True
            worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
            worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
            worksheet.Range("A1:" & ic & "1").Font.Size = 12
            'Copete  
            worksheet.Range("A2:" & ic & "2").Merge()
            worksheet.Range("A2:" & ic & "2").Value = titulo
            worksheet.Range("A2:" & ic & "2").Font.Size = 12
            'Fecha  
            worksheet.Range("A3:" & ic & "3").Merge()
            worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " + Date.Now
            worksheet.Range("A3:" & ic & "3").Font.Size = 12

            'Aca se agregan las cabeceras de nuestro datagrid.
            Dim head = 4

            For i = 1 To dataGridViewExp.Columns.Count
                worksheet.Cells(1 + head, i) = dataGridViewExp.Columns(i - 1).HeaderText
                worksheet.Cells(1 + head, i).Font.Bold = True
                worksheet.Cells(1 + head, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(1 + head, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Cells(1 + head, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Cells(1 + head, i).Font.Color = Color.White
            Next

            Dim dataGridViewExpRowCount = 0
            For Each row As DataGridViewRow In dataGridViewExp.Rows
                If row.Visible Then
                    For j = 0 To dataGridViewExp.Columns.Count - 1
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1) = row.Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If dataGridViewExpRowCount = dataGridViewExp.RowCount - 1 Then
                            worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                    Next
                    dataGridViewExpRowCount += 1
                End If
            Next

            worksheet.Range("A1:Z" & dataGridViewExp.RowCount + dataGridViewExp.RowCount + 25).Columns.AutoFit()

            app.DisplayAlerts = False
            app.Visible = True
            app.DisplayAlerts = True
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            txtBuscarKardex.Clear()
            Try
                dgvKardex.DataSource = _objKardex.SeleccionarKardexCreadosBuscarDetalle(_tipoCon, txtBuscarKardex.Text.Trim)
                dgvKardex.AutoResizeColumns()
                dgvKardex.AutoResizeRows()

                For Each row In dgvKardex.Rows
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("CANTIDAD").Value)
                    If cantidad >= 10 And cantidad <= 30 Then
                        row.DefaultCellStyle.BackColor = Color.Orange
                        row.DefaultCellStyle.ForeColor = Color.Black
                    ElseIf cantidad >= 1 And cantidad < 10 Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        row.DefaultCellStyle.ForeColor = Color.White
                    End If

                Next
                dgvKardex.Columns(0).Width = 50
                dgvKardex.Columns(1).Width = 70
                dgvKardex.Columns(2).Width = 350
                dgvKardex.Columns(3).Width = 70
                dgvKardex.Columns(4).Width = 80
            Catch
                dgvKardex.DataSource = Nothing
            End Try
        End Sub

        Private Sub AutocompletarArticulo()
            txtBuscarKardex.AutoCompleteCustomSource = _objSecuencialItem.Autocompletar(_tipoCon)
            txtBuscarKardex.AutoCompleteMode = AutoCompleteMode.Suggest
            txtBuscarKardex.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub

        Private Sub FormKardex_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvKardex.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleKardex.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    dgvKardex.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleKardex.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    dgvKardex.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleKardex.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvKardex.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleKardex.Font = New Font("Roboto", 8, FontStyle.Regular)
            AutocompletarArticulo()

        End Sub

        Private Sub btnllamar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnllamar.Click


            _crKardexBodega.SetDataSource(_objKardex.SeleccionarKardexPorIdKardex(_tipoCon, CType(dgvKardex.CurrentRow.Cells.Item(0).Value, Int64)))
            _crKardexBodega.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvKardex.ReportSource = _crKardexBodega

            crvKardex.Zoom(75)
            crvKardex.Refresh()
            crvKardex.Show()


        End Sub

        Private Sub txtBuscarKardex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarKardex.TextChanged

        End Sub
    End Class
End Namespace