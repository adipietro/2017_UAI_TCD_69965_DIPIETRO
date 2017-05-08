Imports System.Windows.Forms

Imports BE
Imports DAL

Public Class PatenteBLL
    Inherits PatenteAbstractaBLL

    Private _p1 As Integer

    Sub New()

    End Sub

    Dim MAP As New DAL.MapperPatente

    Sub New(p1 As Integer)
        _p1 = p1
    End Sub

    Private Sub cargar(ppatente As BE.PatenteAbstracta)
        ppatente.IdPatente = Me.id
        ppatente.Nombre = Me.nombrePatente
        ppatente.Formulario = Me.formulario
        ppatente.Padre = Me.padre
    End Sub


    Public Overrides Sub Alta()

        Dim mBE As New Patente
        If Me.id = 0 Then

            Me.id = MapperPatente.proximoID
            cargar(mBE)
            MapperPatente.InsertarPatente(mBE)
        Else
            cargar(mBE)
            MapperPatente.InsertarPatente(mBE)
        End If
    End Sub

    Public Overrides Sub baja()
        Dim mbe As New BE.GrupoPatente
        cargar(mbe)
        MapperPatente.ElimiarPatente(mbe)
    End Sub

    Public Function AltaPatente(unaPatente As BE.Patente)
        Return MapperPatente.InsertarPatente(unaPatente)

    End Function

    Public Function BuscarPatente() As DataTable
        Return MapperPatente.BuscarPatente

    End Function

    Public Function BajaPatenet(unaPatente As BE.Patente)
        Return MapperPatente.ElimiarPatente(unaPatente)
    End Function

    Public Function ModificarPatente(unaPatente As BE.Patente)

        Return MapperPatente.EditarPatente(unaPatente)

    End Function

    Public Function ListarPatentes() As List(Of BE.Patente)

        Return MapperPatente.Listar()

    End Function


    Public Overrides Function MostrarEnTreeView(pTreeView As Windows.Forms.TreeView) As Windows.Forms.TreeView
        Return Nothing
    End Function

    


End Class
