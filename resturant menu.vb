Imports System.IO
Imports System
Imports System.IO.File
Module resturant_menu
    Public listofmenuitems As New List(Of meal)
    Sub ImportMenu()
        Using sr As StreamReader = New StreamReader("menu.txt")
            Dim line As String
            Dim x As Int16 = 0
            Dim lineCount = File.ReadAllLines("menu.txt").Length
            line = sr.ReadLine
            While x <> lineCount
                Dim parts As Array = line.Split(", ")
                listofmenuitems.Add(New meal(parts(0), CInt(parts(1)), parts(2)))

                x = x + 1
                line = sr.ReadLine
            End While
        End Using
        'For Each item As meal In listofmenuitems
        '    item.PrintItem()
        'Next
    End Sub



    Sub MenuItems()
        Dim I As Int16 = 1
        For Each item As meal In listofmenuitems
            Console.WriteLine("{0}: {1}", I, item.name)
            I += 1
        Next
    End Sub

    Sub Run_resturant_menu()
        Dim neworder As New order
        Dim x As Boolean = True
        ImportMenu()
        While x
            Dim userchoice As String
            Console.Clear()
            Console.WriteLine("--------Menu--------")
            MenuItems()
            Console.WriteLine("--------Menu--------")
            Console.WriteLine("please enter the number that you want to order and leave blank to checkout")
            userchoice = Console.ReadLine()
            Try
                neworder.AddItem(CInt(userchoice))
            Catch ex As Exception
                Console.WriteLine("error")
            End Try
            If userchoice = "" Or userchoice = "x" Then
                neworder.printOrder(listofmenuitems)
                x = False
            End If
            Console.WriteLine("press enter to continue")
            Console.ReadLine()
        End While
    End Sub
End Module
