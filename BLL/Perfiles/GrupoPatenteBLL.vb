Imports System.Windows.Forms
Imports BE
Imports DAL

Public Class GrupoPatenteBLL
    Inherits PatenteAbstractaBLL
    Dim MAP As New DAL.MapperGrupoPatente
    Private _p1 As Integer

    Sub New()

    End Sub

    Sub New(p1 As Integer)

        _p1 = p1
    End Sub

    Private Sub cargar(ppatente As BE.PatenteAbstracta)
        ppatente.IdPatente = Me.id
        ppatente.Nombre = Me.nombrePatente
        ppatente.Formulario = Me.formulario
        ppatente.Padre = Me.padre
    End Sub


    Public Function BuscarGRPPatente() As DataTable
        Return MAP.BuscarGRPPatente

    End Function

    Public Function BajaGRPPatenet(unGRPpatente As BE.GrupoPatente)
        Return MAP.ElimiarGRPPatente(unGRPpatente)
    End Function

    Public Function ModificarGRPPatente(unGRPpatente As BE.GrupoPatente)
        Return MapperGrupoPatente.EditarGRPPatente(unGRPpatente)

    End Function

    Public Function ListarGRPpatentes() As List(Of BE.GrupoPatente)

        Return MapperGrupoPatente.ListarGRP()

    End Function

    Public Overrides Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
        Try
            Dim mListaPermisos As List(Of GrupoPatente) = ListarGRPpatentes()


            Dim mNode As TreeNode = pTreeView.Nodes.Add(mListaPermisos.Item(0).Nombre)
            mNode.Tag = mListaPermisos.Item(0)

            AgregarHijos(mNode.Tag, mNode)
        Catch ex As Exception

        End Try

        Return pTreeView
    End Function

    Private _patentes As New List(Of PatenteAbstractaBLL)
    Public Property Patentes() As List(Of PatenteAbstractaBLL)
        Get
            Return _patentes
        End Get
        Set(ByVal value As List(Of PatenteAbstractaBLL))
            _patentes = value
        End Set
    End Property

    Private Sub AgregarHijos(pPadre As GrupoPatenteBLL, pTreeNode As TreeNode)
        For Each mPermisoAbstracto As PatenteAbstractaBLL In pPadre.Patentes
            Dim mNode As New TreeNode
            mNode.Text = mPermisoAbstracto.nombrePatente
            mNode.Tag = mPermisoAbstracto
            pTreeNode.Nodes.Add(mNode)

            If TypeOf (mPermisoAbstracto) Is GrupoPatenteBLL Then

                Dim mPermisoCompuesto As GrupoPatenteBLL
                mPermisoCompuesto = DirectCast(mPermisoAbstracto, GrupoPatenteBLL)

                If mPermisoCompuesto.ListarGRPpatentes.Count > 0 Then
                    AgregarHijos(mPermisoCompuesto, pTreeNode.LastNode)
                End If
            End If
        Next

    End Sub

    Public Overrides Sub Alta()
        Dim mBE As New GrupoPatente
        If Me.id = 0 Then

            Me.id = MapperGrupoPatente.proximoID
            cargar(mBE)

            MapperGrupoPatente.InsertarGRPPatente(mBE)
        Else
            MapperGrupoPatente.InsertarGRPPatente(mBE)
        End If

    End Sub

    Public Overrides Sub baja()
        Dim mbe As New GrupoPatente
        cargar(mbe)
        MapperPatente.ElimiarPatente(mbe)

    End Sub

    Private Sub CargarHijos()
        Dim mListaCompuestos As List(Of GrupoPatente) = MapperGrupoPatente.ListarGRP(Me.id)
        Dim mListaSimples As List(Of BE.Patente) = MapperPatente.Listar(Me.id)

        If Not IsNothing(mListaCompuestos) Then
            For Each mPermisoAbs As BE.GrupoPatente In mListaCompuestos
                Dim mPermisoBLL As New GrupoPatenteBLL(mPermisoAbs.IdPatente)
                Me.Patentes.Add(mPermisoBLL)
            Next
        End If

        If Not IsNothing(mListaSimples) Then
            For Each mPermisoAbs As BE.patente In mListaSimples
                Dim mPermisoBLL As New PatenteBLL(mPermisoAbs.IdPatente)
                Me.Patentes.Add(mPermisoBLL)
            Next
        End If
    End Sub

End Class
