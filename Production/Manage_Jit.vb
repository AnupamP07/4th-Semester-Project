Imports MySql.Data.MySqlClient
Public Class Manage_Jit
    Private Sub Manage_Jit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
        DataGridView1.RowTemplate.Height = 27
        Load_JitGenerator()
    End Sub
    Sub Load_JitGenerator()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `ID`, `pName`, `Color`, `Size`, `Price` FROM `table_product`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(0, DataGridView1.Rows.Count + 1, dr.Item("ID"), dr.Item("pName"), dr.Item("Color"), dr.Item("Size"), dr.Item("Price"))
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
            cmd = New MySqlCommand("SELECT `ID`, `pName`, `Color`, `Size`, `Price`, `Jit_Qty` FROM `table_product` WHERE ID LIKE '%" & TextBox_Search.Text & "%' or pName LIKE '%" & TextBox_Search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(0, DataGridView1.Rows.Count + 1, dr.Item("ID").ToString, dr.Item("pName").ToString, dr.Item("Color").ToString, dr.Item("Size").ToString, dr.Item("Price").ToString, dr.Item("Jit_Qty").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub Btn_UpdateSchedule_Click(sender As Object, e As EventArgs) Handles Btn_GenerateJit.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim Selected As Boolean = Convert.ToBoolean(row.Cells(0).Value)
            If Selected = True Then
                If row.Cells(7).Value = String.Empty Then
                    MsgBox("Fill JIT!", vbExclamation)
                    Return
                Else
                    Jit_Generate_List.DataGridView1.Rows.Add(Jit_Generate_List.DataGridView1.Rows.Count + 1, Date.Now.ToString("yyyyMMmmss"), Date.Now.ToString("yyyy/MM/dd"), Date.Now.ToString("hh:mm:ss tt"), row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
                End If
                Jit_Generate_List.Show()
            End If
        Next
        Load_JitGenerator()
    End Sub
End Class