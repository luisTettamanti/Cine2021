Public Class lstPeliculas

    Dim pelicula As New Peliculas

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmPeliculas As New frmPeliculas
        frmPeliculas.modo = "Agregar"
        frmPeliculas.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub lstPeliculas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pelicula.Mostrar(dgvPeliculas)
    End Sub

    Private Sub Modificar()
        pelicula.id = dgvPeliculas.Item("id", dgvPeliculas.CurrentRow.Index).Value
        pelicula.nombre = dgvPeliculas.Item("nombre", dgvPeliculas.CurrentRow.Index).Value
        pelicula.anio = dgvPeliculas.Item("anio", dgvPeliculas.CurrentRow.Index).Value
        pelicula.duracion = dgvPeliculas.Item("duracion", dgvPeliculas.CurrentRow.Index).Value
        pelicula.categoria = dgvPeliculas.Item("categoria", dgvPeliculas.CurrentRow.Index).Value
        pelicula.idDirector = dgvPeliculas.Item("idDirector", dgvPeliculas.CurrentRow.Index).Value
        pelicula.IMDB = dgvPeliculas.Item("IMDB", dgvPeliculas.CurrentRow.Index).Value
        pelicula.idCategoria = dgvPeliculas.Item("idCategoria", dgvPeliculas.CurrentRow.Index).Value

        Dim frmPeliculas As New frmPeliculas
        frmPeliculas.modo = "Modificar"
        frmPeliculas.selPelicula = pelicula
        frmPeliculas.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar...?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            pelicula.id = dgvPeliculas.Item("id", dgvPeliculas.CurrentRow.Index).Value
            pelicula.Borrar(pelicula.id)
            pelicula.Mostrar(dgvPeliculas)
        End If
    End Sub

    Private Sub dgvPeliculas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPeliculas.CellDoubleClick
        Modificar()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        pelicula.Mostrar(dgvPeliculas, txtBusqueda.Text)
    End Sub
End Class