Module encryption
    Sub encrypter()

    End Sub
    Sub decrypter()

    End Sub
    Sub choseencryptionordecryption()
        Dim x As Boolean = True
        Dim input As String
        Dim inputasint As Integer = 0
        While x
            Console.Clear()
            Console.WriteLine("to encrypt text press 1 to decrypt text press 2 to quit press enter:")
            input = Console.ReadLine()
            Try
                inputasint = CInt(input)
            Catch ex As Exception
            End Try
            Select Case inputasint
                Case 1
                    encrypter()
                Case 2
                    decrypter()
            End Select
        End While
    End Sub
    Sub Run_encryption()
        choseencryptionordecryption()
    End Sub

End Module
