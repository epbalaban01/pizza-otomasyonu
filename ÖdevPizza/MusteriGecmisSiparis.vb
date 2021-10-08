Imports System.Data.OleDb
Public Class MusteriGecmisSiparis
    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Dim tablo As New DataTable
    Private Sub MusteriGecmisSiparis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()

        DataGridView1.DataSource = tablo
        DataGridView1.Columns(0).HeaderText = "Sipariş ID"
        DataGridView1.Columns(1).HeaderText = "Kullanıcı ID"
        DataGridView1.Columns(2).HeaderText = "Adı"
        DataGridView1.Columns(3).HeaderText = "Soyadı"
        DataGridView1.Columns(4).HeaderText = "Tel"
        DataGridView1.Columns(5).HeaderText = "Adres"
        DataGridView1.Columns(6).HeaderText = "Açıklama"
        DataGridView1.Columns(7).HeaderText = "Pizza"
        DataGridView1.Columns(8).HeaderText = "Pizza Boy"
        DataGridView1.Columns(9).HeaderText = "Pizza Adet"
        DataGridView1.Columns(10).HeaderText = "İçecek"
        DataGridView1.Columns(11).HeaderText = "İçecek Adet"
        DataGridView1.Columns(12).HeaderText = "Menü"
        DataGridView1.Columns(13).HeaderText = "Menü Adet"
        DataGridView1.Columns(14).HeaderText = "Ödeme"
        DataGridView1.Columns(15).HeaderText = "Tarih"
        DataGridView1.Columns(16).HeaderText = "Saat"
        DataGridView1.Columns(17).HeaderText = "İşlem"
    End Sub

    Sub guncelle()

        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("Select * From siparis1 where islem like '" + hazir.Text + "%' AND k_id like '" + id_no.Text + "'", baglanti)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        baglanti.Close()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Pizza: " + DataGridView1.CurrentRow.Cells("pizzaadet").Value.ToString + " adet " + DataGridView1.CurrentRow.Cells("pizzaboy").Value.ToString + "Boy " + DataGridView1.CurrentRow.Cells("pizza").Value.ToString)
        ListBox1.Items.Add("Menü: " + DataGridView1.CurrentRow.Cells("menuadet").Value.ToString + " adet " + DataGridView1.CurrentRow.Cells("menu").Value.ToString)
        ListBox1.Items.Add("İçecek: " + DataGridView1.CurrentRow.Cells("icecekadet").Value.ToString + " adet " + DataGridView1.CurrentRow.Cells("icecek").Value.ToString)
        ListBox1.Items.Add("Ödeme: " + DataGridView1.CurrentRow.Cells("odeme").Value.ToString + " TL ")
        ListBox1.Items.Add("Tarih: " + DataGridView1.CurrentRow.Cells("tarih").Value.ToString + " & " + "Saat: " + DataGridView1.CurrentRow.Cells("saat").Value.ToString)


        islem.Text = DataGridView1.CurrentRow.Cells("islem").Value.ToString

        If islem.Text = "Hazır" Then
            islem.BackColor = Color.Green
            islem.ForeColor = Color.White

        End If

        DataGridView1.ReadOnly = True
    End Sub
End Class