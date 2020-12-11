Imports System.IO
Imports System
Imports System.IO.File
Imports System.Text.RegularExpressions
Module christmas_code
    Sub Run_christmas_script()
        Console.Clear()
        Dim listofstuff As New List(Of String)
        listofstuff = importdata()
        Dim linenom, rownom, nom1, nom2, total As Integer
        Dim listofpassports As New List(Of String)
        Dim inpassport As Boolean = True
        Dim passport As String = ""
        For Each line In listofstuff
            If line = "" Then
                listofpassports.Add(passport)
                passport = ""
            Else
                passport += line
            End If
        Next
        total = 0
        For Each passport In listofpassports
            Dim x As MatchCollection = Regex.Matches(passport, "byr|iyr|eyr|hgt|hcl|ecl|pid")
            If x.Count = 7 Then
                total += 1
            End If
        Next
        Console.WriteLine(total)
        Console.WriteLine("done")
        Console.ReadLine()
    End Sub
    Function importdata() As List(Of String)
        Dim listofstuff As New List(Of String)
        Using sr As StreamReader = New StreamReader("input.txt")
            Dim line As String
            Dim x As Int16 = 0
            Dim lineCount = File.ReadAllLines("input.txt").Length
            line = sr.ReadLine
            While x <> lineCount
                listofstuff.Add(line)
                x = x + 1
                line = sr.ReadLine
            End While
            importdata = listofstuff
        End Using
    End Function
End Module
