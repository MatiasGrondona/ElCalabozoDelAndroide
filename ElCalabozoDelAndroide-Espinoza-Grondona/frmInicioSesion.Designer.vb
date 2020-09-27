<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioSesion
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
        Me.lblTituloSesion = New System.Windows.Forms.Label()
        Me.grbDatosSesion = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.txbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.grbDatosSesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTituloSesion
        '
        Me.lblTituloSesion.AutoSize = True
        Me.lblTituloSesion.BackColor = System.Drawing.Color.Black
        Me.lblTituloSesion.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloSesion.ForeColor = System.Drawing.Color.Red
        Me.lblTituloSesion.Location = New System.Drawing.Point(132, 20)
        Me.lblTituloSesion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTituloSesion.Name = "lblTituloSesion"
        Me.lblTituloSesion.Size = New System.Drawing.Size(396, 21)
        Me.lblTituloSesion.TabIndex = 0
        Me.lblTituloSesion.Text = "Ingrese Nombre De Usuario y Password"
        '
        'grbDatosSesion
        '
        Me.grbDatosSesion.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.grbDatosSesion.Controls.Add(Me.btnSalir)
        Me.grbDatosSesion.Controls.Add(Me.btnIngresar)
        Me.grbDatosSesion.Controls.Add(Me.txbPassword)
        Me.grbDatosSesion.Controls.Add(Me.txbNombreUsuario)
        Me.grbDatosSesion.Controls.Add(Me.lblPassword)
        Me.grbDatosSesion.Controls.Add(Me.lblNombreUsuario)
        Me.grbDatosSesion.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDatosSesion.Location = New System.Drawing.Point(32, 64)
        Me.grbDatosSesion.Name = "grbDatosSesion"
        Me.grbDatosSesion.Size = New System.Drawing.Size(586, 286)
        Me.grbDatosSesion.TabIndex = 7
        Me.grbDatosSesion.TabStop = False
        Me.grbDatosSesion.Text = "Ingrese Sus Datos Por Favor"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(342, 188)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 41)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(186, 188)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(92, 41)
        Me.btnIngresar.TabIndex = 11
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txbPassword
        '
        Me.txbPassword.Location = New System.Drawing.Point(294, 119)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPassword.Size = New System.Drawing.Size(212, 33)
        Me.txbPassword.TabIndex = 10
        Me.txbPassword.UseSystemPasswordChar = True
        '
        'txbNombreUsuario
        '
        Me.txbNombreUsuario.Location = New System.Drawing.Point(294, 58)
        Me.txbNombreUsuario.Name = "txbNombreUsuario"
        Me.txbNombreUsuario.Size = New System.Drawing.Size(212, 33)
        Me.txbNombreUsuario.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(76, 119)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 25)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(76, 64)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(147, 25)
        Me.lblNombreUsuario.TabIndex = 7
        Me.lblNombreUsuario.Text = "Nombre Usuario"
        '
        'frmInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(653, 362)
        Me.Controls.Add(Me.grbDatosSesion)
        Me.Controls.Add(Me.lblTituloSesion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicioSesion"
        Me.Text = "Inicio De Sesion"
        Me.grbDatosSesion.ResumeLayout(False)
        Me.grbDatosSesion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloSesion As System.Windows.Forms.Label
    Friend WithEvents grbDatosSesion As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txbPassword As System.Windows.Forms.TextBox
    Friend WithEvents txbNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label

End Class
