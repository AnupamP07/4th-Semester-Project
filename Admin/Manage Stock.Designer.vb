<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Stock
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btn_Update = New Button()
        TextBox_Search = New TextBox()
        Label_Search = New Label()
        DataGridView1 = New DataGridView()
        Clm_SN = New DataGridViewTextBoxColumn()
        Clm_ProductID = New DataGridViewTextBoxColumn()
        Clm_ProductName = New DataGridViewTextBoxColumn()
        Clm_Color = New DataGridViewTextBoxColumn()
        Clm_Size = New DataGridViewTextBoxColumn()
        Clm_Price = New DataGridViewTextBoxColumn()
        Clm_Qty = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Btn_Update)
        Panel1.Controls.Add(TextBox_Search)
        Panel1.Controls.Add(Label_Search)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 46)
        Panel1.TabIndex = 1
        ' 
        ' Btn_Update
        ' 
        Btn_Update.BackColor = Color.RoyalBlue
        Btn_Update.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Update.Cursor = Cursors.Hand
        Btn_Update.FlatAppearance.BorderSize = 0
        Btn_Update.FlatStyle = FlatStyle.Flat
        Btn_Update.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Update.ForeColor = Color.Black
        Btn_Update.Location = New Point(668, 8)
        Btn_Update.Name = "Btn_Update"
        Btn_Update.Size = New Size(123, 29)
        Btn_Update.TabIndex = 2
        Btn_Update.Text = "Update Stock"
        Btn_Update.UseVisualStyleBackColor = False
        ' 
        ' TextBox_Search
        ' 
        TextBox_Search.BorderStyle = BorderStyle.FixedSingle
        TextBox_Search.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox_Search.Location = New Point(98, 12)
        TextBox_Search.Name = "TextBox_Search"
        TextBox_Search.Size = New Size(309, 24)
        TextBox_Search.TabIndex = 0
        ' 
        ' Label_Search
        ' 
        Label_Search.AutoSize = True
        Label_Search.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Search.Location = New Point(44, 14)
        Label_Search.Name = "Label_Search"
        Label_Search.Size = New Size(51, 19)
        Label_Search.TabIndex = 1
        Label_Search.Text = "Search"
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Clm_SN, Clm_ProductID, Clm_ProductName, Clm_Color, Clm_Size, Clm_Price, Clm_Qty})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 46)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(800, 404)
        DataGridView1.TabIndex = 2
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
        ' Clm_Qty
        ' 
        Clm_Qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.Format = "#,##0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        Clm_Qty.DefaultCellStyle = DataGridViewCellStyle2
        Clm_Qty.HeaderText = "QUANTITY"
        Clm_Qty.Name = "Clm_Qty"
        Clm_Qty.Width = 96
        ' 
        ' Manage_Stock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "Manage_Stock"
        Text = "Manage_Stock"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_Search As TextBox
    Friend WithEvents Label_Search As Label
    Friend WithEvents Btn_Update As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Clm_SN As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Color As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Size As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Price As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Qty As DataGridViewTextBoxColumn
End Class
