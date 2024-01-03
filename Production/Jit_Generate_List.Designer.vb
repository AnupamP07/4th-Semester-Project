<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jit_Generate_List
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btn_PrintJIT = New Button()
        Lbl_Tran_Date = New Label()
        Lbl_Transection_Date = New Label()
        Lbl_tNo = New Label()
        Lbl_Transection_No = New Label()
        DataGridView1 = New DataGridView()
        Clm_SN = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
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
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Btn_PrintJIT)
        Panel1.Controls.Add(Lbl_Tran_Date)
        Panel1.Controls.Add(Lbl_Transection_Date)
        Panel1.Controls.Add(Lbl_tNo)
        Panel1.Controls.Add(Lbl_Transection_No)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(853, 58)
        Panel1.TabIndex = 0
        ' 
        ' Btn_PrintJIT
        ' 
        Btn_PrintJIT.BackColor = Color.Blue
        Btn_PrintJIT.BackgroundImageLayout = ImageLayout.Center
        Btn_PrintJIT.Cursor = Cursors.Hand
        Btn_PrintJIT.FlatAppearance.BorderColor = Color.White
        Btn_PrintJIT.FlatAppearance.BorderSize = 0
        Btn_PrintJIT.FlatStyle = FlatStyle.Flat
        Btn_PrintJIT.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_PrintJIT.ForeColor = Color.White
        Btn_PrintJIT.Location = New Point(726, 15)
        Btn_PrintJIT.Name = "Btn_PrintJIT"
        Btn_PrintJIT.Size = New Size(103, 29)
        Btn_PrintJIT.TabIndex = 8
        Btn_PrintJIT.Text = "PRINT"
        Btn_PrintJIT.UseVisualStyleBackColor = False
        ' 
        ' Lbl_Tran_Date
        ' 
        Lbl_Tran_Date.AutoSize = True
        Lbl_Tran_Date.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_Tran_Date.Location = New Point(433, 21)
        Lbl_Tran_Date.Name = "Lbl_Tran_Date"
        Lbl_Tran_Date.Size = New Size(124, 19)
        Lbl_Tran_Date.TabIndex = 7
        Lbl_Tran_Date.Text = "Transection Date"
        ' 
        ' Lbl_Transection_Date
        ' 
        Lbl_Transection_Date.AutoSize = True
        Lbl_Transection_Date.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_Transection_Date.Location = New Point(308, 21)
        Lbl_Transection_Date.Name = "Lbl_Transection_Date"
        Lbl_Transection_Date.Size = New Size(125, 17)
        Lbl_Transection_Date.TabIndex = 6
        Lbl_Transection_Date.Text = "Transection Date:"
        ' 
        ' Lbl_tNo
        ' 
        Lbl_tNo.AutoSize = True
        Lbl_tNo.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_tNo.ForeColor = Color.FromArgb(CByte(235), CByte(0), CByte(0))
        Lbl_tNo.Location = New Point(155, 21)
        Lbl_tNo.Name = "Lbl_tNo"
        Lbl_tNo.Size = New Size(120, 19)
        Lbl_tNo.TabIndex = 1
        Lbl_tNo.Text = "Transection No.:"
        ' 
        ' Lbl_Transection_No
        ' 
        Lbl_Transection_No.AutoSize = True
        Lbl_Transection_No.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_Transection_No.Location = New Point(37, 21)
        Lbl_Transection_No.Name = "Lbl_Transection_No"
        Lbl_Transection_No.Size = New Size(117, 17)
        Lbl_Transection_No.TabIndex = 0
        Lbl_Transection_No.Text = "Transection No.:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(198))
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Clm_SN, Column2, Column3, Column4, Clm_ProductID, Clm_ProductName, Clm_Color, Clm_Size, Clm_Price, Column1})
        DataGridView1.Location = New Point(0, 59)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(853, 394)
        DataGridView1.TabIndex = 6
        ' 
        ' Clm_SN
        ' 
        Clm_SN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_SN.HeaderText = "S.N."
        Clm_SN.MinimumWidth = 10
        Clm_SN.Name = "Clm_SN"
        Clm_SN.Width = 58
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "JIT No"
        Column2.Name = "Column2"
        Column2.Width = 73
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "JIT DATE"
        Column3.Name = "Column3"
        Column3.Width = 90
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "JIT TIME"
        Column4.Name = "Column4"
        Column4.Width = 90
        ' 
        ' Clm_ProductID
        ' 
        Clm_ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_ProductID.HeaderText = "ID"
        Clm_ProductID.Name = "Clm_ProductID"
        Clm_ProductID.Width = 47
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
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "#,##0.00"
        DataGridViewCellStyle5.NullValue = Nothing
        Column1.DefaultCellStyle = DataGridViewCellStyle5
        Column1.HeaderText = "JIT QTY"
        Column1.Name = "Column1"
        ' 
        ' Jit_Generate_List
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 455)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Jit_Generate_List"
        StartPosition = FormStartPosition.CenterScreen
        Text = "JIT GENERATE LIST"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_Transection_No As Label
    Friend WithEvents Lbl_Tran_Date As Label
    Friend WithEvents Lbl_Transection_Date As Label
    Friend WithEvents Lbl_tNo As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Clm_SN As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Color As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Size As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Price As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_PrintJIT As Button
End Class
