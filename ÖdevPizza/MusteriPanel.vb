Imports System.Data.OleDb
Imports System.IO
Public Class MusteriPanel

    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")

    Dim oku As OleDbDataReader
    Dim cmd As OleDbCommand
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Süperos (sos,mozarella peyniri, sosis, domates, zeytin, kekik, sucuk)" Then
            PictureBox1.Image = My.Resources.süperos

        ElseIf ComboBox2.Text = "Sucuksever (sos, mozarella peyniri, sucuk)" Then
            PictureBox1.Image = My.Resources.sucuksever

        ElseIf ComboBox2.Text = "New York (sos, mozarella peyniri, new york pepperoni)" Then
            PictureBox1.Image = My.Resources.newyork

        ElseIf ComboBox2.Text = "Bol Malzemos (sos, mozarella peyniri, pepperoni, yeşil biber, mantar, mısır, domates, sucuk)" Then
            PictureBox1.Image = My.Resources.bolmalzeme

        ElseIf ComboBox2.Text = "Italiano (sos,mozarella peyniri, mantar, küp sucuk, kekik)" Then
            PictureBox1.Image = My.Resources.italinoa

        ElseIf ComboBox2.Text = "Dopdolu Extra (sos, mozarella peyniri, beyaz peynir, meksika biberi, susam, mantar, domates, yeşil biber)" Then
            PictureBox1.Image = My.Resources.dopdoluextra
        End If



    End Sub


    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click

        'veritabanı

        baglanti.Open()
        Dim komutlar As New OleDbCommand("insert into siparis1(k_id,adi,soyadi,tel,adres,aciklama,pizza,pizzaboy,pizzaadet,icecek,icecekadet,menu,menuadet,odeme,tarih,saat,islem) values(

'" + id_no.Text + "',
'" + txtAdi.Text + "',
'" + txtSoyadi.Text + "',
'" + txtTel.Text + "',
'" + txtAdres.Text + "',
'" + txtNot.Text + "',
'" + ComboBox2.Text + "',
'" + comboBoxPizzaBoy.Text + "',
'" + numericUpDownPizza.Text + "',
'" + comboBoxIcecek.Text + "',
'" + numericUpDownIcecek.Text + "',
'" + ComboBox3.Text + "',
'" + NumericUpDownMenu.Text + "',
'" + lblToplam.Text + "',
'" + tarih.Text + "',
'" + saat.Text + "',
'" + islem.Text + "'
)", baglanti)
        komutlar.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Sipariş Kayıt Eklendi!", "Sipariş Kayıt")
        delete()

        Me.Hide()





        'ödeme alanı
        Dim odeme As New Odeme
        odeme.lblToplam.Text = lblToplam.Text
        odeme.id.Text = id_no.Text
        odeme.adi.Text = txtAdi.Text
        odeme.soyadi.Text = txtSoyadi.Text
        odeme.tl.Text = tl.Text
        odeme.Show()



    End Sub


    Private Sub MusteriPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tarih.Text = DateTime.Now.ToString("dd/MM/yyyy")
        saat.Text = DateTime.Now.ToString("HH:mm")
        Dim timer As New Timer()
        timer.Interval = 1000
        AddHandler timer.Tick, AddressOf timer1_Tick
        timer.Start()

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.tarih.Refresh()
        Me.saat.Refresh()

        tarih.Text = DateTime.Now.ToString("dd/MM/yyyy")
        saat.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub btnSepeteEkle_Click(sender As Object, e As EventArgs) Handles btnSepeteEkle.Click
        groupBox1.Enabled = True
        button3.Enabled = True


        listBox1.Items.Add("Pizza: " + numericUpDownPizza.Value.ToString + " adet " + comboBoxPizzaBoy.Text + "Boy " + ComboBox2.Text)
        listBox1.Items.Add("Menü: " + NumericUpDownMenu.Value.ToString + " adet " + ComboBox3.Text)
        listBox1.Items.Add("İçecek: " + numericUpDownIcecek.Value.ToString + " adet " + comboBoxIcecek.Text)


        Dim icecek As String = 0
        Dim boy As String = 0
        Dim menu As String = 0
        Dim pizza As String = 0
        Dim ucret As String

        If comboBoxPizzaBoy.Text = "Küçük" Then
            boy = numericUpDownPizza.Value * 25
        ElseIf comboBoxPizzaBoy.Text = "Orta" Then
            boy = numericUpDownPizza.Value * 40
        ElseIf comboBoxPizzaBoy.Text = "Büyük" Then
            boy = numericUpDownPizza.Value * 50
        End If

        If ComboBox3.Text = "Dürümos Menü - (Ekmek Arası veya Dürümos + Patates + Coca-Cola 330 ml)" Then
            menu = NumericUpDownMenu.Value * 22
        ElseIf ComboBox3.Text = "Şampiyon Menü - (Büyük Dilim Pizza, 2li Chicken Fingers, 4lü Nuggets, 4lü Soğan Halkası, Parmak Patates, Kutu İçecek)" Then
            menu = NumericUpDownMenu.Value * 35
        ElseIf ComboBox3.Text = "Aile Menü - (Büyük Boy Pizza, 2 adet patates, Coca-Cola 1 L)" Then
            menu = NumericUpDownMenu.Value * 85
        ElseIf ComboBox3.Text = "Zula Gamer Menü - (Orta Boy Pizza, Coca-Cola 1L veya Pepsi 1L)" Then
            menu = NumericUpDownMenu.Value * 40
        End If

        If ComboBox2.Text = "Süperos (sos,mozarella peyniri, sosis, domates, zeytin, kekik, sucuk)" Then
            pizza = 20

        ElseIf ComboBox2.Text = "Sucuksever (sos, mozarella peyniri, sucuk)" Then
            pizza = 22
        ElseIf ComboBox2.Text = "New York (sos, mozarella peyniri, new york pepperoni)" Then
            pizza = 24
        ElseIf ComboBox2.Text = "Bol Malzemos (sos, mozarella peyniri, pepperoni, yeşil biber, mantar, mısır, domates, sucuk)" Then
            pizza = 25
        ElseIf ComboBox2.Text = "Italiano (sos,mozarella peyniri, mantar, küp sucuk, kekik)" Then
            pizza = 30
        ElseIf ComboBox2.Text = "Dopdolu Extra (sos, mozarella peyniri, beyaz peynir, meksika biberi, susam, mantar, domates, yeşil biber)" Then
            pizza = 40
        End If



        If comboBoxIcecek.Text = "Coca-Cola Pet 1 lt" Then
            icecek += numericUpDownIcecek.Value * 7
        ElseIf comboBoxIcecek.Text = "Fanta Pet 1 lt" Then
            icecek += numericUpDownIcecek.Value * 4
        ElseIf comboBoxIcecek.Text = "Sprite Pet 1 lt" Then
            icecek += numericUpDownIcecek.Value * 5
        ElseIf comboBoxIcecek.Text = "1 Lt Sütaş Ayran" Then
            icecek += numericUpDownIcecek.Value * 7
        ElseIf comboBoxIcecek.Text = "Coca-Cola Kutu 330 ml" Then
            icecek += numericUpDownIcecek.Value * 5
        ElseIf comboBoxIcecek.Text = "Sütaş Ayran 200 ml" Then
            icecek += numericUpDownIcecek.Value * 4
        ElseIf comboBoxIcecek.Text = "Fanta Kutu 330 ml" Then
            icecek += numericUpDownIcecek.Value * 5
        ElseIf comboBoxIcecek.Text = "Sprite Kutu 330 ml" Then
            icecek += numericUpDownIcecek.Value * 4
        ElseIf comboBoxIcecek.Text = "FuseTea Şeftali Kutu 330 ml" Then
            icecek += numericUpDownIcecek.Value * 4
        ElseIf comboBoxIcecek.Text = "FuseTea Şeftali Pet 1 lt" Then
            icecek += numericUpDownIcecek.Value * 6
        End If

        ucret = Val(icecek) + Val(boy) + Val(pizza) + Val(menu)

        lblToplam.Text = ucret 
        tl.Text = "TL"

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        groupBox1.Enabled = False
        button3.Enabled = False

        temizle()


    End Sub

    Sub temizle()
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        comboBoxIcecek.Text = ""
        comboBoxPizzaBoy.Text = ""
        numericUpDownIcecek.Value = 0
        NumericUpDownMenu.Value = 0
        numericUpDownPizza.Value = 0



        PictureBox1.Image = My.Resources.pizzaa
        PictureBox2.Image = My.Resources.pizza_menu_3_1047816
        PictureBox8.Image = My.Resources.drink_icon
        listBox1.Items.Clear()
        lblToplam.Text = "-"
        tl.Text = ""

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Dürümos Menü - (Ekmek Arası veya Dürümos + Patates + Coca-Cola 330 ml)" Then
            PictureBox2.Image = My.Resources.ekmekarasıdürümoskola

        ElseIf ComboBox3.Text = "Şampiyon Menü - (Büyük Dilim Pizza, 2li Chicken Fingers, 4lü Nuggets, 4lü Soğan Halkası, Parmak Patates, Kutu İçecek)" Then
            PictureBox2.Image = My.Resources.şampiyonmenü

        ElseIf ComboBox3.Text = "Aile Menü - (Büyük Boy Pizza, 2 adet patates, Coca-Cola 1 L)" Then
            PictureBox2.Image = My.Resources.ailemenü

        ElseIf ComboBox3.Text = "Zula Gamer Menü - (Orta Boy Pizza, Coca-Cola 1L veya Pepsi 1L)" Then
            PictureBox2.Image = My.Resources.zulagamermenü


        End If
    End Sub

    Private Sub comboBoxIcecek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxIcecek.SelectedIndexChanged
        Dim icecek As String = 0
        Dim icecekfiyat As String = 0

        If comboBoxIcecek.Text = "Coca-Cola Pet 1 lt" Then
            PictureBox8.Image = My.Resources.cocacola_pet

        ElseIf comboBoxIcecek.Text = "Fanta Pet 1 lt" Then
            PictureBox8.Image = My.Resources.fanta

        ElseIf comboBoxIcecek.Text = "Sprite Pet 1 lt" Then
            PictureBox8.Image = My.Resources.sprite

        ElseIf comboBoxIcecek.Text = "1 Lt Sütaş Ayran" Then
            PictureBox8.Image = My.Resources.sütasayran1litre

        ElseIf comboBoxIcecek.Text = "Coca-Cola Kutu 330 ml" Then
            PictureBox8.Image = My.Resources.cocacola_330ml

        ElseIf comboBoxIcecek.Text = "Sütaş Ayran 200 ml" Then
            PictureBox8.Image = My.Resources.sütasayran

        ElseIf comboBoxIcecek.Text = "Fanta Kutu 330 ml" Then
            PictureBox8.Image = My.Resources.fanta330

        ElseIf comboBoxIcecek.Text = "Sprite Kutu 330 ml" Then
            PictureBox8.Image = My.Resources.sprite330

        ElseIf comboBoxIcecek.Text = "FuseTea Şeftali Kutu 330 ml" Then
            PictureBox8.Image = My.Resources.fusetea330

        ElseIf comboBoxIcecek.Text = "FuseTea Şeftali Pet 1 lt" Then
            PictureBox8.Image = My.Resources.fusetea


        End If


    End Sub

    Private Sub delete()

        ComboBox2.Text = ""
        ComboBox3.Text = ""
        comboBoxIcecek.Text = ""
        comboBoxPizzaBoy.Text = ""



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        baglanti.Open()
        Dim komutlar As New OleDbCommand("insert into siparis1(k_id,adi,soyadi,tel,adres,aciklama,pizza,pizzaboy,pizzaadet,icecek,icecekadet,menu,menuadet,odeme,tarih,saat) values(

'" + id_no.Text + "',
'" + txtAdi.Text + "',
'" + txtSoyadi.Text + "',
'" + txtTel.Text + "',
'" + txtAdres.Text + "',
'" + txtNot.Text + "',
'" + ComboBox2.Text + "',
'" + comboBoxPizzaBoy.Text + "',
'" + numericUpDownPizza.Text + "',
'" + comboBoxIcecek.Text + "',
'" + numericUpDownIcecek.Text + "',
'" + ComboBox3.Text + "',
'" + NumericUpDownMenu.Text + "',
'" + lblToplam.Text + "',
'" + tarih.Text + "',
'" + saat.Text + "'
)", baglanti)
        komutlar.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Sipariş Kayıt Eklendi!", "Sipariş Kayıt")
        delete()

    End Sub
End Class