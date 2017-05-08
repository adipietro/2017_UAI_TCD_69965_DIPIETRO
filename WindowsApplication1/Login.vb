Imports BE
Imports BLL

Public Class Login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        Dim unUsuario As Usuario
        Dim unUsuarioBLL As New UsuarioBLL
        Dim buscarUsuario As New UsuarioBLL

        Dim p As New SqlClient.SqlParameter
        p.ParameterName = "@uss"
        p.Value = txtUsuario.Text
        p.DbType = DbType.String

        unUsuario = buscarUsuario.Buscarusuario("ValidarUsuario", p, txtUsuario.Text)

        If unUsuario Is Nothing Then
            MessageBox.Show("El usuario ingresado no existe en la base de datos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Text = ""
            txtContraseña.Text = ""
        Else
            If unUsuario.Contraseña = txtContraseña.Text Then
                unUsuario.LOGIN(unUsuario)
                MessageBox.Show("Bienvenido al Sistema de Compras y Proveedores", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Contraseña incorrecta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtContraseña.Text = ""

            End If

        End If

        ' Catch ex As Exception

        ' MessageBox.Show(ex.Message)

        ' End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmABMUsuario.Show()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class