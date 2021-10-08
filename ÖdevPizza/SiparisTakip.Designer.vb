<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiparisTakip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiparisTakip))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.islem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pizza = New System.Windows.Forms.ComboBox()
        Me.menu2 = New System.Windows.Forms.ComboBox()
        Me.siparis_id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.icecek = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.siparis_id_delete = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.ÖdevPizza.My.Resources.Resources.delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(901, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 49)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Sipariş Sil"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(553, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Sipariş No:"
        '
        'islem
        '
        Me.islem.FormattingEnabled = True
        Me.islem.Items.AddRange(New Object() {"Beklemede", "Hazırlanıyor", "Hazır", "İptal"})
        Me.islem.Location = New System.Drawing.Point(75, 317)
        Me.islem.Name = "islem"
        Me.islem.Size = New System.Drawing.Size(113, 21)
        Me.islem.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "İşlem:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(61, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(434, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Sipariş silmek için Sipariş ID numarası yazarak siliniz!"
        '
        'pizza
        '
        Me.pizza.FormattingEnabled = True
        Me.pizza.Items.AddRange(New Object() {"Süperos (sos,mozarella peyniri, sosis, domates, zeytin, kekik, sucuk)", "Sucuksever (sos, mozarella peyniri, sucuk)", "New York (sos, mozarella peyniri, new york pepperoni)", "Bol Malzemos (sos, mozarella peyniri, pepperoni, yeşil biber, mantar, mısır, doma" &
                "tes, sucuk)", "Italiano (sos,mozarella peyniri, mantar, küp sucuk, kekik)", "Dopdolu Extra (sos, mozarella peyniri, beyaz peynir, meksika biberi, susam, manta" &
                "r, domates, yeşil biber)"})
        Me.pizza.Location = New System.Drawing.Point(73, 223)
        Me.pizza.Name = "pizza"
        Me.pizza.Size = New System.Drawing.Size(115, 21)
        Me.pizza.TabIndex = 16
        '
        'menu2
        '
        Me.menu2.FormattingEnabled = True
        Me.menu2.Items.AddRange(New Object() {"Dürümos Menü - (Ekmek Arası veya Dürümos + Patates + Coca-Cola 330 ml)", "Şampiyon Menü - (Büyük Dilim Pizza, 2li Chicken Fingers, 4lü Nuggets, 4lü Soğan H" &
                "alkası, Parmak Patates, Kutu İçecek)", "Aile Menü - (Büyük Boy Pizza, 2 adet patates, Coca-Cola 1 L)", "Zula Gamer Menü - (Orta Boy Pizza, Coca-Cola 1L veya Pepsi 1L)"})
        Me.menu2.Location = New System.Drawing.Point(73, 255)
        Me.menu2.Name = "menu2"
        Me.menu2.Size = New System.Drawing.Size(113, 21)
        Me.menu2.TabIndex = 15
        '
        'siparis_id
        '
        Me.siparis_id.Enabled = False
        Me.siparis_id.Location = New System.Drawing.Point(75, 19)
        Me.siparis_id.Name = "siparis_id"
        Me.siparis_id.Size = New System.Drawing.Size(113, 20)
        Me.siparis_id.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Sipariş ID:"
        '
        'icecek
        '
        Me.icecek.FormattingEnabled = True
        Me.icecek.Items.AddRange(New Object() {"Coca-Cola Pet 1 lt", "Fanta Pet 1 lt", "Sprite Pet 1 lt", "1 Lt Sütaş Ayran", "Coca-Cola Kutu 330 ml", "Sütaş Ayran 200 ml", "Fanta Kutu 330 ml", "Sprite Kutu 330 ml", "FuseTea Şeftali Kutu 330 ml", "FuseTea Şeftali Pet 1 lt"})
        Me.icecek.Location = New System.Drawing.Point(75, 285)
        Me.icecek.Name = "icecek"
        Me.icecek.Size = New System.Drawing.Size(113, 21)
        Me.icecek.TabIndex = 7
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(76, 131)
        Me.txtTel.Mask = "(999) 000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(112, 20)
        Me.txtTel.TabIndex = 3
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(48, 50)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(21, 13)
        Me.label7.TabIndex = 3
        Me.label7.Text = "ID:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(32, 162)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Adres:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.dataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 419)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(125, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(493, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Siparişlerini daha detaylı görmek için tabloda olanları tıklayın!"
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dataGridView1.Location = New System.Drawing.Point(11, 39)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(777, 365)
        Me.dataGridView1.TabIndex = 7
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Image = Global.ÖdevPizza.My.Resources.Resources.updateee
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(47, 364)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(137, 49)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Sipariş Düzenle"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(32, 258)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(37, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Menü:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Soyadı:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Adı:"
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(75, 160)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(113, 52)
        Me.txtAdres.TabIndex = 4
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(75, 103)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(113, 20)
        Me.txtSoyad.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(75, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(113, 20)
        Me.txtID.TabIndex = 0
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(75, 75)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(113, 20)
        Me.txtAd.TabIndex = 1
        '
        'siparis_id_delete
        '
        Me.siparis_id_delete.Location = New System.Drawing.Point(634, 23)
        Me.siparis_id_delete.Name = "siparis_id_delete"
        Me.siparis_id_delete.Size = New System.Drawing.Size(228, 20)
        Me.siparis_id_delete.TabIndex = 39
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(34, 226)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 13)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Pizza:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.pizza)
        Me.groupBox1.Controls.Add(Me.menu2)
        Me.groupBox1.Controls.Add(Me.siparis_id)
        Me.groupBox1.Controls.Add(Me.Label11)
        Me.groupBox1.Controls.Add(Me.icecek)
        Me.groupBox1.Controls.Add(Me.txtTel)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.islem)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.txtAdres)
        Me.groupBox1.Controls.Add(Me.txtSoyad)
        Me.groupBox1.Controls.Add(Me.txtID)
        Me.groupBox1.Controls.Add(Me.txtAd)
        Me.groupBox1.Location = New System.Drawing.Point(14, 59)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(224, 419)
        Me.groupBox1.TabIndex = 36
        Me.groupBox1.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(44, 135)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(25, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Tel:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "İçecek:"
        '
        'SiparisTakip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 486)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.siparis_id_delete)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SiparisTakip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sipariş İşlemleri"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Private WithEvents Label13 As Label
    Friend WithEvents islem As ComboBox
    Friend WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents pizza As ComboBox
    Friend WithEvents menu2 As ComboBox
    Friend WithEvents siparis_id As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents icecek As ComboBox
    Friend WithEvents txtTel As MaskedTextBox
    Private WithEvents label7 As Label
    Private WithEvents label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents Label12 As Label
    Public WithEvents dataGridView1 As DataGridView
    Private WithEvents button1 As Button
    Private WithEvents label6 As Label
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents txtAdres As TextBox
    Private WithEvents txtSoyad As TextBox
    Private WithEvents txtID As TextBox
    Private WithEvents txtAd As TextBox
    Friend WithEvents siparis_id_delete As TextBox
    Private WithEvents label5 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label3 As Label
    Private WithEvents Label8 As Label
End Class
