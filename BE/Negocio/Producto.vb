Public Class Producto

    Private _IdProducto As Integer
    Public Property idProd() As Integer
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As Integer)
            _IdProducto = value
        End Set
    End Property


    Private _NombreProducto As String
    Public Property NombreProducto() As String
        Get
            Return _NombreProducto
        End Get
        Set(ByVal value As String)
            _NombreProducto = value
        End Set
    End Property


    Private _Frecuencia As String
    Public Property Frecuencia() As String
        Get
            Return _Frecuencia
        End Get
        Set(ByVal value As String)
            _Frecuencia = value
        End Set
    End Property


    Private _lstProveedores As New List(Of Proveedor)
    Public Property lstProveedores() As List(Of Proveedor)
        Get
            Return _lstProveedores
        End Get
        Set(ByVal value As List(Of Proveedor))
            _lstProveedores = value
        End Set
    End Property

    Public Function AltaProducto(unId As Integer, unNombre As String, unaFrecuencia As String, Proveedores As IList(Of Proveedor))
        idProd = unId
        NombreProducto = unNombre
        lstProveedores = Proveedores
        Frecuencia = unaFrecuencia

    End Function

    Sub New()

    End Sub


End Class
