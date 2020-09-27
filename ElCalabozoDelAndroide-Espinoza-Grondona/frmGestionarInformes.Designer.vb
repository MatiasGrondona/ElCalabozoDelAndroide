<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarInformesAdm
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
        Me.rtvInformes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rtvInformes
        '
        Me.rtvInformes.Location = New System.Drawing.Point(12, 22)
        Me.rtvInformes.Name = "rtvInformes"
        Me.rtvInformes.Size = New System.Drawing.Size(771, 246)
        Me.rtvInformes.TabIndex = 0
        '
        'frmGestionarInformesAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 370)
        Me.Controls.Add(Me.rtvInformes)
        Me.Name = "frmGestionarInformesAdm"
        Me.Text = "Informes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtvInformes As Microsoft.Reporting.WinForms.ReportViewer
End Class
