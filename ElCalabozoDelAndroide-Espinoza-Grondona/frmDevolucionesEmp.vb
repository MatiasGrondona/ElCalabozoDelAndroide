Public Class frmDevolucionesEmp

    Private Sub frmDevolucionesEmp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModGlobal.getCerrarPorX() Then
            End
        End If
    End Sub

    Private Sub frmDevolucionesEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnAnteriorDetallesDevEmp.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        Me.btnAnteriorVentasDevEmp.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        ModGlobal.setCerrarPorX(True)
    End Sub

    Private Sub btnVolverDevEmp_Click(sender As Object, e As EventArgs) Handles btnVolverDevEmp.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmVentanaInicialAdm)
    End Sub

    Private Sub grbDevolucionesEmp_Enter(sender As Object, e As EventArgs) Handles grbDevolucionesEmp.Enter

    End Sub
End Class