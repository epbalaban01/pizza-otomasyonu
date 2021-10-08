<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminOdeme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminOdeme))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.toplamindirimodeme = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.icecek = New System.Windows.Forms.Label()
        Me.menu1 = New System.Windows.Forms.Label()
        Me.pizza = New System.Windows.Forms.Label()
        Me.buyuk = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.orta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kucuk = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sirket_toplam = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.toplamodeme = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tamamlanansiparis = New System.Windows.Forms.Label()
        Me.toplamkullanici = New System.Windows.Forms.Label()
        Me.toplamsiparis = New System.Windows.Forms.Label()
        Me.hazir = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Toplam Ödemeler:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Toplam İndirm Ödeme:"
        '
        'toplamindirimodeme
        '
        Me.toplamindirimodeme.AutoSize = True
        Me.toplamindirimodeme.Location = New System.Drawing.Point(145, 66)
        Me.toplamindirimodeme.Name = "toplamindirimodeme"
        Me.toplamindirimodeme.Size = New System.Drawing.Size(10, 13)
        Me.toplamindirimodeme.TabIndex = 39
        Me.toplamindirimodeme.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "İçecek Toplam Fiyat:"
        '
        'icecek
        '
        Me.icecek.AutoSize = True
        Me.icecek.Location = New System.Drawing.Point(137, 102)
        Me.icecek.Name = "icecek"
        Me.icecek.Size = New System.Drawing.Size(10, 13)
        Me.icecek.TabIndex = 1
        Me.icecek.Text = "-"
        '
        'menu1
        '
        Me.menu1.AutoSize = True
        Me.menu1.Location = New System.Drawing.Point(138, 66)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(10, 13)
        Me.menu1.TabIndex = 1
        Me.menu1.Text = "-"
        '
        'pizza
        '
        Me.pizza.AutoSize = True
        Me.pizza.Location = New System.Drawing.Point(137, 30)
        Me.pizza.Name = "pizza"
        Me.pizza.Size = New System.Drawing.Size(10, 13)
        Me.pizza.TabIndex = 1
        Me.pizza.Text = "-"
        '
        'buyuk
        '
        Me.buyuk.AutoSize = True
        Me.buyuk.Location = New System.Drawing.Point(242, 189)
        Me.buyuk.Name = "buyuk"
        Me.buyuk.Size = New System.Drawing.Size(10, 13)
        Me.buyuk.TabIndex = 38
        Me.buyuk.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pizza Toplam Fiyat:"
        '
        'orta
        '
        Me.orta.AutoSize = True
        Me.orta.Location = New System.Drawing.Point(156, 189)
        Me.orta.Name = "orta"
        Me.orta.Size = New System.Drawing.Size(10, 13)
        Me.orta.TabIndex = 38
        Me.orta.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Menü Toplam Fiyat:"
        '
        'kucuk
        '
        Me.kucuk.AutoSize = True
        Me.kucuk.Location = New System.Drawing.Point(82, 189)
        Me.kucuk.Name = "kucuk"
        Me.kucuk.Size = New System.Drawing.Size(10, 13)
        Me.kucuk.TabIndex = 38
        Me.kucuk.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Şirket Toplam Fiyat:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Büyük:"
        '
        'sirket_toplam
        '
        Me.sirket_toplam.AutoSize = True
        Me.sirket_toplam.Location = New System.Drawing.Point(137, 136)
        Me.sirket_toplam.Name = "sirket_toplam"
        Me.sirket_toplam.Size = New System.Drawing.Size(10, 13)
        Me.sirket_toplam.TabIndex = 1
        Me.sirket_toplam.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Orta:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.icecek)
        Me.GroupBox4.Controls.Add(Me.menu1)
        Me.GroupBox4.Controls.Add(Me.pizza)
        Me.GroupBox4.Controls.Add(Me.buyuk)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.orta)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.kucuk)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.sirket_toplam)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(388, 51)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(324, 241)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Giderler"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Pizza Boy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Küçük:"
        '
        'toplamodeme
        '
        Me.toplamodeme.AutoSize = True
        Me.toplamodeme.Location = New System.Drawing.Point(145, 30)
        Me.toplamodeme.Name = "toplamodeme"
        Me.toplamodeme.Size = New System.Drawing.Size(10, 13)
        Me.toplamodeme.TabIndex = 39
        Me.toplamodeme.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.toplamodeme)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tamamlanansiparis)
        Me.GroupBox2.Controls.Add(Me.toplamkullanici)
        Me.GroupBox2.Controls.Add(Me.toplamsiparis)
        Me.GroupBox2.Controls.Add(Me.toplamindirimodeme)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 241)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gelirler"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Tamamlanan Siparişler:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Kullanıcılar:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(60, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Toplam Sipariş:"
        '
        'tamamlanansiparis
        '
        Me.tamamlanansiparis.AutoSize = True
        Me.tamamlanansiparis.Location = New System.Drawing.Point(145, 166)
        Me.tamamlanansiparis.Name = "tamamlanansiparis"
        Me.tamamlanansiparis.Size = New System.Drawing.Size(10, 13)
        Me.tamamlanansiparis.TabIndex = 39
        Me.tamamlanansiparis.Text = "-"
        '
        'toplamkullanici
        '
        Me.toplamkullanici.AutoSize = True
        Me.toplamkullanici.Location = New System.Drawing.Point(145, 136)
        Me.toplamkullanici.Name = "toplamkullanici"
        Me.toplamkullanici.Size = New System.Drawing.Size(10, 13)
        Me.toplamkullanici.TabIndex = 39
        Me.toplamkullanici.Text = "-"
        '
        'toplamsiparis
        '
        Me.toplamsiparis.AutoSize = True
        Me.toplamsiparis.Location = New System.Drawing.Point(145, 102)
        Me.toplamsiparis.Name = "toplamsiparis"
        Me.toplamsiparis.Size = New System.Drawing.Size(10, 13)
        Me.toplamsiparis.TabIndex = 39
        Me.toplamsiparis.Text = "-"
        '
        'hazir
        '
        Me.hazir.AutoSize = True
        Me.hazir.Location = New System.Drawing.Point(165, 193)
        Me.hazir.Name = "hazir"
        Me.hazir.Size = New System.Drawing.Size(31, 13)
        Me.hazir.TabIndex = 43
        Me.hazir.Text = "Hazır"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ÖdevPizza.My.Resources.Resources.giderr
        Me.PictureBox1.Location = New System.Drawing.Point(618, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ÖdevPizza.My.Resources.Resources.gelirr
        Me.PictureBox2.Location = New System.Drawing.Point(259, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'AdminOdeme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 324)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.hazir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminOdeme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Yönetim"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents toplamindirimodeme As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents icecek As Label
    Friend WithEvents menu1 As Label
    Friend WithEvents pizza As Label
    Friend WithEvents buyuk As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents orta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents kucuk As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents sirket_toplam As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents toplamodeme As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents toplamsiparis As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents toplamkullanici As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tamamlanansiparis As Label
    Friend WithEvents hazir As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
