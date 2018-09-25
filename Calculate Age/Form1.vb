Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' How to make (declare) a variable '
        Dim firstName As String ' String is the variable type for text '
        ' assign it a value
        firstName = "Nairah"

        ' You can declare more than one variable on one line '
        Dim year, month As Integer ' Integers are pos/neg whole numbers '

        ' initialize variables '
        year = 2000
        month = 1

        ' you can declare and initialize all in one line
        Dim yearsOld As Integer = 0

        firstName = InputBox("Enter your name:")

        year = numYear.Value
        month = cmbMonth.SelectedIndex + 1

        MessageBox.Show(firstName & " was born in  " & month & " of " & year)

        yearsOld = Date.Today.Year - year

        'check if birth month is later than current month
        If Date.Today.Month <= month Then
            yearsOld = yearsOld - 1 ' decrease yearsOld by 1
        End If

        MessageBox.Show(firstName & " is " & yearsOld & " years old")



    End Sub
End Class
