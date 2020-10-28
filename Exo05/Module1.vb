Module Module1

    Sub Main()

        Console.WriteLine("Veuillez saisir 5 chiffres :")
        Dim chiffres(4) As Integer
        Dim somme As Integer

        For i As Integer = 0 To 4
            Try
                Dim chiffre As Integer = Console.ReadLine()

                If chiffre = 3 Then
                    Throw New Exception("On accepte pas les 3.")
                End If

                chiffres(i) = chiffre
            Catch ex As Exception
                Console.WriteLine("Problème : {0}", ex.Message)
                chiffres(i) = 0
            Finally
                Console.WriteLine("Cumul : {0}", chiffres.Sum())
            End Try

        Next

        For Each element As Integer In chiffres
            somme += element
        Next

        Console.WriteLine("Resultat : {0}", somme)

        Console.ReadLine()

    End Sub

End Module
