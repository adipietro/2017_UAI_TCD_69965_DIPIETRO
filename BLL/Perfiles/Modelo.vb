Public Class Modelo
    Private Shared _instance As Modelo
    Public Shared Function GetInstance() As Modelo

        If _instance Is Nothing Then
            _instance = New Modelo
        End If

        Return _instance
    End Function

    Private _familias As New List(Of FamiliaBLL)
    Public Property Familias() As List(Of FamiliaBLL)
        Get
            Return _familias
        End Get
        Set(ByVal value As List(Of FamiliaBLL))
            _familias = value
        End Set
    End Property

    Private _usuariobll As New List(Of UsuarioBLL)
    Public Property usuariobll() As List(Of UsuarioBLL)
        Get
            Return _usuariobll
        End Get
        Set(ByVal value As List(Of UsuarioBLL))
            _usuariobll = value
        End Set
    End Property


    Private _patenteRaiz As PatenteAbstractaBLL
    Public Property PatenteRaiz() As PatenteAbstractaBLL
        Get
            Return _patenteRaiz
        End Get
        Set(ByVal value As PatenteAbstractaBLL)
            _patenteRaiz = value
        End Set
    End Property

    Public Sub New()
        Dim raiz As New GrupoPatenteBLL()
        raiz.nombrePatente = "Patentes Sistema"
        Me._patenteRaiz = raiz
    End Sub

End Class
