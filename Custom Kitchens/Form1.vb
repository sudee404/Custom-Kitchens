Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim kitchenStyle() As String = {"Small L-shaped Kitchen", "Medium L-shaped Kitchen", "Large L-shaped Kitchen", "Small Straight Kitchen", "Medium Straight Kitchen", "Large Straight Kitchen", "Large Island Kitchen"}
        Dim counterTops() As String = {"Laminate", "Wood Block", "Granite"}
        Dim prices() As Integer = {3500, 4500, 5750, 6500, 7750, 9500, 8250, 9500, 12500, 1000, 1500, 2200, 5250, 6200, 8000, 6750, 8500, 11000, 12500, 15000, 23000}
        Dim lengthsArray() As Integer = {250, 350, 450, 150, 350, 500, 450}
        Dim widthsArray() As Integer = {180, 240, 350, 60, 60, 60, 450}
        Dim msg As String


        msg = verify()
        lblRemarks.Text = msg
        'checking if empty statement came back
        If (msg <> (" ")) Then
            'if not empty the form stays as is
            gbxCustomerDetails.Visible = True
        Else
            'else  new groupbox is loaded and made visible
            gbxKitchenStyles.Visible = True

        End If

        'get 
        Dim chosenByDim() As String = getKitchenByDIm(rmLength.Text, rmWidth.Text, kitchenStyle, lengthsArray, widthsArray)
        Dim chosen() As String = getKitchenByPrice(rmBudget.Text, chosenByDim, prices)
        Dim top, left As Integer
        top = 15
        left = 6
        For counter = 0 To (chosen.Length - 1)

            Dim rdb As New RadioButton()
            rdb.Text = chosen(counter)
            rdb.Top = top
            rdb.Left = left
            rdb.Width = 147
            gbxBox.Controls.Add(rdb)
            top += 20
            If (rdb.Text.Equals("")) Then
                gbxBox.Controls.Remove(rdb)
            End If

        Next


    End Sub

    Function getKitchenByPrice(ByVal budget As Integer, ByVal chosen As String(), ByVal prices As Integer()) As String()
        Dim x, y, count As Integer
        Dim chosenStyles(7) As String
        x = 0
        y = 0

        For counter = 0 To 6
            count = 0
            For counter1 = 1 To 3
                If (budget > prices(x)) Then
                    count += 1
                End If
                x += 1
            Next
            If (count >= 1) Then
                chosenStyles(y) = chosen(counter)
                y += 1
            End If
        Next
        Return chosenStyles
    End Function


    Function getKitchenByDIm(ByVal length As Integer, ByVal width As Integer, ByVal kitchenstyle() As String,
                             ByVal lengthArr() As Integer, ByVal widthArr() As Integer) As String()
        Dim chosenStyles(7) As String
        Dim cnt As Integer = 0
        Dim cntprice As Integer = 0
        For counter = 0 To 6
            If (length > lengthArr(counter) And width > widthArr(counter)) Then
                chosenStyles(cnt) = kitchenstyle(counter)
                cnt += 1
            End If
        Next
        Return chosenStyles

    End Function
    Function verify() As String
        'this function verifies input by ensuring no characters except numbers can be accepted
        'create a msg variable to hold return type message
        Dim length, width, budget As Integer
        Dim msg As String
        'initialize with an empty text as default
        msg = " "
        'catch and raise exceptions with a try statement
        Try
            length = rmLength.Text
            width = rmWidth.Text
            budget = rmBudget.Text
            'throw an exception when validateData() function returns as True
            If (validateData(length, width, budget)) Then
                Throw New Exception("Enter values within applicable ranges")
            End If

        Catch ex As InvalidCastException
            'this code catches all conversion error exceptions that could break the code
            msg = "Enter correct values"
            Return msg
        Catch ez As Exception
            'this one catches all other exceptions including our own
            msg = ez.Message
            Return msg

        End Try
        'return the final message
        'an empty string means a correct validation has occured
        Return msg
    End Function

    Function validateData(ByVal lnth As Integer, ByVal width As Integer, ByVal budget As Integer) As Boolean
        'This function validates data with an if statement and returns true for incorrect input and false for correct input
        If (lnth < 150 Or width < 20 Or budget < 1000) Or (lnth > 600 Or width > 600 Or budget > 25000) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
