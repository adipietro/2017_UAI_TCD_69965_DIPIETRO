Public Class Proveedor

    Private _IdProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _IdProveedor
        End Get
        Set(ByVal value As Integer)
            _IdProveedor = value
        End Set
    End Property

    Private _NombreProveedor As String
    Public Property NombreProveedor() As String
        Get
            Return _NombreProveedor
        End Get
        Set(ByVal value As String)
            _NombreProveedor = value
        End Set
    End Property

    Private _DirecciónProveedor As String
    Public Property DireccionProveedor() As String
        Get
            Return _DirecciónProveedor
        End Get
        Set(ByVal value As String)
            _DirecciónProveedor = value
        End Set
    End Property

    Private _TelefonoProveedor As String
    Public Property TelefonoProveedor() As String
        Get
            Return _TelefonoProveedor
        End Get
        Set(ByVal value As String)
            _TelefonoProveedor = value
        End Set
    End Property

    Private _ProductoProvee As Producto
    Public Property ProductoProvee() As Producto
        Get
            Return _ProductoProvee
        End Get
        Set(ByVal value As Producto)
            _ProductoProvee = value
        End Set
    End Property

    Public Function AltaProveedor(unNombre As String, unaDireccion As String, unTelefono As String, unProducto As Producto)
        NombreProveedor = unNombre
        DireccionProveedor = unaDireccion
        TelefonoProveedor = unTelefono
        ProductoProvee = unProducto
    End Function

    Sub New()

    End Sub

End Class
