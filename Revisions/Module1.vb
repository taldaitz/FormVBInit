Module Module1

    Sub Main()

        'mardi()
        bienvenue()

        Console.ReadLine()
    End Sub

    Sub mardi()
        Dim maVariable As String = "gobelet"
        Dim nombre As Integer = 5

        If maVariable.Length > 16 Then
            Console.WriteLine(maVariable)
        End If

        For i As Integer = 1 To nombre
            Console.WriteLine(maVariable)
        Next

        Dim compteur As Integer = 0

        Console.WriteLine("Saisir des mots et terminer par /exit :")

        While True
            Dim mot As String = Console.ReadLine()

            If mot = "/exit" Then
                Console.WriteLine("Vous avez écrit {0} mots.", compteur)
                Exit While
            End If

            compteur += 1
        End While
    End Sub

End Module
