<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentanaVentasEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentanaVentasEmp))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnVolverIniEmp = New System.Windows.Forms.Button()
        Me.tbcVentasEmpleado = New System.Windows.Forms.TabControl()
        Me.tpgVentas = New System.Windows.Forms.TabPage()
        Me.btnAntProdEmp = New System.Windows.Forms.Button()
        Me.btnSigProdEmp = New System.Windows.Forms.Button()
        Me.btnConfirmarVenta = New System.Windows.Forms.Button()
        Me.grbCarritoProdEmp = New System.Windows.Forms.GroupBox()
        Me.dgvCarritoProdEmp = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.grbListaProdEmp = New System.Windows.Forms.GroupBox()
        Me.grbFiltradoProdEmo = New System.Windows.Forms.GroupBox()
        Me.txbIdProdEmp = New System.Windows.Forms.TextBox()
        Me.txbNombreProdEmp = New System.Windows.Forms.TextBox()
        Me.lblTituloNombreProdEmp = New System.Windows.Forms.Label()
        Me.lblTituloIdProdEmp = New System.Windows.Forms.Label()
        Me.dgvListaProdEmp = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbDatosProdEmp = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPago = New System.Windows.Forms.Label()
        Me.lblTituloTotalPago = New System.Windows.Forms.Label()
        Me.lblNroElemCarrito = New System.Windows.Forms.Label()
        Me.lblTituloElemCarrito = New System.Windows.Forms.Label()
        Me.btnAgregarCarrito = New System.Windows.Forms.Button()
        Me.nudCantProdEmp = New System.Windows.Forms.NumericUpDown()
        Me.lblCantProdEmp = New System.Windows.Forms.Label()
        Me.lblFechaVentaProdEmp = New System.Windows.Forms.Label()
        Me.lblPrecioProdEmp = New System.Windows.Forms.Label()
        Me.lblClasificacionProdEmp = New System.Windows.Forms.Label()
        Me.lblIdProductoEmp = New System.Windows.Forms.Label()
        Me.tpgEstadisticaVentaEmp = New System.Windows.Forms.TabPage()
        Me.grbCriteriosEstadisticas = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVentasEmp = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tbcVentasEmpleado.SuspendLayout()
        Me.tpgVentas.SuspendLayout()
        Me.grbCarritoProdEmp.SuspendLayout()
        CType(Me.dgvCarritoProdEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbListaProdEmp.SuspendLayout()
        Me.grbFiltradoProdEmo.SuspendLayout()
        CType(Me.dgvListaProdEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosProdEmp.SuspendLayout()
        CType(Me.nudCantProdEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgEstadisticaVentaEmp.SuspendLayout()
        Me.grbCriteriosEstadisticas.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverIniEmp
        '
        Me.btnVolverIniEmp.Location = New System.Drawing.Point(1229, 12)
        Me.btnVolverIniEmp.Name = "btnVolverIniEmp"
        Me.btnVolverIniEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverIniEmp.TabIndex = 39
        Me.btnVolverIniEmp.Text = "Volver"
        Me.btnVolverIniEmp.UseVisualStyleBackColor = True
        '
        'tbcVentasEmpleado
        '
        Me.tbcVentasEmpleado.Controls.Add(Me.tpgVentas)
        Me.tbcVentasEmpleado.Controls.Add(Me.tpgEstadisticaVentaEmp)
        Me.tbcVentasEmpleado.Location = New System.Drawing.Point(12, 41)
        Me.tbcVentasEmpleado.Name = "tbcVentasEmpleado"
        Me.tbcVentasEmpleado.SelectedIndex = 0
        Me.tbcVentasEmpleado.Size = New System.Drawing.Size(1310, 548)
        Me.tbcVentasEmpleado.TabIndex = 40
        '
        'tpgVentas
        '
        Me.tpgVentas.BackColor = System.Drawing.Color.DarkGray
        Me.tpgVentas.Controls.Add(Me.btnAntProdEmp)
        Me.tpgVentas.Controls.Add(Me.btnSigProdEmp)
        Me.tpgVentas.Controls.Add(Me.btnConfirmarVenta)
        Me.tpgVentas.Controls.Add(Me.grbCarritoProdEmp)
        Me.tpgVentas.Controls.Add(Me.grbListaProdEmp)
        Me.tpgVentas.Controls.Add(Me.grbDatosProdEmp)
        Me.tpgVentas.Location = New System.Drawing.Point(4, 22)
        Me.tpgVentas.Name = "tpgVentas"
        Me.tpgVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgVentas.Size = New System.Drawing.Size(1302, 522)
        Me.tpgVentas.TabIndex = 0
        Me.tpgVentas.Text = "Venta"
        '
        'btnAntProdEmp
        '
        Me.btnAntProdEmp.Image = CType(resources.GetObject("btnAntProdEmp.Image"), System.Drawing.Image)
        Me.btnAntProdEmp.Location = New System.Drawing.Point(1208, 212)
        Me.btnAntProdEmp.Name = "btnAntProdEmp"
        Me.btnAntProdEmp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAntProdEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnAntProdEmp.TabIndex = 44
        Me.btnAntProdEmp.UseVisualStyleBackColor = True
        '
        'btnSigProdEmp
        '
        Me.btnSigProdEmp.Image = CType(resources.GetObject("btnSigProdEmp.Image"), System.Drawing.Image)
        Me.btnSigProdEmp.Location = New System.Drawing.Point(1208, 129)
        Me.btnSigProdEmp.Name = "btnSigProdEmp"
        Me.btnSigProdEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnSigProdEmp.TabIndex = 43
        Me.btnSigProdEmp.UseVisualStyleBackColor = True
        '
        'btnConfirmarVenta
        '
        Me.btnConfirmarVenta.Location = New System.Drawing.Point(1194, 377)
        Me.btnConfirmarVenta.Name = "btnConfirmarVenta"
        Me.btnConfirmarVenta.Size = New System.Drawing.Size(75, 43)
        Me.btnConfirmarVenta.TabIndex = 42
        Me.btnConfirmarVenta.Text = "Confirmar Venta"
        Me.btnConfirmarVenta.UseVisualStyleBackColor = True
        '
        'grbCarritoProdEmp
        '
        Me.grbCarritoProdEmp.Controls.Add(Me.dgvCarritoProdEmp)
        Me.grbCarritoProdEmp.Location = New System.Drawing.Point(538, 314)
        Me.grbCarritoProdEmp.Name = "grbCarritoProdEmp"
        Me.grbCarritoProdEmp.Size = New System.Drawing.Size(637, 188)
        Me.grbCarritoProdEmp.TabIndex = 41
        Me.grbCarritoProdEmp.TabStop = False
        Me.grbCarritoProdEmp.Text = "Carrito"
        '
        'dgvCarritoProdEmp
        '
        Me.dgvCarritoProdEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarritoProdEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column1, Me.Column2, Me.Column3})
        Me.dgvCarritoProdEmp.Location = New System.Drawing.Point(6, 19)
        Me.dgvCarritoProdEmp.Name = "dgvCarritoProdEmp"
        Me.dgvCarritoProdEmp.Size = New System.Drawing.Size(614, 163)
        Me.dgvCarritoProdEmp.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cantidad"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quitar 1"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column3
        '
        Me.Column3.HeaderText = "Eliminar"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'grbListaProdEmp
        '
        Me.grbListaProdEmp.BackColor = System.Drawing.Color.DodgerBlue
        Me.grbListaProdEmp.Controls.Add(Me.grbFiltradoProdEmo)
        Me.grbListaProdEmp.Controls.Add(Me.dgvListaProdEmp)
        Me.grbListaProdEmp.ForeColor = System.Drawing.Color.Crimson
        Me.grbListaProdEmp.Location = New System.Drawing.Point(532, 6)
        Me.grbListaProdEmp.Name = "grbListaProdEmp"
        Me.grbListaProdEmp.Size = New System.Drawing.Size(643, 287)
        Me.grbListaProdEmp.TabIndex = 40
        Me.grbListaProdEmp.TabStop = False
        Me.grbListaProdEmp.Text = "Lista De Productos"
        '
        'grbFiltradoProdEmo
        '
        Me.grbFiltradoProdEmo.BackColor = System.Drawing.Color.SteelBlue
        Me.grbFiltradoProdEmo.Controls.Add(Me.txbIdProdEmp)
        Me.grbFiltradoProdEmo.Controls.Add(Me.txbNombreProdEmp)
        Me.grbFiltradoProdEmo.Controls.Add(Me.lblTituloNombreProdEmp)
        Me.grbFiltradoProdEmo.Controls.Add(Me.lblTituloIdProdEmp)
        Me.grbFiltradoProdEmo.ForeColor = System.Drawing.Color.Black
        Me.grbFiltradoProdEmo.Location = New System.Drawing.Point(0, 34)
        Me.grbFiltradoProdEmo.Name = "grbFiltradoProdEmo"
        Me.grbFiltradoProdEmo.Size = New System.Drawing.Size(643, 86)
        Me.grbFiltradoProdEmo.TabIndex = 29
        Me.grbFiltradoProdEmo.TabStop = False
        Me.grbFiltradoProdEmo.Text = "Filtrado Productos"
        '
        'txbIdProdEmp
        '
        Me.txbIdProdEmp.Location = New System.Drawing.Point(178, 62)
        Me.txbIdProdEmp.Name = "txbIdProdEmp"
        Me.txbIdProdEmp.Size = New System.Drawing.Size(90, 20)
        Me.txbIdProdEmp.TabIndex = 3
        '
        'txbNombreProdEmp
        '
        Me.txbNombreProdEmp.Location = New System.Drawing.Point(178, 24)
        Me.txbNombreProdEmp.Name = "txbNombreProdEmp"
        Me.txbNombreProdEmp.Size = New System.Drawing.Size(428, 20)
        Me.txbNombreProdEmp.TabIndex = 2
        '
        'lblTituloNombreProdEmp
        '
        Me.lblTituloNombreProdEmp.AutoSize = True
        Me.lblTituloNombreProdEmp.Location = New System.Drawing.Point(15, 65)
        Me.lblTituloNombreProdEmp.Name = "lblTituloNombreProdEmp"
        Me.lblTituloNombreProdEmp.Size = New System.Drawing.Size(90, 13)
        Me.lblTituloNombreProdEmp.TabIndex = 1
        Me.lblTituloNombreProdEmp.Text = "Nombre Producto"
        '
        'lblTituloIdProdEmp
        '
        Me.lblTituloIdProdEmp.AutoSize = True
        Me.lblTituloIdProdEmp.Location = New System.Drawing.Point(15, 27)
        Me.lblTituloIdProdEmp.Name = "lblTituloIdProdEmp"
        Me.lblTituloIdProdEmp.Size = New System.Drawing.Size(90, 13)
        Me.lblTituloIdProdEmp.TabIndex = 0
        Me.lblTituloIdProdEmp.Text = "Número Producto"
        '
        'dgvListaProdEmp
        '
        Me.dgvListaProdEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaProdEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.dgvListaProdEmp.Location = New System.Drawing.Point(6, 134)
        Me.dgvListaProdEmp.Name = "dgvListaProdEmp"
        Me.dgvListaProdEmp.Size = New System.Drawing.Size(614, 147)
        Me.dgvListaProdEmp.TabIndex = 28
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "Número Producto"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "Nombre Producto"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "Subcategoria"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'grbDatosProdEmp
        '
        Me.grbDatosProdEmp.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.grbDatosProdEmp.Controls.Add(Me.Label6)
        Me.grbDatosProdEmp.Controls.Add(Me.Label7)
        Me.grbDatosProdEmp.Controls.Add(Me.Label5)
        Me.grbDatosProdEmp.Controls.Add(Me.Label4)
        Me.grbDatosProdEmp.Controls.Add(Me.Label3)
        Me.grbDatosProdEmp.Controls.Add(Me.Label2)
        Me.grbDatosProdEmp.Controls.Add(Me.Label1)
        Me.grbDatosProdEmp.Controls.Add(Me.lblTotalPago)
        Me.grbDatosProdEmp.Controls.Add(Me.lblTituloTotalPago)
        Me.grbDatosProdEmp.Controls.Add(Me.lblNroElemCarrito)
        Me.grbDatosProdEmp.Controls.Add(Me.lblTituloElemCarrito)
        Me.grbDatosProdEmp.Controls.Add(Me.btnAgregarCarrito)
        Me.grbDatosProdEmp.Controls.Add(Me.nudCantProdEmp)
        Me.grbDatosProdEmp.Controls.Add(Me.lblCantProdEmp)
        Me.grbDatosProdEmp.Controls.Add(Me.lblFechaVentaProdEmp)
        Me.grbDatosProdEmp.Controls.Add(Me.lblPrecioProdEmp)
        Me.grbDatosProdEmp.Controls.Add(Me.lblClasificacionProdEmp)
        Me.grbDatosProdEmp.Controls.Add(Me.lblIdProductoEmp)
        Me.grbDatosProdEmp.Location = New System.Drawing.Point(6, 6)
        Me.grbDatosProdEmp.Name = "grbDatosProdEmp"
        Me.grbDatosProdEmp.Size = New System.Drawing.Size(502, 505)
        Me.grbDatosProdEmp.TabIndex = 39
        Me.grbDatosProdEmp.TabStop = False
        Me.grbDatosProdEmp.Text = "Datos Del Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(306, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Aquí aparecerá el resultado precio/u*cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha Venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Aquí aparecerá el id del producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Aquí aparecerá la fecha de venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Aquí aparecerá la categoría/subcategoría"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Aquí aparecerá la categoría/subcategoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Aquí aparecerá el nombre del producto"
        '
        'lblTotalPago
        '
        Me.lblTotalPago.AutoSize = True
        Me.lblTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPago.Location = New System.Drawing.Point(182, 454)
        Me.lblTotalPago.Name = "lblTotalPago"
        Me.lblTotalPago.Size = New System.Drawing.Size(146, 20)
        Me.lblTotalPago.TabIndex = 11
        Me.lblTotalPago.Text = "Precio Total A Pagar"
        '
        'lblTituloTotalPago
        '
        Me.lblTituloTotalPago.AutoSize = True
        Me.lblTituloTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTotalPago.Location = New System.Drawing.Point(9, 454)
        Me.lblTituloTotalPago.Name = "lblTituloTotalPago"
        Me.lblTituloTotalPago.Size = New System.Drawing.Size(80, 18)
        Me.lblTituloTotalPago.TabIndex = 10
        Me.lblTituloTotalPago.Text = "Total Pago"
        '
        'lblNroElemCarrito
        '
        Me.lblNroElemCarrito.AutoSize = True
        Me.lblNroElemCarrito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNroElemCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroElemCarrito.Location = New System.Drawing.Point(182, 417)
        Me.lblNroElemCarrito.Name = "lblNroElemCarrito"
        Me.lblNroElemCarrito.Size = New System.Drawing.Size(202, 20)
        Me.lblNroElemCarrito.TabIndex = 9
        Me.lblNroElemCarrito.Text = "Total de elementos en carrito"
        '
        'lblTituloElemCarrito
        '
        Me.lblTituloElemCarrito.AutoSize = True
        Me.lblTituloElemCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloElemCarrito.Location = New System.Drawing.Point(9, 417)
        Me.lblTituloElemCarrito.Name = "lblTituloElemCarrito"
        Me.lblTituloElemCarrito.Size = New System.Drawing.Size(167, 18)
        Me.lblTituloElemCarrito.TabIndex = 8
        Me.lblTituloElemCarrito.Text = "Elementos En El Carrito"
        '
        'btnAgregarCarrito
        '
        Me.btnAgregarCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCarrito.Location = New System.Drawing.Point(182, 343)
        Me.btnAgregarCarrito.Name = "btnAgregarCarrito"
        Me.btnAgregarCarrito.Size = New System.Drawing.Size(75, 32)
        Me.btnAgregarCarrito.TabIndex = 7
        Me.btnAgregarCarrito.Text = "Agregar"
        Me.btnAgregarCarrito.UseVisualStyleBackColor = True
        '
        'nudCantProdEmp
        '
        Me.nudCantProdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantProdEmp.Location = New System.Drawing.Point(91, 212)
        Me.nudCantProdEmp.Name = "nudCantProdEmp"
        Me.nudCantProdEmp.Size = New System.Drawing.Size(59, 24)
        Me.nudCantProdEmp.TabIndex = 6
        '
        'lblCantProdEmp
        '
        Me.lblCantProdEmp.AutoSize = True
        Me.lblCantProdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantProdEmp.Location = New System.Drawing.Point(6, 210)
        Me.lblCantProdEmp.Name = "lblCantProdEmp"
        Me.lblCantProdEmp.Size = New System.Drawing.Size(66, 18)
        Me.lblCantProdEmp.TabIndex = 5
        Me.lblCantProdEmp.Text = "Cantidad"
        '
        'lblFechaVentaProdEmp
        '
        Me.lblFechaVentaProdEmp.AutoSize = True
        Me.lblFechaVentaProdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVentaProdEmp.Location = New System.Drawing.Point(6, 171)
        Me.lblFechaVentaProdEmp.Name = "lblFechaVentaProdEmp"
        Me.lblFechaVentaProdEmp.Size = New System.Drawing.Size(90, 18)
        Me.lblFechaVentaProdEmp.TabIndex = 4
        Me.lblFechaVentaProdEmp.Text = "Fecha Venta"
        '
        'lblPrecioProdEmp
        '
        Me.lblPrecioProdEmp.AutoSize = True
        Me.lblPrecioProdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioProdEmp.Location = New System.Drawing.Point(6, 134)
        Me.lblPrecioProdEmp.Name = "lblPrecioProdEmp"
        Me.lblPrecioProdEmp.Size = New System.Drawing.Size(106, 18)
        Me.lblPrecioProdEmp.TabIndex = 3
        Me.lblPrecioProdEmp.Text = "Precio Unitario"
        '
        'lblClasificacionProdEmp
        '
        Me.lblClasificacionProdEmp.AutoSize = True
        Me.lblClasificacionProdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasificacionProdEmp.Location = New System.Drawing.Point(6, 99)
        Me.lblClasificacionProdEmp.Name = "lblClasificacionProdEmp"
        Me.lblClasificacionProdEmp.Size = New System.Drawing.Size(183, 18)
        Me.lblClasificacionProdEmp.TabIndex = 2
        Me.lblClasificacionProdEmp.Text = "Clasificacion Del Producto"
        '
        'lblIdProductoEmp
        '
        Me.lblIdProductoEmp.AutoSize = True
        Me.lblIdProductoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProductoEmp.Location = New System.Drawing.Point(11, 16)
        Me.lblIdProductoEmp.Name = "lblIdProductoEmp"
        Me.lblIdProductoEmp.Size = New System.Drawing.Size(127, 18)
        Me.lblIdProductoEmp.TabIndex = 1
        Me.lblIdProductoEmp.Text = "Número Producto"
        '
        'tpgEstadisticaVentaEmp
        '
        Me.tpgEstadisticaVentaEmp.BackColor = System.Drawing.Color.DarkGray
        Me.tpgEstadisticaVentaEmp.Controls.Add(Me.grbCriteriosEstadisticas)
        Me.tpgEstadisticaVentaEmp.Controls.Add(Me.Chart1)
        Me.tpgEstadisticaVentaEmp.Location = New System.Drawing.Point(4, 22)
        Me.tpgEstadisticaVentaEmp.Name = "tpgEstadisticaVentaEmp"
        Me.tpgEstadisticaVentaEmp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgEstadisticaVentaEmp.Size = New System.Drawing.Size(1302, 522)
        Me.tpgEstadisticaVentaEmp.TabIndex = 1
        Me.tpgEstadisticaVentaEmp.Text = "Estadisticas"
        '
        'grbCriteriosEstadisticas
        '
        Me.grbCriteriosEstadisticas.BackColor = System.Drawing.Color.MediumAquamarine
        Me.grbCriteriosEstadisticas.Controls.Add(Me.Button4)
        Me.grbCriteriosEstadisticas.Controls.Add(Me.Button3)
        Me.grbCriteriosEstadisticas.Controls.Add(Me.Button2)
        Me.grbCriteriosEstadisticas.Controls.Add(Me.Button1)
        Me.grbCriteriosEstadisticas.Controls.Add(Me.btnVentasEmp)
        Me.grbCriteriosEstadisticas.Location = New System.Drawing.Point(104, 312)
        Me.grbCriteriosEstadisticas.Name = "grbCriteriosEstadisticas"
        Me.grbCriteriosEstadisticas.Size = New System.Drawing.Size(813, 121)
        Me.grbCriteriosEstadisticas.TabIndex = 1
        Me.grbCriteriosEstadisticas.TabStop = False
        Me.grbCriteriosEstadisticas.Text = "Datos Estadísticos"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(638, 31)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 68)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Comparación Con Los Primeros 10"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(491, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 68)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ventas Por Categoria"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(177, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 68)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ventas Por Mes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(336, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 68)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ventas Por Año"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnVentasEmp
        '
        Me.btnVentasEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentasEmp.Location = New System.Drawing.Point(18, 31)
        Me.btnVentasEmp.Name = "btnVentasEmp"
        Me.btnVentasEmp.Size = New System.Drawing.Size(94, 68)
        Me.btnVentasEmp.TabIndex = 0
        Me.btnVentasEmp.Text = "Todas Las Ventas"
        Me.btnVentasEmp.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 6)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1248, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'frmVentanaVentasEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 601)
        Me.Controls.Add(Me.tbcVentasEmpleado)
        Me.Controls.Add(Me.btnVolverIniEmp)
        Me.Name = "frmVentanaVentasEmp"
        Me.Text = "Ventas"
        Me.tbcVentasEmpleado.ResumeLayout(False)
        Me.tpgVentas.ResumeLayout(False)
        Me.grbCarritoProdEmp.ResumeLayout(False)
        CType(Me.dgvCarritoProdEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbListaProdEmp.ResumeLayout(False)
        Me.grbFiltradoProdEmo.ResumeLayout(False)
        Me.grbFiltradoProdEmo.PerformLayout()
        CType(Me.dgvListaProdEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosProdEmp.ResumeLayout(False)
        Me.grbDatosProdEmp.PerformLayout()
        CType(Me.nudCantProdEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgEstadisticaVentaEmp.ResumeLayout(False)
        Me.grbCriteriosEstadisticas.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverIniEmp As System.Windows.Forms.Button
    Friend WithEvents tbcVentasEmpleado As System.Windows.Forms.TabControl
    Friend WithEvents tpgVentas As System.Windows.Forms.TabPage
    Friend WithEvents btnAntProdEmp As System.Windows.Forms.Button
    Friend WithEvents btnSigProdEmp As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarVenta As System.Windows.Forms.Button
    Friend WithEvents grbCarritoProdEmp As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCarritoProdEmp As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents grbListaProdEmp As System.Windows.Forms.GroupBox
    Friend WithEvents grbFiltradoProdEmo As System.Windows.Forms.GroupBox
    Friend WithEvents txbIdProdEmp As System.Windows.Forms.TextBox
    Friend WithEvents txbNombreProdEmp As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloNombreProdEmp As System.Windows.Forms.Label
    Friend WithEvents lblTituloIdProdEmp As System.Windows.Forms.Label
    Friend WithEvents dgvListaProdEmp As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grbDatosProdEmp As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPago As System.Windows.Forms.Label
    Friend WithEvents lblTituloTotalPago As System.Windows.Forms.Label
    Friend WithEvents lblNroElemCarrito As System.Windows.Forms.Label
    Friend WithEvents lblTituloElemCarrito As System.Windows.Forms.Label
    Friend WithEvents btnAgregarCarrito As System.Windows.Forms.Button
    Friend WithEvents nudCantProdEmp As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantProdEmp As System.Windows.Forms.Label
    Friend WithEvents lblFechaVentaProdEmp As System.Windows.Forms.Label
    Friend WithEvents lblPrecioProdEmp As System.Windows.Forms.Label
    Friend WithEvents lblClasificacionProdEmp As System.Windows.Forms.Label
    Friend WithEvents lblIdProductoEmp As System.Windows.Forms.Label
    Friend WithEvents tpgEstadisticaVentaEmp As System.Windows.Forms.TabPage
    Friend WithEvents grbCriteriosEstadisticas As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnVentasEmp As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
