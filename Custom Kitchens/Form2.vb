Imports System.IO
Imports System.Text
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Double = Form1.lblTotalCost.Text
        Dim path As String = "C:\test.txt"
        Dim receipt As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("This is some text in the file.")
        receipt.Write(info, 0, info.Length)
        receipt.Close()
        MsgBox($"Charged Ksh{amount}",)
        Me.Close()
    End Sub
End Class