'Una clase estática usa para "simular" una sesión. Se emplea para guardar, sin realizar ninguna instancia, los datos del
'usuario cuya sesión está iniciada. Esto es sólo un parche, ya que la idea real sería crear algún tipo de conexión
'cliente-servidor que permita mantener los datos del usuario cuya sesión está iniciada similar a la que se hizo en taller 1
'cuando se trabajó con codeigniter.
'Además, se dan algunos métodos necesarios para la recuperación de los datos de la "sesión" iniciada.
Public Class Sesion
    Private Shared idUsuario As Integer
    Private Shared nombreUsu As String
    Private Shared apellidoUsu As String
    Private Shared dni As Integer
    Private Shared perfil As Byte



    Public Shared Function getIdUsuario() As Integer
        Return idUsuario
    End Function

    Public Shared Function getNombreUsu() As String
        Return nombreUsu
    End Function

    Public Shared Function getApellidoUsu() As String
        Return apellidoUsu
    End Function

    Public Shared Function getDniUsuario() As Integer
        Return dni
    End Function

    Public Shared Function getPerfilUsuario() As Byte
        Return perfil
    End Function
    Private Shared Sub setIdUsuario(ByVal id As Integer)
        idUsuario = id
    End Sub

    Private Shared Sub setNombreUsuario(ByVal nombre As String)
        nombreUsu = nombre
    End Sub

    Private Shared Sub setApellidoUsuario(ByVal apellido As String)
        apellidoUsu = apellido
    End Sub

    Private Shared Sub setDniUsuario(ByVal dniUsu As Integer)
        dni = dniUsu
    End Sub

    Private Shared Sub setPerfilUsuario(ByVal perfilUsu As Byte)
        perfil = perfilUsu
    End Sub

    Public Shared Sub establecerValores(ByVal id As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal perfil As Byte)
        setIdUsuario(id)
        setNombreUsuario(nombre)
        setApellidoUsuario(apellido)
        setDniUsuario(dni)
        setPerfilUsuario(perfil)
    End Sub

    Public Shared Function getNombrePerfil() As String
        If getPerfilUsuario() = 1 Then
            Return "Administrador"
        ElseIf getPerfilUsuario() = 2 Then
            Return "Supervisor"
        ElseIf getPerfilUsuario() = 3 Then
            Return "Empleado"
        Else
            Return ""
        End If
    End Function

    Public Sub cerrarSesion()
        establecerValores(0, "", "", 0, 0)
    End Sub
End Class
