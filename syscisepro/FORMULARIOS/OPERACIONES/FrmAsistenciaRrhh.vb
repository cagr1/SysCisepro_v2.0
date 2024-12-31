Imports System.IO
Imports System.Text
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports Krypton.Toolkit

Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmAsistenciaRrhh
        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Private Get
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

        ReadOnly _objAsignacionPersonal As New ClassAsignacionPersonal

        ReadOnly _objProgramacionOps As New ClassProgramacionOperaciones
        ReadOnly _objdetaProgramacionOps As New ClassDetallesProgramacion
        ReadOnly _objPersonal As New ClassPersonal

        Dim _frmDetail As FrmReporteObservaciones

        Private _hoy As DateTime

        Private _usuario As Integer

        Dim _cleanRead As Boolean = False

        Dim _indices3 As List(Of Integer)
        Dim _indices4 As List(Of Integer)

        Private Sub FrmAsignarPuestoTrabajoOperaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a

                    'MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorAsenava


                    dgvDia.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvNoche.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    DataGridView1.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    DataGridView2.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDecimo3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDecimo4.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvBuscarUtilidades.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac

                    'MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac


                    dgvDia.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvNoche.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    DataGridView1.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    DataGridView2.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDecimo3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDecimo4.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvBuscarUtilidades.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro

                    'MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorCisepro


                    dgvDia.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvNoche.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    DataGridView1.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    DataGridView2.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDecimo3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDecimo4.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvBuscarUtilidades.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvDia.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvNoche.Font = New Font("Roboto", 8, FontStyle.Regular)
            DataGridView1.Font = New Font("Roboto", 8, FontStyle.Regular)
            DataGridView2.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDecimo3.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDecimo4.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvBuscarUtilidades.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvUtilidades.Font = New Font("Roboto", 8, FontStyle.Regular)
            DataGridView3.Font = New Font("Roboto", 8, FontStyle.Regular)
            _indices3 = New List(Of Integer)
            _indices4 = New List(Of Integer)

            _hoy = ValidationForms.FechaActual(_tipoCon)
            dtpMes.Value = New Date(_hoy.Year, _hoy.Month, 1)

            DateTimePicker8.Value = New Date(_hoy.Year, _hoy.Month, 1)
            DateTimePicker3.Value = DateTimePicker8.Value

            dtpDecimo3_ValueChanged(Nothing, Nothing)
            dtpDecimo4_ValueChanged(Nothing, Nothing)
            DateTimePicker13_ValueChanged(Nothing, Nothing) 
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click

            If dgvDia.RowCount > 0 Or dgvNoche.RowCount > 0 Then
                If MessageBox.Show("Se detectó datos en las tabla DÍA / NOCHE, si no ha guardado los cambios se volverá a cargar la información almacenada anteriormente para la fecha correspondiente. Desea continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            End If

            Try
                _hoy = ValidationForms.FechaActual(_tipoCon)

                Dim fechaDesde = DateTimePicker4.Value.Year.ToString & "-" & DateTimePicker4.Value.Month.ToString & "-" & DateTimePicker4.Value.Day.ToString & " 00:00:00"
                Dim fechaHasta = DateTimePicker4.Value.Year.ToString & "-" & DateTimePicker4.Value.Month.ToString & "-" & DateTimePicker4.Value.Day.ToString & " 23:59:59"

                Dim prog = _objProgramacionOps.SeleccionarProgramacionByFecha(_tipoCon, fechaDesde)
                TextBox3.Text = prog.Rows(0).Item(0)

                dtpMes.Value = New Date(Convert.ToInt16(prog.Rows(0).Item(2)), Convert.ToInt16(prog.Rows(0).Item(1)), 1)
                DateTimePicker1.Value = Convert.ToDateTime(prog.Rows(0).Item(3))
                DateTimePicker2.Value = Convert.ToDateTime(prog.Rows(0).Item(4))
                Dim dia As String
                Dim ndia = String.Empty
                Dim jdia = String.Empty
                Dim datosd As Data.DataTable
                Dim datosn As Data.DataTable
                Dim crd As Integer
                Dim crn As Integer

                Select Case DateTimePicker4.Value.DayOfWeek
                    Case 0 : dia = "DO" : ndia = "domingo" : jdia = "do_di"
                    Case 1 : dia = "LU" : ndia = "lunes" : jdia = "lu_di"
                    Case 2 : dia = "MA" : ndia = "martes" : jdia = "ma_di"
                    Case 3 : dia = "MI" : ndia = "miercoles" : jdia = "mi_di"
                    Case 4 : dia = "JU" : ndia = "jueves" : jdia = "ju_di"
                    Case 5 : dia = "VI" : ndia = "viernes" : jdia = "vi_di"
                    Case 6 : dia = "SA" : ndia = "sabado" : jdia = "sa_di"
                    Case Else : dia = String.Empty
                End Select
                dgvDia.Rows.Clear()
                dgvNoche.Rows.Clear()

                Dim ex = _objAsignacionPersonal.SeleccionarProgramacionByIdProgFecha(_tipoCon, prog.Rows(0).Item(0), fechaDesde, fechaHasta)
                If ex Then
                    ' Select Case MessageBox.Show("YA EXISTE un reporte del " & DateTimePicker4.Text & " si pone 'SI' se cargará dicho reporte y podrá continuar los cambios sobre el mismo, si pone 'NO' se cargará un nuevo reporte según el día de la programación correspondiente. Desea cargar los datos del reporte existente? ", "Mensaje del sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    Select Case KryptonMessageBox.Show("Ya existe un reporte del " & DateTimePicker4.Text & " si pone 'SI' se cargará dicho reporte y podrá continuar los cambios sobre el mismo" & vbNewLine & "Si pone 'NO' se cargará un nuevo reporte según el día de la programación correspondiente." & vbNewLine & " Desea cargar los datos del reporte existente? ", "Mensaje del sistema", KryptonMessageBoxButtons.YesNoCancel, KryptonMessageBoxIcon.Question)
                        Case DialogResult.Yes
                            datosd = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, True, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 1)
                            datosn = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, True, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 2)

                            crd = If(datosd.Rows.Count > 0, If(datosd.Rows(0).Item(19).ToString.Trim.Length > 0, datosd.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            crn = If(datosn.Rows.Count > 0, If(datosn.Rows(0).Item(19).ToString.Trim.Length > 0, datosn.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            _cleanRead = False
                        Case DialogResult.No
                            datosd = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 1)
                            datosn = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 2)

                            crd = If(datosd.Rows.Count > 0, If(datosd.Rows(0).Item(19).ToString.Trim.Length > 0, datosd.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            crn = If(datosn.Rows.Count > 0, If(datosn.Rows(0).Item(19).ToString.Trim.Length > 0, datosn.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            _cleanRead = True
                        Case Else
                            datosd = New Data.DataTable()
                            datosn = New Data.DataTable()
                            crd = 0
                            crn = 0
                            _cleanRead = False
                    End Select
                Else
                    datosd = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 1)
                    datosn = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 2)
                    crd = 0
                    crn = 0
                    _cleanRead = True
                End If


                ' dia
                DeleteColumnsReport(dgvDia)
                CrearColumnasReporte(dgvDia, crd)
                For Each row As DataRow In datosd.Rows

                    Dim vr = row.Item(19).ToString.Split("~")
                    Dim hora = If(row.Item(21).ToString.Contains("~"), row.Item(21), row.Item(9))

                    dgvDia.Rows.Add(row.Item(0), row.Item(1), row.Item(2), row.Item(3), row.Item(4), row.Item(5), row.Item(6), row.Item(7), row.Item(8), hora, row.Item(10), row.Item(11),
                                    row.Item(12), row.Item(13), row.Item(14), row.Item(15))

                    For i = 16 To dgvDia.ColumnCount - 1
                        If dgvDia.Columns(i).Name.StartsWith("RR") Then
                            If row.Item(19).ToString.Trim.Length = 0 Then Continue For
                            Try
                                dgvDia.Rows(dgvDia.RowCount - 1).Cells(i).Value = vr((dgvDia.Columns(i).Name.Substring(2)) - 1).Trim.Substring(0, 1).Equals("S")
                                Dim h = vr((dgvDia.Columns(i).Name.Substring(2)) - 1).Trim.Substring(1)
                                dgvDia.Rows(dgvDia.RowCount - 1).Cells(i + 1).Value = If(h.Trim.Length = 0, "-", h.Trim)
                            Catch
                                dgvDia.Rows(dgvDia.RowCount - 1).Cells(i + 1).Value = "-"
                            End Try
                        End If
                    Next

                    If row.Item(10) = "ASISTENCIA" Then dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 34, 139, 34)

                    If row.Item(10) = "ATRASO" Then dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 239, 213)

                    If row.Item(10) = "INASISTENCIA" Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Value = "IN"
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                    End If

                    If row.Item(10) = "DOBLADA" Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Value = "DB"
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                    End If

                    If row.Item(10) = "VACACIONES" Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Value = "VC"
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                    End If

                    If row.Item(10) = "PERMISO MÉDICO" Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Value = "PM"
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                    End If

                    If row.Item(10) = "CALAMIDAD DOMÉSTICA" Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Value = "CD"
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                    End If

                    dgvDia.Rows(dgvDia.RowCount - 1).Tag = row.Item(17) & "|" & row.Item(18) & "|" & row.Item(19) & "|" & row.Item(20) ' cantrep|observaciones|rp1~rp2~rp3~|iduser

                    If row.Item(18).ToString.Trim.Length > 0 Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(1).Style.BackColor = Color.LightSkyBlue
                    Else
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(1).Style.BackColor = dgvDia.Rows(dgvDia.RowCount - 1).Cells(2).Style.BackColor
                    End If
                Next

                dgvDia.Columns("RIVER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvDia.Columns("HORARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvDia.AutoResizeRows()
                MetroTabControl1.TabPages(0).Text = "DÍA - " & dgvDia.RowCount & " VIGILANTES"

                ' noche
                DeleteColumnsReport(dgvNoche)
                CrearColumnasReporte(dgvNoche, crn)
                For Each row As DataRow In datosn.Rows

                    Dim vr = row.Item(19).ToString.Split("~")
                    Dim hora = If(row.Item(21).ToString.Contains("~"), row.Item(21), row.Item(9))

                    dgvNoche.Rows.Add(row.Item(0), row.Item(1), row.Item(2), row.Item(3), row.Item(4), row.Item(5), row.Item(6), row.Item(7), row.Item(8), hora, row.Item(10), row.Item(11),
                                      row.Item(12), row.Item(13), row.Item(14), row.Item(15))

                    For i = 16 To dgvNoche.ColumnCount - 1
                        If dgvNoche.Columns(i).Name.StartsWith("RR") Then

                            If row.Item(19).ToString.Trim.Length = 0 Then Continue For
                            Try
                                dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(i).Value = vr((dgvNoche.Columns(i).Name.Substring(2)) - 1).Trim.Substring(0, 1).Equals("S")
                                Dim h = vr((dgvNoche.Columns(i).Name.Substring(2)) - 1).Trim.Substring(1)
                                dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(i + 1).Value = If(h.Trim.Length = 0, "-", h.Trim)
                            Catch
                                dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(i + 1).Value = "-"
                            End Try
                        End If
                    Next

                    If row.Item(10) = "ASISTENCIA" Then dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 34, 139, 34)

                    If row.Item(10) = "ATRASO" Then dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 239, 213)

                    If row.Item(10) = "INASISTENCIA" Then
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Value = "IN"
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                    End If

                    If row.Item(10) = "DOBLADA" Then
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Value = "DB"
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                    End If

                    If row.Item(10) = "VACACIONES" Then
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Value = "VC"
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                    End If

                    If row.Item(10) = "PERMISO MÉDICO" Then
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Value = "PM"
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                    End If

                    If row.Item(10) = "CALAMIDAD DOMÉSTICA" Then
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Value = "CD"
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                    End If

                    dgvNoche.Rows(dgvNoche.RowCount - 1).Tag = row.Item(17) & "|" & row.Item(18) & "|" & row.Item(19) & "|" & row.Item(20) ' cantrep|observaciones|rp1~rp2~rp3~|iduser

                    If row.Item(18).ToString.Trim.Length > 0 Then
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(1).Style.BackColor = Color.LightSkyBlue
                    Else
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(1).Style.BackColor = dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(2).Style.BackColor
                    End If
                Next
                dgvNoche.Columns("RIVER2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvNoche.Columns("HORARIO2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvNoche.AutoResizeRows()
                MetroTabControl1.TabPages(1).Text = "NOCHE - " & dgvNoche.RowCount & " VIGILANTES"

                ' verifica persisos
                If _cleanRead Then
                    Dim per = _objdetaProgramacionOps.SeleccionarDetallePermisosHoyForProgramacion(_tipoCon, fechaDesde)
                    Dim tg() As String
                    If Not per Is Nothing And per.Rows.Count > 0 Then
                        For Each row As DataRow In per.Rows
                            For Each rod As DataGridViewRow In dgvDia.Rows
                                If row.Item(1).ToString().Equals(rod.Cells(3).Value.ToString) Then
                                    If (rod.Tag & "").ToString.Trim.Length = 0 Then rod.Tag = "0|||0"

                                    tg = rod.Tag.ToString.Split("|")
                                    tg(1) += If(tg(1).Trim.Length = 0, row.Item(6).ToString(), vbNewLine & row.Item(6).ToString())
                                    rod.Tag = tg(0) & "|" & tg(1) & "|" & tg(2) & "|" & tg(3)
                                    If tg(1).Trim.Length > 0 Then rod.Cells(1).Style.BackColor = Color.LightSkyBlue

                                    If row.Item(2).ToString().Equals("31") Or row.Item(2).ToString().Equals("33") Then
                                        rod.Cells(10).Value = "PERMISO MÉDICO"
                                        rod.Cells(11).Value = "PM"
                                        rod.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    End If
                                    If row.Item(2).ToString().Equals("32") Then
                                        rod.Cells(10).Value = "CALAMIDAD DOMÉSTICA"
                                        rod.Cells(11).Value = "CD"
                                        rod.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    End If
                                    If row.Item(2).ToString().Equals("34") Then
                                        rod.Cells(10).Value = "VACACIONES"
                                        rod.Cells(11).Value = "VC"
                                        rod.Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                                    End If
                                    rod.Cells(12).Value = "-"
                                    rod.Cells(13).Value = "-"
                                    rod.Cells(14).Value = "-"
                                    rod.Cells(15).Value = "-"
                                End If
                            Next
                        Next

                        For Each row As DataRow In per.Rows
                            For Each rod As DataGridViewRow In dgvNoche.Rows
                                If row.Item(1).ToString().Equals(rod.Cells(3).Value.ToString) Then
                                    If (rod.Tag & "").ToString.Trim.Length = 0 Then rod.Tag = "0|||0"
                                    tg = rod.Tag.ToString.Split("|")
                                    tg(1) += If(tg(1).Trim.Length = 0, row.Item(6).ToString(), vbNewLine & row.Item(6).ToString())
                                    rod.Tag = tg(0) & "|" & tg(1) & "|" & tg(2) & "|" & tg(3)
                                    If tg(1).Trim.Length > 0 Then rod.Cells(1).Style.BackColor = Color.LightSkyBlue

                                    If row.Item(2).ToString().Equals("31") Or row.Item(2).ToString().Equals("33") Then
                                        rod.Cells(10).Value = "PERMISO MÉDICO"
                                        rod.Cells(11).Value = "PM"
                                        rod.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    End If
                                    If row.Item(2).ToString().Equals("32") Then
                                        rod.Cells(10).Value = "CALAMIDAD DOMÉSTICA"
                                        rod.Cells(11).Value = "CD"
                                        rod.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    End If
                                    If row.Item(2).ToString().Equals("34") Then
                                        rod.Cells(10).Value = "VACACIONES"
                                        rod.Cells(11).Value = "VC"
                                        rod.Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                                    End If
                                    rod.Cells(12).Value = "-"
                                    rod.Cells(13).Value = "-"
                                    rod.Cells(14).Value = "-"
                                    rod.Cells(15).Value = "-"
                                End If
                            Next
                        Next
                    End If
                End If

                dgvDia.ReadOnly = True
                dgvNoche.ReadOnly = True

                DateTimePicker5.Value = DateTimePicker4.Value

            Catch ex As Exception
                dgvDia.Rows.Clear()
                dgvNoche.Rows.Clear()
                Dim m = If(ex.Message.Contains("fila en la posición 0"), "NO HA REGISTRADO LA PROGRAMACIÓN CORRESPONDIENTE A LA FECHA SELECCIONADA!", ex.Message)
                'MsgBox("ERROR AL CARGAR PROGRAMACIÓN DE HOY: " & vbNewLine & m, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("ERROR AL CARGAR PROGRAMACIÓN DE HOY: " & vbNewLine & m, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub CrearColumnasReporte(ByVal grid As DataGridView, ByVal cant As Integer)
            If cant < 1 Then Return
            Dim c As DataGridViewCheckBoxColumn
            Dim d As DataGridViewTextBoxColumn

            For i = 1 To cant
                c = New DataGridViewCheckBoxColumn
                c.Width = 40
                c.CellTemplate = New DataGridViewCheckBoxCell()

                d = New DataGridViewTextBoxColumn
                d.HeaderText = "HORA"
                d.Width = 50
                d.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                d.CellTemplate = New DataGridViewTextBoxCell()
                d.DividerWidth = 1

                c.Tag = i
                c.HeaderText = "REP " & i
                c.Name = "RR" & i
                d.Name = "HR" & i
                grid.Columns.Add(c)
                grid.Columns.Add(d)
            Next
        End Sub

        Private Sub DeleteColumnsReport(ByVal grid As DataGridView)
            If grid.ColumnCount < 17 Then Return
            grid.Columns.Remove(grid.Columns(grid.ColumnCount - 1).Name)
            DeleteColumnsReport(grid)
        End Sub

        Private Sub VerificarFaltas()
            Dim cant As Integer
            Dim obs As String
            Dim rep As String
            Dim idu As String
            Dim r = 0
            Try
                If dgvDia.Rows.Count > 0 Then
                    r = 0
                    For Each row As DataGridViewRow In dgvDia.Rows '0|||0
                        If (row.Tag & "").ToString.Trim.Length = 0 Then row.Tag = "0|||0"
                        cant = 0
                        obs = (row.Tag & "").ToString.Trim.Split("|")(1) ' cantrep|observaciones|rp1~rp2~rp3|iduser
                        rep = String.Empty
                        idu = (row.Tag & "").ToString.Trim.Split("|")(3)
                        For i = 16 To dgvDia.ColumnCount - 1
                            If dgvDia.Columns(i).Name.StartsWith("RR") Then
                                rep += If(Convert.ToBoolean(row.Cells(i).Value), "S", "N") & row.Cells(i + 1).Value & "~"
                                If Not Convert.ToBoolean(row.Cells(i).Value) And Not (row.Cells(i + 1).Value & "").Equals("-") Then cant += 1
                            End If
                        Next
                        If rep.EndsWith("~") Then rep = rep.Substring(0, rep.Length - 1)
                        If String.IsNullOrEmpty(idu.Trim) Then idu = _usuario
                        row.Tag = cant & "|" & obs & "|" & rep & "|" & idu
                        r += 1
                    Next
                End If
            Catch ex As Exception
                'MessageBox.Show("ERROR: En VerificarFaltas() DIA, index:" & r & " , " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                KryptonMessageBox.Show("Error: En VerificarFaltas() DIA, index:" & r & " , " & ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
            Try
                If dgvNoche.Rows.Count > 0 Then
                    r = 0
                    For Each row As DataGridViewRow In dgvNoche.Rows
                        If (row.Tag & "").ToString.Trim.Length = 0 Then row.Tag = "0|||0"
                        cant = 0
                        obs = (row.Tag & "").ToString.Trim.Split("|")(1) ' cantrep|observaciones|rp1~rp2~rp3|iduser
                        rep = String.Empty
                        idu = (row.Tag & "").ToString.Trim.Split("|")(3)
                        For i = 16 To dgvNoche.ColumnCount - 1
                            If dgvNoche.Columns(i).Name.StartsWith("RR") Then
                                rep += If(Convert.ToBoolean(row.Cells(i).Value), "S", "N") & row.Cells(i + 1).Value & "~"
                                If Not Convert.ToBoolean(row.Cells(i).Value) And Not (row.Cells(i + 1).Value & "").Equals("-") Then cant += 1
                            End If
                        Next
                        If rep.EndsWith("~") Then rep = rep.Substring(0, rep.Length - 1)
                        If String.IsNullOrEmpty(idu.Trim) Then idu = _usuario
                        row.Tag = cant & "|" & obs & "|" & rep & "|" & idu
                        r += 1
                    Next
                End If
            Catch ex As Exception
                'MessageBox.Show("ERROR: En VerificarFaltas() NOCHE, index:" & r & " , " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                KryptonMessageBox.Show("ERROR: En VerificarFaltas() NOCHE, index:" & r & " , " & ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker4.ValueChanged
            ToolStripMenuItem1_Click(Nothing, Nothing)
        End Sub

        Private Sub dgvDia_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDia.CellDoubleClick
            If dgvDia.RowCount < 0 Then Return
            If e.ColumnIndex > 8 Then Return

            _frmDetail = New FrmReporteObservaciones
            _frmDetail.SoloLectura = True
            _frmDetail.Label3.Text = dgvDia.CurrentRow.Cells(4).Value
            _frmDetail.DateTimePicker5.Value = DateTimePicker5.Value
            VerificarFaltas()

            If (dgvDia.CurrentRow.Tag & "").ToString.Trim.Length = 0 Then dgvDia.CurrentRow.Tag = "0|||0"

            Dim tag = (dgvDia.CurrentRow.Tag & "").ToString.Trim.Split("|") ' cantrep|observaciones|rp1~rp2~rp3~|idu

            _frmDetail.lblCantRep.Text = tag(0).Trim
            _frmDetail.txtObservaciones.Text = tag(1).Trim

            If _frmDetail.ShowDialog = vbOK Then
                dgvDia.CurrentRow.Tag = tag(0).Trim & "|" & _frmDetail.txtObservaciones.Text.Trim.Replace("|", " ") & "|" & tag(2).Trim & "|" & tag(3).Trim

                If _frmDetail.txtObservaciones.Text.Trim.Length > 0 Then
                    dgvDia.CurrentRow.Cells(1).Style.BackColor = Color.LightSkyBlue
                Else
                    dgvDia.CurrentRow.Cells(1).Style.BackColor = dgvDia.CurrentRow.Cells(2).Style.BackColor
                End If

            End If
        End Sub

        Private Sub dgvNoche_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvNoche.CellDoubleClick
            If dgvNoche.RowCount < 0 Then Return
            If e.ColumnIndex > 8 Then Return

            _frmDetail = New FrmReporteObservaciones
            _frmDetail.Label3.Text = dgvNoche.CurrentRow.Cells(4).Value
            _frmDetail.DateTimePicker5.Value = DateTimePicker5.Value
            VerificarFaltas()

            If (dgvDia.CurrentRow.Tag & "").ToString.Trim.Length = 0 Then dgvDia.CurrentRow.Tag = "0|||0"

            Dim tag = (dgvNoche.CurrentRow.Tag & "").ToString.Trim.Split("|") ' cantrep|observaciones|rp1~rp2~rp3~|idu

            _frmDetail.lblCantRep.Text = tag(0).Trim
            _frmDetail.txtObservaciones.Text = tag(1).Trim

            If _frmDetail.ShowDialog = vbOK Then

                dgvNoche.CurrentRow.Tag = tag(0).Trim & "|" & _frmDetail.txtObservaciones.Text.Trim.Replace("|", " ") & "|" & tag(2).Trim & "|" & tag(3).Trim

                If _frmDetail.txtObservaciones.Text.Trim.Length > 0 Then
                    dgvNoche.CurrentRow.Cells(1).Style.BackColor = Color.LightSkyBlue
                Else
                    dgvNoche.CurrentRow.Cells(1).Style.BackColor = dgvNoche.CurrentRow.Cells(2).Style.BackColor
                End If

            End If
        End Sub

        Private Sub dgvDia_DataError(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDia.DataError
            Return
        End Sub

        Private Sub dgvNoche_DataError(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvNoche.DataError
            Return
        End Sub

        Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button6.Click
            Try
                Dim fechaDesde = DateTimePicker7.Value.Day.ToString & "-" & DateTimePicker7.Value.Month.ToString & "-" & DateTimePicker7.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = DateTimePicker6.Value.Day.ToString & "-" & DateTimePicker6.Value.Month.ToString & "-" & DateTimePicker6.Value.Year.ToString & " 23:59:59"

                Dim datos = _objAsignacionPersonal.SeleccionarRegistroAsistenciaDatos(_tipoCon, TextBox1.Text.Trim, fechaDesde, fechaHasta)

                ListView1.Items.Clear()
                ListView1.Groups.Clear()

                Dim group = New ListViewGroup("DETALLE DEL PERSONAL OPERATIVO")
                ListView1.Groups.Add(group)

                ' detalles1
                For Each row As DataRow In datos.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), group)
                    lst.UseItemStyleForSubItems = False

                    For i = 1 To datos.Columns.Count - 1
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next

                    If row.Item(7).ToString.Equals("0") Then lst.SubItems(2).BackColor = Color.FromArgb(255, 240, 128, 128)

                    ListView1.Items.Add(lst)
                Next

                ListView1.Items(0).Selected = True
                ListView1.Select()

            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub ExportarDatosExcel(ByVal listViewExp As ListView, ByVal titulo As String)
            Try
                Dim app As Excel._Application = New Excel.Application()
                Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

                worksheet.Name = "REPORTE"

                worksheet.Range("A1:I" & listViewExp.Items.Count + listViewExp.Items.Count + 25).Font.Size = 10

                Dim ic As String = If(listViewExp.Name.Contains("1"), "H", "F")

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
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Impresión: " + Date.Now
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                Dim dataGridViewExpRowCount As Integer = listViewExp.Items.Cast(Of ListViewItem)().Count()

                'Aca se agregan las cabeceras de nuestro datagrid.
                Dim head As Integer
                Dim foot As Integer
                head = 4
                foot = head + dataGridViewExpRowCount + 2

                For i As Integer = 1 To listViewExp.Columns.Count
                    worksheet.Cells(1 + head, i) = listViewExp.Columns(i - 1).Text
                    worksheet.Cells(1 + head, i).Font.Bold = True
                    worksheet.Cells(1 + head, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(1 + head, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(1 + head, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(1 + head, i).Font.Color = Color.White
                Next

                dataGridViewExpRowCount = 0
                For Each row As ListViewItem In listViewExp.Items
                    For j As Integer = 0 To listViewExp.Columns.Count - 1
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1) = row.SubItems(j).Text

                        ' definir bordes
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If dataGridViewExpRowCount = listViewExp.Items.Count - 1 Then
                            worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                    Next

                    dataGridViewExpRowCount += 1
                Next

                worksheet.Range("A1:I" & listViewExp.Items.Count + listViewExp.Items.Count + 25).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button7.Click
            ExportarDatosExcel(ListView1, "ASISTENCIA DIAS PUESTOS")
        End Sub

        Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged
            If ListView1.SelectedItems.Count = 0 Then Return
            If ListView1.Items.Count = 0 Then Return

            ListView3.Items.Clear()
            ListView3.Groups.Clear()

            Dim fechaDesde = DateTimePicker7.Value.Day.ToString & "-" & DateTimePicker7.Value.Month.ToString & "-" & DateTimePicker7.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = DateTimePicker6.Value.Day.ToString & "-" & DateTimePicker6.Value.Month.ToString & "-" & DateTimePicker6.Value.Year.ToString & " 23:59:59"

            Dim x = CDate(ListView1.SelectedItems(0).SubItems(4).Text)
            Dim fechain = x.Day.ToString & "-" & x.Month.ToString & "-" & x.Year.ToString & " 00:00:00"
            Dim fechaIngreso = If(CDate(fechaDesde) > CDate(fechain), fechaDesde, fechain)

            Dim s = CDate(ListView1.SelectedItems(0).SubItems(5).Text)
            Dim fechaou = s.Day.ToString & "-" & s.Month.ToString & "-" & s.Year.ToString & " 00:00:00"
            Dim fechaSalida = If(CDate(fechaou) < CDate(fechain), fechaHasta, If(CDate(fechaHasta) > CDate(fechaou), fechaou, fechaHasta))

            Dim vigia = _objAsignacionPersonal.SeleccionarRegistroAsistenciaDetallesByGuardia(_tipoCon, True, ListView1.SelectedItems(0).SubItems(0).Text, fechaDesde, fechaHasta, fechaIngreso, fechaSalida)

            Dim group = New ListViewGroup("DETALLE DE ASISTENCIA")
            ListView3.Groups.Add(group)
            For Each row As DataRow In vigia.Rows
                Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), group)
                lst.UseItemStyleForSubItems = False

                For i = 1 To vigia.Columns.Count - 1

                    If i = 1 Then
                        lst.SubItems.Add(row.Item(i).ToString.Split(" ")(0).Trim)
                    ElseIf i = 3 Then
                        If row.Item(3).ToString().Equals("31") Or row.Item(3).ToString().Equals("33") Then
                            row.Item(i) = "PERMISO MÉDICO"
                        ElseIf row.Item(3).ToString().Equals("32") Then
                            row.Item(i) = "CALAMIDAD DOMÉSTICA"
                        ElseIf row.Item(3).ToString().Equals("34") Then
                            row.Item(i) = "VACACIONES"
                        End If

                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))

                        If row.Item(i).ToString.Equals("ASISTENCIA") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 34, 139, 34)
                        If row.Item(i).ToString.Equals("LIBRE") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 135, 206, 250)
                        If row.Item(i).ToString.Equals("INASISTENCIA") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 240, 128, 128)
                        If row.Item(i).ToString.Equals("DOBLADA") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 255, 218, 155)
                        If row.Item(i).ToString.Equals("ATRASO") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 255, 218, 155)
                        If row.Item(i).ToString.Equals("VACACIONES") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 135, 206, 235)
                        If row.Item(i).ToString.Equals("PERMISO MÉDICO") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 255, 218, 155)
                        If row.Item(i).ToString.Equals("CALAMIDAD DOMÉSTICA") Then lst.SubItems(3).BackColor = Color.FromArgb(255, 255, 218, 155)
                        lst.SubItems(3).ForeColor = Color.Black
                    Else
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    End If

                Next
                ListView3.Items.Add(lst)
            Next
        End Sub

        Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button10.Click
            ExportarDatosExcel(ListView3, "DETALLE POR VIGILANTE")
        End Sub

        Private Function NumToCharExcel(ByVal i As Integer) As String
            Dim data() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", _
                          "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", _
                          "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ"}
            Return data(i)
        End Function

        Private Sub EXPORTARDATOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EXPORTARDATOSToolStripMenuItem.Click

            _hoy = ValidationForms.FechaActual(_tipoCon)
            Try

                Dim app As Excel._Application = New Excel.Application()
                Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheetd As Excel._Worksheet = Nothing
                Dim worksheetn As Excel._Worksheet = Nothing

                If workbook.Sheets.Count = 1 Then workbook.Sheets.Add()

                worksheetd = workbook.Sheets("Hoja1")
                worksheetn = workbook.Sheets("Hoja2")

                worksheetd.Name = "ASISTENCIA DIURNA"
                worksheetn.Name = "ASISTENCIA NOCTURNA"

                Dim ld = -1
                For i = 0 To dgvDia.Columns.Count - 1
                    If dgvDia.Columns(i).Visible Then ld += 1
                Next
                Dim id = NumToCharExcel(ld + 1)

                Dim ln = -1
                For i = 0 To dgvNoche.Columns.Count - 1
                    If dgvNoche.Columns(i).Visible Then ln += 1
                Next
                Dim io = NumToCharExcel(ln + 1)

                worksheetd.Range("A1:" & id & dgvDia.RowCount + 25).Font.Size = 10
                worksheetn.Range("A1:" & io & dgvNoche.RowCount + 25).Font.Size = 10

                worksheetd.Range("A1:" & id & "1").Merge()
                worksheetd.Range("A1:" & id & "1").Value = ValidationForms.NombreCompany(_tipoCon)
                worksheetd.Range("A1:" & id & "1").Font.Bold = True
                worksheetd.Range("A1:" & id & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheetd.Range("A1:" & id & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheetd.Range("A1:" & id & "1").Font.Color = Color.White
                worksheetd.Range("A1:" & id & "1").Font.Size = 12
                worksheetd.Range("A2:" & id & "2").Merge()
                worksheetd.Range("A2:" & id & "2").Value = "REPORTE ASISTENCIA"
                worksheetd.Range("A2:" & id & "2").Font.Size = 12
                worksheetd.Range("A4:" & id & "4").Merge()
                worksheetd.Range("A4:" & id & "4").Value = "Fecha: " & DateTimePicker5.Value & "              Fecha de Impresión: " & Date.Now
                worksheetd.Range("A4:" & id & "4").Font.Size = 12

                worksheetn.Range("A1:" & io & "1").Merge()
                worksheetn.Range("A1:" & io & "1").Value = ValidationForms.NombreCompany(_tipoCon)
                worksheetn.Range("A1:" & io & "1").Font.Bold = True
                worksheetn.Range("A1:" & io & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheetn.Range("A1:" & io & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheetn.Range("A1:" & io & "1").Font.Color = Color.White
                worksheetn.Range("A1:" & io & "1").Font.Size = 12
                worksheetn.Range("A2:" & io & "2").Merge()
                worksheetn.Range("A2:" & io & "2").Value = "REPORTE ASISTENCIA"
                worksheetn.Range("A2:" & io & "2").Font.Size = 12
                worksheetn.Range("A4:" & io & "4").Merge()
                worksheetn.Range("A4:" & io & "4").Value = "Fecha: " & DateTimePicker5.Value & "              Fecha de Impresión: " & Date.Now
                worksheetn.Range("A4:" & io & "4").Font.Size = 12

                Dim headd = 6

                Dim headn = 6

                Dim x = 1
                For i = 0 To dgvDia.Columns.Count
                    If i >= dgvDia.Columns.Count Then
                        worksheetd.Cells(headd, x) = "OBSERVACIÓN"
                        worksheetd.Cells(headd, x).Font.Bold = True
                        worksheetd.Cells(headd, x).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheetd.Cells(headd, x).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        worksheetd.Cells(headd, x).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                        worksheetd.Cells(headd, x).Font.Color = Color.White
                        Exit For
                    End If

                    If Not dgvDia.Columns(i).Visible Then Continue For
                    worksheetd.Cells(headd, x) = dgvDia.Columns(i).HeaderText
                    worksheetd.Cells(headd, x).Font.Bold = True
                    worksheetd.Cells(headd, x).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheetd.Cells(headd, x).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheetd.Cells(headd, x).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheetd.Cells(headd, x).Font.Color = Color.White
                    x += 1
                Next

                x = 1
                For i = 0 To dgvNoche.Columns.Count
                    If (i >= dgvNoche.Columns.Count) Then
                        worksheetn.Cells(headn, x) = "OBSERVACIÓN"
                        worksheetn.Cells(headn, x).Font.Bold = True
                        worksheetn.Cells(headn, x).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheetn.Cells(headn, x).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        worksheetn.Cells(headn, x).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                        worksheetn.Cells(headn, x).Font.Color = Color.White
                        Exit For
                    End If

                    If Not dgvNoche.Columns(i).Visible Then Continue For
                    worksheetn.Cells(headn, x) = dgvNoche.Columns(i).HeaderText
                    worksheetn.Cells(headn, x).Font.Bold = True
                    worksheetn.Cells(headn, x).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheetn.Cells(headn, x).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheetn.Cells(headn, x).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheetn.Cells(headn, x).Font.Color = Color.White
                    x += 1
                Next

                Dim y As Integer
                headd = 7
                For Each row As DataGridViewRow In dgvDia.Rows
                    y = 1
                    For j As Integer = 0 To dgvDia.Columns.Count - 1
                        If Not dgvDia.Columns(j).Visible Then Continue For
                        worksheetd.Cells(headd, y) = (row.Cells(j).Value & "")

                        If j > 10 Then
                            If dgvDia.Columns(j).Name.StartsWith("RR") Then
                                If (row.Cells(j).Value & "").ToString.Equals("True") Then
                                    worksheetd.Cells(headd, y) = "*"
                                Else
                                    If (row.Cells(j + 1).Value & "").ToString.Equals("-") Then
                                        worksheetd.Cells(headd, y) = "-"
                                    Else
                                        worksheetd.Cells(headd, y) = "S/R"
                                    End If
                                End If
                            End If
                            worksheetd.Cells(headd, y).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        End If

                        ' definir bordes
                        worksheetd.Cells(headd, y).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheetd.Cells(headd, y).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If headd = dgvDia.RowCount + 6 Then
                            worksheetd.Cells(headd, y).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            worksheetd.Cells(headd, y).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            worksheetd.Cells(headd, y + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            worksheetd.Cells(headd, y + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        y += 1
                    Next
                    worksheetd.Cells(headd, y) = row.Tag.ToString.Split("|")(1)
                    worksheetd.Cells(headd, y).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                    headd += 1

                Next

                headn = 7
                For Each row As DataGridViewRow In dgvNoche.Rows
                    y = 1
                    For j As Integer = 0 To dgvNoche.Columns.Count - 1
                        If Not dgvNoche.Columns(j).Visible Then Continue For
                        worksheetn.Cells(headn, y) = (row.Cells(j).Value & "")

                        If j > 10 Then
                            If dgvNoche.Columns(j).Name.StartsWith("RR") Then
                                If (row.Cells(j).Value & "").ToString.Equals("True") Then
                                    worksheetn.Cells(headn, y) = "*"
                                Else
                                    If (row.Cells(j + 1).Value & "").ToString.Equals("-") Then
                                        worksheetn.Cells(headn, y) = "-"
                                    Else
                                        worksheetn.Cells(headn, y) = "S/R"
                                    End If
                                End If
                            End If
                            worksheetn.Cells(headn, y).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        End If

                        ' definir bordes
                        worksheetn.Cells(headn, y).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheetn.Cells(headn, y).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If headn = dgvNoche.RowCount + 6 Then
                            worksheetn.Cells(headn, y).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            worksheetn.Cells(headn, y).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            worksheetn.Cells(headn, y + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                            worksheetn.Cells(headn, y + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                        y += 1
                    Next
                    worksheetn.Cells(headn, y) = row.Tag.ToString.Split("|")(1)
                    worksheetn.Cells(headn, y).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous

                    headn += 1

                Next

                worksheetd.Range("A1:" & id & dgvDia.RowCount + 25).Columns.AutoFit()
                worksheetn.Range("A1:" & io & dgvNoche.RowCount + 25).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Error al exportar datos! " & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Button6_Click(Nothing, Nothing)
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
            Try

                If DateTimePicker8.Value.Year <> DateTimePicker3.Value.Year Then
                    'MessageBox.Show("Rango de consulta debe ser del mismo año!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    KryptonMessageBox.Show("Rango de consulta debe ser del mismo año!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If

                ' select cliente
                Dim idc = If(txtIdCliente.Text.Trim.Length = 0, 0, CInt(txtIdCliente.Text))
                If idc = 0 Then
                    'MessageBox.Show("Por favor, seleccione un cliente!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    KryptonMessageBox.Show("Por favor, seleccione un cliente!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If

                ' año - utilidades

                Dim fechaDesde = DateTimePicker8.Value.ToString("yyyy-MM-dd 00:00:00")
                Dim fechaHasta = DateTimePicker3.Value.ToString("yyyy-MM-dd 23:59:59")

                ' xiii
                Dim desdeXiii = New DateTime(DateTimePicker13.Value.Year - 1, 12, 1)
                Dim hastaXiii = New DateTime(DateTimePicker13.Value.Year, 11, 30)

                ' xiv
                Dim desdeXiv = New DateTime(DateTimePicker13.Value.Year - 1, 3, 1)
                Dim hastaXiv = New DateTime(DateTimePicker13.Value.Year, 2, 28)

                If DateTime.IsLeapYear(DateTimePicker3.Value.Year) Then
                    hastaXiv = New DateTime(DateTimePicker13.Value.Year, 2, 29)
                End If

                dgvUtilidades.Rows.Clear()
                Dim utilidades = _objAsignacionPersonal.SeleccionarReporteParaUtilidadesByAnio(_tipoCon, fechaDesde, fechaHasta, desdeXiii, hastaXiii, desdeXiv, hastaXiv)
                Dim gan As String
                Dim fres As String
                Dim xiii As String
                Dim xiv As String
                For Each d As DataRow In utilidades.Rows
                    gan = Convert.ToDecimal(d(15)).ToString("N")
                    fres = Convert.ToDecimal(d(16)).ToString("N")
                    If d(12).ToString().Trim().Length = 0 Then
                        xiii = 0.ToString("N")
                    Else
                        xiii = Convert.ToDecimal(d(12)).ToString("N")
                    End If
                    If d(13).ToString().Trim().Length = 0 Then
                        xiv = 0.ToString("N")
                    Else
                        xiv = Convert.ToDecimal(d(13)).ToString("N")
                    End If
                    dgvUtilidades.Rows.Add(d(0), d(1), d(2), d(3), d(4), d(5), d(6),
                                           d(7), d(8), d(9), d(10), d(11), xiii, xiv, d(14), gan, fres, 0, 0, 0, 0, 0, String.Empty, "P")
                Next
                'lblCantidad3.Text = dgvUtilidades.RowCount & " REGISTROS EN TOTAL"



                ' REPORTES POR CLIENTE
                Dim vigia = _objAsignacionPersonal.SeleccionarReporteParaUtilidadesByFechas(_tipoCon, fechaDesde, fechaHasta, idc, TextBox2.Text)

                DataGridView1.AutoResizeColumns()
                DataGridView1.AutoResizeRows()

                DataGridView1.DataSource = vigia
                DataGridView1.Columns(0).Width = 90
                DataGridView1.Columns(0).DefaultCellStyle.Format = "d"
                DataGridView1.Columns(1).Width = 90
                DataGridView1.Columns(2).Width = 250
                DataGridView1.Columns(3).HeaderText = "ENTRADA"
                DataGridView1.Columns(3).Width = 90
                DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DataGridView1.Columns(3).DefaultCellStyle.Format = "d"
                DataGridView1.Columns(4).HeaderText = "SALIDA"
                DataGridView1.Columns(4).Width = 90
                DataGridView1.Columns(4).DefaultCellStyle.Format = "d"
                DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DataGridView1.Columns(5).Width = 250
                DataGridView1.Columns(6).Width = 90
                DataGridView1.Columns(7).Width = 90
                DataGridView1.Columns(8).Width = 250

                For f = 0 To DataGridView1.Rows.Count - 1
                    If (DataGridView1.Rows(f).Cells(4).Value & "").ToString().Trim().Length = 0 Then Continue For
                    If CDate(DataGridView1.Rows(f).Cells(4).Value) <= CDate("1990-01-01 00:00:00") Then
                        DataGridView1.Rows(f).Cells(4).Value = "-"
                    Else
                        DataGridView1.Rows(f).DefaultCellStyle.BackColor = Color.Salmon
                    End If
                Next

                Dim meses = If(idc = 0,
                               _objAsignacionPersonal.SeleccionarReporteParaUtilidadesByMesesTodoAsistencia(_tipoCon, DateTimePicker8.Value.Year, DateTimePicker8.Value.Month, DateTimePicker3.Value.Month, idc, TextBox2.Text),
                               _objAsignacionPersonal.SeleccionarReporteParaUtilidadesByMesesAsistencia(_tipoCon, DateTimePicker8.Value.Year, DateTimePicker8.Value.Month, DateTimePicker3.Value.Month, idc, TextBox2.Text))

                meses.Rows.Add()

                DataGridView2.AutoResizeColumns()
                DataGridView2.AutoResizeRows()
                DataGridView2.DataSource = meses

                DataGridView2.Columns(0).Width = 50
                DataGridView2.Columns(0).HeaderText = "ID"
                DataGridView2.Columns(1).Width = 200
                DataGridView2.Columns(1).HeaderText = "NÓMINA"
                DataGridView2.Columns(2).Width = 90
                DataGridView2.Columns(2).HeaderText = "CÉDULA"
                DataGridView2.Columns(3).Width = 200
                DataGridView2.Columns(3).HeaderText = "UBICACIÓN / CLIENTE "
                DataGridView2.Columns(3).Frozen = True
                DataGridView2.Columns(4).Width = 90
                DataGridView2.Columns(4).HeaderText = "ENTRADA"
                DataGridView2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DataGridView2.Columns(5).Width = 90
                DataGridView2.Columns(5).HeaderText = "SALIDA"
                DataGridView2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Dim t As Integer
                For f = 0 To DataGridView2.Rows.Count - 2
                    t = 0
                    For c = 6 To DataGridView2.Columns.Count - 2
                        t += CInt(DataGridView2.Rows(f).Cells(c).Value)
                    Next
                    DataGridView2.Rows(f).Cells(DataGridView2.Columns.Count - 1).Value = t
                    If CDate(DataGridView2.Rows(f).Cells(5).Value) <= CDate("1990-01-01 00:00:00") Then
                        DataGridView2.Rows(f).Cells(5).Value = "-"
                    Else
                        DataGridView2.Rows(f).DefaultCellStyle.BackColor = Color.Salmon
                    End If
                Next

                For c = 6 To DataGridView2.Columns.Count - 1
                    DataGridView2.Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    t = 0
                    For f = 0 To DataGridView2.Rows.Count - 2
                        t += CInt(DataGridView2.Rows(f).Cells(c).Value)
                    Next
                    DataGridView2.Rows(DataGridView2.Rows.Count - 1).Cells(c).Value = t
                Next


                DataGridView2.Rows(DataGridView2.Rows.Count - 1).Cells(3).Value = "TOTAL"
                DataGridView2.Columns(DataGridView2.ColumnCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                DataGridView2.Rows(DataGridView2.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)


                For f = 0 To DataGridView2.Rows.Count - 2
                    If DataGridView2.Rows(f).Cells(5).Value.ToString.Trim <> "-" Then DataGridView2.Rows(f).DefaultCellStyle.BackColor = Color.Salmon
                Next


                DataGridView3.DataSource = Nothing
                If idc <> 0 Then
                    meses = _objAsignacionPersonal.SeleccionarReporteParaUtilidadesByMesesAsistenciaPuesto(_tipoCon, DateTimePicker8.Value.Year, DateTimePicker8.Value.Month, DateTimePicker3.Value.Month, idc, TextBox2.Text)
                    meses.Rows.Add()

                    DataGridView3.AutoResizeColumns()
                    DataGridView3.AutoResizeRows()
                    DataGridView3.DataSource = meses

                    DataGridView3.Columns(0).Width = 50
                    DataGridView3.Columns(0).HeaderText = "ID"
                    DataGridView3.Columns(1).Width = 200
                    DataGridView3.Columns(1).HeaderText = "NÓMINA"
                    DataGridView3.Columns(2).Width = 90
                    DataGridView3.Columns(2).HeaderText = "CÉDULA"
                    DataGridView3.Columns(3).Width = 200
                    DataGridView3.Columns(3).HeaderText = "UBICACIÓN / CLIENTE "
                    DataGridView3.Columns(3).Frozen = True
                    DataGridView3.Columns(4).Width = 90
                    DataGridView3.Columns(4).HeaderText = "ENTRADA"
                    DataGridView3.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGridView3.Columns(5).Width = 90
                    DataGridView3.Columns(5).HeaderText = "SALIDA"
                    DataGridView3.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    For f = 0 To DataGridView3.Rows.Count - 2
                        t = 0
                        For c = 6 To DataGridView3.Columns.Count - 2
                            t += CInt(DataGridView3.Rows(f).Cells(c).Value)
                        Next
                        DataGridView3.Rows(f).Cells(DataGridView3.Columns.Count - 1).Value = t
                        If CDate(DataGridView3.Rows(f).Cells(5).Value) <= CDate("1990-01-01 00:00:00") Then DataGridView3.Rows(f).Cells(5).Value = "-"

                    Next

                    For c = 6 To DataGridView3.Columns.Count - 1
                        DataGridView3.Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        t = 0
                        For f = 0 To DataGridView3.Rows.Count - 2
                            t += CInt(DataGridView3.Rows(f).Cells(c).Value)
                        Next
                        DataGridView3.Rows(DataGridView3.Rows.Count - 1).Cells(c).Value = t
                    Next

                    DataGridView3.Rows(DataGridView3.Rows.Count - 1).Cells(3).Value = "TOTAL"
                    DataGridView3.Columns(DataGridView3.ColumnCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                    DataGridView3.Rows(DataGridView3.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)

                    For f = 0 To DataGridView3.Rows.Count - 2
                        If DataGridView3.Rows(f).Cells(5).Value.ToString.Trim <> "-" Then DataGridView3.Rows(f).DefaultCellStyle.BackColor = Color.Salmon
                    Next

                End If

            Catch
                dgvUtilidades.Rows.Clear()
                DataGridView1.DataSource = Nothing
                DataGridView2.DataSource = Nothing
            End Try
        End Sub

        Private Sub bntPuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntPuesto.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.rbtCliente.Checked = True
            frm.rbtPersonal.Visible = False
            frm.rbtProveedor.Visible = False
            frm.Todos = False

            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width

            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtCliente.Checked Then
                        txtIdCliente.Tag = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtIdCliente.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtSitio.Text = frm.dgvCustodios.CurrentRow.Cells.Item(3).Value & " - " & frm.dgvCustodios.CurrentRow.Cells.Item(5).Value
                        txtCliente.Text = frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                    End If
                End If
            Catch ex As Exception
                txtIdCliente.Text = ""
                txtSitio.Text = ""
                txtCliente.Text = ""
                txtIdCliente.Tag = ""
            End Try
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click 
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "UTILIDADES"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(DataGridView1)
                worksheet.Range("A1:" & ic & (DataGridView1.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  REPORTE PARA UTILIDADES"
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & DateTimePicker8.Value.ToLongDateString().ToUpper() & "  AL " & DateTimePicker3.Value.ToLongDateString().ToUpper()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString().ToUpper() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To DataGridView1.Columns.Count - 1
                    If Not DataGridView1.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = DataGridView1.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To DataGridView1.Rows.Count - 1
                    indc = 1
                    For j = 0 To DataGridView1.Columns.Count - 1

                        If Not DataGridView1.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = DataGridView1.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = DataGridView1.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next
 
                worksheet.Range("A1:" & ic & (DataGridView1.RowCount + 50)).Columns.AutoFit()

                Dim position = CType(worksheet.Cells(2, 7), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.paste(position)

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!" & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "REPORTE_UTIL"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(DataGridView2)
                worksheet.Range("A1:" & ic & (DataGridView2.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  REPORTE ASISTENCIA POR CLIENTE"
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & DateTimePicker8.Value.ToLongDateString().ToUpper() & "  AL " & DateTimePicker3.Value.ToLongDateString().ToUpper()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString().ToUpper() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To DataGridView2.Columns.Count - 1
                    If Not DataGridView2.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = DataGridView2.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To DataGridView2.Rows.Count - 1
                    indc = 1
                    For j = 0 To DataGridView2.Columns.Count - 1

                        If Not DataGridView2.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = DataGridView2.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = DataGridView2.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (DataGridView2.RowCount + 50)).Columns.AutoFit()

                Dim position = CType(worksheet.Cells(2, 7), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.paste(position)

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!" & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ' decimo 3
        Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar3.Click
            Try
                dgvDecimo3.Rows.Clear()
                'Dim vigia = _objAsignacionPersonal.SeleccionarReportePara10Mo3ByAnio(_tipoCon, dtpDecimo3.Value.Year, DateTimePicker9.Value.Month, DateTimePicker9.Value.Day, DateTimePicker10.Value.Month, DateTimePicker10.Value.Day)
                Dim vigia = _objAsignacionPersonal.SeleccionarReportePara10Mo3ByAnio(_tipoCon, DateTimePicker9.Value, DateTimePicker10.Value)
                Dim t As String
                For Each d As DataRow In vigia.Rows
                    t = Convert.ToDecimal(d(5)).ToString("N")

                    dgvDecimo3.Rows.Add(d(0), d(1), d(2), d(3), d(4), t, d(6), d(7), d(8), d(9), d(10), d(11), d(12))
                Next
                lblCantidad3.Text = dgvDecimo3.RowCount & " REGISTROS EN TOTAL"
            Catch
                dgvDecimo3.DataSource = Nothing
                lblCantidad3.Text = "0 REGISTROS EN TOTAL"
            End Try
        End Sub

        Private Sub TextBox2_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBuscarDecimo3.KeyUp
            If txtBuscarDecimo3.Text.Trim().Length = 0 Then
                _indices3.Clear()
                btnAnt3.Tag = 0
                btnSig3.Tag = 0
                dgvDecimo3.Rows(0).Selected = True
                dgvDecimo3.FirstDisplayedScrollingRowIndex = 0
                Return
            End If

            If e.KeyCode <> Keys.Enter Or dgvDecimo3.RowCount = 0 Then Return

            _indices3.Clear()

            For Each row As DataGridViewRow In dgvDecimo3.Rows
                If (row.Cells(0).Value + "").ToString().Trim().Contains(txtBuscarDecimo3.Text.Trim) Or _
                    (row.Cells(1).Value + "").ToString().Trim().Contains(txtBuscarDecimo3.Text.Trim) Or _
                    (row.Cells(2).Value + "").ToString().Trim().Contains(txtBuscarDecimo3.Text.Trim) Then
                    _indices3.Add(row.Index)
                End If
            Next

            If _indices3.Count = 0 Then
                btnAnt3.Tag = 0
                btnSig3.Tag = 0
                dgvDecimo3.Rows(0).Selected = True
                dgvDecimo3.FirstDisplayedScrollingRowIndex = 0
                lblCoincidencias3.Text = "No hay coincidencias..."
            Else
                btnAnt3.Tag = 0
                btnSig3.Tag = 0
                dgvDecimo3.Rows(_indices3(0)).Selected = True
                dgvDecimo3.FirstDisplayedScrollingRowIndex = _indices3(0)
                If _indices3.Count > 1 Then
                    btnAnt3.Tag = 0
                    btnSig3.Tag = 1
                End If
                lblCoincidencias3.Text = "1 de " & _indices3.Count & " resultado(s)..."
            End If
        End Sub

        Private Sub btnAnt_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnt3.Click
            If _indices3.Count = 0 Or dgvDecimo3.RowCount = 0 Then Return
            If CInt(btnAnt3.Tag) < 0 Then Return

            dgvDecimo3.Rows(_indices3(CInt(btnAnt3.Tag))).Selected = True
            dgvDecimo3.FirstDisplayedScrollingRowIndex = _indices3(CInt(btnAnt3.Tag))

            btnSig3.Tag = CInt(btnAnt3.Tag)
            btnAnt3.Tag = (CInt(btnAnt3.Tag) - 1)
            lblCoincidencias3.Text = (CInt(btnSig3.Tag) + 1) & "  de " & _indices3.Count & " resultado(s)..."
        End Sub

        Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSig3.Click
            If _indices3.Count = 0 Or dgvDecimo3.RowCount = 0 Then Return
            If CInt(btnSig3.Tag) > _indices3.Count - 1 Then Return

            dgvDecimo3.Rows(_indices3(CInt(btnSig3.Tag))).Selected = True
            dgvDecimo3.FirstDisplayedScrollingRowIndex = _indices3(CInt(btnSig3.Tag))

            If CInt(btnSig3.Tag) < _indices3.Count Then
                btnAnt3.Tag = CInt(btnSig3.Tag)
                btnSig3.Tag = (CInt(btnSig3.Tag) + 1)
                lblCoincidencias3.Text = (CInt(btnAnt3.Tag) + 1) & "  de " & _indices3.Count & " resultado(s)..."
            End If
        End Sub

        Private Sub btnExp3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExp3.Click
            Try
                Dim sfd = New SaveFileDialog
                sfd.Filter = "CSV Files (*.csv)|*.csv"
                sfd.Title = "EXPORTAR A EXCEL"
                sfd.FileName = "10MO3RO_MENSUALIZACION_" & dtpDecimo3.Value.Year & ".csv"
                If sfd.ShowDialog() <> DialogResult.OK Then Return

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "10MO3RCONMENSUALIZACION"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvDecimo3)
                worksheet.Range("A1:" & ic & (dgvDecimo3.RowCount + 50)).Font.Size = 10

                ''Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 1
                For i = 0 To dgvDecimo3.Columns.Count - 1
                    If Not dgvDecimo3.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvDecimo3.Columns(i).HeaderText
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvDecimo3.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvDecimo3.Columns.Count - 1
                        If Not dgvDecimo3.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = dgvDecimo3.Rows(i).Cells(j).Value
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvDecimo3.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True

                workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlCSV, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos 10MO3RO!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            Try
                Dim filePath As String = "10MO3RO_MENSUALIZACION_" & dtpDecimo3.Value.Year & ".csv"
                Const delimeter = ","
                Dim sb As New StringBuilder
                For i = 0 To dgvDecimo3.Rows.Count - 1
                    Dim array = New String(dgvDecimo3.Columns.Count - 1) {}
                    If i.Equals(0) Then
                        For j = 0 To dgvDecimo3.Columns.Count - 1
                            array(j) = dgvDecimo3.Columns(j).HeaderText
                        Next
                        sb.AppendLine(String.Join(delimeter, array))
                    End If
                    For j = 0 To dgvDecimo3.Columns.Count - 1
                        If Not dgvDecimo3.Rows(i).IsNewRow Then array(j) = dgvDecimo3(j, i).Value.ToString
                    Next
                    If Not dgvDecimo3.Rows(i).IsNewRow Then sb.AppendLine(String.Join(delimeter, array))
                Next
                File.WriteAllText(filePath, sb.ToString)

                Process.Start(filePath)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos 10MO3RO!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ' decimo 4
        Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar4.Click
            Try
                dgvDecimo4.Rows.Clear()
                Dim vigia = _objAsignacionPersonal.SeleccionarReportePara10Mo4ByAnio(_tipoCon, DateTimePicker12.Value, DateTimePicker11.Value)
                For Each d As DataRow In vigia.Rows
                    dgvDecimo4.Rows.Add(d(0), d(1), d(2), d(3), d(4), d(6), d(7), d(8), d(9), d(10), String.Empty, d(11), d(12))
                Next
                lblCantidad4.Text = dgvDecimo3.RowCount & " REGISTROS EN TOTAL"
            Catch
                dgvDecimo4.DataSource = Nothing
                lblCantidad4.Text = "0 REGISTROS EN TOTAL"
            End Try
        End Sub

        Private Sub TextBox4_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarDecimo4.KeyUp
            If txtBuscarDecimo4.Text.Trim().Length = 0 Then
                _indices4.Clear()
                btnAnt4.Tag = 0
                btnSig4.Tag = 0
                dgvDecimo4.Rows(0).Selected = True
                dgvDecimo4.FirstDisplayedScrollingRowIndex = 0
                Return
            End If

            If e.KeyCode <> Keys.Enter Or dgvDecimo4.RowCount = 0 Then Return

            _indices4.Clear()

            For Each row As DataGridViewRow In dgvDecimo4.Rows
                If (row.Cells(0).Value + "").ToString().Trim().Contains(txtBuscarDecimo4.Text.Trim) Or _
                    (row.Cells(1).Value + "").ToString().Trim().Contains(txtBuscarDecimo4.Text.Trim) Or _
                    (row.Cells(2).Value + "").ToString().Trim().Contains(txtBuscarDecimo4.Text.Trim) Then
                    _indices4.Add(row.Index)
                End If
            Next

            If _indices4.Count = 0 Then
                btnAnt4.Tag = 0
                btnSig4.Tag = 0
                dgvDecimo4.Rows(0).Selected = True
                dgvDecimo4.FirstDisplayedScrollingRowIndex = 0
                lblCoincidencias4.Text = "No hay coincidencias..."
            Else
                btnAnt4.Tag = 0
                btnSig4.Tag = 0
                dgvDecimo4.Rows(_indices4(0)).Selected = True
                dgvDecimo4.FirstDisplayedScrollingRowIndex = _indices4(0)
                If _indices4.Count > 1 Then
                    btnAnt4.Tag = 0
                    btnSig4.Tag = 1
                End If
                lblCoincidencias4.Text = "1 de " & _indices4.Count & " resultado(s)..."
            End If
        End Sub

        Private Sub btnAnt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnt4.Click
            If _indices4.Count = 0 Or dgvDecimo4.RowCount = 0 Then Return
            If CInt(btnAnt4.Tag) < 0 Then Return

            dgvDecimo4.Rows(_indices4(CInt(btnAnt4.Tag))).Selected = True
            dgvDecimo4.FirstDisplayedScrollingRowIndex = _indices4(CInt(btnAnt4.Tag))

            btnSig4.Tag = CInt(btnAnt4.Tag)
            btnAnt4.Tag = (CInt(btnAnt4.Tag) - 1)
            lblCoincidencias4.Text = (CInt(btnSig4.Tag) + 1) & "  de " & _indices4.Count & " resultado(s)..."
        End Sub

        Private Sub btnSig4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig4.Click
            If _indices4.Count = 0 Or dgvDecimo4.RowCount = 0 Then Return
            If CInt(btnSig4.Tag) > _indices4.Count - 1 Then Return

            dgvDecimo4.Rows(_indices4(CInt(btnSig4.Tag))).Selected = True
            dgvDecimo4.FirstDisplayedScrollingRowIndex = _indices4(CInt(btnSig4.Tag))

            If CInt(btnSig4.Tag) < _indices4.Count Then
                btnAnt4.Tag = CInt(btnSig4.Tag)
                btnSig4.Tag = (CInt(btnSig4.Tag) + 1)
                lblCoincidencias4.Text = (CInt(btnAnt4.Tag) + 1) & "  de " & _indices4.Count & " resultado(s)..."
            End If
        End Sub

        Private Sub btnExportar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                Dim filePath As String = "10MO4TO_MENSUALIZACION_" & dtpDecimo4.Value.Year & ".csv"
                Const delimeter = ","
                Dim sb As New StringBuilder
                For i = 0 To dgvDecimo4.Rows.Count - 1
                    Dim array = New String(dgvDecimo4.Columns.Count - 1) {}
                    If i.Equals(0) Then
                        For j = 0 To dgvDecimo4.Columns.Count - 1
                            array(j) = dgvDecimo4.Columns(j).HeaderText
                        Next
                        sb.AppendLine(String.Join(delimeter, array))
                    End If
                    For j = 0 To dgvDecimo4.Columns.Count - 1
                        If Not dgvDecimo4.Rows(i).IsNewRow Then array(j) = dgvDecimo4(j, i).Value.ToString
                    Next
                    If Not dgvDecimo4.Rows(i).IsNewRow Then sb.AppendLine(String.Join(delimeter, array))
                Next
                File.WriteAllText(filePath, sb.ToString)

                Process.Start(filePath)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos 10MO4TO!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExp4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExp4.Click
            Try
                Dim sfd = New SaveFileDialog
                sfd.Filter = "CSV Files (*.csv)|*.csv"
                sfd.Title = "EXPORTAR A EXCEL"
                sfd.FileName = "10MO4TO_MENSUALIZACION_" & dtpDecimo3.Value.Year & ".csv"
                If sfd.ShowDialog() <> DialogResult.OK Then Return

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "10MO4TCONMENSUALIZACION"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvDecimo4)
                worksheet.Range("A1:" & ic & (dgvDecimo4.RowCount + 50)).Font.Size = 10

                ''Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 1
                For i = 0 To dgvDecimo4.Columns.Count - 1
                    If Not dgvDecimo4.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvDecimo4.Columns(i).HeaderText
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvDecimo4.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvDecimo4.Columns.Count - 1
                        If Not dgvDecimo4.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = dgvDecimo4.Rows(i).Cells(j).Value
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvDecimo4.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True

                workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlCSV, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos 10MO4TO!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub dtpDecimo3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDecimo3.ValueChanged
            DateTimePicker9.Value = New DateTime(dtpDecimo3.Value.Year - 1, 12, 1)
            DateTimePicker10.Value = New DateTime(dtpDecimo3.Value.Year, 11, 30)
        End Sub

        Private Sub dtpDecimo4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDecimo4.ValueChanged
            DateTimePicker12.Value = New DateTime(dtpDecimo3.Value.Year - 1, 3, 1)
            'Dim f = New DateTime(dtpDecimo3.Value.Year, 2, 1)
            DateTimePicker11.Value = New DateTime(dtpDecimo3.Value.Year, 2, 1).AddMonths(1).AddDays(-1)
        End Sub

        Private Sub DateTimePicker13_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker13.ValueChanged
            DateTimePicker8.Value = New DateTime(DateTimePicker13.Value.Year, 1, 1)
            DateTimePicker3.Value = New DateTime(DateTimePicker13.Value.Year, 12, 31)
        End Sub

        Private Sub TextBox2_KeyUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
            If e.KeyValue <> 13 Then Return
            Button3_Click(Nothing, Nothing)
        End Sub

        Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "REPORTE_UTIL"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(DataGridView3)
                worksheet.Range("A1:" & ic & (DataGridView3.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  REPORTE ASISTENCIA POR PUESTO"
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & DateTimePicker8.Value.ToLongDateString().ToUpper() & "  AL " & DateTimePicker3.Value.ToLongDateString().ToUpper()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString().ToUpper() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To DataGridView3.Columns.Count - 1
                    If Not DataGridView3.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = DataGridView3.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To DataGridView3.Rows.Count - 1
                    indc = 1
                    For j = 0 To DataGridView3.Columns.Count - 1

                        If Not DataGridView3.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = DataGridView3.Rows(i).Cells(j).Value.ToString()


                        

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = DataGridView3.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (DataGridView3.RowCount + 50)).Columns.AutoFit()

                Dim position = CType(worksheet.Cells(2, 7), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.paste(position)

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!" & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "UTILIDADES"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvUtilidades)
                worksheet.Range("A1:" & ic & (dgvUtilidades.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  REPORTE PARA UTILIDADES"
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & DateTimePicker8.Value.ToLongDateString().ToUpper() & "  AL " & DateTimePicker3.Value.ToLongDateString().ToUpper()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString().ToUpper() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvUtilidades.Columns.Count - 1
                    If Not dgvUtilidades.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvUtilidades.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvUtilidades.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvUtilidades.Columns.Count - 1

                        If Not dgvUtilidades.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = dgvUtilidades.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvUtilidades.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvUtilidades.RowCount + 50)).Columns.AutoFit()

                Dim position = CType(worksheet.Cells(2, 7), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.paste(position)

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!" & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            Try


                Dim fechaDesde = dtpDesde.Value.Year.ToString + "-" + dtpDesde.Value.Month.ToString + "-" + dtpDesde.Value.Day.ToString + " 00:00:00"
                Dim fechaHasta = dtpHasta.Value.Year.ToString + "-" + dtpHasta.Value.Month.ToString + "-" + dtpHasta.Value.Day.ToString + " 23:59:59"
                Dim anio = dtpHasta.Value.Year.ToString + "-01-01 00:00:00"

                Dim tipo As Integer = Convert.ToInt32(cbxTipoUtilidades.SelectedIndex)

                Dim Uti = _objPersonal.BuscarPersonalUtilidades(_tipoCon, fechaDesde, fechaHasta, tipo, anio)

                dgvBuscarUtilidades.Rows.Clear()

                For Each d As DataRow In Uti.Rows

                    dgvBuscarUtilidades.Rows.Add(d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7))
                Next

                dgvBuscarUtilidades.Columns(0).Width = 90
                dgvBuscarUtilidades.Columns(1).Width = 250
                dgvBuscarUtilidades.Columns(2).Width = 100
                dgvBuscarUtilidades.Columns(2).DefaultCellStyle.Format = "d"
                dgvBuscarUtilidades.Columns(3).Width = 100
                dgvBuscarUtilidades.Columns(4).Width = 180
                dgvBuscarUtilidades.Columns(5).Width = 100
                dgvBuscarUtilidades.Columns(5).DefaultCellStyle.Format = "d"
                dgvBuscarUtilidades.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvBuscarUtilidades.Columns(6).Width = 100
                dgvBuscarUtilidades.Columns(6).DefaultCellStyle.Format = "d"
                dgvBuscarUtilidades.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvBuscarUtilidades.Columns(7).Width = 100



            Catch ex As Exception
                dgvBuscarUtilidades.Rows.Clear()

            End Try



        End Sub

        Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "UTILIDADES"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvUtilidades)
                worksheet.Range("A1:" & ic & (dgvBuscarUtilidades.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  REPORTE PARA UTILIDADES"
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpDesde.Value.ToLongDateString().ToUpper() & "  AL " & dtpHasta.Value.ToLongDateString().ToUpper()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString().ToUpper() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvBuscarUtilidades.Columns.Count - 1
                    If Not dgvBuscarUtilidades.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvBuscarUtilidades.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvBuscarUtilidades.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvBuscarUtilidades.Columns.Count - 1

                        If Not dgvBuscarUtilidades.Columns(j).Visible Then Continue For
                        worksheet.Cells(i + 1 + headin, indc) = dgvBuscarUtilidades.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvBuscarUtilidades.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvBuscarUtilidades.RowCount + 50)).Columns.AutoFit()

                Dim position = CType(worksheet.Cells(2, 7), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.paste(position)

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!" & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub dgvDecimo3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDecimo3.CellContentClick

        End Sub
    End Class
End Namespace