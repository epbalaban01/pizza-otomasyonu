<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Odeme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Odeme))
        Me.odemegrup = New System.Windows.Forms.GroupBox()
        Me.soyadi = New System.Windows.Forms.Label()
        Me.lblIndirimliTutar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.adi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.k_karti = New System.Windows.Forms.RadioButton()
        Me.nakit = New System.Windows.Forms.RadioButton()
        Me.lblToplam = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.labelOdeme = New System.Windows.Forms.Label()
        Me.labelToplamTutar = New System.Windows.Forms.Label()
        Me.tl = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.odemegrup.SuspendLayout()
        Me.SuspendLayout()
        '
        'odemegrup
        '
        Me.odemegrup.Controls.Add(Me.soyadi)
        Me.odemegrup.Controls.Add(Me.lblIndirimliTutar)
        Me.odemegrup.Controls.Add(Me.Label9)
        Me.odemegrup.Controls.Add(Me.adi)
        Me.odemegrup.Controls.Add(Me.Label1)
        Me.odemegrup.Controls.Add(Me.Label8)
        Me.odemegrup.Controls.Add(Me.id)
        Me.odemegrup.Controls.Add(Me.k_karti)
        Me.odemegrup.Controls.Add(Me.nakit)
        Me.odemegrup.Controls.Add(Me.lblToplam)
        Me.odemegrup.Controls.Add(Me.Button3)
        Me.odemegrup.Controls.Add(Me.Button2)
        Me.odemegrup.Controls.Add(Me.Label2)
        Me.odemegrup.Controls.Add(Me.label)
        Me.odemegrup.Controls.Add(Me.labelOdeme)
        Me.odemegrup.Controls.Add(Me.labelToplamTutar)
        Me.odemegrup.Controls.Add(Me.tl)
        Me.odemegrup.Location = New System.Drawing.Point(11, 0)
        Me.odemegrup.Name = "odemegrup"
        Me.odemegrup.Size = New System.Drawing.Size(294, 352)
        Me.odemegrup.TabIndex = 89
        Me.odemegrup.TabStop = False
        '
        'soyadi
        '
        Me.soyadi.AutoSize = True
        Me.soyadi.Location = New System.Drawing.Point(91, 60)
        Me.soyadi.Name = "soyadi"
        Me.soyadi.Size = New System.Drawing.Size(10, 13)
        Me.soyadi.TabIndex = 96
        Me.soyadi.Text = "-"
        '
        'lblIndirimliTutar
        '
        Me.lblIndirimliTutar.AutoSize = True
        Me.lblIndirimliTutar.Location = New System.Drawing.Point(96, 155)
        Me.lblIndirimliTutar.Name = "lblIndirimliTutar"
        Me.lblIndirimliTutar.Size = New System.Drawing.Size(10, 13)
        Me.lblIndirimliTutar.TabIndex = 93
        Me.lblIndirimliTutar.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "ID:"
        '
        'adi
        '
        Me.adi.AutoSize = True
        Me.adi.Location = New System.Drawing.Point(91, 36)
        Me.adi.Name = "adi"
        Me.adi.Size = New System.Drawing.Size(10, 13)
        Me.adi.TabIndex = 91
        Me.adi.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Soyadı:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Adı:"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(259, 16)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(10, 13)
        Me.id.TabIndex = 89
        Me.id.Text = "-"
        '
        'k_karti
        '
        Me.k_karti.AutoSize = True
        Me.k_karti.Location = New System.Drawing.Point(163, 121)
        Me.k_karti.Name = "k_karti"
        Me.k_karti.Size = New System.Drawing.Size(76, 17)
        Me.k_karti.TabIndex = 88
        Me.k_karti.TabStop = True
        Me.k_karti.Text = "Kredi Kartı "
        Me.k_karti.UseVisualStyleBackColor = True
        '
        'nakit
        '
        Me.nakit.AutoSize = True
        Me.nakit.Location = New System.Drawing.Point(107, 121)
        Me.nakit.Name = "nakit"
        Me.nakit.Size = New System.Drawing.Size(50, 17)
        Me.nakit.TabIndex = 87
        Me.nakit.TabStop = True
        Me.nakit.Text = "Nakit"
        Me.nakit.UseVisualStyleBackColor = True
        '
        'lblToplam
        '
        Me.lblToplam.AutoSize = True
        Me.lblToplam.Location = New System.Drawing.Point(91, 87)
        Me.lblToplam.Name = "lblToplam"
        Me.lblToplam.Size = New System.Drawing.Size(10, 13)
        Me.lblToplam.TabIndex = 86
        Me.lblToplam.Text = "-"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.ÖdevPizza.My.Resources.Resources.cash
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(68, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 52)
        Me.Button3.TabIndex = 85
        Me.Button3.Text = "Öde"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.ÖdevPizza.My.Resources.Resources.fatura
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(68, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 52)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Fiş"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(32, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 26)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "*Nakit ödeme yapılırsa %10 indirim, kredi kartı " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ödeme yapılırsa %3 olacaktır!"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label.Location = New System.Drawing.Point(18, 155)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(72, 13)
        Me.label.TabIndex = 80
        Me.label.Text = "İndirimli Tutar:"
        '
        'labelOdeme
        '
        Me.labelOdeme.AutoSize = True
        Me.labelOdeme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.labelOdeme.Location = New System.Drawing.Point(16, 123)
        Me.labelOdeme.Name = "labelOdeme"
        Me.labelOdeme.Size = New System.Drawing.Size(85, 13)
        Me.labelOdeme.TabIndex = 78
        Me.labelOdeme.Text = "Ödeme Yöntemi:"
        '
        'labelToplamTutar
        '
        Me.labelToplamTutar.AutoSize = True
        Me.labelToplamTutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.labelToplamTutar.Location = New System.Drawing.Point(16, 87)
        Me.labelToplamTutar.Name = "labelToplamTutar"
        Me.labelToplamTutar.Size = New System.Drawing.Size(73, 13)
        Me.labelToplamTutar.TabIndex = 75
        Me.labelToplamTutar.Text = "Toplam Tutar:"
        '
        'tl
        '
        Me.tl.AutoSize = True
        Me.tl.Location = New System.Drawing.Point(112, 87)
        Me.tl.Name = "tl"
        Me.tl.Size = New System.Drawing.Size(10, 13)
        Me.tl.TabIndex = 94
        Me.tl.Text = "-"
        '
        'Odeme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 360)
        Me.Controls.Add(Me.odemegrup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Odeme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ödeme"
        Me.odemegrup.ResumeLayout(False)
        Me.odemegrup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents odemegrup As GroupBox
    Private WithEvents label As Label
    Private WithEvents labelOdeme As Label
    Private WithEvents labelToplamTutar As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblToplam As Label
    Friend WithEvents k_karti As RadioButton
    Friend WithEvents nakit As RadioButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents id As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents adi As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblIndirimliTutar As Label
    Friend WithEvents tl As Label
    Friend WithEvents soyadi As Label
    Friend WithEvents Label1 As Label
    Private WithEvents Label2 As Label
End Class
