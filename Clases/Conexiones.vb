Imports System.Data
Imports mysql.data.mysqlclient

Public Class Conexiones
    Private strConexion_ As String
    Private conexion_ As MySqlConnection

    Private Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property

    Public Property conexion() As MySqlConnection
        Get
            Return conexion_
        End Get
        Set(ByVal value As MySqlConnection)
            conexion_ = value
        End Set
    End Property

    Public Sub Abrir()
        Try
            strConexion_ = "Server=127.0.0.1;Database=cine;Uid=root;Pwd='';"
            conexion_ = New MySqlConnection(strConexion)
            conexion_.Open()
        Catch ex As InvalidOperationException
            MsgBox("La base de datos ya está abierta...!")
        Catch ex As MySqlException
            MsgBox("Hay un problema con la conexión...!")
        End Try
    End Sub

    Public Sub Cerrar()
        conexion_.Close()
    End Sub
End Class
