<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(User_Login))
        Text_Username = New TextBox()
        Text_Password = New TextBox()
        Button_Login = New Button()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox_Login = New PictureBox()
        CType(PictureBox_Login, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Text_Username
        ' 
        Text_Username.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Text_Username.Location = New Point(39, 136)
        Text_Username.Name = "Text_Username"
        Text_Username.Size = New Size(227, 23)
        Text_Username.TabIndex = 0
        ' 
        ' Text_Password
        ' 
        Text_Password.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Text_Password.Location = New Point(39, 187)
        Text_Password.Name = "Text_Password"
        Text_Password.Size = New Size(227, 23)
        Text_Password.TabIndex = 1
        Text_Password.UseSystemPasswordChar = True
        ' 
        ' Button_Login
        ' 
        Button_Login.BackColor = SystemColors.Highlight
        Button_Login.Cursor = Cursors.Hand
        Button_Login.FlatAppearance.BorderSize = 0
        Button_Login.FlatStyle = FlatStyle.Flat
        Button_Login.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Login.Location = New Point(39, 225)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(227, 28)
        Button_Login.TabIndex = 3
        Button_Login.Text = "Login Here"
        Button_Login.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(39, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 16)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(39, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 16)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' PictureBox_Login
        ' 
        PictureBox_Login.Image = CType(resources.GetObject("PictureBox_Login.Image"), Image)
        PictureBox_Login.Location = New Point(94, 9)
        PictureBox_Login.Margin = New Padding(0)
        PictureBox_Login.Name = "PictureBox_Login"
        PictureBox_Login.Size = New Size(110, 106)
        PictureBox_Login.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_Login.TabIndex = 6
        PictureBox_Login.TabStop = False
        ' 
        ' User_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(306, 276)
        Controls.Add(PictureBox_Login)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button_Login)
        Controls.Add(Text_Password)
        Controls.Add(Text_Username)
        Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "User_Login"
        Text = "User Login"
        CType(PictureBox_Login, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Text_Username As TextBox
    Friend WithEvents Text_Password As TextBox
    Friend WithEvents Button_Login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox_Login As PictureBox
End Class
