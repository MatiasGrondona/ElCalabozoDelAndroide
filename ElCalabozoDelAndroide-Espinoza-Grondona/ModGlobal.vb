Module ModGlobal
    'variable global que permite controlar si se cierra mediante el botón X o no
    Dim cerrarPorX As Boolean

    Public Sub setCerrarPorX(ByVal valor As Boolean)
        cerrarPorX = valor
    End Sub

    Public Function getCerrarPorX() As Boolean
        Return cerrarPorX
    End Function

    '-------------------------------------------------------------------------------------------------------------
    'Permite moverse entre ventanas cerrando la ventana origen y mostrando la ventana destino
    'Parámetros:
    'ventanaOrigen-Tipo: Formulario-La ventana que se cerrará
    'ventanaDestino-Tipo: Formulario-La vantana que se abrirá
    '------------------------------------------------------------------------------------------------------------
    Public Sub moverseEntreVentana(ByRef ventanaOrigen As Form, ByRef ventanaDestino As Form)
        ventanaOrigen.Close()
        ventanaDestino.Show()
    End Sub
    '------------------------------------------------------------------------------------------------------------------
    'Permite cerrar las ventanas y volver a la ventana de inicio de sesión
    'Parámetros:
    'ventanaOrigen-Tipo: Formulario-La ventana que se cerrará, será la ventana principal de un usuario según su perfil
    'ventanaSesión-Tipo: Formulario-La ventana de inicio de sesión que se volverá visible
    '----------------------------------------------------------------------------------------------------------------
    Public Sub cerrarSesion(ByRef ventanaOrigen As Form, ByRef ventanaSesion As Form)
        ventanaOrigen.Close()
        ventanaSesion.Visible = True
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    'Permite moverse desde la ventana inicial hacia cualquier otra. La diferencia con moverseEntreVentanas es que
    'este método no cierra la ventana principal, sólo la vuelve invisible
    'Parámetros:
    'pantallaInicial-Tipo: Formulario-La ventana inicial que se volverá invisible. Puede ser de cualquier perfil
    'ventanaDestino-Tipo: Formulario-La ventana destino que se mostrará 
    '-------------------------------------------------------------------------------------------------------------
    Public Sub moverseDesdeVentanaInicial(ByRef ventanaInicial As Form, ByRef ventanaDestino As Form)
        ventanaInicial.Visible = False
        ventanaDestino.Show()
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    'Permite controlar los valores ingresados para un producto
    'Parámetros:
    'precio-Tipo: String-Representa el precio del producto
    'stock-Tipo: String-Representa el stock inicial del producto
    'stockMin-Tipo: String-Representa el stock mínimo del producto
    'garantia-Tipo: String-Representa la cantidad de de días de garantía del producto
    'ruta-Tipo: String-Representa la ruta donde se guardará la imagen del producto
    'descripción-Tipo: String-Representa la descripción asociada al producto
    'Retorno: Retorna True si todos los datos cumplen los criterios de aceptación y False en caso contrario
    '-------------------------------------------------------------------------------------------------------------
    Public Function controlaValoresProducto(ByVal precio As String, ByVal stock As String, ByVal stockMin As String, ByVal garantia As String, ByVal Ruta As String, ByVal descripcion As String) As Boolean
        Dim precioCorrecto As Boolean
        Dim stockCorrecto As Boolean
        Dim stockMinCorrecto As Boolean
        Dim garantiaCorrecta As Boolean
        Dim imagenCorrecta As Boolean
        Dim descripcionCorrecta As Boolean

        Dim respuesta As Boolean
        precioCorrecto = controlarValores(precio)
        stockCorrecto = controlarValores(stock)
        stockMinCorrecto = controlarValores(stockMin)
        garantiaCorrecta = controlarValores(garantia)
        If Ruta <> "" Then
            imagenCorrecta = True
        Else
            imagenCorrecta = False
        End If

        If descripcion <> "" Then
            descripcionCorrecta = True
        Else
            descripcionCorrecta = False
        End If

        If precioCorrecto And stockCorrecto And stockMinCorrecto And garantiaCorrecta And imagenCorrecta And descripcionCorrecta Then
            respuesta = True
        Else
            respuesta = False
        End If
        controlaValoresProducto = respuesta
    End Function
    '-------------------------------------------------------------------------------------------------------------
    'Controla que los valores ingresados sean sólo enteros positivos
    'Parámetros
    'valor-Tipo: String-es el valor que se desea controlar que sea sólo un entero positivo
    'Retorno: retorna True en caso de que sea un valor entero positivo y retorna False en caso contrario
    '------------------------------------------------------------------------------------------------------------
    Private Function controlarValores(ByVal valor As String) As Boolean
        Dim resultado As Boolean
        Dim longitudValor As Integer
        Dim digito As Integer

        Try
            longitudValor = valor.Length
            digito = 0
            resultado = True
            If Trim(valor) = "" Or Not IsNumeric(valor) Then
                resultado = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOK, "Error en controlarValores")
            resultado = False
        End Try

        controlarValores = resultado
    End Function
    '--------------------------------------------------------------------------------------------------------------
    'Controla que el texto sólo contenga letras
    'Parámetros:
    'texto-Tipo: String-Es el texto que se va analizar que sólo contenga letras
    'Retorno: Retorna True en caso de que el texto contenga sólo letras y retorna False en caso contrario
    '---------------------------------------------------------------------------------------------------------------
    Private Function controlarLetras(ByVal texto As String) As Boolean
        Dim tamanioTexto As Integer
        Dim caracter As Integer
        Dim textoCorrecto As Boolean

        caracter = 0
        tamanioTexto = texto.Length
        textoCorrecto = True

        If texto <> "" Then
            While (caracter < tamanioTexto)
                If (IsNumeric(texto(caracter)) Or Char.IsControl(texto(caracter)) Or Char.IsPunctuation(texto(caracter))) Then
                    textoCorrecto = False
                    caracter = tamanioTexto
                End If
                caracter = caracter + 1
            End While
        Else
            textoCorrecto = False
        End If

        controlarLetras = textoCorrecto
    End Function
    '-------------------------------------------------------------------------------------------------------------
    'Permite buscar un archivo de imagen que será la imagen ilustrativa del producto
    'Parámetros
    'dialogo-Tipo: FileDialog-Es el objeto que permite se abra la caja de diálogo para elegir la imagen
    'cajaFoto-Tipo: PicturBox-Es el picture box donde irá la foto para que sea observada
    'etiquetaRuta-Tipo: Label-La etiqueta donde se almacenará la ruta del archivo para posteriormente almacenarlo
    '--------------------------------------------------------------------------------------------------------------
    Private Sub buscarFoto(ByRef dialogo As FileDialog, ByRef cajaFoto As PictureBox, ByRef etiquetaRuta As Label)

        Try
            dialogo.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"
            dialogo.InitialDirectory = "C:\Users"
            If dialogo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                cajaFoto.Image = Image.FromFile(dialogo.FileName)
                etiquetaRuta.Text = dialogo.FileName


            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical + vbOKOnly, "Error Al Cargar La Imagen")
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------------
    'Permite obtener el nombre del archivo de imagen mediante la ruta
    'Parámetros:
    'ruta-Tipo: String-Representa el nombre de la ruta donde está guardado el archivo
    'Retorno: Retorna un string que representa el nombre del archivo imagen y, en caso de no existir la ruta, retorna
    'un string vacío
    '--------------------------------------------------------------------------------------------------------------------
    Function obtenerNombreImagen(ByVal ruta As String) As String
        Dim caracterAnalizado As Long
        Dim nombreArchivo As String
        Dim listo As Boolean
        Dim nombreCorrecto As String

        If ruta <> "" Then
            caracterAnalizado = ruta.LongCount - 1
            nombreArchivo = ""
            listo = False
            nombreCorrecto = ""

            'obtengo todos los caracteres del nombre hasta encontrar "\"
            While caracterAnalizado >= 0 And listo = False
                If ruta(caracterAnalizado) = "\" Then
                    listo = True
                Else
                    nombreArchivo = nombreArchivo + ruta(caracterAnalizado)
                End If
                caracterAnalizado = caracterAnalizado - 1
            End While
            nombreArchivo = Trim(nombreArchivo)
            caracterAnalizado = nombreArchivo.LongCount - 1
            'invierto el string del nombre del archivo para que sea correcto
            While (caracterAnalizado >= 0)
                nombreCorrecto = nombreCorrecto + nombreArchivo(caracterAnalizado)
                caracterAnalizado = caracterAnalizado - 1
            End While
            obtenerNombreImagen = Trim(nombreCorrecto)
        Else
            MsgBox("Por favor, seleccione una foto", vbExclamation + vbOKOnly, "Error al determinar el nombre de la foto")
            obtenerNombreImagen = ""
        End If

    End Function
    '-----------------------------------------------------------------------------------------------
    'Permite eliminar un archivo de imagen en una carpeta
    'Parámetros:
    'nombreArchivo-Tipo: String-Representa el nombre del archivo que se va a eliminar
    'Nota: el texto "\Fotos\" indica la subcarpeta donde se encuentra el archivo a borrar. Modificar
    'si la subcarpeta donde se guardan las imagenes tiene otro nombre
    '-----------------------------------------------------------------------------------------------
    Private Sub eliminarImagenCarpeta(ByRef nombreArchivo As String)
        Dim imagenABorrar As String
        Dim cadena As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6)

        imagenABorrar = cadena + "\Fotos\" + nombreArchivo
        If System.IO.File.Exists(imagenABorrar) = True Then
            System.IO.File.Delete(imagenABorrar)
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------
    'Permite deshabilitar objetos group box para que ciertos perfiles no accedan a determinadas funciones
    'Parámetros:
    'gruposCaja-Tipo: List of GroupBox-Representa el conjunto de group box que se desactivarán
    '-------------------------------------------------------------------------------------------------
    Public Sub adaptarGroupBox(ByRef gruposCaja As List(Of GroupBox))
        Dim cantidadGrupos As Integer
        Dim grupoAnalizado As Integer
        cantidadGrupos = gruposCaja.Count
        grupoAnalizado = 0
        While grupoAnalizado < cantidadGrupos
            gruposCaja(grupoAnalizado).Enabled = False
            grupoAnalizado = grupoAnalizado + 1
        End While

    End Sub

    
    '--------------------------------------------------------------------------------------------------------
    'Permite seleccionar una de las opciones de los tab control de los formularios. Se usará para que, al
    'presionar sobre la barra de opciones, pueda dirigirse a la opción del tab control correspondiente
    'Parámetros:
    'control-Tipo: TabControl-Representa el tab control cuyas tab pages se quiere seleccionar
    'elemento-tipo: Integer-Representa la tab page que se seleccionará
    '--------------------------------------------------------------------------------------------------------
    Public Sub seleccionarTabControl(ByRef control As TabControl, ByVal elemento As Byte, ByRef ventanaInicio As Form, ByRef ventanaDestino As Form)
        If elemento >= 1 And elemento <= control.TabCount Then
            control.SelectedIndex = elemento - 1
            moverseEntreVentana(ventanaInicio, ventanaDestino)

        End If
    End Sub
    '-----------------------------------------------------------------------------------------------
    'Permite preguntar al usuario si desea salir del programa
    'Retorno: Retorna True en caso de una respuesta afirmativa y retorna False en caso contrario
    '-----------------------------------------------------------------------------------------------
    Public Function consultarSalida() As Boolean
        Dim respuesta As Byte
        respuesta = MsgBox("¿Seguo Desea Salir De La Aplicacion?", vbYesNo + vbDefaultButton2, "Salir De La Aplicación")
        If respuesta = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
