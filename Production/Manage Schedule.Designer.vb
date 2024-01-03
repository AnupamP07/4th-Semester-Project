<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Schedule
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Lbl_Date = New Label()
        Btn_DeleteSchedule = New Button()
        Btn_UpdateSchedule = New Button()
        TextBox_Search = New TextBox()
        Label_Search = New Label()
        DataGridView1 = New DataGridView()
        Clm_SN = New DataGridViewTextBoxColumn()
        Clm_ProductID = New DataGridViewTextBoxColumn()
        Clm_ProductName = New DataGridViewTextBoxColumn()
        Clm_Color = New DataGridViewTextBoxColumn()
        Clm_Size = New DataGridViewTextBoxColumn()
        Clm_Price = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Lbl_Date)
        Panel1.Controls.Add(Btn_DeleteSchedule)
        Panel1.Controls.Add(Btn_UpdateSchedule)
        Panel1.Controls.Add(TextBox_Search)
        Panel1.Controls.Add(Label_Search)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 63)
        Panel1.TabIndex = 1
        ' 
        ' Lbl_Date
        ' 
        Lbl_Date.AutoSize = True
        Lbl_Date.BorderStyle = BorderStyle.Fixed3D
        Lbl_Date.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Date.Location = New Point(6, 22)
        Lbl_Date.Name = "Lbl_Date"
        Lbl_Date.Size = New Size(43, 21)
        Lbl_Date.TabIndex = 4
        Lbl_Date.Text = "Date:"
        ' 
        ' Btn_DeleteSchedule
        ' 
        Btn_DeleteSchedule.BackColor = Color.FromArgb(CByte(235), CByte(0), CByte(0))
        Btn_DeleteSchedule.BackgroundImageLayout = ImageLayout.Center
        Btn_DeleteSchedule.Cursor = Cursors.Hand
        Btn_DeleteSchedule.FlatAppearance.BorderColor = Color.White
        Btn_DeleteSchedule.FlatAppearance.BorderSize = 0
        Btn_DeleteSchedule.FlatStyle = FlatStyle.Flat
        Btn_DeleteSchedule.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_DeleteSchedule.ForeColor = Color.Black
        Btn_DeleteSchedule.Location = New Point(662, 18)
        Btn_DeleteSchedule.Name = "Btn_DeleteSchedule"
        Btn_DeleteSchedule.Size = New Size(126, 27)
        Btn_DeleteSchedule.TabIndex = 3
        Btn_DeleteSchedule.Text = "Delete Schedule"
        Btn_DeleteSchedule.UseVisualStyleBackColor = False
        ' 
        ' Btn_UpdateSchedule
        ' 
        Btn_UpdateSchedule.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Btn_UpdateSchedule.BackgroundImageLayout = ImageLayout.Center
        Btn_UpdateSchedule.Cursor = Cursors.Hand
        Btn_UpdateSchedule.FlatAppearance.BorderColor = Color.White
        Btn_UpdateSchedule.FlatAppearance.BorderSize = 0
        Btn_UpdateSchedule.FlatStyle = FlatStyle.Flat
        Btn_UpdateSchedule.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_UpdateSchedule.ForeColor = Color.Black
        Btn_UpdateSchedule.Location = New Point(515, 18)
        Btn_UpdateSchedule.Name = "Btn_UpdateSchedule"
        Btn_UpdateSchedule.Size = New Size(137, 27)
        Btn_UpdateSchedule.TabIndex = 2
        Btn_UpdateSchedule.Text = "Update Schedule"
        Btn_UpdateSchedule.UseVisualStyleBackColor = False
        ' 
        ' TextBox_Search
        ' 
        TextBox_Search.BorderStyle = BorderStyle.FixedSingle
        TextBox_Search.Font = New Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox_Search.Location = New Point(187, 18)
        TextBox_Search.Name = "TextBox_Search"
        TextBox_Search.Size = New Size(258, 27)
        TextBox_Search.TabIndex = 0
        ' 
        ' Label_Search
        ' 
        Label_Search.AutoSize = True
        Label_Search.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label_Search.Location = New Point(133, 22)
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
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(198))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Clm_SN, Clm_ProductID, Clm_ProductName, Clm_Color, Clm_Size, Clm_Price, Column8, Column7})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 63)
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
        DataGridView1.Size = New Size(800, 387)
        DataGridView1.TabIndex = 2
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
        ' Column8
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "#,##0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        Column8.DefaultCellStyle = DataGridViewCellStyle2
        Column8.HeaderText = "QUANTITY"
        Column8.MinimumWidth = 10
        Column8.Name = "Column8"
        ' 
        ' Column7
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "#,##0.00"
        DataGridViewCellStyle3.NullValue = Nothing
        Column7.DefaultCellStyle = DataGridViewCellStyle3
        Column7.HeaderText = "HIT RATE"
        Column7.Name = "Column7"
        ' 
        ' Manage_Schedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Font = New Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Manage_Schedule"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MANAGE SCHEDULE"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_Search As TextBox
    Friend WithEvents Label_Search As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_DeleteSchedule As Button
    Friend WithEvents Btn_UpdateSchedule As Button
    Friend WithEvents Lbl_Date As Label
    Friend WithEvents Clm_SN As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductID As DataGridViewTextBoxColumn
    Friend WithEvents Clm_ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Color As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Size As DataGridViewTextBoxColumn
    Friend WithEvents Clm_Price As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
