Public MustInherit Class PatenteAbstractaBLL

    Public Property id As Integer
    Public Property nombrePatente
    Public Property formulario As String
    Public Property padre As Integer



    Public Overridable Function MostrarEnTreeView(pTreeView As Windows.Forms.TreeView) As Windows.Forms.TreeView

    End Function
    Public MustOverride Sub Alta()
    Public MustOverride Sub baja()
End Class
