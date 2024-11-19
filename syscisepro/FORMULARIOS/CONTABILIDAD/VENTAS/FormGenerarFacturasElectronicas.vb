Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports syscisepro.DATOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports System.Xml
Imports System.Text

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormGenerarFacturasElectronicas

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

        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoDetalleFacturaVenta As New ClassDetalleFacturaVenta
        ReadOnly _objetoSecuencialItem As New ClassSecuencialItem
        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos

        Dim _rucEmpresa As String = ""
        Dim _razonSocialEmpresa As String = ""
        Dim _nombreComercialEmpresa As String = ""
        Dim _direccionEmpresa As String = ""
        Dim _numAutoContEspecial As String = ""
        '=-=-=-=-=-=Datos Factura=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        Dim _idFacturaVenta As Integer = 0
        Dim _fechaEmisionFactura As DateTime = Nothing
        Dim _establecimientoFactura As String = ""
        Dim _ptoEmisionFactura As String = ""
        Dim _secuencialFactura As String = ""
        Dim _observacionesFactura As String = ""
        Dim _subTotal12Factura As Decimal = 0
        Dim _descuentoFactura As Decimal = 0
        Dim _ivaFactura As Decimal = 0
        Dim _totalFactura As Decimal = 0

        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""
        Dim _porcentajeIva As Integer = 0
        '=-=-=-=-=-=Datos Facturacion electronica=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        Dim _tipoAmbiente As Integer = 0 ' tipo de ambiente para facturación electrónica: 1 => PRUEBAS / 2 => PRODUCCIÓN
        Dim _tipoEmision As Integer = 0 ' tipo de emisión para facturación electrónica: 1 => NORMAL / 2 => INDISPONIBILIDAD DEL SISTEMA
        Dim _claveAcceso As String = "" ' clave de acceso para envio de la factura electrónica
        Dim _tipoIdentificacionCliente As String = "" ' tipo de identificacion del cliente RUC => 01 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07
        '==============Datos Cliente===================================
        ReadOnly _objetoInformacionTributaria As New ClassInformacionTributaria

        Dim _rucCliente As String = ""
        Dim _razonSocialCliente As String = ""
        Dim _direccionCliente As String = ""
        Dim _correoCliente As String = ""
        '==============Envio por correo===================================
        Private ReadOnly _correo As New MailMessage
        Private ReadOnly _envio As New SmtpClient
        Private _nombreArchivo As String = ""
        Private _archivoXml As String = ""
        Private _archivoPdf As String = ""
        Dim _emailEmpresa As String

        Public RutaDocsElec As String
        Public RutaFirmElec As String

        Private Sub enviar_correo_con_archivoCisepro()
            _correo.To.Clear()
            _correo.Body = ""
            _correo.Subject = ""

            _correo.Body = Me.txtMensaje.Text    'El contenido del mensaje
            _correo.Subject = Me.txtAsunto.Text   'El asunto
            _correo.IsBodyHtml = True             'Estructura html ? le ponemos si
            _correo.To.Add(Trim(_correoCliente))  'Agregamos la direccion para quien es el mensaje
            _correo.Attachments.Add(New Attachment(_archivoXml)) 'archivo adjuntado XML, le mandamos la ruta
            _correo.Attachments.Add(New Attachment(_archivoPdf)) 'archivo adjuntado PDF, le mandamos la ruta

            _correo.From = New MailAddress("cisepro@yahoo.es", "[CISEPRO CIA. LTDA.]")  'Datos quien envia

            _emailEmpresa = "cisepro@yahoo.es"

            'Datos importantes no modificables para tener acceso a las cuentas
            _envio.Host = "smtp.mail.yahoo.com"
            _envio.Port = 25
            _envio.DeliveryMethod = SmtpDeliveryMethod.Network
            _envio.UseDefaultCredentials = False
            _envio.Credentials = New Net.NetworkCredential(_emailEmpresa, "SEGU1234.")
            _envio.DeliveryMethod = SmtpDeliveryMethod.Network
            _envio.EnableSsl = True

            _envio.Send(_correo) 'enviamos em mensaje

            Me.Cursor = Cursors.Default
            Me.Text = "Enviar mensaje"
            MsgBox(" El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
            'limpiamos los campos
            txtAsunto.Text = String.Empty

            txtMensaje.Text = String.Empty
        End Sub

        Private Sub enviar_correo_con_archivoSeportpac()
            _correo.To.Clear()
            _correo.Body = ""
            _correo.Subject = ""

            _correo.Body = Me.txtMensaje.Text    'El contenido del mensaje
            _correo.Subject = Me.txtAsunto.Text   'El asunto
            _correo.IsBodyHtml = True             'Estructura html ? le ponemos si
            _correo.To.Add(Trim(_correoCliente))  'Agregamos la direccion para quien es el mensaje
            _correo.Attachments.Add(New Attachment(_archivoXml)) 'archivo adjuntado XML, le mandamos la ruta
            _correo.Attachments.Add(New Attachment(_archivoPdf)) 'archivo adjuntado PDF, le mandamos la ruta

            _correo.From = New MailAddress("seportpac@hotmail.com", "[SEPORTPAC CIA. LTDA.]")  'Datos quien envia

            _emailEmpresa = "seportpac@hotmail.com"

            'Datos importantes no modificables para tener acceso a las cuentas
            _envio.Host = "smtp.mail.hotmail.com"
            _envio.Port = 25
            _envio.DeliveryMethod = SmtpDeliveryMethod.Network
            _envio.UseDefaultCredentials = False
            _envio.Credentials = New System.Net.NetworkCredential(_emailEmpresa, "Seport13*.")
            _envio.DeliveryMethod = SmtpDeliveryMethod.Network
            _envio.EnableSsl = True

            _envio.Send(_correo) 'enviamos em mensaje

            Me.Cursor = Cursors.Default
            Me.Text = "Enviar mensaje"
            MsgBox(" El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
            'limpiamos los campos
            txtAsunto.Text = String.Empty

            txtMensaje.Text = String.Empty
        End Sub

        Private Sub enviar_correo_con_archivoAsenava()
            _correo.To.Clear()
            _correo.Body = ""
            _correo.Subject = ""

            _correo.Body = Me.txtMensaje.Text    'El contenido del mensaje
            _correo.Subject = Me.txtAsunto.Text   'El asunto
            _correo.IsBodyHtml = True             'Estructura html ? le ponemos si
            _correo.To.Add(Trim(_correoCliente))  'Agregamos la direccion para quien es el mensaje
            _correo.Attachments.Add(New Attachment(_archivoXml)) 'archivo adjuntado XML, le mandamos la ruta
            _correo.Attachments.Add(New Attachment(_archivoPdf)) 'archivo adjuntado PDF, le mandamos la ruta

            _correo.From = New MailAddress("asenava@hotmail.com", "[ASENAVA CIA. LTDA.]")  'Datos quien envia

            _emailEmpresa = "asenava@hotmail.com"

            'Datos importantes no modificables para tener acceso a las cuentas
            _envio.Host = "smtp.mail.hotmail.com"
            _envio.Port = 25
            _envio.DeliveryMethod = SmtpDeliveryMethod.Network
            _envio.UseDefaultCredentials = False
            _envio.Credentials = New System.Net.NetworkCredential(_emailEmpresa, "Asenava13*.")
            _envio.DeliveryMethod = SmtpDeliveryMethod.Network
            _envio.EnableSsl = True

            _envio.Send(_correo) 'enviamos em mensaje

            Me.Cursor = Cursors.Default
            Me.Text = "Enviar mensaje"
            MsgBox(" El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
            'limpiamos los campos
            txtAsunto.Text = String.Empty

            txtMensaje.Text = String.Empty
        End Sub

        Private Sub AutocompletarNombreCliente()
            'Try
            txtClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
            txtClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
            txtClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            'Catch ex As Exception
            'End Try
        End Sub

        Private Sub CargarDatosCliente()
            'Try
            dgvCliente.DataSource = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, _razonSocialCliente)

            If dgvCliente.RowCount > 0 Then
                'idCliente = dgvCliente.Rows(0).Cells(0).Value
                If dgvCliente.Rows(0).Cells(3).Value = "9999999999999" Then
                    _tipoIdentificacionCliente = "07"
                Else
                    Select Case dgvCliente.Rows(0).Cells(2).Value.ToString
                        Case "RUC"
                            _tipoIdentificacionCliente = "04"
                        Case "CEDULA"
                            _tipoIdentificacionCliente = "05"
                        Case "PASAPORTE"
                            _tipoIdentificacionCliente = "06"
                        Case "IDENTIFICACION DEL EXTERIOR"
                            _tipoIdentificacionCliente = "08"
                    End Select
                End If
                _rucCliente = dgvCliente.Rows(0).Cells(3).Value
                ' llevaContabilidad = dgvCliente.Rows(0).Cells(7).Value
                _direccionCliente = dgvCliente.Rows(0).Cells(8).Value
                'telefonoCliente = dgvCliente.Rows(0).Cells(11).Value
                _correoCliente = dgvCliente.Rows(0).Cells(13).Value '
            End If
            'Catch ex As Exception
            '    MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            'End Try
        End Sub

        Private Sub CargarDatosEmpresa()
            'Try
            dgvEmpresa.DataSource = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)

            If dgvEmpresa.RowCount > 0 Then
                'idEmpresa = dgvEmpresa.Rows(0).Cells(0).Value

                _rucEmpresa = dgvEmpresa.Rows(0).Cells(2).Value
                _razonSocialEmpresa = dgvEmpresa.Rows(0).Cells(3).Value
                _nombreComercialEmpresa = dgvEmpresa.Rows(0).Cells(4).Value
                _direccionEmpresa = dgvEmpresa.Rows(0).Cells(5).Value
                _numAutoContEspecial = dgvEmpresa.Rows(0).Cells(6).Value
                _establecimientoFactura = dgvEmpresa.Rows(0).Cells(9).Value
                _ptoEmisionFactura = dgvEmpresa.Rows(0).Cells(10).Value
                _porcentajeIva = dgvEmpresa.Rows(0).Cells(21).Value

            End If
            'Catch ex As Exception
            '    MsgBox("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            'End Try
        End Sub

        Private Sub CargarFacturasVenta()
            Try

                If chkNumeroFactura.CheckState = CheckState.Checked Then
                    dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtNumeroFacturaBuscar.Text)
                Else
                    dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturasVentaXParametros(_tipoCon, lblIdClienteGeneral.Text, _fechaDesde, _fechaHasta, 1)
                End If

                dgvFacturaVenta.Columns(0).HeaderText = "ID"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).HeaderText = "FACTURA"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).HeaderText = "FECHA"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                'dgvFacturaVenta.Columns(2).DefaultCellStyle.Format = "d"
                dgvFacturaVenta.Columns(3).HeaderText = "RUC"
                dgvFacturaVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).HeaderText = "CLIENTE"
                dgvFacturaVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(5).HeaderText = "SUBTOTAL 12%"
                dgvFacturaVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(6).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(7).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(8).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(9).HeaderText = "PORCENTAJE IVA"
                dgvFacturaVenta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(10).HeaderText = "IVA"
                dgvFacturaVenta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(11).HeaderText = "TOTAL      "
                dgvFacturaVenta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(12).HeaderText = "EST"
                dgvFacturaVenta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
                dgvFacturaVenta.Columns(2).Width = 120
                dgvFacturaVenta.Columns(4).Width = 325
                dgvFacturaVenta.Columns(20).Width = 325
                dgvFacturaVenta.ReadOnly = True
                dgvFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub

        Private Sub CargarDetalleFactura()
            dgvDetalleFacturaVenta.DataSource = _objetoDetalleFacturaVenta.SeleccionarDetalleFacturaVentaXIdFacturaVenta(_tipoCon, _idFacturaVenta)
            dgvDetalleFacturaVenta.AutoResizeColumns()
            dgvDetalleFacturaVenta.AutoResizeRows()
        End Sub

        Private Sub ExportarXml()

            Dim numeroFactura = _establecimientoFactura.ToString + "-" + _ptoEmisionFactura.ToString + "-" + _secuencialFactura
            Dim nres = _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon)
            '"\\Videomonitoreo\comprobantes electronicos cisepro cia ltda\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA 001-002-000017671.xml"
            Dim ruta As String
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml"
                Case TipoConexion.Seportpac
                    ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA " & numeroFactura & ".xml"
                Case Else
                    ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml"
            End Select
             
            Dim xml = String.Empty
            xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine
            xml += "<factura id='comprobante' version='1.0.0'>" & vbNewLine
            ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<infoTributaria>" & vbNewLine
            xml += "<ambiente>" & _tipoAmbiente & "</ambiente>" & vbNewLine
            xml += "<tipoEmision>" & _tipoEmision & "</tipoEmision>" & vbNewLine
            xml += "<razonSocial>" & _razonSocialEmpresa & "</razonSocial>" & vbNewLine
            xml += "<nombreComercial>" & _nombreComercialEmpresa & "</nombreComercial>" & vbNewLine
            xml += "<ruc>" & _rucEmpresa & "</ruc>" & vbNewLine
            xml += "<claveAcceso>" & _claveAcceso & "</claveAcceso>" & vbNewLine
            xml += "<codDoc>01</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 /  LIQUIDACION DE COMPRA =>  03  / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
            xml += "<estab>" & _establecimientoFactura & "</estab>" & vbNewLine
            xml += "<ptoEmi>" & _ptoEmisionFactura & "</ptoEmi>" & vbNewLine
            xml += "<secuencial>" & _secuencialFactura & "</secuencial>" & vbNewLine
            xml += "<dirMatriz>" & _direccionEmpresa & "</dirMatriz>" & vbNewLine
            xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
            xml += "</infoTributaria>" & vbNewLine
            ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<infoFactura>" & vbNewLine
            xml += "<fechaEmision>" & Format(_fechaEmisionFactura, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
            xml += "<dirEstablecimiento>" & _direccionEmpresa & "</dirEstablecimiento>" & vbNewLine
            'xml += "<contribuyenteEspecial>" & _numAutoContEspecial & "</contribuyenteEspecial>" & vbNewLine
            xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
            xml += "<tipoIdentificacionComprador>" & _tipoIdentificacionCliente & "</tipoIdentificacionComprador>" & vbNewLine
            xml += "<razonSocialComprador>" & _razonSocialCliente & "</razonSocialComprador>" & vbNewLine
            xml += "<identificacionComprador>" & _rucCliente & "</identificacionComprador>" & vbNewLine
            xml += "<direccionComprador>" & _direccionCliente & "</direccionComprador>" & vbNewLine ' ficha tecnica julio 2016; publicado 0/0/2016; implementado 08/09/2016
            xml += "<totalSinImpuestos>" & (Math.Round(CDec(_subTotal12Factura), 2, MidpointRounding.ToEven) - Math.Round(CDec(_descuentoFactura), 2, MidpointRounding.ToEven)) & "</totalSinImpuestos>" & vbNewLine
            xml += "<totalDescuento>" & _descuentoFactura & "</totalDescuento>" & vbNewLine
            xml += "<totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5
            ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
            If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
            If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
            If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine
            xml += "<descuentoAdicional>0.00</descuentoAdicional>" & vbNewLine '
            xml += "<baseImponible>" & (Math.Round(CDec(_subTotal12Factura), 2, MidpointRounding.ToEven) - Math.Round(CDec(_descuentoFactura), 2, MidpointRounding.ToEven)) & "</baseImponible>" & vbNewLine
            xml += "<valor>" & _ivaFactura & "</valor>" & vbNewLine
            xml += "</totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "</totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<propina>0.00</propina>" & vbNewLine
            xml += "<importeTotal>" & _totalFactura & "</importeTotal>" & vbNewLine
            xml += "<moneda>DOLAR</moneda>" & vbNewLine
            ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ficha tecnica julio 2016; publicado 0/0/2016; implementado 08/09/2016
            xml += "<pagos>" & vbNewLine
            xml += "<pago>" & vbNewLine
            xml += "<formaPago>01</formaPago>" & vbNewLine
            xml += "<total>" & _totalFactura & "</total>" & vbNewLine
            xml += "<plazo>30</plazo>" & vbNewLine
            xml += "<unidadTiempo>dias</unidadTiempo>" & vbNewLine
            xml += "</pago>" & vbNewLine
            xml += "</pagos>" & vbNewLine
            xml += "</infoFactura>" & vbNewLine
            ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS DETALLES DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<detalles>" & vbNewLine
            If dgvDetalleFacturaVenta.Rows.Count > 1 Then
                For indiceDetalle = 0 To dgvDetalleFacturaVenta.Rows.Count - 2
                    xml += "<detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA ITEM =-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "<codigoPrincipal>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(1).Value & "</codigoPrincipal>" & vbNewLine
                    xml += "<descripcion>" & _objetoSecuencialItem.BuscarNombreSecuencialItemXIdSecuencialItem(_tipoCon, CLng(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(1).Value)) & "</descripcion>" & vbNewLine
                    xml += "<cantidad>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(2).Value & "</cantidad>" & vbNewLine
                    xml += "<precioUnitario>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(3).Value), 2, MidpointRounding.ToEven) & "</precioUnitario>" & vbNewLine
                    xml += "<descuento>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(4).Value), 2, MidpointRounding.ToEven) & "</descuento>" & vbNewLine
                    xml += "<precioTotalSinImpuesto>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(5).Value), 2, MidpointRounding.ToEven) & "</precioTotalSinImpuesto>" & vbNewLine
                    xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5
                    If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine
                    xml += "<tarifa>" & _porcentajeIva & "</tarifa>" & vbNewLine
                    xml += "<baseImponible>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(5).Value), 2, MidpointRounding.ToEven) & "</baseImponible>" & vbNewLine
                    Dim valorIvaDetalle = (CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(5).Value) * _porcentajeIva) / 100
                    xml += "<valor>" & Math.Round(valorIvaDetalle, 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                    xml += "</impuesto>" & vbNewLine
                    xml += "</impuestos>" & vbNewLine
                    xml += "</detalle>" & vbNewLine
                Next
            End If
            xml += "</detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
            xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & nres & "</campoAdicional>" & vbNewLine
            If _tipoCon = TipoConexion.Seportpac Then
                xml += "<campoAdicional nombre='Retencion'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones: Avda. Alejandro Castro Benitez; correo:seportpac@hotmail.com; Telf: 072790424</campoAdicional>" & vbNewLine
            Else
                xml += "<campoAdicional nombre='Retencion'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones: Avda. Alejandro Castro Benitez; correo:cisepro@yahoo.es; Telf: 072790424</campoAdicional>" & vbNewLine
            End If
            xml += "<campoAdicional nombre='Observaciones'>" & _observacionesFactura.ToUpper.ToString & "</campoAdicional>" & vbNewLine
            xml += "</infoAdicional>" & vbNewLine
            xml += "</factura>" & vbNewLine


            ' guardar factura electronica
            _objetoComprobantesElectronicos.IdComprobante = _objetoComprobantesElectronicos.BuscarMayorIdComprobanteElectronico(_tipoCon) + 1
            _objetoComprobantesElectronicos.IdDocumento = _objetoFacturaVenta.IdFactura
            _objetoComprobantesElectronicos.Tipo = "FACTURA VENTA"
            _objetoComprobantesElectronicos.Documento = xml
            _objetoComprobantesElectronicos.FechaEmision = _objetoFacturaVenta.FechaEmisionFactura
            _objetoComprobantesElectronicos.NumDocumento = numeroFactura
            Dim res = _objetoComprobantesElectronicos.GuardarComprobanteElectronico(_tipoCon)

            Dim writer As XmlTextWriter
            writer = New XmlTextWriter(ruta, Encoding.UTF8)
            writer.Formatting = Formatting.Indented
            writer.WriteRaw(xml)
            writer.Flush()
            writer.Close()

            'MsgBox("XML GENERADO CORRECTAMENTE", MsgBoxStyle.Information, "Mensaje de información.")
            'Catch ex As Exception
            MsgBox(If(res, " - XML GUARDADO", " - XML NO GUARDADO!"), MsgBoxStyle.Exclamation, "Mensaje del sistema")
            'End Try
        End Sub
        Private Sub CargarControlListView(ByVal path As String)
            Dim d As New DirectoryInfo(path) ' directorio del que se va a cargar el listview
            Dim n As String = "" ' numero de factura a cargar
            ListView1.View = View.Details
            ListView1.FullRowSelect = True
            ListView1.BeginUpdate()
            ListView1.Items.Clear()
            'CheckedListBox1.Items.Clear()
            'For indiceFacturas = 0 To dgvFacturaVenta.Rows.Count - 1
            'n = dgvFacturaVenta.Rows(indiceFacturas).Cells(1).Value ' obtiene el numero de factura
            n = dgvFacturaVenta.CurrentRow.Cells(1).Value ' obtiene el numero de factura
            Select Case n.Length
                Case 1 : n = "FACTURA 001-002-" + "00000000" + n
                Case 2 : n = "FACTURA 001-002-" + "0000000" + n
                Case 3 : n = "FACTURA 001-002-" + "000000" + n
                Case 4 : n = "FACTURA 001-002-" + "00000" + n
                Case 5 : n = "FACTURA 001-002-" + "0000" + n
                Case 6 : n = "FACTURA 001-002-" + "000" + n
                Case 7 : n = "FACTURA 001-002-" + "00" + n
                Case 8 : n = "FACTURA 001-002-" + "0" + n
                Case 9 : n = "FACTURA 001-002-" + n
            End Select
            'OJO 2024 
            Dim FilePath As String = d.FullName & n & ".xml"
            Try

                If File.Exists(FilePath) Then
                    Dim file As New FileInfo(FilePath)
                    Dim item As New ListViewItem(file.Name)
                    item.SubItems.Add(file.Length.ToString()) ' Format file size if needed
                    item.SubItems.Add(file.CreationTime.ToString()) ' Format creation time if needed
                    ListView1.Items.Add(item)
                End If
            Catch ex As Exception
                MsgBox("EL ARCHIVO XML NO EXISTE" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try

            'For Each file As FileInfo In d.GetFiles(n & ".xml") ' recorre los archivos del directorio que coicidan con la busqueda
            '    Dim item As New ListViewItem(file.Name)
            '    'item.SubItems.Add(file.Length)
            '    item.SubItems.Add(file.Length.ToString())
            '    item.SubItems.Add(file.CreationTime.ToString())
            '    ListView1.Items.Add(item)
            '    'CheckedListBox1.Items.Add(n + ".xml")
            'Next
            'Next

            ListView1.EndUpdate()
        End Sub
        Private Sub CargarListView(ByVal path As String, ByVal n As String)
            Dim d As New DirectoryInfo(path) ' directorio del que se va a cargar el listview
            'Dim n As String = "" ' numero de factura a cargar
            ListView1.View = View.Details
            ListView1.FullRowSelect = True
            ListView1.BeginUpdate()
            ListView1.Items.Clear()
            'CheckedListBox1.Items.Clear()
            'For indiceFacturas = 0 To dgvFacturaVenta.Rows.Count - 1
            'n = dgvFacturaVenta.Rows(indiceFacturas).Cells(1).Value ' obtiene el numero de factura
            'n = dgvFacturaVenta.CurrentRow.Cells(1).Value ' obtiene el numero de factura
            Select Case n.Length
                Case 1 : n = "FACTURA 001-002-" + "00000000" + n
                Case 2 : n = "FACTURA 001-002-" + "0000000" + n
                Case 3 : n = "FACTURA 001-002-" + "000000" + n
                Case 4 : n = "FACTURA 001-002-" + "00000" + n
                Case 5 : n = "FACTURA 001-002-" + "0000" + n
                Case 6 : n = "FACTURA 001-002-" + "000" + n
                Case 7 : n = "FACTURA 001-002-" + "00" + n
                Case 8 : n = "FACTURA 001-002-" + "0" + n
                Case 9 : n = "FACTURA 001-002-" + n
            End Select
            'OJO 2024 
            Dim FilePath As String = d.FullName & n & ".xml"
            Try


                Dim file As New FileInfo(FilePath)
                Dim item As New ListViewItem(file.Name)
                item.SubItems.Add(file.Length.ToString()) ' Format file size if needed
                item.SubItems.Add(file.CreationTime.ToString()) ' Format creation time if needed
                ListView1.Items.Add(item)

            Catch ex As Exception
                MsgBox("EL ARCHIVO XML NO EXISTE" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try

            'For Each file As FileInfo In d.GetFiles(n & ".xml") ' recorre los archivos del directorio que coicidan con la busqueda
            '    Dim item As New ListViewItem(file.Name)
            '    'item.SubItems.Add(file.Length)
            '    item.SubItems.Add(file.Length.ToString())
            '    item.SubItems.Add(file.CreationTime.ToString())
            '    ListView1.Items.Add(item)
            '    'CheckedListBox1.Items.Add(n + ".xml")
            'Next
            'Next

            ListView1.EndUpdate()
        End Sub

        Private Sub FormGenerarFacturasElectronicas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCliente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEmpresa.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCliente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvEmpresa.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCliente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvEmpresa.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            AutocompletarNombreCliente()
            CargarDatosEmpresa()
            rbProduccion.Checked = True
            rbTipoEmisionNormal.Checked = True
            'btnCargarXML.Enabled = False
            btnGuardarFirmado.Enabled = False
        End Sub
        Private Sub btnCargarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarXML.Click

            'CargarFacturasVenta()
            If dgvFacturaVenta.CurrentRow IsNot Nothing Then
                Dim n As String = dgvFacturaVenta.CurrentRow.Cells(1).Value
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        CargarListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS\", n)
                    Case TipoConexion.Seportpac
                        CargarListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS\", n)
                    Case Else
                        'CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
                        CargarListView(RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\", n)
                End Select
            End If
            
        End Sub
        Private Sub btnGuardarSinFirmar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSinFirmar.Click
            If dgvFacturaVenta.Rows.Count > 0 Then

                For indice = 0 To dgvFacturaVenta.Rows.Count - 1
                    If dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString <> "0" Then
                        _fechaEmisionFactura = Nothing

                        _fechaEmisionFactura = dgvFacturaVenta.Rows(indice).Cells(2).Value '"15/12/2014 23:59:59"
                        _secuencialFactura = dgvFacturaVenta.Rows(indice).Cells(1).Value
                        Select Case dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString.Length
                            Case 1 : _secuencialFactura = "00000000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 2 : _secuencialFactura = "0000000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 3 : _secuencialFactura = "000000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 4 : _secuencialFactura = "00000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 5 : _secuencialFactura = "0000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 6 : _secuencialFactura = "000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 7 : _secuencialFactura = "00" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 8 : _secuencialFactura = "0" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            Case 9 : _secuencialFactura = dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                        End Select
                        _razonSocialCliente = dgvFacturaVenta.Rows(indice).Cells(4).Value

                        CargarDatosCliente()

                        _idFacturaVenta = dgvFacturaVenta.Rows(indice).Cells(0).Value
                        _subTotal12Factura = dgvFacturaVenta.Rows(indice).Cells(5).Value
                        _descuentoFactura = dgvFacturaVenta.Rows(indice).Cells(7).Value
                        _porcentajeIva = dgvFacturaVenta.Rows(indice).Cells(9).Value
                        _ivaFactura = dgvFacturaVenta.Rows(indice).Cells(10).Value
                        _totalFactura = dgvFacturaVenta.Rows(indice).Cells(11).Value
                        _observacionesFactura = dgvFacturaVenta.Rows(indice).Cells("OBSERVACIONES").Value.ToString.TrimEnd
                        CargarDetalleFactura()


                        _claveAcceso = ValidationForms.GenerarClaveAccesoFacturacionElectronica("01", _fechaEmisionFactura, _rucEmpresa, _tipoAmbiente, _establecimientoFactura, _ptoEmisionFactura, _secuencialFactura, _tipoEmision)
                        If _claveAcceso.ToString.Length = 49 Then
                            ExportarXml()
                        Else
                            MsgBox("CLAVE DE ACCESO INVALIDA")
                            Exit For
                        End If
                    End If
                Next
                lblEstadoXML.Text = "GENERADOS"

                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
                    Case TipoConexion.Seportpac
                        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS\")
                    Case Else
                        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
                End Select

                CargarFacturasVenta()
            End If

        End Sub

        Private Sub btnGuardarFirmado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarFirmado.Click
            For indiceListView = 0 To ListView1.Items.Count - 1 
                Dim numeroFactura = ListView1.Items(indiceListView).Text.ToString
                Dim firma As New Signatures
                firma.RutaDocsElec = RutaDocsElec

                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        firma.Xml(RutaDocsElec & "\COMPROBANTES GENERADOS\" & ListView1.Items(indiceListView).Text.ToString & "", RutaFirmElec & "\jose_ignacio_navarrete_landazuri.p12", "Segu1234", numeroFactura, _tipoCon)
                    Case TipoConexion.Seportpac
                        firma.Xml(RutaDocsElec & "\COMPROBANTES GENERADOS\" & ListView1.Items(indiceListView).Text.ToString & "", RutaFirmElec & "\jose_ignacio_navarrete_landazuri.p12", "Segu1234", numeroFactura, _tipoCon)
                    Case Else
                        firma.Xml(RutaDocsElec & "\COMPROBANTES GENERADOS\" & ListView1.Items(indiceListView).Text.ToString & "", RutaFirmElec & "\jose_ignacio_navarrete_landazuri.p12", "Segu1234", numeroFactura, _tipoCon)
                End Select

            Next
            lblEstadoXML.Text = "FIRMADOS"

            Select Case _tipoCon
                Case TipoConexion.Asenava
                    CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
                Case TipoConexion.Seportpac
                    CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS\")
                Case Else
                    CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
            End Select
        End Sub

        Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEnviar.Click
            If dgvFacturaVenta.Rows.Count > 0 Then
                If txtAsunto.Text = "" Or txtMensaje.Text = "" Then
                    MsgBox("INGRESE UN ASUNTO / MENSAJE ANTES DE ENVIAR", MsgBoxStyle.Exclamation, "Mensaje de validación")
                Else
                    For indice = 0 To dgvFacturaVenta.Rows.Count - 1
                        If dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString <> "0" Then
                            _secuencialFactura = dgvFacturaVenta.Rows(indice).Cells(1).Value
                            Select Case dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString.Length
                                Case 1 : _secuencialFactura = "00000000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 2 : _secuencialFactura = "0000000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 3 : _secuencialFactura = "000000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 4 : _secuencialFactura = "00000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 5 : _secuencialFactura = "0000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 6 : _secuencialFactura = "000" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 7 : _secuencialFactura = "00" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 8 : _secuencialFactura = "0" + dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                                Case 9 : _secuencialFactura = dgvFacturaVenta.Rows(indice).Cells(1).Value.ToString
                            End Select
                            'numeroFactura = ""
                            _nombreArchivo = ""
                            _archivoXml = ""
                            _archivoPdf = ""
                            _nombreArchivo = "FACTURA 001-002-" + _secuencialFactura

                            Select Case _tipoCon
                                Case TipoConexion.Asenava
                                    _archivoXml = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\" + _nombreArchivo + ".xml"
                                    _archivoPdf = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\" + _nombreArchivo + ".pdf"
                                Case TipoConexion.Seportpac
                                    _archivoXml = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS\" + _nombreArchivo + ".xml"
                                    _archivoPdf = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS" + _nombreArchivo + ".pdf"
                                Case Else
                                    _archivoXml = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\" + _nombreArchivo + ".xml"
                                    _archivoPdf = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\" + _nombreArchivo + ".pdf"
                            End Select

                            For indiceListView = 0 To ListView1.Items.Count - 1
                                _razonSocialCliente = dgvFacturaVenta.Rows(indice).Cells(4).Value.ToString
                                CargarDatosCliente()
                                If _nombreArchivo + ".xml" = ListView1.Items(indiceListView).Text.ToString Then

                                    Select Case _tipoCon
                                        Case TipoConexion.Asenava
                                            enviar_correo_con_archivoAsenava()
                                        Case TipoConexion.Seportpac
                                            enviar_correo_con_archivoSeportpac()
                                        Case Else
                                            enviar_correo_con_archivoCisepro()
                                    End Select

                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
            End If
            ListView1.Items.Clear()
            dgvFacturaVenta.DataSource = Nothing
            txtAsunto.Text = ""
            txtMensaje.Text = ""
        End Sub

        Private Sub rbPruebas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPruebas.CheckedChanged
            If rbPruebas.Checked = True Then
                _tipoAmbiente = 1
            Else
                _tipoAmbiente = 2
            End If
        End Sub
        Private Sub rbProduccion_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbProduccion.CheckedChanged
            If rbProduccion.Checked = True Then
                _tipoAmbiente = 2
            Else
                _tipoAmbiente = 1
            End If
        End Sub
        Private Sub rbTipoEmisionNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTipoEmisionNormal.CheckedChanged
            If rbTipoEmisionNormal.Checked = True Then
                _tipoEmision = 1
            Else
                _tipoEmision = 2
            End If
        End Sub
        Private Sub rbTipoEmisionIndisponibilidadSistema_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTipoEmisionIndisponibilidadSistema.CheckedChanged
            If rbTipoEmisionIndisponibilidadSistema.Checked = True Then
                _tipoEmision = 2
            Else
                _tipoEmision = 1
            End If
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

            CargarFacturasVenta()

            'Select Case _tipoCon
            '    Case TipoConexion.Asenava
            '        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
            '    Case TipoConexion.Seportpac
            '        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS\")
            '    Case Else
            '        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
            'End Select

        End Sub

        Private Sub txtNumeroFacturaBuscar_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroFacturaBuscar.KeyDown
            If e.KeyCode = Keys.Enter Then

                _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
                _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

                CargarFacturasVenta()

                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
                    Case TipoConexion.Seportpac
                        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\VENTAS\")
                    Case Else
                        CargarControlListView(RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO\")
                End Select

            End If
        End Sub
        Private Sub txtClienteGeneral_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtClienteGeneral.KeyDown
            If e.KeyCode = Keys.Enter Then
                lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtClienteGeneral.Text)
            End If
        End Sub

        Private Sub chkClienteGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkClienteGeneral.CheckedChanged
            If chkClienteGeneral.CheckState = CheckState.Checked Then
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Enabled = False
                txtClienteGeneral.Text = ""
            Else
                txtClienteGeneral.Enabled = True
            End If
        End Sub

        Private Sub chkNumeroFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkNumeroFactura.CheckedChanged
            If chkNumeroFactura.CheckState = CheckState.Checked Then
                gbClienteGeneral.Enabled = False
                gbRangoFechas.Enabled = False
                txtNumeroFacturaBuscar.Enabled = True
            Else
                gbClienteGeneral.Enabled = True
                gbRangoFechas.Enabled = True
                txtNumeroFacturaBuscar.Enabled = False
            End If
        End Sub

    End Class

    Public Class Signatures
        Public RutaDocsElec As String

        Private ReadOnly _rnd As New Random(DateTime.Now.Millisecond)
        Private Const XmlDsigRsasha1Url As String = "http://www.w3.org/2000/09/xmldsig#rsa-sha1"

        Public Sub Xml(ByVal pathXml As String, ByVal pathSignature As String, ByVal passFirma As String, ByVal numeroFactura As String, ByVal tipoCon As TipoConexion)
            Dim xmlDoc As New XmlDocument()
            xmlDoc.PreserveWhitespace = True
            xmlDoc.Load(pathXml.ToString.Trim)

            Dim uidCert As New X509Certificate2(pathSignature.ToString.Trim, passFirma, X509KeyStorageFlags.DefaultKeySet)
            Dim rsaKey As RSACryptoServiceProvider = DirectCast(uidCert.PrivateKey, RSACryptoServiceProvider)
            Dim signedXml As New SignedXml(xmlDoc)
            signedXml.SigningKey = rsaKey
            signedXml.Signature.Id = NewId("Signature") ';
            signedXml.SignedInfo.SignatureMethod = XmlDsigRsasha1Url
            signedXml.SignedInfo.Id = NewId("Signature-SignedInfo") ';

            Dim reference As New Reference()
            reference.Id = NewId("SignedPropertiesID") ';
            reference.Uri = ""

            ' Add an enveloped transformation to the reference.
            Dim env As New XmlDsigEnvelopedSignatureTransform()
            reference.AddTransform(env)
            signedXml.AddReference(reference)

            ' Add an RSAKeyValue KeyInfo (optional; helps recipient find key to validate).
            Dim keyInfo As New KeyInfo()

            Dim clause As New KeyInfoX509Data()
            clause.AddSubjectName(uidCert.Subject)
            clause.AddCertificate(uidCert)
            keyInfo.AddClause(clause)
            signedXml.KeyInfo = keyInfo

            ' Compute the signature.
            signedXml.ComputeSignature()

            ' Get the XML representation of the signature and save it to an XmlElement object.
            Dim xmlDigitalSignature As XmlElement = signedXml.GetXml()
            For Each node As XmlNode In xmlDigitalSignature.SelectNodes("descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']")
                node.Prefix = "ds"
            Next

            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, True))

            Select Case tipoCon
                Case TipoConexion.Asenava
                    xmlDoc.Save(RutaDocsElec & "\COMPROBANTES FIRMADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml")
                Case TipoConexion.Seportpac
                    xmlDoc.Save(RutaDocsElec & "\COMPROBANTES FIRMADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml")
                Case Else
                    xmlDoc.Save(RutaDocsElec & "\COMPROBANTES FIRMADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml")
            End Select

            MsgBox("FIRMA GENERADA CORRECTAMENTE", MsgBoxStyle.Information, "Mensaje de información.")
        End Sub

        Private Function NewId(ByVal prefix As String) As String
            Return prefix & _rnd.Next(1048576)
        End Function
    End Class
End Namespace