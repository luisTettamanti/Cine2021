Public Class principal

    Private Sub PelículasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelículasToolStripMenuItem.Click
        lstPeliculas.ShowDialog()
    End Sub

    Private Sub CategoríasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoríasToolStripMenuItem.Click
        lstCategorias.ShowDialog()
    End Sub

    Private Sub DirectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoresToolStripMenuItem.Click
        lstDirectores.ShowDialog()
    End Sub

    Private Sub ActoresActricesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActoresActricesToolStripMenuItem.Click
        Dim lsActores As New lstActores
        lstActores.esBusqueda = False
        lstActores.ShowDialog()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem.Click
        lstReservas.ShowDialog()
    End Sub
End Class
