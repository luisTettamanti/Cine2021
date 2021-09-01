Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ActoresPelicula

    Inherits Conexiones
    Private idActor_ As Integer
    Private idPelicula_ As Integer

    Public Property idActor() As Integer
        Get
            Return idActor_
        End Get
        Set(ByVal value As Integer)
            idActor_ = value
        End Set
    End Property

    Public Property idPelicula() As Integer
        Get
            Return idPelicula_
        End Get
        Set(ByVal value As Integer)
            idPelicula_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView, ByVal idPelicula As Integer)
        Abrir()
        Dim strComando As String = "SELECT ap.id,ap.idpelicula,ap.idactor,a.nombre FROM actorespelicula ap " & _
        "INNER JOIN actores a ON ap.idactor = a.id WHERE idpelicula=@idPelicula"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@idPelicula", idPelicula)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("idPelicula").Visible = False
        grilla.Columns("idActor").Visible = False
        grilla.Columns("id").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal idActor As Integer, ByVal idPelicula As Integer)
        Abrir()
        Dim strComando As String = "INSERT INTO ActoresPelicula (idActor, idPelicula) VALUES (@idActor,@idPelicula)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@idActor", idActor)
        mysqlComando.Parameters.AddWithValue("@idPelicula", idPelicula)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idActorPelicula As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM ActoresPelicula WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idActorPelicula)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

End Class
