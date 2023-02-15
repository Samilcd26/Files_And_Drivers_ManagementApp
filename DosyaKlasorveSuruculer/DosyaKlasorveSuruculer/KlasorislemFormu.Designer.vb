<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KlasorislemFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KlasorislemFormu))
        Me.OlusturBtn = New System.Windows.Forms.Button()
        Me.KopyalaBtn = New System.Windows.Forms.Button()
        Me.SilBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KlasorAdiTBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OlusturBtn
        '
        Me.OlusturBtn.Image = CType(resources.GetObject("OlusturBtn.Image"), System.Drawing.Image)
        Me.OlusturBtn.Location = New System.Drawing.Point(12, 69)
        Me.OlusturBtn.Name = "OlusturBtn"
        Me.OlusturBtn.Size = New System.Drawing.Size(167, 66)
        Me.OlusturBtn.TabIndex = 0
        Me.OlusturBtn.Text = "Klasör Oluştur"
        Me.OlusturBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OlusturBtn.UseVisualStyleBackColor = True
        '
        'KopyalaBtn
        '
        Me.KopyalaBtn.Image = CType(resources.GetObject("KopyalaBtn.Image"), System.Drawing.Image)
        Me.KopyalaBtn.Location = New System.Drawing.Point(12, 143)
        Me.KopyalaBtn.Name = "KopyalaBtn"
        Me.KopyalaBtn.Size = New System.Drawing.Size(167, 66)
        Me.KopyalaBtn.TabIndex = 1
        Me.KopyalaBtn.Text = "Klasörü Kopyala"
        Me.KopyalaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KopyalaBtn.UseVisualStyleBackColor = True
        '
        'SilBtn
        '
        Me.SilBtn.Image = CType(resources.GetObject("SilBtn.Image"), System.Drawing.Image)
        Me.SilBtn.Location = New System.Drawing.Point(12, 217)
        Me.SilBtn.Name = "SilBtn"
        Me.SilBtn.Size = New System.Drawing.Size(167, 66)
        Me.SilBtn.TabIndex = 2
        Me.SilBtn.Text = "Klasörü Sil"
        Me.SilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SilBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Klasör Adı:"
        '
        'KlasorAdiTBox
        '
        Me.KlasorAdiTBox.Location = New System.Drawing.Point(12, 40)
        Me.KlasorAdiTBox.Name = "KlasorAdiTBox"
        Me.KlasorAdiTBox.Size = New System.Drawing.Size(167, 23)
        Me.KlasorAdiTBox.TabIndex = 4
        '
        'KlasorislemFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 312)
        Me.Controls.Add(Me.KlasorAdiTBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SilBtn)
        Me.Controls.Add(Me.KopyalaBtn)
        Me.Controls.Add(Me.OlusturBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KlasorislemFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Klasör İşlemleri"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OlusturBtn As Button
    Friend WithEvents KopyalaBtn As Button
    Friend WithEvents SilBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents KlasorAdiTBox As TextBox
End Class
