<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtRut = New TextBox()
        txtApellidos = New TextBox()
        txtNombres = New TextBox()
        txtCiudad = New TextBox()
        txtObservacion = New TextBox()
        cmbComunas = New ComboBox()
        Label8 = New Label()
        btBuscar = New Button()
        btGuardar = New Button()
        rbMasculino = New RadioButton()
        rbFemenino = New RadioButton()
        rbNoEs = New RadioButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellidos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(60, 318)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 3
        Label4.Text = "Comuna"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(60, 378)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 4
        Label5.Text = "Ciudad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 441)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 5
        Label6.Text = "Observacion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(118, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 15)
        Label7.TabIndex = 6
        Label7.Text = "Ejemplo:123456789"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(125, 52)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(100, 23)
        txtRut.TabIndex = 7
        ' 
        ' txtApellidos
        ' 
        txtApellidos.Location = New Point(125, 142)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.Size = New Size(255, 23)
        txtApellidos.TabIndex = 8
        ' 
        ' txtNombres
        ' 
        txtNombres.Location = New Point(125, 99)
        txtNombres.Name = "txtNombres"
        txtNombres.Size = New Size(255, 23)
        txtNombres.TabIndex = 9
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(125, 375)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(255, 23)
        txtCiudad.TabIndex = 10
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(125, 433)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(255, 23)
        txtObservacion.TabIndex = 11
        ' 
        ' cmbComunas
        ' 
        cmbComunas.FormattingEnabled = True
        cmbComunas.Location = New Point(125, 318)
        cmbComunas.Name = "cmbComunas"
        cmbComunas.Size = New Size(255, 23)
        cmbComunas.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(60, 227)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 15)
        Label8.TabIndex = 14
        Label8.Text = "Sexo"
        ' 
        ' btBuscar
        ' 
        btBuscar.Location = New Point(271, 51)
        btBuscar.Name = "btBuscar"
        btBuscar.Size = New Size(109, 23)
        btBuscar.TabIndex = 15
        btBuscar.Text = "Buscar"
        btBuscar.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(125, 497)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(109, 23)
        btGuardar.TabIndex = 16
        btGuardar.Text = "Guardar Mysql"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' rbMasculino
        ' 
        rbMasculino.AutoSize = True
        rbMasculino.Location = New Point(60, 262)
        rbMasculino.Name = "rbMasculino"
        rbMasculino.Size = New Size(80, 19)
        rbMasculino.TabIndex = 17
        rbMasculino.TabStop = True
        rbMasculino.Text = "Masculino"
        rbMasculino.UseVisualStyleBackColor = True
        ' 
        ' rbFemenino
        ' 
        rbFemenino.AutoSize = True
        rbFemenino.Location = New Point(163, 262)
        rbFemenino.Name = "rbFemenino"
        rbFemenino.Size = New Size(78, 19)
        rbFemenino.TabIndex = 18
        rbFemenino.TabStop = True
        rbFemenino.Text = "Femenino"
        rbFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbNoEs
        ' 
        rbNoEs.AutoSize = True
        rbNoEs.Location = New Point(266, 262)
        rbNoEs.Name = "rbNoEs"
        rbNoEs.Size = New Size(96, 19)
        rbNoEs.TabIndex = 19
        rbNoEs.TabStop = True
        rbNoEs.Text = "No especifica"
        rbNoEs.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(457, 572)
        Controls.Add(rbNoEs)
        Controls.Add(rbFemenino)
        Controls.Add(rbMasculino)
        Controls.Add(btGuardar)
        Controls.Add(btBuscar)
        Controls.Add(Label8)
        Controls.Add(cmbComunas)
        Controls.Add(txtObservacion)
        Controls.Add(txtCiudad)
        Controls.Add(txtNombres)
        Controls.Add(txtApellidos)
        Controls.Add(txtRut)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents cmbComunas As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents rbNoEs As RadioButton

End Class
