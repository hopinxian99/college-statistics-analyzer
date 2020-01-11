Imports System.Data
Imports System
Imports System.Data.SqlClient

'Button1 = Impoer Data
'Button2=


Public Class Form1
    Dim avg As Double
    Dim sum As Integer
    Dim max As Integer
    Dim mix As Integer



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "C:\\Users\\hopin\\Documents\\programing\\kapasiti-dewan-peperiksaan.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [kolej$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView1.DataSource = dataSet.Tables(0)

            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

            
        End Try
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("SansSerif", 10, FontStyle.Bold)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim index As Integer
        index = DataGridView1.CurrentCell.RowIndex

        ' delete the selected row
        DataGridView1.Rows.RemoveAt(index)

    End Sub

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(2).Value

        Next
        avg = sum / DataGridView1.Rows.Count()
        Label1.Text = avg.ToString()
        Label2.Text = sum.ToString()
    End Sub

  
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
       
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(3).Value

        Next
        avg = sum / DataGridView1.Rows.Count()
        Label3.Text = Format(avg.ToString("###.##"))
        Label4.Text = sum.ToString()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = (From row As DataGridViewRow In DataGridView1.Rows
                           Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                           Select Convert.ToInt32(row.Cells(2).FormattedValue)).Max().ToString()
        TextBox3.Text = (From row As DataGridViewRow In DataGridView1.Rows
                           Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                           Select Convert.ToInt32(row.Cells(3).FormattedValue)).Max().ToString()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox2.Text = (From row As DataGridViewRow In DataGridView1.Rows
                           Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                           Select Convert.ToInt32(row.Cells(2).FormattedValue)).Min().ToString()
        TextBox4.Text = (From row As DataGridViewRow In DataGridView1.Rows
                           Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                           Select Convert.ToInt32(row.Cells(3).FormattedValue)).Min().ToString()

    End Sub



    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim style As New DataGridViewCellStyle()
        style.Font = New Font(DataGridView1.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        style.BackColor = Color.Yellow
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value.ToString() IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.TextBox5.Text) AndAlso cell.Value.ToString().Contains(Me.TextBox5.Text) Then
                    cell.Style = style
                Else
                    cell.Style = DataGridView1.DefaultCellStyle
                End If

            Next
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim msg As String = "Do you want to Exit?"
        Dim title As String = "Exit Application"

        If MessageBox.Show(msg, title, MessageBoxButtons.YesNo, _
                         MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = _
                     Windows.Forms.DialogResult.Yes Then

            Me.Close()
        End If

    End Sub
End Class
