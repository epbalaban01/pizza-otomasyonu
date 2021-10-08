Imports System.IO
Imports System.Data.OleDb
Public Class Odeme
    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Enabled = True

        Dim secili As String
        If nakit.Checked Then
            secili = nakit.Text
        ElseIf k_karti.Checked Then
            secili = k_karti.Text
        End If



        baglanti.Open()
        Dim komutlar As New OleDbCommand("insert into odeme(k_id,adi,soyadi,odeme,i_odeme,odeme_yontemi) values(
'" + id.Text + "',
'" + adi.Text + "',
'" + soyadi.Text + "',
'" + lblToplam.Text + "',
'" + lblIndirimliTutar.Text + "',
'" + secili.ToString + "'
)", baglanti)
        komutlar.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Ödeme tamamlandı!", "Ödeme")
        MessageBox.Show("Fiş almayı unutmayın!", "Fiş")


    End Sub

    Private Sub Odeme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub button4_Click(sender As Object, e As EventArgs)
        Dim yenisiparis As New MusteriPanel
        yenisiparis.Show()
        Me.Hide()
    End Sub

    Dim indirimoranı As Decimal = 0.1
    Private Sub nakit_CheckedChanged(sender As Object, e As EventArgs) Handles nakit.CheckedChanged

        Dim indirim, tutar, sonuc As Decimal


        tutar = lblToplam.Text
        indirim = tutar * indirimoranı
        sonuc = tutar - indirim
        lblIndirimliTutar.Text = sonuc

    End Sub

    Dim krediindirimoranı As Decimal = 0.03
    Private Sub k_karti_CheckedChanged(sender As Object, e As EventArgs) Handles k_karti.CheckedChanged

        Dim indirim, tutar, sonuc As Decimal
        tutar = lblToplam.Text
        indirim = tutar * krediindirimoranı
        sonuc = tutar - indirim
        lblIndirimliTutar.Text = sonuc
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Enabled = False

        Dim secili As String
        If nakit.Checked Then
            secili = nakit.Text
        ElseIf k_karti.Checked Then
            secili = k_karti.Text
        End If

        Dim save As New SaveFileDialog


        save.Title = "Fiş Kaydet"
        save.DefaultExt = "txt"
        save.Filter = "Metin Belgeleri (*.txt)|*.txt*"
        If save.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim Kayit As New StreamWriter(save.FileName)

            Kayit.WriteLine("ID No: " + id.Text)
            Kayit.WriteLine("Adı: " + adi.Text)
            Kayit.WriteLine("Soyadı: " + soyadi.Text)
            Kayit.WriteLine("Toplam Tutar: " + lblToplam.Text + " TL")
            Kayit.WriteLine("İndirimli Tutar: " + lblIndirimliTutar.Text + " TL")
            Kayit.WriteLine("Ödeme Yöntemi: " + secili)

            MessageBox.Show("Fiş Kaydedildi", "Dosya Yolu:" + save.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Kayit.Close()
            Me.Hide()
        End If
    End Sub
End Class