Imports MySql.Data.MySqlClient

Public Class Cart

    Dim mixfruit As Decimal
    Dim awacado As Decimal
    Dim mango As Decimal
    Dim icecoffee As Decimal
    Dim Faluda As Decimal
    Dim lime As Decimal
    Dim milkshake As Decimal
    Dim pashion As Decimal
    Dim mocktail As Decimal
    Dim pineapple As Decimal
    Dim cake As Decimal
    Dim icecream As Decimal
    Dim donuts As Decimal
    Dim dodol As Decimal
    Dim asmi As Decimal
    Dim kokis As Decimal
    Dim watalappam As Decimal
    Dim pudding As Decimal
    Dim swisroll As Decimal
    Dim total As Decimal




    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmixfruit.Click
        TextBox1.Text -= 1
        If TextBox1.Text <= 0 Then
            TextBox1.Text = 0
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox2.Text = TextBox2.Text + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text -= 1
        If TextBox2.Text <= 0 Then
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox3.Text = TextBox3.Text + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text -= 1
        If TextBox3.Text <= 0 Then
            TextBox3.Text = 0
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox4.Text = TextBox4.Text + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox4.Text -= 1
        If TextBox4.Text <= 0 Then
            TextBox4.Text = 0
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox5.Text = TextBox5.Text + 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox5.Text -= 1
        If TextBox5.Text <= 0 Then
            TextBox5.Text = 0 '
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox6.Text = TextBox6.Text + 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox6.Text -= 1
        If TextBox6.Text <= 0 Then
            TextBox6.Text = 0 '
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox7.Text = TextBox7.Text + 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox7.Text -= 1
        If TextBox7.Text <= 0 Then
            TextBox7.Text = 0 '
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox8.Text = TextBox8.Text + 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox8.Text -= 1
        If TextBox8.Text <= 0 Then
            TextBox8.Text = 0 '
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox9.Text = TextBox9.Text + 1
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox9.Text -= 1
        If TextBox9.Text <= 0 Then
            TextBox9.Text = 0 '
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox10.Text = TextBox10.Text + 1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox10.Text -= 1
        If TextBox10.Text <= 0 Then
            TextBox10.Text = 0 '
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox11.Text = TextBox11.Text + 1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox11.Text -= 1
        If TextBox11.Text <= 0 Then
            TextBox11.Text = 0 '
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox12.Text = TextBox12.Text + 1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox12.Text -= 1
        If TextBox12.Text <= 0 Then
            TextBox12.Text = 0 '
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox13.Text = TextBox13.Text + 1
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox13.Text -= 1
        If TextBox13.Text <= 0 Then
            TextBox13.Text = 0 '
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TextBox14.Text = TextBox14.Text + 1
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox14.Text -= 1
        If TextBox14.Text <= 0 Then
            TextBox14.Text = 0 '
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox15.Text = TextBox15.Text + 1
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox15.Text -= 1
        If TextBox15.Text <= 0 Then
            TextBox15.Text = 0 '
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        TextBox16.Text = TextBox16.Text + 1
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox16.Text -= 1
        If TextBox16.Text <= 0 Then
            TextBox16.Text = 0 '
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        TextBox17.Text = TextBox17.Text + 1
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox17.Text -= 1
        If TextBox17.Text <= 0 Then
            TextBox17.Text = 0 '
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        TextBox18.Text = TextBox18.Text + 1
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox18.Text -= 1
        If TextBox18.Text <= 0 Then
            TextBox18.Text = 0 '
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        TextBox19.Text = TextBox19.Text + 1
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TextBox19.Text -= 1
        If TextBox19.Text <= 0 Then
            TextBox19.Text = 0 '
        End If
    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        mixfruit = TextBox1.Text * 250
        awacado = TextBox2.Text * 250
        mango = TextBox3.Text * 200
        icecoffee = TextBox4.Text * 250
        Faluda = TextBox5.Text * 250
        lime = TextBox6.Text * 150
        milkshake = TextBox7.Text * 300
        pashion = TextBox8.Text * 200
        mocktail = TextBox9.Text * 300
        pineapple = TextBox10.Text * 200
        cake = TextBox11.Text * 500
        icecream = TextBox12.Text * 350
        donuts = TextBox13.Text * 150
        dodol = TextBox14.Text * 650
        asmi = TextBox15.Text * 100
        kokis = TextBox16.Text * 200
        watalappam = TextBox17.Text * 100
        pudding = TextBox18.Text * 100
        swisroll = TextBox19.Text * 500



        txttotal.Text = "Rs" & Format(mixfruit + awacado + mango + icecoffee + Faluda + lime + milkshake + pashion + mocktail + pineapple + cake + icecream + donuts + dodol + asmi + kokis + watalappam + pudding + swisroll, "0.00")

        If (TextBox1.Text >= 1) Then
            Label1.Text = ("Mix Fruit:P" & TextBox1.Text * 200)
        Else
            txttotal.Text = ("")
        End If

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox14.Text = 0
        TextBox15.Text = 0
        TextBox16.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
        TextBox19.Text = 0

        txttotal.Text = 0

        mixfruit = 0
        awacado = 0
        mango = 0
        icecoffee = 0
        Faluda = 0
        lime = 0
        milkshake = 0
        pashion = 0
        mocktail = 0
        pineapple = 0
        cake = 0
        icecream = 0
        donuts = 0
        dodol = 0
        asmi = 0
        kokis = 0
        watalappam = 0
        pudding = 0
        swisroll = 0
        total = 0

    End Sub

    Private Sub btnrecipet_Click(sender As Object, e As EventArgs) Handles btnrecipet.Click


        MessageBox.Show("Mix Fruit:Rs" & mixfruit & vbCrLf & "Awacado:Rs" & awacado & vbCrLf & "Mango:Rs" & mango & vbCrLf & "Ice Coffee:Rs" & icecoffee & vbCrLf & "Faluda:Rs" & Faluda & vbCrLf & "Lime:Rs" & lime & vbCrLf & "Milk Shake:Rs" & milkshake & vbCrLf & "Pashion:Rs" & pashion & vbCrLf & "Mocktail:Rs" & mocktail & vbCrLf & "Pineapple:Rs" & pineapple & vbCrLf & "Cake:Rs" & cake & vbCrLf & "Ice Cream:Rs" & icecream & vbCrLf & "Donuts:Rs" & donuts & vbCrLf & "Dodol:Rs" & dodol & vbCrLf & "Asmi:Rs" & asmi & vbCrLf & "Kokis:Rs" & kokis & vbCrLf & "Watalappam:Rs" & watalappam & vbCrLf & "Pudding:Rs" & pudding & vbCrLf & "Swis Roll:Rs" & swisroll & vbCrLf & "total:Rs" & total)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim trasql As String
        Dim result As Integer
        Dbconnect()
        Try


            trasql = " INSERT INTO `info`(`Mix Fruit`, `Awacado`, `Mango`, `Ice Coffee`, `Faluda`, `Lime`, `Milk Shake`, `Pashion`, `Mocktail`, `Pineapple`, `cake`, `Ice Cream`, `Donuts`, `Dodol`, `Asmi`, `Kokis`, `watalappam`, `Pudding`, `swisroll`) VALUES(@mixfruit,@awacado,@mango,@icecoffee,@faluda,@lime,@milkshake,@pashion,@mocktail,@pineapple,@cake,@icecream,@donuts,@dodol,@asmi,@kokis,@watalappam,@pudding,@swisroll)"

            Dim command As New MySqlCommand(trasql, conn)

            command.Parameters.AddWithValue("@mixfruit", TextBox1.Text)
            command.Parameters.AddWithValue("@awacado", TextBox2.Text)
            command.Parameters.AddWithValue("@mango", TextBox3.Text)
            command.Parameters.AddWithValue("@icecoffee", TextBox4.Text)
            command.Parameters.AddWithValue("@faluda", TextBox5.Text)
            command.Parameters.AddWithValue("@lime", TextBox6.Text)
            command.Parameters.AddWithValue("@milkshake", TextBox7.Text)
            command.Parameters.AddWithValue("@pashion", TextBox8.Text)
            command.Parameters.AddWithValue("@mocktail", TextBox9.Text)
            command.Parameters.AddWithValue("@pineapple", TextBox10.Text)
            command.Parameters.AddWithValue("@cake", TextBox11.Text)
            command.Parameters.AddWithValue("@icecream", TextBox12.Text)
            command.Parameters.AddWithValue("@donuts", TextBox13.Text)
            command.Parameters.AddWithValue("@dodol", TextBox14.Text)
            command.Parameters.AddWithValue("@asmi", TextBox15.Text)
            command.Parameters.AddWithValue("@kokis", TextBox16.Text)
            command.Parameters.AddWithValue("@watalappam", TextBox17.Text)
            command.Parameters.AddWithValue("@pudding", TextBox18.Text)
            command.Parameters.AddWithValue("@swisroll", TextBox19.Text)

            result = command.ExecuteNonQuery()
            If result = 1 Then
                MsgBox("Successful")
            Else
                MsgBox("Error")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class