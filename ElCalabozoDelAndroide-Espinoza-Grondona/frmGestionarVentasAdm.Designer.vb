<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarVentasAdm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.tbcVentasAdm = New System.Windows.Forms.TabControl()
        Me.tpgListaVentasAdm = New System.Windows.Forms.TabPage()
        Me.tpgEstadisticasAdm = New System.Windows.Forms.TabPage()
        Me.grbListaVentasAdm = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grbDetallesVentaAdm = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.chtVentasAdm = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnMasVendidoAdm = New System.Windows.Forms.Button()
        Me.btnVentasEmpAdm = New System.Windows.Forms.Button()
        Me.btnVentasCatAdm = New System.Windows.Forms.Button()
        Me.btnVentasSubAdm = New System.Windows.Forms.Button()
        Me.btnVentasCatSubAdm = New System.Windows.Forms.Button()
        Me.btnVolverVentasAdm = New System.Windows.Forms.Button()
        Me.btnSiguienteVentasAdm = New System.Windows.Forms.Button()
        Me.btnAnteriorVentasAdm = New System.Windows.Forms.Button()
        Me.btnAnteriorDetallesAdm = New System.Windows.Forms.Button()
        Me.btnSiguienteDetallesAdm = New System.Windows.Forms.Button()
        Me.grbFiltrarDev = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnFiltrarSoloDni = New System.Windows.Forms.Button()
        Me.btnFiltrarTodo = New System.Windows.Forms.Button()
        Me.lblFechaFinDev = New System.Windows.Forms.Label()
        Me.lblFechaIniDev = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblApellidoVentasAdm = New System.Windows.Forms.Label()
        Me.txbApellidosVentasAdm = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblDniVentasAdm = New System.Windows.Forms.Label()
        Me.btnFiltrarNombre = New System.Windows.Forms.Button()
        Me.btnFiltrarFecha = New System.Windows.Forms.Button()
        Me.tbcVentasAdm.SuspendLayout()
        Me.tpgListaVentasAdm.SuspendLayout()
        Me.tpgEstadisticasAdm.SuspendLayout()
        Me.grbListaVentasAdm.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDetallesVentaAdm.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtVentasAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltrarDev.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcVentasAdm
        '
        Me.tbcVentasAdm.Controls.Add(Me.tpgListaVentasAdm)
        Me.tbcVentasAdm.Controls.Add(Me.tpgEstadisticasAdm)
        Me.tbcVentasAdm.Location = New System.Drawing.Point(12, 55)
        Me.tbcVentasAdm.Name = "tbcVentasAdm"
        Me.tbcVentasAdm.SelectedIndex = 0
        Me.tbcVentasAdm.Size = New System.Drawing.Size(1166, 477)
        Me.tbcVentasAdm.TabIndex = 0
        '
        'tpgListaVentasAdm
        '
        Me.tpgListaVentasAdm.Controls.Add(Me.grbFiltrarDev)
        Me.tpgListaVentasAdm.Controls.Add(Me.grbDetallesVentaAdm)
        Me.tpgListaVentasAdm.Controls.Add(Me.grbListaVentasAdm)
        Me.tpgListaVentasAdm.Location = New System.Drawing.Point(4, 22)
        Me.tpgListaVentasAdm.Name = "tpgListaVentasAdm"
        Me.tpgListaVentasAdm.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgListaVentasAdm.Size = New System.Drawing.Size(1158, 451)
        Me.tpgListaVentasAdm.TabIndex = 0
        Me.tpgListaVentasAdm.Text = "Lista De Ventas"
        Me.tpgListaVentasAdm.UseVisualStyleBackColor = True
        '
        'tpgEstadisticasAdm
        '
        Me.tpgEstadisticasAdm.Controls.Add(Me.btnVentasCatSubAdm)
        Me.tpgEstadisticasAdm.Controls.Add(Me.btnVentasSubAdm)
        Me.tpgEstadisticasAdm.Controls.Add(Me.btnVentasCatAdm)
        Me.tpgEstadisticasAdm.Controls.Add(Me.btnVentasEmpAdm)
        Me.tpgEstadisticasAdm.Controls.Add(Me.btnMasVendidoAdm)
        Me.tpgEstadisticasAdm.Controls.Add(Me.chtVentasAdm)
        Me.tpgEstadisticasAdm.Location = New System.Drawing.Point(4, 22)
        Me.tpgEstadisticasAdm.Name = "tpgEstadisticasAdm"
        Me.tpgEstadisticasAdm.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgEstadisticasAdm.Size = New System.Drawing.Size(1158, 451)
        Me.tpgEstadisticasAdm.TabIndex = 1
        Me.tpgEstadisticasAdm.Text = "Estadística Ventas"
        Me.tpgEstadisticasAdm.UseVisualStyleBackColor = True
        '
        'grbListaVentasAdm
        '
        Me.grbListaVentasAdm.Controls.Add(Me.btnAnteriorVentasAdm)
        Me.grbListaVentasAdm.Controls.Add(Me.btnSiguienteVentasAdm)
        Me.grbListaVentasAdm.Controls.Add(Me.DataGridView1)
        Me.grbListaVentasAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbListaVentasAdm.Location = New System.Drawing.Point(15, 65)
        Me.grbListaVentasAdm.Name = "grbListaVentasAdm"
        Me.grbListaVentasAdm.Size = New System.Drawing.Size(815, 187)
        Me.grbListaVentasAdm.TabIndex = 2
        Me.grbListaVentasAdm.TabStop = False
        Me.grbListaVentasAdm.Text = "Lista De Ventas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(604, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'grbDetallesVentaAdm
        '
        Me.grbDetallesVentaAdm.Controls.Add(Me.btnAnteriorDetallesAdm)
        Me.grbDetallesVentaAdm.Controls.Add(Me.btnSiguienteDetallesAdm)
        Me.grbDetallesVentaAdm.Controls.Add(Me.DataGridView2)
        Me.grbDetallesVentaAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDetallesVentaAdm.Location = New System.Drawing.Point(15, 258)
        Me.grbDetallesVentaAdm.Name = "grbDetallesVentaAdm"
        Me.grbDetallesVentaAdm.Size = New System.Drawing.Size(815, 187)
        Me.grbDetallesVentaAdm.TabIndex = 3
        Me.grbDetallesVentaAdm.TabStop = False
        Me.grbDetallesVentaAdm.Text = "Detalles Venta Seleccionada"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(21, 31)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(604, 150)
        Me.DataGridView2.TabIndex = 1
        '
        'chtVentasAdm
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtVentasAdm.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtVentasAdm.Legends.Add(Legend1)
        Me.chtVentasAdm.Location = New System.Drawing.Point(20, 15)
        Me.chtVentasAdm.Name = "chtVentasAdm"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtVentasAdm.Series.Add(Series1)
        Me.chtVentasAdm.Size = New System.Drawing.Size(1060, 250)
        Me.chtVentasAdm.TabIndex = 0
        Me.chtVentasAdm.Text = "Chart1"
        '
        'btnMasVendidoAdm
        '
        Me.btnMasVendidoAdm.Location = New System.Drawing.Point(131, 301)
        Me.btnMasVendidoAdm.Name = "btnMasVendidoAdm"
        Me.btnMasVendidoAdm.Size = New System.Drawing.Size(75, 48)
        Me.btnMasVendidoAdm.TabIndex = 1
        Me.btnMasVendidoAdm.Text = "Más Vendidos Por Mes"
        Me.btnMasVendidoAdm.UseVisualStyleBackColor = True
        '
        'btnVentasEmpAdm
        '
        Me.btnVentasEmpAdm.Location = New System.Drawing.Point(243, 301)
        Me.btnVentasEmpAdm.Name = "btnVentasEmpAdm"
        Me.btnVentasEmpAdm.Size = New System.Drawing.Size(75, 48)
        Me.btnVentasEmpAdm.TabIndex = 2
        Me.btnVentasEmpAdm.Text = "Ventas Por Empleado"
        Me.btnVentasEmpAdm.UseVisualStyleBackColor = True
        '
        'btnVentasCatAdm
        '
        Me.btnVentasCatAdm.Location = New System.Drawing.Point(357, 301)
        Me.btnVentasCatAdm.Name = "btnVentasCatAdm"
        Me.btnVentasCatAdm.Size = New System.Drawing.Size(75, 48)
        Me.btnVentasCatAdm.TabIndex = 3
        Me.btnVentasCatAdm.Text = "Ventas Por Categoría"
        Me.btnVentasCatAdm.UseVisualStyleBackColor = True
        '
        'btnVentasSubAdm
        '
        Me.btnVentasSubAdm.Location = New System.Drawing.Point(469, 301)
        Me.btnVentasSubAdm.Name = "btnVentasSubAdm"
        Me.btnVentasSubAdm.Size = New System.Drawing.Size(88, 48)
        Me.btnVentasSubAdm.TabIndex = 4
        Me.btnVentasSubAdm.Text = "Ventas Por Subcategoría"
        Me.btnVentasSubAdm.UseVisualStyleBackColor = True
        '
        'btnVentasCatSubAdm
        '
        Me.btnVentasCatSubAdm.Location = New System.Drawing.Point(573, 301)
        Me.btnVentasCatSubAdm.Name = "btnVentasCatSubAdm"
        Me.btnVentasCatSubAdm.Size = New System.Drawing.Size(137, 48)
        Me.btnVentasCatSubAdm.TabIndex = 5
        Me.btnVentasCatSubAdm.Text = "Ventas Por Categoria/Subcategoría"
        Me.btnVentasCatSubAdm.UseVisualStyleBackColor = True
        '
        'btnVolverVentasAdm
        '
        Me.btnVolverVentasAdm.Location = New System.Drawing.Point(1026, 12)
        Me.btnVolverVentasAdm.Name = "btnVolverVentasAdm"
        Me.btnVolverVentasAdm.Size = New System.Drawing.Size(137, 37)
        Me.btnVolverVentasAdm.TabIndex = 6
        Me.btnVolverVentasAdm.Text = "Volver Inicio"
        Me.btnVolverVentasAdm.UseVisualStyleBackColor = True
        '
        'btnSiguienteVentasAdm
        '
        Me.btnSiguienteVentasAdm.Location = New System.Drawing.Point(682, 52)
        Me.btnSiguienteVentasAdm.Name = "btnSiguienteVentasAdm"
        Me.btnSiguienteVentasAdm.Size = New System.Drawing.Size(92, 28)
        Me.btnSiguienteVentasAdm.TabIndex = 2
        Me.btnSiguienteVentasAdm.Text = "Siguiente"
        Me.btnSiguienteVentasAdm.UseVisualStyleBackColor = True
        '
        'btnAnteriorVentasAdm
        '
        Me.btnAnteriorVentasAdm.Location = New System.Drawing.Point(682, 106)
        Me.btnAnteriorVentasAdm.Name = "btnAnteriorVentasAdm"
        Me.btnAnteriorVentasAdm.Size = New System.Drawing.Size(75, 30)
        Me.btnAnteriorVentasAdm.TabIndex = 3
        Me.btnAnteriorVentasAdm.Text = "Anterior"
        Me.btnAnteriorVentasAdm.UseVisualStyleBackColor = True
        '
        'btnAnteriorDetallesAdm
        '
        Me.btnAnteriorDetallesAdm.Location = New System.Drawing.Point(652, 114)
        Me.btnAnteriorDetallesAdm.Name = "btnAnteriorDetallesAdm"
        Me.btnAnteriorDetallesAdm.Size = New System.Drawing.Size(75, 26)
        Me.btnAnteriorDetallesAdm.TabIndex = 5
        Me.btnAnteriorDetallesAdm.Text = "Anterior"
        Me.btnAnteriorDetallesAdm.UseVisualStyleBackColor = True
        '
        'btnSiguienteDetallesAdm
        '
        Me.btnSiguienteDetallesAdm.Location = New System.Drawing.Point(652, 60)
        Me.btnSiguienteDetallesAdm.Name = "btnSiguienteDetallesAdm"
        Me.btnSiguienteDetallesAdm.Size = New System.Drawing.Size(84, 27)
        Me.btnSiguienteDetallesAdm.TabIndex = 4
        Me.btnSiguienteDetallesAdm.Text = "Siguiente"
        Me.btnSiguienteDetallesAdm.UseVisualStyleBackColor = True
        '
        'grbFiltrarDev
        '
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltrarFecha)
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltrarNombre)
        Me.grbFiltrarDev.Controls.Add(Me.lblDniVentasAdm)
        Me.grbFiltrarDev.Controls.Add(Me.TextBox2)
        Me.grbFiltrarDev.Controls.Add(Me.txbApellidosVentasAdm)
        Me.grbFiltrarDev.Controls.Add(Me.lblApellidoVentasAdm)
        Me.grbFiltrarDev.Controls.Add(Me.Button3)
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltrarSoloDni)
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltrarTodo)
        Me.grbFiltrarDev.Controls.Add(Me.lblFechaFinDev)
        Me.grbFiltrarDev.Controls.Add(Me.lblFechaIniDev)
        Me.grbFiltrarDev.Controls.Add(Me.DateTimePicker2)
        Me.grbFiltrarDev.Controls.Add(Me.DateTimePicker1)
        Me.grbFiltrarDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltrarDev.Location = New System.Drawing.Point(836, 13)
        Me.grbFiltrarDev.Name = "grbFiltrarDev"
        Me.grbFiltrarDev.Size = New System.Drawing.Size(311, 426)
        Me.grbFiltrarDev.TabIndex = 4
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
        'btnFiltrarSoloDni
        '
        Me.btnFiltrarSoloDni.Location = New System.Drawing.Point(118, 307)
        Me.btnFiltrarSoloDni.Name = "btnFiltrarSoloDni"
        Me.btnFiltrarSoloDni.Size = New System.Drawing.Size(75, 58)
        Me.btnFiltrarSoloDni.TabIndex = 11
        Me.btnFiltrarSoloDni.Text = "Filtrar Por Dni"
        Me.btnFiltrarSoloDni.UseVisualStyleBackColor = True
        '
        'btnFiltrarTodo
        '
        Me.btnFiltrarTodo.Location = New System.Drawing.Point(104, 371)
        Me.btnFiltrarTodo.Name = "btnFiltrarTodo"
        Me.btnFiltrarTodo.Size = New System.Drawing.Size(75, 35)
        Me.btnFiltrarTodo.TabIndex = 6
        Me.btnFiltrarTodo.Text = "Filtrar"
        Me.btnFiltrarTodo.UseVisualStyleBackColor = True
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
        'lblApellidoVentasAdm
        '
        Me.lblApellidoVentasAdm.AutoSize = True
        Me.lblApellidoVentasAdm.Location = New System.Drawing.Point(115, 163)
        Me.lblApellidoVentasAdm.Name = "lblApellidoVentasAdm"
        Me.lblApellidoVentasAdm.Size = New System.Drawing.Size(141, 20)
        Me.lblApellidoVentasAdm.TabIndex = 13
        Me.lblApellidoVentasAdm.Text = "Apellido Empleado"
        '
        'txbApellidosVentasAdm
        '
        Me.txbApellidosVentasAdm.Location = New System.Drawing.Point(6, 186)
        Me.txbApellidosVentasAdm.Name = "txbApellidosVentasAdm"
        Me.txbApellidosVentasAdm.Size = New System.Drawing.Size(289, 26)
        Me.txbApellidosVentasAdm.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 249)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(289, 26)
        Me.TextBox2.TabIndex = 15
        '
        'lblDniVentasAdm
        '
        Me.lblDniVentasAdm.AutoSize = True
        Me.lblDniVentasAdm.Location = New System.Drawing.Point(106, 226)
        Me.lblDniVentasAdm.Name = "lblDniVentasAdm"
        Me.lblDniVentasAdm.Size = New System.Drawing.Size(109, 20)
        Me.lblDniVentasAdm.TabIndex = 16
        Me.lblDniVentasAdm.Text = "Dni Empleado"
        '
        'btnFiltrarNombre
        '
        Me.btnFiltrarNombre.Location = New System.Drawing.Point(199, 307)
        Me.btnFiltrarNombre.Name = "btnFiltrarNombre"
        Me.btnFiltrarNombre.Size = New System.Drawing.Size(96, 60)
        Me.btnFiltrarNombre.TabIndex = 17
        Me.btnFiltrarNombre.Text = "Filtrar Por Nombre"
        Me.btnFiltrarNombre.UseVisualStyleBackColor = True
        '
        'btnFiltrarFecha
        '
        Me.btnFiltrarFecha.Location = New System.Drawing.Point(10, 307)
        Me.btnFiltrarFecha.Name = "btnFiltrarFecha"
        Me.btnFiltrarFecha.Size = New System.Drawing.Size(102, 60)
        Me.btnFiltrarFecha.TabIndex = 18
        Me.btnFiltrarFecha.Text = "Filtrar Por Fecha"
        Me.btnFiltrarFecha.UseVisualStyleBackColor = True
        '
        'frmGestionarVentasAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 544)
        Me.Controls.Add(Me.btnVolverVentasAdm)
        Me.Controls.Add(Me.tbcVentasAdm)
        Me.Name = "frmGestionarVentasAdm"
        Me.Text = "Ventas Administrador"
        Me.tbcVentasAdm.ResumeLayout(False)
        Me.tpgListaVentasAdm.ResumeLayout(False)
        Me.tpgEstadisticasAdm.ResumeLayout(False)
        Me.grbListaVentasAdm.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDetallesVentaAdm.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtVentasAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltrarDev.ResumeLayout(False)
        Me.grbFiltrarDev.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcVentasAdm As System.Windows.Forms.TabControl
    Friend WithEvents tpgListaVentasAdm As System.Windows.Forms.TabPage
    Friend WithEvents grbDetallesVentaAdm As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnteriorDetallesAdm As System.Windows.Forms.Button
    Friend WithEvents btnSiguienteDetallesAdm As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents grbListaVentasAdm As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnteriorVentasAdm As System.Windows.Forms.Button
    Friend WithEvents btnSiguienteVentasAdm As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tpgEstadisticasAdm As System.Windows.Forms.TabPage
    Friend WithEvents btnVentasCatSubAdm As System.Windows.Forms.Button
    Friend WithEvents btnVentasSubAdm As System.Windows.Forms.Button
    Friend WithEvents btnVentasCatAdm As System.Windows.Forms.Button
    Friend WithEvents btnVentasEmpAdm As System.Windows.Forms.Button
    Friend WithEvents btnMasVendidoAdm As System.Windows.Forms.Button
    Friend WithEvents chtVentasAdm As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnVolverVentasAdm As System.Windows.Forms.Button
    Friend WithEvents grbFiltrarDev As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarSoloDni As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarTodo As System.Windows.Forms.Button
    Friend WithEvents lblFechaFinDev As System.Windows.Forms.Label
    Friend WithEvents lblFechaIniDev As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDniVentasAdm As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txbApellidosVentasAdm As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidoVentasAdm As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarFecha As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarNombre As System.Windows.Forms.Button
End Class
