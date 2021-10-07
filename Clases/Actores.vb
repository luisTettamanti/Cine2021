Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Actores
    Inherits Conexiones
    Private id_ As Integer
    Private nombre_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT * FROM Actores"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Mostrar(ByVal grilla As DataGridView, ByVal busqueda As String)
        Abrir()
        Dim strComando As String = "SELECT * FROM actores WHERE nombre LIKE @busqueda"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%")
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal actor As Actores)
        Abrir()
        Dim strComando As String = "INSERT INTO Actores (nombre) VALUES (@nombre)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@nombre", actor.nombre)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal actor As Actores)
        Abrir()
        Dim strComando As String = "UPDATE Actores SET nombre=@nombre WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", actor.id)
        mysqlComando.Parameters.AddWithValue("@nombre", actor.nombre)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idActor As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Actores WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idActor)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

End Class

