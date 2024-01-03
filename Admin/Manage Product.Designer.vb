<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Product
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Manage_Product))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        TextBox_Search = New TextBox()
        Label_Search = New Label()
        TabPage2 = New TabPage()
        Lbl_Price = New Label()
        Lbl_Size = New Label()
        Lbl_colour = New Label()
        Lbl_Name = New Label()
        Cmb_Size = New ComboBox()
        Cmb_Color = New ComboBox()
        Txt_Price = New TextBox()
        Txt_pName = New TextBox()
        Txt_ID = New TextBox()
        Lbl_pID = New Label()
        Btn_Clear = New Button()
        Btn_Save = New Button()
        PictureBox1 = New PictureBox()
        Clm_SN = New DataGridViewTextBoxColumn()
        Clm_ProductID = New DataGridViewTextBoxColumn()
        Clm_ProductName = New DataGridViewTextBoxColumn()
        Clm_Color = New DataGridViewTextBoxColumn()
        Clm_Size = New DataGridViewTextBoxColumn()
        Clm_Price = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.ItemSize = New Size(105, 35)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 450)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 39)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 407)
        TabPage1.TabIndex = 0
        TabPage1.Text = "VIEW PRODUCT"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(198))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Clm_SN, Clm_ProductID, Clm_ProductName, Clm_Color, Clm_Size, Clm_Price, colEdit, colDelete})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 32)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(786, 372)
        DataGridView1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox_Search)
        Panel1.Controls.Add(Label_Search)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(786, 29)
        Panel1.TabIndex = 0
        ' 
        ' TextBox_Search
        ' 
        TextBox_Search.BorderStyle = BorderStyle.FixedSingle
        TextBox_Search.Font = New Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox_Search.Location = New Point(245, 0)
        TextBox_Search.Name = "TextBox_Search"
        TextBox_Search.Size = New Size(309, 27)
        TextBox_Search.TabIndex = 0
        ' 
        ' Label_Search
        ' 
        Label_Search.AutoSize = True
        Label_Search.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Search.Location = New Point(191, 4)
        Label_Search.Name = "Label_Search"
        Label_Search.Size = New Size(51, 19)
        Label_Search.TabIndex = 1
        Label_Search.Text = "Search"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Lbl_Price)
        TabPage2.Controls.Add(Lbl_Size)
        TabPage2.Controls.Add(Lbl_colour)
        TabPage2.Controls.Add(Lbl_Name)
        TabPage2.Controls.Add(Cmb_Size)
        TabPage2.Controls.Add(Cmb_Color)
        TabPage2.Controls.Add(Txt_Price)
        TabPage2.Controls.Add(Txt_pName)
        TabPage2.Controls.Add(Txt_ID)
        TabPage2.Controls.Add(Lbl_pID)
        TabPage2.Controls.Add(Btn_Clear)
        TabPage2.Controls.Add(Btn_Save)
        TabPage2.Controls.Add(PictureBox1)
        TabPage2.Location = New Point(4, 39)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(792, 407)
        TabPage2.TabIndex = 1
        TabPage2.Text = "EDIT PRODUCT"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Lbl_Price
        ' 
        Lbl_Price.AutoSize = True
        Lbl_Price.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Price.Location = New Point(367, 261)
        Lbl_Price.Name = "Lbl_Price"
        Lbl_Price.Size = New Size(47, 19)
        Lbl_Price.TabIndex = 12
        Lbl_Price.Text = "Price :"
        ' 
        ' Lbl_Size
        ' 
        Lbl_Size.AutoSize = True
        Lbl_Size.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Size.Location = New Point(373, 215)
        Lbl_Size.Name = "Lbl_Size"
        Lbl_Size.Size = New Size(41, 19)
        Lbl_Size.TabIndex = 11
        Lbl_Size.Text = "Size :"
        ' 
        ' Lbl_colour
        ' 
        Lbl_colour.AutoSize = True
        Lbl_colour.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_colour.Location = New Point(356, 168)
        Lbl_colour.Name = "Lbl_colour"
        Lbl_colour.Size = New Size(58, 19)
        Lbl_colour.TabIndex = 10
        Lbl_colour.Text = "Colour :"
        ' 
        ' Lbl_Name
        ' 
        Lbl_Name.AutoSize = True
        Lbl_Name.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Name.Location = New Point(361, 121)
        Lbl_Name.Name = "Lbl_Name"
        Lbl_Name.Size = New Size(53, 19)
        Lbl_Name.TabIndex = 9
        Lbl_Name.Text = "Name :"
        ' 
        ' Cmb_Size
        ' 
        Cmb_Size.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Cmb_Size.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Cmb_Size.FormattingEnabled = True
        Cmb_Size.Items.AddRange(New Object() {"S", "M", "L", "XL", "2XL", "3XL", "4XL"})
        Cmb_Size.Location = New Point(421, 212)
        Cmb_Size.Name = "Cmb_Size"
        Cmb_Size.Size = New Size(233, 27)
        Cmb_Size.TabIndex = 4
        ' 
        ' Cmb_Color
        ' 
        Cmb_Color.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Cmb_Color.BackColor = Color.White
        Cmb_Color.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Cmb_Color.FormattingEnabled = True
        Cmb_Color.Items.AddRange(New Object() {"White", "Black", "Brown", "Blue", "Red", "Grey", "", ""})
        Cmb_Color.Location = New Point(421, 164)
        Cmb_Color.Name = "Cmb_Color"
        Cmb_Color.Size = New Size(233, 27)
        Cmb_Color.TabIndex = 3
        ' 
        ' Txt_Price
        ' 
        Txt_Price.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Txt_Price.BackColor = Color.White
        Txt_Price.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Price.Location = New Point(421, 258)
        Txt_Price.Name = "Txt_Price"
        Txt_Price.Size = New Size(290, 26)
        Txt_Price.TabIndex = 2
        ' 
        ' Txt_pName
        ' 
        Txt_pName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Txt_pName.BackColor = Color.White
        Txt_pName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_pName.Location = New Point(421, 118)
        Txt_pName.Name = "Txt_pName"
        Txt_pName.Size = New Size(290, 26)
        Txt_pName.TabIndex = 1
        ' 
        ' Txt_ID
        ' 
        Txt_ID.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Txt_ID.BackColor = Color.White
        Txt_ID.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_ID.Location = New Point(421, 73)
        Txt_ID.Name = "Txt_ID"
        Txt_ID.Size = New Size(290, 26)
        Txt_ID.TabIndex = 0
        ' 
        ' Lbl_pID
        ' 
        Lbl_pID.AutoSize = True
        Lbl_pID.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_pID.Location = New Point(330, 77)
        Lbl_pID.Name = "Lbl_pID"
        Lbl_pID.Size = New Size(84, 19)
        Lbl_pID.TabIndex = 8
        Lbl_pID.Text = "Product ID :"
        ' 
        ' Btn_Clear
        ' 
        Btn_Clear.BackColor = Color.FromArgb(CByte(250), CByte(0), CByte(0))
        Btn_Clear.BackgroundImageLayout = ImageLayout.None
        Btn_Clear.Cursor = Cursors.Hand
        Btn_Clear.FlatStyle = FlatStyle.Flat
        Btn_Clear.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Clear.Location = New Point(595, 308)
        Btn_Clear.Margin = New Padding(0)
        Btn_Clear.Name = "Btn_Clear"
        Btn_Clear.Size = New Size(81, 31)
        Btn_Clear.TabIndex = 6
        Btn_Clear.Text = "CLEAR"
        Btn_Clear.UseVisualStyleBackColor = False
        ' 
        ' Btn_Save
        ' 
        Btn_Save.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Btn_Save.BackgroundImageLayout = ImageLayout.None
        Btn_Save.Cursor = Cursors.Hand
        Btn_Save.FlatStyle = FlatStyle.Flat
        Btn_Save.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Save.Location = New Point(456, 308)
        Btn_Save.Margin = New Padding(0)
        Btn_Save.Name = "Btn_Save"
        Btn_Save.Size = New Size(81, 31)
        Btn_Save.TabIndex = 5
        Btn_Save.Text = "SAVE"
        Btn_Save.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(350, 350)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Clm_SN
        ' 
        Clm_SN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_SN.HeaderText = "S.N."
        Clm_SN.Name = "Clm_SN"
        Clm_SN.Width = 55
        ' 
        ' Clm_ProductID
        ' 
        Clm_ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_ProductID.HeaderText = "PRODUCT ID"
        Clm_ProductID.Name = "Clm_ProductID"
        Clm_ProductID.Width = 109
        ' 
        ' Clm_ProductName
        ' 
        Clm_ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Clm_ProductName.HeaderText = "PRODUCT NAME"
        Clm_ProductName.Name = "Clm_ProductName"
        ' 
        ' Clm_Color
        ' 
        Clm_Color.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_Color.HeaderText = "COLOUR"
        Clm_Color.Name = "Clm_Color"
        Clm_Color.Width = 86
        ' 
        ' Clm_Size
        ' 
        Clm_Size.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_Size.HeaderText = "SIZE"
        Clm_Size.Name = "Clm_Size"
        Clm_Size.Width = 59
        ' 
        ' Clm_Price
        ' 
        Clm_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_Price.HeaderText = "PRICE"
        Clm_Price.Name = "Clm_Price"
        Clm_Price.Width = 69
        ' 
        ' colEdit
        ' 
        colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        colEdit.DefaultCellStyle = DataGridViewCellStyle2
        colEdit.FlatStyle = FlatStyle.Flat
        colEdit.HeaderText = "ACTION"
        colEdit.Name = "colEdit"
        colEdit.Text = "EDIT"
        colEdit.UseColumnTextForButtonValue = True
        colEdit.Width = 62
        ' 
        ' colDelete
        ' 
        colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        colDelete.DefaultCellStyle = DataGridViewCellStyle3
        colDelete.FlatStyle = FlatStyle.Flat
        colDelete.HeaderText = "ACTION"
        colDelete.Name = "colDelete"
        colDelete.Text = "DELETE"
        colDelete.UseColumnTextForButtonValue = True
        colDelete.Width = 62
        ' 
        ' Manage_Product
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Manage_Product"
        Text = "Manage Product"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_Search As TextBox
    Friend WithEvents Label_Search As Label
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Cmb_Size As ComboBox
    Friend WithEvents Cmb_Color As ComboBox
    Friend WithEvents Txt_Price As TextBox
    Friend WithEvents Txt_pName As TextBox
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_Price As Label
    Friend WithEvents Lbl_Size As Label
    Friend WithEvents Lbl_colour As Label
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents Lbl_pID As Label
    Friend WithEvents Clm_SN As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Color As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Size As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Price As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
End Class
