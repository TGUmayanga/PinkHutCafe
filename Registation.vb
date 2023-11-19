Imports MySql.Data.MySqlClient
Public Class Registation
    Private Sub Registation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim fname, lname, email, phoneno, address As String

        fname = TextBox1.Text
        lname = TextBox5.Text
        email = TextBox4.Text
        phoneno = TextBox3.Text
        address = TextBox2.Text

        Try

            If Dbconnect() Then

                Dim sql As String
                Dim result As Integer

                sql = "INSERT INTO `phc`(`First_Name`, `Last_Name`, `Email`, `Phone_No`, `Address`) VALUES (@fname,@lname,@email,@phoneno,@address)"

                Dim command As New MySqlCommand(sql, conn)

                command.Parameters.AddWithValue("@fname", fname)
                command.Parameters.AddWithValue("@lname", lname)
                command.Parameters.AddWithValue("email", email)
                command.Parameters.AddWithValue("@phoneno", phoneno)
                command.Parameters.AddWithValue("@address", address)

                result = command.ExecuteNonQuery()

                If result = 1 Then

                    MsgBox("successfull")
                    command.Parameters.Clear()

                Else

                    MsgBox("Error")




                End If











            End If








        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class