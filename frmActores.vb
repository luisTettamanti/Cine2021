Public Class frmActores

    Private modo_ As String
    Private selActor_ As New Actores

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selActor() As Actores
        Set(ByVal value As Actores)
            selActor_ = value
        End Set
    End Property

    Dim actor As New Actores
    Dim ap As New ActoresPelicula

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        actor.nombre = txtNombre.Text
        If modo_ = "Agregar" Then
            actor.Agregar(actor)
        Else
            actor.id = txtId.Text
            actor.Modificar(actor)
        End If
        actor.Mostrar(lstActores.dgvActores)
        Close()
    End Sub

    Private Sub frmActores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = modo_ + " Actor"
        ap.MostrarPeliculas(dgvPeliculas, selActor_.id)

        If modo_ = "Modificar" Then
            txtId.Text = selActor_.id
            txtNombre.Text = selActor_.nombre
        End If

    End Sub

End Class