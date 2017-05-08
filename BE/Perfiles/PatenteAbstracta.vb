Public MustInherit Class PatenteAbstracta

    Private _IdPatente As Integer
    Public Property IdPatente() As Integer
        Get
            Return _IdPatente
        End Get
        Set(ByVal value As Integer)
            _IdPatente = value
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

    Private _Padre As Integer
    Public Property Padre() As Integer
        Get
            Return _Padre
        End Get
        Set(ByVal value As Integer)
            _Padre = value
        End Set
    End Property

    Private _Formulario As String
    Public Property Formulario() As String
        Get
            Return _Formulario
        End Get
        Set(ByVal value As String)
            _Formulario = value
        End Set
    End Property


    

End Class
