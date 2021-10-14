<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeliculas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDuracion = New System.Windows.Forms.TextBox
        Me.txtIMDB = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtAnio = New System.Windows.Forms.MaskedTextBox
        Me.cmbCategoria = New System.Windows.Forms.ComboBox
        Me.cmbDirector = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAgregarActor = New System.Windows.Forms.Button
        Me.btnBorrarActor = New System.Windows.Forms.Button
        Me.dgvActores = New System.Windows.Forms.DataGridView
        Me.pcbPelicula = New System.Windows.Forms.PictureBox
        Me.btnCargarImagen = New System.Windows.Forms.Button
        CType(Me.dgvActores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(80, 13)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(110, 20)
        Me.txtId.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(80, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(296, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(80, 91)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(110, 20)
        Me.txtDuracion.TabIndex = 7
        '
        'txtIMDB
        '
        Me.txtIMDB.Location = New System.Drawing.Point(80, 169)
        Me.txtIMDB.Name = "txtIMDB"
        Me.txtIMDB.Size = New System.Drawing.Size(110, 20)
        Me.txtIMDB.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "duración:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "director:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "IMDB:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "categoría:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(148, 315)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(229, 315)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(79, 65)
        Me.txtAnio.Mask = "0000"
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(110, 20)
        Me.txtAnio.TabIndex = 5
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(80, 117)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(296, 21)
        Me.cmbCategoria.TabIndex = 18
        '
        'cmbDirector
        '
        Me.cmbDirector.FormattingEnabled = True
        Me.cmbDirector.Location = New System.Drawing.Point(79, 143)
        Me.cmbDirector.Name = "cmbDirector"
        Me.cmbDirector.Size = New System.Drawing.Size(297, 21)
        Me.cmbDirector.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "reparto:"
        '
        'btnAgregarActor
        '
        Me.btnAgregarActor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarActor.Location = New System.Drawing.Point(12, 245)
        Me.btnAgregarActor.Name = "btnAgregarActor"
        Me.btnAgregarActor.Size = New System.Drawing.Size(63, 23)
        Me.btnAgregarActor.TabIndex = 22
        Me.btnAgregarActor.Text = "Agregar"
        Me.btnAgregarActor.UseVisualStyleBackColor = True
        '
        'btnBorrarActor
        '
        Me.btnBorrarActor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarActor.Location = New System.Drawing.Point(12, 275)
        Me.btnBorrarActor.Name = "btnBorrarActor"
        Me.btnBorrarActor.Size = New System.Drawing.Size(61, 23)
        Me.btnBorrarActor.TabIndex = 23
        Me.btnBorrarActor.Text = "Borrar"
        Me.btnBorrarActor.UseVisualStyleBackColor = True
        '
        'dgvActores
        '
        Me.dgvActores.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvActores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActores.Location = New System.Drawing.Point(81, 195)
        Me.dgvActores.Name = "dgvActores"
        Me.dgvActores.ReadOnly = True
        Me.dgvActores.RowHeadersVisible = False
        Me.dgvActores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActores.Size = New System.Drawing.Size(296, 103)
        Me.dgvActores.TabIndex = 24
        '
        'pcbPelicula
        '
        Me.pcbPelicula.Location = New System.Drawing.Point(383, 12)
        Me.pcbPelicula.Name = "pcbPelicula"
        Me.pcbPelicula.Size = New System.Drawing.Size(242, 286)
        Me.pcbPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbPelicula.TabIndex = 25
        Me.pcbPelicula.TabStop = False
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.Location = New System.Drawing.Point(383, 315)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(242, 23)
        Me.btnCargarImagen.TabIndex = 26
        Me.btnCargarImagen.Text = "Cargar imagen"
        Me.btnCargarImagen.UseVisualStyleBackColor = True
        '
        'frmPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 349)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.Controls.Add(Me.pcbPelicula)
        Me.Controls.Add(Me.dgvActores)
        Me.Controls.Add(Me.btnBorrarActor)
        Me.Controls.Add(Me.btnAgregarActor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbDirector)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIMDB)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(653, 747)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(653, 388)
        Me.Name = "frmPeliculas"
        Me.Text = "Peliculas"
        CType(Me.dgvActores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents txtIMDB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtAnio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDirector As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarActor As System.Windows.Forms.Button
    Friend WithEvents btnBorrarActor As System.Windows.Forms.Button
    Friend WithEvents dgvActores As System.Windows.Forms.DataGridView
    Friend WithEvents pcbPelicula As System.Windows.Forms.PictureBox
    Friend WithEvents btnCargarImagen As System.Windows.Forms.Button
End Class
