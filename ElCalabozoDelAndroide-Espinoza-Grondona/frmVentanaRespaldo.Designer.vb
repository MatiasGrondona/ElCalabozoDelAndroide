<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentanaRespaldo
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
        Me.grbRespaldoTablas = New System.Windows.Forms.GroupBox()
        Me.dgvListaTablas = New System.Windows.Forms.DataGridView()
        Me.ckbSeleccionarTodas = New System.Windows.Forms.CheckBox()
        Me.btnRealizarRespaldo = New System.Windows.Forms.Button()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRespaldar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grbRespaldoTablas.SuspendLayout()
        CType(Me.dgvListaTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbRespaldoTablas
        '
        Me.grbRespaldoTablas.BackColor = System.Drawing.Color.Aquamarine
        Me.grbRespaldoTablas.Controls.Add(Me.btnRealizarRespaldo)
        Me.grbRespaldoTablas.Controls.Add(Me.ckbSeleccionarTodas)
        Me.grbRespaldoTablas.Controls.Add(Me.dgvListaTablas)
        Me.grbRespaldoTablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbRespaldoTablas.Location = New System.Drawing.Point(12, 23)
        Me.grbRespaldoTablas.Name = "grbRespaldoTablas"
        Me.grbRespaldoTablas.Size = New System.Drawing.Size(533, 227)
        Me.grbRespaldoTablas.TabIndex = 0
        Me.grbRespaldoTablas.TabStop = False
        Me.grbRespaldoTablas.Text = "Datos Para El Respaldo"
        '
        'dgvListaTablas
        '
        Me.dgvListaTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaTablas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre, Me.colRespaldar})
        Me.dgvListaTablas.Location = New System.Drawing.Point(0, 71)
        Me.dgvListaTablas.Name = "dgvListaTablas"
        Me.dgvListaTablas.Size = New System.Drawing.Size(386, 150)
        Me.dgvListaTablas.TabIndex = 0
        '
        'ckbSeleccionarTodas
        '
        Me.ckbSeleccionarTodas.AutoSize = True
        Me.ckbSeleccionarTodas.Location = New System.Drawing.Point(180, 41)
        Me.ckbSeleccionarTodas.Name = "ckbSeleccionarTodas"
        Me.ckbSeleccionarTodas.Size = New System.Drawing.Size(201, 22)
        Me.ckbSeleccionarTodas.TabIndex = 1
        Me.ckbSeleccionarTodas.Text = "Respaldar todas las tablas"
        Me.ckbSeleccionarTodas.UseVisualStyleBackColor = True
        '
        'btnRealizarRespaldo
        '
        Me.btnRealizarRespaldo.Location = New System.Drawing.Point(423, 122)
        Me.btnRealizarRespaldo.Name = "btnRealizarRespaldo"
        Me.btnRealizarRespaldo.Size = New System.Drawing.Size(89, 69)
        Me.btnRealizarRespaldo.TabIndex = 2
        Me.btnRealizarRespaldo.Text = "Realizar Respaldo"
        Me.btnRealizarRespaldo.UseVisualStyleBackColor = True
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre Tabla"
        Me.colNombre.Name = "colNombre"
        '
        'colRespaldar
        '
        Me.colRespaldar.HeaderText = "Respaldar"
        Me.colRespaldar.Name = "colRespaldar"
        Me.colRespaldar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colRespaldar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmVentanaRespaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(561, 262)
        Me.Controls.Add(Me.grbRespaldoTablas)
        Me.Name = "frmVentanaRespaldo"
        Me.Text = "Respaldo De Tablas"
        Me.grbRespaldoTablas.ResumeLayout(False)
        Me.grbRespaldoTablas.PerformLayout()
        CType(Me.dgvListaTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbRespaldoTablas As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListaTablas As System.Windows.Forms.DataGridView
    Friend WithEvents btnRealizarRespaldo As System.Windows.Forms.Button
    Friend WithEvents ckbSeleccionarTodas As System.Windows.Forms.CheckBox
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRespaldar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
