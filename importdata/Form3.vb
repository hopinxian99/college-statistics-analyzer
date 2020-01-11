Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssigmentDataSet1._kolej_' table. You can move, or remove it, as needed.
        Me.Kolej_TableAdapter.Fill(Me.AssigmentDataSet1._kolej_)

    End Sub
End Class