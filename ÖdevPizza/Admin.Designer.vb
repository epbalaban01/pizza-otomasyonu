<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Location = New System.Drawing.Point(147, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(271, 145)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(110, 24)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(140, 20)
        Me.textBox1.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.label2.Location = New System.Drawing.Point(53, 55)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 18)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Şifre:"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(110, 55)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(140, 20)
        Me.textBox2.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.label1.Location = New System.Drawing.Point(6, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(90, 18)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Kullanıcı Adı:"
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.button1.Location = New System.Drawing.Point(152, 89)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(98, 40)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Giriş Yap"
        Me.button1.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.ÖdevPizza.My.Resources.Resources.admin
        Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(116, 114)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 159)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents textBox2 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
    Private WithEvents pictureBox1 As PictureBox
End Class
