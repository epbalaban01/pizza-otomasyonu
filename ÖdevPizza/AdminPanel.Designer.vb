<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPanel))
        Me.label7 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.labeladi = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblyetki = New System.Windows.Forms.Label()
        Me.lblK_adi = New System.Windows.Forms.Label()
        Me.lblAdres = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblAdi = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.menuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(400, 37)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(27, 13)
        Me.label7.TabIndex = 26
        Me.label7.Text = "saat"
        '
        'button3
        '
        Me.button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Location = New System.Drawing.Point(336, 328)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(106, 41)
        Me.button3.TabIndex = 23
        Me.button3.Text = "Müşteri Paneli"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button1.Location = New System.Drawing.Point(15, 328)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(106, 41)
        Me.button1.TabIndex = 21
        Me.button1.Text = "Geçmiş Siparişler"
        Me.button1.UseVisualStyleBackColor = True
        '
        'timer1
        '
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem, Me.hakkındaToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.menuStrip1.TabIndex = 27
        Me.menuStrip1.Text = "menuStrip1"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'hakkındaToolStripMenuItem
        '
        Me.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem"
        Me.hakkındaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.hakkındaToolStripMenuItem.Text = "Hakkında"
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(15, 165)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 41)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Sipariş İşlemleri"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'labeladi
        '
        Me.labeladi.AutoSize = True
        Me.labeladi.Location = New System.Drawing.Point(12, 37)
        Me.labeladi.Name = "labeladi"
        Me.labeladi.Size = New System.Drawing.Size(10, 13)
        Me.labeladi.TabIndex = 32
        Me.labeladi.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblyetki)
        Me.GroupBox1.Controls.Add(Me.lblK_adi)
        Me.GroupBox1.Controls.Add(Me.lblAdres)
        Me.GroupBox1.Controls.Add(Me.lblTel)
        Me.GroupBox1.Controls.Add(Me.lblAdi)
        Me.GroupBox1.Controls.Add(Me.lblSoyad)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(467, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 342)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'lblyetki
        '
        Me.lblyetki.AutoSize = True
        Me.lblyetki.Location = New System.Drawing.Point(76, 306)
        Me.lblyetki.Name = "lblyetki"
        Me.lblyetki.Size = New System.Drawing.Size(10, 13)
        Me.lblyetki.TabIndex = 2
        Me.lblyetki.Text = "-"
        '
        'lblK_adi
        '
        Me.lblK_adi.AutoSize = True
        Me.lblK_adi.Location = New System.Drawing.Point(79, 282)
        Me.lblK_adi.Name = "lblK_adi"
        Me.lblK_adi.Size = New System.Drawing.Size(10, 13)
        Me.lblK_adi.TabIndex = 2
        Me.lblK_adi.Text = "-"
        '
        'lblAdres
        '
        Me.lblAdres.AutoSize = True
        Me.lblAdres.Location = New System.Drawing.Point(79, 259)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(10, 13)
        Me.lblAdres.TabIndex = 2
        Me.lblAdres.Text = "-"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(80, 236)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(10, 13)
        Me.lblTel.TabIndex = 2
        Me.lblTel.Text = "-"
        '
        'lblAdi
        '
        Me.lblAdi.AutoSize = True
        Me.lblAdi.Location = New System.Drawing.Point(80, 191)
        Me.lblAdi.Name = "lblAdi"
        Me.lblAdi.Size = New System.Drawing.Size(10, 13)
        Me.lblAdi.TabIndex = 2
        Me.lblAdi.Text = "-"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.Location = New System.Drawing.Point(79, 214)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(10, 13)
        Me.lblSoyad.TabIndex = 2
        Me.lblSoyad.Text = "-"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(80, 165)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(10, 13)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Yetki:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Kullanıcı Adı:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Adres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Soyadı:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adı:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ÖdevPizza.My.Resources.Resources.logojpg
        Me.PictureBox1.Location = New System.Drawing.Point(30, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'groupBox3
        '
        Me.groupBox3.Location = New System.Drawing.Point(12, 50)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(449, 10)
        Me.groupBox3.TabIndex = 35
        Me.groupBox3.TabStop = False
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(336, 165)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 41)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "Cari Yönetim"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(174, 165)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(106, 41)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "Kullanıcı İşlemleri"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ÖdevPizza.My.Resources.Resources.pizza
        Me.PictureBox2.Location = New System.Drawing.Point(336, 229)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 93)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ÖdevPizza.My.Resources.Resources.pizzasiparis
        Me.PictureBox6.Location = New System.Drawing.Point(15, 229)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(106, 93)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 39
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ÖdevPizza.My.Resources.Resources.web
        Me.PictureBox5.Location = New System.Drawing.Point(15, 66)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(106, 93)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ÖdevPizza.My.Resources.Resources.musteri
        Me.PictureBox4.Location = New System.Drawing.Point(174, 66)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(106, 93)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 39
        Me.PictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = Global.ÖdevPizza.My.Resources.Resources.gelir_gider
        Me.pictureBox3.Location = New System.Drawing.Point(336, 66)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(106, 93)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 39
        Me.pictureBox3.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Location = New System.Drawing.Point(572, 6)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 13)
        Me.LinkLabel1.TabIndex = 51
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Oturumdan Çık"
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 385)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.labeladi)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdminPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Panel"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Private WithEvents button3 As Button
    Private WithEvents button1 As Button
    Private WithEvents timer1 As Timer
    Private WithEvents contextMenuStrip1 As ContextMenuStrip
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents hakkındaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button6 As Button
    Friend WithEvents labeladi As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblyetki As Label
    Friend WithEvents lblK_adi As Label
    Friend WithEvents lblAdres As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblAdi As Label
    Friend WithEvents lblSoyad As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents groupBox3 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents PictureBox4 As PictureBox
    Private WithEvents PictureBox5 As PictureBox
    Private WithEvents PictureBox6 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
