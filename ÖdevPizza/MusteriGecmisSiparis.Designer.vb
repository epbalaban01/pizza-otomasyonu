<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusteriGecmisSiparis
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusteriGecmisSiparis))
        Me.label9 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.islem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_no = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adisoyadi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.hazir = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Silver
        Me.label9.Location = New System.Drawing.Point(126, 166)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(555, 20)
        Me.label9.TabIndex = 42
        Me.label9.Text = "Geçmiş siparişlerini daha detaylı görmek için tabloda olanları tıklayın!"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(14, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(773, 121)
        Me.ListBox1.TabIndex = 41
        '
        'islem
        '
        Me.islem.AutoSize = True
        Me.islem.Location = New System.Drawing.Point(461, 11)
        Me.islem.Name = "islem"
        Me.islem.Size = New System.Drawing.Size(10, 13)
        Me.islem.TabIndex = 40
        Me.islem.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "İşlem:"
        '
        'id_no
        '
        Me.id_no.AutoSize = True
        Me.id_no.Location = New System.Drawing.Point(777, 11)
        Me.id_no.Name = "id_no"
        Me.id_no.Size = New System.Drawing.Size(10, 13)
        Me.id_no.TabIndex = 38
        Me.id_no.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(733, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "ID No:"
        '
        'adisoyadi
        '
        Me.adisoyadi.AutoSize = True
        Me.adisoyadi.Location = New System.Drawing.Point(77, 11)
        Me.adisoyadi.Name = "adisoyadi"
        Me.adisoyadi.Size = New System.Drawing.Size(10, 13)
        Me.adisoyadi.TabIndex = 36
        Me.adisoyadi.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Adı Soyadı:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(14, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 250)
        Me.DataGridView1.TabIndex = 33
        '
        'hazir
        '
        Me.hazir.AutoSize = True
        Me.hazir.Location = New System.Drawing.Point(265, 316)
        Me.hazir.Name = "hazir"
        Me.hazir.Size = New System.Drawing.Size(31, 13)
        Me.hazir.TabIndex = 34
        Me.hazir.Text = "Hazır"
        '
        'MusteriGecmisSiparis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 450)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.islem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_no)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.adisoyadi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.hazir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MusteriGecmisSiparis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geçmiş Siparişlerim"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label9 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents islem As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id_no As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents adisoyadi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents hazir As Label
End Class
