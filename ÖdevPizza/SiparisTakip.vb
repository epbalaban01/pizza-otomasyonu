Imports System.Data.OleDb
Public Class SiparisTakip
    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Dim tablo As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim D As String

        D = MsgBox("Silmek istediğine emin misin?", vbYesNo + vbQuestion, "Sipariş İşlemleri")
        If D = vbYes Then
            baglanti.Open()

            Dim komut2 As New OleDbCommand("delete *from siparis1 where siparis_id=" + siparis_id_delete.Text + "", baglanti)
            komut2.ExecuteNonQuery()

            baglanti.Close()
            MessageBox.Show("Sipariş Silindi", "Sipariş İşlemleri")
            tablo.Clear()
            delete()
            guncelle()

        End If

    End Sub

    Private Sub siparis_id_delete_TextChanged(sender As Object, e As EventArgs) Handles siparis_id_delete.TextChanged
        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select * from siparis1 where siparis_id like '" + siparis_id_delete.Text + "%'", baglanti)
        Dim tablo2 As New DataTable
        adtr.Fill(tablo2)
        dataGridView1.DataSource = tablo2
        baglanti.Close()
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        siparis_id.Text = dataGridView1.CurrentRow.Cells("siparis_id").Value.ToString
        txtID.Text = dataGridView1.CurrentRow.Cells("k_id").Value.ToString
        txtAd.Text = dataGridView1.CurrentRow.Cells("adi").Value.ToString
        txtSoyad.Text = dataGridView1.CurrentRow.Cells("soyadi").Value.ToString
        txtTel.Text = dataGridView1.CurrentRow.Cells("tel").Value.ToString
        txtAdres.Text = dataGridView1.CurrentRow.Cells("adres").Value.ToString
        pizza.Text = dataGridView1.CurrentRow.Cells("pizza").Value.ToString
        menu2.Text = dataGridView1.CurrentRow.Cells("menu").Value.ToString
        icecek.Text = dataGridView1.CurrentRow.Cells("icecek").Value.ToString
        islem.Text = dataGridView1.CurrentRow.Cells("islem").Value.ToString

        dataGridView1.ReadOnly = True
    End Sub

    Private Sub delete()
        siparis_id.Text = ""
        txtID.Text = ""
        txtAd.Text = ""
        txtSoyad.Text = ""
        txtSoyad.Text = ""
        txtTel.Text = ""
        txtAdres.Text = ""
        pizza.Text = ""
        menu2.Text = ""
        icecek.Text = ""
        islem.Text = ""


    End Sub

    Private Sub SiparisTakip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()

        dataGridView1.DataSource = tablo
        dataGridView1.Columns(0).HeaderText = "Şipariş ID"
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

    Sub guncelle()

        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select *from siparis1", baglanti)
        adtr.Fill(tablo)
        dataGridView1.DataSource = tablo
        baglanti.Close()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        baglanti.Open()
        Dim komut As New OleDbCommand("UPDATE siparis1 set 


adi='" + txtAd.Text + "',
soyadi='" + txtSoyad.Text + "',
tel='" + txtTel.Text + "',
adres='" + txtAdres.Text + "',
pizza='" + pizza.Text + "',
menu='" + menu2.Text + "',
icecek='" + icecek.Text + "',
islem='" + islem.Text + "' 

where siparis_id=" + siparis_id.Text + "", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Sipariş Güncellendi", "Sipariş")

        tablo.Clear()
        delete()
        guncelle()
    End Sub
End Class