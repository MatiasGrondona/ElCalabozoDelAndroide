'Formulario para el inicio de sesión de los usuarios
'Imports BusinessLayer
'Imports Entities
Public Class frmInicioSesion
    'Dim negocioUsu As New UsuarioBus
    ' Dim entidadUsu As New Usuario

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Dim perfil As Byte
        Dim nombreUsu As String
        Dim password As String

        'perfil = 1
        nombreUsu = Trim(Me.txbNombreUsuario.Text)
        password = Trim(Me.txbPassword.Text)
        If nombreUsu <> "" And password <> "" Then
            'perfil = negocioUsu.controlarUsuario(Trim(Me.txbNombreUsuario.Text), Trim(Me.txbPassword.Text))
            If nombreUsu = "admin" And password = "1234" Then
                MsgBox("Acceso concedido", vbOKOnly, "Éxito en el acceso")
                Me.limpiarCampos()
                ModGlobal.setCerrarPorX(False)
                'ModGlobal.setIdUsu(1)
                Sesion.establecerValores(1, "Enrique", "Espinoza", 32837262, 1)
                ModGlobal.moverseDesdeVentanaInicial(Me, frmVentanaInicialAdm)
            ElseIf nombreUsu = "empleado" And password = "1234" Then
                MsgBox("Acceso concedido", vbOKOnly, "Éxito en el acceso")
                Me.limpiarCampos()
                ModGlobal.setCerrarPorX(False)
                'ModGlobal.setIdUsu(3)
                Sesion.establecerValores(1, "Enrique", "Espinoza", 32837262, 3)
                ModGlobal.moverseDesdeVentanaInicial(Me, frmVentanaInicialAdm)
            ElseIf nombreUsu = "supervisor" And password = "1234" Then
                MsgBox("Acceso concedido", vbOKOnly, "Éxito en el acceso")
                Me.limpiarCampos()
                Sesion.establecerValores(1, "Enrique", "Espinoza", 32837262, 2)
                ModGlobal.setCerrarPorX(False)
                'ModGlobal.setIdUsu(2)
                ModGlobal.moverseDesdeVentanaInicial(Me, frmVentanaInicialAdm)
            Else
                MsgBox("Usuario y contraseña no válidos", vbOKOnly + vbExclamation, "Error De Ingreso De Datos")
            End If
        Else
            MsgBox("Por favor, coloque el nombre de usuario y contraseña", vbOKOnly + vbExclamation, "Error De Ingreso De Datos")
        End If
        ' If modInicioSesion.controlDatos(Me.getNombreUsuario(), Me.getPassword()) Then
        'Me.cargarVentanaInicial()
        'End If
    End Sub

    Private Sub frmInicioSesion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModGlobal.getCerrarPorX() Then
            End
        End If
    End Sub
    Private Sub limpiarCampos()
        Me.txbNombreUsuario.Text = ""
        Me.txbPassword.Text = ""
    End Sub

    
    Private Sub frmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModGlobal.setCerrarPorX(True)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If ModGlobal.consultarSalida() Then
            End
        End If
    End Sub
End Class
