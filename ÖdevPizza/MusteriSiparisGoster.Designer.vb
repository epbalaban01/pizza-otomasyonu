<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusteriSiparisGoster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusteriSiparisGoster))
        Me.id = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labeladisoyadi = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.islem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.beklemede = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(651, 9)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(10, 13)
        Me.id.TabIndex = 0
        Me.id.Text = "-"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(12, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(653, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(655, 95)
        Me.ListBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Adı Soyadı:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(609, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID No:"
        '
        'labeladisoyadi
        '
        Me.labeladisoyadi.AutoSize = True
        Me.labeladisoyadi.Location = New System.Drawing.Point(78, 9)
        Me.labeladisoyadi.Name = "labeladisoyadi"
        Me.labeladisoyadi.Size = New System.Drawing.Size(10, 13)
        Me.labeladisoyadi.TabIndex = 4
        Me.labeladisoyadi.Text = "-"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Silver
        Me.label9.Location = New System.Drawing.Point(77, 133)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(493, 20)
        Me.label9.TabIndex = 26
        Me.label9.Text = "Siparişlerini daha detaylı görmek için tabloda olanları tıklayın!"
        '
        'islem
        '
        Me.islem.AutoSize = True
        Me.islem.Location = New System.Drawing.Point(415, 9)
        Me.islem.Name = "islem"
        Me.islem.Size = New System.Drawing.Size(10, 13)
        Me.islem.TabIndex = 30
        Me.islem.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "İşlem:"
        '
        'beklemede
        '
        Me.beklemede.AutoSize = True
        Me.beklemede.Location = New System.Drawing.Point(260, 238)
        Me.beklemede.Name = "beklemede"
        Me.beklemede.Size = New System.Drawing.Size(60, 13)
        Me.beklemede.TabIndex = 31
        Me.beklemede.Text = "Beklemede"
        '
        'MusteriSiparisGoster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 319)
        Me.Controls.Add(Me.islem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.labeladisoyadi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.beklemede)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MusteriSiparisGoster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sipariş Göster"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labeladisoyadi As Label
    Private WithEvents label9 As Label
    Friend WithEvents islem As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents beklemede As Label
End Class
