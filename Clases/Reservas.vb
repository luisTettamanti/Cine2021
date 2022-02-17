Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Reservas
    Inherits Conexiones
    Private id_ As Integer
    Private idUsuario_ As Integer
    Private fecha_ As Date
    Private idEstado_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property idUsuario() As Integer
        Get
            Return idUsuario_
        End Get
        Set(ByVal value As Integer)
            idUsuario_ = value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return fecha_
        End Get
        Set(ByVal value As Date)
            fecha_ = value
        End Set
    End Property

    Public Property idEstado() As Integer
        Get
            Return idEstado_
        End Get
        Set(ByVal value As Integer)
            idEstado_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView) ', ByVal busqueda As String)
        Abrir()
        Dim strComando As String = "SELECT r.id, r.idUsuario, u.nombre, u.email, r.fecha, r.idEstado, re.color " & _
        "FROM Reservas r " & _
        "INNER JOIN Usuarios u ON u.id=r.idUsuario " & _
        "INNER JOIN resEstados re ON re.id=r.idEstado " & _
        "ORDER BY r.id DESC"
        '"WHERE UCASE(p.nombre) LIKE UCASE(@busqueda)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        'mysqlComando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%")
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("idUsuario").Visible = False
        grilla.Columns("fecha").Width = 50
        grilla.Columns("email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grilla.Columns("nombre").Width = 200
        grilla.Columns("fecha").Width = 150
        grilla.Columns("idEstado").Visible = False
        grilla.Columns("color").Visible = False
        Cerrar()
    End Sub

    Public Sub Colorear(ByVal grilla As DataGridView)
        For i = 0 To grilla.Rows.Count - 1
            grilla.Rows(i).DefaultCellStyle.BackColor = Color.FromName(grilla.Rows(i).Cells("color").Value)
        Next
    End Sub

    Public Sub MostrarPeliculas(ByVal grilla As DataGridView, ByVal idReserva As Integer)
        Abrir()
        Dim strComando As String = "SELECT p.id, p.nombre, rp.cantidad FROM respeliculas rp " & _
        "INNER JOIN peliculas p ON p.id=rp.idPelicula " & _
        "WHERE idreserva=@idReserva"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@idReserva", idReserva)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("id").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grilla.Columns("cantidad").Width = 50
        Cerrar()
    End Sub

    Public Sub ActualizarReserva(ByVal reserva As Reservas)
        Abrir()
        Dim strComando As String = "UPDATE Reservas SET idEstado=@idEstado WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@idEstado", reserva.idEstado)
        mysqlComando.Parameters.AddWithValue("@id", reserva.id)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub CargarComboEstados(ByVal comboActual As ComboBox, ByVal idEstado As Integer)
        Try
            Abrir()
            Dim strComando As String = "SELECT id, nombre FROM resEstados"
            Dim mysqlComando As New MySqlCommand(strComando, conexion)
            Dim tabla As New Data.DataTable
            tabla.Load(mysqlComando.ExecuteReader)
            With comboActual
                .DataSource = tabla
                .DisplayMember = "nombre"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

End Class
