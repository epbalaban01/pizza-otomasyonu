<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KullanıcıBilgileri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KullanıcıBilgileri))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label9 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.sifre = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.k_adi = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dataGridView1)
        Me.GroupBox2.Controls.Add(Me.label9)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(715, 370)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dataGridView1.Location = New System.Drawing.Point(10, 44)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(696, 310)
        Me.dataGridView1.TabIndex = 24
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Silver
        Me.label9.Location = New System.Drawing.Point(66, 18)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(563, 20)
        Me.label9.TabIndex = 25
        Me.label9.Text = "Güncelleme İşlemi İçin Tabloda Olanları Seçerek Solda Güncelleyiniz!"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.ComboBox1)
        Me.groupBox1.Controls.Add(Me.txtTel)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.sifre)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.k_adi)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtAdres)
        Me.groupBox1.Controls.Add(Me.txtSoyad)
        Me.groupBox1.Controls.Add(Me.txtID)
        Me.groupBox1.Controls.Add(Me.txtAd)
        Me.groupBox1.Location = New System.Drawing.Point(16, 125)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(236, 370)
        Me.groupBox1.TabIndex = 27
        Me.groupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(78, 261)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(79, 98)
        Me.txtTel.Mask = "(999) 000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(112, 20)
        Me.txtTel.TabIndex = 3
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = Global.ÖdevPizza.My.Resources.Resources.updateee
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(33, 302)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(164, 52)
        Me.button1.TabIndex = 26
        Me.button1.Text = "Kullanıcı Güncelle"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(51, 23)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(21, 13)
        Me.label7.TabIndex = 3
        Me.label7.Text = "ID:"
        '
        'sifre
        '
        Me.sifre.Location = New System.Drawing.Point(78, 227)
        Me.sifre.Name = "sifre"
        Me.sifre.Size = New System.Drawing.Size(113, 20)
        Me.sifre.TabIndex = 6
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(35, 127)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Adres:"
        '
        'k_adi
        '
        Me.k_adi.Location = New System.Drawing.Point(78, 195)
        Me.k_adi.Name = "k_adi"
        Me.k_adi.Size = New System.Drawing.Size(113, 20)
        Me.k_adi.TabIndex = 5
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(5, 195)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 13)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Kullanıcı Adı:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(47, 99)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(25, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Tel:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Yetki:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(32, 230)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(40, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Parola:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(30, 73)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Soyadı:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(47, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Adı:"
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(78, 127)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(113, 52)
        Me.txtAdres.TabIndex = 4
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(78, 70)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(113, 20)
        Me.txtSoyad.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(78, 20)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(113, 20)
        Me.txtID.TabIndex = 0
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(78, 44)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(113, 20)
        Me.txtAd.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.ÖdevPizza.My.Resources.Resources.delete_user
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(336, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 52)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Kullanıcı Sil"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Location = New System.Drawing.Point(558, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 107)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button3.Image = Global.ÖdevPizza.My.Resources.Resources.add_userr
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(21, 42)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 52)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Kullanıcı Ekle"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = Global.ÖdevPizza.My.Resources.Resources.rehber
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(235, 42)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(164, 52)
        Me.Button11.TabIndex = 34
        Me.Button11.Text = "Kullanıcı Bilgileri"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(527, 107)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(228, 20)
        Me.TextBox2.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Adı Araması:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(71, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(375, 20)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Kullanıcı silmek için sadece adı yazarak siliniz!"
        '
        'KullanıcıBilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 508)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KullanıcıBilgileri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı İşlemleri"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents label9 As Label
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtTel As MaskedTextBox
    Private WithEvents button1 As Button
    Private WithEvents label7 As Label
    Private WithEvents sifre As TextBox
    Private WithEvents label4 As Label
    Private WithEvents k_adi As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents Label8 As Label
    Private WithEvents label6 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtAdres As TextBox
    Private WithEvents txtSoyad As TextBox
    Private WithEvents txtID As TextBox
    Private WithEvents txtAd As TextBox
    Private WithEvents Button2 As Button
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Private WithEvents Button3 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
End Class
