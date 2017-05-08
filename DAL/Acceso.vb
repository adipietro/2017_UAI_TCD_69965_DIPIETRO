Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data

Public Class Acceso


    Public Shared Function Abrir() As SqlConnection
        Dim cn As New SqlConnection
        cn.ConnectionString = "Integrated Security=SSPI;Initial Catalog=Productos y Proveedores;Data Source=.\SQL14_UAI"
        cn.Open()
        Return cn

    End Function



    Public Shared Function Cerrar() As SqlConnection
        Dim cn As New SqlConnection
        cn.Close()
        Return cn
    End Function

    Public Shared Function RetornarEscalar(nombre As String) As Integer
        Dim resultado As New Integer
        Dim cmd As New SqlCommand(nombre, Abrir())
        cmd.CommandType = CommandType.StoredProcedure
        Try
            resultado = cmd.ExecuteScalar
        Catch ex As Exception

        End Try

        Return resultado

    End Function

    Public Function Escribir(nombre As String, parametros() As SqlParameter)

        Dim resutlado As Integer

        Dim cmd As New SqlCommand(nombre, Abrir())
        cmd.Parameters.AddRange(parametros)
        cmd.CommandType = CommandType.StoredProcedure
        Try

            resutlado = cmd.ExecuteNonQuery

        Catch ex As Exception
            resutlado = -1

        End Try

        Cerrar()

        Return resutlado

    End Function

    Public Function Leer(nombre As String, Optional parametros() As SqlParameter = Nothing) As SqlDataReader
        Dim cmd As New SqlDataAdapter(nombre, Abrir())
        Dim tabla As New DataTable

        cmd.SelectCommand.CommandType = CommandType.StoredProcedure

        If parametros IsNot Nothing Then

            cmd.SelectCommand.Parameters.AddRange(parametros)
        End If

        cmd.Fill(tabla)

        
        Cerrar()


    End Function


    Public Function BuscarUsuarios() As DataTable

        Dim sql As New SqlDataAdapter("BuscarUsuario", Abrir())
        Dim tabla As New DataTable("Usuarios")

        sql.Fill(tabla)

        Cerrar()

        Return tabla

    End Function

    


End Class
