Imports MySql.Data.MySqlClient
Public Class Form_ManageUser
    Private Sub Form_ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles txt_ManageUser.Click

    End Sub
    Sub Clear()
        TextBox_Name.Clear()
        TextBox_Username.Clear()
        TextBox_Password.Clear()
        ComboBox_Role.SelectedIndex = -1
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `table_user`(`Name`, `Username`, `Password`, `Role`) VALUES (@Name,@Username,@Password,@Role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Name", TextBox_Name.Text)
            cmd.Parameters.AddWithValue("@Username", TextBox_Username.Text)
            cmd.Parameters.AddWithValue("@Password", TextBox_Password.Text)
            cmd.Parameters.AddWithValue("@Role", ComboBox_Role.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("New User Registered Successfully!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("New User Registered Failed!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Clear()

    End Sub
End Class
