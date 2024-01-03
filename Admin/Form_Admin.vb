Public Class Form_Admin

    Private Sub Btn_ManageProduct_Click(sender As Object, e As EventArgs) Handles Btn_ManageProduct.Click
        Manage_Product.Show()

    End Sub

    Private Sub Btn_ManageStock_Click(sender As Object, e As EventArgs) Handles Btn_ManageStock.Click
        Manage_Stock.Show()
    End Sub

    Private Sub Btn_ManageUser_Click(sender As Object, e As EventArgs) Handles Btn_ManageUser.Click
        Change_User.Show()
    End Sub

    Private Sub Btn_ChgPwd_Click(sender As Object, e As EventArgs) Handles Btn_ChgPwd.Click

    End Sub

    Private Sub Btn_Report_Click(sender As Object, e As EventArgs) Handles Btn_Report.Click

    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class