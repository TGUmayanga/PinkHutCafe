Imports MySql.Data.MySqlClient
Module dbconnection



    Const SERVER As String = "localhost"
    Public conn As New MySqlConnection
    Public cammand As New MySqlCommand
    Public Status As Boolean = False


    Public Function Dbconnect() As Boolean
        Try
            conn.ConnectionString = "Server=" + SERVER + ";user=root;password=;database=pink_hut_cafe"
            conn.Open()

            If conn.State = 1 Then
                Status = True
            End If
        Catch ex As Exception
            ex.Message.ToString()

        End Try
        Return Status

    End Function
End Module

