Public Class frmGestionarUsuariosAdm


    Private Sub btnUsuRegreso_Click(sender As Object, e As EventArgs) Handles btnUsuRegreso.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmVentanaInicialAdm)
        
    End Sub

    Private Sub frmGestionarUsuariosAdm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModGlobal.getCerrarPorX() Then
            End
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------
    'Permite deshabilitar ciertas opciones de usuarios sólo permitidas a un usuario de perfil administrador
    '----------------------------------------------------------------------------------------------------
    Private Sub habilitarParaNoAdm()
        Dim cajaGrupos As New List(Of GroupBox)
        Dim modificarSoloDatosPropios As Integer

        modificarSoloDatosPropios = 3
        cajaGrupos.Add(Me.grbEmpleados)
        cajaGrupos.Add(Me.grbNuevoUsuario)
        cajaGrupos.Add(Me.grbFiltradoEmpAdm)
        cajaGrupos.Add(Me.grbNuevoEmpAdm)
        cajaGrupos.Add(Me.grbFiltradoEmpNuevoAdm)
        cajaGrupos.Add(Me.grbEmNuevoUsuAdm)
        cajaGrupos.Add(Me.grbModUsuAdm)
        cajaGrupos.Add(Me.grbFiltradoModUsuAdm)
        cajaGrupos.Add(Me.grbUsuModUsuAdm)
        Me.cmbTipoModDatosUsu.Enabled = False
        ModGlobal.adaptarGroupBox(cajaGrupos)
        Me.tbcUsuarios.SelectedIndex = modificarSoloDatosPropios
        'Me.grbEmpleados.Enabled = False
        'Me.grbNuevoUsuario.Enabled = False
        'Me.grbFiltradoEmpAdm.Enabled = False
        'Me.grbNuevoEmpAdm.Enabled = False
        'Me.grbFiltradoEmpNuevoAdm.Enabled = False
        'Me.grbEmNuevoUsuAdm.Enabled = False
        'Me.grbModUsuAdm.Enabled = False
        'Me.grbFiltradoModUsuAdm.Enabled = False
        'Me.grbUsuModUsuAdm.Enabled = False
    End Sub



    Private Sub frmGestionarUsuariosAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModGlobal.setCerrarPorX(True)
        Me.establecerImagenBtn()
        If Sesion.getNombrePerfil() <> "Administrador" Then
            Me.habilitarParaNoAdm()
        End If
    End Sub

    Private Sub establecerImagenBtn()
        Me.btnAntEmp.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        Me.btnAnteNuevoUsu.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        Me.btnAntModUsuAdm.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
    End Sub

    

    Private Sub tbcUsuarios_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tbcUsuarios.Selecting
        If Sesion.getNombrePerfil() <> "Administrador" Then
            e.Cancel = True
            MsgBox("Su perfil sólo le permite modificar sus propios datos", vbOKOnly + vbExclamation, "Operación Inválida")
        End If
    End Sub
End Class