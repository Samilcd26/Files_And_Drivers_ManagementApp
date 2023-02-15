<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.SurucuBilgiBtn = New System.Windows.Forms.Button()
        Me.KlasorislemBtn = New System.Windows.Forms.Button()
        Me.DosyaBilgiBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SurucuBilgiBtn
        '
        Me.SurucuBilgiBtn.Image = CType(resources.GetObject("SurucuBilgiBtn.Image"), System.Drawing.Image)
        Me.SurucuBilgiBtn.Location = New System.Drawing.Point(12, 46)
        Me.SurucuBilgiBtn.Name = "SurucuBilgiBtn"
        Me.SurucuBilgiBtn.Size = New System.Drawing.Size(203, 62)
        Me.SurucuBilgiBtn.TabIndex = 0
        Me.SurucuBilgiBtn.Text = "Sürücü Bilgileri"
        Me.SurucuBilgiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SurucuBilgiBtn.UseVisualStyleBackColor = True
        '
        'KlasorislemBtn
        '
        Me.KlasorislemBtn.Image = CType(resources.GetObject("KlasorislemBtn.Image"), System.Drawing.Image)
        Me.KlasorislemBtn.Location = New System.Drawing.Point(12, 124)
        Me.KlasorislemBtn.Name = "KlasorislemBtn"
        Me.KlasorislemBtn.Size = New System.Drawing.Size(203, 62)
        Me.KlasorislemBtn.TabIndex = 1
        Me.KlasorislemBtn.Text = "Klasör İşlemleri"
        Me.KlasorislemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KlasorislemBtn.UseVisualStyleBackColor = True
        '
        'DosyaBilgiBtn
        '
        Me.DosyaBilgiBtn.Image = CType(resources.GetObject("DosyaBilgiBtn.Image"), System.Drawing.Image)
        Me.DosyaBilgiBtn.Location = New System.Drawing.Point(12, 202)
        Me.DosyaBilgiBtn.Name = "DosyaBilgiBtn"
        Me.DosyaBilgiBtn.Size = New System.Drawing.Size(203, 62)
        Me.DosyaBilgiBtn.TabIndex = 2
        Me.DosyaBilgiBtn.Text = "Dosya Bilgileri"
        Me.DosyaBilgiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DosyaBilgiBtn.UseVisualStyleBackColor = True
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 328)
        Me.Controls.Add(Me.DosyaBilgiBtn)
        Me.Controls.Add(Me.KlasorislemBtn)
        Me.Controls.Add(Me.SurucuBilgiBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AnaForm"
        Me.Text = "DKS Bilgi"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SurucuBilgiBtn As Button
    Friend WithEvents KlasorislemBtn As Button
    Friend WithEvents DosyaBilgiBtn As Button
End Class
