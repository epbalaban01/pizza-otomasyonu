Imports System.Data.OleDb
Public Class KullanıcıGoster

    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Private Sub KullanıcıGoster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()

        dataGridView1.DataSource = tablo
        dataGridView1.Columns(0).HeaderText = "ID"
        dataGridView1.Columns(1).HeaderText = "Adı"
        dataGridView1.Columns(2).HeaderText = "Soyadı"
        dataGridView1.Columns(3).HeaderText = "Tel"
        dataGridView1.Columns(4).HeaderText = "Adres"
        dataGridView1.Columns(5).HeaderText = "Kullanıcı Adı"
        dataGridView1.Columns(6).HeaderText = "Şifre"
    End Sub
    Dim tablo As New DataTable
    Dim oku1 As OleDbDataReader
    Sub guncelle()

        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select *from kullanici", baglanti)
        adtr.Fill(tablo)
        dataGridView1.DataSource = tablo

        'Toplam Kişi
        Dim toplam As New OleDbCommand("SELECT  count(adi) as KisiSayisi from kullanici  ", baglanti)
        oku1 = toplam.ExecuteReader()

        If oku1.Read() Then
            Label1.Text = "Kayıtlı olan toplam " + oku1(0).ToString + " kişidir."
        End If

        baglanti.Close()

        dataGridView1.ReadOnly = True
    End Sub
End Class