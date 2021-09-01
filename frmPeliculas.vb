Public Class frmPeliculas

    Private modo_ As String
    Private selPelicula_ As Peliculas

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selPelicula() As Peliculas
        Set(ByVal value As Peliculas)
            selPelicula_ = value
        End Set
    End Property

    Dim pelicula As New Peliculas
    Dim ap As New ActoresPelicula

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        pelicula.anio = txtAnio.Text
        pelicula.duracion = txtDuracion.Text
        pelicula.idCategoria = cmbCategoria.SelectedValue
        'pelicula.idDirector = txtIddirector.Text
        pelicula.idDirector = cmbDirector.SelectedValue
        pelicula.IMDB = txtIMDB.Text
        pelicula.nombre = txtNombre.Text
        If modo_ = "Agregar" Then
            pelicula.Agregar(pelicula)
        Else
            pelicula.id = txtId.Text
            pelicula.Modificar(pelicula)
        End If
        pelicula.Mostrar(lstPeliculas.dgvPeliculas)
        Close()
    End Sub

    Private Sub frmPeliculas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ap.Mostrar(dgvActores, selPelicula_.id)
        Text = modo_ + " Película"
        pelicula.CargarComboCategoriasReader(cmbCategoria, selPelicula_.idCategoria)
        pelicula.CargarComboDirectores(cmbDirector, selPelicula_.idDirector)

        If modo_ = "Modificar" Then
            txtId.Text = selPelicula_.id
            txtNombre.Text = selPelicula_.nombre
            txtAnio.Text = selPelicula_.anio
            txtDuracion.Text = selPelicula_.duracion
            'txtIddirector.Text = selPelicula_.idDirector
            cmbDirector.SelectedValue = selPelicula_.idDirector
            txtIMDB.Text = selPelicula_.IMDB
            cmbCategoria.SelectedValue = selPelicula_.idCategoria
        End If

    End Sub

    Private Sub btnAgregarActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarActor.Click
        Dim lstActores As New lstActores
        lstActores.esBusqueda = True
        lstActores.ShowDialog()
        If lstActores.actorSel > 0 Then
            ap.Agregar(lstActores.actorSel, txtId.Text)
            ap.Mostrar(dgvActores, selPelicula_.id)
        End If
    End Sub

    Private Sub btnBorrarActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarActor.Click
        Dim idActorPelicula As Integer
        idActorPelicula = dgvActores.Item("id", dgvActores.CurrentRow.Index).Value
        ap.Borrar(idActorPelicula)
        ap.Mostrar(dgvActores, selPelicula_.id)
    End Sub
End Class