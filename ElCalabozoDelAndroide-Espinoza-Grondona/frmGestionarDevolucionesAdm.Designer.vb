<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarDevolucionesAdm
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
        Me.grBoxDevolucionesAdm = New System.Windows.Forms.GroupBox()
        Me.btnSiguienteDev = New System.Windows.Forms.Button()
        Me.btnAnteriorDev = New System.Windows.Forms.Button()
        Me.dgvDevAdm = New System.Windows.Forms.DataGridView()
        Me.grbDetallesDevAdm = New System.Windows.Forms.GroupBox()
        Me.dgvDetallesDevAdm = New System.Windows.Forms.DataGridView()
        Me.chtEstadisticasDevAdm = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grbFiltrarDev = New System.Windows.Forms.GroupBox()
        Me.btnFiltradoCatSubDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltradoFechaDevAdm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSubFiltradoDevAdm = New System.Windows.Forms.ComboBox()
        Me.cmbCatFiltradoDevAdm = New System.Windows.Forms.ComboBox()
        Me.btnFiltradoTodoDevAdm = New System.Windows.Forms.Button()
        Me.lblFechaFinDev = New System.Windows.Forms.Label()
        Me.lblFechaIniDev = New System.Windows.Forms.Label()
        Me.dtpFechaFinDevAdm = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicioDevAdm = New System.Windows.Forms.DateTimePicker()
        Me.btnFiltrarCatDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarSubDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarMesDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarAnioDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarCatMesDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarCatAnioDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarSubMesDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarSubAnioDevAdm = New System.Windows.Forms.Button()
        Me.btnFiltrarMotivoDevAdm = New System.Windows.Forms.Button()
        Me.btnVolverDevAdm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grBoxDevolucionesAdm.SuspendLayout()
        CType(Me.dgvDevAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDetallesDevAdm.SuspendLayout()
        CType(Me.dgvDetallesDevAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtEstadisticasDevAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltrarDev.SuspendLayout()
        Me.SuspendLayout()
        '
        'grBoxDevolucionesAdm
        '
        Me.grBoxDevolucionesAdm.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.grBoxDevolucionesAdm.Controls.Add(Me.btnSiguienteDev)
        Me.grBoxDevolucionesAdm.Controls.Add(Me.btnAnteriorDev)
        Me.grBoxDevolucionesAdm.Controls.Add(Me.dgvDevAdm)
        Me.grBoxDevolucionesAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grBoxDevolucionesAdm.Location = New System.Drawing.Point(18, 119)
        Me.grBoxDevolucionesAdm.Name = "grBoxDevolucionesAdm"
        Me.grBoxDevolucionesAdm.Size = New System.Drawing.Size(527, 253)
        Me.grBoxDevolucionesAdm.TabIndex = 0
        Me.grBoxDevolucionesAdm.TabStop = False
        Me.grBoxDevolucionesAdm.Text = "Lista Devoluciones"
        '
        'btnSiguienteDev
        '
        Me.btnSiguienteDev.Location = New System.Drawing.Point(279, 175)
        Me.btnSiguienteDev.Name = "btnSiguienteDev"
        Me.btnSiguienteDev.Size = New System.Drawing.Size(72, 72)
        Me.btnSiguienteDev.TabIndex = 4
        Me.btnSiguienteDev.Text = "Siguiente"
        Me.btnSiguienteDev.UseVisualStyleBackColor = True
        '
        'btnAnteriorDev
        '
        Me.btnAnteriorDev.Location = New System.Drawing.Point(94, 175)
        Me.btnAnteriorDev.Name = "btnAnteriorDev"
        Me.btnAnteriorDev.Size = New System.Drawing.Size(72, 72)
        Me.btnAnteriorDev.TabIndex = 3
        Me.btnAnteriorDev.Text = "Anterior"
        Me.btnAnteriorDev.UseVisualStyleBackColor = True
        '
        'dgvDevAdm
        '
        Me.dgvDevAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevAdm.Location = New System.Drawing.Point(6, 19)
        Me.dgvDevAdm.Name = "dgvDevAdm"
        Me.dgvDevAdm.Size = New System.Drawing.Size(512, 156)
        Me.dgvDevAdm.TabIndex = 0
        '
        'grbDetallesDevAdm
        '
        Me.grbDetallesDevAdm.BackColor = System.Drawing.Color.SteelBlue
        Me.grbDetallesDevAdm.Controls.Add(Me.Button1)
        Me.grbDetallesDevAdm.Controls.Add(Me.Button2)
        Me.grbDetallesDevAdm.Controls.Add(Me.dgvDetallesDevAdm)
        Me.grbDetallesDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDetallesDevAdm.Location = New System.Drawing.Point(18, 378)
        Me.grbDetallesDevAdm.Name = "grbDetallesDevAdm"
        Me.grbDetallesDevAdm.Size = New System.Drawing.Size(521, 249)
        Me.grbDetallesDevAdm.TabIndex = 1
        Me.grbDetallesDevAdm.TabStop = False
        Me.grbDetallesDevAdm.Text = "Detalles Devoluciones"
        '
        'dgvDetallesDevAdm
        '
        Me.dgvDetallesDevAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallesDevAdm.Location = New System.Drawing.Point(6, 19)
        Me.dgvDetallesDevAdm.Name = "dgvDetallesDevAdm"
        Me.dgvDetallesDevAdm.Size = New System.Drawing.Size(506, 132)
        Me.dgvDetallesDevAdm.TabIndex = 0
        '
        'chtEstadisticasDevAdm
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtEstadisticasDevAdm.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtEstadisticasDevAdm.Legends.Add(Legend1)
        Me.chtEstadisticasDevAdm.Location = New System.Drawing.Point(551, 138)
        Me.chtEstadisticasDevAdm.Name = "chtEstadisticasDevAdm"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtEstadisticasDevAdm.Series.Add(Series1)
        Me.chtEstadisticasDevAdm.Size = New System.Drawing.Size(440, 300)
        Me.chtEstadisticasDevAdm.TabIndex = 2
        Me.chtEstadisticasDevAdm.Text = "Chart1"
        '
        'grbFiltrarDev
        '
        Me.grbFiltrarDev.BackColor = System.Drawing.Color.DarkGray
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltradoCatSubDevAdm)
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltradoFechaDevAdm)
        Me.grbFiltrarDev.Controls.Add(Me.Label2)
        Me.grbFiltrarDev.Controls.Add(Me.Label1)
        Me.grbFiltrarDev.Controls.Add(Me.cmbSubFiltradoDevAdm)
        Me.grbFiltrarDev.Controls.Add(Me.cmbCatFiltradoDevAdm)
        Me.grbFiltrarDev.Controls.Add(Me.btnFiltradoTodoDevAdm)
        Me.grbFiltrarDev.Controls.Add(Me.lblFechaFinDev)
        Me.grbFiltrarDev.Controls.Add(Me.lblFechaIniDev)
        Me.grbFiltrarDev.Controls.Add(Me.dtpFechaFinDevAdm)
        Me.grbFiltrarDev.Controls.Add(Me.dtpFechaInicioDevAdm)
        Me.grbFiltrarDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltrarDev.Location = New System.Drawing.Point(24, 12)
        Me.grbFiltrarDev.Name = "grbFiltrarDev"
        Me.grbFiltrarDev.Size = New System.Drawing.Size(831, 101)
        Me.grbFiltrarDev.TabIndex = 3
        Me.grbFiltrarDev.TabStop = False
        Me.grbFiltrarDev.Text = "Opciones De Filtrado"
        '
        'btnFiltradoCatSubDevAdm
        '
        Me.btnFiltradoCatSubDevAdm.Location = New System.Drawing.Point(692, 14)
        Me.btnFiltradoCatSubDevAdm.Name = "btnFiltradoCatSubDevAdm"
        Me.btnFiltradoCatSubDevAdm.Size = New System.Drawing.Size(133, 45)
        Me.btnFiltradoCatSubDevAdm.TabIndex = 12
        Me.btnFiltradoCatSubDevAdm.Text = "Sólo Categoría/Subcategoria"
        Me.btnFiltradoCatSubDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltradoFechaDevAdm
        '
        Me.btnFiltradoFechaDevAdm.Location = New System.Drawing.Point(575, 16)
        Me.btnFiltradoFechaDevAdm.Name = "btnFiltradoFechaDevAdm"
        Me.btnFiltradoFechaDevAdm.Size = New System.Drawing.Size(111, 40)
        Me.btnFiltradoFechaDevAdm.TabIndex = 11
        Me.btnFiltradoFechaDevAdm.Text = "Sólo Fecha"
        Me.btnFiltradoFechaDevAdm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Subcategoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Categoría"
        '
        'cmbSubFiltradoDevAdm
        '
        Me.cmbSubFiltradoDevAdm.FormattingEnabled = True
        Me.cmbSubFiltradoDevAdm.Location = New System.Drawing.Point(409, 66)
        Me.cmbSubFiltradoDevAdm.Name = "cmbSubFiltradoDevAdm"
        Me.cmbSubFiltradoDevAdm.Size = New System.Drawing.Size(160, 26)
        Me.cmbSubFiltradoDevAdm.TabIndex = 8
        '
        'cmbCatFiltradoDevAdm
        '
        Me.cmbCatFiltradoDevAdm.FormattingEnabled = True
        Me.cmbCatFiltradoDevAdm.Location = New System.Drawing.Point(114, 67)
        Me.cmbCatFiltradoDevAdm.Name = "cmbCatFiltradoDevAdm"
        Me.cmbCatFiltradoDevAdm.Size = New System.Drawing.Size(176, 26)
        Me.cmbCatFiltradoDevAdm.TabIndex = 7
        '
        'btnFiltradoTodoDevAdm
        '
        Me.btnFiltradoTodoDevAdm.Location = New System.Drawing.Point(651, 63)
        Me.btnFiltradoTodoDevAdm.Name = "btnFiltradoTodoDevAdm"
        Me.btnFiltradoTodoDevAdm.Size = New System.Drawing.Size(81, 32)
        Me.btnFiltradoTodoDevAdm.TabIndex = 6
        Me.btnFiltradoTodoDevAdm.Text = "Filtrar"
        Me.btnFiltradoTodoDevAdm.UseVisualStyleBackColor = True
        '
        'lblFechaFinDev
        '
        Me.lblFechaFinDev.AutoSize = True
        Me.lblFechaFinDev.Location = New System.Drawing.Point(377, 14)
        Me.lblFechaFinDev.Name = "lblFechaFinDev"
        Me.lblFechaFinDev.Size = New System.Drawing.Size(73, 18)
        Me.lblFechaFinDev.TabIndex = 4
        Me.lblFechaFinDev.Text = "Fecha Fin"
        '
        'lblFechaIniDev
        '
        Me.lblFechaIniDev.AutoSize = True
        Me.lblFechaIniDev.Location = New System.Drawing.Point(148, 11)
        Me.lblFechaIniDev.Name = "lblFechaIniDev"
        Me.lblFechaIniDev.Size = New System.Drawing.Size(87, 18)
        Me.lblFechaIniDev.TabIndex = 3
        Me.lblFechaIniDev.Text = "Fecha Inicio"
        '
        'dtpFechaFinDevAdm
        '
        Me.dtpFechaFinDevAdm.Location = New System.Drawing.Point(283, 32)
        Me.dtpFechaFinDevAdm.Name = "dtpFechaFinDevAdm"
        Me.dtpFechaFinDevAdm.Size = New System.Drawing.Size(286, 24)
        Me.dtpFechaFinDevAdm.TabIndex = 1
        '
        'dtpFechaInicioDevAdm
        '
        Me.dtpFechaInicioDevAdm.Location = New System.Drawing.Point(6, 32)
        Me.dtpFechaInicioDevAdm.Name = "dtpFechaInicioDevAdm"
        Me.dtpFechaInicioDevAdm.Size = New System.Drawing.Size(271, 24)
        Me.dtpFechaInicioDevAdm.TabIndex = 0
        '
        'btnFiltrarCatDevAdm
        '
        Me.btnFiltrarCatDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarCatDevAdm.Location = New System.Drawing.Point(583, 444)
        Me.btnFiltrarCatDevAdm.Name = "btnFiltrarCatDevAdm"
        Me.btnFiltrarCatDevAdm.Size = New System.Drawing.Size(86, 33)
        Me.btnFiltrarCatDevAdm.TabIndex = 4
        Me.btnFiltrarCatDevAdm.Text = "Categorias"
        Me.btnFiltrarCatDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarSubDevAdm
        '
        Me.btnFiltrarSubDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarSubDevAdm.Location = New System.Drawing.Point(700, 444)
        Me.btnFiltrarSubDevAdm.Name = "btnFiltrarSubDevAdm"
        Me.btnFiltrarSubDevAdm.Size = New System.Drawing.Size(104, 33)
        Me.btnFiltrarSubDevAdm.TabIndex = 5
        Me.btnFiltrarSubDevAdm.Text = "Subcategoria"
        Me.btnFiltrarSubDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarMesDevAdm
        '
        Me.btnFiltrarMesDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarMesDevAdm.Location = New System.Drawing.Point(839, 444)
        Me.btnFiltrarMesDevAdm.Name = "btnFiltrarMesDevAdm"
        Me.btnFiltrarMesDevAdm.Size = New System.Drawing.Size(94, 23)
        Me.btnFiltrarMesDevAdm.TabIndex = 6
        Me.btnFiltrarMesDevAdm.Text = "Por Mes"
        Me.btnFiltrarMesDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarAnioDevAdm
        '
        Me.btnFiltrarAnioDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarAnioDevAdm.Location = New System.Drawing.Point(583, 483)
        Me.btnFiltrarAnioDevAdm.Name = "btnFiltrarAnioDevAdm"
        Me.btnFiltrarAnioDevAdm.Size = New System.Drawing.Size(94, 30)
        Me.btnFiltrarAnioDevAdm.TabIndex = 7
        Me.btnFiltrarAnioDevAdm.Text = "Por Año"
        Me.btnFiltrarAnioDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarCatMesDevAdm
        '
        Me.btnFiltrarCatMesDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarCatMesDevAdm.Location = New System.Drawing.Point(700, 483)
        Me.btnFiltrarCatMesDevAdm.Name = "btnFiltrarCatMesDevAdm"
        Me.btnFiltrarCatMesDevAdm.Size = New System.Drawing.Size(133, 30)
        Me.btnFiltrarCatMesDevAdm.TabIndex = 8
        Me.btnFiltrarCatMesDevAdm.Text = "Categoria/Mes"
        Me.btnFiltrarCatMesDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarCatAnioDevAdm
        '
        Me.btnFiltrarCatAnioDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarCatAnioDevAdm.Location = New System.Drawing.Point(839, 480)
        Me.btnFiltrarCatAnioDevAdm.Name = "btnFiltrarCatAnioDevAdm"
        Me.btnFiltrarCatAnioDevAdm.Size = New System.Drawing.Size(111, 33)
        Me.btnFiltrarCatAnioDevAdm.TabIndex = 9
        Me.btnFiltrarCatAnioDevAdm.Text = "Categoria/Año"
        Me.btnFiltrarCatAnioDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarSubMesDevAdm
        '
        Me.btnFiltrarSubMesDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarSubMesDevAdm.Location = New System.Drawing.Point(583, 519)
        Me.btnFiltrarSubMesDevAdm.Name = "btnFiltrarSubMesDevAdm"
        Me.btnFiltrarSubMesDevAdm.Size = New System.Drawing.Size(111, 45)
        Me.btnFiltrarSubMesDevAdm.TabIndex = 10
        Me.btnFiltrarSubMesDevAdm.Text = "Subcaterogia/Mes"
        Me.btnFiltrarSubMesDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarSubAnioDevAdm
        '
        Me.btnFiltrarSubAnioDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarSubAnioDevAdm.Location = New System.Drawing.Point(700, 520)
        Me.btnFiltrarSubAnioDevAdm.Name = "btnFiltrarSubAnioDevAdm"
        Me.btnFiltrarSubAnioDevAdm.Size = New System.Drawing.Size(111, 44)
        Me.btnFiltrarSubAnioDevAdm.TabIndex = 11
        Me.btnFiltrarSubAnioDevAdm.Text = "Subcaterogia/Año"
        Me.btnFiltrarSubAnioDevAdm.UseVisualStyleBackColor = True
        '
        'btnFiltrarMotivoDevAdm
        '
        Me.btnFiltrarMotivoDevAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarMotivoDevAdm.Location = New System.Drawing.Point(839, 530)
        Me.btnFiltrarMotivoDevAdm.Name = "btnFiltrarMotivoDevAdm"
        Me.btnFiltrarMotivoDevAdm.Size = New System.Drawing.Size(79, 34)
        Me.btnFiltrarMotivoDevAdm.TabIndex = 12
        Me.btnFiltrarMotivoDevAdm.Text = "Motivo"
        Me.btnFiltrarMotivoDevAdm.UseVisualStyleBackColor = True
        '
        'btnVolverDevAdm
        '
        Me.btnVolverDevAdm.Location = New System.Drawing.Point(900, 2)
        Me.btnVolverDevAdm.Name = "btnVolverDevAdm"
        Me.btnVolverDevAdm.Size = New System.Drawing.Size(111, 23)
        Me.btnVolverDevAdm.TabIndex = 13
        Me.btnVolverDevAdm.Text = "Ventana Anterior"
        Me.btnVolverDevAdm.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(279, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 72)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(94, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 72)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Anterior"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmGestionarDevolucionesAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 626)
        Me.Controls.Add(Me.btnVolverDevAdm)
        Me.Controls.Add(Me.btnFiltrarMotivoDevAdm)
        Me.Controls.Add(Me.btnFiltrarSubAnioDevAdm)
        Me.Controls.Add(Me.btnFiltrarSubMesDevAdm)
        Me.Controls.Add(Me.btnFiltrarCatAnioDevAdm)
        Me.Controls.Add(Me.btnFiltrarCatMesDevAdm)
        Me.Controls.Add(Me.btnFiltrarAnioDevAdm)
        Me.Controls.Add(Me.btnFiltrarMesDevAdm)
        Me.Controls.Add(Me.btnFiltrarSubDevAdm)
        Me.Controls.Add(Me.btnFiltrarCatDevAdm)
        Me.Controls.Add(Me.grbFiltrarDev)
        Me.Controls.Add(Me.chtEstadisticasDevAdm)
        Me.Controls.Add(Me.grbDetallesDevAdm)
        Me.Controls.Add(Me.grBoxDevolucionesAdm)
        Me.Name = "frmGestionarDevolucionesAdm"
        Me.Text = "Devoluciones Administrador"
        Me.grBoxDevolucionesAdm.ResumeLayout(False)
        CType(Me.dgvDevAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDetallesDevAdm.ResumeLayout(False)
        CType(Me.dgvDetallesDevAdm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtEstadisticasDevAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltrarDev.ResumeLayout(False)
        Me.grbFiltrarDev.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grBoxDevolucionesAdm As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDevAdm As System.Windows.Forms.DataGridView
    Friend WithEvents btnSiguienteDev As System.Windows.Forms.Button
    Friend WithEvents btnAnteriorDev As System.Windows.Forms.Button
    Friend WithEvents grbDetallesDevAdm As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetallesDevAdm As System.Windows.Forms.DataGridView
    Friend WithEvents chtEstadisticasDevAdm As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents grbFiltrarDev As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltradoCatSubDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltradoFechaDevAdm As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSubFiltradoDevAdm As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCatFiltradoDevAdm As System.Windows.Forms.ComboBox
    Friend WithEvents btnFiltradoTodoDevAdm As System.Windows.Forms.Button
    Friend WithEvents lblFechaFinDev As System.Windows.Forms.Label
    Friend WithEvents lblFechaIniDev As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinDevAdm As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicioDevAdm As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFiltrarCatDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarSubDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarMesDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarAnioDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarCatMesDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarCatAnioDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarSubMesDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarSubAnioDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnFiltrarMotivoDevAdm As System.Windows.Forms.Button
    Friend WithEvents btnVolverDevAdm As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
