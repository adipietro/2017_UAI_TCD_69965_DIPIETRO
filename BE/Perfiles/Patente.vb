Public Class Patente
    Inherits PatenteAbstracta

  


    Sub New(unId As Integer, unNombre As String, unFormulario As String, Optional unPadre As Integer = 1)
        IdPatente = unId
        Nombre = unNombre
        Formulario = unFormulario
        Padre = unPadre

    End Sub


    Sub New()

    End Sub

End Class
