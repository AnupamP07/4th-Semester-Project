
Public Class Form_Production
    Private Sub Form_Production_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Schedule.Click
        Manage_Schedule.ShowDialog()
    End Sub

    Private Sub Btn_Jit_Click(sender As Object, e As EventArgs) Handles Btn_Jit.Click
        Manage_Jit.ShowDialog()
    End Sub

    Private Sub Button_Report_Click(sender As Object, e As EventArgs) Handles Button_Report.Click
        Frm_Report.ShowDialog()
    End Sub
End Class