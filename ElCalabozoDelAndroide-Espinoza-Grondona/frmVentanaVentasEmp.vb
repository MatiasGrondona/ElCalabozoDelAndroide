Public Class frmVentanaVentasEmp

    Private Sub btnAntProdEmp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmVentanaVentasEmp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ModGlobal.getCerrarPorX() Then
            End
        End If

    End Sub

    Private Sub btnVolverIniEmp_Click(sender As Object, e As EventArgs) Handles btnVolverIniEmp.Click
        ModGlobal.setCerrarPorX(False)
        ModGlobal.moverseEntreVentana(Me, frmVentanaInicialAdm)
    End Sub

    Private Sub frmVentanaVentasEmp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.btnAntProdEmp.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        ModGlobal.setCerrarPorX(True)
    End Sub
End Class