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
        Dim rr(6) As String
        'byr(Birth Year) - four digits; at least 1920 And at most 2002.
        rr(0) = "byr:([1][9][2-9][0-9]|([2][0][0][0-2]))"
        'iyr(Issue Year) - four digits; at least 2010 And at most 2020.
        rr(1) = "iyr:([2][0][1][0-9]|([2][0][2][0]))"
        'eyr(Expiration Year) - four digits; at least 2020 And at most 2030
        rr(2) = "eyr:([2][0][2][0-9]|([2][0][3][0]))"
        'hgt(Height) - a number followed by either cm Or 
        rr(3) = "hgt:([1]([5-8][0-9]|[9][0-3])cm|(59|[6][0-9]|7[0-6])in)"
        'If cm Then, the number must be at least 150 And at most 193
        'If in, the number must be at least 59 And at most 76.
        'hcl(Hair Color) - a # followed by exactly six characters 0-9 Or a-f.
        rr(4) = "hcl:#[a-f0-9]{6}"
        'ecl(Eye Color) - exactly one Of: amb blu brn gry grn hzl oth.
        rr(5) = "ecl:(amb|blu|brn|gry|grn|hzl|oth)"
        'pid(Passport ID) - a nine-digit number, including leading zeroes.
        rr(6) = "pid:([0-9]{9})(?![0-9])"
        'cid(Country ID) - ignored, missing Or Not.

        Dim x As MatchCollection
        total = 0
        For Each passport In listofpassports
            Dim criteria As Int16 = 0
            For Each r In rr
                x = Regex.Matches(passport, r)
                If x.Count = 1 Then
                    criteria += 1
                End If
            Next
            If criteria = 7 Then
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
