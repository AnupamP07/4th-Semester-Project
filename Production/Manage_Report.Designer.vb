<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel5 = New Panel()
        Lbl_PendingJIT = New Label()
        Label6 = New Label()
        Panel4 = New Panel()
        Lbl_FinishedJIT = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        Lbl_TodayJIT = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Lbl_TodayRequest = New Label()
        Lbl_tReq = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        TextBox_Search = New TextBox()
        Label_Search = New Label()
        Btn_FilterJIT = New Button()
        DataGridView1 = New DataGridView()
        Clm_SN = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
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
        TableLayoutPanel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(DateTimePicker2)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox_Search)
        Panel1.Controls.Add(Label_Search)
        Panel1.Controls.Add(Btn_FilterJIT)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1085, 62)
        Panel1.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(Panel5, 3, 0)
        TableLayoutPanel1.Controls.Add(Panel4, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Location = New Point(604, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(481, 59)
        TableLayoutPanel1.TabIndex = 15
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel5.BackgroundImageLayout = ImageLayout.Stretch
        Panel5.Controls.Add(Lbl_PendingJIT)
        Panel5.Controls.Add(Label6)
        Panel5.Cursor = Cursors.Hand
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(363, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(115, 53)
        Panel5.TabIndex = 3
        ' 
        ' Lbl_PendingJIT
        ' 
        Lbl_PendingJIT.AutoSize = True
        Lbl_PendingJIT.BackColor = Color.Transparent
        Lbl_PendingJIT.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_PendingJIT.ForeColor = Color.White
        Lbl_PendingJIT.Location = New Point(4, 31)
        Lbl_PendingJIT.Name = "Lbl_PendingJIT"
        Lbl_PendingJIT.Size = New Size(104, 14)
        Lbl_PendingJIT.TabIndex = 5
        Lbl_PendingJIT.Text = "Today Request"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(17, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 14)
        Label6.TabIndex = 4
        Label6.Text = "Pending JIT"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel4.BackgroundImageLayout = ImageLayout.Stretch
        Panel4.Controls.Add(Lbl_FinishedJIT)
        Panel4.Controls.Add(Label5)
        Panel4.Cursor = Cursors.Hand
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(243, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(114, 53)
        Panel4.TabIndex = 2
        ' 
        ' Lbl_FinishedJIT
        ' 
        Lbl_FinishedJIT.AutoSize = True
        Lbl_FinishedJIT.BackColor = Color.Transparent
        Lbl_FinishedJIT.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_FinishedJIT.ForeColor = Color.White
        Lbl_FinishedJIT.Location = New Point(4, 31)
        Lbl_FinishedJIT.Name = "Lbl_FinishedJIT"
        Lbl_FinishedJIT.Size = New Size(104, 14)
        Lbl_FinishedJIT.TabIndex = 4
        Lbl_FinishedJIT.Text = "Today Request"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(17, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 14)
        Label5.TabIndex = 3
        Label5.Text = "Finished JIT"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(Lbl_TodayJIT)
        Panel3.Controls.Add(Label4)
        Panel3.Cursor = Cursors.Hand
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(123, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(114, 53)
        Panel3.TabIndex = 1
        ' 
        ' Lbl_TodayJIT
        ' 
        Lbl_TodayJIT.AutoSize = True
        Lbl_TodayJIT.BackColor = Color.Transparent
        Lbl_TodayJIT.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_TodayJIT.ForeColor = Color.White
        Lbl_TodayJIT.Location = New Point(4, 31)
        Lbl_TodayJIT.Name = "Lbl_TodayJIT"
        Lbl_TodayJIT.Size = New Size(104, 14)
        Lbl_TodayJIT.TabIndex = 3
        Lbl_TodayJIT.Text = "Today Request"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(20, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 14)
        Label4.TabIndex = 2
        Label4.Text = "Today JIT"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Lbl_TodayRequest)
        Panel2.Controls.Add(Lbl_tReq)
        Panel2.Cursor = Cursors.Hand
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(114, 53)
        Panel2.TabIndex = 0
        ' 
        ' Lbl_TodayRequest
        ' 
        Lbl_TodayRequest.AutoSize = True
        Lbl_TodayRequest.BackColor = Color.Transparent
        Lbl_TodayRequest.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_TodayRequest.ForeColor = Color.White
        Lbl_TodayRequest.Location = New Point(3, 31)
        Lbl_TodayRequest.Name = "Lbl_TodayRequest"
        Lbl_TodayRequest.Size = New Size(104, 14)
        Lbl_TodayRequest.TabIndex = 1
        Lbl_TodayRequest.Text = "Today Request"
        ' 
        ' Lbl_tReq
        ' 
        Lbl_tReq.AutoSize = True
        Lbl_tReq.BackColor = Color.Transparent
        Lbl_tReq.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_tReq.ForeColor = Color.White
        Lbl_tReq.Location = New Point(6, 10)
        Lbl_tReq.Name = "Lbl_tReq"
        Lbl_tReq.Size = New Size(100, 14)
        Lbl_tReq.TabIndex = 0
        Lbl_tReq.Text = "Today Request"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePicker2.CalendarFont = New Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.Cursor = Cursors.Hand
        DateTimePicker2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(429, 20)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(101, 25)
        DateTimePicker2.TabIndex = 12
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePicker1.CalendarFont = New Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Cursor = Cursors.Hand
        DateTimePicker1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(293, 20)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(104, 25)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(403, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 17)
        Label2.TabIndex = 14
        Label2.Text = "To:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(246, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 17)
        Label1.TabIndex = 13
        Label1.Text = "From:"
        ' 
        ' TextBox_Search
        ' 
        TextBox_Search.BorderStyle = BorderStyle.FixedSingle
        TextBox_Search.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Search.Location = New Point(59, 21)
        TextBox_Search.Name = "TextBox_Search"
        TextBox_Search.Size = New Size(182, 24)
        TextBox_Search.TabIndex = 9
        ' 
        ' Label_Search
        ' 
        Label_Search.AutoSize = True
        Label_Search.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Search.Location = New Point(7, 23)
        Label_Search.Name = "Label_Search"
        Label_Search.Size = New Size(51, 19)
        Label_Search.TabIndex = 10
        Label_Search.Text = "Search"
        ' 
        ' Btn_FilterJIT
        ' 
        Btn_FilterJIT.BackColor = Color.Blue
        Btn_FilterJIT.BackgroundImageLayout = ImageLayout.Center
        Btn_FilterJIT.Cursor = Cursors.Hand
        Btn_FilterJIT.FlatAppearance.BorderColor = Color.White
        Btn_FilterJIT.FlatAppearance.BorderSize = 0
        Btn_FilterJIT.FlatStyle = FlatStyle.Flat
        Btn_FilterJIT.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_FilterJIT.ForeColor = Color.White
        Btn_FilterJIT.Location = New Point(536, 19)
        Btn_FilterJIT.Name = "Btn_FilterJIT"
        Btn_FilterJIT.Size = New Size(65, 26)
        Btn_FilterJIT.TabIndex = 8
        Btn_FilterJIT.Text = "Filter"
        Btn_FilterJIT.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(198))
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Clm_SN, Column6, Column5, Column2, Column3, Column4, Clm_ProductID, Clm_ProductName, Clm_Color, Clm_Size, Clm_Price, Column1})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 62)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = SystemColors.Control
        DataGridViewCellStyle12.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = Color.Black
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1085, 446)
        DataGridView1.TabIndex = 7
        ' 
        ' Clm_SN
        ' 
        Clm_SN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Clm_SN.HeaderText = "S.N."
        Clm_SN.MinimumWidth = 10
        Clm_SN.Name = "Clm_SN"
        Clm_SN.Width = 58
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Req.No."
        Column6.Name = "Column6"
        Column6.Width = 79
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Column5.DefaultCellStyle = DataGridViewCellStyle8
        Column5.HeaderText = "Req.DATE"
        Column5.Name = "Column5"
        Column5.Width = 92
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
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Column3.DefaultCellStyle = DataGridViewCellStyle9
        Column3.HeaderText = "JIT DATE"
        Column3.Name = "Column3"
        Column3.Width = 90
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Format = "t"
        DataGridViewCellStyle10.NullValue = Nothing
        Column4.DefaultCellStyle = DataGridViewCellStyle10
        Column4.HeaderText = "JIT TIME"
        Column4.Name = "Column4"
        Column4.Width = 90
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
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "#,##0.00"
        DataGridViewCellStyle11.NullValue = Nothing
        Column1.DefaultCellStyle = DataGridViewCellStyle11
        Column1.HeaderText = "JIT QTY"
        Column1.Name = "Column1"
        ' 
        ' Frm_Report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1085, 508)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Frm_Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PRODUCTION REPORT"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_FilterJIT As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox_Search As TextBox
    Friend WithEvents Label_Search As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Clm_SN As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Color As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Size As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Price As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_tReq As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_TodayRequest As Label
    Friend WithEvents Lbl_PendingJIT As Label
    Friend WithEvents Lbl_FinishedJIT As Label
    Friend WithEvents Lbl_TodayJIT As Label
End Class
