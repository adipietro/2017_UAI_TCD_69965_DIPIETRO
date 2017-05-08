Imports BLL
Imports BE


Public Class frmFamilia
    Dim familia As New FamiliaBLL


    'Public Sub New()
    '
    '    InitializeComponent()
    '
    '    Me.familia.PatenteAbstracta.MostrarEnTreeView(Me.TreeView1)
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim lstFamilias As New List(Of PatenteAbstractaBLL)
        Dim gp = New GrupoPatenteBLL
        Dim unaFamilia As New Familia

        patentesSeleccionada(TreeView1.Nodes, gp.Patentes)

        familia.nombreFamilia = Me.txtNombre.Text
        Modelo.GetInstance.Familias.Add(familia)
        familia.AltaFamilia(unaFamilia)
    End Sub

    Public Sub PatentesSeleccionada(Node As TreeNodeCollection, ByRef list As IList(Of PatenteAbstractaBLL))

        For Each n As System.Windows.Forms.TreeNode In Node
            PatentesSeleccionada(n.Nodes, list)

            If n.Checked Then
                list.Add(CType(n.Tag, PatenteAbstractaBLL))
            End If
        Next
    End Sub


    Public Sub PatentesSeleccionas(Node As TreeNodeCollection, ByRef list As IList(Of PatenteAbstractaBLL))

        For Each n As System.Windows.Forms.TreeNode In Node
            PatentesSeleccionas(n.Nodes, list)

            If n.Checked Then
                list.Add(CType(n.Tag, PatenteAbstractaBLL))
            End If
        Next
    End Sub

    Private Sub treePatentes_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCheck
        e.Node.Tag.Seleccionada = e.Node.Checked
    End Sub

 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class