
Public Class Form2
    Dim msg As String = "Enter all details Correctly"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkEmptyFields() Then
            Dim amount As Double = Form1.lblTotalCost.Text
            Dim output As String
            output = $"  CUSTOM KITCHENS {vbCrLf}{vbCrLf}Name : {txbFName.Text} {txbLName.Text} {vbCrLf}Amount : {amount}{vbCrLf}"
            Dim filePath As String
            filePath = System.IO.Path.Combine(
            My.Computer.FileSystem.SpecialDirectories.Desktop, "KitchenReceipt.txt")
            My.Computer.FileSystem.WriteAllText(filePath, output, False)
            MsgBox("Purchase Completed")
            Me.Close()
            Form1.Close()
        Else
            lblError.Text = msg
        End If
    End Sub
    ''' <summary>
    ''' creating a function that verifies all inputs have no blanks 
    ''' and verifies and validates all numeric inputs
    ''' </summary>
    ''' <returns></returns>
    Function checkEmptyFields() As Boolean
        Dim fname, lname, email, address, town, street, house, cardType As String
        Dim month, year, postal As Integer
        Dim cardNumber As Long

        Try
            fname = txbFName.Text
            lname = txbLName.Text
            email = tbxEmail.Text
            address = tbxaddress.Text
            town = tbxTown.Text
            street = tbxStreet.Text
            house = tbxHouseNumber.Text
            cardType = cboCreditCard.Text
            month = tbxMonth.Text
            year = tbxYear.Text
            postal = tbxPostal.Text
            cardNumber = txbCreditNumber.Text
            If (fname.Equals("") Or lname.Equals("") Or email.Equals("") Or address.Equals("") Or town.Equals("") Or street.Equals("") Or house.Equals("")) Then
                Throw New Exception("No blank fileds")
            End If
            If month > 12 Or year < 20 Then
                Throw New Exception("Enter correct date")
            End If
            If cardNumber < 1000000000000000 Or cardType.Equals("") Then
                Throw New Exception("Enter correct card details")
            End If
        Catch ex As InvalidCastException
            msg = "Please fill in all details correctly"
            Return False
        Catch ex As Exception
            msg = ex.Message
            Return False
        End Try
        Return True
    End Function
End Class