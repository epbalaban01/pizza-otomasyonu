Imports System.Data.OleDb
Public Class MusteriKayit
    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        baglanti.Open()
        Dim komutlar As New OleDbCommand("insert into kullanici(adi,soyadi,tel,adres,k_adi,sifre,yetki) values('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTel.Text + "','" + txtAdres.Text + "','" + k_adi.Text + "','" + sifre.Text + "','" + yetki.Text + "')", baglanti)
        komutlar.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Kayıt Eklendi", "Kayıt")
        delete()
    End Sub

    Private Sub MusteriKayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub delete()
        txtAd.Text = ""
        txtSoyad.Text = ""
        txtTel.Text = ""
        txtAdres.Text = ""
        k_adi.Text = ""
        sifre.Text = ""

    End Sub


End Class