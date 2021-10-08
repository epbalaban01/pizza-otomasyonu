Imports System.Data.OleDb
Public Class MusteriPanel1




    Private Sub MusteriPanel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saat.Text = "Saat: " + DateTime.Now.ToString("HH:mm")

        Dim timer As New Timer()
        timer.Interval = 1000
        AddHandler timer.Tick, AddressOf Timer1_Tick
        timer.Start()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim siparis As New MusteriPanel
        siparis.txtAdi.Text = lblAdi.Text
        siparis.txtSoyadi.Text = lblSoyad.Text
        siparis.txtTel.Text = lblTel.Text
        siparis.txtAdres.Text = lblAdres.Text
        siparis.id_no.Text = lblID.Text
        siparis.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim musteribilgi As New MusteriBilgi
        musteribilgi.lblAdi.Text = lblAdi.Text
        musteribilgi.lblSoyad.Text = lblSoyad.Text
        musteribilgi.lblTel.Text = lblTel.Text
        musteribilgi.lblAdres.Text = lblAdres.Text
        musteribilgi.lblID.Text = lblID.Text
        musteribilgi.lblyetki.Text = lblyetki.Text
        musteribilgi.lblK_adi.Text = lblK_adi.Text
        musteribilgi.lblSifre.Text = lblSifre.Text
        musteribilgi.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim siparisgoster As New MusteriSiparisGoster
        siparisgoster.id.Text = lblID.Text
        siparisgoster.labeladisoyadi.Text = lblAdi.Text + " " + lblSoyad.Text
        siparisgoster.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim odemelerim As New Odemelerim
        odemelerim.id.Text = lblID.Text
        odemelerim.lblAdiSoyadi.Text = lblAdi.Text + " " + lblSoyad.Text
        odemelerim.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim gecmissiparis As New MusteriGecmisSiparis
        gecmissiparis.id_no.Text = lblID.Text
        gecmissiparis.adisoyadi.Text = lblAdi.Text + " " + lblSoyad.Text
        gecmissiparis.Show()
    End Sub

    Private Sub HakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakkındaToolStripMenuItem.Click
        Dim hakkinda As New Hakkinda
        hakkinda.Show()
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Dim D As String

        D = MsgBox("Çıkmak istediğine emin misin?", vbYesNo + vbQuestion, "Çıkış")

        If D = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.saat.Refresh()

        saat.Text = "Saat: " + DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim D As String

        D = MsgBox("Oturumdan çıkmak istediğine emin misin?", vbYesNo + vbQuestion, "Oturumdan Çık")

        If D = vbYes Then
            Me.Close()

            Application.Restart()

        Else
            Exit Sub
        End If
        End
    End Sub
End Class