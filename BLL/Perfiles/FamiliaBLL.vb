Imports System.Windows.Forms

Public Class FamiliaBLL
    Public Property nombreFamilia As String

    Private _patenteRaiz As PatenteAbstractaBLL
    Public Property PatenteAbstracta() As PatenteAbstractaBLL
        Get
            Return _patenteRaiz
        End Get
        Set(ByVal value As PatenteAbstractaBLL)
            _patenteRaiz = value
        End Set
    End Property


    Dim MAP As New DAL.MapperFamilia
    Dim a As DAL.Acceso

    Public Function AltaFamilia(unNombre As BE.Familia)
        Return MAP.InsertarFamilia(unNombre)

    End Function

    Public Function BuscarFamilia() As DataTable
        Return MAP.BuscarFamilia

    End Function

    Public Function BajaFamilia(unaFamilia As BE.Familia)
        Return MAP.ElimiarFamilia(unaFamilia)
    End Function

    Public Function ModificarFamilia(unaFamilia As BE.Familia)
        Return MAP.EditarFamilia(unaFamilia)

    End Function

    Public Function ListarFamilia() As List(Of BE.Familia)
        Return MAP.Listar()
    End Function

    Public Sub MostrarEnTreeview(ByRef padres As TreeNodeCollection)

    End Sub

End Class
