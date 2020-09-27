<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarUsuariosAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionarUsuariosAdm))
        Me.tbcUsuarios = New System.Windows.Forms.TabControl()
        Me.tpgNuevoEmp = New System.Windows.Forms.TabPage()
        Me.grbFiltradoEmpAdm = New System.Windows.Forms.GroupBox()
        Me.btnFiltrarEmp = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.lblApeFiltradoEmp = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.lblDniFiltradoEmp = New System.Windows.Forms.Label()
        Me.grbEmpleados = New System.Windows.Forms.GroupBox()
        Me.btnAntEmp = New System.Windows.Forms.Button()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnBajaAltaEmpleado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colIdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSigEmp = New System.Windows.Forms.Button()
        Me.grbNuevoUsuario = New System.Windows.Forms.GroupBox()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblMailEmpleado = New System.Windows.Forms.Label()
        Me.lblTelEmpleado = New System.Windows.Forms.Label()
        Me.lblDniEmpleado = New System.Windows.Forms.Label()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblApellidoEmpleado = New System.Windows.Forms.Label()
        Me.tpgNuevoUsu = New System.Windows.Forms.TabPage()
        Me.grbFiltradoEmpNuevoAdm = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grbEmNuevoUsuAdm = New System.Windows.Forms.GroupBox()
        Me.btnSigNuevoUsu = New System.Windows.Forms.Button()
        Me.btnAnteNuevoUsu = New System.Windows.Forms.Button()
        Me.dgvEmpNuevoAdm = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbNuevoEmpAdm = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbTiposUsuario = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tpgModUsu = New System.Windows.Forms.TabPage()
        Me.grbFiltradoModUsuAdm = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.grbModUsuAdm = New System.Windows.Forms.GroupBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.grbUsuModUsuAdm = New System.Windows.Forms.GroupBox()
        Me.btnSigModUsuAdm = New System.Windows.Forms.Button()
        Me.btnAntModUsuAdm = New System.Windows.Forms.Button()
        Me.dgvUsuariosActivosAdm = New System.Windows.Forms.DataGridView()
        Me.btnAltaBaja = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpgModUsuActual = New System.Windows.Forms.TabPage()
        Me.grbCambioDatosUsu = New System.Windows.Forms.GroupBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmbTipoModDatosUsu = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnUsuRegreso = New System.Windows.Forms.Button()
        Me.tbcUsuarios.SuspendLayout()
        Me.tpgNuevoEmp.SuspendLayout()
        Me.grbFiltradoEmpAdm.SuspendLayout()
        Me.grbEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNuevoUsuario.SuspendLayout()
        Me.tpgNuevoUsu.SuspendLayout()
        Me.grbFiltradoEmpNuevoAdm.SuspendLayout()
        Me.grbEmNuevoUsuAdm.SuspendLayout()
        CType(Me.dgvEmpNuevoAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNuevoEmpAdm.SuspendLayout()
        Me.tpgModUsu.SuspendLayout()
        Me.grbFiltradoModUsuAdm.SuspendLayout()
        Me.grbModUsuAdm.SuspendLayout()
        Me.grbUsuModUsuAdm.SuspendLayout()
        CType(Me.dgvUsuariosActivosAdm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgModUsuActual.SuspendLayout()
        Me.grbCambioDatosUsu.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcUsuarios
        '
        Me.tbcUsuarios.Controls.Add(Me.tpgNuevoEmp)
        Me.tbcUsuarios.Controls.Add(Me.tpgNuevoUsu)
        Me.tbcUsuarios.Controls.Add(Me.tpgModUsu)
        Me.tbcUsuarios.Controls.Add(Me.tpgModUsuActual)
        Me.tbcUsuarios.Location = New System.Drawing.Point(12, 30)
        Me.tbcUsuarios.Name = "tbcUsuarios"
        Me.tbcUsuarios.SelectedIndex = 0
        Me.tbcUsuarios.Size = New System.Drawing.Size(1233, 494)
        Me.tbcUsuarios.TabIndex = 0
        '
        'tpgNuevoEmp
        '
        Me.tpgNuevoEmp.AllowDrop = True
        Me.tpgNuevoEmp.Controls.Add(Me.grbFiltradoEmpAdm)
        Me.tpgNuevoEmp.Controls.Add(Me.grbEmpleados)
        Me.tpgNuevoEmp.Controls.Add(Me.grbNuevoUsuario)
        Me.tpgNuevoEmp.Location = New System.Drawing.Point(4, 22)
        Me.tpgNuevoEmp.Name = "tpgNuevoEmp"
        Me.tpgNuevoEmp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgNuevoEmp.Size = New System.Drawing.Size(1225, 468)
        Me.tpgNuevoEmp.TabIndex = 0
        Me.tpgNuevoEmp.Text = " Empleado"
        Me.tpgNuevoEmp.UseVisualStyleBackColor = True
        '
        'grbFiltradoEmpAdm
        '
        Me.grbFiltradoEmpAdm.BackColor = System.Drawing.Color.RoyalBlue
        Me.grbFiltradoEmpAdm.Controls.Add(Me.btnFiltrarEmp)
        Me.grbFiltradoEmpAdm.Controls.Add(Me.TextBox12)
        Me.grbFiltradoEmpAdm.Controls.Add(Me.lblApeFiltradoEmp)
        Me.grbFiltradoEmpAdm.Controls.Add(Me.TextBox11)
        Me.grbFiltradoEmpAdm.Controls.Add(Me.lblDniFiltradoEmp)
        Me.grbFiltradoEmpAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltradoEmpAdm.Location = New System.Drawing.Point(541, 12)
        Me.grbFiltradoEmpAdm.Name = "grbFiltradoEmpAdm"
        Me.grbFiltradoEmpAdm.Size = New System.Drawing.Size(387, 92)
        Me.grbFiltradoEmpAdm.TabIndex = 12
        Me.grbFiltradoEmpAdm.TabStop = False
        Me.grbFiltradoEmpAdm.Text = "Opciones De Filtrado"
        '
        'btnFiltrarEmp
        '
        Me.btnFiltrarEmp.Location = New System.Drawing.Point(300, 41)
        Me.btnFiltrarEmp.Name = "btnFiltrarEmp"
        Me.btnFiltrarEmp.Size = New System.Drawing.Size(81, 29)
        Me.btnFiltrarEmp.TabIndex = 11
        Me.btnFiltrarEmp.Text = "Filtrar"
        Me.btnFiltrarEmp.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(141, 44)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(148, 26)
        Me.TextBox12.TabIndex = 8
        '
        'lblApeFiltradoEmp
        '
        Me.lblApeFiltradoEmp.AutoSize = True
        Me.lblApeFiltradoEmp.Location = New System.Drawing.Point(188, 22)
        Me.lblApeFiltradoEmp.Name = "lblApeFiltradoEmp"
        Me.lblApeFiltradoEmp.Size = New System.Drawing.Size(65, 20)
        Me.lblApeFiltradoEmp.TabIndex = 7
        Me.lblApeFiltradoEmp.Text = "Apellido"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(6, 44)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(121, 26)
        Me.TextBox11.TabIndex = 6
        '
        'lblDniFiltradoEmp
        '
        Me.lblDniFiltradoEmp.AutoSize = True
        Me.lblDniFiltradoEmp.Location = New System.Drawing.Point(41, 21)
        Me.lblDniFiltradoEmp.Name = "lblDniFiltradoEmp"
        Me.lblDniFiltradoEmp.Size = New System.Drawing.Size(33, 20)
        Me.lblDniFiltradoEmp.TabIndex = 0
        Me.lblDniFiltradoEmp.Text = "Dni"
        '
        'grbEmpleados
        '
        Me.grbEmpleados.Controls.Add(Me.btnAntEmp)
        Me.grbEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.grbEmpleados.Controls.Add(Me.btnSigEmp)
        Me.grbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEmpleados.Location = New System.Drawing.Point(428, 110)
        Me.grbEmpleados.Name = "grbEmpleados"
        Me.grbEmpleados.Size = New System.Drawing.Size(778, 248)
        Me.grbEmpleados.TabIndex = 1
        Me.grbEmpleados.TabStop = False
        Me.grbEmpleados.Text = "Datos Empleados Registrados"
        '
        'btnAntEmp
        '
        Me.btnAntEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAntEmp.Image = CType(resources.GetObject("btnAntEmp.Image"), System.Drawing.Image)
        Me.btnAntEmp.Location = New System.Drawing.Point(245, 176)
        Me.btnAntEmp.Name = "btnAntEmp"
        Me.btnAntEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnAntEmp.TabIndex = 13
        Me.btnAntEmp.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnBajaAltaEmpleado, Me.colIdEmpleado, Me.colNombre, Me.colApellido, Me.colDni, Me.colTel, Me.colEmail})
        Me.dgvEmpleados.Location = New System.Drawing.Point(6, 24)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(766, 150)
        Me.dgvEmpleados.TabIndex = 0
        '
        'btnBajaAltaEmpleado
        '
        Me.btnBajaAltaEmpleado.HeaderText = "Baja/Alta"
        Me.btnBajaAltaEmpleado.Name = "btnBajaAltaEmpleado"
        Me.btnBajaAltaEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnBajaAltaEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colIdEmpleado
        '
        Me.colIdEmpleado.HeaderText = "idEmpleado"
        Me.colIdEmpleado.Name = "colIdEmpleado"
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        '
        'colApellido
        '
        Me.colApellido.HeaderText = "Apellido"
        Me.colApellido.Name = "colApellido"
        '
        'colDni
        '
        Me.colDni.HeaderText = "Dni"
        Me.colDni.Name = "colDni"
        '
        'colTel
        '
        Me.colTel.HeaderText = "Teléfono"
        Me.colTel.Name = "colTel"
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        '
        'btnSigEmp
        '
        Me.btnSigEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigEmp.Image = CType(resources.GetObject("btnSigEmp.Image"), System.Drawing.Image)
        Me.btnSigEmp.Location = New System.Drawing.Point(422, 176)
        Me.btnSigEmp.Name = "btnSigEmp"
        Me.btnSigEmp.Size = New System.Drawing.Size(72, 72)
        Me.btnSigEmp.TabIndex = 11
        Me.btnSigEmp.UseVisualStyleBackColor = True
        '
        'grbNuevoUsuario
        '
        Me.grbNuevoUsuario.BackColor = System.Drawing.Color.Aquamarine
        Me.grbNuevoUsuario.Controls.Add(Me.btnAgregarEmpleado)
        Me.grbNuevoUsuario.Controls.Add(Me.TextBox5)
        Me.grbNuevoUsuario.Controls.Add(Me.TextBox4)
        Me.grbNuevoUsuario.Controls.Add(Me.TextBox3)
        Me.grbNuevoUsuario.Controls.Add(Me.TextBox2)
        Me.grbNuevoUsuario.Controls.Add(Me.TextBox1)
        Me.grbNuevoUsuario.Controls.Add(Me.lblMailEmpleado)
        Me.grbNuevoUsuario.Controls.Add(Me.lblTelEmpleado)
        Me.grbNuevoUsuario.Controls.Add(Me.lblDniEmpleado)
        Me.grbNuevoUsuario.Controls.Add(Me.lblNombreEmpleado)
        Me.grbNuevoUsuario.Controls.Add(Me.lblApellidoEmpleado)
        Me.grbNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNuevoUsuario.Location = New System.Drawing.Point(6, 6)
        Me.grbNuevoUsuario.Name = "grbNuevoUsuario"
        Me.grbNuevoUsuario.Size = New System.Drawing.Size(397, 236)
        Me.grbNuevoUsuario.TabIndex = 0
        Me.grbNuevoUsuario.TabStop = False
        Me.grbNuevoUsuario.Text = "Datos Empleado Nuevo"
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(138, 196)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(145, 34)
        Me.btnAgregarEmpleado.TabIndex = 10
        Me.btnAgregarEmpleado.Text = "Agregar"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(126, 160)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(246, 26)
        Me.TextBox5.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(126, 124)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(246, 26)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(126, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(246, 26)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(126, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 26)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 26)
        Me.TextBox1.TabIndex = 5
        '
        'lblMailEmpleado
        '
        Me.lblMailEmpleado.AutoSize = True
        Me.lblMailEmpleado.Location = New System.Drawing.Point(6, 160)
        Me.lblMailEmpleado.Name = "lblMailEmpleado"
        Me.lblMailEmpleado.Size = New System.Drawing.Size(53, 20)
        Me.lblMailEmpleado.TabIndex = 4
        Me.lblMailEmpleado.Text = "E-Mail"
        '
        'lblTelEmpleado
        '
        Me.lblTelEmpleado.AutoSize = True
        Me.lblTelEmpleado.Location = New System.Drawing.Point(6, 124)
        Me.lblTelEmpleado.Name = "lblTelEmpleado"
        Me.lblTelEmpleado.Size = New System.Drawing.Size(71, 20)
        Me.lblTelEmpleado.TabIndex = 3
        Me.lblTelEmpleado.Text = "Teléfono"
        '
        'lblDniEmpleado
        '
        Me.lblDniEmpleado.AutoSize = True
        Me.lblDniEmpleado.Location = New System.Drawing.Point(6, 95)
        Me.lblDniEmpleado.Name = "lblDniEmpleado"
        Me.lblDniEmpleado.Size = New System.Drawing.Size(33, 20)
        Me.lblDniEmpleado.TabIndex = 2
        Me.lblDniEmpleado.Text = "Dni"
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(6, 59)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(65, 20)
        Me.lblNombreEmpleado.TabIndex = 1
        Me.lblNombreEmpleado.Text = "Nombre"
        '
        'lblApellidoEmpleado
        '
        Me.lblApellidoEmpleado.AutoSize = True
        Me.lblApellidoEmpleado.Location = New System.Drawing.Point(6, 30)
        Me.lblApellidoEmpleado.Name = "lblApellidoEmpleado"
        Me.lblApellidoEmpleado.Size = New System.Drawing.Size(65, 20)
        Me.lblApellidoEmpleado.TabIndex = 0
        Me.lblApellidoEmpleado.Text = "Apellido"
        '
        'tpgNuevoUsu
        '
        Me.tpgNuevoUsu.Controls.Add(Me.grbFiltradoEmpNuevoAdm)
        Me.tpgNuevoUsu.Controls.Add(Me.grbEmNuevoUsuAdm)
        Me.tpgNuevoUsu.Controls.Add(Me.grbNuevoEmpAdm)
        Me.tpgNuevoUsu.Location = New System.Drawing.Point(4, 22)
        Me.tpgNuevoUsu.Name = "tpgNuevoUsu"
        Me.tpgNuevoUsu.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgNuevoUsu.Size = New System.Drawing.Size(1225, 468)
        Me.tpgNuevoUsu.TabIndex = 1
        Me.tpgNuevoUsu.Text = "Nuevo Usuario"
        Me.tpgNuevoUsu.UseVisualStyleBackColor = True
        '
        'grbFiltradoEmpNuevoAdm
        '
        Me.grbFiltradoEmpNuevoAdm.BackColor = System.Drawing.Color.SpringGreen
        Me.grbFiltradoEmpNuevoAdm.Controls.Add(Me.Button3)
        Me.grbFiltradoEmpNuevoAdm.Controls.Add(Me.TextBox21)
        Me.grbFiltradoEmpNuevoAdm.Controls.Add(Me.Label13)
        Me.grbFiltradoEmpNuevoAdm.Controls.Add(Me.TextBox22)
        Me.grbFiltradoEmpNuevoAdm.Controls.Add(Me.Label14)
        Me.grbFiltradoEmpNuevoAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltradoEmpNuevoAdm.Location = New System.Drawing.Point(474, 6)
        Me.grbFiltradoEmpNuevoAdm.Name = "grbFiltradoEmpNuevoAdm"
        Me.grbFiltradoEmpNuevoAdm.Size = New System.Drawing.Size(407, 183)
        Me.grbFiltradoEmpNuevoAdm.TabIndex = 13
        Me.grbFiltradoEmpNuevoAdm.TabStop = False
        Me.grbFiltradoEmpNuevoAdm.Text = "Opciones De Filtrado"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(115, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 31)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Filtrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(115, 101)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(182, 26)
        Me.TextBox21.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(155, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 20)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Apellido"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(115, 49)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(182, 26)
        Me.TextBox22.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(174, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Dni"
        '
        'grbEmNuevoUsuAdm
        '
        Me.grbEmNuevoUsuAdm.Controls.Add(Me.btnSigNuevoUsu)
        Me.grbEmNuevoUsuAdm.Controls.Add(Me.btnAnteNuevoUsu)
        Me.grbEmNuevoUsuAdm.Controls.Add(Me.dgvEmpNuevoAdm)
        Me.grbEmNuevoUsuAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEmNuevoUsuAdm.Location = New System.Drawing.Point(474, 195)
        Me.grbEmNuevoUsuAdm.Name = "grbEmNuevoUsuAdm"
        Me.grbEmNuevoUsuAdm.Size = New System.Drawing.Size(745, 249)
        Me.grbEmNuevoUsuAdm.TabIndex = 2
        Me.grbEmNuevoUsuAdm.TabStop = False
        Me.grbEmNuevoUsuAdm.Text = "Datos Empleados Registrados"
        '
        'btnSigNuevoUsu
        '
        Me.btnSigNuevoUsu.Image = CType(resources.GetObject("btnSigNuevoUsu.Image"), System.Drawing.Image)
        Me.btnSigNuevoUsu.Location = New System.Drawing.Point(359, 175)
        Me.btnSigNuevoUsu.Name = "btnSigNuevoUsu"
        Me.btnSigNuevoUsu.Size = New System.Drawing.Size(72, 72)
        Me.btnSigNuevoUsu.TabIndex = 20
        Me.btnSigNuevoUsu.UseVisualStyleBackColor = True
        '
        'btnAnteNuevoUsu
        '
        Me.btnAnteNuevoUsu.Image = CType(resources.GetObject("btnAnteNuevoUsu.Image"), System.Drawing.Image)
        Me.btnAnteNuevoUsu.Location = New System.Drawing.Point(159, 175)
        Me.btnAnteNuevoUsu.Name = "btnAnteNuevoUsu"
        Me.btnAnteNuevoUsu.Size = New System.Drawing.Size(72, 72)
        Me.btnAnteNuevoUsu.TabIndex = 19
        Me.btnAnteNuevoUsu.UseVisualStyleBackColor = True
        '
        'dgvEmpNuevoAdm
        '
        Me.dgvEmpNuevoAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpNuevoAdm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvEmpNuevoAdm.Location = New System.Drawing.Point(5, 19)
        Me.dgvEmpNuevoAdm.Name = "dgvEmpNuevoAdm"
        Me.dgvEmpNuevoAdm.Size = New System.Drawing.Size(739, 150)
        Me.dgvEmpNuevoAdm.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Legajo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dni"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'grbNuevoEmpAdm
        '
        Me.grbNuevoEmpAdm.BackColor = System.Drawing.Color.PaleGreen
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label27)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label26)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label25)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label24)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label23)
        Me.grbNuevoEmpAdm.Controls.Add(Me.cmbTiposUsuario)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label18)
        Me.grbNuevoEmpAdm.Controls.Add(Me.TextBox20)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label12)
        Me.grbNuevoEmpAdm.Controls.Add(Me.TextBox19)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label11)
        Me.grbNuevoEmpAdm.Controls.Add(Me.TextBox18)
        Me.grbNuevoEmpAdm.Controls.Add(Me.lblNombreUsuario)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Button2)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label6)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label7)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label8)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label9)
        Me.grbNuevoEmpAdm.Controls.Add(Me.Label10)
        Me.grbNuevoEmpAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNuevoEmpAdm.Location = New System.Drawing.Point(6, 6)
        Me.grbNuevoEmpAdm.Name = "grbNuevoEmpAdm"
        Me.grbNuevoEmpAdm.Size = New System.Drawing.Size(442, 429)
        Me.grbNuevoEmpAdm.TabIndex = 1
        Me.grbNuevoEmpAdm.TabStop = False
        Me.grbNuevoEmpAdm.Text = "Datos Empleado Nuevo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(175, 176)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(222, 20)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Aquí va el e-mail del empleado"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(175, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(238, 20)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Aquí va el teléfono del empleado"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(175, 94)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(201, 20)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Aquí va el dni del empleado"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(175, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(234, 20)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Aquí va el nombre del empleado"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(175, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(234, 20)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Aquí va el apellido del empleado"
        '
        'cmbTiposUsuario
        '
        Me.cmbTiposUsuario.FormattingEnabled = True
        Me.cmbTiposUsuario.Location = New System.Drawing.Point(179, 322)
        Me.cmbTiposUsuario.Name = "cmbTiposUsuario"
        Me.cmbTiposUsuario.Size = New System.Drawing.Size(182, 28)
        Me.cmbTiposUsuario.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 332)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Tipo Usuario"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(179, 290)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(182, 26)
        Me.TextBox20.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Repetir Contraseña"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(179, 258)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(182, 26)
        Me.TextBox19.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Contraseña"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(179, 223)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(182, 26)
        Me.TextBox18.TabIndex = 12
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(6, 219)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(124, 20)
        Me.lblNombreUsuario.TabIndex = 11
        Me.lblNombreUsuario.Text = "Nombre Usuario"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Crear Usuario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "E-Mail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Teléfono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Dni"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nombre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Apellido"
        '
        'tpgModUsu
        '
        Me.tpgModUsu.Controls.Add(Me.grbFiltradoModUsuAdm)
        Me.tpgModUsu.Controls.Add(Me.grbModUsuAdm)
        Me.tpgModUsu.Controls.Add(Me.grbUsuModUsuAdm)
        Me.tpgModUsu.Location = New System.Drawing.Point(4, 22)
        Me.tpgModUsu.Name = "tpgModUsu"
        Me.tpgModUsu.Size = New System.Drawing.Size(1225, 468)
        Me.tpgModUsu.TabIndex = 2
        Me.tpgModUsu.Text = "Modificar Usuario"
        Me.tpgModUsu.UseVisualStyleBackColor = True
        '
        'grbFiltradoModUsuAdm
        '
        Me.grbFiltradoModUsuAdm.BackColor = System.Drawing.Color.Aqua
        Me.grbFiltradoModUsuAdm.Controls.Add(Me.Button9)
        Me.grbFiltradoModUsuAdm.Controls.Add(Me.TextBox27)
        Me.grbFiltradoModUsuAdm.Controls.Add(Me.Label21)
        Me.grbFiltradoModUsuAdm.Controls.Add(Me.TextBox28)
        Me.grbFiltradoModUsuAdm.Controls.Add(Me.Label22)
        Me.grbFiltradoModUsuAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltradoModUsuAdm.Location = New System.Drawing.Point(467, 3)
        Me.grbFiltradoModUsuAdm.Name = "grbFiltradoModUsuAdm"
        Me.grbFiltradoModUsuAdm.Size = New System.Drawing.Size(346, 192)
        Me.grbFiltradoModUsuAdm.TabIndex = 14
        Me.grbFiltradoModUsuAdm.TabStop = False
        Me.grbFiltradoModUsuAdm.Text = "Opciones De Filtrado"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(123, 154)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(116, 32)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Filtrar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(94, 111)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(182, 26)
        Me.TextBox27.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(156, 82)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 20)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Apellido"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(104, 51)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(182, 26)
        Me.TextBox28.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(156, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 20)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Dni"
        '
        'grbModUsuAdm
        '
        Me.grbModUsuAdm.BackColor = System.Drawing.Color.LightGreen
        Me.grbModUsuAdm.Controls.Add(Me.TextBox26)
        Me.grbModUsuAdm.Controls.Add(Me.Label20)
        Me.grbModUsuAdm.Controls.Add(Me.ComboBox1)
        Me.grbModUsuAdm.Controls.Add(Me.Label19)
        Me.grbModUsuAdm.Controls.Add(Me.TextBox23)
        Me.grbModUsuAdm.Controls.Add(Me.Label15)
        Me.grbModUsuAdm.Controls.Add(Me.TextBox24)
        Me.grbModUsuAdm.Controls.Add(Me.Label16)
        Me.grbModUsuAdm.Controls.Add(Me.TextBox25)
        Me.grbModUsuAdm.Controls.Add(Me.Label17)
        Me.grbModUsuAdm.Controls.Add(Me.Button8)
        Me.grbModUsuAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbModUsuAdm.Location = New System.Drawing.Point(3, 3)
        Me.grbModUsuAdm.Name = "grbModUsuAdm"
        Me.grbModUsuAdm.Size = New System.Drawing.Size(433, 285)
        Me.grbModUsuAdm.TabIndex = 4
        Me.grbModUsuAdm.TabStop = False
        Me.grbModUsuAdm.Text = "Datos Usuario"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(197, 180)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(182, 26)
        Me.TextBox26.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 186)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(148, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Repetir Contraseña"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(197, 108)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 20)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Tipo Usuario"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(197, 148)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(182, 26)
        Me.TextBox23.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(173, 20)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Contraseña Modificada"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(197, 69)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(182, 26)
        Me.TextBox24.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 20)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Contraseña"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(197, 33)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(182, 26)
        Me.TextBox25.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 20)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Nombre Usuario"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(108, 218)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(224, 61)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Guardar Nueva Contraseña o Nuevo Tipo"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'grbUsuModUsuAdm
        '
        Me.grbUsuModUsuAdm.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.grbUsuModUsuAdm.Controls.Add(Me.btnSigModUsuAdm)
        Me.grbUsuModUsuAdm.Controls.Add(Me.btnAntModUsuAdm)
        Me.grbUsuModUsuAdm.Controls.Add(Me.dgvUsuariosActivosAdm)
        Me.grbUsuModUsuAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbUsuModUsuAdm.Location = New System.Drawing.Point(442, 201)
        Me.grbUsuModUsuAdm.Name = "grbUsuModUsuAdm"
        Me.grbUsuModUsuAdm.Size = New System.Drawing.Size(768, 249)
        Me.grbUsuModUsuAdm.TabIndex = 3
        Me.grbUsuModUsuAdm.TabStop = False
        Me.grbUsuModUsuAdm.Text = "Datos Usuarios Activos"
        '
        'btnSigModUsuAdm
        '
        Me.btnSigModUsuAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigModUsuAdm.Image = CType(resources.GetObject("btnSigModUsuAdm.Image"), System.Drawing.Image)
        Me.btnSigModUsuAdm.Location = New System.Drawing.Point(344, 175)
        Me.btnSigModUsuAdm.Name = "btnSigModUsuAdm"
        Me.btnSigModUsuAdm.Size = New System.Drawing.Size(72, 72)
        Me.btnSigModUsuAdm.TabIndex = 25
        Me.btnSigModUsuAdm.UseVisualStyleBackColor = True
        '
        'btnAntModUsuAdm
        '
        Me.btnAntModUsuAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAntModUsuAdm.Image = CType(resources.GetObject("btnAntModUsuAdm.Image"), System.Drawing.Image)
        Me.btnAntModUsuAdm.Location = New System.Drawing.Point(148, 171)
        Me.btnAntModUsuAdm.Name = "btnAntModUsuAdm"
        Me.btnAntModUsuAdm.Size = New System.Drawing.Size(72, 72)
        Me.btnAntModUsuAdm.TabIndex = 26
        Me.btnAntModUsuAdm.UseVisualStyleBackColor = True
        '
        'dgvUsuariosActivosAdm
        '
        Me.dgvUsuariosActivosAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuariosActivosAdm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnAltaBaja, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dgvUsuariosActivosAdm.Location = New System.Drawing.Point(12, 19)
        Me.dgvUsuariosActivosAdm.Name = "dgvUsuariosActivosAdm"
        Me.dgvUsuariosActivosAdm.Size = New System.Drawing.Size(750, 150)
        Me.dgvUsuariosActivosAdm.TabIndex = 0
        '
        'btnAltaBaja
        '
        Me.btnAltaBaja.HeaderText = "Alta/Baja"
        Me.btnAltaBaja.Name = "btnAltaBaja"
        Me.btnAltaBaja.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnAltaBaja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Identificación"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Dni"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Perfil"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'tpgModUsuActual
        '
        Me.tpgModUsuActual.Controls.Add(Me.grbCambioDatosUsu)
        Me.tpgModUsuActual.Controls.Add(Me.GroupBox8)
        Me.tpgModUsuActual.Location = New System.Drawing.Point(4, 22)
        Me.tpgModUsuActual.Name = "tpgModUsuActual"
        Me.tpgModUsuActual.Size = New System.Drawing.Size(1225, 468)
        Me.tpgModUsuActual.TabIndex = 3
        Me.tpgModUsuActual.Text = "Modificar Datos Propios"
        Me.tpgModUsuActual.UseVisualStyleBackColor = True
        '
        'grbCambioDatosUsu
        '
        Me.grbCambioDatosUsu.BackColor = System.Drawing.Color.LightGreen
        Me.grbCambioDatosUsu.Controls.Add(Me.TextBox29)
        Me.grbCambioDatosUsu.Controls.Add(Me.Label33)
        Me.grbCambioDatosUsu.Controls.Add(Me.cmbTipoModDatosUsu)
        Me.grbCambioDatosUsu.Controls.Add(Me.Label34)
        Me.grbCambioDatosUsu.Controls.Add(Me.TextBox30)
        Me.grbCambioDatosUsu.Controls.Add(Me.Label35)
        Me.grbCambioDatosUsu.Controls.Add(Me.TextBox31)
        Me.grbCambioDatosUsu.Controls.Add(Me.Label36)
        Me.grbCambioDatosUsu.Controls.Add(Me.TextBox32)
        Me.grbCambioDatosUsu.Controls.Add(Me.Label37)
        Me.grbCambioDatosUsu.Controls.Add(Me.Button13)
        Me.grbCambioDatosUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCambioDatosUsu.Location = New System.Drawing.Point(474, 21)
        Me.grbCambioDatosUsu.Name = "grbCambioDatosUsu"
        Me.grbCambioDatosUsu.Size = New System.Drawing.Size(433, 285)
        Me.grbCambioDatosUsu.TabIndex = 13
        Me.grbCambioDatosUsu.TabStop = False
        Me.grbCambioDatosUsu.Text = "Datos Usuario"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(197, 180)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(182, 26)
        Me.TextBox29.TabIndex = 22
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 186)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(148, 20)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "Repetir Contraseña"
        '
        'cmbTipoModDatosUsu
        '
        Me.cmbTipoModDatosUsu.FormattingEnabled = True
        Me.cmbTipoModDatosUsu.Location = New System.Drawing.Point(197, 108)
        Me.cmbTipoModDatosUsu.Name = "cmbTipoModDatosUsu"
        Me.cmbTipoModDatosUsu.Size = New System.Drawing.Size(121, 28)
        Me.cmbTipoModDatosUsu.TabIndex = 20
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 113)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(98, 20)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Tipo Usuario"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(197, 148)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(182, 26)
        Me.TextBox30.TabIndex = 16
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 154)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(173, 20)
        Me.Label35.TabIndex = 15
        Me.Label35.Text = "Contraseña Modificada"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(197, 69)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(182, 26)
        Me.TextBox31.TabIndex = 14
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 75)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(92, 20)
        Me.Label36.TabIndex = 13
        Me.Label36.Text = "Contraseña"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(197, 33)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(182, 26)
        Me.TextBox32.TabIndex = 12
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 39)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(124, 20)
        Me.Label37.TabIndex = 11
        Me.Label37.Text = "Nombre Usuario"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(108, 218)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(224, 61)
        Me.Button13.TabIndex = 10
        Me.Button13.Text = "Guardar Nueva Contraseña o Nuevo Tipo"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Teal
        Me.GroupBox8.Controls.Add(Me.Button12)
        Me.GroupBox8.Controls.Add(Me.TextBox13)
        Me.GroupBox8.Controls.Add(Me.TextBox14)
        Me.GroupBox8.Controls.Add(Me.TextBox15)
        Me.GroupBox8.Controls.Add(Me.TextBox16)
        Me.GroupBox8.Controls.Add(Me.TextBox17)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Controls.Add(Me.Label31)
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(17, 21)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(397, 236)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Datos Personales"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(138, 196)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(116, 34)
        Me.Button12.TabIndex = 10
        Me.Button12.Text = "Modificar Datos"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(126, 160)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(182, 26)
        Me.TextBox13.TabIndex = 9
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(126, 124)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(182, 26)
        Me.TextBox14.TabIndex = 8
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(126, 88)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(182, 26)
        Me.TextBox15.TabIndex = 7
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(126, 59)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(182, 26)
        Me.TextBox16.TabIndex = 6
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(126, 30)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(182, 26)
        Me.TextBox17.TabIndex = 5
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 160)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 20)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "E-Mail"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 124)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 20)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Teléfono"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 95)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 20)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Dni"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 59)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(65, 20)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Nombre"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(65, 20)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Apellido"
        '
        'btnUsuRegreso
        '
        Me.btnUsuRegreso.Location = New System.Drawing.Point(1156, 12)
        Me.btnUsuRegreso.Name = "btnUsuRegreso"
        Me.btnUsuRegreso.Size = New System.Drawing.Size(99, 34)
        Me.btnUsuRegreso.TabIndex = 1
        Me.btnUsuRegreso.Text = "Ventana Inicial"
        Me.btnUsuRegreso.UseVisualStyleBackColor = True
        '
        'frmGestionarUsuariosAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 536)
        Me.Controls.Add(Me.btnUsuRegreso)
        Me.Controls.Add(Me.tbcUsuarios)
        Me.Name = "frmGestionarUsuariosAdm"
        Me.Text = "Gestion De Empleados y Usuarios"
        Me.tbcUsuarios.ResumeLayout(False)
        Me.tpgNuevoEmp.ResumeLayout(False)
        Me.grbFiltradoEmpAdm.ResumeLayout(False)
        Me.grbFiltradoEmpAdm.PerformLayout()
        Me.grbEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNuevoUsuario.ResumeLayout(False)
        Me.grbNuevoUsuario.PerformLayout()
        Me.tpgNuevoUsu.ResumeLayout(False)
        Me.grbFiltradoEmpNuevoAdm.ResumeLayout(False)
        Me.grbFiltradoEmpNuevoAdm.PerformLayout()
        Me.grbEmNuevoUsuAdm.ResumeLayout(False)
        CType(Me.dgvEmpNuevoAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNuevoEmpAdm.ResumeLayout(False)
        Me.grbNuevoEmpAdm.PerformLayout()
        Me.tpgModUsu.ResumeLayout(False)
        Me.grbFiltradoModUsuAdm.ResumeLayout(False)
        Me.grbFiltradoModUsuAdm.PerformLayout()
        Me.grbModUsuAdm.ResumeLayout(False)
        Me.grbModUsuAdm.PerformLayout()
        Me.grbUsuModUsuAdm.ResumeLayout(False)
        CType(Me.dgvUsuariosActivosAdm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgModUsuActual.ResumeLayout(False)
        Me.grbCambioDatosUsu.ResumeLayout(False)
        Me.grbCambioDatosUsu.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcUsuarios As System.Windows.Forms.TabControl
    Friend WithEvents tpgNuevoEmp As System.Windows.Forms.TabPage
    Friend WithEvents grbFiltradoEmpAdm As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltrarEmp As System.Windows.Forms.Button
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents lblApeFiltradoEmp As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents lblDniFiltradoEmp As System.Windows.Forms.Label
    Friend WithEvents grbEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents grbNuevoUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarEmpleado As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMailEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblTelEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblDniEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblApellidoEmpleado As System.Windows.Forms.Label
    Friend WithEvents tpgNuevoUsu As System.Windows.Forms.TabPage
    Friend WithEvents tpgModUsu As System.Windows.Forms.TabPage
    Friend WithEvents btnUsuRegreso As System.Windows.Forms.Button
    Friend WithEvents btnAntEmp As System.Windows.Forms.Button
    Friend WithEvents btnSigEmp As System.Windows.Forms.Button
    Friend WithEvents grbFiltradoEmpNuevoAdm As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grbEmNuevoUsuAdm As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmpNuevoAdm As System.Windows.Forms.DataGridView
    Friend WithEvents grbNuevoEmpAdm As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbTiposUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents grbFiltradoModUsuAdm As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents grbModUsuAdm As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents grbUsuModUsuAdm As System.Windows.Forms.GroupBox
    Friend WithEvents dgvUsuariosActivosAdm As System.Windows.Forms.DataGridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnBajaAltaEmpleado As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colIdEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpgModUsuActual As System.Windows.Forms.TabPage
    Friend WithEvents grbCambioDatosUsu As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoModDatosUsu As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAntModUsuAdm As System.Windows.Forms.Button
    Friend WithEvents btnSigModUsuAdm As System.Windows.Forms.Button
    Friend WithEvents btnAltaBaja As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSigNuevoUsu As System.Windows.Forms.Button
    Friend WithEvents btnAnteNuevoUsu As System.Windows.Forms.Button
End Class
