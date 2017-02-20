<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.aux1 = New System.Windows.Forms.TextBox()
        Me.aux2 = New System.Windows.Forms.TextBox()
        Me.aux3 = New System.Windows.Forms.TextBox()
        Me.txtRaiz1 = New System.Windows.Forms.TextBox()
        Me.txtRaiz2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(155, 104)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(96, 52)
        Me.Calcular.TabIndex = 0
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Raiz 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Raiz 2"
        '
        'aux1
        '
        Me.aux1.Location = New System.Drawing.Point(51, 79)
        Me.aux1.Name = "aux1"
        Me.aux1.Size = New System.Drawing.Size(56, 20)
        Me.aux1.TabIndex = 6
        '
        'aux2
        '
        Me.aux2.Location = New System.Drawing.Point(51, 117)
        Me.aux2.Name = "aux2"
        Me.aux2.Size = New System.Drawing.Size(56, 20)
        Me.aux2.TabIndex = 7
        '
        'aux3
        '
        Me.aux3.Location = New System.Drawing.Point(51, 162)
        Me.aux3.Name = "aux3"
        Me.aux3.Size = New System.Drawing.Size(56, 20)
        Me.aux3.TabIndex = 8
        '
        'txtRaiz1
        '
        Me.txtRaiz1.Location = New System.Drawing.Point(317, 94)
        Me.txtRaiz1.Name = "txtRaiz1"
        Me.txtRaiz1.Size = New System.Drawing.Size(56, 20)
        Me.txtRaiz1.TabIndex = 9
        '
        'txtRaiz2
        '
        Me.txtRaiz2.Location = New System.Drawing.Point(317, 136)
        Me.txtRaiz2.Name = "txtRaiz2"
        Me.txtRaiz2.Size = New System.Drawing.Size(56, 20)
        Me.txtRaiz2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(318, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dada la formula general de las ecuc de seg grado : Ax^2+Bx+C=0"
        '
        'Form1
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(2, 4)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRaiz2)
        Me.Controls.Add(Me.txtRaiz1)
        Me.Controls.Add(Me.aux3)
        Me.Controls.Add(Me.aux2)
        Me.Controls.Add(Me.aux1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Calcular)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Form1"
        Me.Tag = "A"
        Me.Text = "hola"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents aux1 As TextBox
    Friend WithEvents aux2 As TextBox
    Friend WithEvents aux3 As TextBox
    Friend WithEvents txtRaiz1 As TextBox
    Friend WithEvents txtRaiz2 As TextBox
    Friend WithEvents Label6 As Label
End Class
