Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Peliculas
    Inherits Conexiones
    Private id_ As Integer
    Private nombre_ As String
    Private anio_ As Integer
    Private duracion_ As Integer
    Private categoria_ As String
    Private idDirector_ As Integer
    Private IMDB_ As Decimal
    Private idCategoria_ As Integer

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

    Public Property anio() As Integer
        Get
            Return anio_
        End Get
        Set(ByVal value As Integer)
            anio_ = value
        End Set
    End Property

    Public Property duracion() As Decimal
        Get
            Return duracion_
        End Get
        Set(ByVal value As Decimal)
            duracion_ = value
        End Set
    End Property

    Public Property categoria() As String
        Get
            Return categoria_
        End Get
        Set(ByVal value As String)
            categoria_ = value
        End Set
    End Property

    Public Property idDirector() As Integer
        Get
            Return idDirector_
        End Get
        Set(ByVal value As Integer)
            idDirector_ = value
        End Set
    End Property

    Public Property IMDB() As Decimal
        Get
            Return IMDB_
        End Get
        Set(ByVal value As Decimal)
            IMDB_ = value
        End Set
    End Property

    Public Property idCategoria() As Integer
        Get
            Return idCategoria_
        End Get
        Set(ByVal value As Integer)
            idCategoria_ = value
        End Set
    End Property

    Public Sub Mostrar(ByVal grilla As DataGridView)
        Abrir()
        Dim strComando As String = "SELECT p.id, p.anio, p.duracion, p.idCategoria, p.idDirector, p.IMDB, p.nombre, c.nombre categoria, d.nombre director " & _
        "FROM peliculas p " & _
        "INNER JOIN categorias c ON c.id=p.idCategoria " & _
        "INNER JOIN directores d ON d.id=p.idDirector"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("duracion").Visible = False
        grilla.Columns("idCategoria").Visible = False
        grilla.Columns("idDirector").Visible = False
        grilla.Columns("IMDB").Visible = False
        grilla.Columns("id").Width = 50
        grilla.Columns("anio").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grilla.Columns("director").Width = 150
        Cerrar()
    End Sub

    Public Sub Mostrar(ByVal grilla As DataGridView, ByVal busqueda As String)
        Abrir()
        Dim strComando As String = "SELECT p.id, p.anio, p.duracion, p.idCategoria, p.idDirector, p.IMDB, p.nombre, c.nombre categoria, d.nombre director " & _
        "FROM peliculas p " & _
        "INNER JOIN categorias c ON c.id=p.idCategoria " & _
        "INNER JOIN directores d ON d.id=p.idDirector " & _
        "WHERE UCASE(p.nombre) LIKE UCASE(@busqueda)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%")
        Dim tabla As New DataTable
        tabla.Load(mysqlComando.ExecuteReader)
        grilla.DataSource = tabla
        grilla.Columns("duracion").Visible = False
        grilla.Columns("idCategoria").Visible = False
        grilla.Columns("idDirector").Visible = False
        grilla.Columns("IMDB").Visible = False
        grilla.Columns("id").Width = 50
        grilla.Columns("anio").Width = 50
        grilla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grilla.Columns("director").Width = 150
        Cerrar()
    End Sub

    Public Sub Agregar(ByVal pelicula As Peliculas)
        Abrir()

        'Comando Insertar utilizando concatenamiento de strings
        'Dim strComando As String = "INSERT INTO peliculas (nombre, anio, duracion, categoria, idDirector, IMDB, idCategoria) " & _
        '"VALUES ('" + pelicula.nombre + "'," + Str(pelicula.anio) + "," + Str(pelicula.duracion) + ",'" & _
        '"" + pelicula.categoria + "'," + Str(pelicula.idDirector) + "," + Str(pelicula.IMDB) + "," + Str(pelicula.idCategoria) + ")"
        'Dim mysqlComando As New MySqlCommand(strComando, conexion)

        'Comando Insertar utilizando parámetros
        'No se tiene en cuenta la clave id porque se definió como autonumérica
        Dim strComando As String = "INSERT INTO peliculas (nombre, anio, duracion, idDirector, IMDB, idCategoria) VALUES (@nombre, @anio, @duracion, @categoria, @idDirector, @IMDB, @idCategoria)"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@nombre", pelicula.nombre)
        mysqlComando.Parameters.AddWithValue("@anio", pelicula.anio)
        mysqlComando.Parameters.AddWithValue("@duracion", pelicula.duracion)
        mysqlComando.Parameters.AddWithValue("@idDirector", pelicula.idDirector)
        mysqlComando.Parameters.AddWithValue("@IMDB", pelicula.IMDB)
        mysqlComando.Parameters.AddWithValue("@idCategoria", pelicula.idCategoria)

        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Modificar(ByVal pelicula As Peliculas)
        Abrir()
        Dim strComando As String = "UPDATE peliculas SET nombre=@nombre, anio=@anio, duracion=@duracion, idDirector=@idDirector, IMDB=@IMDB, idCategoria=@idCategoria WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", pelicula.id)
        mysqlComando.Parameters.AddWithValue("@nombre", pelicula.nombre)
        mysqlComando.Parameters.AddWithValue("@anio", pelicula.anio)
        mysqlComando.Parameters.AddWithValue("@duracion", pelicula.duracion)
        mysqlComando.Parameters.AddWithValue("@idDirector", pelicula.idDirector)
        mysqlComando.Parameters.AddWithValue("@IMDB", pelicula.IMDB)
        mysqlComando.Parameters.AddWithValue("@idCategoria", pelicula.idCategoria)

        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub Borrar(ByVal idPelicula As Integer)
        Abrir()
        Dim strComando As String = "DELETE FROM peliculas WHERE id=@id"
        Dim mysqlComando As New MySqlCommand(strComando, conexion)
        mysqlComando.Parameters.AddWithValue("@id", idPelicula)
        mysqlComando.ExecuteNonQuery()
        Cerrar()
    End Sub

    Public Sub CargarComboCategoriasTable(ByVal comboActual As ComboBox, ByVal idCategoria As Integer)
        Try
            Abrir()
            Dim strComando As String = "SELECT id, nombre FROM categorias ORDER BY nombre"
            Dim mysqlComando As New MySqlCommand(strComando, conexion)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New MySqlDataAdapter(mysqlComando)
            objDataAdapter.Fill(objDataTable)
            With comboActual
                .DataSource = objDataTable
                .DisplayMember = "nombre"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub CargarComboCategoriasReader(ByVal comboActual As ComboBox, ByVal idCategoria As Integer)
        Try
            Abrir()
            Dim strComando As String = "SELECT id, nombre FROM categorias ORDER BY nombre"
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

    Public Sub CargarComboDirectores(ByVal comboActual As ComboBox, ByVal idDirector As Integer)
        Try
            Abrir()
            Dim strComando As String = "SELECT id, nombre FROM directores ORDER BY nombre"
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
