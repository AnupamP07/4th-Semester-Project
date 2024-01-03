Imports MySql.Data.MySqlClient
Public Class Manage_Stock
    Private Sub Manage_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
        Load_StockData()
        DataGridView1.RowTemplate.Height = 27
    End Sub
    Sub Load_StockData()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `table_product`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ID").ToString, dr.Item("pName").ToString, dr.Item("Color").ToString, dr.Item("Size").ToString, dr.Item("Price").ToString, dr.Item("Stock").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub TextBox_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT  `ID`, `pName`, `Color`, `Size`, `Price` FROM `table_product` WHERE ID LIKE '%" & TextBox_Search.Text & "%' or pName LIKE '%" & TextBox_Search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ID").ToString, dr.Item("pName").ToString, dr.Item("Color").ToString, dr.Item("Size").ToString, dr.Item("Price").ToString, dr.Item("Stock").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Try
            conn.Open()
            For j = 0 To DataGridView1.Rows.Count() - 1 Step +1
                cmd = New MySqlCommand("UPDATE `table_product` SET `Stock`=@Stock WHERE `ID`=@ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@Stock", DataGridView1.Rows(j).Cells(6).Value)
                i = cmd.ExecuteNonQuery
            Next
            If i > 0 Then
                MsgBox("Stock Updated!", Pro_Title, vbInformation)
            Else
                MsgBox("Stock Update Failed!", Pro_Title, vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Load_StockData()
    End Sub
End Class
