Module Module1

    Sub Main()

        'Dim chiffres() As Integer = {4, 89, 127, -5, 12, -89, 43, 279, -16, 89}
        'Dim max As Integer = Integer.MinValue
        'Dim min As Integer = Integer.MaxValue
        'Dim sum As Integer = 0


        'For Each chiffre As Integer In chiffres
        '    If chiffre > max Then max = chiffre
        '    If chiffre < min Then min = chiffre

        '    sum += chiffre
        'Next

        'Console.WriteLine("Valeur Max : {0} ({1})", max, chiffres.Max())
        'Console.WriteLine("Valeur Min : {0} ({1})", min, chiffres.Min())
        'Console.WriteLine("Valeur Moyenne : {0} ({1})", sum / chiffres.Length, chiffres.Average())


        'Console.WriteLine("Saisir des mots : ")
        'Dim mot As String
        'Dim tabMots(10) As String 'index : 0 => 9

        'For i As Integer = 0 To 9
        '    mot = Console.ReadLine()

        '    If mot = "/exit" Then Exit For

        '    tabMots(i) = String.Format("{0} - {1} lettres", mot, mot.Length)
        'Next

        'Array.Sort(tabMots)

        'For Each element As String In tabMots
        '    If element = Nothing Then Continue For

        '    Console.WriteLine(element)
        'Next

        Console.ReadLine()

    End Sub

End Module
