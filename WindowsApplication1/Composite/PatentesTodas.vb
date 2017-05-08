Imports System.Reflection
Imports BLL


Public Class frmPatentesTodas

    Public Sub New()

        InitializeComponent()
        Dim Asm As Assembly = Reflection.Assembly.GetExecutingAssembly()

        For Each t As Type In Asm.GetTypes()
            If t.IsSubclassOf(GetType(Form)) Then
                Me.cmbFormularios.Items.Add(t.FullName)
            End If

        Next
    End Sub



    Public Function Nombre() As String
        Return Me.txtNombre.Text
    End Function

    Public Function Formulario() As String
        Return Me.cmbFormularios.Text
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub frmPatentesTodas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbFormularios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormularios.SelectedIndexChanged

    End Sub
End Class