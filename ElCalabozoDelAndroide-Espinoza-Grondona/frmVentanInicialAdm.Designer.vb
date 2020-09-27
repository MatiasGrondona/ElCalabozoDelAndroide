<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentanaInicialAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentanaInicialAdm))
        Me.PtbDevoluciones = New System.Windows.Forms.PictureBox()
        Me.PtbUsuarios = New System.Windows.Forms.PictureBox()
        Me.PtbProductos = New System.Windows.Forms.PictureBox()
        Me.PtbVentas = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDatosSesion = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.menuVentanaPrincipal = New System.Windows.Forms.MenuStrip()
        Me.menuProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemNuevoProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemModificarProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemEliminarProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemListarPrdo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemVentasTotales = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísitcasPropiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemNuevoEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemNuevoSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemEliminarUsu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDatosPropiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDevoluciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemNuevaDev = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemEliminarDev = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemSistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemRealizarRespaldo = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.subItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PtbDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuVentanaPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PtbDevoluciones
        '
        Me.PtbDevoluciones.BackgroundImage = CType(resources.GetObject("PtbDevoluciones.BackgroundImage"), System.Drawing.Image)
        Me.PtbDevoluciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbDevoluciones.Location = New System.Drawing.Point(260, 380)
        Me.PtbDevoluciones.Name = "PtbDevoluciones"
        Me.PtbDevoluciones.Size = New System.Drawing.Size(336, 337)
        Me.PtbDevoluciones.TabIndex = 8
        Me.PtbDevoluciones.TabStop = False
        '
        'PtbUsuarios
        '
        Me.PtbUsuarios.BackgroundImage = CType(resources.GetObject("PtbUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.PtbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbUsuarios.Location = New System.Drawing.Point(834, 70)
        Me.PtbUsuarios.Name = "PtbUsuarios"
        Me.PtbUsuarios.Size = New System.Drawing.Size(325, 300)
        Me.PtbUsuarios.TabIndex = 7
        Me.PtbUsuarios.TabStop = False
        '
        'PtbProductos
        '
        Me.PtbProductos.BackgroundImage = CType(resources.GetObject("PtbProductos.BackgroundImage"), System.Drawing.Image)
        Me.PtbProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbProductos.Location = New System.Drawing.Point(484, 70)
        Me.PtbProductos.Name = "PtbProductos"
        Me.PtbProductos.Size = New System.Drawing.Size(325, 300)
        Me.PtbProductos.TabIndex = 6
        Me.PtbProductos.TabStop = False
        '
        'PtbVentas
        '
        Me.PtbVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbVentas.Image = CType(resources.GetObject("PtbVentas.Image"), System.Drawing.Image)
        Me.PtbVentas.Location = New System.Drawing.Point(135, 70)
        Me.PtbVentas.Name = "PtbVentas"
        Me.PtbVentas.Size = New System.Drawing.Size(325, 300)
        Me.PtbVentas.TabIndex = 5
        Me.PtbVentas.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(715, 380)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 337)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblDatosSesion
        '
        Me.lblDatosSesion.AutoSize = True
        Me.lblDatosSesion.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosSesion.Location = New System.Drawing.Point(919, 30)
        Me.lblDatosSesion.Name = "lblDatosSesion"
        Me.lblDatosSesion.Size = New System.Drawing.Size(367, 22)
        Me.lblDatosSesion.TabIndex = 10
        Me.lblDatosSesion.Text = "Datos Del Usuario Cuya Sesión Está Iniciada"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Red
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.Location = New System.Drawing.Point(25, 25)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(198, 36)
        Me.btnCerrarSesion.TabIndex = 11
        Me.btnCerrarSesion.Text = "CERRAR SESIÓN"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'menuVentanaPrincipal
        '
        Me.menuVentanaPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuProductos, Me.menuVentas, Me.menuUsuarios, Me.menuDevoluciones, Me.itemAyuda, Me.itemSistema})
        Me.menuVentanaPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuVentanaPrincipal.Name = "menuVentanaPrincipal"
        Me.menuVentanaPrincipal.Size = New System.Drawing.Size(1370, 24)
        Me.menuVentanaPrincipal.TabIndex = 12
        Me.menuVentanaPrincipal.Text = "Productos"
        '
        'menuProductos
        '
        Me.menuProductos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subItemNuevoProd, Me.subItemModificarProd, Me.subItemEliminarProd, Me.subItemListarPrdo})
        Me.menuProductos.Name = "menuProductos"
        Me.menuProductos.Size = New System.Drawing.Size(73, 20)
        Me.menuProductos.Text = "Productos"
        '
        'subItemNuevoProd
        '
        Me.subItemNuevoProd.Name = "subItemNuevoProd"
        Me.subItemNuevoProd.Size = New System.Drawing.Size(177, 22)
        Me.subItemNuevoProd.Text = "Nuevo Producto"
        '
        'subItemModificarProd
        '
        Me.subItemModificarProd.Name = "subItemModificarProd"
        Me.subItemModificarProd.Size = New System.Drawing.Size(177, 22)
        Me.subItemModificarProd.Text = "Modificar Producto"
        '
        'subItemEliminarProd
        '
        Me.subItemEliminarProd.Name = "subItemEliminarProd"
        Me.subItemEliminarProd.Size = New System.Drawing.Size(177, 22)
        Me.subItemEliminarProd.Text = "Eliminar Producto"
        '
        'subItemListarPrdo
        '
        Me.subItemListarPrdo.Name = "subItemListarPrdo"
        Me.subItemListarPrdo.Size = New System.Drawing.Size(177, 22)
        Me.subItemListarPrdo.Text = "Listar Productos"
        '
        'menuVentas
        '
        Me.menuVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subItemVentasTotales, Me.EstadísticasVentaToolStripMenuItem, Me.RealizarVentaToolStripMenuItem, Me.EstadísitcasPropiasToolStripMenuItem})
        Me.menuVentas.Name = "menuVentas"
        Me.menuVentas.Size = New System.Drawing.Size(54, 20)
        Me.menuVentas.Text = "Ventas"
        '
        'subItemVentasTotales
        '
        Me.subItemVentasTotales.Name = "subItemVentasTotales"
        Me.subItemVentasTotales.Size = New System.Drawing.Size(181, 22)
        Me.subItemVentasTotales.Text = "Listar Ventas Totales"
        '
        'EstadísticasVentaToolStripMenuItem
        '
        Me.EstadísticasVentaToolStripMenuItem.Name = "EstadísticasVentaToolStripMenuItem"
        Me.EstadísticasVentaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EstadísticasVentaToolStripMenuItem.Text = "Estadísticas Venta"
        '
        'RealizarVentaToolStripMenuItem
        '
        Me.RealizarVentaToolStripMenuItem.Name = "RealizarVentaToolStripMenuItem"
        Me.RealizarVentaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RealizarVentaToolStripMenuItem.Text = "Realizar Venta"
        '
        'EstadísitcasPropiasToolStripMenuItem
        '
        Me.EstadísitcasPropiasToolStripMenuItem.Name = "EstadísitcasPropiasToolStripMenuItem"
        Me.EstadísitcasPropiasToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EstadísitcasPropiasToolStripMenuItem.Text = "Estadísitcas Propias"
        '
        'menuUsuarios
        '
        Me.menuUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subItemNuevoEmp, Me.subItemNuevoSub, Me.subItemEliminarUsu, Me.ModificarDatosPropiosToolStripMenuItem})
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.menuUsuarios.Text = "Usuarios"
        '
        'subItemNuevoEmp
        '
        Me.subItemNuevoEmp.Name = "subItemNuevoEmp"
        Me.subItemNuevoEmp.Size = New System.Drawing.Size(216, 22)
        Me.subItemNuevoEmp.Text = "Agregar Nuevo Empleado"
        '
        'subItemNuevoSub
        '
        Me.subItemNuevoSub.Name = "subItemNuevoSub"
        Me.subItemNuevoSub.Size = New System.Drawing.Size(216, 22)
        Me.subItemNuevoSub.Text = "Nuevo Usuario"
        '
        'subItemEliminarUsu
        '
        Me.subItemEliminarUsu.Name = "subItemEliminarUsu"
        Me.subItemEliminarUsu.Size = New System.Drawing.Size(216, 22)
        Me.subItemEliminarUsu.Text = "Modificar/Eliminar Usuario"
        '
        'ModificarDatosPropiosToolStripMenuItem
        '
        Me.ModificarDatosPropiosToolStripMenuItem.Name = "ModificarDatosPropiosToolStripMenuItem"
        Me.ModificarDatosPropiosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ModificarDatosPropiosToolStripMenuItem.Text = "Modificar Datos Propios"
        '
        'menuDevoluciones
        '
        Me.menuDevoluciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subItemNuevaDev, Me.subItemEliminarDev})
        Me.menuDevoluciones.Name = "menuDevoluciones"
        Me.menuDevoluciones.Size = New System.Drawing.Size(90, 20)
        Me.menuDevoluciones.Text = "Devoluciones"
        '
        'subItemNuevaDev
        '
        Me.subItemNuevaDev.Name = "subItemNuevaDev"
        Me.subItemNuevaDev.Size = New System.Drawing.Size(176, 22)
        Me.subItemNuevaDev.Text = "Nueva Devolución"
        '
        'subItemEliminarDev
        '
        Me.subItemEliminarDev.Name = "subItemEliminarDev"
        Me.subItemEliminarDev.Size = New System.Drawing.Size(176, 22)
        Me.subItemEliminarDev.Text = "Listar Devoluciones"
        '
        'itemAyuda
        '
        Me.itemAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subItemManual, Me.subItemAcercaDe})
        Me.itemAyuda.Name = "itemAyuda"
        Me.itemAyuda.Size = New System.Drawing.Size(53, 20)
        Me.itemAyuda.Text = "Ayuda"
        '
        'subItemManual
        '
        Me.subItemManual.Name = "subItemManual"
        Me.subItemManual.Size = New System.Drawing.Size(174, 22)
        Me.subItemManual.Text = "Manual De Usuario"
        '
        'subItemAcercaDe
        '
        Me.subItemAcercaDe.Name = "subItemAcercaDe"
        Me.subItemAcercaDe.Size = New System.Drawing.Size(174, 22)
        Me.subItemAcercaDe.Text = "Acerca De"
        '
        'itemSistema
        '
        Me.itemSistema.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subItemRealizarRespaldo, Me.subItemCerrarSesion, Me.subItemSalir})
        Me.itemSistema.Name = "itemSistema"
        Me.itemSistema.Size = New System.Drawing.Size(60, 20)
        Me.itemSistema.Text = "Sistema"
        '
        'subItemRealizarRespaldo
        '
        Me.subItemRealizarRespaldo.Name = "subItemRealizarRespaldo"
        Me.subItemRealizarRespaldo.Size = New System.Drawing.Size(165, 22)
        Me.subItemRealizarRespaldo.Text = "Realizar Respaldo"
        '
        'subItemCerrarSesion
        '
        Me.subItemCerrarSesion.Name = "subItemCerrarSesion"
        Me.subItemCerrarSesion.Size = New System.Drawing.Size(165, 22)
        Me.subItemCerrarSesion.Text = "Cerrar Sesión"
        '
        'subItemSalir
        '
        Me.subItemSalir.Name = "subItemSalir"
        Me.subItemSalir.Size = New System.Drawing.Size(165, 22)
        Me.subItemSalir.Text = "Salir"
        '
        'frmVentanaInicialAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.lblDatosSesion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PtbDevoluciones)
        Me.Controls.Add(Me.PtbUsuarios)
        Me.Controls.Add(Me.PtbProductos)
        Me.Controls.Add(Me.PtbVentas)
        Me.Controls.Add(Me.menuVentanaPrincipal)
        Me.MainMenuStrip = Me.menuVentanaPrincipal
        Me.Name = "frmVentanaInicialAdm"
        Me.Text = "Ventana Inicial Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PtbDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuVentanaPrincipal.ResumeLayout(False)
        Me.menuVentanaPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PtbDevoluciones As System.Windows.Forms.PictureBox
    Friend WithEvents PtbUsuarios As System.Windows.Forms.PictureBox
    Friend WithEvents PtbProductos As System.Windows.Forms.PictureBox
    Friend WithEvents PtbVentas As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDatosSesion As System.Windows.Forms.Label
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents menuVentanaPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents menuProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemNuevoProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemModificarProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemEliminarProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemListarPrdo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemVentasTotales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemNuevoEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemNuevoSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemEliminarUsu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDevoluciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemNuevaDev As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemEliminarDev As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemCerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subItemRealizarRespaldo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísticasVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarDatosPropiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísitcasPropiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
