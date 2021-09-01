Public Class lstActores

    Private esBusqueda_ As Boolean
    Private actorSel_ As Integer

    Public Property esBusqueda() As Boolean
        Get
            Return esBusqueda_
        End Get
        Set(ByVal value As Boolean)
            esBusqueda_ = value
        End Set
    End Property

    Public Property actorSel() As Integer
        Get
            Return actorSel_
        End Get
        Set(ByVal value As Integer)
            actorSel_ = value
        End Set
    End Property

    Dim actor As New Actores

    Private Sub lstCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actor.Mostrar(dgvActores)
        If esBusqueda_ = True Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False

        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmActores As New frmActores
        frmActores.modo = "Agregar"
        frmActores.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub Modificar()
        actor.id = dgvActores.Item("id", dgvActores.CurrentRow.Index).Value
        actor.nombre = dgvActores.Item("nombre", dgvActores.CurrentRow.Index).Value

        Dim frmActores As New frmActores
        frmActores.modo = "Modificar"
        frmActores.selActor = actor
        frmActores.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim respuesta As MessageBoxOptions = MessageBox.Show("¿Está seguro que quiere borrar...?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If respuesta = 1 Then
            actor.id = dgvActores.Item("id", dgvActores.CurrentRow.Index).Value
            actor.Borrar(actor.id)
            actor.Mostrar(dgvActores)
        End If
    End Sub

    Private Sub dgvCategorias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvActores.CellDoubleClick
        Modificar()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        actorSel_ = dgvActores.Item("id", dgvActores.CurrentRow.Index).Value
        Close()
    End Sub
End Class