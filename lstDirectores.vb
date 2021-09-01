Public Class lstDirectores

    Dim dir As New Directores

    Private Sub lstCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dir.Mostrar(dgvDirectores)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmDirectores As New frmDirectores
        frmDirectores.modo = "Agregar"
        frmDirectores.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Modificar()
        dir.id = dgvDirectores.Item("id", dgvDirectores.CurrentRow.Index).Value
        dir.nombre = dgvDirectores.Item("nombre", dgvDirectores.CurrentRow.Index).Value

        Dim frmDirectores As New frmDirectores
        frmDirectores.modo = "Modificar"
        frmDirectores.selDirector = dir
        frmDirectores.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar...?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            dir.id = dgvDirectores.Item("id", dgvDirectores.CurrentRow.Index).Value
            dir.Borrar(dir.id)
            dir.Mostrar(dgvDirectores)
        End If
    End Sub

    Private Sub dgvCategorias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDirectores.CellDoubleClick
        Modificar()
    End Sub

End Class