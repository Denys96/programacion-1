﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalario))
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.lblDescuentos = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarDescuento = New System.Windows.Forms.Button()
        Me.btnEliminarDescuento = New System.Windows.Forms.Button()
        Me.btnModificarDescuento = New System.Windows.Forms.Button()
        Me.btnAgregarDescuento = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosSalario = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblUsuario)
        Me.grbDatos.Controls.Add(Me.txtUsuario)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(13, 12)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(784, 117)
        Me.grbDatos.TabIndex = 9
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Usuario"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(20, 53)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(97, 20)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "USUARIO:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(211, 49)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(443, 22)
        Me.txtUsuario.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescuentos)
        Me.GroupBox1.Controls.Add(Me.lblDescuentos)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(13, 132)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Size = New System.Drawing.Size(784, 117)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Descuentos"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Location = New System.Drawing.Point(211, 49)
        Me.txtDescuentos.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(443, 22)
        Me.txtDescuentos.TabIndex = 5
        '
        'lblDescuentos
        '
        Me.lblDescuentos.AutoSize = True
        Me.lblDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentos.Location = New System.Drawing.Point(20, 53)
        Me.lblDescuentos.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescuentos.Name = "lblDescuentos"
        Me.lblDescuentos.Size = New System.Drawing.Size(141, 20)
        Me.lblDescuentos.TabIndex = 4
        Me.lblDescuentos.Text = "DESCUENTOS:"
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnEliminarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnModificarDescuento)
        Me.grbEdicion.Controls.Add(Me.btnAgregarDescuento)
        Me.grbEdicion.Location = New System.Drawing.Point(377, 283)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(420, 84)
        Me.grbEdicion.TabIndex = 71
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarDescuento
        '
        Me.btnBuscarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDescuento.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBuscarDescuento.Image = CType(resources.GetObject("btnBuscarDescuento.Image"), System.Drawing.Image)
        Me.btnBuscarDescuento.Location = New System.Drawing.Point(344, 23)
        Me.btnBuscarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarDescuento.Name = "btnBuscarDescuento"
        Me.btnBuscarDescuento.Size = New System.Drawing.Size(72, 48)
        Me.btnBuscarDescuento.TabIndex = 8
        Me.btnBuscarDescuento.UseVisualStyleBackColor = True
        '
        'btnEliminarDescuento
        '
        Me.btnEliminarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDescuento.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarDescuento.Image = CType(resources.GetObject("btnEliminarDescuento.Image"), System.Drawing.Image)
        Me.btnEliminarDescuento.Location = New System.Drawing.Point(244, 23)
        Me.btnEliminarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarDescuento.Name = "btnEliminarDescuento"
        Me.btnEliminarDescuento.Size = New System.Drawing.Size(83, 48)
        Me.btnEliminarDescuento.TabIndex = 7
        Me.btnEliminarDescuento.UseVisualStyleBackColor = True
        '
        'btnModificarDescuento
        '
        Me.btnModificarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDescuento.Location = New System.Drawing.Point(121, 23)
        Me.btnModificarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarDescuento.Name = "btnModificarDescuento"
        Me.btnModificarDescuento.Size = New System.Drawing.Size(120, 48)
        Me.btnModificarDescuento.TabIndex = 6
        Me.btnModificarDescuento.Text = "Modificar"
        Me.btnModificarDescuento.UseVisualStyleBackColor = True
        '
        'btnAgregarDescuento
        '
        Me.btnAgregarDescuento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDescuento.Location = New System.Drawing.Point(15, 23)
        Me.btnAgregarDescuento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarDescuento.Name = "btnAgregarDescuento"
        Me.btnAgregarDescuento.Size = New System.Drawing.Size(91, 48)
        Me.btnAgregarDescuento.TabIndex = 5
        Me.btnAgregarDescuento.Text = "Nuevo"
        Me.btnAgregarDescuento.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosSalario)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(14, 283)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(360, 84)
        Me.grbNavegacion.TabIndex = 70
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosSalario
        '
        Me.lblRegistrosSalario.AutoSize = True
        Me.lblRegistrosSalario.Location = New System.Drawing.Point(115, 42)
        Me.lblRegistrosSalario.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosSalario.Name = "lblRegistrosSalario"
        Me.lblRegistrosSalario.Size = New System.Drawing.Size(46, 17)
        Me.lblRegistrosSalario.TabIndex = 4
        Me.lblRegistrosSalario.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.Location = New System.Drawing.Point(301, 23)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(55, 48)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(249, 23)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(55, 48)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(56, 23)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(55, 48)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnPrimero.Image = CType(resources.GetObject("btnPrimero.Image"), System.Drawing.Image)
        Me.btnPrimero.Location = New System.Drawing.Point(3, 23)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(55, 48)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'frmSalario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(815, 377)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSalario"
        Me.Text = " Salario"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescuentos As TextBox
    Friend WithEvents lblDescuentos As Label
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarDescuento As Button
    Friend WithEvents btnEliminarDescuento As Button
    Friend WithEvents btnModificarDescuento As Button
    Friend WithEvents btnAgregarDescuento As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosSalario As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
End Class
