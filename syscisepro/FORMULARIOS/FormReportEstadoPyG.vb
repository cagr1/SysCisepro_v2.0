Imports ClassLibraryCisepro.ENUMS
Imports Krypton.Toolkit

Public Class FormReportEstadoPyG

    Private _tipoCon As TipoConexion


    Public Property SelectedRange As Integer
    Public Property FechaDesde As Date
    Public Property FechaHasta As Date
    Public Property ShowColumns As Integer
    Public Property Previo As Boolean
    Public Property CambioPrevio As Boolean
    Public Property PorcentajePrevio As Boolean
    Public Property Anterior As Boolean
    Public Property CambioAnterior As Boolean
    Public Property PorcentajeAnterior As Boolean


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
    Private Sub KryptonInputBoxForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _tipoCon
            Case TipoConexion.Asenava
                Icon = My.Resources.logo_a

            Case TipoConexion.Seportpac
                Icon = My.Resources.logo_s

            Case Else
                Icon = My.Resources.logo_c

        End Select



        dtpFechaDesdeMes.Value = FechaDesde
        dtpFechaHastaMes.Value = FechaHasta
        cbxShowColumns.SelectedIndex = ShowColumns
        chkPrevio.Checked = Previo
        chkCambioPrevio.Checked = CambioPrevio
        chkPorcPrevio.Checked = PorcentajePrevio
        chkAnterior.Checked = Anterior
        chkCambioAnterior.Checked = CambioAnterior
        chkPorcAnterior.Checked = PorcentajeAnterior



    End Sub

    Private Sub chkAnterior_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnterior.CheckedChanged
        If chkAnterior.Checked Then
            chkCambioAnterior.Enabled = True
            chkPorcAnterior.Enabled = True
        Else
            chkCambioAnterior.Enabled = False
            chkPorcAnterior.Enabled = False
        End If
    End Sub

    Private Sub chkPrevio_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrevio.CheckedChanged
        If chkPrevio.Checked Then
            chkCambioPrevio.Enabled = True
            chkPorcPrevio.Enabled = True
        Else
            chkCambioPrevio.Enabled = False
            chkPorcPrevio.Enabled = False
        End If


    End Sub

    Private Sub btnAcpetar_Click(sender As Object, e As EventArgs) Handles btnAcpetar.Click


        If chkPrevio.Checked AndAlso chkAnterior.Checked Then
            KryptonMessageBox.Show("No se puede seleccionar ambos periodos", "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            Return
        End If



        ' Guardar los valores antes de cerrar


        FechaDesde = dtpFechaDesdeMes.Value
        FechaHasta = dtpFechaHastaMes.Value
        ShowColumns = cbxShowColumns.SelectedIndex


        If chkPrevio.Checked Then
            Anterior = False
            CambioAnterior = False
            PorcentajeAnterior = False
            CambioPrevio = chkCambioPrevio.Checked
            PorcentajePrevio = chkPorcPrevio.Checked
            Previo = True
        ElseIf chkAnterior.Checked Then
            Anterior = True
            CambioAnterior = chkCambioAnterior.Checked
            PorcentajeAnterior = chkPorcAnterior.Checked
            Previo = False
            CambioPrevio = False
            PorcentajePrevio = False
        Else
            Anterior = False
            CambioAnterior = False
            PorcentajeAnterior = False
            Previo = False
            CambioPrevio = False
            PorcentajePrevio = False
        End If


        ' Cerrar con resultado OK
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    'Private Sub cbxDates_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Dim selectedRange As String = cbxDates.SelectedItem.ToString()

    '    Select Case selectedRange.Trim()
    '        Case "Mensual"
    '            ' Desde el primer día del mes actual
    '            dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1)
    '            dtpFechaHastaMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, Date.DaysInMonth(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month))

    '        Case "Trimestral"
    '            ' Desde el primer día del mes, restando 2 meses (para cubrir 3 meses en total)
    '            dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1).AddMonths(-2)

    '        Case "Semestral"
    '            ' Desde el primer día del mes, restando 5 meses (para cubrir 6 meses en total)
    '            dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1).AddMonths(-5)

    '        Case "Anual"
    '            ' Desde el primer día del mes, restando 1 año
    '            dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year - 1, dtpFechaHastaMes.Value.Month, dtpFechaHastaMes.Value.Day)


    '        Case "Custom"
    '            ' No hacer cambios en las fechas, el usuario las define manualmente
    '    End Select
    'End Sub

    Private Sub dtpFechaDesdeMes_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesdeMes.ValueChanged
        'UpdateCbxDates()
    End Sub

    'Private Sub UpdateCbxDates()
    '    Dim fechaDesde As Date = dtpFechaDesdeMes.Value
    '    Dim fechaHasta As Date = dtpFechaHastaMes.Value

    '    RemoveHandler cbxDates.SelectedIndexChanged, AddressOf cbxDates_SelectedIndexChanged

    '    'Verificar si el rango de fechas coincide con un periodo estandar
    '    If IsMonthlyRange(fechaDesde, fechaHasta) Then
    '        cbxDates.SelectedIndex = 0
    '    ElseIf IsQuarterlyRange(fechaDesde, fechaHasta) Then
    '        cbxDates.SelectedIndex = 1
    '    ElseIf IsSemestralRange(fechaDesde, fechaHasta) Then
    '        cbxDates.SelectedIndex = 2
    '    ElseIf IsAnnualRange(fechaDesde, fechaHasta) Then
    '        cbxDates.SelectedIndex = 3
    '    Else
    '        cbxDates.SelectedIndex = 4
    '    End If

    '    AddHandler cbxDates.SelectedIndexChanged, AddressOf cbxDates_SelectedIndexChanged

    'End Sub

    Private Function IsMonthlyRange(ByVal fechadesde As Date, ByVal fechashasta As Date) As Boolean
        Return fechadesde.Day = 1 AndAlso fechashasta = fechadesde.AddMonths(1).AddDays(-1)
    End Function

    Private Function IsQuarterlyRange(fechaDesde As Date, fechaHasta As Date) As Boolean
        Return fechaDesde.Day = 1 AndAlso fechaHasta = fechaDesde.AddMonths(3).AddDays(-1)
    End Function

    Private Function IsSemestralRange(fechaDesde As Date, fechaHasta As Date) As Boolean
        Return fechaDesde.Day = 1 AndAlso fechaHasta = fechaDesde.AddMonths(6).AddDays(-1)
    End Function

    Private Function IsAnnualRange(fechaDesde As Date, fechaHasta As Date) As Boolean
        Return fechaDesde.Day = 1 AndAlso fechaHasta = fechaDesde.AddYears(1).AddDays(-1)
    End Function


End Class