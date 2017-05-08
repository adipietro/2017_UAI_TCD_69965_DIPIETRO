Public Class GrupoPatente
    Inherits PatenteAbstracta

    Private _lstPatentes As New List(Of PatenteAbstracta)

    Public Property lstPatentes() As List(Of PatenteAbstracta)
        Get
            Return _lstPatentes
        End Get
        Set(ByVal value As List(Of PatenteAbstracta))
            _lstPatentes = value
        End Set
    End Property

   

    Sub New(unId As Integer, unNombre As String, Optional unPadre As Integer = 1)
        IdPatente = unId
        Nombre = unNombre
        Padre = unPadre
    End Sub


    Sub New()

    End Sub



End Class
