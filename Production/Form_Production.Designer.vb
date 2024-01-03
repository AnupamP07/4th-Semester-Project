<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Production
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_Production))
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button_Report = New Button()
        Btn_Jit = New Button()
        Btn_Schedule = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Btn_Report = New Button()
        Btn_ManageProduct = New Button()
        Btn_ChgPwd = New Button()
        Btn_ManageStock = New Button()
        Btn_ManageUser = New Button()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 65)
        Panel1.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(Button_Report, 2, 0)
        TableLayoutPanel2.Controls.Add(Btn_Jit, 1, 0)
        TableLayoutPanel2.Controls.Add(Btn_Schedule, 0, 0)
        TableLayoutPanel2.Location = New Point(286, 10)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(511, 47)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' Button_Report
        ' 
        Button_Report.BackColor = SystemColors.HotTrack
        Button_Report.Cursor = Cursors.Hand
        Button_Report.Dock = DockStyle.Fill
        Button_Report.FlatAppearance.BorderSize = 0
        Button_Report.FlatStyle = FlatStyle.Flat
        Button_Report.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Report.ForeColor = SystemColors.Control
        Button_Report.Location = New Point(343, 3)
        Button_Report.Name = "Button_Report"
        Button_Report.Size = New Size(165, 41)
        Button_Report.TabIndex = 4
        Button_Report.Text = "REPORT"
        Button_Report.UseVisualStyleBackColor = False
        ' 
        ' Btn_Jit
        ' 
        Btn_Jit.BackColor = SystemColors.HotTrack
        Btn_Jit.Cursor = Cursors.Hand
        Btn_Jit.Dock = DockStyle.Fill
        Btn_Jit.FlatAppearance.BorderSize = 0
        Btn_Jit.FlatStyle = FlatStyle.Flat
        Btn_Jit.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Jit.ForeColor = SystemColors.Control
        Btn_Jit.Location = New Point(173, 3)
        Btn_Jit.Name = "Btn_Jit"
        Btn_Jit.Size = New Size(164, 41)
        Btn_Jit.TabIndex = 3
        Btn_Jit.Text = "JIT GENERATE"
        Btn_Jit.UseVisualStyleBackColor = False
        ' 
        ' Btn_Schedule
        ' 
        Btn_Schedule.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn_Schedule.BackColor = SystemColors.HotTrack
        Btn_Schedule.Cursor = Cursors.Hand
        Btn_Schedule.FlatAppearance.BorderSize = 0
        Btn_Schedule.FlatStyle = FlatStyle.Flat
        Btn_Schedule.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Schedule.ForeColor = SystemColors.Control
        Btn_Schedule.Location = New Point(3, 3)
        Btn_Schedule.Name = "Btn_Schedule"
        Btn_Schedule.Size = New Size(164, 41)
        Btn_Schedule.TabIndex = 2
        Btn_Schedule.Text = "MANAGE SCHEDULE"
        Btn_Schedule.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.DarkOrange
        Label2.Location = New Point(93, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 3
        Label2.Text = "System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(93, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 19)
        Label3.TabIndex = 4
        Label3.Text = "Management"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkOrange
        Label1.Location = New Point(93, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 2
        Label1.Text = "Stock"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(17, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(72, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(Btn_Report, 4, 0)
        TableLayoutPanel1.Controls.Add(Btn_ManageProduct, 0, 0)
        TableLayoutPanel1.Controls.Add(Btn_ChgPwd, 3, 0)
        TableLayoutPanel1.Controls.Add(Btn_ManageStock, 1, 0)
        TableLayoutPanel1.Controls.Add(Btn_ManageUser, 2, 0)
        TableLayoutPanel1.Location = New Point(890, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(655, 59)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Btn_Report
        ' 
        Btn_Report.BackColor = SystemColors.Highlight
        Btn_Report.Cursor = Cursors.Hand
        Btn_Report.Dock = DockStyle.Fill
        Btn_Report.FlatAppearance.BorderSize = 0
        Btn_Report.FlatStyle = FlatStyle.Flat
        Btn_Report.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Report.Location = New Point(527, 3)
        Btn_Report.Name = "Btn_Report"
        Btn_Report.Size = New Size(125, 53)
        Btn_Report.TabIndex = 6
        Btn_Report.Text = "Report"
        Btn_Report.UseVisualStyleBackColor = False
        ' 
        ' Btn_ManageProduct
        ' 
        Btn_ManageProduct.BackColor = SystemColors.Highlight
        Btn_ManageProduct.Cursor = Cursors.Hand
        Btn_ManageProduct.Dock = DockStyle.Fill
        Btn_ManageProduct.FlatAppearance.BorderSize = 0
        Btn_ManageProduct.FlatStyle = FlatStyle.Flat
        Btn_ManageProduct.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_ManageProduct.Location = New Point(3, 3)
        Btn_ManageProduct.Name = "Btn_ManageProduct"
        Btn_ManageProduct.Size = New Size(125, 53)
        Btn_ManageProduct.TabIndex = 2
        Btn_ManageProduct.Text = "Manage Products"
        Btn_ManageProduct.UseVisualStyleBackColor = False
        ' 
        ' Btn_ChgPwd
        ' 
        Btn_ChgPwd.BackColor = SystemColors.Highlight
        Btn_ChgPwd.Cursor = Cursors.Hand
        Btn_ChgPwd.Dock = DockStyle.Fill
        Btn_ChgPwd.FlatAppearance.BorderSize = 0
        Btn_ChgPwd.FlatStyle = FlatStyle.Flat
        Btn_ChgPwd.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_ChgPwd.Location = New Point(396, 3)
        Btn_ChgPwd.Name = "Btn_ChgPwd"
        Btn_ChgPwd.Size = New Size(125, 53)
        Btn_ChgPwd.TabIndex = 5
        Btn_ChgPwd.Text = "Change Password"
        Btn_ChgPwd.UseVisualStyleBackColor = False
        ' 
        ' Btn_ManageStock
        ' 
        Btn_ManageStock.BackColor = SystemColors.Highlight
        Btn_ManageStock.Cursor = Cursors.Hand
        Btn_ManageStock.Dock = DockStyle.Fill
        Btn_ManageStock.FlatAppearance.BorderSize = 0
        Btn_ManageStock.FlatStyle = FlatStyle.Flat
        Btn_ManageStock.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_ManageStock.Location = New Point(134, 3)
        Btn_ManageStock.Name = "Btn_ManageStock"
        Btn_ManageStock.Size = New Size(125, 53)
        Btn_ManageStock.TabIndex = 3
        Btn_ManageStock.Text = "Manage Stock"
        Btn_ManageStock.UseVisualStyleBackColor = False
        ' 
        ' Btn_ManageUser
        ' 
        Btn_ManageUser.BackColor = SystemColors.Highlight
        Btn_ManageUser.Cursor = Cursors.Hand
        Btn_ManageUser.Dock = DockStyle.Fill
        Btn_ManageUser.FlatAppearance.BorderSize = 0
        Btn_ManageUser.FlatStyle = FlatStyle.Flat
        Btn_ManageUser.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_ManageUser.Location = New Point(265, 3)
        Btn_ManageUser.Name = "Btn_ManageUser"
        Btn_ManageUser.Size = New Size(125, 53)
        Btn_ManageUser.TabIndex = 4
        Btn_ManageUser.Text = "Manage Users"
        Btn_ManageUser.UseVisualStyleBackColor = False
        ' 
        ' Form_Production
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Form_Production"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Production"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_Report As Button
    Friend WithEvents Btn_ManageProduct As Button
    Friend WithEvents Btn_ChgPwd As Button
    Friend WithEvents Btn_ManageStock As Button
    Friend WithEvents Btn_ManageUser As Button
    Friend WithEvents Btn_Schedule As Button
    Friend WithEvents Btn_Jit As Button
    Friend WithEvents Button_Report As Button
End Class
