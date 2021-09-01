Public Class frmDirectores

    Private modo_ As String
    Private selDirector_ As Directores

    Public WriteOnly Property modo() As String
        Set(ByVal value As String)
            modo_ = value
        End Set
    End Property

    Public WriteOnly Property selDirector() As Directores
        Set(ByVal value As Directores)
            selDirector_ = value
        End Set
    End Property

    Dim dir As New Directores

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        dir.nombre = txtNombre.Text
        If modo_ = "Agregar" Then
            dir.Agregar(dir)
        Else
            dir.id = txtId.Text
            dir.Modificar(dir)
        End If
        dir.Mostrar(lstDirectores.dgvDirectores)
        Close()
    End Sub

    Private Sub frmPeliculas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = modo_ + " Director"

        If modo_ = "Modificar" Then
            txtId.Text = selDirector_.id
            txtNombre.Text = selDirector_.nombre
        End If

    End Sub



End Class