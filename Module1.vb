Imports System.IO
Imports System
Imports System.IO.File
Module Module1
    Sub Initial_menu()
        Dim initial_menu_items() As String = {"restuant menu", "binary conversion", "types of gates demonstration", "random number generator", "text letter analisis"}
        Dim i As Integer = 0
        Dim userinput As Integer
        Console.Clear()
        Console.WriteLine("--------Inital Menu--------")
        For Each item In initial_menu_items
            Console.WriteLine(i & ": " & item)
            i += 1
        Next
        Console.WriteLine("Please enter your selection")
        Try
            userinput = Console.ReadLine()
        Catch ex As Exception
            Exit Sub
        End Try

        Select Case CInt(userinput)
            Case 0
                Run_resturant_menu()
            Case 1
                Run_convert_number()
            Case 3
                Run_random_number_gen()
            Case 4
                Run_text_analisis()
            Case Else
                Return
        End Select

    End Sub


    Sub Main()
        Run_christmas_script()
        While True
            Initial_menu()
        End While
    End Sub




End Module
