Public Class AdminPanel
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim gecmissiparis As New GecmisSiparis
        gecmissiparis.Show()

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) 
        Dim kullaniciekle As New KullanıcıEkle
        kullaniciekle.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim siparis As New MusteriPanel
        siparis.txtAdi.Text = lblAdi.Text
        siparis.txtSoyadi.Text = lblSoyad.Text
        siparis.txtTel.Text = lblTel.Text
        siparis.txtAdres.Text = lblAdres.Text
        siparis.id_no.Text = lblID.Text
        siparis.Show()
    End Sub



    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label7.Text = "Saat: " + DateTime.Now.ToString("HH:mm")

        Dim timer As New Timer()
        timer.Interval = 1000
        AddHandler timer.Tick, AddressOf timer1_Tick
        timer.Start()






    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Me.label7.Refresh()

        label7.Text = "Saat: " + DateTime.Now.ToString("HH:mm")


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim siparistakip As New SiparisTakip
        siparistakip.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) 
        Dim kullanicigoster As New KullanıcıGoster
        kullanicigoster.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim kullanicibilgileri As New KullanıcıBilgileri
        kullanicibilgileri.Show()
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

    Private Sub hakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles hakkındaToolStripMenuItem.Click
        Dim hakkinda As New Hakkinda
        hakkinda.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim cariyonetim As New AdminOdeme
        cariyonetim.Show()
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