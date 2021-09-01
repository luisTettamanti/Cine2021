Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Directores
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
        Dim strComando As String = "SELECT * FROM Directores"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal dir As Directores)
        Abrir()
        Dim strComando As String = "INSERT INTO Directores (nombre) VALUES (@nombre)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@nombre", dir.nombre)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal dir As Directores)
        Abrir()
        Dim strComando As String = "UPDATE Directores SET nombre=@nombre WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", dir.id)
        mysqlComando.Parameters.AddWithValue("@nombre", dir.nombre)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idDirector As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM Directores WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idDirector)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

End Class
