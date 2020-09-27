Public Class frmVentanaInicialAdm



    Private Sub PtbProductos_Click(sender As Object, e As EventArgs) Handles PtbProductos.Click
        If Sesion.getNombrePerfil() <> "Empleado" Then
            ModGlobal.moverseDesdeVentanaInicial(Me, frmGestionarProductosAdm)
        Else
            MsgBox("Debido a su perfil, usted no tiene acceso a estas opciones del programa", vbOKOnly + vbExclamation, "Acción No Válida")
        End If

    End Sub

    Private Sub PtbUsuarios_Click(sender As Object, e As EventArgs) Handles PtbUsuarios.Click
        ModGlobal.moverseDesdeVentanaInicial(Me, frmGestionarUsuariosAdm)

    End Sub


    Private Sub PtbDevoluciones_Click(sender As Object, e As EventArgs) Handles PtbDevoluciones.Click
        ModGlobal.setCerrarPorX(False)
        If Sesion.getNombrePerfil() <> "Empleado" Then
            ModGlobal.moverseEntreVentana(Me, frmGestionarDevolucionesAdm)
        Else
            ModGlobal.moverseEntreVentana(Me, frmDevolucionesEmp)
        End If
    End Sub

    Private Sub frmVentanInicialAdm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If ModGlobal.getCerrarPorX() Then
            End
        End If

    End Sub


    Private Sub PtbVentas_Click(sender As Object, e As EventArgs) Handles PtbVentas.Click
        ModGlobal.setCerrarPorX(False)
        If Sesion.getNombrePerfil() = "Empleado" Then
            ModGlobal.moverseEntreVentana(Me, frmVentanaVentasEmp)
        Else
            ModGlobal.moverseDesdeVentanaInicial(Me, frmGestionarVentasAdm)
        End If

    End Sub

    Private Sub subItemRealizarRespaldo_Click(sender As Object, e As EventArgs) Handles subItemRealizarRespaldo.Click
        frmVentanaRespaldo.ShowDialog()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.cerrarSesion(Me, frmInicioSesion)
    End Sub

    Private Sub frmVentanaInicialAdm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModGlobal.getCerrarPorX() Then
            If ModGlobal.consultarSalida() Then
                End
            Else
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub frmVentanaInicialAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModGlobal.setCerrarPorX(True)
        Me.prepararVentanaInicial()

    End Sub

    '---------------------------------------------------------------------------------------------
    'Deshabilita las opciones de menus según el perfil de los usuarios
    '---------------------------------------------------------------------------------------------
    Private Sub deshabilitarMenus()
        Dim subItemsTotales As Byte
        Dim subItemAnalizado As Byte


        subItemsTotales = 2
        subItemAnalizado = 0
        If Sesion.getNombrePerfil() <> "Administrador" Then
            While subItemAnalizado <= subItemsTotales
                Me.menuUsuarios.DropDownItems(subItemAnalizado).Enabled = False
                subItemAnalizado = subItemAnalizado + 1
            End While
        End If
        subItemsTotales = 3
        subItemAnalizado = 2
        If Sesion.getNombrePerfil() <> "Empleado" Then
            Me.menuDevoluciones.DropDownItems(0).Enabled = False
            While subItemAnalizado <= subItemsTotales
                Me.menuVentas.DropDownItems(subItemAnalizado).Enabled = False
                subItemAnalizado = subItemAnalizado + 1
            End While
        Else
            Me.menuProductos.Visible = False
            Me.menuVentas.DropDownItems(0).Enabled = False
            Me.menuVentas.DropDownItems(1).Enabled = False
            Me.menuDevoluciones.DropDownItems(1).Enabled = False
            Me.menuDevoluciones.DropDownItems(1).Enabled = False
        End If



    End Sub
    '------------------------------------------------------------------------------------------------------
    'Adapta al menú principal dependiendo el perfil
    '------------------------------------------------------------------------------------------------------
    Private Sub prepararVentanaInicial()
        Me.deshabilitarMenus()
        Me.Text = "Ventana Inicial " + Sesion.getNombrePerfil()
        Me.lblDatosSesion.Text = "Usuario: " + CStr(Sesion.getIdUsuario()) + "-" + Sesion.getApellidoUsu() + " " + Sesion.getNombreUsu() + "-" + CStr(Sesion.getDniUsuario())
    End Sub


    Private Sub subItemNuevoProd_Click(sender As Object, e As EventArgs) Handles subItemNuevoProd.Click
        Dim pestaniaNuevoProducto As Byte
        pestaniaNuevoProducto = 1
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarProductosAdm.tbcGestionProdAdm, pestaniaNuevoProducto, Me, frmGestionarProductosAdm)

    End Sub

    Private Sub subItemModificarProd_Click(sender As Object, e As EventArgs) Handles subItemModificarProd.Click
        Dim pestaniaModificarProducto As Byte
        pestaniaModificarProducto = 2
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarProductosAdm.tbcGestionProdAdm, pestaniaModificarProducto, Me, frmGestionarProductosAdm)

    End Sub

    Private Sub subItemEliminarProd_Click(sender As Object, e As EventArgs) Handles subItemEliminarProd.Click
        Dim pestaniaEliminarProducto As Byte
        pestaniaEliminarProducto = 3
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarProductosAdm.tbcGestionProdAdm, pestaniaEliminarProducto, Me, frmGestionarProductosAdm)

    End Sub

    Private Sub subItemListarPrdo_Click(sender As Object, e As EventArgs) Handles subItemListarPrdo.Click
        Dim pestaniaListarProducto As Byte
        pestaniaListarProducto = 4
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarProductosAdm.tbcGestionProdAdm, pestaniaListarProducto, Me, frmGestionarProductosAdm)

    End Sub

    Private Sub subItemVentasTotales_Click(sender As Object, e As EventArgs) Handles subItemVentasTotales.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmGestionarVentasAdm)
    End Sub

    Private Sub EstadísticasVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasVentaToolStripMenuItem.Click
        Dim estadisticasVenta As Byte
        estadisticasVenta = 2
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarVentasAdm.tbcVentasAdm, estadisticasVenta, Me, frmGestionarVentasAdm)
    End Sub

    Private Sub subItemNuevoEmp_Click(sender As Object, e As EventArgs) Handles subItemNuevoEmp.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmGestionarUsuariosAdm)
    End Sub

    Private Sub subItemNuevoSub_Click(sender As Object, e As EventArgs) Handles subItemNuevoSub.Click
        Dim nuevoUsuario As Byte
        nuevoUsuario = 2
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarUsuariosAdm.tbcUsuarios, nuevoUsuario, Me, frmGestionarUsuariosAdm)
    End Sub

    Private Sub subItemEliminarUsu_Click(sender As Object, e As EventArgs) Handles subItemEliminarUsu.Click
        Dim eliminarUsuario As Byte
        eliminarUsuario = 3
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarUsuariosAdm.tbcUsuarios, eliminarUsuario, Me, frmGestionarUsuariosAdm)
    End Sub

    Private Sub ModificarDatosPropiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDatosPropiosToolStripMenuItem.Click
        Dim modificarDatosPropios As Byte
        modificarDatosPropios = 4
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarUsuariosAdm.tbcUsuarios, modificarDatosPropios, Me, frmGestionarUsuariosAdm)
    End Sub




    Private Sub subItemEliminarDev_Click(sender As Object, e As EventArgs) Handles subItemEliminarDev.Click
        Dim estadisticasDev As Byte
        estadisticasDev = 2
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmGestionarUsuariosAdm.tbcUsuarios, estadisticasDev, Me, frmGestionarDevolucionesAdm)
    End Sub

    Private Sub subItemRealizarDevoluciones_Click(sender As Object, e As EventArgs)
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmDevolucionesEmp)
    End Sub

    Private Sub RealizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarVentaToolStripMenuItem.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmVentanaVentasEmp)
    End Sub

    Private Sub EstadísitcasPropiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísitcasPropiasToolStripMenuItem.Click
        Dim estadisticasVentasPropias As Byte
        estadisticasVentasPropias = 2
        ModGlobal.setCerrarPorX(False)
        ModGlobal.seleccionarTabControl(frmVentanaVentasEmp.tbcVentasEmpleado, estadisticasVentasPropias, Me, frmVentanaVentasEmp)
    End Sub

    Private Sub subItemCerrarSesion_Click(sender As Object, e As EventArgs) Handles subItemCerrarSesion.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.cerrarSesion(Me, frmInicioSesion)
    End Sub

    Private Sub subItemSalir_Click(sender As Object, e As EventArgs) Handles subItemSalir.Click
        If ModGlobal.consultarSalida() Then
            End
        End If
    End Sub

    Private Sub subItemNuevaDev_Click(sender As Object, e As EventArgs) Handles subItemNuevaDev.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmDevolucionesEmp)
    End Sub
End Class
'probando si funciona