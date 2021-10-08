Imports System.Data.OleDb
Imports System.Deployment.Application
Public Class Form1

    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Dim adp As New OleDbDataAdapter
    Dim dataset As New DataSet
    Dim oku As OleDbDataReader
    Dim cmd As OleDbCommand




    Dim kullanıcı As New Kullanicilar
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        baglanti.Open()
        Dim komutlar As New OleDbCommand("Select * From kullanici Where k_adi =@k_adi and sifre =@sifre", baglanti)
        komutlar.Parameters.Add("k_adi", OleDbType.VarChar).Value = textBox1.Text
        komutlar.Parameters.Add("sifre", OleDbType.VarChar).Value = textBox2.Text
        oku = komutlar.ExecuteReader()

        If oku.Read Then
            If oku(7).ToString() = "admin" Then
                If oku.HasRows = True Then
                    kullanıcı.adi = oku("adi").ToString
                    kullanıcı.soyadi = oku("soyadi").ToString
                    kullanıcı.kullaniciadi = oku("k_adi").ToString
                    kullanıcı.kullanici_id = oku("kullanici_id").ToString
                    kullanıcı.tel = oku("tel").ToString
                    kullanıcı.adres = oku("adres").ToString
                    kullanıcı.yetki = oku("yetki").ToString


                    Dim adminpaneli As New AdminPanel

                    adminpaneli.labeladi.Text = "Hoşgeldin => " + kullanıcı.adi + " " + kullanıcı.soyadi
                    adminpaneli.lblK_adi.Text = kullanıcı.kullaniciadi
                    adminpaneli.lblID.Text = kullanıcı.kullanici_id
                    adminpaneli.lblAdi.Text = kullanıcı.adi
                    adminpaneli.lblSoyad.Text = kullanıcı.soyadi
                    adminpaneli.lblTel.Text = kullanıcı.tel
                    adminpaneli.lblAdres.Text = kullanıcı.adres
                    adminpaneli.lblyetki.Text = kullanıcı.yetki
                    adminpaneli.Show()
                    Me.Hide()



                Else
                    oku.Close()
                    MessageBox.Show("Hata var")
                End If

            ElseIf oku(7).ToString() = "uye" Then
                If oku.HasRows = True Then
                    kullanıcı.kullaniciadi = oku("k_adi").ToString
                    kullanıcı.sifre = oku("sifre").ToString
                    kullanıcı.kullanici_id = oku("kullanici_id").ToString
                    kullanıcı.adi = oku("adi").ToString
                    kullanıcı.soyadi = oku("soyadi").ToString
                    kullanıcı.tel = oku("tel").ToString
                    kullanıcı.adres = oku("adres").ToString
                    kullanıcı.yetki = oku("yetki").ToString



                    Dim musteripaneli As New MusteriPanel1

                    musteripaneli.Label1.Text = "Hoşgeldin => " + kullanıcı.adi + " " + kullanıcı.soyadi
                    musteripaneli.lblK_adi.Text = kullanıcı.kullaniciadi
                    musteripaneli.lblID.Text = kullanıcı.kullanici_id
                    musteripaneli.lblAdi.Text = kullanıcı.adi
                    musteripaneli.lblSoyad.Text = kullanıcı.soyadi
                    musteripaneli.lblTel.Text = kullanıcı.tel
                    musteripaneli.lblAdres.Text = kullanıcı.adres
                    musteripaneli.lblSifre.Text = kullanıcı.sifre
                    musteripaneli.lblyetki.Text = kullanıcı.yetki

                    musteripaneli.Show()




                    Me.Hide()
                Else
                    oku.Close()
                    MessageBox.Show("Hata var")

                End If

            End If
        ElseIf (textBox1.Text = "") Then
            MessageBox.Show("Kullanıcı Adı Alanı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (textBox2.Text = "") Then
            MessageBox.Show("Şifre Alanı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If







        baglanti.Close()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1.Text = "Version: " + Me.GetType.Assembly.GetName.Version.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim musterikayit As New MusteriKayit
        musterikayit.Show()

    End Sub


End Class
