Module Module1

    Sub Main()
        'Civilité
        'Console.WriteLine("Veuillez saisir votre civilité :")
        'Dim civilite As String = Console.ReadLine()

        'Select Case civilite
        '    Case "Mme"
        '        Console.WriteLine("Bonjour, vous avez un joli chapeau.")

        '    Case "Mr"
        '        Console.WriteLine("Bonjour, vous avez une jolie moustache.")

        '    Case "Dr"
        '        Console.WriteLine("Bonjour, quoi de neuf ?")

        '    Case Else
        '        Console.WriteLine("Cette civilité n'est pas gérée.")
        'End Select


        'Pair ou impair
        'Console.WriteLine("Veuillez saisir un chiffre : ")
        'Dim chiffre As Integer = Console.ReadLine()

        'If chiffre Mod 2 = 0 Then
        '    Console.WriteLine("Ce chiffre est pair.")
        'Else
        '    Console.WriteLine("Ce chiffre est impair.")
        'End If


        'Compte lettre
        Console.WriteLine("Veuillez saisir un mot : ")
        Dim mot As String = Console.ReadLine()

        If mot.Trim().Length > 15 Then
            Console.WriteLine("Mot trop long")
        Else
            Console.WriteLine("{0} - {1} lettres", mot.Trim(), mot.Trim().Length)
        End If



        Console.ReadLine()

    End Sub

End Module
