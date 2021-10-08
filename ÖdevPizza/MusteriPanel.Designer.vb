<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MusteriPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusteriPanel))
        Me.btnSepeteEkle = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YapıştırToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.id_no = New System.Windows.Forms.Label()
        Me.saat = New System.Windows.Forms.Label()
        Me.tarih = New System.Windows.Forms.Label()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.txtAdi = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNot = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSoyadi = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.numericUpDownPizza = New System.Windows.Forms.NumericUpDown()
        Me.comboBoxIcecek = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.comboBoxPizzaBoy = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblToplam = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDownMenu = New System.Windows.Forms.NumericUpDown()
        Me.numericUpDownIcecek = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tl = New System.Windows.Forms.Label()
        Me.islem = New System.Windows.Forms.Label()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.numericUpDownPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDownMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDownIcecek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSepeteEkle
        '
        Me.btnSepeteEkle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSepeteEkle.Location = New System.Drawing.Point(360, 228)
        Me.btnSepeteEkle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSepeteEkle.Name = "btnSepeteEkle"
        Me.btnSepeteEkle.Size = New System.Drawing.Size(93, 39)
        Me.btnSepeteEkle.TabIndex = 85
        Me.btnSepeteEkle.Text = "Sepete Ekle"
        Me.btnSepeteEkle.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button3.Enabled = False
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Location = New System.Drawing.Point(647, 476)
        Me.button3.Margin = New System.Windows.Forms.Padding(2)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(140, 52)
        Me.button3.TabIndex = 9
        Me.button3.Text = "Sipariş Tamamla"
        Me.button3.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(9, 310)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(447, 108)
        Me.listBox1.TabIndex = 0
        '
        'button2
        '
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(259, 227)
        Me.button2.Margin = New System.Windows.Forms.Padding(2)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(93, 41)
        Me.button2.TabIndex = 86
        Me.button2.Text = "Sepeti Temizle"
        Me.button2.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.groupBox1.Controls.Add(Me.Label16)
        Me.groupBox1.Controls.Add(Me.id_no)
        Me.groupBox1.Controls.Add(Me.saat)
        Me.groupBox1.Controls.Add(Me.tarih)
        Me.groupBox1.Controls.Add(Me.txtAdres)
        Me.groupBox1.Controls.Add(Me.txtAdi)
        Me.groupBox1.Controls.Add(Me.GroupBox3)
        Me.groupBox1.Controls.Add(Me.txtTel)
        Me.groupBox1.Controls.Add(Me.Label17)
        Me.groupBox1.Controls.Add(Me.Label21)
        Me.groupBox1.Controls.Add(Me.txtNot)
        Me.groupBox1.Controls.Add(Me.Label11)
        Me.groupBox1.Controls.Add(Me.txtSoyadi)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.Label14)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Enabled = False
        Me.groupBox1.Location = New System.Drawing.Point(495, 99)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Size = New System.Drawing.Size(445, 194)
        Me.groupBox1.TabIndex = 83
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Müşteri Bilgisi"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KopyalaToolStripMenuItem, Me.YapıştırToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 48)
        '
        'KopyalaToolStripMenuItem
        '
        Me.KopyalaToolStripMenuItem.Name = "KopyalaToolStripMenuItem"
        Me.KopyalaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.KopyalaToolStripMenuItem.Text = "Kopyala"
        '
        'YapıştırToolStripMenuItem
        '
        Me.YapıştırToolStripMenuItem.Name = "YapıştırToolStripMenuItem"
        Me.YapıştırToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.YapıştırToolStripMenuItem.Text = "Yapıştır"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(402, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 100
        Me.Label16.Text = "ID:"
        '
        'id_no
        '
        Me.id_no.AutoSize = True
        Me.id_no.Location = New System.Drawing.Point(425, 20)
        Me.id_no.Name = "id_no"
        Me.id_no.Size = New System.Drawing.Size(10, 13)
        Me.id_no.TabIndex = 99
        Me.id_no.Text = "-"
        '
        'saat
        '
        Me.saat.AutoSize = True
        Me.saat.Location = New System.Drawing.Point(234, 20)
        Me.saat.Name = "saat"
        Me.saat.Size = New System.Drawing.Size(10, 13)
        Me.saat.TabIndex = 103
        Me.saat.Text = "-"
        '
        'tarih
        '
        Me.tarih.AutoSize = True
        Me.tarih.Location = New System.Drawing.Point(42, 20)
        Me.tarih.Name = "tarih"
        Me.tarih.Size = New System.Drawing.Size(10, 13)
        Me.tarih.TabIndex = 103
        Me.tarih.Text = "-"
        '
        'txtAdres
        '
        Me.txtAdres.Location = New System.Drawing.Point(64, 121)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(167, 57)
        Me.txtAdres.TabIndex = 10
        '
        'txtAdi
        '
        Me.txtAdi.Location = New System.Drawing.Point(64, 53)
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.Size = New System.Drawing.Size(121, 20)
        Me.txtAdi.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(6, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 3)
        Me.GroupBox3.TabIndex = 100
        Me.GroupBox3.TabStop = False
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(64, 79)
        Me.txtTel.Mask = "(999) 000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(121, 20)
        Me.txtTel.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(202, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Saat:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 98
        Me.Label21.Text = "Tarih:"
        '
        'txtNot
        '
        Me.txtNot.Location = New System.Drawing.Point(276, 121)
        Me.txtNot.Multiline = True
        Me.txtNot.Name = "txtNot"
        Me.txtNot.Size = New System.Drawing.Size(147, 57)
        Me.txtNot.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(240, 56)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Soyadı:"
        '
        'txtSoyadi
        '
        Me.txtSoyadi.Location = New System.Drawing.Point(287, 53)
        Me.txtSoyadi.Name = "txtSoyadi"
        Me.txtSoyadi.Size = New System.Drawing.Size(121, 20)
        Me.txtSoyadi.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 82)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Telefon:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(34, 56)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Adı:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(244, 121)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Not:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(23, 127)
        Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Adres:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(357, 16)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 0
        Me.label4.Text = "İçecek:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(56, 181)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Pizza Boy:"
        '
        'numericUpDownPizza
        '
        Me.numericUpDownPizza.Cursor = System.Windows.Forms.Cursors.Hand
        Me.numericUpDownPizza.Location = New System.Drawing.Point(52, 228)
        Me.numericUpDownPizza.Margin = New System.Windows.Forms.Padding(2)
        Me.numericUpDownPizza.Name = "numericUpDownPizza"
        Me.numericUpDownPizza.Size = New System.Drawing.Size(95, 20)
        Me.numericUpDownPizza.TabIndex = 2
        '
        'comboBoxIcecek
        '
        Me.comboBoxIcecek.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboBoxIcecek.FormattingEnabled = True
        Me.comboBoxIcecek.Items.AddRange(New Object() {"Coca-Cola Pet 1 lt", "Fanta Pet 1 lt", "Sprite Pet 1 lt", "1 Lt Sütaş Ayran", "Coca-Cola Kutu 330 ml", "Sütaş Ayran 200 ml", "Fanta Kutu 330 ml", "Sprite Kutu 330 ml", "FuseTea Şeftali Kutu 330 ml", "FuseTea Şeftali Pet 1 lt"})
        Me.comboBoxIcecek.Location = New System.Drawing.Point(320, 33)
        Me.comboBoxIcecek.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBoxIcecek.Name = "comboBoxIcecek"
        Me.comboBoxIcecek.Size = New System.Drawing.Size(131, 21)
        Me.comboBoxIcecek.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(16, 230)
        Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(32, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Adet:"
        '
        'comboBoxPizzaBoy
        '
        Me.comboBoxPizzaBoy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboBoxPizzaBoy.FormattingEnabled = True
        Me.comboBoxPizzaBoy.Items.AddRange(New Object() {"Küçük", "Orta", "Büyük"})
        Me.comboBoxPizzaBoy.Location = New System.Drawing.Point(16, 196)
        Me.comboBoxPizzaBoy.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBoxPizzaBoy.Name = "comboBoxPizzaBoy"
        Me.comboBoxPizzaBoy.Size = New System.Drawing.Size(131, 21)
        Me.comboBoxPizzaBoy.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Süperos (sos,mozarella peyniri, sosis, domates, zeytin, kekik, sucuk)", "Sucuksever (sos, mozarella peyniri, sucuk)", "New York (sos, mozarella peyniri, new york pepperoni)", "Bol Malzemos (sos, mozarella peyniri, pepperoni, yeşil biber, mantar, mısır, doma" &
                "tes, sucuk)", "Italiano (sos,mozarella peyniri, mantar, küp sucuk, kekik)", "Dopdolu Extra (sos, mozarella peyniri, beyaz peynir, meksika biberi, susam, manta" &
                "r, domates, yeşil biber)"})
        Me.ComboBox2.Location = New System.Drawing.Point(16, 33)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.lblToplam)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.listBox1)
        Me.GroupBox2.Controls.Add(Me.PictureBox8)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.NumericUpDownMenu)
        Me.GroupBox2.Controls.Add(Me.numericUpDownIcecek)
        Me.GroupBox2.Controls.Add(Me.label3)
        Me.GroupBox2.Controls.Add(Me.numericUpDownPizza)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btnSepeteEkle)
        Me.GroupBox2.Controls.Add(Me.comboBoxIcecek)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.button2)
        Me.GroupBox2.Controls.Add(Me.label7)
        Me.GroupBox2.Controls.Add(Me.comboBoxPizzaBoy)
        Me.GroupBox2.Controls.Add(Me.tl)
        Me.GroupBox2.Controls.Add(Me.islem)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 471)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(3, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(465, 2)
        Me.GroupBox4.TabIndex = 97
        Me.GroupBox4.TabStop = False
        '
        'lblToplam
        '
        Me.lblToplam.AutoSize = True
        Me.lblToplam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblToplam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplam.Location = New System.Drawing.Point(403, 436)
        Me.lblToplam.Name = "lblToplam"
        Me.lblToplam.Size = New System.Drawing.Size(10, 13)
        Me.lblToplam.TabIndex = 98
        Me.lblToplam.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(324, 436)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "Toplam Tutar: "
        '
        'ComboBox3
        '
        Me.ComboBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Dürümos Menü - (Ekmek Arası veya Dürümos + Patates + Coca-Cola 330 ml)", "Şampiyon Menü - (Büyük Dilim Pizza, 2li Chicken Fingers, 4lü Nuggets, 4lü Soğan H" &
                "alkası, Parmak Patates, Kutu İçecek)", "Aile Menü - (Büyük Boy Pizza, 2 adet patates, Coca-Cola 1 L)", "Zula Gamer Menü - (Orta Boy Pizza, Coca-Cola 1L veya Pepsi 1L)"})
        Me.ComboBox3.Location = New System.Drawing.Point(168, 33)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(131, 21)
        Me.ComboBox3.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(195, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Menü Seçiniz:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Pizza:"
        '
        'NumericUpDownMenu
        '
        Me.NumericUpDownMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NumericUpDownMenu.Location = New System.Drawing.Point(204, 196)
        Me.NumericUpDownMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownMenu.Name = "NumericUpDownMenu"
        Me.NumericUpDownMenu.Size = New System.Drawing.Size(95, 20)
        Me.NumericUpDownMenu.TabIndex = 4
        '
        'numericUpDownIcecek
        '
        Me.numericUpDownIcecek.Cursor = System.Windows.Forms.Cursors.Hand
        Me.numericUpDownIcecek.Location = New System.Drawing.Point(356, 196)
        Me.numericUpDownIcecek.Margin = New System.Windows.Forms.Padding(2)
        Me.numericUpDownIcecek.Name = "numericUpDownIcecek"
        Me.numericUpDownIcecek.Size = New System.Drawing.Size(95, 20)
        Me.numericUpDownIcecek.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(204, 288)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Sipariş Listesi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Adet:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(320, 198)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(32, 13)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Adet:"
        '
        'tl
        '
        Me.tl.AutoSize = True
        Me.tl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tl.Location = New System.Drawing.Point(423, 436)
        Me.tl.Name = "tl"
        Me.tl.Size = New System.Drawing.Size(28, 13)
        Me.tl.TabIndex = 98
        Me.tl.Text = "       "
        '
        'islem
        '
        Me.islem.AutoSize = True
        Me.islem.Location = New System.Drawing.Point(87, 341)
        Me.islem.Name = "islem"
        Me.islem.Size = New System.Drawing.Size(60, 13)
        Me.islem.TabIndex = 99
        Me.islem.Text = "Beklemede"
        '
        'groupBox9
        '
        Me.groupBox9.Location = New System.Drawing.Point(602, 295)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(2, 158)
        Me.groupBox9.TabIndex = 97
        Me.groupBox9.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(728, 300)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(2, 158)
        Me.GroupBox5.TabIndex = 97
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(835, 300)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(2, 158)
        Me.GroupBox6.TabIndex = 97
        Me.GroupBox6.TabStop = False
        '
        'Timer1
        '
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ÖdevPizza.My.Resources.Resources.pizza_logo
        Me.PictureBox7.Location = New System.Drawing.Point(102, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(755, 91)
        Me.PictureBox7.TabIndex = 99
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.ÖdevPizza.My.Resources.Resources.pizzahut
        Me.PictureBox6.Location = New System.Drawing.Point(611, 300)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(113, 91)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 96
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.ÖdevPizza.My.Resources.Resources.pizzabuls
        Me.PictureBox5.Location = New System.Drawing.Point(827, 300)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(124, 78)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 96
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.ÖdevPizza.My.Resources.Resources.little_caesarss
        Me.PictureBox4.Location = New System.Drawing.Point(732, 300)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 110)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 96
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.ÖdevPizza.My.Resources.Resources.dominos
        Me.PictureBox3.Location = New System.Drawing.Point(495, 300)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 137)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 96
        Me.PictureBox3.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ÖdevPizza.My.Resources.Resources.drink_icon
        Me.PictureBox8.Location = New System.Drawing.Point(327, 68)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(114, 110)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 96
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ÖdevPizza.My.Resources.Resources.pizza_menu_3_1047816
        Me.PictureBox2.Location = New System.Drawing.Point(168, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 121)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 96
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.ÖdevPizza.My.Resources.Resources.pizzaa
        Me.PictureBox1.Location = New System.Drawing.Point(16, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'MusteriPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 577)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.groupBox9)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MusteriPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sipariş"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.numericUpDownPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDownMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDownIcecek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSepeteEkle As Button
    Private WithEvents button3 As Button
    Private WithEvents listBox1 As ListBox
    Private WithEvents button2 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents numericUpDownPizza As NumericUpDown
    Private WithEvents label2 As Label
    Private WithEvents comboBoxIcecek As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents label1 As Label
    Private WithEvents comboBoxPizzaBoy As ComboBox
    Private WithEvents label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Private WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label9 As Label
    Private WithEvents Label14 As Label
    Private WithEvents Label13 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Private WithEvents NumericUpDownMenu As NumericUpDown
    Private WithEvents numericUpDownIcecek As NumericUpDown
    Private WithEvents Label8 As Label
    Private WithEvents label7 As Label
    Friend WithEvents Label15 As Label
    Private WithEvents lblToplam As Label
    Friend WithEvents id_no As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tarih As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents Label21 As Label
    Private WithEvents GroupBox4 As GroupBox
    Private WithEvents groupBox9 As GroupBox
    Private WithEvents GroupBox5 As GroupBox
    Private WithEvents GroupBox6 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents KopyalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YapıştırToolStripMenuItem As ToolStripMenuItem
    Private WithEvents tl As Label
    Friend WithEvents saat As Label
    Private WithEvents Label17 As Label
    Friend WithEvents txtSoyadi As TextBox
    Friend WithEvents txtNot As TextBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents txtAdres As TextBox
    Friend WithEvents txtAdi As TextBox
    Friend WithEvents islem As Label
    Private WithEvents PictureBox7 As PictureBox
End Class
