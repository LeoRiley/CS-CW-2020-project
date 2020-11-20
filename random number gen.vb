Module random_number_gen
    Sub Run_random_number_gen()
        Console.Clear()
        Randomize()
        Console.WriteLine(Int(100 * Rnd()))
        Console.ReadLine()
    End Sub
End Module
