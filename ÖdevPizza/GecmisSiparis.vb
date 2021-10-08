Imports System.Data.OleDb
Public Class GecmisSiparis

    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Dim tablo As New DataTable


    Sub guncelle()

        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("Select * From siparis1 where islem like '" + hazir.Text + "%'", baglanti)
        adtr.Fill(tablo)
        dataGridView1.DataSource = tablo
        baglanti.Close()


    End Sub



    Private Sub GecmisSiparis_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()

        dataGridView1.DataSource = tablo
        dataGridView1.Columns(0).HeaderText = "Sipariş ID"
        dataGridView1.Columns(1).HeaderText = "Kullanıcı ID"
        dataGridView1.Columns(2).HeaderText = "Adı"
        dataGridView1.Columns(3).HeaderText = "Soyadı"
        dataGridView1.Columns(4).HeaderText = "Tel"
        dataGridView1.Columns(5).HeaderText = "Adres"
        dataGridView1.Columns(6).HeaderText = "Açıklama"
        dataGridView1.Columns(7).HeaderText = "Pizza"
        dataGridView1.Columns(8).HeaderText = "Pizza Boy"
        dataGridView1.Columns(9).HeaderText = "Pizza Adet"
        dataGridView1.Columns(10).HeaderText = "İçecek"
        dataGridView1.Columns(11).HeaderText = "İçecek Adet"
        dataGridView1.Columns(12).HeaderText = "Menü"
        dataGridView1.Columns(13).HeaderText = "Menü Adet"
        dataGridView1.Columns(14).HeaderText = "Ödeme"
        dataGridView1.Columns(15).HeaderText = "Tarih"
        dataGridView1.Columns(16).HeaderText = "Saat"
        dataGridView1.Columns(17).HeaderText = "İşlem"
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        adi.Text = dataGridView1.CurrentRow.Cells("adi").Value.ToString + " " + dataGridView1.CurrentRow.Cells("soyadi").Value.ToString
        id_no.Text = dataGridView1.CurrentRow.Cells("k_id").Value.ToString


        ListBox1.Items.Clear()
        ListBox1.Items.Add("Pizza: " + dataGridView1.CurrentRow.Cells("pizzaadet").Value.ToString + " adet " + dataGridView1.CurrentRow.Cells("pizzaboy").Value.ToString + "Boy " + dataGridView1.CurrentRow.Cells("pizza").Value.ToString)
        ListBox1.Items.Add("Menü: " + dataGridView1.CurrentRow.Cells("menuadet").Value.ToString + " adet " + dataGridView1.CurrentRow.Cells("menu").Value.ToString)
        ListBox1.Items.Add("İçecek: " + dataGridView1.CurrentRow.Cells("icecekadet").Value.ToString + " adet " + dataGridView1.CurrentRow.Cells("icecek").Value.ToString)
        ListBox1.Items.Add("Ödeme: " + dataGridView1.CurrentRow.Cells("odeme").Value.ToString + " TL ")
        ListBox1.Items.Add("Tarih: " + dataGridView1.CurrentRow.Cells("tarih").Value.ToString + " & " + "Saat: " + dataGridView1.CurrentRow.Cells("saat").Value.ToString)


        islem.Text = dataGridView1.CurrentRow.Cells("islem").Value.ToString

        If islem.Text = "Hazır" Then
            islem.BackColor = Color.Green
            islem.ForeColor = Color.White

        End If

        dataGridView1.ReadOnly = True
    End Sub
End Class