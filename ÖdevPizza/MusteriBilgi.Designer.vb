<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MusteriBilgi
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KopyalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblyetki = New System.Windows.Forms.Label()
        Me.lblSifre = New System.Windows.Forms.Label()
        Me.lblK_adi = New System.Windows.Forms.Label()
        Me.lblAdres = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblAdi = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KopyalaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 26)
        '
        'KopyalaToolStripMenuItem
        '
        Me.KopyalaToolStripMenuItem.Name = "KopyalaToolStripMenuItem"
        Me.KopyalaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.KopyalaToolStripMenuItem.Text = "Kopyala"
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Controls.Add(Me.lblyetki)
        Me.GroupBox1.Controls.Add(Me.lblSifre)
        Me.GroupBox1.Controls.Add(Me.lblK_adi)
        Me.GroupBox1.Controls.Add(Me.lblAdres)
        Me.GroupBox1.Controls.Add(Me.lblTel)
        Me.GroupBox1.Controls.Add(Me.lblAdi)
        Me.GroupBox1.Controls.Add(Me.lblSoyad)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 223)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lblyetki
        '
        Me.lblyetki.AutoSize = True
        Me.lblyetki.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblyetki.Location = New System.Drawing.Point(80, 181)
        Me.lblyetki.Name = "lblyetki"
        Me.lblyetki.Size = New System.Drawing.Size(10, 13)
        Me.lblyetki.TabIndex = 2
        Me.lblyetki.Text = "-"
        '
        'lblSifre
        '
        Me.lblSifre.AutoSize = True
        Me.lblSifre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSifre.Location = New System.Drawing.Point(80, 158)
        Me.lblSifre.Name = "lblSifre"
        Me.lblSifre.Size = New System.Drawing.Size(10, 13)
        Me.lblSifre.TabIndex = 2
        Me.lblSifre.Text = "-"
        '
        'lblK_adi
        '
        Me.lblK_adi.AutoSize = True
        Me.lblK_adi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblK_adi.Location = New System.Drawing.Point(80, 133)
        Me.lblK_adi.Name = "lblK_adi"
        Me.lblK_adi.Size = New System.Drawing.Size(10, 13)
        Me.lblK_adi.TabIndex = 2
        Me.lblK_adi.Text = "-"
        '
        'lblAdres
        '
        Me.lblAdres.AutoSize = True
        Me.lblAdres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblAdres.Location = New System.Drawing.Point(80, 110)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(10, 13)
        Me.lblAdres.TabIndex = 2
        Me.lblAdres.Text = "-"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTel.Location = New System.Drawing.Point(81, 87)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(10, 13)
        Me.lblTel.TabIndex = 2
        Me.lblTel.Text = "-"
        '
        'lblAdi
        '
        Me.lblAdi.AutoSize = True
        Me.lblAdi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblAdi.Location = New System.Drawing.Point(81, 42)
        Me.lblAdi.Name = "lblAdi"
        Me.lblAdi.Size = New System.Drawing.Size(10, 13)
        Me.lblAdi.TabIndex = 2
        Me.lblAdi.Text = "-"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblSoyad.Location = New System.Drawing.Point(80, 65)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(10, 13)
        Me.lblSoyad.TabIndex = 2
        Me.lblSoyad.Text = "-"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblID.Location = New System.Drawing.Point(81, 16)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(10, 13)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Yetki:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Şifre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Kullanıcı Adı:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Adres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Soyadı:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(55, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Adı:"
        '
        'MusteriBilgi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 243)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MusteriBilgi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bilgilerim"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents KopyalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblyetki As Label
    Friend WithEvents lblSifre As Label
    Friend WithEvents lblK_adi As Label
    Friend WithEvents lblAdres As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblAdi As Label
    Friend WithEvents lblSoyad As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
End Class
