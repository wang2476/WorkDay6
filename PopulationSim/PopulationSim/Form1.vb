Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim pop As Integer
        Dim yea As Integer
        pop = 7000
        yea = 2012

        Do While (pop > 6)
            pop = CInt(pop / 2)
            yea = yea - 50

        Loop

        MessageBox.Show("This year is " & yea)


    End Sub
End Class
