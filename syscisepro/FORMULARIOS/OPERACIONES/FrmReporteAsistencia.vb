Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports Krypton.Toolkit


Namespace FORMULARIOS.OPERACIONES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmReporteAsistencia
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
        Dim _sqlCommands As List(Of SqlCommand)

        'Private ReadOnly _modificar = True

        ReadOnly _objRegistroSancion As New ClassRegistroSancionPersonal

        ReadOnly _objAsignacionPersonal As New ClassAsignacionPersonal

        ReadOnly _objProgramacionOps As New ClassProgramacionOperaciones
        ReadOnly _objdetaProgramacionOps As New ClassDetallesProgramacion

        ReadOnly _objRegistroDescuento As New ClassDescuentosPersonal
        ReadOnly _objSitioTrabajo As New ClassSitiosTrabajo


        Dim _frmDetail As FrmReporteObservaciones

        Private _hoy As DateTime

        Public Admin As Boolean
        Public IdUsuario As Integer
        Public Usuario As Integer
        Public UserName As String

        Dim _cleanRead As Boolean = True

        Dim _r As DataGridViewRow

        Private Sub FrmAsignarPuestoTrabajoOperaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    '  MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip2.ForeColor = Color.White
                    'MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label24.ForeColor = Color.White
                    Label24.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label7.ForeColor = Color.White
                    Label7.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label8.ForeColor = Color.White
                    Label8.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label4.ForeColor = Color.White
                    Label4.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDia.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvNoche.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip2.ForeColor = Color.White
                    ' MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label24.ForeColor = Color.White
                    Label24.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'Label7.ForeColor = Color.White
                    'Label7.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'Label8.ForeColor = Color.White
                    'Label8.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label4.ForeColor = Color.White
                    Label4.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDia.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvNoche.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip2.ForeColor = Color.White
                    'MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label24.ForeColor = Color.White
                    Label24.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label7.ForeColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label7.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label8.ForeColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label8.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label4.ForeColor = Color.White
                    Label4.BackColor = My.MySettingsProperty.Settings.ColorCisepro

                    dgvDia.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvNoche.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _hoy = ValidationForms.FechaActual(_tipoCon)
            Me.btnAgregar.ToolTipText = "Agregar Vigilante"

            dtpMes.Value = New Date(_hoy.Year, _hoy.Month, 1)
            Text += " " & ValidationForms.NombreCompany(_tipoCon)
            Label8.Text = UserName

            _sqlCommands = New List(Of SqlCommand)
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click

            If dgvDia.RowCount > 0 Or dgvNoche.RowCount > 0 Then
                If KryptonMessageBox.Show("Se detectó datos en las tabla DÍA / NOCHE, si no ha guardado los cambios se volverá a cargar la información almacenada anteriormente para la fecha correspondiente. Desea continuar?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            End If

            Try
                _hoy = ValidationForms.FechaActual(_tipoCon)

                Dim fechaDesde = DateTimePicker4.Value.Year.ToString & "-" & DateTimePicker4.Value.Month.ToString & "-" & DateTimePicker4.Value.Day.ToString & " 00:00:00"
                Dim fechaHasta = DateTimePicker4.Value.Year.ToString & "-" & DateTimePicker4.Value.Month.ToString & "-" & DateTimePicker4.Value.Day.ToString & " 23:59:59"

                Dim prog = _objProgramacionOps.SeleccionarProgramacionByFecha(_tipoCon, fechaDesde)
                If prog.Rows.Count = 0 Then
                    KryptonMessageBox.Show("NO HAY REGISTRO DE LA PROGRAMACIÓN CORRESPONDIENTE A LA FECHA SELECCIONADA!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                TextBox3.Text = prog.Rows(0).Item(0)

                dtpMes.Value = New Date(Convert.ToInt16(prog.Rows(0).Item(2)), Convert.ToInt16(prog.Rows(0).Item(1)), 1)
                DateTimePicker1.Value = Convert.ToDateTime(prog.Rows(0).Item(3))
                DateTimePicker2.Value = Convert.ToDateTime(prog.Rows(0).Item(4))
                Dim dia As String
                Dim ndia = String.Empty
                Dim jdia = String.Empty
                Dim datosd As DataTable
                Dim datosn As DataTable
                Dim datosl As DataTable
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
                    Select Case KryptonMessageBox.Show("YA EXISTE un reporte del " & DateTimePicker4.Text & " si pone 'SI' se cargará dicho reporte y podrá continuar los cambios sobre el mismo, si pone 'NO' se cargará un nuevo reporte según el día de la programación correspondiente. Desea cargar los datos del reporte existente? ", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNoCancel, KryptonMessageBoxIcon.Question)
                        Case DialogResult.Yes
                            datosd = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, True, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 1)
                            datosn = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, True, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 2)
                            datosl = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaLibresByIdProgramacion(_tipoCon, prog.Rows(0).Item(0), dia, fechaDesde, fechaHasta)

                            crd = If(datosd.Rows.Count > 0, If(datosd.Rows(0).Item(19).ToString.Trim.Length > 0, datosd.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            crn = If(datosn.Rows.Count > 0, If(datosn.Rows(0).Item(19).ToString.Trim.Length > 0, datosn.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            _cleanRead = False
                        Case DialogResult.No
                            datosd = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 1)
                            datosn = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 2)
                            datosl = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaLibresByIdProgramacion(_tipoCon, prog.Rows(0).Item(0), dia, fechaDesde, fechaHasta)

                            crd = If(datosd.Rows.Count > 0, If(datosd.Rows(0).Item(19).ToString.Trim.Length > 0, datosd.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            crn = If(datosn.Rows.Count > 0, If(datosn.Rows(0).Item(19).ToString.Trim.Length > 0, datosn.Rows(0).Item(19).ToString.Split("~").Length, 0), 0)
                            _cleanRead = True
                        Case Else
                            datosd = New DataTable()
                            datosn = New DataTable()
                            datosl = New DataTable()
                            crd = 0
                            crn = 0
                            _cleanRead = False
                    End Select
                Else
                    datosd = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 1)
                    datosn = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaByIdProgramacion(_tipoCon, False, prog.Rows(0).Item(0), dia, ndia, fechaDesde, fechaHasta, jdia, 2)
                    datosl = _objdetaProgramacionOps.SeleccionarDetalleAsistenciaLibresByIdProgramacion(_tipoCon, prog.Rows(0).Item(0), dia, fechaDesde, fechaHasta)
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

                    If row.Item(10) = "ATRASO" Then dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)

                    If row.Item(10) = "INASISTENCIA" Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Value = "IN"
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                    End If

                    If row.Item(10) = "DOBLADA" Then
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Value = "DB"
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
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
                TabControl1.TabPages(0).Text = "DÍA - " & dgvDia.RowCount & " VIGILANTES"

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

                    If row.Item(10) = "ATRASO" Then dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)

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
                TabControl1.TabPages(1).Text = "NOCHE - " & dgvNoche.RowCount & " VIGILANTES"


                ' lista libre hoy
                DataGridView1.Rows.Clear()
                For Each lrow As DataRow In datosl.Rows
                    DataGridView1.Rows.Add(lrow.Item(0), lrow.Item(1), lrow.Item(2), lrow.Item(3), lrow.Item(4), lrow.Item(5), String.Empty)
                Next

                ' ver en el dia
                For Each lrow As DataGridViewRow In DataGridView1.Rows
                    For Each drow As DataGridViewRow In dgvDia.Rows
                        If lrow.Cells(1).Value.ToString().Trim().Equals(drow.Cells(3).Value.ToString().Trim()) Then
                            lrow.Cells(6).Value = drow.Cells(1).Value & " - " & drow.Cells(6).Value
                            lrow.Cells(6).Style.BackColor = Color.LightSkyBlue
                        End If
                    Next
                Next
                ' ver en la noche
                For Each lrow As DataGridViewRow In DataGridView1.Rows
                    For Each nrow As DataGridViewRow In dgvNoche.Rows
                        If lrow.Cells(1).Value.ToString().Trim().Equals(nrow.Cells(3).Value.ToString().Trim()) Then
                            lrow.Cells(6).Value = nrow.Cells(1).Value & " - " & nrow.Cells(6).Value
                            lrow.Cells(6).Style.BackColor = Color.LightSkyBlue
                        End If
                    Next
                Next


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
                'If Not Admin And _hoy > DateTimePicker4.Value.AddDays(15).AddHours(2) And Convert.ToInt32(_objUsuario.IdUsuario) = 50 Then
                If Not Admin And _hoy > DateTimePicker4.Value.AddDays(2).AddHours(2) Then
                    btnAgregar.Enabled = False
                    btnCambiar.Enabled = False
                    btnQuitar.Enabled = False
                    btnAddRad.Enabled = False
                    ToolStripMenuItem6.Enabled = False
                    dgvDia.ReadOnly = True
                    dgvNoche.ReadOnly = True
                    KryptonMessageBox.Show("HAN PASADO MÁS DE 48H, NO SE PUEDE MODIFICAR EL REPORTE CORRESPONDIENTE!!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Else
                    btnAgregar.Enabled = True
                    btnCambiar.Enabled = True
                    btnQuitar.Enabled = True
                    btnAddRad.Enabled = True
                    dgvDia.ReadOnly = False
                    dgvNoche.ReadOnly = False
                End If

                DateTimePicker5.Value = DateTimePicker4.Value

            Catch ex As Exception
                dgvDia.Rows.Clear()
                dgvNoche.Rows.Clear()
                Dim m = If(ex.Message.Contains("fila en la posición 0"), "HUBO UN PROBLEMA AL CARGAR LA PROGRAMACIÓN CORRESPONDIENTE A LA FECHA SELECCIONADA!", ex.Message)
                MsgBox(m, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
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

        Private Sub FrmReporteAsistencia_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If dgvDia.RowCount > 0 Or dgvNoche.RowCount > 0 Then
                Dim res = KryptonMessageBox.Show("Desea guardar los cambios realizados?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNoCancel, KryptonMessageBoxIcon.Question)
                If res = DialogResult.Cancel Then
                    e.Cancel = True
                Else
                    If res = DialogResult.Yes Then Guardar(False)
                End If
            End If
        End Sub

        Private Sub Guardar(ByVal msg As Boolean)
            _hoy = ValidationForms.FechaActual(_tipoCon)

            If Not Admin And _hoy > DateTimePicker5.Value.AddDays(2).AddHours(2) Then
                KryptonMessageBox.Show("HAN PASADO MÁS DE 48H, NO SE PUEDE MODIFICAR EL REPORTE CORRESPONDIENTE!!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If msg Then If KryptonMessageBox.Show("Desea guardar los cambios realizados para los vigilantes?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            VerificarFaltas()

            _sqlCommands.Clear()

            DateTimePicker5.Value = New Date(DateTimePicker5.Value.Year, DateTimePicker5.Value.Month, DateTimePicker5.Value.Day, 0, 0, 0)
            Dim fechaDesde = DateTimePicker5.Value.Year.ToString & "-" & DateTimePicker5.Value.Month.ToString & "-" & DateTimePicker5.Value.Day.ToString & " 00:00:00"
            Dim fechaHasta = DateTimePicker5.Value.Year.ToString & "-" & DateTimePicker5.Value.Month.ToString & "-" & DateTimePicker5.Value.Day.ToString & " 23:59:59"
            _sqlCommands.Add(_objAsignacionPersonal.DeleteRegistroNuevoAsignacionPersonalComman(CInt(TextBox3.Text), fechaDesde, fechaHasta))
            'Borrar Descuento
            _sqlCommands.Add(_objRegistroDescuento.DeleteRegistroDescuentoXAsignacionPersonalCommand(CInt(TextBox3.Text), fechaDesde, fechaHasta))
            'Borrar(Sancion)
            _sqlCommands.Add(_objRegistroSancion.DeleteRegistroNuevoSancionPersonalCommand(CInt(TextBox3.Text), fechaDesde, fechaHasta))


            Dim id = 1

            ' dia
            For Each row As DataGridViewRow In dgvDia.Rows
                With _objAsignacionPersonal
                    .IdAsignacion = _objAsignacionPersonal.BuscarMayorIdAsignacion(_tipoCon) + id
                    .IdPersonal = row.Cells(3).Value
                    .IdPuesto = row.Cells(5).Value
                    .IdHorario = row.Cells(8).Value
                    .Estado = 1
                    .Fecharegistro = _hoy
                    .IdpPogramacion = row.Cells(2).Value
                    .Fecha = fechaDesde
                    .C50 = row.Cells(12).Value
                    .C51 = row.Cells(13).Value
                    .C40 = row.Cells(14).Value
                    .C41 = row.Cells(15).Value
                    .Entrada = row.Cells(11).Value
                    .Salida = "-"
                    .Tipo = row.Cells(10).Value
                    .Cant = (row.Tag & "").ToString.Trim.Split("|")(0).Trim
                    .Observa = (row.Tag & "").ToString.Trim.Split("|")(1).Trim
                    .Report = (row.Tag & "").ToString.Trim.Split("|")(2).Trim
                    .Iduser = (row.Tag & "").ToString.Trim.Split("|")(3).Trim
                    .Horario = row.Cells(9).Value
                End With
                _sqlCommands.Add(_objAsignacionPersonal.RegistararNuevoAsignacionPersonalComman())


                'Registro de Multas x inasistencia

                If row.Cells(10).Value.ToString().Equals("INASISTENCIA") Then
                    With _objRegistroSancion
                        .IdRegistro = _objRegistroSancion.BuscarMayorIdRegistroSancion(_tipoCon) + id
                        .IdPersonal = CInt(row.Cells(3).Value)
                        .IdSancion = 3
                        .Fecha = fechaDesde
                        .Valor = 50
                        .Estado = 1
                        .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " DESCUENTO DE INASISTENCIA"
                        .Idsitio = _objSitioTrabajo.SeleccionarSitioxIdxIdPersonal(_tipoCon, .IdPersonal)
                        .IdProg = CInt(row.Cells(2).Value)
                        .IdDescuento = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                        .Multador = UserName
                    End With

                    _sqlCommands.Add(_objRegistroSancion.NuevoRegistroSancionDescuentoCommands())

                    With _objRegistroDescuento
                        .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                        .IdPersonal = CInt(row.Cells(3).Value)
                        .Fecha = fechaDesde
                        .Procesado = 0
                        .Mes = DateTimePicker5.Value.Month
                        .Anio = DateTimePicker5.Value.Year
                        .IdRol = 0
                        .Tipo = 10
                        .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " DESCUENTO DE INASISTENCIA"
                        .Valor = 50
                        .Tipot = "DESCUENTO MULTAS / ATRASOS"
                        .Idprog = CInt(row.Cells(2).Value)
                    End With
                    _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())

                End If


                'Registro de Multas x Atrasos

                Dim time As String = row.Cells(11).Value.ToString()
                Dim parts() As String = time.Split(":"c)

                If row.Cells(10).Value.ToString.Equals("ATRASO") Then
                    If parts.Length >= 2 Then


                        Dim minutes As Integer
                        Dim IdSancion As Integer
                        If Integer.TryParse(parts(1), minutes) Then


                            If minutes >= 1 AndAlso minutes <= 9 Then
                                IdSancion = 1 ' 10 min sanction
                            ElseIf minutes >= 10 AndAlso minutes <= 15 Then
                                IdSancion = 2 ' 15 min sanction
                            ElseIf minutes >= 16 AndAlso minutes <= 20 Then
                                IdSancion = 13 ' 20 min sanction
                            ElseIf minutes >= 21 AndAlso minutes <= 59 Then
                                IdSancion = 14 ' 30 min sanction
                            End If



                            If IdSancion > 0 Then


                                With _objRegistroSancion
                                    .IdRegistro = _objRegistroSancion.BuscarMayorIdRegistroSancion(_tipoCon) + id
                                    .IdPersonal = CInt(row.Cells(3).Value)
                                    .IdSancion = IdSancion
                                    .Fecha = fechaDesde
                                    .Valor = 5
                                    .Estado = 1
                                    .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " MULTA POR " & minutes & " min DE ATRASO"
                                    .Idsitio = _objSitioTrabajo.SeleccionarSitioxIdxIdPersonal(_tipoCon, .IdPersonal)
                                    .IdProg = CInt(row.Cells(2).Value)
                                    .IdDescuento = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                                    .Multador = UserName
                                End With

                                _sqlCommands.Add(_objRegistroSancion.NuevoRegistroSancionDescuentoCommands())

                                With _objRegistroDescuento
                                    .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                                    .IdPersonal = CInt(row.Cells(3).Value)
                                    .Fecha = fechaDesde
                                    .Procesado = 0
                                    .Mes = DateTimePicker5.Value.Month
                                    .Anio = DateTimePicker5.Value.Year
                                    .IdRol = 0
                                    .Tipo = 10
                                    .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " MULTA POR " & minutes & " min DE ATRASO"
                                    .Valor = 5
                                    .Tipot = "DESCUENTO MULTAS / ATRASOS"
                                End With
                                _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())
                            End If

                        End If

                    End If


                End If


                id += 1
            Next





            ' noche 
            For Each row As DataGridViewRow In dgvNoche.Rows


                With _objAsignacionPersonal
                    .IdAsignacion = _objAsignacionPersonal.BuscarMayorIdAsignacion(_tipoCon) + id
                    .IdPersonal = row.Cells(3).Value
                    .IdPuesto = row.Cells(5).Value
                    .IdHorario = row.Cells(8).Value
                    .Estado = 1
                    .Fecharegistro = _hoy
                    .IdpPogramacion = row.Cells(2).Value
                    .Fecha = fechaDesde
                    .C50 = row.Cells(12).Value
                    .C51 = row.Cells(13).Value
                    .C40 = row.Cells(14).Value
                    .C41 = row.Cells(15).Value
                    .Entrada = row.Cells(11).Value
                    .Salida = "-"
                    .Tipo = row.Cells(10).Value
                    .Cant = (row.Tag & "").ToString.Trim.Split("|")(0).Trim
                    .Observa = (row.Tag & "").ToString.Trim.Split("|")(1).Trim
                    .Report = (row.Tag & "").ToString.Trim.Split("|")(2).Trim
                    .Iduser = (row.Tag & "").ToString.Trim.Split("|")(3).Trim
                    .Horario = row.Cells(9).Value
                End With
                _sqlCommands.Add(_objAsignacionPersonal.RegistararNuevoAsignacionPersonalComman())


                'Dim multas As Integer = _objAsignacionPersonal.BuscarMultasParaSancionxId(_tipoCon, CInt(row.Cells(3).Value), fechaDesde, fechaHasta)
                Dim Valor1 As Integer = _objRegistroSancion.ActualizarValorSancion(_tipoCon, CInt(row.Cells(3).Value), fechaDesde, fechaHasta, CInt(row.Cells(2).Value))

                'Dim Id_descuento As Integer = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id

                If Valor1 > 0 Then
                    Dim Valor2 As Decimal = _objRegistroSancion.ValorSancion(_tipoCon)
                    With _objRegistroSancion
                        .IdRegistro = _objRegistroSancion.BuscarMayorIdRegistroSancion(_tipoCon) + id
                        .IdPersonal = CInt(row.Cells(3).Value)
                        .IdSancion = 28
                        .Fecha = fechaDesde
                        .Valor = Valor1 * Valor2
                        .Estado = 1
                        .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " MULTA DE REPORTE"
                        .Idsitio = _objSitioTrabajo.SeleccionarSitioxIdxIdPersonal(_tipoCon, .IdPersonal)
                        .IdProg = CInt(row.Cells(2).Value)
                        .IdDescuento = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                        .Multador = UserName
                    End With

                    _sqlCommands.Add(_objRegistroSancion.NuevoRegistroSancionDescuentoCommands())

                    With _objRegistroDescuento
                        .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                        .IdPersonal = CInt(row.Cells(3).Value)
                        .Fecha = fechaDesde
                        .Procesado = 0
                        .Mes = DateTimePicker5.Value.Month
                        .Anio = DateTimePicker5.Value.Year
                        .IdRol = 0
                        .Tipo = 10
                        .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " MULTA DE REPORTE"
                        .Valor = Valor1 * Valor2
                        .Tipot = "DESCUENTO MULTAS / ATRASOS"
                    End With
                    _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())
                    id += 1
                End If

                'Registro de Multas x inasistencia
                If row.Cells(10).Value.ToString().Equals("INASISTENCIA") Then

                    Dim sancion = _objRegistroSancion.BuscarValorInastenciaParaSancionxId(_tipoCon, CInt(row.Cells(3).Value), fechaDesde, fechaHasta)
                    If sancion > 0 Then

                    Else

                        With _objRegistroSancion
                            .IdRegistro = _objRegistroSancion.BuscarMayorIdRegistroSancion(_tipoCon) + id
                            .IdPersonal = CInt(row.Cells(3).Value)
                            .IdSancion = 3
                            .Fecha = fechaDesde
                            .Valor = 50
                            .Estado = 1
                            .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " DESCUENTO DE INASISTENCIA"
                            .Idsitio = _objSitioTrabajo.SeleccionarSitioxIdxIdPersonal(_tipoCon, .IdPersonal)
                            .IdProg = CInt(row.Cells(2).Value)
                            .IdDescuento = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                            .Multador = UserName
                        End With

                        _sqlCommands.Add(_objRegistroSancion.NuevoRegistroSancionDescuentoCommands())

                        With _objRegistroDescuento
                            .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                            .IdPersonal = CInt(row.Cells(3).Value)
                            .Fecha = fechaDesde
                            .Procesado = 0
                            .Mes = DateTimePicker5.Value.Month
                            .Anio = DateTimePicker5.Value.Year
                            .IdRol = 0
                            .Tipo = 10
                            .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " DESCUENTO DE INASISTENCIA"
                            .Valor = 50
                            .Tipot = "DESCUENTO MULTAS / ATRASOS"
                            .Idprog = CInt(row.Cells(2).Value)
                        End With
                        _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())

                    End If


                End If


                'Registro de Multas x Atrasos
                Dim time As String = row.Cells(11).Value.ToString()
                Dim parts() As String = time.Split(":"c)

                If row.Cells(10).Value.ToString().Equals("ATRASO") Then

                    If parts.Length >= 2 Then

                        Dim minutes As Integer
                        Dim IdSancion As Integer
                        If Integer.TryParse(parts(1), minutes) Then


                            If minutes >= 1 AndAlso minutes <= 9 Then
                                IdSancion = 1 ' 10 min 
                            ElseIf minutes >= 10 AndAlso minutes <= 15 Then
                                IdSancion = 2 ' 15 min 
                            ElseIf minutes >= 16 AndAlso minutes <= 20 Then
                                IdSancion = 13 ' 20 min 
                            ElseIf minutes >= 21 AndAlso minutes <= 59 Then
                                IdSancion = 14 ' 30 min 
                            End If



                            If IdSancion > 0 Then

                                With _objRegistroSancion
                                    .IdRegistro = _objRegistroSancion.BuscarMayorIdRegistroSancion(_tipoCon) + id
                                    .IdPersonal = CInt(row.Cells(3).Value)
                                    .IdSancion = IdSancion
                                    .Fecha = fechaDesde
                                    .Valor = 5
                                    .Estado = 1
                                    .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " MULTA POR " & minutes & " min DE ATRASO"
                                    .Idsitio = _objSitioTrabajo.SeleccionarSitioxIdxIdPersonal(_tipoCon, .IdPersonal)
                                    .IdProg = CInt(row.Cells(2).Value)
                                    .IdDescuento = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                                    .Multador = UserName
                                End With

                                _sqlCommands.Add(_objRegistroSancion.NuevoRegistroSancionDescuentoCommands())

                                With _objRegistroDescuento
                                    .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + id
                                    .IdPersonal = CInt(row.Cells(3).Value)
                                    .Fecha = fechaDesde
                                    .Procesado = 0
                                    .Mes = DateTimePicker5.Value.Month
                                    .Anio = DateTimePicker5.Value.Year
                                    .IdRol = 0
                                    .Tipo = 10
                                    .Observacion = (row.Tag & "").ToString.Trim.Split("|")(1).Trim & " MULTA POR " & minutes & " min DE ATRASO"
                                    .Valor = 5
                                    .Tipot = "DESCUENTO MULTAS / ATRASOS"
                                End With
                                _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())
                            End If
                        End If

                    End If


                End If


                id += 1

            Next




            Dim nombreU As String = "REPORTE ASISTENCIA " & UserName
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Dim messageIcon As KryptonMessageBoxIcon
            If res(0) Then
                messageIcon = KryptonMessageBoxIcon.Information
            Else
                messageIcon = KryptonMessageBoxIcon.Exclamation
            End If
            KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
        End Sub

        Private Function NumeroRiver(ByVal rivers As String) As Integer
            Dim nriver = (From c In rivers Where Char.IsDigit(c)).Aggregate(String.Empty, Function(current, c) current + c)
            Return Convert.ToInt32(nriver.Trim)
        End Function

        Private Function ExisteRegistroDia(ByVal idp As String, ByVal idh As String) As Boolean
            Return dgvDia.Rows.Cast(Of DataGridViewRow)().Any(Function(row) row.Cells(3).Value.ToString.Equals(idp) And row.Cells(8).Value.ToString.Equals(idh))
        End Function

        Private Function ExisteRegistroNoche(ByVal idp As String, ByVal idh As String) As Boolean
            Return dgvNoche.Rows.Cast(Of DataGridViewRow)().Any(Function(row) row.Cells(3).Value.ToString.Equals(idp) And row.Cells(8).Value.ToString.Equals(idh))
        End Function

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
                        If String.IsNullOrEmpty(idu.Trim) Then idu = Usuario
                        row.Tag = cant & "|" & obs & "|" & rep & "|" & idu
                        r += 1
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: En VerificarFaltas() DIA, index:" & r & " , " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                        If String.IsNullOrEmpty(idu.Trim) Then idu = Usuario
                        row.Tag = cant & "|" & obs & "|" & rep & "|" & idu
                        r += 1
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: En VerificarFaltas() NOCHE, index:" & r & " , " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker4.ValueChanged
            ToolStripMenuItem1_Click(Nothing, Nothing)
        End Sub

        Private Sub dgvNoche_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvNoche.CellEndEdit
            If e.ColumnIndex = 9 Then
                Try
                    If dgvNoche.CurrentRow.Cells(9).Value.ToString().Length = 0 Then dgvNoche.CurrentRow.Cells(9).Value = "-"
                Catch ex As Exception
                    dgvNoche.CurrentRow.Cells(9).Value = "-"
                End Try
            End If

            If e.ColumnIndex = 10 Then
                Try
                    If (dgvNoche.CurrentRow.Tag & "").ToString.Trim.Length = 0 Then dgvNoche.CurrentRow.Tag = "0|||0"

                    Dim tg = dgvNoche.CurrentRow.Tag.ToString.Split("|")
                    If dgvNoche.CurrentRow.Cells(10).Value = "PENDIENTE" Then
                        dgvNoche.CurrentRow.Cells(11).Value = "-"
                        dgvNoche.CurrentRow.Cells(12).Value = "-"
                        dgvNoche.CurrentRow.Cells(13).Value = "-"
                        dgvNoche.CurrentRow.Cells(14).Value = "-"
                        dgvNoche.CurrentRow.Cells(15).Value = "-"
                        dgvNoche.CurrentRow.Cells(11).Style.BackColor = dgvNoche.CurrentRow.Cells(0).Style.BackColor
                        dgvNoche.CurrentRow.Tag = tg(0) & "|" & tg(1) & "|" & tg(2) & "|" & 0
                    Else
                        If dgvNoche.CurrentRow.Cells(10).Value = "ASISTENCIA" Then
                            dgvNoche.CurrentRow.Cells(11).Value = ValidationForms.FechaActual(_tipoCon).ToString("HH:mm") 'ValidationForms.FechaActual(_tipoCon).ToString("HH:mm")
                            dgvNoche.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 34, 139, 34)
                        Else
                            If dgvNoche.CurrentRow.Cells(10).Value = "ATRASO" Then
                                dgvNoche.CurrentRow.Cells(11).Value = ValidationForms.FechaActual(_tipoCon).ToString("HH:mm") 'ValidationForms.FechaActual(_tipoCon).ToString("HH:mm")
                                dgvNoche.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            ElseIf dgvNoche.CurrentRow.Cells(10).Value = "PERMISO MÉDICO" Then
                                dgvNoche.CurrentRow.Cells(11).Value = "PM"
                                dgvNoche.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            ElseIf dgvNoche.CurrentRow.Cells(10).Value = "DOBLADA" Then
                                dgvNoche.CurrentRow.Cells(11).Value = "DB"
                                dgvNoche.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            ElseIf dgvNoche.CurrentRow.Cells(10).Value = "VACACIONES" Then
                                dgvNoche.CurrentRow.Cells(11).Value = "VC"
                                dgvNoche.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                            ElseIf dgvNoche.CurrentRow.Cells(10).Value = "CALAMIDAD DOMÉSTICA" Then
                                dgvNoche.CurrentRow.Cells(11).Value = "CD"
                                dgvNoche.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            Else
                                dgvNoche.CurrentRow.Cells(11).Value = "IN"
                                dgvNoche.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                            End If
                            dgvNoche.CurrentRow.Cells(12).Value = "-"
                            dgvNoche.CurrentRow.Cells(13).Value = "-"
                            dgvNoche.CurrentRow.Cells(14).Value = "-"
                            dgvNoche.CurrentRow.Cells(15).Value = "-"
                        End If
                        dgvNoche.CurrentRow.Tag = tg(0) & "|" & tg(1) & "|" & tg(2) & "|" & Usuario
                    End If
                Catch ex As Exception
                    dgvNoche.CurrentRow.Cells(11).Value = "-"
                    dgvNoche.CurrentRow.Cells(12).Value = "-"
                    dgvNoche.CurrentRow.Cells(13).Value = "-"
                    dgvNoche.CurrentRow.Cells(14).Value = "-"
                    dgvNoche.CurrentRow.Cells(15).Value = "-"
                    dgvNoche.CurrentRow.Cells(11).Style.BackColor = dgvNoche.CurrentRow.Cells(0).Style.BackColor
                End Try
            End If

            If e.ColumnIndex > 15 Then
                Try
                    If dgvNoche.Columns(e.ColumnIndex).Name.StartsWith("RR") Then
                        dgvNoche.CurrentRow.Cells("HR" & (dgvNoche.Columns(e.ColumnIndex).Tag)).Value = ValidationForms.FechaActual(_tipoCon).ToString("HH:mm") 'ValidationForms.FechaActual(_tipoCon)
                    End If
                Catch
                    'dgvNoche.CurrentRow.Cells("HR" & (dgvNoche.Columns(e.ColumnIndex).Tag)).Value = "S/R " & vbNewLine & _objProgramacionOps.GetFechaActual.ToString("HH:mm")
                End Try
            End If
            VerificarFaltas()
        End Sub

        Private Sub dgvDia_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDia.CellEndEdit
            If e.ColumnIndex = 9 Then
                Try
                    If dgvDia.CurrentRow.Cells(9).Value.ToString().Length = 0 Then dgvDia.CurrentRow.Cells(9).Value = "-"
                Catch ex As Exception
                    dgvDia.CurrentRow.Cells(9).Value = "-"
                End Try
            End If

            If e.ColumnIndex = 10 Then
                Try
                    If (dgvDia.CurrentRow.Tag & "").ToString.Trim.Length = 0 Then dgvDia.CurrentRow.Tag = "0|||0"

                    Dim tg = dgvDia.CurrentRow.Tag.ToString.Split("|")
                    If dgvDia.CurrentRow.Cells(10).Value = "PENDIENTE" Then
                        dgvDia.CurrentRow.Cells(11).Value = "-"
                        dgvDia.CurrentRow.Cells(12).Value = "-"
                        dgvDia.CurrentRow.Cells(13).Value = "-"
                        dgvDia.CurrentRow.Cells(14).Value = "-"
                        dgvDia.CurrentRow.Cells(15).Value = "-"
                        dgvDia.CurrentRow.Cells(11).Style.BackColor = dgvDia.CurrentRow.Cells(0).Style.BackColor
                        dgvDia.CurrentRow.Tag = tg(0) & "|" & tg(1) & "|" & tg(2) & "|" & 0
                    Else
                        If dgvDia.CurrentRow.Cells(10).Value = "ASISTENCIA" Then
                            dgvDia.CurrentRow.Cells(11).Value = ValidationForms.FechaActual(_tipoCon).ToString("HH:mm")
                            dgvDia.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 34, 139, 34)
                        Else
                            If dgvDia.CurrentRow.Cells(10).Value = "ATRASO" Then
                                dgvDia.CurrentRow.Cells(11).Value = ValidationForms.FechaActual(_tipoCon).ToString("HH:mm")
                                dgvDia.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            ElseIf dgvDia.CurrentRow.Cells(10).Value = "PERMISO MÉDICO" Then
                                dgvDia.CurrentRow.Cells(11).Value = "PM"
                                dgvDia.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            ElseIf dgvDia.CurrentRow.Cells(10).Value = "DOBLADA" Then
                                dgvDia.CurrentRow.Cells(11).Value = "DB"
                                dgvDia.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            ElseIf dgvDia.CurrentRow.Cells(10).Value = "VACACIONES" Then
                                dgvDia.CurrentRow.Cells(11).Value = "VC"
                                dgvDia.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                            ElseIf dgvDia.CurrentRow.Cells(10).Value = "CALAMIDAD DOMÉSTICA" Then
                                dgvDia.CurrentRow.Cells(11).Value = "CD"
                                dgvDia.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                            Else
                                dgvDia.CurrentRow.Cells(11).Value = "IN"
                                dgvDia.CurrentRow.Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                            End If

                            dgvDia.CurrentRow.Cells(12).Value = "-"
                            dgvDia.CurrentRow.Cells(13).Value = "-"
                            dgvDia.CurrentRow.Cells(14).Value = "-"
                            dgvDia.CurrentRow.Cells(15).Value = "-"
                        End If
                        dgvDia.CurrentRow.Tag = tg(0) & "|" & tg(1) & "|" & tg(2) & "|" & Usuario
                    End If
                Catch ex As Exception
                    dgvDia.CurrentRow.Cells(11).Value = "-"
                    dgvDia.CurrentRow.Cells(12).Value = "-"
                    dgvDia.CurrentRow.Cells(13).Value = "-"
                    dgvDia.CurrentRow.Cells(14).Value = "-"
                    dgvDia.CurrentRow.Cells(15).Value = "-"
                    dgvDia.CurrentRow.Cells(11).Style.BackColor = dgvDia.CurrentRow.Cells(0).Style.BackColor
                End Try
            End If

            If e.ColumnIndex > 15 Then
                Try
                    If dgvDia.Columns(e.ColumnIndex).Name.StartsWith("RR") Then
                        dgvDia.CurrentRow.Cells("HR" & (dgvDia.Columns(e.ColumnIndex).Tag)).Value = ValidationForms.FechaActual(_tipoCon).ToString("HH:mm") ' ValidationForms.FechaActual(_tipoCon)
                    End If
                Catch
                    'dgvDia.CurrentRow.Cells("HR" & (dgvDia.Columns(e.ColumnIndex).Tag)).Value = "S/R " & vbNewLine & _objProgramacionOps.GetFechaActual.ToString("HH:mm")
                End Try
            End If
            VerificarFaltas()
        End Sub

        Private Function ContarColumnasReporte(ByVal grid As DataGridView) As Integer
            Return grid.Columns.Cast(Of DataGridViewColumn)().Count(Function(col) col.Name.StartsWith("RR"))
        End Function

        Private Sub DefaultValueReporte(ByVal grid As DataGridView)
            If grid.RowCount = 0 Then Return
            For Each row As DataGridViewRow In grid.Rows
                row.Cells(grid.ColumnCount - 1).Value = "-"
            Next
        End Sub

        Private Sub dgvDia_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDia.CellDoubleClick
            If dgvDia.RowCount < 0 Then Return
            If e.ColumnIndex > 8 Then Return

            _frmDetail = New FrmReporteObservaciones
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

        Private Sub dgvNoche_CellBeginEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvNoche.CellBeginEdit
            If dgvNoche.RowCount = 0 Then Return
            If e.ColumnIndex > 10 Then If (dgvNoche.CurrentRow.Cells(10).Value <> "ASISTENCIA" And dgvNoche.CurrentRow.Cells(10).Value <> "ATRASO" And dgvNoche.CurrentRow.Cells(10).Value <> "DOBLADA") Then e.Cancel = True
        End Sub

        Private Sub dgvDia_CellBeginEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDia.CellBeginEdit
            If dgvDia.RowCount = 0 Then Return
            If e.ColumnIndex > 10 Then If (dgvDia.CurrentRow.Cells(10).Value <> "ASISTENCIA" And dgvDia.CurrentRow.Cells(10).Value <> "ATRASO" And dgvDia.CurrentRow.Cells(10).Value <> "DOBLADA") Then e.Cancel = True
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
                'Nombre  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Vigilante: " + ListView1.SelectedItems(0).SubItems(2).Text + " - " + ListView1.SelectedItems(0).SubItems(1).Text
                worksheet.Range("A3:" & ic & "3").Font.Size = 12
                'Fecha  
                worksheet.Range("A4:" & ic & "4").Merge()
                worksheet.Range("A4:" & ic & "4").Value = "Fecha de Impresión: " + Date.Now
                worksheet.Range("A4:" & ic & "4").Font.Size = 12


                Dim dataGridViewExpRowCount As Integer = listViewExp.Items.Cast(Of ListViewItem)().Count()

                'Aca se agregan las cabeceras de nuestro datagrid.
                Dim head As Integer
                Dim foot As Integer
                head = 5
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

        Private Sub NOVEDADESACBMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles NOVEDADESACBMToolStripMenuItem.Click
            Try
                Dim fechaDesde = DateTimePicker4.Value.Year.ToString & "-" & DateTimePicker4.Value.Month.ToString & "-" & DateTimePicker4.Value.Day.ToString & " 00:00:00"
                Dim fechaHasta = DateTimePicker4.Value.Year.ToString & "-" & DateTimePicker4.Value.Month.ToString & "-" & DateTimePicker4.Value.Day.ToString & " 23:59:59"

                Dim prog = _objProgramacionOps.SeleccionarProgramacionByFecha(_tipoCon, fechaDesde)
                Dim data = _objdetaProgramacionOps.SeleccionarReporteAperturaCierreBm(_tipoCon, prog.Rows(0).Item(0), fechaDesde, fechaHasta)

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheetd = workbook.Worksheets(1)
                worksheetd.Name = "REPORTE B.M."

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataTable(data)
                worksheetd.Range("A1:" & ic & (data.Rows.Count + 50)).Font.Size = 10

                worksheetd.Range("A1:" & ic & "1").Merge()
                worksheetd.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
                worksheetd.Range("A1:" & ic & "1").Font.Bold = True
                worksheetd.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheetd.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheetd.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheetd.Range("A1:" & ic & "1").Font.Size = 12
                worksheetd.Range("A2:" & ic & "2").Merge()
                worksheetd.Range("A2:" & ic & "2").Value = "REPORTE APERTURAS / CIERRES BANCO DE MACHALA"
                worksheetd.Range("A2:" & ic & "2").Font.Size = 12
                worksheetd.Range("A3:" & ic & "3").Merge()
                worksheetd.Range("A3:" & ic & "3").Value = "Fecha: " & fechaDesde & "              Fecha de Impresión: " & fec.ToString("dd/MM/yyyy")
                worksheetd.Range("A3:" & ic & "3").Font.Size = 12

                Dim headd = 5

                For i = 1 To data.Columns.Count
                    worksheetd.Cells(1 + headd, i) = data.Columns(i - 1).Caption
                    worksheetd.Cells(1 + headd, i).Font.Bold = True
                    worksheetd.Cells(1 + headd, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheetd.Cells(1 + headd, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheetd.Cells(1 + headd, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheetd.Cells(1 + headd, i).Font.Color = Color.White
                Next

                Dim dataGridViewExpRowCountd = 0
                For Each row As DataRow In data.Rows
                    For j = 0 To data.Columns.Count - 1
                        worksheetd.Cells(dataGridViewExpRowCountd + 2 + headd, j + 1) = row.Item(j)
                        If j > 0 Then worksheetd.Cells(dataGridViewExpRowCountd + 2 + headd, j + 1).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        worksheetd.Cells(dataGridViewExpRowCountd + 2 + headd, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheetd.Cells(dataGridViewExpRowCountd + 2 + headd, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If dataGridViewExpRowCountd = data.Rows.Count - 1 Then worksheetd.Cells(dataGridViewExpRowCountd + 2 + headd, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    Next
                    dataGridViewExpRowCountd += 1
                Next

                worksheetd.Range("A1:" & ic & (data.Rows.Count + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Error al exportar datos! " & vbNewLine & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub REPORTESDERADIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles REPORTESDERADIOToolStripMenuItem.Click
            'Try
            Dim data As New DataTable()
            data.Columns.Add("VIGILANTE")
            data.Columns.Add("RIVER")
            data.Columns.Add("# REP. S/R")

            data.Columns.Add("VALOR")

            data.Columns.Add("NOVEDAD")
            data.Columns.Add("SANCIÓN / MULTA")
            data.Columns.Add("OBSERVACIÓN")

            Dim fechaDesde = DateTimePicker5.Value.Year.ToString & "-" & DateTimePicker5.Value.Month.ToString & "-" & DateTimePicker5.Value.Day.ToString & " 00:00:00"
            Dim fechaHasta = DateTimePicker5.Value.Year.ToString & "-" & DateTimePicker5.Value.Month.ToString & "-" & DateTimePicker5.Value.Day.ToString & " 23:59:59"

            Dim cadred As String
            Dim cadren As String
            For Each row As DataGridViewRow In dgvDia.Rows
                If Not row.Cells(10).Value.Equals("PENDIENTE") And Not row.Cells(10).Value.Equals("CALAMIDAD DOMÉSTICA") And Not row.Cells(10).Value.Equals("PERMISO MÉDICO") And Not row.Cells(10).Value.Equals("VACACIONES") Then

                    cadred = (From col As DataGridViewColumn In dgvDia.Columns Where col.Name.StartsWith("HR") Where Not CBool(row.Cells(col.Index - 1).Value) Where row.Cells(col.Index).Value <> "-").Aggregate("", Function(current, col) current + ("H: " & row.Cells(col.Index).Value & ",   "))
                    cadred = cadred.Trim
                    cadred = If(cadred.EndsWith(","), cadred.Substring(0, cadred.Length - 1), cadred)

                    If row.Tag.ToString.Split("|")(0) <> "0" Or row.Cells(10).Value.Equals("INASISTENCIA") Or row.Cells(10).Value.Equals("ATRASO") Then
                        If row.Cells(10).Value.Equals("INASISTENCIA") Then
                            data.Rows.Add(row.Cells(4).Value, row.Cells(1).Value, "-", "IN", "INASISTENCIA", row.Tag.ToString.Split("|")(1))
                        ElseIf row.Cells(10).Value.Equals("ATRASO") Then
                            data.Rows.Add(row.Cells(4).Value, row.Cells(1).Value, row.Tag.ToString.Split("|")(0), "AT - " & row.Cells(11).Value, "ATRASO", row.Tag.ToString.Split("|")(1) & If(cadred.Trim().Length > 0, " HORA DE REPORTES: " & cadred, String.Empty))
                        Else
                            data.Rows.Add(row.Cells(4).Value, row.Cells(1).Value, row.Tag.ToString.Split("|")(0), "S/R", "NO CONTESTAR RADIO", row.Tag.ToString.Split("|")(1) & If(cadred.Trim().Length > 0, " HORA DE REPORTES: " & cadred, String.Empty))
                        End If
                    End If
                End If
            Next

            For Each row As DataGridViewRow In dgvNoche.Rows
                If Not row.Cells(10).Value.Equals("PENDIENTE") And Not row.Cells(10).Value.Equals("CALAMIDAD DOMÉSTICA") And Not row.Cells(10).Value.Equals("PERMISO MÉDICO") And Not row.Cells(10).Value.Equals("VACACIONES") Then

                    cadren = (From col As DataGridViewColumn In dgvNoche.Columns Where col.Name.StartsWith("HR") Where Not CBool(row.Cells(col.Index - 1).Value) Where row.Cells(col.Index).Value <> "-").Aggregate("", Function(current, col) current + ("H: " & row.Cells(col.Index).Value & ",   "))
                    cadren = cadren.Trim
                    cadren = If(cadren.EndsWith(","), cadren.Substring(0, cadren.Length - 1), cadren)

                    If row.Tag.ToString.Split("|")(0) <> "0" Or row.Cells(10).Value.Equals("INASISTENCIA") Or row.Cells(10).Value.Equals("ATRASO") Then
                        If row.Cells(10).Value.Equals("INASISTENCIA") Then
                            data.Rows.Add(row.Cells(4).Value, row.Cells(1).Value, "-", "IN", "INASISTENCIA", row.Tag.ToString.Split("|")(1))
                        ElseIf row.Cells(10).Value.Equals("ATRASO") Then
                            data.Rows.Add(row.Cells(4).Value, row.Cells(1).Value, row.Tag.ToString.Split("|")(0), "AT - " & row.Cells(11).Value, "ATRASO", row.Tag.ToString.Split("|")(1) & If(cadren.Trim().Length > 0, " HORA DE REPORTES: " & cadren, String.Empty))
                        Else
                            data.Rows.Add(row.Cells(4).Value, row.Cells(1).Value, row.Tag.ToString.Split("|")(0), "S/R", "NO CONTESTAR RADIO", row.Tag.ToString.Split("|")(1) & " " & If(cadren.Trim().Length > 0, " HORA DE REPORTES: " & cadren, String.Empty))
                        End If
                    End If
                End If
            Next

            Dim fec = ValidationForms.FechaActual(_tipoCon)

            Dim app = New Microsoft.Office.Interop.Excel.Application()
            Dim workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheetd = workbook.Worksheets(1)
            worksheetd.Name = "REPORTES"

            Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataTable(data)
            worksheetd.Range("A1:" & ic & (data.Rows.Count + 50)).Font.Size = 10

            worksheetd.Range("A1:" & ic & "1").Merge()
            worksheetd.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
            worksheetd.Range("A1:" & ic & "1").Font.Bold = True
            worksheetd.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            worksheetd.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
            worksheetd.Range("A1:" & ic & "1").Font.Color = Color.White
            worksheetd.Range("A1:" & ic & "1").Font.Size = 12
            worksheetd.Range("A2:" & ic & "2").Merge()
            worksheetd.Range("A2:" & ic & "2").Value = "CONTROL DE CUMPLIMIENTO"
            worksheetd.Range("A2:" & ic & "2").Font.Size = 12
            worksheetd.Range("A3:" & ic & "3").Merge()
            worksheetd.Range("A3:" & ic & "3").Value = "TURNO: " & Label8.Text.Trim
            worksheetd.Range("A3:" & ic & "3").Font.Size = 12
            worksheetd.Range("A5:" & ic & "5").Merge()
            worksheetd.Range("A5:" & ic & "5").Value = "Fecha: " & DateTimePicker5.Value.ToString("dd/MM/yyyy") & "              Fecha de Impresión: " & fec.ToString("dd/MM/yyyy")
            worksheetd.Range("A5:" & ic & "5").Font.Size = 12

            Dim headd = 7
            For i = 1 To data.Columns.Count
                worksheetd.Cells(headd, i) = data.Columns(i - 1).Caption
                worksheetd.Cells(headd, i).Font.Bold = True
                worksheetd.Cells(headd, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheetd.Cells(headd, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheetd.Cells(headd, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheetd.Cells(headd, i).Font.Color = Color.White
            Next

            Dim fdata = headd + 1
            For Each row As DataRow In data.Rows
                For j = 0 To data.Columns.Count - 1
                    worksheetd.Cells(fdata, j + 1) = row.Item(j)
                    If j > 0 Then worksheetd.Cells(fdata, j + 1).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                    worksheetd.Cells(fdata, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheetd.Cells(fdata, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    If fdata = data.Rows.Count + headd Then worksheetd.Cells(fdata, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                Next
                fdata += 1
            Next

            ' MULTAS
            Dim datos = _objAsignacionPersonal.SeleccionarRegistroMultasDatosExceptoRadio(_tipoCon, fechaDesde, fechaHasta)
            If datos.Rows.Count > 0 Then
                data.Columns(3).Caption = "VALOR"
                data.Columns(4).Caption = "TIPO"

                Dim x = fdata
                worksheetd.Range("A" & x & ":" & ic & x).Merge()
                worksheetd.Range("A" & x & ":" & ic & x).Value = "OTRAS SANCIONES Y/O MULTAS"
                worksheetd.Range("A" & x & ":" & ic & x).Font.Bold = True
                worksheetd.Range("A" & x & ":" & ic & x).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheetd.Range("A" & x & ":" & ic & x).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheetd.Range("A" & x & ":" & ic & x).Font.Color = Color.White
                worksheetd.Range("A" & x & ":" & ic & x).Font.Size = 12

                For i = 1 To data.Columns.Count
                    worksheetd.Cells(1 + x, i) = data.Columns(i - 1).Caption
                    worksheetd.Cells(1 + x, i).Font.Bold = True
                    worksheetd.Cells(1 + x, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheetd.Cells(1 + x, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheetd.Cells(1 + x, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheetd.Cells(1 + x, i).Font.Color = Color.White
                Next


                data.Rows.Clear()
                For Each dato As DataRow In datos.Rows
                    data.Rows.Add(dato(0), dato(1), dato(2), dato(3), dato(4), dato(5), dato(6))
                Next

                fdata = x + 2
                For Each row As DataRow In data.Rows
                    For j = 0 To data.Columns.Count - 1
                        worksheetd.Cells(fdata, j + 1) = row.Item(j)
                        If j > 0 Then worksheetd.Cells(fdata, j + 1).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        worksheetd.Cells(fdata, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheetd.Cells(fdata, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If fdata = data.Rows.Count + x + 1 Then worksheetd.Cells(fdata, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                    Next
                    fdata += 1
                Next
            End If

            worksheetd.Range("A1:" & ic & data.Rows.Count + 50).Columns.AutoFit()

            worksheetd.Columns(ic).ColumnWidth = 40
            worksheetd.Columns(ic).WrapText = True

            app.DisplayAlerts = False
            app.Visible = True
            app.DisplayAlerts = True
            'Catch ex As Exception
            '    MessageBox.Show("Error al exportar datos! " & vbNewLine & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        End Sub

        Private Function NumToCharExcel(ByVal i As Integer) As String
            Dim data() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ",
                          "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP",
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
                worksheetd.Range("A3:" & id & "3").Merge()
                worksheetd.Range("A3:" & id & "3").Value = "TURNO: " & Label8.Text.Trim
                worksheetd.Range("A3:" & id & "3").Font.Size = 12
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
                worksheetn.Range("A3:" & io & "3").Merge()
                worksheetn.Range("A3:" & io & "3").Value = "TURNO: " & Label8.Text.Trim
                worksheetn.Range("A3:" & io & "3").Font.Size = 12
                worksheetn.Range("A4:" & io & "4").Merge()
                worksheetn.Range("A4:" & io & "4").Value = "Fecha: " & DateTimePicker5.Value & "              Fecha de Impresión: " & Date.Now
                worksheetn.Range("A4:" & io & "4").Font.Size = 12

                Dim headd = 6
                Dim footd = headd + dgvDia.RowCount + 2

                Dim headn = 6
                Dim footn = headn + dgvNoche.RowCount + 2

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
                MessageBox.Show("Error al exportar datos! " & vbNewLine & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub GUARDARCAMBIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles GUARDARCAMBIOSToolStripMenuItem.Click
            TabControl1.TabPages(0).Text = "DÍA - " & dgvDia.RowCount & " VIGILANTES"
            TabControl1.TabPages(1).Text = "NOCHE - " & dgvNoche.RowCount & " VIGILANTES"

            Guardar(True)
        End Sub

        Private Sub AGREGARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click

            _hoy = ValidationForms.FechaActual(_tipoCon)
            Dim nombreU As String = ""

            If Not Admin And _hoy > DateTimePicker4.Value.AddDays(2).AddHours(2) Then
                'If Not _modificar Then
                KryptonMessageBox.Show("HAN PASADO MÁS DE 48H, NO SE PUEDE MODIFICAR EL REPORTE CORRESPONDIENTE!!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            Dim frm As New FrmAgregarPersonalReporte
            frm.TipoCox = TipoCox
            frm.Text = "AGREGAR VIGILANTE DE TURNO " & If(TabControl1.SelectedIndex = 0, "DÍA", "NOCHE")
            frm.EsDiurno = (TabControl1.SelectedIndex = 0)

            Select Case DateTimePicker5.Value.DayOfWeek
                Case 0 : frm.NomDia = "DOMINGO"
                Case 1 : frm.NomDia = "LUNES"
                Case 2 : frm.NomDia = "MARTES"
                Case 3 : frm.NomDia = "MIERCOLES"
                Case 4 : frm.NomDia = "JUEVES"
                Case 5 : frm.NomDia = "VIERNES"
                Case 6 : frm.NomDia = "SABADO"
                Case Else : frm.NomDia = String.Empty
            End Select

            If frm.ShowDialog = vbOK Then
                If frm.txtIdPersonal.Text.Trim.Length > 0 And frm.lblIdHorario.Text.Trim.Length > 0 And frm.txtIdPuesto.Text.Trim.Length > 0 Then

                    If frm.lblDiaNoche.Text.Equals("1") Then
                        If ExisteRegistroDia(frm.txtIdPersonal.Text.Trim, frm.lblIdHorario.Text.Trim) Then
                            MessageBox.Show("Ya existe el personal en el mismo puesto / horario que intenta agregar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    Else
                        If ExisteRegistroNoche(frm.txtIdPersonal.Text.Trim, frm.lblIdHorario.Text.Trim) Then
                            MessageBox.Show("Ya existe el personal en el mismo puesto / horario que intenta agregar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End If

                    Dim ho As String
                    Select Case DateTimePicker5.Value.DayOfWeek
                        Case 0 : ho = frm.dtpDeDomingo.Text & " ~ " & frm.dtpADomingo.Text
                        Case 1 : ho = frm.dtpDeLunes.Text & " ~ " & frm.dtpALunes.Text
                        Case 2 : ho = frm.dtpDeMartes.Text & " ~ " & frm.dtpAMartes.Text
                        Case 3 : ho = frm.dtpDeMiercoles.Text & " ~ " & frm.dtpAMiercoles.Text
                        Case 4 : ho = frm.dtpDeJueves.Text & " ~ " & frm.dtpAJueves.Text
                        Case 5 : ho = frm.dtpDeViernes.Text & " ~ " & frm.dtpAViernes.Text
                        Case 6 : ho = frm.dtpDeSabado.Text & " ~ " & frm.dtpASabado.Text
                        Case Else : ho = String.Empty
                    End Select

                    If frm.lblDiaNoche.Text.Equals("1") Then
                        Try
                            dgvDia.Rows.Add(NumeroRiver(frm.lblRiver.Text.Trim), frm.lblRiver.Text.Trim, TextBox3.Text.Trim, frm.txtIdPersonal.Text.Trim, frm.txtPersonal.Text.Trim, frm.txtIdPuesto.Text.Trim, frm.txtUbicacionPuesto.Text.Trim, frm.lblDireccion.Text.Trim, frm.lblIdHorario.Text.Trim, ho, "PENDIENTE", "-", "-", "-", "-", "-")
                            _r = dgvDia.Rows(dgvDia.RowCount - 1)
                            dgvDia.Sort(dgvDia.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

                            If dgvDia.ColumnCount > 15 Then
                                For i = 16 To dgvDia.ColumnCount - 1
                                    If dgvDia.Columns(i).Name.StartsWith("RR") Then
                                        _r.Cells(i).Value = False
                                    Else
                                        _r.Cells(i).Value = "-"
                                    End If
                                Next
                            End If

                            dgvDia.Refresh()
                            _r.Selected = True
                            _r.Tag = "0|||" & Usuario
                            dgvDia.FirstDisplayedScrollingRowIndex = dgvDia.SelectedRows(0).Index

                            TabControl1.TabPages(0).Text = "DÍA - " & dgvDia.RowCount & " VIGILANTES"
                            nombreU = "Se agrega " & frm.txtIdPersonal.Text & " en R. ASISTENCIA DIA ID: " & TextBox3.Text & " por: " & UserName
                        Catch ex As Exception
                            MessageBox.Show("ERROR: En AGREGARToolStripMenuItem() DIA, " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try
                    Else
                        Try
                            dgvNoche.Rows.Add(NumeroRiver(frm.lblRiver.Text.Trim), frm.lblRiver.Text.Trim, TextBox3.Text.Trim, frm.txtIdPersonal.Text.Trim, frm.txtPersonal.Text.Trim, frm.txtIdPuesto.Text.Trim, frm.txtUbicacionPuesto.Text.Trim, frm.lblDireccion.Text.Trim, frm.lblIdHorario.Text.Trim, ho, "PENDIENTE", "-", "-", "-", "-", "-")
                            _r = dgvNoche.Rows(dgvNoche.RowCount - 1)
                            dgvNoche.Sort(dgvNoche.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

                            If dgvNoche.ColumnCount > 15 Then
                                For i = 16 To dgvNoche.ColumnCount - 1
                                    If dgvNoche.Columns(i).Name.StartsWith("RR") Then
                                        _r.Cells(i).Value = False
                                    Else
                                        _r.Cells(i).Value = "-"
                                    End If
                                Next
                            End If

                            dgvNoche.Refresh()
                            _r.Selected = True
                            _r.Tag = "0|||" & Usuario
                            dgvNoche.FirstDisplayedScrollingRowIndex = dgvNoche.SelectedRows(0).Index

                            TabControl1.TabPages(1).Text = "NOCHE - " & dgvNoche.RowCount & " VIGILANTES"
                            nombreU = "Se agrega " & frm.txtIdPersonal.Text & " en R. Asistencia Noche ID: " & TextBox3.Text & " por: " & UserName
                        Catch ex As Exception
                            MessageBox.Show("ERROR: En AGREGARToolStripMenuItem() NOCHE, " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try
                    End If
                Else
                    MessageBox.Show("No seleccionó nigún registro!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            VerificarFaltas()

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
        End Sub

        Private Sub CAMBIARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCambiar.Click
            If TabControl1.SelectedIndex = 0 And dgvDia.RowCount = 0 Then Return
            If TabControl1.SelectedIndex = 1 And dgvNoche.RowCount = 0 Then Return

            _hoy = ValidationForms.FechaActual(_tipoCon)

            If Not Admin And _hoy > DateTimePicker5.Value.AddDays(2).AddHours(2) Then
                MessageBox.Show("HAN PASADO MÁS DE 48H, NO SE PUEDE MODIFICAR EL REPORTE CORRESPONDIENTE!!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If TabControl1.SelectedIndex = 0 Then
                If MessageBox.Show("El puesto de " & dgvDia.CurrentRow.Cells(4).Value & " será cubierto por otro vigilante. Si la respuesta es 'SI' seleccione el nombre del vigilante que cubrirá el puesto", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Else
                If MessageBox.Show("El puesto de " & dgvNoche.CurrentRow.Cells(4).Value & " será cubierto por otro vigilante. Si la respuesta es 'SI' seleccione el nombre del vigilante que cubrirá el puesto", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            End If

            Try
                Dim frm As New FrmBuscarProveedorCliente
                frm.TipoCox = TipoCox
                frm.IsOperaciones = True
                frm.IsAdmin = False
                frm.rbtProveedor.Visible = False
                frm.rbtPersonal.Checked = True
                frm.rbtCliente.Visible = False
                frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
                frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
                If frm.ShowDialog = vbOK Then

                    If TabControl1.SelectedIndex = 0 Then
                        If ExisteRegistroDia(frm.dgvCustodios.CurrentRow.Cells.Item(0).Value, dgvDia.CurrentRow.Cells(8).Value) Then
                            MessageBox.Show("Ya existe el personal en el mismo puesto / horario que intenta agregar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    Else
                        If ExisteRegistroNoche(frm.dgvCustodios.CurrentRow.Cells.Item(0).Value, dgvDia.CurrentRow.Cells(8).Value) Then
                            MessageBox.Show("Ya existe el personal en el mismo puesto / horario que intenta agregar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End If

                    If frm.rbtPersonal.Checked Then
                        If TabControl1.SelectedIndex = 0 Then
                            dgvDia.CurrentRow.Cells(3).Value = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                            dgvDia.CurrentRow.Cells(4).Value = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                        Else
                            dgvNoche.CurrentRow.Cells(3).Value = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                            dgvNoche.CurrentRow.Cells(4).Value = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                        End If
                    End If


                End If

                VerificarFaltas()
            Catch ex As Exception
                MessageBox.Show("Erro al cambiar: " & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub QUITARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnQuitar.Click
            If TabControl1.SelectedIndex = 0 And dgvDia.RowCount = 0 Then Return
            If TabControl1.SelectedIndex = 1 And dgvNoche.RowCount = 0 Then Return

            _hoy = ValidationForms.FechaActual(_tipoCon)

            If Not Admin And _hoy > DateTimePicker5.Value.AddDays(2).AddHours(2) Then
                KryptonMessageBox.Show("HAN PASADO MÁS DE 48H, NO SE PUEDE MODIFICAR EL REPORTE CORRESPONDIENTE!!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If KryptonMessageBox.Show("Seguro que desea quitar este registro", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try

                If TabControl1.SelectedIndex = 0 Then
                    'I need the value copy the value in dgvDia.CurrentRow.Cells(3).Value
                    Dim idpValue = dgvDia.SelectedRows(0).Cells(3).Value.ToString()
                    Dim nombreU As String = "Se elimina a " & idpValue & " en R. ASISTENCIA por  " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    dgvDia.Rows.Remove(dgvDia.SelectedRows(0))
                    TabControl1.TabPages(0).Text = "DÍA - " & dgvDia.RowCount & " VIGILANTES"

                Else
                    Dim idpValue = dgvNoche.SelectedRows(0).Cells(3).Value.ToString()
                    Dim nombreU As String = "Se elimina a " & idpValue & " en R. ASISTENCIA por  " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    dgvNoche.Rows.Remove(dgvNoche.SelectedRows(0))
                    TabControl1.TabPages(1).Text = "NOCHE - " & dgvNoche.RowCount & " VIGILANTES"
                End If
                VerificarFaltas()

            Catch ex As Exception
                MessageBox.Show("Ocurrio un problema al quitar fila: " & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub AGREGARDETRADIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAddRad.Click
            If TabControl1.SelectedIndex = 0 And dgvDia.RowCount = 0 Then Return
            If TabControl1.SelectedIndex = 1 And dgvNoche.RowCount = 0 Then Return

            Try
                Dim nd = ContarColumnasReporte(dgvDia)
                Dim nn = ContarColumnasReporte(dgvNoche)

                Dim c = New DataGridViewCheckBoxColumn
                c.Width = 40
                c.CellTemplate = New DataGridViewCheckBoxCell()

                Dim d = New DataGridViewTextBoxColumn
                d.HeaderText = "HORA"
                d.Width = 50
                d.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                d.CellTemplate = New DataGridViewTextBoxCell()
                d.DividerWidth = 1

                If TabControl1.SelectedIndex = 0 Then
                    c.Tag = nd + 1
                    c.HeaderText = "REP " & (nd + 1)
                    c.Name = "RR" & (nd + 1)
                    d.Name = "HR" & (nd + 1)
                    dgvDia.Columns.Add(c)
                    dgvDia.Columns.Add(d)

                    DefaultValueReporte(dgvDia)

                    dgvDia.Refresh()
                    dgvDia.FirstDisplayedCell = dgvDia.SelectedRows(0).Cells(dgvDia.ColumnCount - 1)
                Else
                    c.Tag = nn + 1
                    c.HeaderText = "REP " & (nn + 1)
                    c.Name = "RR" & (nn + 1)
                    d.Name = "HR" & (nn + 1)
                    dgvNoche.Columns.Add(c)
                    dgvNoche.Columns.Add(d)

                    DefaultValueReporte(dgvNoche)

                    dgvNoche.Refresh()
                    dgvNoche.FirstDisplayedCell = dgvNoche.SelectedRows(0).Cells(dgvNoche.ColumnCount - 1)
                End If

                VerificarFaltas()
            Catch ex As Exception
                MessageBox.Show("Ocurrio un problema al agregar columna reporte: " & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub QUTARDETRADIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem6.Click
            If TabControl1.SelectedIndex = 0 And dgvDia.RowCount = 0 Then Return
            If TabControl1.SelectedIndex = 1 And dgvNoche.RowCount = 0 Then Return

            If MessageBox.Show("Desea quitar la última columna de reportes?" & vbNewLine & "Nota: El proceso es irreversible!", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            If TabControl1.SelectedIndex = 0 Then
                If dgvDia.ColumnCount - 2 > 15 Then
                    dgvDia.Columns.Remove(dgvDia.Columns(dgvDia.ColumnCount - 1))
                    dgvDia.Columns.Remove(dgvDia.Columns(dgvDia.ColumnCount - 1))
                    dgvDia.Refresh()
                End If
            Else
                If dgvNoche.ColumnCount - 2 > 15 Then
                    dgvNoche.Columns.Remove(dgvNoche.Columns(dgvNoche.ColumnCount - 1))
                    dgvNoche.Columns.Remove(dgvNoche.Columns(dgvNoche.ColumnCount - 1))
                    dgvNoche.Refresh()
                End If
            End If
        End Sub

        Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If TabControl1.SelectedIndex = 0 And dgvDia.RowCount = 0 Then Return
            If TabControl1.SelectedIndex = 1 And dgvNoche.RowCount = 0 Then Return
            Dim c As DataGridViewCheckBoxColumn
            Dim d As DataGridViewTextBoxColumn
            Dim str As String

            _hoy = ValidationForms.FechaActual(_tipoCon)

            If Not Admin And _hoy > DateTimePicker4.Value.AddDays(2).AddHours(2) Then
                MessageBox.Show("HAN PASADO MÁS DE 48H, NO SE PUEDE MODIFICAR EL REPORTE CORRESPONDIENTE!!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If TabControl1.SelectedIndex = 0 Then
                If MessageBox.Show("El turno de " & dgvDia.CurrentRow.Cells(4).Value & " será cambiado a la NOCHE?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                _r = dgvDia.CurrentRow
                str = If((_r.Tag & "").ToString.Trim.Length = 0, "0|||0", _r.Tag & "")

                dgvDia.Rows.Remove(_r)

                Dim cc = ContarColumnasReporte(dgvNoche)
                Dim nn = ContarColumnasReporte(dgvDia) - ContarColumnasReporte(dgvNoche)
                If nn > 0 Then
                    For i = 1 To nn Step 1
                        c = New DataGridViewCheckBoxColumn
                        c.Width = 40
                        c.CellTemplate = New DataGridViewCheckBoxCell()

                        d = New DataGridViewTextBoxColumn
                        d.HeaderText = "HORA"
                        d.Width = 50
                        d.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        d.CellTemplate = New DataGridViewTextBoxCell()
                        d.DividerWidth = 1

                        c.Tag = (cc + i)
                        c.HeaderText = "REP " & (cc + i)
                        c.Name = "RR" & (cc + i)
                        d.Name = "HR" & (cc + i)
                        d.DefaultCellStyle.NullValue = "-"
                        dgvNoche.Columns.Add(c)
                        dgvNoche.Columns.Add(d)
                    Next
                End If

                dgvNoche.Rows.Add()
                For i = 0 To dgvNoche.ColumnCount - 1
                    Try
                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(i).Value = _r.Cells(i).Value
                        If i = 11 Then
                            If _r.Cells(10).Value = "PENDIENTE" Then
                                dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = _r.Cells(0).Style.BackColor
                            Else
                                If _r.Cells(10).Value = "ASISTENCIA" Then
                                    dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 34, 139, 34)
                                Else
                                    If _r.Cells(10).Value = "ATRASO" Then
                                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    ElseIf _r.Cells(10).Value = "PERMISO MÉDICO" Then
                                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    ElseIf _r.Cells(10).Value = "DOBLADA" Then
                                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    ElseIf _r.Cells(10).Value = "VACACIONES" Then
                                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                                    ElseIf _r.Cells(10).Value = "CALAMIDAD DOMÉSTICA" Then
                                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    Else
                                        dgvNoche.Rows(dgvNoche.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                                    End If
                                End If
                            End If
                        End If
                    Catch
                    End Try
                Next

                TabControl1.SelectedIndex = 1
                TabControl1.TabPages(1).Text = "NOCHE - " & dgvNoche.RowCount & " VIGILANTES"

                _r = dgvNoche.Rows(dgvNoche.RowCount - 1)
                _r.Tag = str

                If str.Split("|")(1).Trim.Length > 0 Then _r.Cells(1).Style.BackColor = Color.LightSkyBlue

                dgvNoche.FirstDisplayedScrollingRowIndex = dgvNoche.SelectedRows(0).Index
                dgvNoche.Sort(dgvNoche.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

                ' CAMBIAR HORARIO (254 DIA, 255 NOCHE)
                _r.Cells(8).Value = 255
                _r.Cells(9).Value = "19:00 ~ 07:00"

                _r.Selected = True
                dgvNoche.FirstDisplayedScrollingRowIndex = dgvNoche.SelectedRows(0).Index
            Else
                If MessageBox.Show("El turno de " & dgvNoche.CurrentRow.Cells(4).Value & " será cambiado a la DÍA?", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                _r = dgvNoche.CurrentRow
                str = If((_r.Tag & "").ToString.Trim.Length = 0, "0|||0", _r.Tag & "")

                dgvNoche.Rows.Remove(_r)

                Dim cc = ContarColumnasReporte(dgvDia)
                Dim nn = ContarColumnasReporte(dgvNoche) - ContarColumnasReporte(dgvDia)
                If nn > 0 Then
                    For i = 1 To nn Step 1
                        c = New DataGridViewCheckBoxColumn
                        c.Width = 40
                        c.CellTemplate = New DataGridViewCheckBoxCell()

                        d = New DataGridViewTextBoxColumn
                        d.HeaderText = "HORA"
                        d.Width = 50
                        d.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        d.CellTemplate = New DataGridViewTextBoxCell()
                        d.DividerWidth = 1

                        c.Tag = (cc + i)
                        c.HeaderText = "REP " & (cc + i)
                        c.Name = "RR" & (cc + i)
                        d.Name = "HR" & (cc + i)
                        d.DefaultCellStyle.NullValue = "-"
                        dgvDia.Columns.Add(c)
                        dgvDia.Columns.Add(d)
                    Next
                End If

                dgvDia.Rows.Add()
                For i = 0 To dgvDia.ColumnCount - 1
                    Try
                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(i).Value = _r.Cells(i).Value

                        If i = 11 Then
                            If _r.Cells(10).Value = "PENDIENTE" Then
                                dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = _r.Cells(0).Style.BackColor
                            Else
                                If _r.Cells(10).Value = "ASISTENCIA" Then
                                    dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 34, 139, 34)
                                Else
                                    If _r.Cells(10).Value = "ATRASO" Then
                                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    ElseIf _r.Cells(10).Value = "PERMISO MÉDICO" Then
                                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    ElseIf _r.Cells(10).Value = "DOBLADA" Then
                                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    ElseIf _r.Cells(10).Value = "VACACIONES" Then
                                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 135, 206, 235)
                                    ElseIf _r.Cells(10).Value = "CALAMIDAD DOMÉSTICA" Then
                                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 255, 218, 155)
                                    Else
                                        dgvDia.Rows(dgvDia.RowCount - 1).Cells(11).Style.BackColor = Color.FromArgb(255, 240, 128, 128)
                                    End If
                                End If
                            End If
                        End If
                    Catch
                    End Try
                Next

                TabControl1.SelectedIndex = 0
                TabControl1.TabPages(0).Text = "DÍA - " & dgvDia.RowCount & " VIGILANTES"

                _r = dgvDia.Rows(dgvDia.RowCount - 1)
                _r.Tag = str

                If str.Split("|")(1).Trim.Length > 0 Then _r.Cells(1).Style.BackColor = Color.LightSkyBlue
                dgvDia.FirstDisplayedScrollingRowIndex = dgvDia.SelectedRows(0).Index
                dgvDia.Sort(dgvDia.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

                ' CAMBIAR HORARIO (254 DIA, 255 NOCHE)
                _r.Cells(8).Value = 254
                _r.Cells(9).Value = "07:00 ~ 19:00"

                _r.Selected = True
                dgvDia.FirstDisplayedScrollingRowIndex = dgvDia.SelectedRows(0).Index
            End If

            VerificarFaltas()

        End Sub

        Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Button6_Click(Nothing, Nothing)
        End Sub

        Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem3.Click
            If TabControl1.SelectedIndex = 0 And dgvDia.RowCount = 0 Then Return
            If TabControl1.SelectedIndex = 1 And dgvNoche.RowCount = 0 Then Return

            _hoy = ValidationForms.FechaActual(_tipoCon)

            'If _hoy > DateTimePicker5.Value.AddDays(2).AddHours(2) Then
            If Not Admin And _hoy > DateTimePicker4.Value.AddDays(2).AddHours(2) Then
                'If Not _modificar Then
                MessageBox.Show("HAN PASADO MÁS DE 48H, NO SE PUEDE MODIFICAR EL REPORTE CORRESPONDIENTE!!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If TabControl1.SelectedIndex = 0 Then
                If MessageBox.Show("Está por cambiar el puesto de " & dgvDia.CurrentRow.Cells(4).Value & ". Si la respuesta es 'SI' deberá seleccionar el nuevo puesto", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Else
                If MessageBox.Show("Está por cambiar el puesto de " & dgvNoche.CurrentRow.Cells(4).Value & ". Si la respuesta es 'SI' deberá seleccionar el nuevo puesto", "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            End If

            Try
                Dim frm As New FrmBuscarPuestoTrabajo
                frm.TipoCox = TipoCox
                frm.Label3.Text = "TODOS LOS PUESTOS REGISTRADOS"
                frm.Text = "SELECCIONAR SITIO DE TRABAJO"

                If frm.ShowDialog = vbOK Then
                    If TabControl1.SelectedIndex = 0 Then
                        dgvDia.CurrentRow.Cells(0).Value = NumeroRiver(frm.ListView1.SelectedItems(0).SubItems(1).Text)
                        dgvDia.CurrentRow.Cells(1).Value = frm.ListView1.SelectedItems(0).SubItems(1).Text

                        dgvDia.CurrentRow.Cells(5).Value = frm.ListView1.SelectedItems(0).SubItems(0).Text
                        dgvDia.CurrentRow.Cells(6).Value = frm.ListView1.SelectedItems(0).SubItems(2).Text
                        dgvDia.CurrentRow.Cells(7).Value = frm.ListView1.SelectedItems(0).SubItems(3).Text
                        _r = dgvDia.CurrentRow
                        dgvDia.Sort(dgvDia.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                        dgvDia.Refresh()
                    Else
                        dgvNoche.CurrentRow.Cells(0).Value = NumeroRiver(frm.ListView1.SelectedItems(0).SubItems(1).Text)
                        dgvNoche.CurrentRow.Cells(1).Value = frm.ListView1.SelectedItems(0).SubItems(1).Text

                        dgvNoche.CurrentRow.Cells(5).Value = frm.ListView1.SelectedItems(0).SubItems(0).Text
                        dgvNoche.CurrentRow.Cells(6).Value = frm.ListView1.SelectedItems(0).SubItems(2).Text
                        dgvNoche.CurrentRow.Cells(7).Value = frm.ListView1.SelectedItems(0).SubItems(3).Text
                        _r = dgvNoche.CurrentRow
                        dgvNoche.Sort(dgvNoche.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                        dgvNoche.Refresh()
                    End If
                    dgvDia.FirstDisplayedScrollingRowIndex = _r.Index
                End If

                VerificarFaltas()
            Catch ex As Exception
                MessageBox.Show("Erro al puesto: " & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End Sub

        Private Sub REPORTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTESToolStripMenuItem.Click

        End Sub

        Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        End Sub
    End Class
End Namespace