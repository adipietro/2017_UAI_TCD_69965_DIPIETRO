Imports BE
Imports BLL
Imports System.Reflection

Public Class frmPatente
   
    Private Sub frmPatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mPermisoRaiz As New GrupoPatenteBLL(0)
        mPermisoRaiz.MostrarEnTreeview(TreeView1)


        'Dim mSelectedNode As TreeNode = Me.TreeView1.SelectedNode
        '
        'If TypeOf mSelectedNode.Tag Is GrupoPatenteBLL Then
        '
        '    Dim mPadre As GrupoPatenteBLL = mSelectedNode.Tag
        '
        '    Dim mForm As New frmPatentesTodas
        '    mForm.ShowDialog()
        '
        '    Dim mNombrePermiso As String = mForm.Nombre
        '    Dim mNombreFormulario As String = mForm.Formulario
        '
        '    If (mNombrePermiso.Length > 0) And (mNombreFormulario.Length > 0) Then
        '
        '        Dim mPermiso As New PatenteBLL
        '        Dim mNodoNuevo As New TreeNode
        '
        '        mNodoNuevo.Text = mNombrePermiso
        '
        '        mPermiso.nombrePatente = mNombrePermiso
        '        mPermiso.formulario = mNombreFormulario
        '        mPermiso.padre = mPadre.id
        '
        '        mPermiso.Alta()
        '
        '        mNodoNuevo.Tag = mPermiso
        '
        '        mSelectedNode.Nodes.Add(mNodoNuevo)
        '        mPadre.Patentes.Add(mPermiso)
        '    End If
        'End If


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mSelectedNode As TreeNode = TreeView1.SelectedNode

        If TypeOf mSelectedNode.Tag Is GrupoPatenteBLL Then
            Dim mPadre As GrupoPatenteBLL = mSelectedNode.Tag
            Dim mNombrePermiso As String = InputBox("Ingrese el nombre del Permiso: ")

            If mNombrePermiso.Length > 0 Then
                Dim mPermisoCompuesto As New GrupoPatenteBLL
                mPermisoCompuesto.nombrePatente = mNombrePermiso
                mPermisoCompuesto.Padre = mPadre.ID

                Dim mNodoNuevo As New TreeNode
                mNodoNuevo.Text = mNombrePermiso
                mNodoNuevo.Tag = mPermisoCompuesto

                mSelectedNode.Nodes.Add(mNodoNuevo)
                mPadre.Patentes.Add(mPermisoCompuesto)

                mPermisoCompuesto.Alta()
                TreeView1.Nodes.Clear()

                frmPatente_Load(Nothing, Nothing)
                TreeView1.ExpandAll()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class