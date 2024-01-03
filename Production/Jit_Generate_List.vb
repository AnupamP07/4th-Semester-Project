Imports MySql.Data.MySqlClient
Public Class Jit_Generate_List
    Private Sub Jit_Generate_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
        Auto_requestNo()
        DataGridView1.RowTemplate.Height = 27
        Lbl_Tran_Date.Text = "Date: " & Date.Now.ToString("yyyy/MM/dd")
    End Sub
    Sub Auto_requestNo()
        Lbl_tNo.Text = ""
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `table_jit` order by ID desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Lbl_tNo.Text = dr.Item("reqNo").ToString
            Else
                Lbl_tNo.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Btn_PrintJIT_Click(sender As Object, e As EventArgs) Handles Btn_PrintJIT.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `table_jit`(`reqNo`, `reqDate`, `jitNo`, `jitDate`, `jitTime`, `pID`, `pName`, `Colour`, `Size`, `Price`, `jitQty`) VALUES (@reqNo,@reqDate,@jitNo,@jitDate,@jitTime,@pID,@pName,@Colour,@Size,@Price,@jitQty)", conn)
            ' dr = cmd.ExecuteReader
            For j = 0 To DataGridView1.Rows.Count() - 1 Step +1
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@reqNo", Lbl_tNo.Text)
                cmd.Parameters.AddWithValue("@reqDate", Lbl_Tran_Date.Text)
                cmd.Parameters.AddWithValue("@jitNo", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@jitDate", DataGridView1.Rows(j).Cells(2).Value)
                cmd.Parameters.AddWithValue("@jitTime", DataGridView1.Rows(j).Cells(3).Value)
                cmd.Parameters.AddWithValue("@pID", DataGridView1.Rows(j).Cells(4).Value)
                cmd.Parameters.AddWithValue("@pName", DataGridView1.Rows(j).Cells(5).Value)
                cmd.Parameters.AddWithValue("@Colour", DataGridView1.Rows(j).Cells(6).Value)
                cmd.Parameters.AddWithValue("@Size", DataGridView1.Rows(j).Cells(7).Value)
                cmd.Parameters.AddWithValue("@Price", DataGridView1.Rows(j).Cells(8).Value)
                cmd.Parameters.AddWithValue("@jitQty", DataGridView1.Rows(j).Cells(9).Value)
                i = cmd.ExecuteNonQuery
            Next
            If i > 0 Then
                MsgBox("JIT Generated!" & vbCrLf & "JIT No.: " & Lbl_tNo.Text, vbInformation)
            Else
                MsgBox("JIT Generate Failed!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Auto_requestNo()
        DataGridView1.Rows.Clear()
    End Sub
End Class