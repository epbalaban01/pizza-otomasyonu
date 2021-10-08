Imports System.Data.OleDb
Public Class KullanıcıBilgileri

    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Dim tablo As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim D As String

        D = MsgBox("Silmek istediğine emin misin?", vbYesNo + vbQuestion, "Sipariş İşlemleri")
        If D = vbYes Then
            baglanti.Open()
            Dim komut As New OleDbCommand("delete *from kullanici where adi='" + TextBox2.Text + "'", baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()

            MessageBox.Show("Kayıt Silindi", "Kayıt İşlemleri")
            tablo.Clear()
            delete()
            guncelle()
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        baglanti.Open()
        Dim komut As New OleDbCommand("UPDATE kullanici set adi='" + txtAd.Text + "',soyadi='" + txtSoyad.Text + "',tel='" + txtTel.Text + "',adres='" + txtAdres.Text + "',k_adi='" + k_adi.Text + "',sifre='" + sifre.Text + "',yetki='" + ComboBox1.Text + "' where kullanici_id=" + txtID.Text + "", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Kayıt Güncellendi", "Kayıt")

        tablo.Clear()
        delete()
        guncelle()
    End Sub

    Private Sub KullanıcıBilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()

        dataGridView1.DataSource = tablo
        dataGridView1.Columns(0).HeaderText = "Kullanıcı ID"
        dataGridView1.Columns(1).HeaderText = "Adı"
        dataGridView1.Columns(2).HeaderText = "Soyadı"
        dataGridView1.Columns(3).HeaderText = "Tel"
        dataGridView1.Columns(4).HeaderText = "Adres"
        dataGridView1.Columns(5).HeaderText = "Kullanıcı Adı"
        dataGridView1.Columns(6).HeaderText = "Şifre"
    End Sub

    Sub guncelle()

        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select *from kullanici", baglanti)
        adtr.Fill(tablo)
        dataGridView1.DataSource = tablo
        baglanti.Close()

    End Sub

    Private Sub delete()
        txtID.Text = ""
        txtAd.Text = ""
        txtSoyad.Text = ""
        txtSoyad.Text = ""
        txtTel.Text = ""
        txtAdres.Text = ""
        k_adi.Text = ""
        sifre.Text = ""
        ComboBox1.Text = ""


    End Sub







    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        txtID.Text = dataGridView1.CurrentRow.Cells("kullanici_id").Value.ToString
        txtAd.Text = dataGridView1.CurrentRow.Cells("adi").Value.ToString
        txtSoyad.Text = dataGridView1.CurrentRow.Cells("soyadi").Value.ToString
        txtTel.Text = dataGridView1.CurrentRow.Cells("tel").Value.ToString
        txtAdres.Text = dataGridView1.CurrentRow.Cells("adres").Value.ToString
        k_adi.Text = dataGridView1.CurrentRow.Cells("k_adi").Value.ToString
        sifre.Text = dataGridView1.CurrentRow.Cells("sifre").Value.ToString
        ComboBox1.Text = dataGridView1.CurrentRow.Cells("yetki").Value.ToString

        dataGridView1.ReadOnly = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kullaniciekle As New KullanıcıEkle
        kullaniciekle.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim kullanicigoster As New KullanıcıGoster
        kullanicigoster.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select * from kullanici where adi like '" + TextBox2.Text + "%'", baglanti)
        Dim tablo2 As New DataTable
        adtr.Fill(tablo2)
        dataGridView1.DataSource = tablo2
        baglanti.Close()
    End Sub
End Class