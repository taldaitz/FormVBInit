Module Module1

    Sub Main()

        While True
            Console.Clear()
            Console.WriteLine("Selectionnez une option : ")
            Console.WriteLine("1 - Compteur de lettres")
            Console.WriteLine("2 - Pair ou Impair")
            Console.WriteLine("3 - Cadrillage")
            Console.WriteLine("4 - Addition")
            Console.WriteLine("0 - Quitter")
            Console.WriteLine()

            Dim choix As String = getString()

            If choix = "0" Then Exit While

            Console.Clear()
            Select Case choix
                Case "1"
                    compteurLettres()
                Case "2"
                    pairOuImpair()
                Case "3"
                    cadrillage()
                Case "4"
                    addition()
            End Select

            Console.ReadLine()


        End While

    End Sub

    Sub compteurLettres()
        Console.WriteLine("Veuillez saisir un mot : ")
        Dim mot As String = getString()

        If mot.Trim().Length > 15 Then
            Console.WriteLine("Mot trop long")
        Else
            Console.WriteLine("{0} - {1} lettres", mot.Trim(), mot.Trim().Length)
        End If
    End Sub

    Sub pairOuImpair()
        Console.WriteLine("Veuillez saisir un chiffre : ")
        Dim chiffre As Integer = getInt()

        If chiffre Mod 2 = 0 Then
            Console.WriteLine("Ce chiffre est pair.")
        Else
            Console.WriteLine("Ce chiffre est impair.")
        End If
    End Sub

    Sub cadrillage()
        Console.WriteLine("Veuillez saisir des dimensions :")
        Dim nbLignes As Integer = getInt()
        Dim nbColonnes As Integer = getInt()

        For j As Integer = 1 To nbLignes
            For i As Integer = 1 To nbColonnes ' 1 <= nbColonnes
                Console.Write("[]")
            Next
            Console.Write(Environment.NewLine)
        Next
    End Sub

    Sub addition()
        Console.WriteLine("Veuillez saisir deux chiffres :")

        Dim chiffre1 As Integer = getInt()
        Dim chiffre2 As Integer = getInt()

        Console.WriteLine("Le résultat est {0}", chiffre1 + chiffre2)
    End Sub

    Function getString() As String
        Return Console.ReadLine()
    End Function

    Function getInt() As Integer
        Dim saisie As String = Console.ReadLine()
        Dim chiffre As Integer

        Integer.TryParse(saisie, chiffre)

        If chiffre = Nothing Then
            Console.WriteLine("Ceci n'est pas un chiffre. Veuillez saisir une valeur numérique.")
            chiffre = getInt()
        End If

        Return chiffre

    End Function

End Module
