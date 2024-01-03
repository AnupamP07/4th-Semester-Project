Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Frm_Report
    Private Sub Frm_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
        Load_Report()
        Report_Dashboard()
        DataGridView1.RowTemplate.Height = 27
    End Sub
    Sub Load_Report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `reqNo`, `reqDate`, `jitNo`, `jitDate`, `jitTime`, `pID`, `pName`, `Colour`, `Size`, `Price`, `jitQty` FROM `table_jit`", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("reqNo"), dr.Item("jitNo"), dr.Item("jitTime"), dr.Item("pID"), dr.Item("pName"), dr.Item("Colour"), dr.Item("Size"), dr.Item("Price"), dr.Item("jitQty"))
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
            cmd = New MySqlCommand("SELECT `reqNo`, `reqDate`, `jitNo`, `jitDate`, `jitTime`, `pID`, `pName`, `Colour`, `Size`, `Price`, `jitQty` FROM `table_jit` where reqNo like '%" & TextBox_Search.Text & "%' or pName LIKE '%" & TextBox_Search.Text & "%'or pID LIKE '%" & TextBox_Search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("reqNo"), dr.Item("jitNo"), dr.Item("jitTime"), dr.Item("pID"), dr.Item("pName"), dr.Item("Colour"), dr.Item("Size"), dr.Item("Price"), dr.Item("jitQty"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Btn_PrintJIT_Click(sender As Object, e As EventArgs) Handles Btn_FilterJIT.Click
        Dim Date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim Date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `reqNo`, `reqDate`, `jitNo`, `jitDate`, `jitTime`, `pID`, `pName`, `Colour`, `Size`, `Price`, `jitQty` FROM `table_jit`where reqDate between '" & Date1 & "' and '" & Date2 & "' ", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("reqNo"), dr.Item("jitNo"), dr.Item("jitTime"), dr.Item("pID"), dr.Item("pName"), dr.Item("Colour"), dr.Item("Size"), dr.Item("Price"), dr.Item("jitQty"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub Report_Dashboard()
        conn.Open()
        cmd = New MySqlCommand("SELECT COUNT(`reqNo`) FROM `table_jit` WHERE `reqDate` ='" & Date.Now.ToString("yyyy/MM/dd") & "' GROUP BY `reqNo`", conn)
        Lbl_TodayRequest.Text = cmd.ExecuteScalar
        conn.Close()

        conn.Open()
        cmd = New MySqlCommand("SELECT COUNT(`jitNo`) FROM `table_jit` WHERE `reqDate` ='" & Date.Now.ToString("yyyy/MM/dd") & "'", conn)
        Lbl_TodayJIT.Text = cmd.ExecuteScalar
        conn.Close()

        conn.Open()
        cmd = New MySqlCommand("SELECT COUNT(`jitNo`) FROM `table_jit` WHERE `jitQty` < 0 AND `reqDate` ='" & Date.Now.ToString("yyyy/MM/dd") & "'", conn)
        Lbl_FinishedJIT.Text = cmd.ExecuteScalar
        conn.Close()

        conn.Open()
        cmd = New MySqlCommand("SELECT COUNT(`jitNo`) FROM `table_jit` WHERE `jitQty` > 0 AND `reqDate` ='" & Date.Now.ToString("yyyy/MM/dd") & "'", conn)
        Lbl_PendingJIT.Text = cmd.ExecuteScalar
        conn.Close()
    End Sub
End Class