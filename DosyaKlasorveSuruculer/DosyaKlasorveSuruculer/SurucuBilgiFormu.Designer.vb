<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurucuBilgiFormu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SurucuBilgiFormu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SurucuCBox = New System.Windows.Forms.ComboBox()
        Me.TazeleBtn = New System.Windows.Forms.Button()
        Me.BilgiLBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sürücü Seçiniz:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sürücü Bilgileri"
        '
        'SurucuCBox
        '
        Me.SurucuCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SurucuCBox.FormattingEnabled = True
        Me.SurucuCBox.Location = New System.Drawing.Point(104, 31)
        Me.SurucuCBox.Name = "SurucuCBox"
        Me.SurucuCBox.Size = New System.Drawing.Size(161, 23)
        Me.SurucuCBox.TabIndex = 2
        '
        'TazeleBtn
        '
        Me.TazeleBtn.Image = CType(resources.GetObject("TazeleBtn.Image"), System.Drawing.Image)
        Me.TazeleBtn.Location = New System.Drawing.Point(263, 30)
        Me.TazeleBtn.Name = "TazeleBtn"
        Me.TazeleBtn.Size = New System.Drawing.Size(25, 25)
        Me.TazeleBtn.TabIndex = 3
        Me.TazeleBtn.UseVisualStyleBackColor = True
        '
        'BilgiLBox
        '
        Me.BilgiLBox.FormattingEnabled = True
        Me.BilgiLBox.ItemHeight = 15
        Me.BilgiLBox.Location = New System.Drawing.Point(12, 81)
        Me.BilgiLBox.Name = "BilgiLBox"
        Me.BilgiLBox.Size = New System.Drawing.Size(483, 259)
        Me.BilgiLBox.TabIndex = 4
        '
        'SurucuBilgiFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 363)
        Me.Controls.Add(Me.BilgiLBox)
        Me.Controls.Add(Me.TazeleBtn)
        Me.Controls.Add(Me.SurucuCBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SurucuBilgiFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sürücü Bilgileri"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SurucuCBox As ComboBox
    Friend WithEvents TazeleBtn As Button
    Friend WithEvents BilgiLBox As ListBox
End Class
