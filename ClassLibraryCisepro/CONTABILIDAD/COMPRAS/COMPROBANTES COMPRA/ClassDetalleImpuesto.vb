Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA

    Public Class ClassDetalleImpuestos
        Public Property Codigo As String
        Public Property CodigoRetencion As String
        Public Property BaseImponible As Decimal
        Public Property PorcentajeRetener As Decimal
        Public Property ValorRetenido As Decimal
        Public Property CodDocSustento As String
        Public Property NumDocSustento As String
        Public Property FechaEmisionDocSustento As String
        Public Property PeriodoFiscal As String

    End Class

End Namespace