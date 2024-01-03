<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ManageUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_ManageUser))
        ComboBox_Role = New ComboBox()
        txt_Name = New Label()
        txt_Username = New Label()
        txt_Password = New Label()
        txt_Role = New Label()
        txt_ManageUser = New Label()
        PictureBox_ManageUser = New PictureBox()
        Button_Register = New Button()
        TextBox_Name = New TextBox()
        TextBox_Username = New TextBox()
        TextBox_Password = New TextBox()
        CType(PictureBox_ManageUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox_Role
        ' 
        ComboBox_Role.FormattingEnabled = True
        ComboBox_Role.Items.AddRange(New Object() {resources.GetString("ComboBox_Role.Items"), resources.GetString("ComboBox_Role.Items1"), resources.GetString("ComboBox_Role.Items2")})
        resources.ApplyResources(ComboBox_Role, "ComboBox_Role")
        ComboBox_Role.Name = "ComboBox_Role"
        ' 
        ' txt_Name
        ' 
        resources.ApplyResources(txt_Name, "txt_Name")
        txt_Name.Name = "txt_Name"
        ' 
        ' txt_Username
        ' 
        resources.ApplyResources(txt_Username, "txt_Username")
        txt_Username.Name = "txt_Username"
        ' 
        ' txt_Password
        ' 
        resources.ApplyResources(txt_Password, "txt_Password")
        txt_Password.Name = "txt_Password"
        ' 
        ' txt_Role
        ' 
        resources.ApplyResources(txt_Role, "txt_Role")
        txt_Role.Name = "txt_Role"
        ' 
        ' txt_ManageUser
        ' 
        resources.ApplyResources(txt_ManageUser, "txt_ManageUser")
        txt_ManageUser.Name = "txt_ManageUser"
        ' 
        ' PictureBox_ManageUser
        ' 
        resources.ApplyResources(PictureBox_ManageUser, "PictureBox_ManageUser")
        PictureBox_ManageUser.Name = "PictureBox_ManageUser"
        PictureBox_ManageUser.TabStop = False
        ' 
        ' Button_Register
        ' 
        Button_Register.BackColor = Color.Blue
        Button_Register.Cursor = Cursors.Hand
        Button_Register.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Button_Register, "Button_Register")
        Button_Register.ForeColor = SystemColors.ButtonHighlight
        Button_Register.Name = "Button_Register"
        Button_Register.UseVisualStyleBackColor = False
        ' 
        ' TextBox_Name
        ' 
        resources.ApplyResources(TextBox_Name, "TextBox_Name")
        TextBox_Name.Name = "TextBox_Name"
        ' 
        ' TextBox_Username
        ' 
        resources.ApplyResources(TextBox_Username, "TextBox_Username")
        TextBox_Username.Name = "TextBox_Username"
        ' 
        ' TextBox_Password
        ' 
        resources.ApplyResources(TextBox_Password, "TextBox_Password")
        TextBox_Password.Name = "TextBox_Password"
        ' 
        ' Form_ManageUser
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        Controls.Add(PictureBox_ManageUser)
        Controls.Add(TextBox_Password)
        Controls.Add(TextBox_Username)
        Controls.Add(TextBox_Name)
        Controls.Add(txt_ManageUser)
        Controls.Add(Button_Register)
        Controls.Add(txt_Role)
        Controls.Add(txt_Password)
        Controls.Add(txt_Username)
        Controls.Add(txt_Name)
        Controls.Add(ComboBox_Role)
        Name = "Form_ManageUser"
        CType(PictureBox_ManageUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ComboBox_Role As ComboBox
    Friend WithEvents txt_Name As Label
    Friend WithEvents txt_Username As Label
    Friend WithEvents txt_Password As Label
    Friend WithEvents txt_Role As Label
    Friend WithEvents txt_ManageUser As Label
    Friend WithEvents PictureBox_ManageUser As PictureBox
    Friend WithEvents Button_Register As Button
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
End Class
