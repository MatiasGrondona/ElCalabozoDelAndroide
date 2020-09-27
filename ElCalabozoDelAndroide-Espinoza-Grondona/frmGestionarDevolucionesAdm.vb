Public Class frmGestionarDevolucionesAdm


    Private Sub frmGestionarDevolucionesAdm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModGlobal.getCerrarPorX() Then
            End
        End If
    End Sub
    
    
    Private Sub frmGestionarDevolucionesAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModGlobal.setCerrarPorX(True)
    End Sub

    Private Sub btnVolverDevAdm_Click(sender As Object, e As EventArgs) Handles btnVolverDevAdm.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmVentanaInicialAdm)
    End Sub
End Class