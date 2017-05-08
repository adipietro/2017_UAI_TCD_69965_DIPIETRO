

Public Class Usuario

    Private _Id_Uss As Integer
    Public Property Id_Uss() As Integer
        Get
            Return _Id_Uss
        End Get
        Set(ByVal value As Integer)
            _Id_Uss = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Apellido As String
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property

    Private _Usuario As String
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property



    Private _Contraseña As String
    Public Property Contraseña() As String
        Get
            Return _Contraseña
        End Get
        Set(ByVal value As String)
            _Contraseña = value
        End Set
    End Property

    Private _FamiliaUsuario As Integer = 0
    Public Property FamiliaUss() As Integer
        Get
            Return _FamiliaUsuario
        End Get
        Set(ByVal value As Integer)
            _FamiliaUsuario = value
        End Set
    End Property

    Private _Rol As Integer
    Public Property Rol() As Integer
        Get
            Return _Rol
        End Get
        Set(ByVal value As Integer)
            _Rol = value
        End Set
    End Property

    Private _lstUsuarios As New List(Of Usuario)
    Public Property LstUsuario() As List(Of Usuario)
        Get
            Return _lstUsuarios
        End Get
        Set(ByVal value As List(Of Usuario))
            _lstUsuarios = value
        End Set
    End Property



    Sub New()

    End Sub

    Public Function AltaUsuario(unNombre As String, unApellido As String, unUsuario As String, unaContraseña As String)
        Nombre = unNombre
        Apellido = unApellido
        Usuario = unUsuario
        Contraseña = unaContraseña
        'FamiliaUss = unaFamilia
        'Rol = unRol
    End Function

    Public Function LOGIN(Usuario As Usuario) As Boolean
        If Usuario Is Nothing Then
            Usuario = Usuario
            LstUsuario.Add(Usuario)
        End If
    End Function

    

End Class
