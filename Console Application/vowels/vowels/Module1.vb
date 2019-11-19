Module Module1
    Dim s As Char
    Dim flag As Integer
    Sub Main()
        Console.WriteLine("Enter a Character : ")
        s = Console.ReadLine
        s = Char.ToLower(s)
        Select Case s
            Case "a"
                Console.WriteLine("Vowel")
            Case "e"
                Console.WriteLine("Vowel")
            Case "i"
                Console.WriteLine("Vowel")
            Case "o"
                Console.WriteLine("Vowel")
            Case "u"
                Console.WriteLine("Vowel")
            Case Else
                Console.WriteLine("Consonant")
        End Select
        Console.ReadKey()
    End Sub

End Module
