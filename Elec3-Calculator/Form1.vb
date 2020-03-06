Public Class Form1
    Private Function UpdateText(buttonText As String) As String
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = buttonText
        Else
            RichTextBox1.Text += buttonText
        End If

        Return RichTextBox1.Text
    End Function


    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        RichTextBox1.Text = UpdateText(Button20.Text)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        RichTextBox1.Text = UpdateText(Button19.Text)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        RichTextBox1.Text = UpdateText(Button18.Text)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        RichTextBox1.Text = UpdateText(Button14.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RichTextBox1.Text = UpdateText(Button15.Text)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RichTextBox1.Text = UpdateText(Button16.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        RichTextBox1.Text = UpdateText(Button10.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RichTextBox1.Text = UpdateText(Button11.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RichTextBox1.Text = UpdateText(Button12.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox1.Text = "0"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RichTextBox1.Text = "0"
    End Sub
End Class
