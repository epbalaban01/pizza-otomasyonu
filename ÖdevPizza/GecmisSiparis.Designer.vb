<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GecmisSiparis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GecmisSiparis))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.id_no = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.islem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adi = New System.Windows.Forms.Label()
        Me.hazir = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.id_no)
        Me.GroupBox1.Controls.Add(Me.dataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.islem)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.adi)
        Me.GroupBox1.Controls.Add(Me.hazir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 445)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(20, 76)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(764, 108)
        Me.ListBox1.TabIndex = 28
        '
        'id_no
        '
        Me.id_no.AutoSize = True
        Me.id_no.Location = New System.Drawing.Point(736, 44)
        Me.id_no.Name = "id_no"
        Me.id_no.Size = New System.Drawing.Size(10, 13)
        Me.id_no.TabIndex = 27
        Me.id_no.Text = "-"
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dataGridView1.Location = New System.Drawing.Point(17, 198)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(767, 229)
        Me.dataGridView1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(690, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "ID No:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Silver
        Me.label9.Location = New System.Drawing.Point(233, 14)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(256, 20)
        Me.label9.TabIndex = 21
        Me.label9.Text = "Müşteri Geçmiş Sipariş Bilgileri"
        '
        'islem
        '
        Me.islem.AutoSize = True
        Me.islem.Location = New System.Drawing.Point(380, 45)
        Me.islem.Name = "islem"
        Me.islem.Size = New System.Drawing.Size(10, 13)
        Me.islem.TabIndex = 25
        Me.islem.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Adı:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "İşlem:"
        '
        'adi
        '
        Me.adi.AutoSize = True
        Me.adi.Location = New System.Drawing.Point(48, 45)
        Me.adi.Name = "adi"
        Me.adi.Size = New System.Drawing.Size(10, 13)
        Me.adi.TabIndex = 23
        Me.adi.Text = "-"
        '
        'hazir
        '
        Me.hazir.AutoSize = True
        Me.hazir.Location = New System.Drawing.Point(279, 279)
        Me.hazir.Name = "hazir"
        Me.hazir.Size = New System.Drawing.Size(31, 13)
        Me.hazir.TabIndex = 10
        Me.hazir.Text = "Hazır"
        '
        'GecmisSiparis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GecmisSiparis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geçmiş Sipariş"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents id_no As Label
    Public WithEvents dataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Private WithEvents label9 As Label
    Friend WithEvents islem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents adi As Label
    Friend WithEvents hazir As Label
End Class
