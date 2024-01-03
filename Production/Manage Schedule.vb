Imports System.IO
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class Manage_Schedule
    Private Sub Manage_Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
        Lbl_Date.Text = "Date: " & Date.Now.ToString("yyyy/MM/dd")
        DataGridView1.RowTemplate.Height = 27
        load_Schedule()
    End Sub
    Sub load_Schedule()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `ID`, `pName`, `Color`, `Size`, `Price`, `HitRate`, `Schedule_Qty` FROM `table_product`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ID"), dr.Item("pName"), dr.Item("Color"), dr.Item("Size"), dr.Item("Schedule_Qty"))
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
            cmd = New MySqlCommand("SELECT  `ID`, `pName`, `Color`, `Size`, `Price`,`HitRate`, `Schedule_Qty` FROM `table_product` WHERE ID LIKE '%" & TextBox_Search.Text & "%' or pName LIKE '%" & TextBox_Search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ID").ToString, dr.Item("pName").ToString, dr.Item("Color").ToString, dr.Item("Size").ToString, dr.Item("Price").ToString, dr.Item("HitRate").ToString, dr.Item("Schedule_Qty").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Btn_UpdateSchedule_Click(sender As Object, e As EventArgs) Handles Btn_UpdateSchedule.Click
        If MsgBox("Are You Sure To Update Schedule? ", vbQuestion + vbYesNo) = vbYes Then

            Try
                conn.Open()
                For j = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    cmd = New MySqlCommand("UPDATE `table_product` SET `HitRate`=@Hitrate, `Schedule_Qty`= @Schedule_Qty WHERE `ID`=@ID", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@ID", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@HitRate", DataGridView1.Rows(j).Cells(7).Value)
                    cmd.Parameters.AddWithValue("@Schedule_Qty", DataGridView1.Rows(j).Cells(6).Value)
                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("Schedule Updated!", Pro_Title, vbInformation)
                Else
                    MsgBox("Schedule Updation Failed!", Pro_Title, vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            load_Schedule()
        End If
    End Sub

    Private Sub Btn_DeleteSchedule_Click(sender As Object, e As EventArgs) Handles Btn_DeleteSchedule.Click
        If MsgBox("Are You Sure To Clear Schedule? ", vbQuestion + vbYesNo) = vbYes Then

            Try
                conn.Open()
                For j = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    cmd = New MySqlCommand("UPDATE `table_product` SET `HitRate`=@Hitrate, `Schedule_Qty`= @Schedule_Qty WHERE `ID`=@ID", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@ID", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@HitRate", 0)
                    cmd.Parameters.AddWithValue("@Schedule_Qty", 0)
                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("Schedule Cleared!", Pro_Title, vbInformation)
                Else
                    MsgBox("Schedule Clearance Failed!", Pro_Title, vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            load_Schedule()
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            'conn.Open()
            DataGridView1.CurrentRow.Cells(7).Value = DataGridView1.CurrentRow.Cells(6).Value / 26
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        ' conn.Close()

    End Sub
End Class