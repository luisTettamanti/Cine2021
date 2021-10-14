Imports System.IO

Public Class frmPeliculas

    Private modo_ As String
    Private selPelicula_ As New Peliculas

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
    Dim carpetaInicial As String = "c:\wamp\www\abmPeliculas\img\"

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        pelicula.anio = txtAnio.Text
        pelicula.duracion = txtDuracion.Text
        pelicula.idCategoria = cmbCategoria.SelectedValue
        pelicula.idDirector = cmbDirector.SelectedValue
        pelicula.IMDB = txtIMDB.Text
        pelicula.nombre = txtNombre.Text
        Try
            pelicula.caratula = pcbPelicula.ImageLocation.Substring(InStrRev(pcbPelicula.ImageLocation, "\"))
        Catch ex As Exception
            pelicula.caratula = ""
        End Try
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
        cmbCategoria.SelectedValue = selPelicula_.idCategoria
        Text = modo_ + " Película"
        pelicula.CargarComboCategoriasReader(cmbCategoria, selPelicula_.idCategoria)
        pelicula.CargarComboDirectores(cmbDirector, selPelicula_.idDirector)

        If modo_ = "Modificar" Then
            ap.MostrarActores(dgvActores, selPelicula_.id)
            txtId.Text = selPelicula_.id
            txtNombre.Text = selPelicula_.nombre
            txtAnio.Text = selPelicula_.anio
            txtDuracion.Text = selPelicula_.duracion
            cmbCategoria.SelectedValue = selPelicula_.idCategoria
            cmbDirector.SelectedValue = selPelicula_.idDirector
            txtIMDB.Text = selPelicula_.IMDB
            pcbPelicula.ImageLocation = carpetaInicial & selPelicula_.caratula
        End If
    End Sub

    Private Sub btnAgregarActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarActor.Click
        Dim lstActores As New lstActores
        lstActores.esBusqueda = True
        lstActores.ShowDialog()
        If lstActores.actorSel > 0 Then
            ap.Agregar(lstActores.actorSel, txtId.Text)
            ap.MostrarActores(dgvActores, selPelicula_.id)
        End If
    End Sub

    Private Sub btnBorrarActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarActor.Click
        Dim idActorPelicula As Integer
        idActorPelicula = dgvActores.Item("id", dgvActores.CurrentRow.Index).Value
        ap.Borrar(idActorPelicula)
        ap.MostrarActores(dgvActores, selPelicula_.id)
    End Sub

    Private Sub btnCargarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarImagen.Click
        Dim archivoImagen As String

        Dim ofdImagen As New OpenFileDialog
        ofdImagen.InitialDirectory = carpetaInicial
        ofdImagen.Filter = "Imagenes (*.jpg,*.gif)|*.jpg;*.gif"
        ofdImagen.FilterIndex = 2
        ofdImagen.RestoreDirectory = True

        If ofdImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim carpetaActual As String = ofdImagen.FileName.Substring(0, InStrRev(ofdImagen.FileName, "\"))
            Dim archivoActual As String = ofdImagen.FileName.Substring(InStrRev(ofdImagen.FileName, "\"))
            If UCase(carpetaActual) = UCase(carpetaInicial) Then
                archivoImagen = ofdImagen.FileName
                pcbPelicula.ImageLocation = archivoImagen
            Else
                Dim msgCopiar As DialogResult = MessageBox.Show("¿Quiere copiar la imagen a la carpeta de Imágenes...?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If msgCopiar = Windows.Forms.DialogResult.OK Then
                    File.Copy(ofdImagen.FileName, carpetaInicial + archivoActual)
                    archivoImagen = ofdImagen.FileName
                    pcbPelicula.ImageLocation = archivoImagen
                End If
            End If
        End If
    End Sub
End Class