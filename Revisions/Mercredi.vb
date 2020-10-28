Imports System.IO

Module Mercredi

    Sub bienvenue()
        'Console.WriteLine("Veuillez saisir vos noms et prénoms (3 max.) :")
        'Dim nom As String = Console.ReadLine()
        'Dim tabPrenoms(2) As String
        'Dim prenoms As String = ""

        'For i As Integer = 0 To 2
        '    Dim prenom As String = Console.ReadLine()
        '    If prenom = "" Then Exit For
        '    tabPrenoms(i) = prenom
        'Next

        'prenoms = String.Join(", ", tabPrenoms)

        'transformer(nom, prenoms)

        'Console.WriteLine("Bonjour {0} {1}", nom, prenoms)


        'Dim noms As New List(Of String)
        'noms.Add("Thomas")
        'noms.Add("Robert")
        'noms.Add("Jean")

        'For Each element As String In noms
        '    Console.WriteLine(element)
        'Next

        lireFichier()

    End Sub

    Sub transformer(ByRef nom As String, ByRef prenoms As String)
        nom = nom.ToUpper()
        prenoms = prenoms.ToLower().Trim()
    End Sub


    Sub ecrireFichier()

        Dim writer As New StreamWriter("test.txt", True)

        writer.WriteLine("Ligne de test")

        writer.Close()

    End Sub

    Sub lireFichier()

        Dim reader As New StreamReader("test.txt")

        While reader.EndOfStream = False
            Dim ligne = reader.ReadLine()
            Console.WriteLine(ligne)
        End While

        reader.Close()
    End Sub

End Module
