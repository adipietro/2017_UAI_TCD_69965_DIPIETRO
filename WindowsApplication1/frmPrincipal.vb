Imports BE
Imports BLL

Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim modelo As New Modelo

        Dim p1 As New Patente
        Dim p2 As New Patente
        Dim p3 As New Patente
        Dim p4 As New FamiliaBLL


        p1.Nombre = "p1"
        p2.Nombre = "p1"
        p3.Nombre = "p3"
        p4.nombreFamilia = "p1p2"

        Modelo.GetInstance.Familias.Add(p4)
    End Sub



    Private Sub AdministrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ABMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMToolStripMenuItem.Click
        frmABMUsuario.Show()
        frmABMUsuario.MdiParent = Me
    End Sub

    Private Sub IngresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarToolStripMenuItem.Click
        Login.Show()
        Login.MdiParent = Me
    End Sub

    Private Sub ABMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABMToolStripMenuItem1.Click
        frmFamilia.Show()
        frmFamilia.MdiParent = Me

    End Sub

    Private Sub ABMToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ABMToolStripMenuItem2.Click
        Dim form As New frmPatentesTodas
        form.Show()
        form.MdiParent = Me

    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        frmPatente.Show()
        frmPatente.MdiParent = Me
    End Sub

    Private Sub AdministraciònToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciònToolStripMenuItem.Click
        frmFormulario.Show()
        frmFormulario.MdiParent = Me
    End Sub
End Class