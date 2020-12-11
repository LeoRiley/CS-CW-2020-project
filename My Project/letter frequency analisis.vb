Imports System.IO
Imports System
Imports System.IO.File
Module letter_frequency_analisis
    Dim charcount(127) As Integer
    Dim charcountpercent(127) As Double
    Function Import_text() As String
        Dim text As String = ""
        'create a stream reader
        Dim filename As String = "EnglishSample.txt"
        Using sr As StreamReader = New StreamReader(filename)
            Dim linecount = File.ReadAllLines(filename).Length
            Dim x As Long = 0
            Dim line As String = sr.ReadLine
            While x <> linecount
                text += line.ToLower()
                x = x + 1
                line = sr.ReadLine
            End While
        End Using
        Import_text = text
    End Function

    Sub count_characters(text As String)
        Dim asci2 As Integer
        For Each i As String In text
            asci2 = Asc(i)
            charcount(asci2) += 1
        Next
    End Sub

    Sub convert_to_percentage()
        Dim totalcharcount As Int64
        For Each i As Integer In charcount
            totalcharcount += i
        Next
        Dim x As Integer = 0
        For Each i As Integer In charcount
            charcountpercent(x) = i / totalcharcount * 100
            x += 1
        Next
    End Sub

    Sub createchart()
        Dim i As Integer = 0
        Dim character As String
        Dim resultstring As String
        For Each value In charcountpercent

            resultstring = ""
            character = Chr(i).ToString
            resultstring = StrDup(CInt(value * 10), "-")
            If resultstring <> "" Then
                Console.WriteLine(character + ":" + resultstring + character + " " + value.ToString)

            End If
            i += 1
        Next
        Console.ReadLine()

    End Sub
    Sub Run_text_analisis()
        Dim text As String = Import_text()
        count_characters(text)
        convert_to_percentage()
        createchart()
    End Sub


End Module
