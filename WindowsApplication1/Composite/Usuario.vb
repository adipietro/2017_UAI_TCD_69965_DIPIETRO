Imports BE
Imports BLL

Public Class frmUsuario

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFamiliaUss.DataSource = Modelo.GetInstance().Familias
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MessageBox.Show("Se ha cancelado la operación", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub
End Class