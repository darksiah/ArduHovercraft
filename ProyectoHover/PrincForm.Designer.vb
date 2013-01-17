<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Valdire = New System.Windows.Forms.Label()
        Me.ValTro = New System.Windows.Forms.Label()
        Me.ValPrinc = New System.Windows.Forms.Label()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Valdire)
        Me.Panel1.Controls.Add(Me.ValTro)
        Me.Panel1.Controls.Add(Me.ValPrinc)
        Me.Panel1.Controls.Add(Me.TrackBar3)
        Me.Panel1.Controls.Add(Me.TrackBar2)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 562)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Desconectado"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(96, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Prender"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Apagar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(15, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Conectar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Valdire
        '
        Me.Valdire.AutoSize = True
        Me.Valdire.BackColor = System.Drawing.Color.Transparent
        Me.Valdire.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valdire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Valdire.Location = New System.Drawing.Point(75, 411)
        Me.Valdire.Name = "Valdire"
        Me.Valdire.Size = New System.Drawing.Size(49, 31)
        Me.Valdire.TabIndex = 5
        Me.Valdire.Text = "Dir"
        '
        'ValTro
        '
        Me.ValTro.AutoSize = True
        Me.ValTro.BackColor = System.Drawing.Color.Transparent
        Me.ValTro.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValTro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ValTro.Location = New System.Drawing.Point(75, 302)
        Me.ValTro.Name = "ValTro"
        Me.ValTro.Size = New System.Drawing.Size(55, 31)
        Me.ValTro.TabIndex = 4
        Me.ValTro.Text = "Tro"
        '
        'ValPrinc
        '
        Me.ValPrinc.AutoSize = True
        Me.ValPrinc.BackColor = System.Drawing.Color.Transparent
        Me.ValPrinc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValPrinc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ValPrinc.Location = New System.Drawing.Point(75, 193)
        Me.ValPrinc.Name = "ValPrinc"
        Me.ValPrinc.Size = New System.Drawing.Size(67, 31)
        Me.ValPrinc.TabIndex = 3
        Me.ValPrinc.Text = "Elev"
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(15, 353)
        Me.TrackBar3.Maximum = 180
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(182, 45)
        Me.TrackBar3.SmallChange = 5
        Me.TrackBar3.TabIndex = 2
        Me.TrackBar3.TickFrequency = 10
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(12, 254)
        Me.TrackBar2.Maximum = 180
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(182, 45)
        Me.TrackBar2.SmallChange = 5
        Me.TrackBar2.TabIndex = 1
        Me.TrackBar2.TickFrequency = 10
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(12, 145)
        Me.TrackBar1.Maximum = 180
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(182, 45)
        Me.TrackBar1.SmallChange = 5
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickFrequency = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 562)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Location = New System.Drawing.Point(123, 145)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(375, 253)
        Me.TextBox1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'PrincForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "PrincForm"
        Me.Text = "Hovercraft Test"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Valdire As System.Windows.Forms.Label
    Friend WithEvents ValTro As System.Windows.Forms.Label
    Friend WithEvents ValPrinc As System.Windows.Forms.Label
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
