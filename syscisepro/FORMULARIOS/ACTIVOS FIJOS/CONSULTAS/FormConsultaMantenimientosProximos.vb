Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaMantenimientosProximos
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

        ReadOnly _objActivosFijos As New ClassActivoFijo
        ReadOnly _objBeep As New ClassBeep

        Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFiltrar.Click
            If rbSemana.Checked = True Then
                dgvMantenimientosProximos.DataSource = _objActivosFijos.SeleccionarMantenimientosProximosSemana(_tipoCon)
                If dgvMantenimientosProximos.RowCount > 1 Then
                    _objBeep.Advertir()
                    MsgBox("EXISTEN ACTIVOS QUE ESTA SEMANA NECESITAN DARSE MANTENIMIENTO", MsgBoxStyle.Critical, "MENSAJE DE INFORMACIÓN")
                End If
                dgvMantenimientosProximos.Columns("FECHA_MANTENIMIENTO").DefaultCellStyle.BackColor = Color.Red
                dgvMantenimientosProximos.Columns("FECHA_MANTENIMIENTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvMantenimientosProximos.ReadOnly = False
                dgvMantenimientosProximos.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvMantenimientosProximos.AutoResizeColumns()
                dgvMantenimientosProximos.AutoResizeRows()
            Else
                If rbTodos.Checked = True Then
                    dgvMantenimientosProximos.DataSource = _objActivosFijos.SeleccionarMantenimientosProximosTodos(_tipoCon)
                    dgvMantenimientosProximos.Columns("FECHA_MANTENIMIENTO").DefaultCellStyle.BackColor = Color.Red
                    dgvMantenimientosProximos.Columns("FECHA_MANTENIMIENTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvMantenimientosProximos.Columns("MANTENIMIENTO").DefaultCellStyle.BackColor = Color.Pink
                    dgvMantenimientosProximos.Columns("MANTENIMIENTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvMantenimientosProximos.ReadOnly = False
                    dgvMantenimientosProximos.EditMode = DataGridViewEditMode.EditProgrammatically
                    dgvMantenimientosProximos.AutoResizeColumns()
                    dgvMantenimientosProximos.AutoResizeRows()
                End If
            End If
        End Sub

        Private Sub btnMayores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMayores.Click
            ExportarDatosExcel(dgvMantenimientosProximos, "MAYORES")
        End Sub

        '=== PARA EXPORTAR EN EXCEL ===================================================================================================================================================
        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)
            Dim mExcel As New Excel.Application
            mExcel.Cursor = Excel.XlMousePointer.xlWait
            mExcel.Visible = True
            Dim objLibroExcel As Excel.Workbook = mExcel.Workbooks.Add
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                'Encabezado  
                .Range("A1:L1").Merge()
                .Range("A1:L1").Value = ValidationForms.NombreCompany(_tipoCon)
                .Range("A1:L1").Font.Bold = True
                .Range("A1:L1").Font.Size = 15
                'Copete  
                .Range("A2:L2").Merge()
                .Range("A2:L2").Value = titulo
                .Range("A2:L2").Font.Bold = True
                .Range("A2:L2").Font.Size = 12
                Const primeraLetra As Char = "A"
                Const primerNumero As Short = 3
                Dim letra As Char, ultimaLetra As Char
                Dim numero As Integer, ultimoNumero As Integer
                Dim codLetra As Byte = Asc(primeraLetra) - 1
                Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
                'Establecer formatos de las columnas de la hija de cálculo  
                Dim strColumna As String = ""
                Dim letraIzq As String = ""
                Dim codLetraIzq As Byte = Asc(primeraLetra) - 1
                letra = primeraLetra
                numero = primerNumero
                Dim objCelda As Excel.Range
                For Each c As DataGridViewColumn In dataGridViewExp.Columns
                    If c.Visible Then
                        If letra = "Z" Then
                            letra = primeraLetra
                            codLetra = Asc(primeraLetra)
                            codLetraIzq += 1
                            letraIzq = Chr(codLetraIzq)
                        Else
                            codLetra += 1
                            letra = Chr(codLetra)
                        End If
                        strColumna = letraIzq + letra + numero.ToString
                        objCelda = .Range(strColumna, Type.Missing)
                        objCelda.Value = c.HeaderText
                        objCelda.EntireColumn.Font.Size = 8
                        'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                        If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                            objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                        End If
                    End If
                Next

                Dim objRangoEncab As Excel.Range = .Range(primeraLetra + numero.ToString, letraIzq + letra + numero.ToString)
                objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
                ultimaLetra = letra
                Dim ultimaLetraIzq As String = letraIzq
                'CARGA DE DATOS  
                Dim i As Integer = numero + 1
                For Each reg As DataGridViewRow In dataGridViewExp.Rows
                    letraIzq = ""
                    codLetraIzq = Asc(primeraLetra) - 1
                    letra = primeraLetra
                    codLetra = Asc(primeraLetra) - 1
                    For Each c As DataGridViewColumn In dataGridViewExp.Columns
                        If c.Visible Then
                            If letra = "Z" Then
                                letra = primeraLetra
                                codLetra = Asc(primeraLetra)
                                codLetraIzq += 1
                                letraIzq = Chr(codLetraIzq)
                            Else
                                codLetra += 1
                                letra = Chr(codLetra)
                            End If
                            strColumna = letraIzq + letra
                            ' acá debería realizarse la carga  
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                            '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                            '.Range(strColumna + i, strColumna + i).In()  
                        End If
                    Next
                    Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                    objRangoReg.Rows.BorderAround()
                    objRangoReg.Select()
                    i += 1
                Next
                ultimoNumero = i

                'Dibujar las líneas de las columnas  
                letraIzq = ""
                codLetraIzq = Asc("A")
                codLetra = Asc(primeraLetra)
                letra = primeraLetra
                For Each c As DataGridViewColumn In dataGridViewExp.Columns
                    If c.Visible Then
                        objCelda = .Range(letraIzq + letra + primerNumero.ToString, letraIzq + letra + (ultimoNumero - 1).ToString)
                        objCelda.BorderAround()
                        If letra = "Z" Then
                            letra = primeraLetra
                            codLetra = Asc(primeraLetra)
                            letraIzq = Chr(codLetraIzq)
                            codLetraIzq += 1
                        Else
                            codLetra += 1
                            letra = Chr(codLetra)
                        End If
                    End If
                Next
                'Dibujar el border exterior grueso  
                Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, ultimaLetraIzq + ultimaLetra + (ultimoNumero - 1).ToString)
                objRango.Select()
                objRango.Columns.AutoFit()
                objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            End With
            mExcel.Cursor = Excel.XlMousePointer.xlDefault
        End Sub

        Private Sub FormConsultaMantenimientosProximos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvMantenimientosProximos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvMantenimientosProximos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvMantenimientosProximos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvMantenimientosProximos.Font = New Font("Roboto", 8.25, FontStyle.Regular)
        End Sub
    End Class
End Namespace