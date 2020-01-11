Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Form1.ShowDialog()
        End If


        If RadioButton2.Checked Then
            Form2.Show()
        ElseIf RadioButton3.Checked Then
            Form3.Show()
        End If

    End Sub


End Class