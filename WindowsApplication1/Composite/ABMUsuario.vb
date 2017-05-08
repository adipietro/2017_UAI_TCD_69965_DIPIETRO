Public Class frmABMUsuario
    Dim map As New BLL.UsuarioBLL
    Dim tabla As New DataTable
    Dim gestorUsuario As New BLL.UsuarioBLL


    Sub enlazar()

        tabla = gestorUsuario.Buscarusuario()

        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = tabla



        cmbUsuarios.DataSource = tabla
        cmbUsuarios.DisplayMember = "Usuario"
        cmbUsuarios.ValueMember = "ID_Uss"

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuario As New BE.Usuario

        usuario.Nombre = txtNombre.Text
        usuario.Apellido = txtApellido.Text
        usuario.Usuario = txtUsuario.Text
        usuario.Contraseña = txtContraseña.Text

        If txtContraseña.Text = txtRepContraseña.Text Then


            gestorUsuario.AltaUsuario(usuario)

            MessageBox.Show("El usuario fue dado de alta con exito", "Alta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            txtApellido.Text = ""
            txtNombre.Text = ""
            txtUsuario.Text = ""
            txtContraseña.Text = ""
            txtRepContraseña.Text = ""

            enlazar()


        Else
            MessageBox.Show("Las contraseñas no Coinciden")
            txtContraseña.Text = ""
            txtRepContraseña.Text = ""
        End If

        

    End Sub

    Private Sub frmAltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlazar()

    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        Dim usuario As New BE.Usuario

        usuario.Nombre = txtNombreMod.Text
        usuario.Apellido = txtApellidoMod.Text
        usuario.Usuario = txtUsuario.Text
        usuario.Contraseña = txtContraseñaMod.Text
        usuario.Id_Uss = Integer.Parse(cmbUsuarios.SelectedValue)

        gestorUsuario.BajaUsuario(usuario)
        enlazar()

        MessageBox.Show("El usuario fue eliminado correctamente")

    End Sub

    Private Sub cmbUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuarios.SelectedIndexChanged

        For Each f As DataRow In tabla.Rows

            If f("Id_Uss").ToString = cmbUsuarios.SelectedValue.ToString Then

                txtApellidoMod.Text = f("Apellido").ToString
                txtNombreMod.Text = f("Nombre").ToString
                txtContraseñaMod.Text = f("Contraseña").ToString


            End If
        Next

        enlazar()

    End Sub

    Private Function p() As SqlClient.SqlParameter
        Throw New NotImplementedException
    End Function

End Class