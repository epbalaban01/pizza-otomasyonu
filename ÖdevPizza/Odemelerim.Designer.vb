<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Odemelerim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Odemelerim))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAdiSoyadi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.o_yontemi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ıodeme = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.odeme = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.toplamodeme = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.toplamindirimodeme = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adı Soyadı:"
        '
        'lblAdiSoyadi
        '
        Me.lblAdiSoyadi.AutoSize = True
        Me.lblAdiSoyadi.Location = New System.Drawing.Point(100, 9)
        Me.lblAdiSoyadi.Name = "lblAdiSoyadi"
        Me.lblAdiSoyadi.Size = New System.Drawing.Size(10, 13)
        Me.lblAdiSoyadi.TabIndex = 1
        Me.lblAdiSoyadi.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(705, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID No:"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(749, 9)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(10, 13)
        Me.id.TabIndex = 3
        Me.id.Text = "-"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(752, 224)
        Me.DataGridView1.TabIndex = 4
        '
        'o_yontemi
        '
        Me.o_yontemi.AutoSize = True
        Me.o_yontemi.Location = New System.Drawing.Point(605, 40)
        Me.o_yontemi.Name = "o_yontemi"
        Me.o_yontemi.Size = New System.Drawing.Size(10, 13)
        Me.o_yontemi.TabIndex = 40
        Me.o_yontemi.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Ödeme Yöntemi:"
        '
        'ıodeme
        '
        Me.ıodeme.AutoSize = True
        Me.ıodeme.Location = New System.Drawing.Point(346, 39)
        Me.ıodeme.Name = "ıodeme"
        Me.ıodeme.Size = New System.Drawing.Size(10, 13)
        Me.ıodeme.TabIndex = 38
        Me.ıodeme.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "İndirimli Ödeme:"
        '
        'odeme
        '
        Me.odeme.AutoSize = True
        Me.odeme.Location = New System.Drawing.Point(97, 40)
        Me.odeme.Name = "odeme"
        Me.odeme.Size = New System.Drawing.Size(10, 13)
        Me.odeme.TabIndex = 36
        Me.odeme.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Ödeme:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Silver
        Me.label9.Location = New System.Drawing.Point(140, 112)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(495, 20)
        Me.label9.TabIndex = 34
        Me.label9.Text = "Ödemelerini daha detaylı görmek için tabloda olanları tıklayın!"
        '
        'toplamodeme
        '
        Me.toplamodeme.AutoSize = True
        Me.toplamodeme.Location = New System.Drawing.Point(243, 79)
        Me.toplamodeme.Name = "toplamodeme"
        Me.toplamodeme.Size = New System.Drawing.Size(10, 13)
        Me.toplamodeme.TabIndex = 41
        Me.toplamodeme.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(155, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Toplam Ödeme:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 2)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'toplamindirimodeme
        '
        Me.toplamindirimodeme.AutoSize = True
        Me.toplamindirimodeme.Location = New System.Drawing.Point(515, 79)
        Me.toplamindirimodeme.Name = "toplamindirimodeme"
        Me.toplamindirimodeme.Size = New System.Drawing.Size(10, 13)
        Me.toplamindirimodeme.TabIndex = 41
        Me.toplamindirimodeme.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(390, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Toplam İndirimli Ödeme:"
        '
        'Odemelerim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.toplamindirimodeme)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.toplamodeme)
        Me.Controls.Add(Me.o_yontemi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ıodeme)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.odeme)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAdiSoyadi)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Odemelerim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ödemelerim"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAdiSoyadi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents id As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents o_yontemi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ıodeme As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents odeme As Label
    Friend WithEvents Label2 As Label
    Private WithEvents label9 As Label
    Friend WithEvents toplamodeme As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents toplamindirimodeme As Label
    Friend WithEvents Label8 As Label
End Class
