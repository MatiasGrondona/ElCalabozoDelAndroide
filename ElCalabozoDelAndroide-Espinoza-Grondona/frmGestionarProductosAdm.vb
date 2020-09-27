'Imports BusinessLayer
'Imports Entities

Public Class frmGestionarProductosAdm
    'Dim negocioCategoria As New CategoriaBus
    'Dim negocioSubCat As New SubCatBus
    'Dim negocioProducto As New ProductoBus
    'Dim producto As New productos


    Private Sub frmGestionarProductosAdm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModGlobal.getCerrarPorX() Then
            End
        End If
    End Sub


    Private Sub frmGestionarProductosAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.prepararFormularioProductosAdm()
    End Sub

    Private Sub ingresarProducto()
        Dim nombre As String
        Dim precio As String
        Dim stock As String
        Dim stockMin As String
        Dim garantia As String
        Dim ruta As String
        Dim descripcion As String
        Dim categoria As Integer
        Dim subcategoria As Integer
        Dim respuesta As Integer

        nombre = Me.txbNombreProdAdmNuevo.Text
        precio = Me.txbPrecioProdAdmNuevo.Text
        stock = Me.txbStockProdAdmNuevo.Text
        stockMin = Me.txbStockMinProdAdmNuevo.Text
        garantia = Me.txbGarantiaProdAdmNuevo.Text
        ruta = Me.lblRutaProdAdmNuevo.Text
        descripcion = Me.txbDescProdAdmNuevo.Text
        categoria = Me.cmbCatProdAdmNuevo.ValueMember
        subcategoria = Me.cmbSubCatProdAdmNuevo.ValueMember

        If ModGlobal.controlaValoresProducto(precio, stock, stockMin, garantia, ruta, descripcion) Then
            If CInt(stockMin) <= CInt(stock) Then
                If CInt(garantia) > 0 Then
                    'producto.nombreProducto = nombre
                    'producto.precio = precio
                    'producto.stock = CInt(stock)
                    'producto.stockMinimo = CInt(stockMin)
                    'producto.garantia = CInt(garantia)
                    'producto.nombreFoto = ModGlobal.obtenerNombreImagen(ruta)
                    'producto.idSubcategoria = subcategoria
                    'producto.idCategoria = categoria
                    'producto.fecha = Date.Now
                    'producto.descripcionProducto = descripcion
                    respuesta = MsgBox("¿Desea ingresar el producto con los datos establecidos?", vbYesNoCancel, "Confirmación De Ingreso")
                    If respuesta = vbYes Then
                        ' negocioProducto.insertarProducto(producto)
                    End If
                Else
                    MsgBox("Por favor, coloque una garantía mayor a cero", vbCritical + vbOKOnly, "Error en el valor de la garantía")
                End If 'termina el if que controla que la garantía sea mayor a cero
            Else
                MsgBox("Por favor, coloque un stock mínimo menor o igual al stock inicial", vbCritical + vbOKOnly, "Error en el valor de stock")
            End If 'termina el if que controla que el stock mínimo no supere al stock total
        Else
            MsgBox("Por favor, no deje espacios en blanco y coloque valores numéricos donde corresponda", vbCritical + vbOKOnly, "Error de formato de datos")
        End If 'termina el if inicial
    End Sub
    'evento para cuando quiero que ocurra algo ante el cambio del combo box
    Private Sub cmbCategoriasProdAdm_SelectionChangeCommitted1(sender As Object, e As EventArgs) Handles cmbCatProdAdmNuevo.SelectionChangeCommitted
        Me.establecerCategoriaSubcategoria(Me.cmbCatProdAdmNuevo.Text, Me.cmbSubCatProdAdmNuevo.Text)
    End Sub

    Private Sub cmbSubCatProdAdm_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubCatProdAdmNuevo.SelectionChangeCommitted
        Me.establecerCategoriaSubcategoria(Me.cmbCatProdAdmNuevo.Text, Me.cmbSubCatProdAdmNuevo.Text)
    End Sub

    'Permite preparar las condiciones iniciales del formulario
    Private Sub prepararFormularioProductosAdm()
        'evita que se modifique la lista desplegable
        Me.cmbCatProdAdmNuevo.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmbSubCatProdAdmNuevo.DropDownStyle = ComboBoxStyle.DropDownList
        ModGlobal.setCerrarPorX(True)
        'Me.cmbCatProdAdmNuevo.DataSource = negocioCategoria.getCategorias()
        'Me.cmbCatProdAdmNuevo.DisplayMember = "nombre"
        'Me.cmbCatProdAdmNuevo.ValueMember = "idCategoria"
        'Me.cmbCatProdAdmNuevo.SelectedIndex = 0
        'Me.cmbSubCatProdAdmNuevo.DataSource = negocioSubCat.getSubcategorias()
        'Me.cmbSubCatProdAdmNuevo.DisplayMember = "nombre"
        'Me.cmbSubCatProdAdmNuevo.ValueMember = "idSubcategoria"
        'Me.cmbSubCatProdAdmNuevo.SelectedIndex = 0
        'Me.lblRutaProdAdmNuevo.Text = 0
        Me.establecerCategoriaSubcategoria(Me.cmbCatProdAdmNuevo.Text, Me.cmbSubCatProdAdmNuevo.Text)
    End Sub
    'Muestra en una etiqueta la categoría y la subcategoría que tendrá el producto
    'Parámetros:
    'categoria-Tipo: String-El nombre de la categoría seleccionada
    'subcategoria-Tipo: String-El nombre de la subcategoria asociada
    Private Sub establecerCategoriaSubcategoria(ByVal categoria As String, ByVal subcategoria As String)
        Me.lblCategoriaSubcategoria.Text = categoria + "-" + subcategoria
    End Sub

  
    Private Sub btnProductosAdmVolver_Click(sender As Object, e As EventArgs) Handles btnProductosAdmVolver.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmVentanaInicialAdm)
    End Sub

    Private Sub tbcGestionProdAdm_Click(sender As Object, e As EventArgs) Handles tbcGestionProdAdm.Click
       
    End Sub
End Class