Imports System.Data.OleDb
Public Class Odemelerim
    Public baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=veritabani.mdb")
    Private Sub Odemelerim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()

        DataGridView1.DataSource = tablo
        DataGridView1.Columns(0).HeaderText = "Ödeme ID"
        DataGridView1.Columns(1).HeaderText = "Kullanıcı ID"
        DataGridView1.Columns(2).HeaderText = "Adı"
        DataGridView1.Columns(3).HeaderText = "Soyadı"
        DataGridView1.Columns(4).HeaderText = "Ödeme"
        DataGridView1.Columns(5).HeaderText = "İndirimli Ödeme"
        DataGridView1.Columns(6).HeaderText = "Ödeme Yöntemi"

    End Sub

    Dim tablo As New DataTable
    Dim oku1 As OleDbDataReader
    Sub guncelle()

        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select * from odeme where k_id like  '" + id.Text + "%'", baglanti)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo


        'Toplam Ödeme
        Dim toplam As New OleDbCommand("SELECT  sum(odeme) as ToplamOdeme from odeme where k_id like '" + id.Text + "'", baglanti)
        oku1 = toplam.ExecuteReader()

        If oku1.Read() Then
            toplamodeme.Text = oku1(0).ToString + " TL"
        End If

        'Toplam İndirimli Ödeme
        Dim toplamindirim As New OleDbCommand("SELECT  sum(i_odeme) as ToplamOdeme from odeme where k_id like '" + id.Text + "'", baglanti)
        oku1 = toplamindirim.ExecuteReader()

        If oku1.Read() Then
            toplamindirimodeme.Text = oku1(0).ToString + " TL"
        End If

        baglanti.Close()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        odeme.Text = ""
        ıodeme.Text = ""
        o_yontemi.Text = ""

        odeme.Text = DataGridView1.CurrentRow.Cells("odeme").Value.ToString + " TL"
        ıodeme.Text = DataGridView1.CurrentRow.Cells("i_odeme").Value.ToString + " TL"
        o_yontemi.Text = DataGridView1.CurrentRow.Cells("odeme_yontemi").Value.ToString

        DataGridView1.ReadOnly = True
    End Sub


End Class