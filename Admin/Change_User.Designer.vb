<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_User
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
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 79)
        Button1.TabIndex = 0
        Button1.Text = "ACCESS PRODUCTION"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(182, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 79)
        Button2.TabIndex = 1
        Button2.Text = "ACCESS STORE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Change_User
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(350, 106)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Change_User"
        Text = "Change_User"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
