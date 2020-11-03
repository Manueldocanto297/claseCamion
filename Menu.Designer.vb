<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtChapa = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkVenta = New System.Windows.Forms.CheckBox()
        Me.btnRevision = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(117, 179)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(145, 47)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtChapa
        '
        Me.txtChapa.Location = New System.Drawing.Point(88, 39)
        Me.txtChapa.Name = "txtChapa"
        Me.txtChapa.Size = New System.Drawing.Size(228, 20)
        Me.txtChapa.TabIndex = 1
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(88, 76)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(228, 20)
        Me.txtColor.TabIndex = 2
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(88, 111)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(228, 20)
        Me.txtAnio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Chapa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Año"
        '
        'chkVenta
        '
        Me.chkVenta.AutoSize = True
        Me.chkVenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkVenta.Location = New System.Drawing.Point(136, 156)
        Me.chkVenta.Name = "chkVenta"
        Me.chkVenta.Size = New System.Drawing.Size(107, 17)
        Me.chkVenta.TabIndex = 10
        Me.chkVenta.Text = "¿Está a la venta?"
        Me.chkVenta.UseVisualStyleBackColor = True
        '
        'btnRevision
        '
        Me.btnRevision.Location = New System.Drawing.Point(117, 232)
        Me.btnRevision.Name = "btnRevision"
        Me.btnRevision.Size = New System.Drawing.Size(145, 23)
        Me.btnRevision.TabIndex = 11
        Me.btnRevision.Text = "Revision"
        Me.btnRevision.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(387, 270)
        Me.Controls.Add(Me.btnRevision)
        Me.Controls.Add(Me.chkVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtChapa)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "Menu"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtChapa As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkVenta As CheckBox
    Friend WithEvents btnRevision As Button
End Class
