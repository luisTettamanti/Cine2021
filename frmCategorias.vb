Public Class frmCategorias

    Private modo_ As String
    Private selCategoria_ As Categorias

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selCategoria() As Categorias
        Set(ByVal value As Categorias)
            selCategoria_ = value
        End Set
    End Property

    Dim cat As New Categorias

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        cat.nombre = txtNombre.Text
        If modo_ = "Agregar" Then
            cat.Agregar(cat)
        Else
            cat.id = txtId.Text
            cat.Modificar(cat)
        End If
        cat.Mostrar(lstCategorias.dgvCategorias)
        Close()
    End Sub

    Private Sub frmPeliculas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = modo_ + " Categoría"

        If modo_ = "Modificar" Then
            txtId.Text = selCategoria_.id
            txtNombre.Text = selCategoria_.nombre
        End If

    End Sub

End Class