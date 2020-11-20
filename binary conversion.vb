Imports System.IO
Module binary_conversion
    Function ConvertingNumberToBinary(number) As String
        Dim powerfound As Boolean = False
        Dim divide, modd As Int64
        Dim binarynum As String = ""
        While Not powerfound
            divide = number \ 2
            modd = number Mod 2
            If modd = 1 Then
                binarynum = binarynum + "1"
            Else
                binarynum = binarynum + "0"
            End If
            number = divide
            If divide = 0 Then
                powerfound = True
            End If
        End While
        ConvertingNumberToBinary = StrReverse(binarynum)
    End Function

    Function ConvertingNumberToDenary(binary As String) As Long
        Dim reversedbinary As String = StrReverse(binary)
        Dim x As Integer = 0
        Dim number As Long = 0
        For Each val As String In reversedbinary
            number += Integer.Parse(val) * (2 ^ x)
            x += 1
        Next
        ConvertingNumberToDenary = number
    End Function
    Sub Convert_number_to_binary()
        Console.Clear()
        Dim number1 As Int64
        Console.WriteLine("please enter a number to convert to binary")
        number1 = Console.ReadLine()
        Dim Number As String = ConvertingNumberToBinary(number1)
        Console.WriteLine(Number)
        Console.WriteLine("")
        Console.WriteLine(number1)
        Console.ReadLine()
    End Sub
    Sub Convert_number_to_denary()
        Console.Clear()
        Dim number1 As Int64
        Console.WriteLine("please enter a binary number to convert to denary")
        number1 = Console.ReadLine()
        Dim Number As String = ConvertingNumberToDenary(number1)
        Console.WriteLine(Number)
        Console.WriteLine("")
        Console.WriteLine(number1)
        Console.ReadLine()
    End Sub
    Sub Run_convert_number()
        Dim choice As String
        Console.Clear()
        Console.WriteLine("to convert binary number to denary press 1 or press 2 to convert denary to binary")
        choice = Console.ReadLine()
        Select Case choice
            Case "1"
                Convert_number_to_denary()
            Case "2"
                Convert_number_to_binary()
            Case Else
                Console.WriteLine()
                Console.WriteLine("nothing entered returning to main menu")
                Threading.Thread.Sleep(2000)
        End Select
    End Sub
End Module
