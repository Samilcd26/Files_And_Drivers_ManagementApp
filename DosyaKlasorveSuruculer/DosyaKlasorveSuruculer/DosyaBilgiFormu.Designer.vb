<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DosyaBilgiFormu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DosyaBilgiFormu))
        Me.BilgiLBox = New System.Windows.Forms.ListBox()
        Me.DosyaSecBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DosyaTBox = New System.Windows.Forms.TextBox()
        Me.DosyaAcDialog = New System.Windows.Forms.OpenFileDialog()
        Me.KopyalaBtn = New System.Windows.Forms.Button()
        Me.TasiBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BilgiLBox
        '
        Me.BilgiLBox.FormattingEnabled = True
        Me.BilgiLBox.ItemHeight = 15
        Me.BilgiLBox.Location = New System.Drawing.Point(12, 77)
        Me.BilgiLBox.Name = "BilgiLBox"
        Me.BilgiLBox.Size = New System.Drawing.Size(483, 259)
        Me.BilgiLBox.TabIndex = 8
        '
        'DosyaSecBtn
        '
        Me.DosyaSecBtn.Image = CType(resources.GetObject("DosyaSecBtn.Image"), System.Drawing.Image)
        Me.DosyaSecBtn.Location = New System.Drawing.Point(435, 11)
        Me.DosyaSecBtn.Name = "DosyaSecBtn"
        Me.DosyaSecBtn.Size = New System.Drawing.Size(60, 60)
        Me.DosyaSecBtn.TabIndex = 7
        Me.DosyaSecBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dosya Bilgileri"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dosya Seçiniz:"
        '
        'DosyaTBox
        '
        Me.DosyaTBox.Location = New System.Drawing.Point(99, 11)
        Me.DosyaTBox.Name = "DosyaTBox"
        Me.DosyaTBox.ReadOnly = True
        Me.DosyaTBox.Size = New System.Drawing.Size(330, 23)
        Me.DosyaTBox.TabIndex = 9
        '
        'DosyaAcDialog
        '
        Me.DosyaAcDialog.Filter = "Tüm Dosyalar|*.*"
        '
        'KopyalaBtn
        '
        Me.KopyalaBtn.Image = CType(resources.GetObject("KopyalaBtn.Image"), System.Drawing.Image)
        Me.KopyalaBtn.Location = New System.Drawing.Point(12, 342)
        Me.KopyalaBtn.Name = "KopyalaBtn"
        Me.KopyalaBtn.Size = New System.Drawing.Size(163, 48)
        Me.KopyalaBtn.TabIndex = 10
        Me.KopyalaBtn.Text = "Dosyayı Kopyala"
        Me.KopyalaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KopyalaBtn.UseVisualStyleBackColor = True
        '
        'TasiBtn
        '
        Me.TasiBtn.Image = CType(resources.GetObject("TasiBtn.Image"), System.Drawing.Image)
        Me.TasiBtn.Location = New System.Drawing.Point(332, 342)
        Me.TasiBtn.Name = "TasiBtn"
        Me.TasiBtn.Size = New System.Drawing.Size(163, 48)
        Me.TasiBtn.TabIndex = 11
        Me.TasiBtn.Text = "Dosyayı Taşı"
        Me.TasiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TasiBtn.UseVisualStyleBackColor = True
        '
        'DosyaBilgiFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 402)
        Me.Controls.Add(Me.TasiBtn)
        Me.Controls.Add(Me.KopyalaBtn)
        Me.Controls.Add(Me.DosyaTBox)
        Me.Controls.Add(Me.BilgiLBox)
        Me.Controls.Add(Me.DosyaSecBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DosyaBilgiFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dosya Bilgileri"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BilgiLBox As ListBox
    Friend WithEvents DosyaSecBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DosyaTBox As TextBox
    Friend WithEvents DosyaAcDialog As OpenFileDialog
    Friend WithEvents KopyalaBtn As Button
    Friend WithEvents TasiBtn As Button
End Class
