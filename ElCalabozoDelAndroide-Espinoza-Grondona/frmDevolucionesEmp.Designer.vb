<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucionesEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionesEmp))
        Me.grbDevolucionesEmp = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDevolverDev = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbFiltrarDev = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.lblFechaFinDev = New System.Windows.Forms.Label()
        Me.lblFechaIniDev = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.grbDetallesVentaAdm = New System.Windows.Forms.GroupBox()
        Me.btnAnteriorDetallesDevEmp = New System.Windows.Forms.Button()
        Me.btnSiguienteDetallesDevEmp = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.grbListaVentasAdm = New System.Windows.Forms.GroupBox()
        Me.btnAnteriorVentasDevEmp = New System.Windows.Forms.Button()
        Me.btnSiguienteVentasDevEmp = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnVolverDevEmp = New System.Windows.Forms.Button()
        Me.grbDevolucionesEmp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltrarDev.SuspendLayout()
        Me.grbDetallesVentaAdm.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbListaVentasAdm.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbDevolucionesEmp
        '
        Me.grbDevolucionesEmp.BackColor = System.Drawing.Color.DarkGray
        Me.grbDevolucionesEmp.Controls.Add(Me.GroupBox1)
        Me.grbDevolucionesEmp.Controls.Add(Me.grbFiltrarDev)
        Me.grbDevolucionesEmp.Controls.Add(Me.grbDetallesVentaAdm)
        Me.grbDevolucionesEmp.Controls.Add(Me.grbListaVentasAdm)
        Me.grbDevolucionesEmp.Location = New System.Drawing.Point(12, 42)
        Me.grbDevolucionesEmp.Name = "grbDevolucionesEmp"
        Me.grbDevolucionesEmp.Size = New System.Drawing.Size(1060, 537)
        Me.grbDevolucionesEmp.TabIndex = 0
        Me.grbDevolucionesEmp.TabStop = False
        Me.grbDevolucionesEmp.Text = "Devolución De Ventas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnDevolverDev)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(659, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 313)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Devolución"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "aquí va el codigo de venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Código Venta Y Detalle"
        '
        'btnDevolverDev
        '
        Me.btnDevolverDev.Location = New System.Drawing.Point(104, 262)
        Me.btnDevolverDev.Name = "btnDevolverDev"
        Me.btnDevolverDev.Size = New System.Drawing.Size(151, 38)
        Me.btnDevolverDev.TabIndex = 17
        Me.btnDevolverDev.Text = "Devolver"
        Me.btnDevolverDev.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(47, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Aquí mostrará el monto devuelto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Monto A Devolver"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(10, 127)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDown1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cantidad Devuelta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 45)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Sólo Categoría/Subcategoria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aquí va el nombre del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'grbFiltrarDev
        '
        Me.grbFiltrarDev.BackColor = System.Drawing.Color.CadetBlue
        Me.grbFiltrarDev.Controls.Add(Me.Button3)
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltrar)
        Me.grbFiltrarDev.Controls.Add(Me.lblFechaFinDev)
        Me.grbFiltrarDev.Controls.Add(Me.lblFechaIniDev)
        Me.grbFiltrarDev.Controls.Add(Me.DateTimePicker2)
        Me.grbFiltrarDev.Controls.Add(Me.DateTimePicker1)
        Me.grbFiltrarDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltrarDev.Location = New System.Drawing.Point(704, 19)
        Me.grbFiltrarDev.Name = "grbFiltrarDev"
        Me.grbFiltrarDev.Size = New System.Drawing.Size(311, 181)
        Me.grbFiltrarDev.TabIndex = 6
        Me.grbFiltrarDev.TabStop = False
        Me.grbFiltrarDev.Text = "Opciones De Filtrado"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(650, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 45)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Sólo Categoría/Subcategoria"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(110, 141)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 35)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'lblFechaFinDev
        '
        Me.lblFechaFinDev.AutoSize = True
        Me.lblFechaFinDev.Location = New System.Drawing.Point(126, 83)
        Me.lblFechaFinDev.Name = "lblFechaFinDev"
        Me.lblFechaFinDev.Size = New System.Drawing.Size(80, 20)
        Me.lblFechaFinDev.TabIndex = 4
        Me.lblFechaFinDev.Text = "Fecha Fin"
        '
        'lblFechaIniDev
        '
        Me.lblFechaIniDev.AutoSize = True
        Me.lblFechaIniDev.Location = New System.Drawing.Point(115, 16)
        Me.lblFechaIniDev.Name = "lblFechaIniDev"
        Me.lblFechaIniDev.Size = New System.Drawing.Size(95, 20)
        Me.lblFechaIniDev.TabIndex = 3
        Me.lblFechaIniDev.Text = "Fecha Inicio"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 106)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(289, 26)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(289, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'grbDetallesVentaAdm
        '
        Me.grbDetallesVentaAdm.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.grbDetallesVentaAdm.Controls.Add(Me.btnAnteriorDetallesDevEmp)
        Me.grbDetallesVentaAdm.Controls.Add(Me.btnSiguienteDetallesDevEmp)
        Me.grbDetallesVentaAdm.Controls.Add(Me.DataGridView2)
        Me.grbDetallesVentaAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDetallesVentaAdm.Location = New System.Drawing.Point(16, 264)
        Me.grbDetallesVentaAdm.Name = "grbDetallesVentaAdm"
        Me.grbDetallesVentaAdm.Size = New System.Drawing.Size(621, 187)
        Me.grbDetallesVentaAdm.TabIndex = 5
        Me.grbDetallesVentaAdm.TabStop = False
        Me.grbDetallesVentaAdm.Text = "Detalles Venta Seleccionada"
        '
        'btnAnteriorDetallesDevEmp
        '
        Me.btnAnteriorDetallesDevEmp.Image = CType(resources.GetObject("btnAnteriorDetallesDevEmp.Image"), System.Drawing.Image)
        Me.btnAnteriorDetallesDevEmp.Location = New System.Drawing.Point(496, 109)
        Me.btnAnteriorDetallesDevEmp.Name = "btnAnteriorDetallesDevEmp"
        Me.btnAnteriorDetallesDevEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnAnteriorDetallesDevEmp.TabIndex = 5
        Me.btnAnteriorDetallesDevEmp.UseVisualStyleBackColor = True
        '
        'btnSiguienteDetallesDevEmp
        '
        Me.btnSiguienteDetallesDevEmp.Image = CType(resources.GetObject("btnSiguienteDetallesDevEmp.Image"), System.Drawing.Image)
        Me.btnSiguienteDetallesDevEmp.Location = New System.Drawing.Point(496, 31)
        Me.btnSiguienteDetallesDevEmp.Name = "btnSiguienteDetallesDevEmp"
        Me.btnSiguienteDetallesDevEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnSiguienteDetallesDevEmp.TabIndex = 4
        Me.btnSiguienteDetallesDevEmp.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(21, 31)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(448, 150)
        Me.DataGridView2.TabIndex = 1
        '
        'grbListaVentasAdm
        '
        Me.grbListaVentasAdm.BackColor = System.Drawing.Color.Aquamarine
        Me.grbListaVentasAdm.Controls.Add(Me.btnAnteriorVentasDevEmp)
        Me.grbListaVentasAdm.Controls.Add(Me.btnSiguienteVentasDevEmp)
        Me.grbListaVentasAdm.Controls.Add(Me.DataGridView1)
        Me.grbListaVentasAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbListaVentasAdm.Location = New System.Drawing.Point(16, 48)
        Me.grbListaVentasAdm.Name = "grbListaVentasAdm"
        Me.grbListaVentasAdm.Size = New System.Drawing.Size(621, 187)
        Me.grbListaVentasAdm.TabIndex = 4
        Me.grbListaVentasAdm.TabStop = False
        Me.grbListaVentasAdm.Text = "Lista De Ventas"
        '
        'btnAnteriorVentasDevEmp
        '
        Me.btnAnteriorVentasDevEmp.Image = CType(resources.GetObject("btnAnteriorVentasDevEmp.Image"), System.Drawing.Image)
        Me.btnAnteriorVentasDevEmp.Location = New System.Drawing.Point(496, 104)
        Me.btnAnteriorVentasDevEmp.Name = "btnAnteriorVentasDevEmp"
        Me.btnAnteriorVentasDevEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnAnteriorVentasDevEmp.TabIndex = 3
        Me.btnAnteriorVentasDevEmp.UseVisualStyleBackColor = True
        '
        'btnSiguienteVentasDevEmp
        '
        Me.btnSiguienteVentasDevEmp.Image = CType(resources.GetObject("btnSiguienteVentasDevEmp.Image"), System.Drawing.Image)
        Me.btnSiguienteVentasDevEmp.Location = New System.Drawing.Point(496, 31)
        Me.btnSiguienteVentasDevEmp.Name = "btnSiguienteVentasDevEmp"
        Me.btnSiguienteVentasDevEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnSiguienteVentasDevEmp.TabIndex = 2
        Me.btnSiguienteVentasDevEmp.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(448, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'btnVolverDevEmp
        '
        Me.btnVolverDevEmp.Location = New System.Drawing.Point(985, 3)
        Me.btnVolverDevEmp.Name = "btnVolverDevEmp"
        Me.btnVolverDevEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverDevEmp.TabIndex = 1
        Me.btnVolverDevEmp.Text = "Volver"
        Me.btnVolverDevEmp.UseVisualStyleBackColor = True
        '
        'frmDevolucionesEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 587)
        Me.Controls.Add(Me.btnVolverDevEmp)
        Me.Controls.Add(Me.grbDevolucionesEmp)
        Me.Name = "frmDevolucionesEmp"
        Me.Text = "Devoluciones"
        Me.grbDevolucionesEmp.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltrarDev.ResumeLayout(False)
        Me.grbFiltrarDev.PerformLayout()
        Me.grbDetallesVentaAdm.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbListaVentasAdm.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDevolucionesEmp As System.Windows.Forms.GroupBox
    Friend WithEvents grbDetallesVentaAdm As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnteriorDetallesDevEmp As System.Windows.Forms.Button
    Friend WithEvents btnSiguienteDetallesDevEmp As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents grbListaVentasAdm As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnteriorVentasDevEmp As System.Windows.Forms.Button
    Friend WithEvents btnSiguienteVentasDevEmp As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDevolverDev As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grbFiltrarDev As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents lblFechaFinDev As System.Windows.Forms.Label
    Friend WithEvents lblFechaIniDev As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnVolverDevEmp As System.Windows.Forms.Button
End Class
