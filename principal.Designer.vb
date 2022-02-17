<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PelículasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.DirectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActoresActricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservasToolStripMenuItem, Me.ToolStripSeparator1, Me.PelículasToolStripMenuItem, Me.DirectoresToolStripMenuItem, Me.ActoresActricesToolStripMenuItem, Me.CategoríasToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'PelículasToolStripMenuItem
        '
        Me.PelículasToolStripMenuItem.Name = "PelículasToolStripMenuItem"
        Me.PelículasToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PelículasToolStripMenuItem.Text = "Películas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'DirectoresToolStripMenuItem
        '
        Me.DirectoresToolStripMenuItem.Name = "DirectoresToolStripMenuItem"
        Me.DirectoresToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DirectoresToolStripMenuItem.Text = "Directores"
        '
        'ActoresActricesToolStripMenuItem
        '
        Me.ActoresActricesToolStripMenuItem.Name = "ActoresActricesToolStripMenuItem"
        Me.ActoresActricesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ActoresActricesToolStripMenuItem.Text = "Actores/Actrices"
        '
        'CategoríasToolStripMenuItem
        '
        Me.CategoríasToolStripMenuItem.Name = "CategoríasToolStripMenuItem"
        Me.CategoríasToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CategoríasToolStripMenuItem.Text = "Categorías"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 412)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "principal"
        Me.Text = "Cine 2021"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelículasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoríasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ActoresActricesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
