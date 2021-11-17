Public Class Form1
    Dim kitchenStyle() As String = {"Small L-shaped Kitchen", "Medium L-shaped Kitchen", "Large L-shaped Kitchen", "Small Straight Kitchen", "Medium Straight Kitchen", "Large Straight Kitchen", "Large Island Kitchen"}
    Dim prices() As Integer = {3500, 4500, 5750, 6500, 7750, 9500, 8250, 9500, 12500, 1000, 1500, 2200, 5250, 6200, 8000, 6750, 8500, 11000, 12500, 15000, 23000}
    Dim Counterpricelist(3) As Integer
    Dim total As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

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



            'get 
            Dim chosen() As String = getKitchenByDIm(rmLength.Text, rmWidth.Text, rmBudget.Text, prices, kitchenStyle, lengthsArray, widthsArray)

            Dim top, left As Integer
            top = 10
            left = 6
            For counter = 0 To (chosen.Length - 1)

                Dim rdb As New RadioButton()
                rdb.Text = chosen(counter)
                rdb.Top = top
                rdb.Left = left
                rdb.Width = 147
                rdb.Height = 25
                gbxBox.Controls.Add(rdb)
                top += 22
                If (rdb.Text.Equals("")) Then
                    gbxBox.Controls.Remove(rdb)
                End If

            Next

        End If
    End Sub



    Function getKitchenByDIm(ByVal length As Integer, ByVal width As Integer, ByVal budget As Integer, ByVal prices() As Integer, ByVal kitchenstyle() As String,
                             ByVal lengthArr() As Integer, ByVal widthArr() As Integer) As String()
        Dim chosenStyles(7) As String
        Dim lowest() As Integer = {prices(0), prices(3), prices(6), prices(9), prices(12), prices(15), prices(18)}
        Dim cnt As Integer = 0
        Dim cntprice As Integer = 0

        For counter = 0 To 6
            If (length > lengthArr(counter) And width > widthArr(counter)) And budget > lowest(counter) Then

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
            msg = "Enter all values correctly"
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


    Private Sub loadCounters(sender As Object, e As EventArgs) Handles gbxBox.MouseMove

        Dim rdb As New RadioButton()


        For Each rdb In gbxBox.Controls
            If rdb.Checked Then
                gbxCountertops.Visible = True
                Dim priceofcountertops() As Integer = getKitchenPrices(prices, rdb.Text, kitchenStyle)
                Counterpricelist = priceofcountertops
                lblLaminatePrice.Text = priceofcountertops(0)
                lblWoodPrice.Text = priceofcountertops(1)
                lblGranitePrice.Text = priceofcountertops(2)

            End If
        Next

    End Sub

    Function getKitchenPrices(ByVal prices() As Integer, ByVal text As String, ByVal styles() As String) As Integer()

        Dim n, pricelist(3) As Integer
        n = 0
        If (text.Equals(styles(0))) Then
            For counter = 0 To 2
                pricelist(n) = prices(counter)
                n += 1
            Next
        ElseIf (text.Equals(styles(1))) Then
            For counter = 3 To 5
                pricelist(n) = prices(counter)
                n += 1
            Next
        ElseIf (text.Equals(styles(2))) Then
            For counter = 6 To 8
                pricelist(n) = prices(counter)
                n += 1
            Next
        ElseIf (text.Equals(styles(3))) Then
            For counter = 9 To 11
                pricelist(n) = prices(counter)
                n += 1
            Next
        ElseIf (text.Equals(styles(4))) Then
            For counter = 12 To 14
                pricelist(n) = prices(counter)
                n += 1
            Next
        ElseIf (text.Equals(styles(5))) Then
            For counter = 15 To 17
                pricelist(n) = prices(counter)
                n += 1
            Next
        ElseIf (text.Equals(styles(6))) Then
            For counter = 18 To 20
                pricelist(n) = prices(counter)
                n += 1
            Next

        End If

        Return pricelist

    End Function

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim counterTopPrice As Integer = 0

        If gbxCountertops.Visible Then

            If rdbLaminate.Checked Then
                counterTopPrice = Counterpricelist(0)

            ElseIf rdbWoodBlk.Checked Then
                counterTopPrice = Counterpricelist(1)

            ElseIf rdbGranite.Checked Then
                counterTopPrice = Counterpricelist(2)

            Else
                lblRemind.Text = "Please select a countertop to proceed"


            End If
        Else
            lblRemind.Text = "Please select a kitchen style to proceed"
            'add more code

        End If



    End Sub


End Class