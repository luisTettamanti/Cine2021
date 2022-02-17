Public Class ResEstados
    Private id_ As Integer
    Private nombre_ As String
    Private color_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property color() As String
        Get
            Return color_
        End Get
        Set(ByVal value As String)
            color_ = value
        End Set
    End Property

End Class
