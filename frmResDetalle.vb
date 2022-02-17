Public Class frmResDetalle

    Private modo_ As String
    Private selReserva_ As New Reservas

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selReserva() As Reservas
        Set(ByVal value As Reservas)
            selReserva_ = value
        End Set
    End Property

    Dim res As New Reservas

    Private Sub frmResDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = modo_ + " Reserva"

        If modo_ = "Modificar" Then
            res.MostrarPeliculas(dgvPeliculas, selReserva_.id)
            res.CargarComboEstados(cmbEstados, selReserva_.idEstado)
            txtId.Text = selReserva_.id
            dtpFecha.Text = selReserva_.fecha
            cmbEstados.SelectedValue = selReserva_.idEstado
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        res.id = selReserva_.id
        res.idUsuario = selReserva_.idUsuario
        res.fecha = selReserva_.fecha
        res.idEstado = cmbEstados.SelectedValue
        res.ActualizarReserva(res)
        Close()
    End Sub
End Class