Public Class lstCategorias

    Dim cat As New Categorias

    Private Sub lstCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cat.Mostrar(dgvCategorias)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmCategorias As New frmCategorias
        frmCategorias.modo = "Agregar"
        frmCategorias.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Modificar()
        cat.id = dgvCategorias.Item("id", dgvCategorias.CurrentRow.Index).Value
        cat.nombre = dgvCategorias.Item("nombre", dgvCategorias.CurrentRow.Index).Value

        Dim frmCategorias As New frmCategorias
        frmCategorias.modo = "Modificar"
        frmCategorias.selCategoria = cat
        frmCategorias.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar...?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            cat.id = dgvCategorias.Item("id", dgvCategorias.CurrentRow.Index).Value
            cat.Borrar(cat.id)
            cat.Mostrar(dgvCategorias)
        End If
    End Sub

    Private Sub dgvCategorias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCategorias.CellDoubleClick
        Modificar()
    End Sub

End Class