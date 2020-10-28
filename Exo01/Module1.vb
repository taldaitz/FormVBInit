Module Module1

    Sub Main()

        'Console.WriteLine("Veuillez saisir votre nom")

        'Dim nom As String = Console.ReadLine()

        ''Console.WriteLine("Bonjour " & nom & "!") --> contatenation : à éviter
        'Console.WriteLine("Bonjour {0}!", nom)



        Console.WriteLine("Veuillez saisir deux chiffres :")

        Dim chiffre1 As Integer = Console.ReadLine()
        Dim chiffre2 As Integer = Console.ReadLine()

        Console.WriteLine("Le résultat est {0}", chiffre1 + chiffre2)



        Console.ReadLine()

    End Sub

End Module
