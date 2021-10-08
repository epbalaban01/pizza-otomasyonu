<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KullanıcıEkle
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KullanıcıEkle))
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.sifre = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.k_adi = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sifre
        '
        Me.sifre.Location = New System.Drawing.Point(78, 215)
        Me.sifre.Name = "sifre"
        Me.sifre.Size = New System.Drawing.Size(113, 20)
        Me.sifre.TabIndex = 5
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(35, 115)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Adres:"
        '
        'k_adi
        '
        Me.k_adi.Location = New System.Drawing.Point(78, 183)
        Me.k_adi.Name = "k_adi"
        Me.k_adi.Size = New System.Drawing.Size(113, 20)
        Me.k_adi.TabIndex = 4
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(5, 183)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 13)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Kullanıcı Adı:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(47, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(25, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Tel:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(32, 218)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(40, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Parola:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(30, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Soyadı:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(47, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Adı:"
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = Global.ÖdevPizza.My.Resources.Resources.add_userr
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(33, 281)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(164, 52)
        Me.button1.TabIndex = 22
        Me.button1.Text = "Kullanıcı Ekle"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(78, 115)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(113, 52)
        Me.txtAdres.TabIndex = 3
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(78, 58)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(113, 20)
        Me.txtSoyad.TabIndex = 1
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(78, 32)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(113, 20)
        Me.txtAd.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.ComboBox1)
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
        Me.groupBox1.Location = New System.Drawing.Point(12, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(236, 350)
        Me.groupBox1.TabIndex = 18
        Me.groupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"admin", "uye"})
        Me.ComboBox1.Location = New System.Drawing.Point(78, 251)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(78, 87)
        Me.txtTel.Mask = "(999) 000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(113, 20)
        Me.txtTel.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Yetki:"
        '
        'KullanıcıEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 365)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KullanıcıEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Ekle"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents timer1 As Timer
    Private WithEvents sifre As TextBox
    Private WithEvents label4 As Label
    Private WithEvents k_adi As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents label6 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
    Private WithEvents txtAdres As TextBox
    Private WithEvents txtSoyad As TextBox
    Private WithEvents txtAd As TextBox
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Private WithEvents Label7 As Label
End Class
