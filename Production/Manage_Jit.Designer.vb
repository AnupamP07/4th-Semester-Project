<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Jit
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btn_GenerateJit = New Button()
        TextBox_Search = New TextBox()
        Label_Search = New Label()
        DataGridView1 = New DataGridView()
        Column2 = New DataGridViewCheckBoxColumn()
        Clm_SN = New DataGridViewTextBoxColumn()
        Clm_ProductID = New DataGridViewTextBoxColumn()
        Clm_ProductName = New DataGridViewTextBoxColumn()
        Clm_Color = New DataGridViewTextBoxColumn()
        Clm_Size = New DataGridViewTextBoxColumn()
        Clm_Price = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Btn_GenerateJit)
        Panel1.Controls.Add(TextBox_Search)
        Panel1.Controls.Add(Label_Search)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 63)
        Panel1.TabIndex = 2
        ' 
        ' Btn_GenerateJit
        ' 
        Btn_GenerateJit.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Btn_GenerateJit.BackgroundImageLayout = ImageLayout.Center
        Btn_GenerateJit.Cursor = Cursors.Hand
        Btn_GenerateJit.FlatAppearance.BorderColor = Color.White
        Btn_GenerateJit.FlatAppearance.BorderSize = 0
        Btn_GenerateJit.FlatStyle = FlatStyle.Flat
        Btn_GenerateJit.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_GenerateJit.ForeColor = Color.Black
        Btn_GenerateJit.Location = New Point(670, 16)
        Btn_GenerateJit.Name = "Btn_GenerateJit"
        Btn_GenerateJit.Size = New Size(118, 29)
        Btn_GenerateJit.TabIndex = 2
        Btn_GenerateJit.Text = "GENERATE"
        Btn_GenerateJit.UseVisualStyleBackColor = False
        ' 
        ' TextBox_Search
        ' 
        TextBox_Search.BorderStyle = BorderStyle.FixedSingle
        TextBox_Search.Font = New Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox_Search.Location = New Point(62, 19)
        TextBox_Search.Name = "TextBox_Search"
        TextBox_Search.Size = New Size(258, 27)
        TextBox_Search.TabIndex = 0
        ' 
        ' Label_Search
        ' 
        Label_Search.AutoSize = True
        Label_Search.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Search.Location = New Point(8, 23)
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
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(198))
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column2, Clm_SN, Clm_ProductID, Clm_ProductName, Clm_Color, Clm_Size, Clm_Price, Column1})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Control
        DataGridViewCellStyle8.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(800, 387)
        DataGridView1.TabIndex = 3
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = "False"
        Column2.DefaultCellStyle = DataGridViewCellStyle6
        Column2.FlatStyle = FlatStyle.Flat
        Column2.HeaderText = ""
        Column2.Name = "Column2"
        Column2.Width = 5
        ' 
        ' Clm_SN
        ' 
        Clm_SN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_SN.HeaderText = "S.N."
        Clm_SN.MinimumWidth = 10
        Clm_SN.Name = "Clm_SN"
        Clm_SN.Width = 58
        ' 
        ' Clm_ProductID
        ' 
        Clm_ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_ProductID.HeaderText = "PRODUCT ID"
        Clm_ProductID.Name = "Clm_ProductID"
        Clm_ProductID.Width = 115
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
        Clm_Color.Width = 87
        ' 
        ' Clm_Size
        ' 
        Clm_Size.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_Size.HeaderText = "SIZE"
        Clm_Size.Name = "Clm_Size"
        Clm_Size.Width = 61
        ' 
        ' Clm_Price
        ' 
        Clm_Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_Price.HeaderText = "PRICE"
        Clm_Price.Name = "Clm_Price"
        Clm_Price.Width = 71
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "#,##0.00"
        DataGridViewCellStyle7.NullValue = Nothing
        Column1.DefaultCellStyle = DataGridViewCellStyle7
        Column1.HeaderText = "JIT QTY"
        Column1.Name = "Column1"
        ' 
        ' Manage_Jit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Manage_Jit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "JIT GENERATOR"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_GenerateJit As Button
    Friend WithEvents TextBox_Search As TextBox
    Friend WithEvents Label_Search As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Clm_SN As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Color As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Size As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Price As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
