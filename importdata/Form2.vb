Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssigmentDataSet._kolej_' table. You can move, or remove it, as needed.
        Me.Kolej_TableAdapter.Fill(Me.AssigmentDataSet._kolej_)

    End Sub
End Class