Imports BE
Imports System.Data
Imports System.Data.SqlClient

Public Class UsuarioBLL


    Dim MAP As New DAL.MapperUsuario

    'Public Property ID As Integer = 0
    'Public Property Nombre As String
    'Public Property Apellido As String
    'Public Property Usuario As String
    'Public Property Contraseña As String
    'Public Property rol As Integer
    'Public Property lstUsuario As List(Of UsuarioBLL)





    Public Function AltaUsuario(unUsuario As BE.Usuario)
        Return MAP.InsertarUsuario(unUsuario)

    End Function

    Public Function Buscarusuario() As DataTable


        Return MAP.BuscarUsuario()

    End Function


    Public Function BajaUsuario(unUsuario As BE.Usuario)
        Return MAP.ElimiarUsuario(unUsuario)
    End Function

    Public Function ModificarUsuario(unUsuario As BE.Usuario)

        Return MAP.EditarUsuario(unUsuario)

    End Function

    Public Function ListarUsuarios() As List(Of BE.Usuario)

        Return MAP.Listar()

    End Function

    Function Buscarusuario(procedimiento As String, p As SqlParameter, nombreUsuario As String) As BE.Usuario
        Dim unUsuario As New BE.Usuario
        MAP.BuscarUsuario()
        For Each unRow As DataRow In MAP.BuscarUsuario.Rows
            If unRow("Usuario") = nombreUsuario Then
                unUsuario.Nombre = unRow("Nombre")
                unUsuario.Apellido = unRow("Apellido")
                unUsuario.Usuario = unRow("Usuario")
                unUsuario.Contraseña = unRow("Contraseña")
                unUsuario.Id_Uss = unRow("Id_Uss")



            End If
        Next
        Return unUsuario
    End Function







End Class
