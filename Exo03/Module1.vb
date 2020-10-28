Module Module1

    Sub Main()
        'civilite avec boucles
        'Console.WriteLine("Veuillez saisir votre civilité :")

        'While True
        '    Dim civilite As String = Console.ReadLine()

        '    Select Case civilite
        '        Case "Mme"
        '            Console.WriteLine("Bonjour, vous avez un joli chapeau.")

        '        Case "Mr"
        '            Console.WriteLine("Bonjour, vous avez une jolie moustache.")

        '        Case "Dr"
        '            Console.WriteLine("Bonjour, quoi de neuf ?")

        '        Case Else
        '            Console.WriteLine("Cette civilité n'est pas gérée. Veuillez en saisir une autre")
        '            Continue While
        '    End Select

        '    Exit While
        'End While

        'Cadrillage
        'Console.WriteLine("Veuillez saisir des dimensions :")
        'Dim nbLignes As Integer = Console.ReadLine()
        'Dim nbColonnes As Integer = Console.ReadLine()

        'For j As Integer = 1 To nbLignes
        '    For i As Integer = 1 To nbColonnes ' 1 <= nbColonnes
        '        Console.Write("[]")
        '    Next
        '    'Console.WriteLine()
        '    Console.Write(Environment.NewLine)
        'Next

        Dim mots As String = ""
        Console.WriteLine("Veuillez saisir des mots et terminer par /exit :")

        While True
            Dim mot = Console.ReadLine()

            If mot = "/exit" Then Exit While

            mots &= String.Format("{0} - {1} lettres{2}", mot, mot.Length, Environment.NewLine)

        End While

        Console.WriteLine(mots)

        Console.ReadLine()

    End Sub

End Module
