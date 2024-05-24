Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS

    Public Class ClassDetalle
        Public Property CodigoPrincipal As String
        Public Property CodigoAuxiliar As String
        Public Property Cantidad As Decimal
        Public Property Descripcion As String
        Public Property DetalleAdicional As String
        Public Property PrecioUnitario As Decimal
        Public Property Subsidio As Decimal
        Public Property Descuento As Decimal
        Public Property PrecioTotalSinImpuesto As Decimal
        Public Property tarifa As Integer

    End Class

End Namespace