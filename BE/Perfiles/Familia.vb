Public Class Familia
    Private _IdFamilia As String
    Public Property IdFamilia() As String
        Get
            Return _IdFamilia
        End Get
        Set(ByVal value As String)
            _IdFamilia = value
        End Set
    End Property


    Private _NombreFamilia As String
    Public Property NombreFamilia() As String
        Get
            Return _NombreFamilia
        End Get
        Set(ByVal value As String)
            _NombreFamilia = value
        End Set
    End Property


    Private _lstPatentes As New List(Of PatenteAbstracta)
    Public Property lstPatentes() As List(Of PatenteAbstracta)
        Get
            Return _lstPatentes
        End Get
        Set(ByVal value As List(Of PatenteAbstracta))
            _lstPatentes = value
        End Set
    End Property

    Sub New(unId As Integer, unNombre As String)
        IdFamilia = unId
        NombreFamilia = unNombre
    End Sub

    Public Function GetPatentes() As List(Of PatenteAbstracta)
        Return lstPatentes
    End Function

    Sub New()

    End Sub

End Class
