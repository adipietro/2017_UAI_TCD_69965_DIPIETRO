<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormularioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciònToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.FamiliaToolStripMenuItem, Me.PatenteToolStripMenuItem, Me.FormularioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem, Me.IngresarToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.IngresarToolStripMenuItem.Text = "Ingresar"
        '
        'FamiliaToolStripMenuItem
        '
        Me.FamiliaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem1})
        Me.FamiliaToolStripMenuItem.Name = "FamiliaToolStripMenuItem"
        Me.FamiliaToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FamiliaToolStripMenuItem.Text = "Familia"
        '
        'ABMToolStripMenuItem1
        '
        Me.ABMToolStripMenuItem1.Name = "ABMToolStripMenuItem1"
        Me.ABMToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.ABMToolStripMenuItem1.Text = "ABM"
        '
        'PatenteToolStripMenuItem
        '
        Me.PatenteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem2, Me.ListadoToolStripMenuItem})
        Me.PatenteToolStripMenuItem.Name = "PatenteToolStripMenuItem"
        Me.PatenteToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.PatenteToolStripMenuItem.Text = "Patente"
        '
        'ABMToolStripMenuItem2
        '
        Me.ABMToolStripMenuItem2.Name = "ABMToolStripMenuItem2"
        Me.ABMToolStripMenuItem2.Size = New System.Drawing.Size(112, 22)
        Me.ABMToolStripMenuItem2.Text = "Alta"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'FormularioToolStripMenuItem
        '
        Me.FormularioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciònToolStripMenuItem})
        Me.FormularioToolStripMenuItem.Name = "FormularioToolStripMenuItem"
        Me.FormularioToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FormularioToolStripMenuItem.Text = "Formulario"
        '
        'AdministraciònToolStripMenuItem
        '
        Me.AdministraciònToolStripMenuItem.Name = "AdministraciònToolStripMenuItem"
        Me.AdministraciònToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AdministraciònToolStripMenuItem.Text = "Administraciòn"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(579, 333)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema Integrado de Compras y Proveedores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormularioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciònToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
