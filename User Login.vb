Imports MySql.Data.MySqlClient
Public Class User_Login
    Private Sub User_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBconn()


    End Sub
    Private Sub PictureBox_Login_Click(sender As Object, e As EventArgs) Handles PictureBox_Login.Click
        PictureBox_Login.BorderStyle = BorderStyle.None

    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        If Text_Username.Text = String.Empty Or Text_Password.Text = String.Empty Then
            MessageBox.Show("Please Fill All The Fields!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM `table_User` WHERE Username = @Username", conn)
                cmd.Parameters.Clear()
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                cmd.Parameters.AddWithValue("@Username", Text_Username.Text)
                da.SelectCommand = cmd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    cmd = New MySqlCommand("SELECT * FROM `table_User` WHERE Username = @Username and Password = @Password", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Username", Text_Username.Text)
                    cmd.Parameters.AddWithValue("@Password", Text_Password.Text)
                    dr = cmd.ExecuteReader

                    If dr.Read = True Then
                        Dim Name As String = dr.Item("Name").ToString
                        Dim Username As String = dr.Item("Username").ToString
                        Dim Password As String = dr.Item("Password").ToString
                        Dim Role As String = dr.Item("Role").ToString
                        conn.Close()
                        Text_Password.Clear()
                        Text_Username.Clear()

                        If Role = "Admin" Then
                            Me.Hide()
                            Form_Admin.Show()
                        ElseIf Role = "Production" Then
                            Me.Hide()
                            Form_Production.Show()
                        ElseIf Role = "Store" Then
                            Me.Hide()
                            Form_Store.Show()
                        End If
                    Else
                        MessageBox.Show("Invalid Username or Password!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    MessageBox.Show("Invalid User!", Pro_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            conn.Close()

        End If

    End Sub
End Class