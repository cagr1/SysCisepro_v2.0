Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit
Imports System.Windows.Forms
Imports System.Drawing

Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaActivosFijos

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

        ReadOnly _objActivo As New ClassActivoFijo

        Private Sub CargarArmas()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarArmas(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarRadios()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarRadios(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarVehiculos()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarVehículos(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarTerrenos()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarTerrenos(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarEquiposComputo()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarEquiposdeComputo(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarLibrosColecciones()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarLibrosYColecciones(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarEquiposOficina()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarEquiposDeOficina(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarMueblesOficina()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarMueblesDeOficina(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarEquiposCocina()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarEquiposDeCocina(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarEquiposAmbientacion()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarEquiposDeAmbientación(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarEquiposComunicacion()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarEquiposDeComunicacionYTelefonia(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarEquiposSeguridad()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarEquiposDeSeguridadIndustrial(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarCamarasSeguridad()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarCamarasSeguridad(_tipoCon)
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarGeneradores()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarGeneradores(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarChalecos()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarChalecos(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarSoftware()
            Try
                dgvActivosFijos.DataSource = _objActivo.SeleccionarSoftware(_tipoCon)
                dgvActivosFijos.Columns(8).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                dgvActivosFijos.AutoResizeColumns()
                dgvActivosFijos.AutoResizeRows()
            Catch ex As Exception
                dgvActivosFijos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub CargarValoresActivos()
            Try
                dgvTotalActivosFijos.DataSource = _objActivo.SeleccionaTotalActivosFijosValores(_tipoCon)
                For indice = 0 To dgvTotalActivosFijos.ColumnCount - 1
                    dgvTotalActivosFijos.Columns(indice).DefaultCellStyle.Alignment() = DataGridViewContentAlignment.MiddleRight
                Next
                dgvTotalActivosFijos.AutoResizeColumns()
                dgvTotalActivosFijos.AutoResizeRows()
            Catch
                dgvTotalActivosFijos.DataSource = Nothing
            End Try
        End Sub

        Private Sub Sumar()
            txtTotal.Text = "0.00"
            txtCantidad.Text = "0.00"
            Dim suma As Decimal = 0
            Dim cantidad = 0
            Try
                For indice = 0 To dgvActivosFijos.RowCount - 1
                    suma += CDec(dgvActivosFijos.Rows(indice).Cells("COSTO").Value)
                    cantidad += 1
                Next
                txtTotal.Text = suma
                txtCantidad.Text = cantidad
            Catch
                txtTotal.Text = "0.00"
                txtCantidad.Text = "0.00"
            End Try
        End Sub

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
                Dim letra As Char
                Dim ultimaLetra As Char
                Dim numero As Integer
                Dim ultimoNumero As Integer
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

        Private Sub FormConsultaActivosFijos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            dgvTotalActivosFijos.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(_tipoCon)
            dgvActivosFijos.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(_tipoCon)
            MenuStrip1.ForeColor = Color.White
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            'cbmTipoActivo.SelectedIndex = 0
            cbxActivo.SelectedIndex = 0
            dgvTotalActivosFijos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvActivosFijos.Font = New Font("Roboto", 8, FontStyle.Regular)



            txtBuscar.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            txtBuscar.Font = New Font("Roboto", 9, FontStyle.Regular)

            Dim validation As New ValidationForms()
            validation.SetPlaceholder(txtBuscar, "BUSCAR ACTIVO")




            Me.Controls.Add(txtBuscar)


        End Sub


        Private Sub btnReporteFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporteFondoRotativo.Click
            'ExportarDatosExcel(dgvActivosFijos, "REPORTE DE ACTIVOS" + cbmTipoActivo.Text)
            ExportarDatosExcel(dgvActivosFijos, "REPORTE DE ACTIVOS" + cbxActivo.Text)
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            dgvActivosFijos.DataSource = Nothing
            dgvTotalActivosFijos.DataSource = Nothing

            'If cbmTipoActivo.Text = "ARMAS" Then CargarArmas() '
            'If cbmTipoActivo.Text = "RADIOS" Then CargarRadios() '
            'If cbmTipoActivo.Text = "VEHICULOS" Then CargarVehiculos() '
            'If cbmTipoActivo.Text = "TERRENOS" Then CargarTerrenos() '
            'If cbmTipoActivo.Text = "EQUIPOS DE COMPUTO" Then CargarEquiposComputo() '
            'If cbmTipoActivo.Text = "LIBROS Y COLECCIONES" Then CargarLibrosColecciones() '
            'If cbmTipoActivo.Text = "EQUIPOS DE OFICINA" Then CargarEquiposOficina() '
            'If cbmTipoActivo.Text = "MUEBLES DE OFICINA" Then CargarMueblesOficina() '
            'If cbmTipoActivo.Text = "EQUIPOS DE COCINA" Then CargarEquiposCocina() '
            'If cbmTipoActivo.Text = "EQUIPOS DE AMBIENTACION" Then CargarEquiposAmbientacion() '
            'If cbmTipoActivo.Text = "EQUIPOS DE COMUNICACION Y TELEFONIA" Then CargarEquiposComunicacion() '
            'If cbmTipoActivo.Text = "EQUIPOS DE SEGURIDAD INDUSTRIAL" Then CargarEquiposSeguridad() '
            'If cbmTipoActivo.Text = "CAMARAS DE SEGURIDAD" Then CargarCamarasSeguridad() 
            'If cbmTipoActivo.Text = "GENERADORES" Then CargarGeneradores() 
            'If cbmTipoActivo.Text = "CHALECOS" Then CargarChalecos() '
            'If cbmTipoActivo.Text = "SOFTWARE" Then CargarSoftware()
            'txtActivo.Text = cbmTipoActivo.Text

            If cbxActivo.Text = "ARMAS" Then CargarArmas() '
            If cbxActivo.Text = "RADIOS" Then CargarRadios() '
            If cbxActivo.Text = "VEHICULOS" Then CargarVehiculos() '
            If cbxActivo.Text = "TERRENOS" Then CargarTerrenos() '
            If cbxActivo.Text = "EQUIPOS DE COMPUTO" Then CargarEquiposComputo() '
            If cbxActivo.Text = "LIBROS Y COLECCIONES" Then CargarLibrosColecciones() '
            If cbxActivo.Text = "EQUIPOS DE OFICINA" Then CargarEquiposOficina() '
            If cbxActivo.Text = "MUEBLES DE OFICINA" Then CargarMueblesOficina() '
            If cbxActivo.Text = "EQUIPOS DE COCINA" Then CargarEquiposCocina() '
            If cbxActivo.Text = "EQUIPOS DE AMBIENTACION" Then CargarEquiposAmbientacion() '
            If cbxActivo.Text = "EQUIPOS DE COMUNICACION Y TELEFONIA" Then CargarEquiposComunicacion() '
            If cbxActivo.Text = "EQUIPOS DE SEGURIDAD INDUSTRIAL" Then CargarEquiposSeguridad() '
            If cbxActivo.Text = "CAMARAS DE SEGURIDAD" Then CargarCamarasSeguridad()
            If cbxActivo.Text = "GENERADORES" Then CargarGeneradores()
            If cbxActivo.Text = "CHALECOS" Then CargarChalecos() '
            If cbxActivo.Text = "SOFTWARE" Then CargarSoftware()
            txtActivo.Text = cbxActivo.Text



            If dgvActivosFijos.ColumnCount > 0 Then
                dgvActivosFijos.Columns(0).Width = 50
                dgvActivosFijos.Columns(1).Width = 200
                dgvActivosFijos.Columns(2).Visible = False
                dgvActivosFijos.Columns(3).Width = 80
                dgvActivosFijos.Columns(4).Visible = False
                dgvActivosFijos.Columns(5).Width = 100
                dgvActivosFijos.Columns(6).Width = 100
                dgvActivosFijos.Columns(7).Width = 200
                dgvActivosFijos.Columns(8).Width = 60
                dgvActivosFijos.Columns(9).Width = 100
                dgvActivosFijos.Columns(10).Width = 200

                dgvActivosFijos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            End If

            Sumar()
            CargarValoresActivos()
        End Sub

        Private Sub dgvActivosFijos_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvActivosFijos.SelectionChanged
            If dgvActivosFijos.CurrentRow Is Nothing Then Return
            txtCustodio.Text = dgvActivosFijos.CurrentRow.Cells(1).Value.ToString()
        End Sub

        Private Sub cbmTipoActivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'ToolStripMenuItem1_Click(Nothing, Nothing)
        End Sub

        Private Sub cbxActivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxActivo.SelectedIndexChanged
            ToolStripMenuItem1_Click(Nothing, Nothing)
        End Sub

        Private Sub chbxCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles chbxCategoria.CheckedChanged
            If chbxCategoria.Checked Then
                cbxActivo.Enabled = True
            Else
                cbxActivo.Enabled = False
            End If
        End Sub
    End Class
End Namespace