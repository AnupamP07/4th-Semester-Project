Imports MySql.Data.MySqlClient
Public Class Manage_Product
    Private Sub Manage_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
        Load_Products()
    End Sub
    Public Sub Load_Products()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `ID`, `pName`, `Color`, `Size`, `Price` FROM `table_product`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ID").ToString, dr.Item("pName").ToString, dr.Item("Color").ToString, dr.Item("Size").ToString, dr.Item("Price").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub
    Sub Clear()
        Txt_ID.Clear()
        Txt_pName.Clear()
        Txt_Price.Clear()
        Cmb_Color.SelectedIndex = -1
        Cmb_Size.SelectedIndex = -1

    End Sub
    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Clear()

    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If Txt_ID.Text = String.Empty Or Txt_pName.Text = String.Empty Or Txt_Price.Text = String.Empty Or Cmb_Color.Text = String.Empty Or Cmb_Color.Text = String.Empty Then
            MessageBox.Show("Please Fill All The Fields!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO `table_product`(`ID`, `pName`, `Color`, `Size`, `Price`) VALUES (@ID,@pName,@Color,@Size,@Price)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", Txt_ID.Text)
                cmd.Parameters.AddWithValue("@pName", Txt_pName.Text)
                cmd.Parameters.AddWithValue("@Color", Cmb_Color.Text)
                cmd.Parameters.AddWithValue("@Size", Cmb_Size.Text)
                cmd.Parameters.AddWithValue("@Price", Txt_Price.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Product Saved!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Product Save Failed!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            Load_Products()
            conn.Close()
            Clear()
        End If
    End Sub

    Private Sub TextBox_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `ID`, `pName`, `Color`, `Size`, `Price` FROM `table_product` WHERE ID LIKE '%" & TextBox_Search.Text & "%' or pName LIKE '%" & TextBox_Search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ID").ToString, dr.Item("pName").ToString, dr.Item("Color").ToString, dr.Item("Size").ToString, dr.Item("Price").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colEdit" Then
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `table_product` SET `pName`=@pName,`Color`=@Color,`Size`=@Size,`Price`=@Price WHERE `ID`=@ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", DataGridView1.CurrentRow.Cells(1).Value.ToString)
                cmd.Parameters.AddWithValue("@pName", DataGridView1.CurrentRow.Cells(2).Value.ToString)
                cmd.Parameters.AddWithValue("@Color", DataGridView1.CurrentRow.Cells(3).Value.ToString)
                cmd.Parameters.AddWithValue("@Size", DataGridView1.CurrentRow.Cells(4).Value.ToString)
                cmd.Parameters.AddWithValue("@Price", DataGridView1.CurrentRow.Cells(5).Value.ToString)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Product Updated!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Product Update Failed!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            Load_Products()
        End If
        If colName = "colDelete" Then
            If MsgBox("Are You Sure To delete This Product?", vbQuestion + vbYesNo) = vbYes Then
                Try
                    conn.Open()
                    cmd = New MySqlCommand("DELETE FROM `table_product` WHERE `ID`=@ID", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@ID", DataGridView1.CurrentRow.Cells(1).Value.ToString)
                    ' ' cmd.Parameters.AddWithValue("@pName", DataGridView1.CurrentRow.Cells(2).Value.ToString)
                    ' ' cmd.Parameters.AddWithValue("@Price", DataGridView1.CurrentRow.Cells(3).Value.ToString)
                    ' ' cmd.Parameters.AddWithValue("@Color", DataGridView1.CurrentRow.Cells(4).Value.ToString)
                    ' ' cmd.Parameters.AddWithValue("@Size", DataGridView1.CurrentRow.Cells(5).Value.ToString)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MessageBox.Show("Product Updated!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Product Update Failed!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
                Load_Products()
            End If
        End If
    End Sub
End Class