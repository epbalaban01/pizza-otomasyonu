Imports System.Data.OleDb
Public Class AdminOdeme
    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Dim tablo As New DataTable
    Private Sub AdminOdeme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()





        Dim pizzaodeme As String
        Dim menuodeme As String
        Dim icecekodeme As String
        Dim kucuk1, orta1, buyuk1 As String
        Dim sirketodeme As String

        pizzaodeme = 20 + 22 + 24 + 25 + 30 + 40
        pizza.Text = pizzaodeme + " TL"

        menuodeme = 22 + 35 + 85 + 40
        menu1.Text = menuodeme + " TL"

        icecekodeme = 7 + 4 + 5 + 7 + 5 + 4 + 5 + 4 + 4 + 6
        icecek.Text = icecekodeme + " TL"


        kucuk1 = 25
        kucuk.Text = kucuk1 + " TL"
        orta1 = 40
        orta.Text = orta1 + " TL"
        buyuk1 = 50
        buyuk.Text = buyuk1 + " TL"



        sirketodeme = Val(pizzaodeme) + Val(menuodeme) + Val(icecekodeme)
        sirket_toplam.Text = sirketodeme + " TL"
    End Sub

    Dim oku1 As OleDbDataReader

    Sub guncelle()

        baglanti.Open()

        'Toplam Ödeme
        Dim toplam As New OleDbCommand("SELECT  sum(odeme) as ToplamMaas from odeme  ", baglanti)
        oku1 = toplam.ExecuteReader()

        If oku1.Read() Then
            toplamodeme.Text = oku1(0).ToString + " TL"
        End If




        'İndirim Ödeme
        Dim indirimodeme As New OleDbCommand("SELECT  sum(i_odeme) as ToplamMaas from odeme  ", baglanti)
        oku1 = indirimodeme.ExecuteReader()

        If oku1.Read() Then
            toplamindirimodeme.Text = oku1(0).ToString + " TL"
        End If

        'Toplam Siparis
        Dim toplamsiparis1 As New OleDbCommand("SELECT  count(siparis_id) as ToplamSiparis from siparis1 ", baglanti)
        oku1 = toplamsiparis1.ExecuteReader()

        If oku1.Read() Then
            toplamsiparis.Text = oku1(0).ToString + " tane sipariş alındı."
        End If

        'Toplam Kullanıcı
        Dim toplamkullanici1 As New OleDbCommand("SELECT  count(kullanici_id) as ToplamKullanici from kullanici ", baglanti)
        oku1 = toplamkullanici1.ExecuteReader()

        If oku1.Read() Then
            toplamkullanici.Text = oku1(0).ToString + " kişi kullanıcı "
        End If

        'Toplam Kullanıcı
        Dim tamamlanansiparis1 As New OleDbCommand("SELECT  count(siparis_id) as ToplamSiparisTeslim from siparis1 where islem like '" + hazir.Text + "' ", baglanti)

        oku1 = tamamlanansiparis1.ExecuteReader()

        If oku1.Read() Then
            tamamlanansiparis.Text = oku1(0).ToString + " tane sipariş teslim edildi. "
        End If

        baglanti.Close()

    End Sub
End Class