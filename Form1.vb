Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        'declare and initialize variables
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decAverageSpeed As Decimal
        Dim decTotalSpeed As Decimal = 0D
        Dim strInputMes As String = "Enter the Internet Speed #"
        Dim strInputHeading As String = "Internet Speed"
        Dim strNormalMes As String = "Enter the Internet Speed #"
        Dim strNonNumMes As String = "ERROR - Enter a nuber for the Internet Speed for #"
        Dim strNegativenNumMes As String = "ERROR - Enter a positive number for #"

        'declare and initializw loop variable
        Dim strCancel As String = ""
        Dim intMaxNum As Integer = 10
        Dim intNumEntries As Integer = 1

        'capture the first value
        strSpeed = InputBox(strInputMes & intNumEntries, strInputHeading, " ")

        'loop until 10 speed values are input or Cancel button is clicked
        Do Until intNumEntries > intMaxNum Or strSpeed = strCancel
            'check nonnum
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                'check positive
                If decSpeed > 0 Then
                    'add value
                    lstSpeed.Items.Add(decSpeed)
                    decTotalSpeed += decSpeed
                    intNumEntries += 1
                    strInputMes = strNormalMes
                Else
                    strInputMes = strNegativenNumMes

                End If
            Else
                strInputMes = strNonNumMes
            End If
            'Check if 10 values entered
            If intNumEntries <= intMaxNum Then
                strSpeed = InputBox(strInputMes & intNumEntries, strInputHeading, " ")

            End If
        Loop
        'Cal avg
        If intNumEntries > 1 Then
            lblAverage.Visible = True
            decAverageSpeed = decTotalSpeed / (intNumEntries - 1)
            lblAverage.Text = "Average Internet Speed is " & decAverageSpeed.ToString("F2") & " Mbps"
        End If

        btnSpeed.Enabled = False
    End Sub
End Class
