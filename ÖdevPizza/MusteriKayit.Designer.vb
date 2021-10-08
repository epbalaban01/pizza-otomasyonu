<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MusteriKayit
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusteriKayit))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.yetki = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.sifre = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.k_adi = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.yetki)
        Me.groupBox1.Controls.Add(Me.txtTel)
        Me.groupBox1.Controls.Add(Me.sifre)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.k_adi)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtAdres)
        Me.groupBox1.Controls.Add(Me.txtSoyad)
        Me.groupBox1.Controls.Add(Me.txtAd)
        Me.groupBox1.Location = New System.Drawing.Point(12, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(226, 341)
        Me.groupBox1.TabIndex = 19
        Me.groupBox1.TabStop = False
        '
        'yetki
        '
        Me.yetki.Enabled = False
        Me.yetki.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.yetki.Location = New System.Drawing.Point(85, 236)
        Me.yetki.Name = "yetki"
        Me.yetki.Size = New System.Drawing.Size(113, 20)
        Me.yetki.TabIndex = 6
        Me.yetki.Text = "uye"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(85, 74)
        Me.txtTel.Mask = "(999) 000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(113, 20)
        Me.txtTel.TabIndex = 2
        '
        'sifre
        '
        Me.sifre.Location = New System.Drawing.Point(85, 202)
        Me.sifre.Name = "sifre"
        Me.sifre.Size = New System.Drawing.Size(113, 20)
        Me.sifre.TabIndex = 5
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(57, 279)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(115, 38)
        Me.button1.TabIndex = 22
        Me.button1.Text = "Kayıt Ol"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(42, 102)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Adres:"
        '
        'k_adi
        '
        Me.k_adi.Location = New System.Drawing.Point(85, 170)
        Me.k_adi.Name = "k_adi"
        Me.k_adi.Size = New System.Drawing.Size(113, 20)
        Me.k_adi.TabIndex = 4
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 170)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 13)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Kullanıcı Adı:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(54, 74)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(25, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Tel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Yetki:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(39, 205)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(40, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Parola:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(37, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Soyadı:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(54, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Adı:"
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(85, 102)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(113, 52)
        Me.txtAdres.TabIndex = 3
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(85, 45)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(113, 20)
        Me.txtSoyad.TabIndex = 1
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(85, 19)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(113, 20)
        Me.txtAd.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MusteriKayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 353)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MusteriKayit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kayıt Ol"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents txtTel As MaskedTextBox
    Private WithEvents sifre As TextBox
    Private WithEvents button1 As Button
    Private WithEvents label4 As Label
    Private WithEvents k_adi As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents label6 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtAdres As TextBox
    Private WithEvents txtSoyad As TextBox
    Private WithEvents txtAd As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents yetki As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
