Imports System.Data.OleDb

Public Class KullanıcıEkle
    Dim tablo As New DataTable
    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        baglanti.Open()
        Dim komutlar As New OleDbCommand("insert into kullanici(adi,soyadi,tel,adres,k_adi,sifre,yetki) values('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTel.Text + "','" + txtAdres.Text + "','" + k_adi.Text + "','" + sifre.Text + "','" + ComboBox1.Text + "')", baglanti)
        komutlar.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Kullanıcı kayıt eklendi", "Kayıt")
        delete()
        MessageBox.Show("Kullanıcı işlemleri yapmak için formu kapatıp yeniden açın!!", "Uyarı")
        Me.Hide()


    End Sub


    Private Sub KullanıcıEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub


    Private Sub delete()
        txtAd.Text = ""
        txtSoyad.Text = ""
        txtTel.Text = ""
        txtAdres.Text = ""
        k_adi.Text = ""
        sifre.Text = ""
        ComboBox1.Text = ""



    End Sub
End Class