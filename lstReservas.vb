Public Class lstReservas
    Dim res As New Reservas

    Private Sub lstReservas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Actualizar()
    End Sub

    Private Sub lstReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub Actualizar()
        res.Mostrar(dgvReservas)
        res.Colorear(dgvReservas)
    End Sub

    Private Sub dgvReservas_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReservas.CellDoubleClick
        res.id = dgvReservas.Item("id", dgvReservas.CurrentRow.Index).Value
        res.idUsuario = dgvReservas.Item("idUsuario", dgvReservas.CurrentRow.Index).Value
        res.fecha = dgvReservas.Item("fecha", dgvReservas.CurrentRow.Index).Value
        res.idEstado = dgvReservas.Item("idEstado", dgvReservas.CurrentRow.Index).Value
        Dim frmResDetalle As New frmResDetalle
        frmResDetalle.modo = "Modificar"
        frmResDetalle.selReserva = res
        frmResDetalle.ShowDialog()
    End Sub

    Private Sub dgvReservas_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvReservas.RowPrePaint
        Try
            dgvReservas.DefaultCellStyle.SelectionForeColor = dgvReservas.CurrentRow.DefaultCellStyle.BackColor
        Catch ex As Exception
        End Try
    End Sub

End Class